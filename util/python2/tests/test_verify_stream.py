# -*- coding: utf-8 -*-
import unittest
from io import BytesIO

from alibabacloud_oss_util.verify_stream import VerifyStream

import os

root_path = os.path.dirname(os.path.dirname(__file__))
file_path = os.path.join(root_path, 'tests/test.txt')


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
        self.assertEqual('17540041809663704128', res.get('crc'))

        content = b''
        while True:
            r = v.read()
            if r:
                content += r
            else:
                break
        self.assertEqual(b'tests test', content)
        self.assertEqual('WwpvIEGlrSYPX1YJmi0o2A==', res.get('md5'))
        self.assertEqual('17540041809663704128', res.get('crc'))

        res = {}
        v = VerifyStream(f, res)
        content = b''
        while True:
            r = v.read(1)
            if r:
                content += r
            else:
                break

        self.assertEqual(b'tests test', content)
        self.assertEqual('WwpvIEGlrSYPX1YJmi0o2A==', res.get('md5'))
        self.assertEqual('17540041809663704128', res.get('crc'))
        f.close()

        io = BytesIO(b'test')
        res = {}
        v = VerifyStream(io, res)
        content = b''
        for i in v:
            content += i
        self.assertEqual(b'test', content)
        self.assertEqual('CY9rzUYh03PK3k6DJie09g==', res.get('md5'))
        self.assertEqual('18020588380933092773', res.get('crc'))
        self.assertEqual(4, v.__len__())
