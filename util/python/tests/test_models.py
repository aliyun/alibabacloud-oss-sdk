import unittest

from alibabacloud_oss_util import models


class TestClient(unittest.TestCase):
    def test_RuntimeOptions(self):
        opt = models.RuntimeOptions()
        opt.validate()
        map = {
            'autoretry': 'autoretry',
            'ignoreSSL': 'ignoreSSL',
            'maxAttempts': 'maxAttempts',
            'backoffPolicy': 'backoffPolicy',
            'backoffPeriod': 'backoffPeriod',
            'readTimeout': 'readTimeout',
            'connectTimeout': 'connectTimeout',
            'localAddr': 'localAddr',
            'httpProxy': 'httpProxy',
            'httpsProxy': 'httpsProxy',
            'noProxy': 'noProxy',
            'maxIdleConns': 'maxIdleConns',
            'socks5Proxy': 'socks5Proxy',
            'socks5NetWork': 'socks5NetWork',
            'uploadLimitSpeed': 'uploadLimitSpeed',
            'listener': 'listener',
        }
        opt.from_map(map)
        self.assertEqual('ignoreSSL', opt.ignore_ssl)
        self.assertEqual(map, opt.to_map())

    def test_ErrorResponse(self):
        er = models.ErrorResponse(
            code='200',
            message='success',
            request_id='id',
            host_id='host',
        )
        er.validate()
        self.assertEqual('200', er.to_map()['Code'])
        er.from_map({})
        self.assertEqual(None, er.code)