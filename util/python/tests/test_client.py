import unittest

from alibabacloud_oss_util.client import Client
from Tea.request import TeaRequest

file_path = 'tests/test.txt'


class TestClient(unittest.TestCase):
    def test_get_err_message(self):
        message = "<?xml version='1.0' encoding='UTF-8'?><Error><Code>401</Code></Error>"
        result = Client.get_err_message(message)
        self.assertEqual(401, result.code)

        message = "<?xml version='1.0' encoding='UTF-8'?><Code>401</Code>"
        result = Client.get_err_message(message)
        self.assertEqual(None, result.code)

    def test_to_meta(self):
        header = {
            'size': '1',
            'test.key.id': '9527'
        }
        result = Client.to_meta(header, 'test.key.')
        self.assertEqual('9527', result.get('test.key.id'))
        self.assertTrue('test.key.size' in result)

    def test_parse_meta(self):
        header = {
            'size': '1',
            'test.key.id': '9527'
        }
        result = Client.parse_meta(None, 'test.key')
        self.assertEqual(0, len(result))

        result = Client.parse_meta(header, 'test.key.')
        self.assertEqual('1', result.get('size'))
        self.assertTrue('id' in result)

    def test_get_content_type(self):
        self.assertEqual('image/webp', Client.get_content_type('test.webp'))
        self.assertEqual('audio/mpeg', Client.get_content_type('test.mp3'))

    def test_get_content_md5(self):
        self.assertEqual('CY9rzUYh03PK3k6DJie09g==', Client.get_content_md5("test", True))

    def test_encode(self):
        value = 'test/encode/h%f'
        self.assertEqual(value, Client.encode(value, None))
        self.assertEqual('test/encode/aCVm', Client.encode(value, 'Base64'))
        self.assertEqual('test/encode/h%25f', Client.encode(value, 'UrlEncode'))
        self.assertEqual(value, Client.encode(value, ''))

    def test_decode(self):
        res = Client.decode('test', None)
        self.assertEqual('test', res)

        res = Client.decode('test/dXJs', 'Base64Decode')
        self.assertEqual('test/url', res)

        res = Client.decode('test/url', 'UrlDecode')
        self.assertEqual('test/url', res)

        res = Client.decode('test/url/rr', 'test')
        self.assertEqual('test/url/rr', res)

    def test_get_host(self):
        host = Client.get_host(None, None, None, None)
        self.assertEqual('oss-cn-hangzhou.aliyuncs.com', host)

        host = Client.get_host("testBucket", "region", "endpoint", "ip")
        self.assertEqual("endpoint/testBucket", host)

        host = Client.get_host("testBucket", "region", "endpoint", "cname")
        self.assertEqual("endpoint", host)

        host = Client.get_host("testBucket", "region", "endpoint", "test")
        self.assertEqual("testBucket.endpoint", host)

    def test_inject(self):
        fr = open(file_path, 'r')
        d = {}
        v = Client.inject(fr, d)
        res = v.read(1024)
        v.close()
        self.assertEqual({'md5': 'WwpvIEGlrSYPX1YJmi0o2A==', 'crc': 146865635.8}, d)
        self.assertEqual('tests test', res)
        frb = open(file_path, 'rb')
        d = {}
        v2 = Client.inject(frb, d)
        res = v2.read()
        v2.close()
        self.assertEqual({'md5': 'WwpvIEGlrSYPX1YJmi0o2A==', 'crc': 146865635.8}, d)
        self.assertEqual(b'tests test', res)

    def test_get_signature(self):
        request = TeaRequest()
        signature = Client.get_signature(request, "bucket", "accessKeyId",
                                         "accessKeySecret", "v2", None)
        self.assertEqual("OSS2 AccessKeyId:accessKeyId,Signature:61mT0P8eZxBI5cfj7YfqctSz4Zwtp0sltgTS5JZZc1M=",
                         signature)

        request = TeaRequest()
        request.pathname = 'test?aa'
        request.headers = {
            'x-oss-test': 'test',
            'content-type': 'type',
            'content-md5': 'md5',
        }
        request.query = {
            'testQuery': 'testQuery',
            'queryKey': 'queryValue',
            "x-oss-test": "test"
        }
        res = Client.get_signature(request, 'test', 'ak', 'sk', 'v2', None)
        self.assertEqual('OSS2 AccessKeyId:ak,Signature:QNGIXVU4Qg0dxuBmVaN8q//ceXf15fmdTEaIK7R3od4=', res)

        request = TeaRequest()
        request.headers = {
            'x-oss-test': 'test',
            'content-type': 'type',
            'content-md5': 'md5'
        }
        request.query = {
            'testQuery': 'testQuery',
            'queryKey': 'queryValue',
            'x-oss-process': 'value'
        }
        res = Client.get_signature(request, 'test', "ak", "sk", "v1", None)
        self.assertEqual('OSS ak:q9lSDGVH1VmpjMTGSwUZn3tg3J4=', res)
