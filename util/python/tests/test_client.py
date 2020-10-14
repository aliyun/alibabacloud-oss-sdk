import unittest
import os

from alibabacloud_oss_util.client import Client
from Tea.request import TeaRequest

root_path = os.path.dirname(os.path.dirname(__file__))
file_path = os.path.join(root_path, 'tests/test.txt')


class TestClient(unittest.TestCase):
    def test_get_err_message(self):
        message = "<?xml version='1.0' encoding='UTF-8'?><Error><Code>401</Code></Error>"
        result = Client.get_err_message(message)

        self.assertEqual('401', result.code)

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
        self.assertEqual('', Client.get_content_md5("test", False))

    def test_encode(self):
        value = 'test/encode/h%f'
        self.assertEqual(value, Client.encode(value, None))
        self.assertEqual('test/encode/aCVm', Client.encode(value, 'Base64'))
        self.assertEqual('test/encode/h%25f', Client.encode(value, 'UrlEncode'))
        self.assertEqual(value, Client.encode(value, ''))

    def test_decode(self):
        res = Client.decode('test', None)
        self.assertEqual('test', res)

        res = Client.decode('JjJi', 'Base64Decode')
        self.assertEqual('&2b', res)

        res = Client.decode('path/%262b', 'UrlDecode')
        self.assertEqual('path/&2b', res)

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
        for i in v:
            self.assertEqual('tests test', i)
        v.close()
        self.assertEqual({'md5': 'WwpvIEGlrSYPX1YJmi0o2A==', 'crc': 17540041809663704128}, d)

        frb = open(file_path, 'rb')
        d = {}
        v2 = Client.inject(frb, d)
        for i in v2:
            self.assertEqual(b'tests test', i)
        v2.close()
        self.assertEqual({'md5': 'WwpvIEGlrSYPX1YJmi0o2A==', 'crc': 17540041809663704128}, d)

    def test_get_signature_v1(self):
        request = TeaRequest()
        request.headers = {
            'x-oss-test': 'test',
            'content-type': 'type',
            'content-md5': 'md5'
        }
        request.query = {
            'testQuery': 'testQuery',
            'queryKey': 'queryValue',
            'x-oss-process': 'value',
            'location': 'test'
        }
        res = Client.get_signature(request, 'test', "ak", "sk", "v1", None)
        self.assertEqual('OSS ak:EutyeRVaRDNJSPiaBHmN/Cip8lw=', res)

    def test_get_signature_v2(self):
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
        res = Client.get_signature(request, 'test', 'ak', 'sk', 'v2', ['headers', 'sign2'])
        self.assertEqual(
            'OSS2 AccessKeyId:ak,AdditionalHeaders:headers;'
            'sign2,Signature:l8RDYSFtqTP0NhyoTyrRqAtrnUO6lCjrOF/MK2zV0nU=',
            res
        )

        request.pathname = 'test?zz'
        res = Client.get_signature(request, 'test', 'ak', 'sk', 'v2', ['headers'])
        self.assertEqual(
            'OSS2 AccessKeyId:ak,AdditionalHeaders:headers,Signature:kbg4BGoZbDGm2OBRt1kOTh9z6dToFSg1L55PXTmGdQw=',
            res
        )
