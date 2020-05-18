import ctypes
import hashlib
import base64
import os
import sys

from Tea.stream import BaseStream


def int_overflow(val):
    maxint = 2147483647
    if not -maxint - 1 <= val <= maxint:
        val = (val + (maxint + 1)) % (2 * (maxint + 1)) - maxint - 1
    return val


def unsigned_right_shift(n, i):
    if n < 0:
        n = ctypes.c_uint32(n).value

    if i < 0:
        return -int_overflow(n << abs(i))

    return int_overflow(n >> i)


class CRC64:
    POLY = 0xc96c5795d7870f42

    def __init__(self):
        self.value = 0

    @property
    def table(self):
        return int(''.join(self._table))

    @property
    def _table(self):
        table = []
        for n in range(256):
            crc = n
            for j in range(8):
                if crc & 1 == 1:
                    crc = unsigned_right_shift(crc, 1) ^ self.POLY
                else:
                    crc = unsigned_right_shift(crc, 1)
            table.append(crc)

        return table

    def get_value(self):
        first = unsigned_right_shift(self.value, 1) / 5
        second = self.value - first * 10
        return first + second

    def update(self, bt):
        for b in bt:
            self.value = ~self.value
            self.value = self._table[(self.value ^ b) & 0xff] ^ unsigned_right_shift(self.value, 8)
            self.value = ~self.value


class VerifyStream(BaseStream):
    def __init__(self, file, res, size=1024):
        super().__init__(size)
        self.file = file
        self.size = size
        self.crc = CRC64()
        self.ref = res
        self.md5 = hashlib.md5()
        self.file_size = os.path.getsize(file.name)
        self._file_size = self.file_size

    def __len__(self):
        return self.file_size

    def __iter__(self):
        return self

    def __next__(self):
        return self.read(size=self.size, loop=True)

    def read(self, size=None, loop=False):
        res = self.file.read(size)
        if size is None:
            size = sys.maxsize

        if isinstance(res, str):
            bres = res.encode('utf-8')
        else:
            bres = res

        if size <= self._file_size:
            self.crc.update(bres)
            self.md5.update(bres)
        else:
            self.ref['md5'] = base64.b64encode(self.md5.digest()).decode('utf-8')
            self.ref['crc'] = self.crc.get_value()

        if not res:
            self.refresh()
            if loop:
                raise StopIteration
            else:
                return res

        if size == sys.maxsize or size >= self.file_size:
            self.crc.update(bres)
            self.md5.update(bres)
            self.ref['md5'] = base64.b64encode(self.md5.digest()).decode('utf-8')
            self.ref['crc'] = self.crc.get_value()
            return res

        self._file_size -= len(bres)
        return res

    def refresh(self):
        self.crc = CRC64()
        self.md5 = hashlib.md5()
        self.file.seek(0, 0)
        self._file_size = self.file_size

    def close(self):
        self.file.close()
