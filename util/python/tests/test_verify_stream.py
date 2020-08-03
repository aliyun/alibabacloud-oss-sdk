import unittest
from io import BytesIO

from alibabacloud_oss_util.verify_stream import VerifyStream

file_path = 'test.txt'


class TestVerifyStream(unittest.TestCase):
    def test_verify_stream_read(self):
        f = open(file_path, 'rb')
        res = {}
        v = VerifyStream(f, res)
        content = b''
        for i in v:
            content += i
        self.assertEqual(b'tests test', content)
        self.assertEqual('WwpvIEGlrSYPX1YJmi0o2A==', res.get('md5'))
        self.assertEqual(146865635.8, res.get('crc'))

        content = b''
        while True:
            r = v.read()
            if r:
                content += r
            else:
                break
        self.assertEqual(b'tests test', content)
        self.assertEqual('WwpvIEGlrSYPX1YJmi0o2A==', res.get('md5'))
        self.assertEqual(146865635.8, res.get('crc'))
        v.close()

        io = BytesIO(b'tests test')
        res = {}
        v = VerifyStream(io, res)
        content = b''
        for i in v:
            content += i
        self.assertEqual(b'tests test', content)
        self.assertEqual('WwpvIEGlrSYPX1YJmi0o2A==', res.get('md5'))
        self.assertEqual(146865635.8, res.get('crc'))
