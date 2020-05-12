import unittest

from alibabacloud_oss_util.verify_stream import VerifyStream

file_path = 'tests/test.txt'


class TestVerifyStream(unittest.TestCase):
    def test_verify_stream_read(self):
        f = open(file_path, 'rb')
        res = {}
        v = VerifyStream(f, res)
        self.assertEqual(b'tests test', v.read())
        self.assertEqual('WwpvIEGlrSYPX1YJmi0o2A==', res.get('md5'))
        self.assertEqual(146865635.8, res.get('crc'))
        v.close()
