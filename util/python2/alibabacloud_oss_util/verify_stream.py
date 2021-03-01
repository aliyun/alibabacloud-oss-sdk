import hashlib
import base64
import os
import sys

from _io import BytesIO
from Tea.stream import BaseStream
from Tea.converter import py2


class CRC64(object):
    POLY = (0xC96C5795 << 32) | 0xD7870F42

    def __init__(self):
        self.value = 0

    @property
    def _table(self):
        table = []
        for n in range(256):
            crc = n
            for j in range(8):
                if crc & True:
                    crc = (crc >> 1) & ~(0x8 << 60) ^ self.POLY
                else:
                    crc = (crc >> 1) & ~(0x8 << 60)
            table.append(crc)

        return table

    def get_value(self):
        return str(self.value)

    def update(self, bt):
        for b in bt:
            if py2:
                b = ord(b)
            self.value = ~self.value
            self.value = self._table[(self.value ^ b) & 0xff] ^ (self.value >> 8) & ~(0xff << 56)
            self.value = ~self.value


class VerifyStream(BaseStream):
    MAX_SIZE = 2147483647

    def __init__(self, file, res, size=1024):
        super(VerifyStream, self).__init__(size)
        self.file = file
        self.size = size
        self.crc = CRC64()
        self.ref = res
        self.md5 = hashlib.md5()
        if isinstance(file, BytesIO):
            self.file_size = len(file.getvalue())
        else:
            self.file_size = os.path.getsize(file.name)
        self._file_size = self.file_size

    def __len__(self):
        return self.file_size

    def __iter__(self):
        return self

    def next(self):
        return self.read(size=self.size, loop=True)

    def read(self, size=None, loop=False):
        if size is None:
            size = self.MAX_SIZE

        res = self.file.read(size)

        if size <= self._file_size:
            self.crc.update(res)
            self.md5.update(res)
        else:
            self.ref['md5'] = base64.b64encode(self.md5.digest())
            self.ref['crc'] = self.crc.get_value()

        if not res:
            self.refresh()
            if loop:
                raise StopIteration
            else:
                return res

        if size == sys.maxsize or size >= self.file_size:
            self.crc.update(res)
            self.md5.update(res)
            self.ref['md5'] = base64.b64encode(self.md5.digest())
            self.ref['crc'] = self.crc.get_value()
            return res

        self._file_size -= len(res)
        return res

    def refresh(self):
        self.crc = CRC64()
        self.md5 = hashlib.md5()
        self.file.seek(0, 0)
        self._file_size = self.file_size

    def close(self):
        self.file.close()
