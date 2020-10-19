from Tea.model import TeaModel


class RuntimeOptions(TeaModel):
    def __init__(self, autoretry=False, ignore_ssl=False, max_attempts=0, backoff_policy="", backoff_period=0,
                 read_timeout=0, connect_timeout=0, local_addr="", http_proxy="", https_proxy="", no_proxy="",
                 max_idle_conns=0, socks_5proxy="", socks_5net_work="", upload_limit_speed=0, listener=None):
        self.autoretry = autoretry
        self.ignore_ssl = ignore_ssl
        self.max_attempts = max_attempts
        self.backoff_policy = backoff_policy
        self.backoff_period = backoff_period
        self.read_timeout = read_timeout
        self.connect_timeout = connect_timeout
        self.local_addr = local_addr
        self.http_proxy = http_proxy
        self.https_proxy = https_proxy
        self.no_proxy = no_proxy
        self.max_idle_conns = max_idle_conns
        self.socks_5proxy = socks_5proxy
        self.socks_5net_work = socks_5net_work
        self.upload_limit_speed = upload_limit_speed
        self.listener = listener

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['autoretry'] = self.autoretry
        result['ignoreSSL'] = self.ignore_ssl
        result['maxAttempts'] = self.max_attempts
        result['backoffPolicy'] = self.backoff_policy
        result['backoffPeriod'] = self.backoff_period
        result['readTimeout'] = self.read_timeout
        result['connectTimeout'] = self.connect_timeout
        result['localAddr'] = self.local_addr
        result['httpProxy'] = self.http_proxy
        result['httpsProxy'] = self.https_proxy
        result['noProxy'] = self.no_proxy
        result['maxIdleConns'] = self.max_idle_conns
        result['socks5Proxy'] = self.socks_5proxy
        result['socks5NetWork'] = self.socks_5net_work
        result['uploadLimitSpeed'] = self.upload_limit_speed
        result['listener'] = self.listener
        return result

    def from_map(self, map={}):
        self.autoretry = map.get('autoretry')
        self.ignore_ssl = map.get('ignoreSSL')
        self.max_attempts = map.get('maxAttempts')
        self.backoff_policy = map.get('backoffPolicy')
        self.backoff_period = map.get('backoffPeriod')
        self.read_timeout = map.get('readTimeout')
        self.connect_timeout = map.get('connectTimeout')
        self.local_addr = map.get('localAddr')
        self.http_proxy = map.get('httpProxy')
        self.https_proxy = map.get('httpsProxy')
        self.no_proxy = map.get('noProxy')
        self.max_idle_conns = map.get('maxIdleConns')
        self.socks_5proxy = map.get('socks5Proxy')
        self.socks_5net_work = map.get('socks5NetWork')
        self.upload_limit_speed = map.get('uploadLimitSpeed')
        self.listener = map.get('listener')
        return self
