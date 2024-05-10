import Foundation
import Tea

public class RuntimeOptions : Tea.TeaModel {
    public var autoretry: Bool?

    public var ignoreSSL: Bool?

    public var maxAttempts: Int?

    public var backoffPolicy: String?

    public var backoffPeriod: Int?

    public var readTimeout: Int?

    public var connectTimeout: Int?

    public var localAddr: String?

    public var httpProxy: String?

    public var httpsProxy: String?

    public var noProxy: String?

    public var maxIdleConns: Int?

    public var socks5Proxy: String?

    public var socks5NetWork: String?

    public var uploadLimitSpeed: Int?

    public var listener: Any?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.autoretry != nil {
            map["autoretry"] = self.autoretry!
        }
        if self.ignoreSSL != nil {
            map["ignoreSSL"] = self.ignoreSSL!
        }
        if self.maxAttempts != nil {
            map["maxAttempts"] = self.maxAttempts!
        }
        if self.backoffPolicy != nil {
            map["backoffPolicy"] = self.backoffPolicy!
        }
        if self.backoffPeriod != nil {
            map["backoffPeriod"] = self.backoffPeriod!
        }
        if self.readTimeout != nil {
            map["readTimeout"] = self.readTimeout!
        }
        if self.connectTimeout != nil {
            map["connectTimeout"] = self.connectTimeout!
        }
        if self.localAddr != nil {
            map["localAddr"] = self.localAddr!
        }
        if self.httpProxy != nil {
            map["httpProxy"] = self.httpProxy!
        }
        if self.httpsProxy != nil {
            map["httpsProxy"] = self.httpsProxy!
        }
        if self.noProxy != nil {
            map["noProxy"] = self.noProxy!
        }
        if self.maxIdleConns != nil {
            map["maxIdleConns"] = self.maxIdleConns!
        }
        if self.socks5Proxy != nil {
            map["socks5Proxy"] = self.socks5Proxy!
        }
        if self.socks5NetWork != nil {
            map["socks5NetWork"] = self.socks5NetWork!
        }
        if self.uploadLimitSpeed != nil {
            map["uploadLimitSpeed"] = self.uploadLimitSpeed!
        }
        if self.listener != nil {
            map["listener"] = self.listener!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("autoretry") && dict["autoretry"] != nil {
            self.autoretry = dict["autoretry"] as! Bool
        }
        if dict.keys.contains("ignoreSSL") && dict["ignoreSSL"] != nil {
            self.ignoreSSL = dict["ignoreSSL"] as! Bool
        }
        if dict.keys.contains("maxAttempts") && dict["maxAttempts"] != nil {
            self.maxAttempts = dict["maxAttempts"] as! Int
        }
        if dict.keys.contains("backoffPolicy") && dict["backoffPolicy"] != nil {
            self.backoffPolicy = dict["backoffPolicy"] as! String
        }
        if dict.keys.contains("backoffPeriod") && dict["backoffPeriod"] != nil {
            self.backoffPeriod = dict["backoffPeriod"] as! Int
        }
        if dict.keys.contains("readTimeout") && dict["readTimeout"] != nil {
            self.readTimeout = dict["readTimeout"] as! Int
        }
        if dict.keys.contains("connectTimeout") && dict["connectTimeout"] != nil {
            self.connectTimeout = dict["connectTimeout"] as! Int
        }
        if dict.keys.contains("localAddr") && dict["localAddr"] != nil {
            self.localAddr = dict["localAddr"] as! String
        }
        if dict.keys.contains("httpProxy") && dict["httpProxy"] != nil {
            self.httpProxy = dict["httpProxy"] as! String
        }
        if dict.keys.contains("httpsProxy") && dict["httpsProxy"] != nil {
            self.httpsProxy = dict["httpsProxy"] as! String
        }
        if dict.keys.contains("noProxy") && dict["noProxy"] != nil {
            self.noProxy = dict["noProxy"] as! String
        }
        if dict.keys.contains("maxIdleConns") && dict["maxIdleConns"] != nil {
            self.maxIdleConns = dict["maxIdleConns"] as! Int
        }
        if dict.keys.contains("socks5Proxy") && dict["socks5Proxy"] != nil {
            self.socks5Proxy = dict["socks5Proxy"] as! String
        }
        if dict.keys.contains("socks5NetWork") && dict["socks5NetWork"] != nil {
            self.socks5NetWork = dict["socks5NetWork"] as! String
        }
        if dict.keys.contains("uploadLimitSpeed") && dict["uploadLimitSpeed"] != nil {
            self.uploadLimitSpeed = dict["uploadLimitSpeed"] as! Int
        }
        if dict.keys.contains("listener") && dict["listener"] != nil {
            self.listener = dict["listener"] as! Any
        }
    }
}
