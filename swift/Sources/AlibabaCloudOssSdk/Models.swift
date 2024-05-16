import Foundation
import Tea
import TeaUtils
import AlibabaCloudOSSUtil
import DarabonbaXML
import TeaFileForm
import AlibabaCloudCredentials

public class Config : Tea.TeaModel {
    public var type: String?

    public var securityToken: String?

    public var accessKeyId: String?

    public var accessKeySecret: String?

    public var endpoint: String?

    public var protocol_: String?

    public var regionId: String?

    public var userAgent: String?

    public var hostModel: String?

    public var signatureVersion: String?

    public var isEnableMD5: Bool?

    public var isEnableCrc: Bool?

    public var readTimeout: Int?

    public var connectTimeout: Int?

    public var localAddr: String?

    public var httpProxy: String?

    public var httpsProxy: String?

    public var noProxy: String?

    public var socks5Proxy: String?

    public var socks5NetWork: String?

    public var maxIdleConns: Int?

    public var addtionalHeaders: [String]?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.accessKeyId, "accessKeyId")
        try self.validateRequired(self.accessKeySecret, "accessKeySecret")
        if self.regionId != nil {
            try self.validatePattern(self.regionId, "regionId", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.type != nil {
            map["type"] = self.type!
        }
        if self.securityToken != nil {
            map["securityToken"] = self.securityToken!
        }
        if self.accessKeyId != nil {
            map["accessKeyId"] = self.accessKeyId!
        }
        if self.accessKeySecret != nil {
            map["accessKeySecret"] = self.accessKeySecret!
        }
        if self.endpoint != nil {
            map["endpoint"] = self.endpoint!
        }
        if self.protocol_ != nil {
            map["protocol"] = self.protocol_!
        }
        if self.regionId != nil {
            map["regionId"] = self.regionId!
        }
        if self.userAgent != nil {
            map["userAgent"] = self.userAgent!
        }
        if self.hostModel != nil {
            map["hostModel"] = self.hostModel!
        }
        if self.signatureVersion != nil {
            map["signatureVersion"] = self.signatureVersion!
        }
        if self.isEnableMD5 != nil {
            map["isEnableMD5"] = self.isEnableMD5!
        }
        if self.isEnableCrc != nil {
            map["isEnableCrc"] = self.isEnableCrc!
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
        if self.socks5Proxy != nil {
            map["socks5Proxy"] = self.socks5Proxy!
        }
        if self.socks5NetWork != nil {
            map["socks5NetWork"] = self.socks5NetWork!
        }
        if self.maxIdleConns != nil {
            map["maxIdleConns"] = self.maxIdleConns!
        }
        if self.addtionalHeaders != nil {
            map["addtionalHeaders"] = self.addtionalHeaders!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("type") && dict["type"] != nil {
            self.type = dict["type"] as! String
        }
        if dict.keys.contains("securityToken") && dict["securityToken"] != nil {
            self.securityToken = dict["securityToken"] as! String
        }
        if dict.keys.contains("accessKeyId") && dict["accessKeyId"] != nil {
            self.accessKeyId = dict["accessKeyId"] as! String
        }
        if dict.keys.contains("accessKeySecret") && dict["accessKeySecret"] != nil {
            self.accessKeySecret = dict["accessKeySecret"] as! String
        }
        if dict.keys.contains("endpoint") && dict["endpoint"] != nil {
            self.endpoint = dict["endpoint"] as! String
        }
        if dict.keys.contains("protocol") && dict["protocol"] != nil {
            self.protocol_ = dict["protocol"] as! String
        }
        if dict.keys.contains("regionId") && dict["regionId"] != nil {
            self.regionId = dict["regionId"] as! String
        }
        if dict.keys.contains("userAgent") && dict["userAgent"] != nil {
            self.userAgent = dict["userAgent"] as! String
        }
        if dict.keys.contains("hostModel") && dict["hostModel"] != nil {
            self.hostModel = dict["hostModel"] as! String
        }
        if dict.keys.contains("signatureVersion") && dict["signatureVersion"] != nil {
            self.signatureVersion = dict["signatureVersion"] as! String
        }
        if dict.keys.contains("isEnableMD5") && dict["isEnableMD5"] != nil {
            self.isEnableMD5 = dict["isEnableMD5"] as! Bool
        }
        if dict.keys.contains("isEnableCrc") && dict["isEnableCrc"] != nil {
            self.isEnableCrc = dict["isEnableCrc"] as! Bool
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
        if dict.keys.contains("socks5Proxy") && dict["socks5Proxy"] != nil {
            self.socks5Proxy = dict["socks5Proxy"] as! String
        }
        if dict.keys.contains("socks5NetWork") && dict["socks5NetWork"] != nil {
            self.socks5NetWork = dict["socks5NetWork"] as! String
        }
        if dict.keys.contains("maxIdleConns") && dict["maxIdleConns"] != nil {
            self.maxIdleConns = dict["maxIdleConns"] as! Int
        }
        if dict.keys.contains("addtionalHeaders") && dict["addtionalHeaders"] != nil {
            self.addtionalHeaders = dict["addtionalHeaders"] as! [String]
        }
    }
}

public class PutBucketLifecycleRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class LifecycleConfiguration : Tea.TeaModel {
            public class Rule : Tea.TeaModel {
                public class Expiration : Tea.TeaModel {
                    public var days: Int?

                    public var createdBeforeDate: String?

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
                        if self.days != nil {
                            map["Days"] = self.days!
                        }
                        if self.createdBeforeDate != nil {
                            map["CreatedBeforeDate"] = self.createdBeforeDate!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("Days") && dict["Days"] != nil {
                            self.days = dict["Days"] as! Int
                        }
                        if dict.keys.contains("CreatedBeforeDate") && dict["CreatedBeforeDate"] != nil {
                            self.createdBeforeDate = dict["CreatedBeforeDate"] as! String
                        }
                    }
                }
                public class Transition : Tea.TeaModel {
                    public var days: Int?

                    public var storageClass: String?

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
                        if self.days != nil {
                            map["Days"] = self.days!
                        }
                        if self.storageClass != nil {
                            map["StorageClass"] = self.storageClass!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("Days") && dict["Days"] != nil {
                            self.days = dict["Days"] as! Int
                        }
                        if dict.keys.contains("StorageClass") && dict["StorageClass"] != nil {
                            self.storageClass = dict["StorageClass"] as! String
                        }
                    }
                }
                public class AbortMultipartUpload : Tea.TeaModel {
                    public var days: Int?

                    public var createdBeforeDate: String?

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
                        if self.days != nil {
                            map["Days"] = self.days!
                        }
                        if self.createdBeforeDate != nil {
                            map["CreatedBeforeDate"] = self.createdBeforeDate!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("Days") && dict["Days"] != nil {
                            self.days = dict["Days"] as! Int
                        }
                        if dict.keys.contains("CreatedBeforeDate") && dict["CreatedBeforeDate"] != nil {
                            self.createdBeforeDate = dict["CreatedBeforeDate"] as! String
                        }
                    }
                }
                public class Tag : Tea.TeaModel {
                    public var key: String?

                    public var value: String?

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
                        if self.key != nil {
                            map["Key"] = self.key!
                        }
                        if self.value != nil {
                            map["Value"] = self.value!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("Key") && dict["Key"] != nil {
                            self.key = dict["Key"] as! String
                        }
                        if dict.keys.contains("Value") && dict["Value"] != nil {
                            self.value = dict["Value"] as! String
                        }
                    }
                }
                public var expiration: PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.Expiration?

                public var transition: PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.Transition?

                public var abortMultipartUpload: PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.AbortMultipartUpload?

                public var tag: PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.Tag?

                public var iD: String?

                public var prefix_: String?

                public var status: String?

                public override init() {
                    super.init()
                }

                public init(_ dict: [String: Any]) {
                    super.init()
                    self.fromMap(dict)
                }

                public override func validate() throws -> Void {
                    try self.expiration?.validate()
                    try self.transition?.validate()
                    try self.abortMultipartUpload?.validate()
                    try self.tag?.validate()
                }

                public override func toMap() -> [String : Any] {
                    var map = super.toMap()
                    if self.expiration != nil {
                        map["Expiration"] = self.expiration?.toMap()
                    }
                    if self.transition != nil {
                        map["Transition"] = self.transition?.toMap()
                    }
                    if self.abortMultipartUpload != nil {
                        map["AbortMultipartUpload"] = self.abortMultipartUpload?.toMap()
                    }
                    if self.tag != nil {
                        map["Tag"] = self.tag?.toMap()
                    }
                    if self.iD != nil {
                        map["ID"] = self.iD!
                    }
                    if self.prefix_ != nil {
                        map["Prefix"] = self.prefix_!
                    }
                    if self.status != nil {
                        map["Status"] = self.status!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Expiration") && dict["Expiration"] != nil {
                        var model = PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.Expiration()
                        model.fromMap(dict["Expiration"] as! [String: Any])
                        self.expiration = model
                    }
                    if dict.keys.contains("Transition") && dict["Transition"] != nil {
                        var model = PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.Transition()
                        model.fromMap(dict["Transition"] as! [String: Any])
                        self.transition = model
                    }
                    if dict.keys.contains("AbortMultipartUpload") && dict["AbortMultipartUpload"] != nil {
                        var model = PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.AbortMultipartUpload()
                        model.fromMap(dict["AbortMultipartUpload"] as! [String: Any])
                        self.abortMultipartUpload = model
                    }
                    if dict.keys.contains("Tag") && dict["Tag"] != nil {
                        var model = PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule.Tag()
                        model.fromMap(dict["Tag"] as! [String: Any])
                        self.tag = model
                    }
                    if dict.keys.contains("ID") && dict["ID"] != nil {
                        self.iD = dict["ID"] as! String
                    }
                    if dict.keys.contains("Prefix") && dict["Prefix"] != nil {
                        self.prefix_ = dict["Prefix"] as! String
                    }
                    if dict.keys.contains("Status") && dict["Status"] != nil {
                        self.status = dict["Status"] as! String
                    }
                }
            }
            public var rule: [PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule]?

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
                if self.rule != nil {
                    var tmp : [Any] = []
                    for k in self.rule! {
                        tmp.append(k.toMap())
                    }
                    map["Rule"] = tmp
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Rule") && dict["Rule"] != nil {
                    var tmp : [PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule] = []
                    for v in dict["Rule"] as! [Any] {
                        var model = PutBucketLifecycleRequest.Body.LifecycleConfiguration.Rule()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.rule = tmp
                }
            }
        }
        public var lifecycleConfiguration: PutBucketLifecycleRequest.Body.LifecycleConfiguration?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.lifecycleConfiguration, "lifecycleConfiguration")
            try self.lifecycleConfiguration?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.lifecycleConfiguration != nil {
                map["LifecycleConfiguration"] = self.lifecycleConfiguration?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("LifecycleConfiguration") && dict["LifecycleConfiguration"] != nil {
                var model = PutBucketLifecycleRequest.Body.LifecycleConfiguration()
                model.fromMap(dict["LifecycleConfiguration"] as! [String: Any])
                self.lifecycleConfiguration = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketLifecycleRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketLifecycleRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketLifecycleResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class DeleteMultipleObjectsRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class Delete : Tea.TeaModel {
            public class Object : Tea.TeaModel {
                public var key: String?

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
                    if self.key != nil {
                        map["Key"] = self.key!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Key") && dict["Key"] != nil {
                        self.key = dict["Key"] as! String
                    }
                }
            }
            public var object: [DeleteMultipleObjectsRequest.Body.Delete.Object]?

            public var quiet: String?

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
                if self.object != nil {
                    var tmp : [Any] = []
                    for k in self.object! {
                        tmp.append(k.toMap())
                    }
                    map["Object"] = tmp
                }
                if self.quiet != nil {
                    map["Quiet"] = self.quiet!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Object") && dict["Object"] != nil {
                    var tmp : [DeleteMultipleObjectsRequest.Body.Delete.Object] = []
                    for v in dict["Object"] as! [Any] {
                        var model = DeleteMultipleObjectsRequest.Body.Delete.Object()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.object = tmp
                }
                if dict.keys.contains("Quiet") && dict["Quiet"] != nil {
                    self.quiet = dict["Quiet"] as! String
                }
            }
        }
        public var delete: DeleteMultipleObjectsRequest.Body.Delete?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.delete, "delete")
            try self.delete?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.delete != nil {
                map["Delete"] = self.delete?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Delete") && dict["Delete"] != nil {
                var model = DeleteMultipleObjectsRequest.Body.Delete()
                model.fromMap(dict["Delete"] as! [String: Any])
                self.delete = model
            }
        }
    }
    public class Header : Tea.TeaModel {
        public var encodingType: String?

        public var contentLength: String?

        public var contentMD5: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.contentLength, "contentLength")
            try self.validateRequired(self.contentMD5, "contentMD5")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.encodingType != nil {
                map["Encoding-type"] = self.encodingType!
            }
            if self.contentLength != nil {
                map["Content-Length"] = self.contentLength!
            }
            if self.contentMD5 != nil {
                map["Content-MD5"] = self.contentMD5!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Encoding-type") && dict["Encoding-type"] != nil {
                self.encodingType = dict["Encoding-type"] as! String
            }
            if dict.keys.contains("Content-Length") && dict["Content-Length"] != nil {
                self.contentLength = dict["Content-Length"] as! String
            }
            if dict.keys.contains("Content-MD5") && dict["Content-MD5"] != nil {
                self.contentMD5 = dict["Content-MD5"] as! String
            }
        }
    }
    public var bucketName: String?

    public var body: DeleteMultipleObjectsRequest.Body?

    public var header: DeleteMultipleObjectsRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = DeleteMultipleObjectsRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = DeleteMultipleObjectsRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class DeleteMultipleObjectsResponse : Tea.TeaModel {
    public class DeleteResult : Tea.TeaModel {
        public class Deleted : Tea.TeaModel {
            public var key: String?

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
                if self.key != nil {
                    map["Key"] = self.key!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Key") && dict["Key"] != nil {
                    self.key = dict["Key"] as! String
                }
            }
        }
        public var quiet: String?

        public var encodingType: String?

        public var deleted: [DeleteMultipleObjectsResponse.DeleteResult.Deleted]?

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
            if self.quiet != nil {
                map["Quiet"] = self.quiet!
            }
            if self.encodingType != nil {
                map["EncodingType"] = self.encodingType!
            }
            if self.deleted != nil {
                var tmp : [Any] = []
                for k in self.deleted! {
                    tmp.append(k.toMap())
                }
                map["Deleted"] = tmp
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Quiet") && dict["Quiet"] != nil {
                self.quiet = dict["Quiet"] as! String
            }
            if dict.keys.contains("EncodingType") && dict["EncodingType"] != nil {
                self.encodingType = dict["EncodingType"] as! String
            }
            if dict.keys.contains("Deleted") && dict["Deleted"] != nil {
                var tmp : [DeleteMultipleObjectsResponse.DeleteResult.Deleted] = []
                for v in dict["Deleted"] as! [Any] {
                    var model = DeleteMultipleObjectsResponse.DeleteResult.Deleted()
                    if v != nil {
                        model.fromMap(v as! [String: Any])
                    }
                    tmp.append(model)
                }
                self.deleted = tmp
            }
        }
    }
    public var requestId: String?

    public var deleteResult: DeleteMultipleObjectsResponse.DeleteResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.deleteResult, "deleteResult")
        try self.deleteResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.deleteResult != nil {
            map["DeleteResult"] = self.deleteResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("DeleteResult") && dict["DeleteResult"] != nil {
            var model = DeleteMultipleObjectsResponse.DeleteResult()
            model.fromMap(dict["DeleteResult"] as! [String: Any])
            self.deleteResult = model
        }
    }
}

public class PutBucketRefererRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class RefererConfiguration : Tea.TeaModel {
            public class RefererList : Tea.TeaModel {
                public var referer: [String]?

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
                    if self.referer != nil {
                        map["Referer"] = self.referer!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Referer") && dict["Referer"] != nil {
                        self.referer = dict["Referer"] as! [String]
                    }
                }
            }
            public var refererList: PutBucketRefererRequest.Body.RefererConfiguration.RefererList?

            public var allowEmptyReferer: Bool?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.refererList?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.refererList != nil {
                    map["RefererList"] = self.refererList?.toMap()
                }
                if self.allowEmptyReferer != nil {
                    map["AllowEmptyReferer"] = self.allowEmptyReferer!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("RefererList") && dict["RefererList"] != nil {
                    var model = PutBucketRefererRequest.Body.RefererConfiguration.RefererList()
                    model.fromMap(dict["RefererList"] as! [String: Any])
                    self.refererList = model
                }
                if dict.keys.contains("AllowEmptyReferer") && dict["AllowEmptyReferer"] != nil {
                    self.allowEmptyReferer = dict["AllowEmptyReferer"] as! Bool
                }
            }
        }
        public var refererConfiguration: PutBucketRefererRequest.Body.RefererConfiguration?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.refererConfiguration, "refererConfiguration")
            try self.refererConfiguration?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.refererConfiguration != nil {
                map["RefererConfiguration"] = self.refererConfiguration?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("RefererConfiguration") && dict["RefererConfiguration"] != nil {
                var model = PutBucketRefererRequest.Body.RefererConfiguration()
                model.fromMap(dict["RefererConfiguration"] as! [String: Any])
                self.refererConfiguration = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketRefererRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketRefererRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketRefererResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutBucketWebsiteRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class WebsiteConfiguration : Tea.TeaModel {
            public class IndexDocument : Tea.TeaModel {
                public var suffix: String?

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
                    if self.suffix != nil {
                        map["Suffix"] = self.suffix!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Suffix") && dict["Suffix"] != nil {
                        self.suffix = dict["Suffix"] as! String
                    }
                }
            }
            public class ErrorDocument : Tea.TeaModel {
                public var key: String?

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
                    if self.key != nil {
                        map["Key"] = self.key!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Key") && dict["Key"] != nil {
                        self.key = dict["Key"] as! String
                    }
                }
            }
            public class RoutingRules : Tea.TeaModel {
                public class RoutingRule : Tea.TeaModel {
                    public class Condition : Tea.TeaModel {
                        public class IncludeHeader : Tea.TeaModel {
                            public var key: String?

                            public var equals: String?

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
                                if self.key != nil {
                                    map["Key"] = self.key!
                                }
                                if self.equals != nil {
                                    map["Equals"] = self.equals!
                                }
                                return map
                            }

                            public override func fromMap(_ dict: [String: Any]) -> Void {
                                if dict.keys.contains("Key") && dict["Key"] != nil {
                                    self.key = dict["Key"] as! String
                                }
                                if dict.keys.contains("Equals") && dict["Equals"] != nil {
                                    self.equals = dict["Equals"] as! String
                                }
                            }
                        }
                        public var includeHeader: PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Condition.IncludeHeader?

                        public var keyPrefixEquals: String?

                        public var httpErrorCodeReturnedEquals: String?

                        public override init() {
                            super.init()
                        }

                        public init(_ dict: [String: Any]) {
                            super.init()
                            self.fromMap(dict)
                        }

                        public override func validate() throws -> Void {
                            try self.includeHeader?.validate()
                        }

                        public override func toMap() -> [String : Any] {
                            var map = super.toMap()
                            if self.includeHeader != nil {
                                map["IncludeHeader"] = self.includeHeader?.toMap()
                            }
                            if self.keyPrefixEquals != nil {
                                map["KeyPrefixEquals"] = self.keyPrefixEquals!
                            }
                            if self.httpErrorCodeReturnedEquals != nil {
                                map["HttpErrorCodeReturnedEquals"] = self.httpErrorCodeReturnedEquals!
                            }
                            return map
                        }

                        public override func fromMap(_ dict: [String: Any]) -> Void {
                            if dict.keys.contains("IncludeHeader") && dict["IncludeHeader"] != nil {
                                var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Condition.IncludeHeader()
                                model.fromMap(dict["IncludeHeader"] as! [String: Any])
                                self.includeHeader = model
                            }
                            if dict.keys.contains("KeyPrefixEquals") && dict["KeyPrefixEquals"] != nil {
                                self.keyPrefixEquals = dict["KeyPrefixEquals"] as! String
                            }
                            if dict.keys.contains("HttpErrorCodeReturnedEquals") && dict["HttpErrorCodeReturnedEquals"] != nil {
                                self.httpErrorCodeReturnedEquals = dict["HttpErrorCodeReturnedEquals"] as! String
                            }
                        }
                    }
                    public class Redirect : Tea.TeaModel {
                        public class MirrorHeaders : Tea.TeaModel {
                            public class Set_ : Tea.TeaModel {
                                public var key: String?

                                public var value: String?

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
                                    if self.key != nil {
                                        map["Key"] = self.key!
                                    }
                                    if self.value != nil {
                                        map["Value"] = self.value!
                                    }
                                    return map
                                }

                                public override func fromMap(_ dict: [String: Any]) -> Void {
                                    if dict.keys.contains("Key") && dict["Key"] != nil {
                                        self.key = dict["Key"] as! String
                                    }
                                    if dict.keys.contains("Value") && dict["Value"] != nil {
                                        self.value = dict["Value"] as! String
                                    }
                                }
                            }
                            public var set_: PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders.Set_?

                            public var passAll: Bool?

                            public var pass: String?

                            public var remove: String?

                            public override init() {
                                super.init()
                            }

                            public init(_ dict: [String: Any]) {
                                super.init()
                                self.fromMap(dict)
                            }

                            public override func validate() throws -> Void {
                                try self.set_?.validate()
                            }

                            public override func toMap() -> [String : Any] {
                                var map = super.toMap()
                                if self.set_ != nil {
                                    map["Set"] = self.set_?.toMap()
                                }
                                if self.passAll != nil {
                                    map["PassAll"] = self.passAll!
                                }
                                if self.pass != nil {
                                    map["Pass"] = self.pass!
                                }
                                if self.remove != nil {
                                    map["Remove"] = self.remove!
                                }
                                return map
                            }

                            public override func fromMap(_ dict: [String: Any]) -> Void {
                                if dict.keys.contains("Set") && dict["Set"] != nil {
                                    var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders.Set_()
                                    model.fromMap(dict["Set"] as! [String: Any])
                                    self.set_ = model
                                }
                                if dict.keys.contains("PassAll") && dict["PassAll"] != nil {
                                    self.passAll = dict["PassAll"] as! Bool
                                }
                                if dict.keys.contains("Pass") && dict["Pass"] != nil {
                                    self.pass = dict["Pass"] as! String
                                }
                                if dict.keys.contains("Remove") && dict["Remove"] != nil {
                                    self.remove = dict["Remove"] as! String
                                }
                            }
                        }
                        public var mirrorHeaders: PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders?

                        public var redirectType: String?

                        public var passQueryString: Bool?

                        public var mirrorURL: String?

                        public var mirrorPassQueryString: Bool?

                        public var mirrorFollowRedirect: Bool?

                        public var mirrorCheckMd5: Bool?

                        public var protocol_: String?

                        public var hostName: String?

                        public var httpRedirectCode: String?

                        public var replaceKeyPrefixWith: String?

                        public var replaceKeyWith: String?

                        public override init() {
                            super.init()
                        }

                        public init(_ dict: [String: Any]) {
                            super.init()
                            self.fromMap(dict)
                        }

                        public override func validate() throws -> Void {
                            try self.mirrorHeaders?.validate()
                        }

                        public override func toMap() -> [String : Any] {
                            var map = super.toMap()
                            if self.mirrorHeaders != nil {
                                map["MirrorHeaders"] = self.mirrorHeaders?.toMap()
                            }
                            if self.redirectType != nil {
                                map["RedirectType"] = self.redirectType!
                            }
                            if self.passQueryString != nil {
                                map["PassQueryString"] = self.passQueryString!
                            }
                            if self.mirrorURL != nil {
                                map["MirrorURL"] = self.mirrorURL!
                            }
                            if self.mirrorPassQueryString != nil {
                                map["MirrorPassQueryString"] = self.mirrorPassQueryString!
                            }
                            if self.mirrorFollowRedirect != nil {
                                map["MirrorFollowRedirect"] = self.mirrorFollowRedirect!
                            }
                            if self.mirrorCheckMd5 != nil {
                                map["MirrorCheckMd5"] = self.mirrorCheckMd5!
                            }
                            if self.protocol_ != nil {
                                map["Protocol"] = self.protocol_!
                            }
                            if self.hostName != nil {
                                map["HostName"] = self.hostName!
                            }
                            if self.httpRedirectCode != nil {
                                map["HttpRedirectCode"] = self.httpRedirectCode!
                            }
                            if self.replaceKeyPrefixWith != nil {
                                map["ReplaceKeyPrefixWith"] = self.replaceKeyPrefixWith!
                            }
                            if self.replaceKeyWith != nil {
                                map["ReplaceKeyWith"] = self.replaceKeyWith!
                            }
                            return map
                        }

                        public override func fromMap(_ dict: [String: Any]) -> Void {
                            if dict.keys.contains("MirrorHeaders") && dict["MirrorHeaders"] != nil {
                                var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders()
                                model.fromMap(dict["MirrorHeaders"] as! [String: Any])
                                self.mirrorHeaders = model
                            }
                            if dict.keys.contains("RedirectType") && dict["RedirectType"] != nil {
                                self.redirectType = dict["RedirectType"] as! String
                            }
                            if dict.keys.contains("PassQueryString") && dict["PassQueryString"] != nil {
                                self.passQueryString = dict["PassQueryString"] as! Bool
                            }
                            if dict.keys.contains("MirrorURL") && dict["MirrorURL"] != nil {
                                self.mirrorURL = dict["MirrorURL"] as! String
                            }
                            if dict.keys.contains("MirrorPassQueryString") && dict["MirrorPassQueryString"] != nil {
                                self.mirrorPassQueryString = dict["MirrorPassQueryString"] as! Bool
                            }
                            if dict.keys.contains("MirrorFollowRedirect") && dict["MirrorFollowRedirect"] != nil {
                                self.mirrorFollowRedirect = dict["MirrorFollowRedirect"] as! Bool
                            }
                            if dict.keys.contains("MirrorCheckMd5") && dict["MirrorCheckMd5"] != nil {
                                self.mirrorCheckMd5 = dict["MirrorCheckMd5"] as! Bool
                            }
                            if dict.keys.contains("Protocol") && dict["Protocol"] != nil {
                                self.protocol_ = dict["Protocol"] as! String
                            }
                            if dict.keys.contains("HostName") && dict["HostName"] != nil {
                                self.hostName = dict["HostName"] as! String
                            }
                            if dict.keys.contains("HttpRedirectCode") && dict["HttpRedirectCode"] != nil {
                                self.httpRedirectCode = dict["HttpRedirectCode"] as! String
                            }
                            if dict.keys.contains("ReplaceKeyPrefixWith") && dict["ReplaceKeyPrefixWith"] != nil {
                                self.replaceKeyPrefixWith = dict["ReplaceKeyPrefixWith"] as! String
                            }
                            if dict.keys.contains("ReplaceKeyWith") && dict["ReplaceKeyWith"] != nil {
                                self.replaceKeyWith = dict["ReplaceKeyWith"] as! String
                            }
                        }
                    }
                    public var condition: PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Condition?

                    public var redirect: PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect?

                    public var ruleNumber: Int?

                    public override init() {
                        super.init()
                    }

                    public init(_ dict: [String: Any]) {
                        super.init()
                        self.fromMap(dict)
                    }

                    public override func validate() throws -> Void {
                        try self.condition?.validate()
                        try self.redirect?.validate()
                    }

                    public override func toMap() -> [String : Any] {
                        var map = super.toMap()
                        if self.condition != nil {
                            map["Condition"] = self.condition?.toMap()
                        }
                        if self.redirect != nil {
                            map["Redirect"] = self.redirect?.toMap()
                        }
                        if self.ruleNumber != nil {
                            map["RuleNumber"] = self.ruleNumber!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("Condition") && dict["Condition"] != nil {
                            var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Condition()
                            model.fromMap(dict["Condition"] as! [String: Any])
                            self.condition = model
                        }
                        if dict.keys.contains("Redirect") && dict["Redirect"] != nil {
                            var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect()
                            model.fromMap(dict["Redirect"] as! [String: Any])
                            self.redirect = model
                        }
                        if dict.keys.contains("RuleNumber") && dict["RuleNumber"] != nil {
                            self.ruleNumber = dict["RuleNumber"] as! Int
                        }
                    }
                }
                public var routingRule: [PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule]?

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
                    if self.routingRule != nil {
                        var tmp : [Any] = []
                        for k in self.routingRule! {
                            tmp.append(k.toMap())
                        }
                        map["RoutingRule"] = tmp
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("RoutingRule") && dict["RoutingRule"] != nil {
                        var tmp : [PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule] = []
                        for v in dict["RoutingRule"] as! [Any] {
                            var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules.RoutingRule()
                            if v != nil {
                                model.fromMap(v as! [String: Any])
                            }
                            tmp.append(model)
                        }
                        self.routingRule = tmp
                    }
                }
            }
            public var indexDocument: PutBucketWebsiteRequest.Body.WebsiteConfiguration.IndexDocument?

            public var errorDocument: PutBucketWebsiteRequest.Body.WebsiteConfiguration.ErrorDocument?

            public var routingRules: PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.indexDocument?.validate()
                try self.errorDocument?.validate()
                try self.routingRules?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.indexDocument != nil {
                    map["IndexDocument"] = self.indexDocument?.toMap()
                }
                if self.errorDocument != nil {
                    map["ErrorDocument"] = self.errorDocument?.toMap()
                }
                if self.routingRules != nil {
                    map["RoutingRules"] = self.routingRules?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("IndexDocument") && dict["IndexDocument"] != nil {
                    var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.IndexDocument()
                    model.fromMap(dict["IndexDocument"] as! [String: Any])
                    self.indexDocument = model
                }
                if dict.keys.contains("ErrorDocument") && dict["ErrorDocument"] != nil {
                    var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.ErrorDocument()
                    model.fromMap(dict["ErrorDocument"] as! [String: Any])
                    self.errorDocument = model
                }
                if dict.keys.contains("RoutingRules") && dict["RoutingRules"] != nil {
                    var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration.RoutingRules()
                    model.fromMap(dict["RoutingRules"] as! [String: Any])
                    self.routingRules = model
                }
            }
        }
        public var websiteConfiguration: PutBucketWebsiteRequest.Body.WebsiteConfiguration?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.websiteConfiguration, "websiteConfiguration")
            try self.websiteConfiguration?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.websiteConfiguration != nil {
                map["WebsiteConfiguration"] = self.websiteConfiguration?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("WebsiteConfiguration") && dict["WebsiteConfiguration"] != nil {
                var model = PutBucketWebsiteRequest.Body.WebsiteConfiguration()
                model.fromMap(dict["WebsiteConfiguration"] as! [String: Any])
                self.websiteConfiguration = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketWebsiteRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketWebsiteRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketWebsiteResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class CompleteMultipartUploadRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var uploadId: String?

        public var encodingType: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.uploadId, "uploadId")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.uploadId != nil {
                map["uploadId"] = self.uploadId!
            }
            if self.encodingType != nil {
                map["Encoding-type"] = self.encodingType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("uploadId") && dict["uploadId"] != nil {
                self.uploadId = dict["uploadId"] as! String
            }
            if dict.keys.contains("Encoding-type") && dict["Encoding-type"] != nil {
                self.encodingType = dict["Encoding-type"] as! String
            }
        }
    }
    public class Body : Tea.TeaModel {
        public class CompleteMultipartUpload : Tea.TeaModel {
            public class Part : Tea.TeaModel {
                public var partNumber: String?

                public var eTag: String?

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
                    if self.partNumber != nil {
                        map["PartNumber"] = self.partNumber!
                    }
                    if self.eTag != nil {
                        map["ETag"] = self.eTag!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("PartNumber") && dict["PartNumber"] != nil {
                        self.partNumber = dict["PartNumber"] as! String
                    }
                    if dict.keys.contains("ETag") && dict["ETag"] != nil {
                        self.eTag = dict["ETag"] as! String
                    }
                }
            }
            public var part: [CompleteMultipartUploadRequest.Body.CompleteMultipartUpload.Part]?

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
                if self.part != nil {
                    var tmp : [Any] = []
                    for k in self.part! {
                        tmp.append(k.toMap())
                    }
                    map["Part"] = tmp
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Part") && dict["Part"] != nil {
                    var tmp : [CompleteMultipartUploadRequest.Body.CompleteMultipartUpload.Part] = []
                    for v in dict["Part"] as! [Any] {
                        var model = CompleteMultipartUploadRequest.Body.CompleteMultipartUpload.Part()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.part = tmp
                }
            }
        }
        public var completeMultipartUpload: CompleteMultipartUploadRequest.Body.CompleteMultipartUpload?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.completeMultipartUpload, "completeMultipartUpload")
            try self.completeMultipartUpload?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.completeMultipartUpload != nil {
                map["CompleteMultipartUpload"] = self.completeMultipartUpload?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("CompleteMultipartUpload") && dict["CompleteMultipartUpload"] != nil {
                var model = CompleteMultipartUploadRequest.Body.CompleteMultipartUpload()
                model.fromMap(dict["CompleteMultipartUpload"] as! [String: Any])
                self.completeMultipartUpload = model
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var filter: CompleteMultipartUploadRequest.Filter?

    public var body: CompleteMultipartUploadRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = CompleteMultipartUploadRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = CompleteMultipartUploadRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class CompleteMultipartUploadResponse : Tea.TeaModel {
    public class CompleteMultipartUploadResult : Tea.TeaModel {
        public var bucket: String?

        public var eTag: String?

        public var location: String?

        public var key: String?

        public var encodingType: String?

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
            if self.bucket != nil {
                map["Bucket"] = self.bucket!
            }
            if self.eTag != nil {
                map["ETag"] = self.eTag!
            }
            if self.location != nil {
                map["Location"] = self.location!
            }
            if self.key != nil {
                map["Key"] = self.key!
            }
            if self.encodingType != nil {
                map["EncodingType"] = self.encodingType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Bucket") && dict["Bucket"] != nil {
                self.bucket = dict["Bucket"] as! String
            }
            if dict.keys.contains("ETag") && dict["ETag"] != nil {
                self.eTag = dict["ETag"] as! String
            }
            if dict.keys.contains("Location") && dict["Location"] != nil {
                self.location = dict["Location"] as! String
            }
            if dict.keys.contains("Key") && dict["Key"] != nil {
                self.key = dict["Key"] as! String
            }
            if dict.keys.contains("EncodingType") && dict["EncodingType"] != nil {
                self.encodingType = dict["EncodingType"] as! String
            }
        }
    }
    public var requestId: String?

    public var completeMultipartUploadResult: CompleteMultipartUploadResponse.CompleteMultipartUploadResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.completeMultipartUploadResult, "completeMultipartUploadResult")
        try self.completeMultipartUploadResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.completeMultipartUploadResult != nil {
            map["CompleteMultipartUploadResult"] = self.completeMultipartUploadResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("CompleteMultipartUploadResult") && dict["CompleteMultipartUploadResult"] != nil {
            var model = CompleteMultipartUploadResponse.CompleteMultipartUploadResult()
            model.fromMap(dict["CompleteMultipartUploadResult"] as! [String: Any])
            self.completeMultipartUploadResult = model
        }
    }
}

public class PutBucketLoggingRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class BucketLoggingStatus : Tea.TeaModel {
            public class LoggingEnabled : Tea.TeaModel {
                public var targetBucket: String?

                public var targetPrefix: String?

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
                    if self.targetBucket != nil {
                        map["TargetBucket"] = self.targetBucket!
                    }
                    if self.targetPrefix != nil {
                        map["TargetPrefix"] = self.targetPrefix!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("TargetBucket") && dict["TargetBucket"] != nil {
                        self.targetBucket = dict["TargetBucket"] as! String
                    }
                    if dict.keys.contains("TargetPrefix") && dict["TargetPrefix"] != nil {
                        self.targetPrefix = dict["TargetPrefix"] as! String
                    }
                }
            }
            public var loggingEnabled: PutBucketLoggingRequest.Body.BucketLoggingStatus.LoggingEnabled?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.loggingEnabled?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.loggingEnabled != nil {
                    map["LoggingEnabled"] = self.loggingEnabled?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("LoggingEnabled") && dict["LoggingEnabled"] != nil {
                    var model = PutBucketLoggingRequest.Body.BucketLoggingStatus.LoggingEnabled()
                    model.fromMap(dict["LoggingEnabled"] as! [String: Any])
                    self.loggingEnabled = model
                }
            }
        }
        public var bucketLoggingStatus: PutBucketLoggingRequest.Body.BucketLoggingStatus?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.bucketLoggingStatus, "bucketLoggingStatus")
            try self.bucketLoggingStatus?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.bucketLoggingStatus != nil {
                map["BucketLoggingStatus"] = self.bucketLoggingStatus?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("BucketLoggingStatus") && dict["BucketLoggingStatus"] != nil {
                var model = PutBucketLoggingRequest.Body.BucketLoggingStatus()
                model.fromMap(dict["BucketLoggingStatus"] as! [String: Any])
                self.bucketLoggingStatus = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketLoggingRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketLoggingRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketLoggingResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutBucketRequestPaymentRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class RequestPaymentConfiguration : Tea.TeaModel {
            public var payer: String?

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
                if self.payer != nil {
                    map["Payer"] = self.payer!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Payer") && dict["Payer"] != nil {
                    self.payer = dict["Payer"] as! String
                }
            }
        }
        public var requestPaymentConfiguration: PutBucketRequestPaymentRequest.Body.RequestPaymentConfiguration?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.requestPaymentConfiguration, "requestPaymentConfiguration")
            try self.requestPaymentConfiguration?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.requestPaymentConfiguration != nil {
                map["RequestPaymentConfiguration"] = self.requestPaymentConfiguration?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("RequestPaymentConfiguration") && dict["RequestPaymentConfiguration"] != nil {
                var model = PutBucketRequestPaymentRequest.Body.RequestPaymentConfiguration()
                model.fromMap(dict["RequestPaymentConfiguration"] as! [String: Any])
                self.requestPaymentConfiguration = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketRequestPaymentRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketRequestPaymentRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketRequestPaymentResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutBucketEncryptionRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class ServerSideEncryptionRule : Tea.TeaModel {
            public class ApplyServerSideEncryptionByDefault : Tea.TeaModel {
                public var sSEAlgorithm: String?

                public var kMSMasterKeyID: String?

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
                    if self.sSEAlgorithm != nil {
                        map["SSEAlgorithm"] = self.sSEAlgorithm!
                    }
                    if self.kMSMasterKeyID != nil {
                        map["KMSMasterKeyID"] = self.kMSMasterKeyID!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("SSEAlgorithm") && dict["SSEAlgorithm"] != nil {
                        self.sSEAlgorithm = dict["SSEAlgorithm"] as! String
                    }
                    if dict.keys.contains("KMSMasterKeyID") && dict["KMSMasterKeyID"] != nil {
                        self.kMSMasterKeyID = dict["KMSMasterKeyID"] as! String
                    }
                }
            }
            public var applyServerSideEncryptionByDefault: PutBucketEncryptionRequest.Body.ServerSideEncryptionRule.ApplyServerSideEncryptionByDefault?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.applyServerSideEncryptionByDefault?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.applyServerSideEncryptionByDefault != nil {
                    map["ApplyServerSideEncryptionByDefault"] = self.applyServerSideEncryptionByDefault?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("ApplyServerSideEncryptionByDefault") && dict["ApplyServerSideEncryptionByDefault"] != nil {
                    var model = PutBucketEncryptionRequest.Body.ServerSideEncryptionRule.ApplyServerSideEncryptionByDefault()
                    model.fromMap(dict["ApplyServerSideEncryptionByDefault"] as! [String: Any])
                    self.applyServerSideEncryptionByDefault = model
                }
            }
        }
        public var serverSideEncryptionRule: PutBucketEncryptionRequest.Body.ServerSideEncryptionRule?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.serverSideEncryptionRule, "serverSideEncryptionRule")
            try self.serverSideEncryptionRule?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.serverSideEncryptionRule != nil {
                map["ServerSideEncryptionRule"] = self.serverSideEncryptionRule?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("ServerSideEncryptionRule") && dict["ServerSideEncryptionRule"] != nil {
                var model = PutBucketEncryptionRequest.Body.ServerSideEncryptionRule()
                model.fromMap(dict["ServerSideEncryptionRule"] as! [String: Any])
                self.serverSideEncryptionRule = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketEncryptionRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketEncryptionRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketEncryptionResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutLiveChannelRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class LiveChannelConfiguration : Tea.TeaModel {
            public class Target : Tea.TeaModel {
                public var type: String?

                public var fragDuration: String?

                public var fragCount: String?

                public var playlistName: String?

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
                    if self.type != nil {
                        map["Type"] = self.type!
                    }
                    if self.fragDuration != nil {
                        map["FragDuration"] = self.fragDuration!
                    }
                    if self.fragCount != nil {
                        map["FragCount"] = self.fragCount!
                    }
                    if self.playlistName != nil {
                        map["PlaylistName"] = self.playlistName!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Type") && dict["Type"] != nil {
                        self.type = dict["Type"] as! String
                    }
                    if dict.keys.contains("FragDuration") && dict["FragDuration"] != nil {
                        self.fragDuration = dict["FragDuration"] as! String
                    }
                    if dict.keys.contains("FragCount") && dict["FragCount"] != nil {
                        self.fragCount = dict["FragCount"] as! String
                    }
                    if dict.keys.contains("PlaylistName") && dict["PlaylistName"] != nil {
                        self.playlistName = dict["PlaylistName"] as! String
                    }
                }
            }
            public class Snapshot : Tea.TeaModel {
                public var roleName: String?

                public var destBucket: String?

                public var notifyTopic: String?

                public var interval: String?

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
                    if self.roleName != nil {
                        map["RoleName"] = self.roleName!
                    }
                    if self.destBucket != nil {
                        map["DestBucket"] = self.destBucket!
                    }
                    if self.notifyTopic != nil {
                        map["NotifyTopic"] = self.notifyTopic!
                    }
                    if self.interval != nil {
                        map["Interval"] = self.interval!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("RoleName") && dict["RoleName"] != nil {
                        self.roleName = dict["RoleName"] as! String
                    }
                    if dict.keys.contains("DestBucket") && dict["DestBucket"] != nil {
                        self.destBucket = dict["DestBucket"] as! String
                    }
                    if dict.keys.contains("NotifyTopic") && dict["NotifyTopic"] != nil {
                        self.notifyTopic = dict["NotifyTopic"] as! String
                    }
                    if dict.keys.contains("Interval") && dict["Interval"] != nil {
                        self.interval = dict["Interval"] as! String
                    }
                }
            }
            public var target: PutLiveChannelRequest.Body.LiveChannelConfiguration.Target?

            public var snapshot: PutLiveChannelRequest.Body.LiveChannelConfiguration.Snapshot?

            public var description_: String?

            public var status: String?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.target?.validate()
                try self.snapshot?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.target != nil {
                    map["Target"] = self.target?.toMap()
                }
                if self.snapshot != nil {
                    map["Snapshot"] = self.snapshot?.toMap()
                }
                if self.description_ != nil {
                    map["Description"] = self.description_!
                }
                if self.status != nil {
                    map["Status"] = self.status!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Target") && dict["Target"] != nil {
                    var model = PutLiveChannelRequest.Body.LiveChannelConfiguration.Target()
                    model.fromMap(dict["Target"] as! [String: Any])
                    self.target = model
                }
                if dict.keys.contains("Snapshot") && dict["Snapshot"] != nil {
                    var model = PutLiveChannelRequest.Body.LiveChannelConfiguration.Snapshot()
                    model.fromMap(dict["Snapshot"] as! [String: Any])
                    self.snapshot = model
                }
                if dict.keys.contains("Description") && dict["Description"] != nil {
                    self.description_ = dict["Description"] as! String
                }
                if dict.keys.contains("Status") && dict["Status"] != nil {
                    self.status = dict["Status"] as! String
                }
            }
        }
        public var liveChannelConfiguration: PutLiveChannelRequest.Body.LiveChannelConfiguration?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.liveChannelConfiguration, "liveChannelConfiguration")
            try self.liveChannelConfiguration?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.liveChannelConfiguration != nil {
                map["LiveChannelConfiguration"] = self.liveChannelConfiguration?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("LiveChannelConfiguration") && dict["LiveChannelConfiguration"] != nil {
                var model = PutLiveChannelRequest.Body.LiveChannelConfiguration()
                model.fromMap(dict["LiveChannelConfiguration"] as! [String: Any])
                self.liveChannelConfiguration = model
            }
        }
    }
    public var bucketName: String?

    public var channelName: String?

    public var body: PutLiveChannelRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutLiveChannelRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutLiveChannelResponse : Tea.TeaModel {
    public class CreateLiveChannelResult : Tea.TeaModel {
        public class PublishUrls : Tea.TeaModel {
            public var url: String?

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
                if self.url != nil {
                    map["Url"] = self.url!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Url") && dict["Url"] != nil {
                    self.url = dict["Url"] as! String
                }
            }
        }
        public class PlayUrls : Tea.TeaModel {
            public var url: String?

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
                if self.url != nil {
                    map["Url"] = self.url!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Url") && dict["Url"] != nil {
                    self.url = dict["Url"] as! String
                }
            }
        }
        public var publishUrls: PutLiveChannelResponse.CreateLiveChannelResult.PublishUrls?

        public var playUrls: PutLiveChannelResponse.CreateLiveChannelResult.PlayUrls?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.publishUrls, "publishUrls")
            try self.publishUrls?.validate()
            try self.validateRequired(self.playUrls, "playUrls")
            try self.playUrls?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.publishUrls != nil {
                map["PublishUrls"] = self.publishUrls?.toMap()
            }
            if self.playUrls != nil {
                map["PlayUrls"] = self.playUrls?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("PublishUrls") && dict["PublishUrls"] != nil {
                var model = PutLiveChannelResponse.CreateLiveChannelResult.PublishUrls()
                model.fromMap(dict["PublishUrls"] as! [String: Any])
                self.publishUrls = model
            }
            if dict.keys.contains("PlayUrls") && dict["PlayUrls"] != nil {
                var model = PutLiveChannelResponse.CreateLiveChannelResult.PlayUrls()
                model.fromMap(dict["PlayUrls"] as! [String: Any])
                self.playUrls = model
            }
        }
    }
    public var requestId: String?

    public var createLiveChannelResult: PutLiveChannelResponse.CreateLiveChannelResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.createLiveChannelResult, "createLiveChannelResult")
        try self.createLiveChannelResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.createLiveChannelResult != nil {
            map["CreateLiveChannelResult"] = self.createLiveChannelResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("CreateLiveChannelResult") && dict["CreateLiveChannelResult"] != nil {
            var model = PutLiveChannelResponse.CreateLiveChannelResult()
            model.fromMap(dict["CreateLiveChannelResult"] as! [String: Any])
            self.createLiveChannelResult = model
        }
    }
}

public class PutBucketTagsRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class Tagging : Tea.TeaModel {
            public class TagSet : Tea.TeaModel {
                public class Tag : Tea.TeaModel {
                    public var key: String?

                    public var value: String?

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
                        if self.key != nil {
                            map["Key"] = self.key!
                        }
                        if self.value != nil {
                            map["Value"] = self.value!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("Key") && dict["Key"] != nil {
                            self.key = dict["Key"] as! String
                        }
                        if dict.keys.contains("Value") && dict["Value"] != nil {
                            self.value = dict["Value"] as! String
                        }
                    }
                }
                public var tag: [PutBucketTagsRequest.Body.Tagging.TagSet.Tag]?

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
                    if self.tag != nil {
                        var tmp : [Any] = []
                        for k in self.tag! {
                            tmp.append(k.toMap())
                        }
                        map["Tag"] = tmp
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Tag") && dict["Tag"] != nil {
                        var tmp : [PutBucketTagsRequest.Body.Tagging.TagSet.Tag] = []
                        for v in dict["Tag"] as! [Any] {
                            var model = PutBucketTagsRequest.Body.Tagging.TagSet.Tag()
                            if v != nil {
                                model.fromMap(v as! [String: Any])
                            }
                            tmp.append(model)
                        }
                        self.tag = tmp
                    }
                }
            }
            public var tagSet: PutBucketTagsRequest.Body.Tagging.TagSet?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.tagSet?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.tagSet != nil {
                    map["TagSet"] = self.tagSet?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("TagSet") && dict["TagSet"] != nil {
                    var model = PutBucketTagsRequest.Body.Tagging.TagSet()
                    model.fromMap(dict["TagSet"] as! [String: Any])
                    self.tagSet = model
                }
            }
        }
        public var tagging: PutBucketTagsRequest.Body.Tagging?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.tagging, "tagging")
            try self.tagging?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.tagging != nil {
                map["Tagging"] = self.tagging?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Tagging") && dict["Tagging"] != nil {
                var model = PutBucketTagsRequest.Body.Tagging()
                model.fromMap(dict["Tagging"] as! [String: Any])
                self.tagging = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketTagsRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketTagsRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketTagsResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutObjectTaggingRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class Tagging : Tea.TeaModel {
            public class TagSet : Tea.TeaModel {
                public class Tag : Tea.TeaModel {
                    public var key: String?

                    public var value: String?

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
                        if self.key != nil {
                            map["Key"] = self.key!
                        }
                        if self.value != nil {
                            map["Value"] = self.value!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("Key") && dict["Key"] != nil {
                            self.key = dict["Key"] as! String
                        }
                        if dict.keys.contains("Value") && dict["Value"] != nil {
                            self.value = dict["Value"] as! String
                        }
                    }
                }
                public var tag: [PutObjectTaggingRequest.Body.Tagging.TagSet.Tag]?

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
                    if self.tag != nil {
                        var tmp : [Any] = []
                        for k in self.tag! {
                            tmp.append(k.toMap())
                        }
                        map["Tag"] = tmp
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Tag") && dict["Tag"] != nil {
                        var tmp : [PutObjectTaggingRequest.Body.Tagging.TagSet.Tag] = []
                        for v in dict["Tag"] as! [Any] {
                            var model = PutObjectTaggingRequest.Body.Tagging.TagSet.Tag()
                            if v != nil {
                                model.fromMap(v as! [String: Any])
                            }
                            tmp.append(model)
                        }
                        self.tag = tmp
                    }
                }
            }
            public var tagSet: PutObjectTaggingRequest.Body.Tagging.TagSet?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.tagSet?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.tagSet != nil {
                    map["TagSet"] = self.tagSet?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("TagSet") && dict["TagSet"] != nil {
                    var model = PutObjectTaggingRequest.Body.Tagging.TagSet()
                    model.fromMap(dict["TagSet"] as! [String: Any])
                    self.tagSet = model
                }
            }
        }
        public var tagging: PutObjectTaggingRequest.Body.Tagging?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.tagging, "tagging")
            try self.tagging?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.tagging != nil {
                map["Tagging"] = self.tagging?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Tagging") && dict["Tagging"] != nil {
                var model = PutObjectTaggingRequest.Body.Tagging()
                model.fromMap(dict["Tagging"] as! [String: Any])
                self.tagging = model
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var body: PutObjectTaggingRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutObjectTaggingRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutObjectTaggingResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class SelectObjectRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var porcess: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.porcess, "porcess")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.porcess != nil {
                map["x-oss-process"] = self.porcess!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("x-oss-process") && dict["x-oss-process"] != nil {
                self.porcess = dict["x-oss-process"] as! String
            }
        }
    }
    public class Body : Tea.TeaModel {
        public class SelectRequest : Tea.TeaModel {
            public class InputSerialization : Tea.TeaModel {
                public class CSV : Tea.TeaModel {
                    public var fileHeaderInfo: String?

                    public var recordDelimiter: String?

                    public var fieldDelimiter: String?

                    public var quoteCharacter: String?

                    public var commentCharacter: String?

                    public var range: String?

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
                        if self.fileHeaderInfo != nil {
                            map["FileHeaderInfo"] = self.fileHeaderInfo!
                        }
                        if self.recordDelimiter != nil {
                            map["RecordDelimiter"] = self.recordDelimiter!
                        }
                        if self.fieldDelimiter != nil {
                            map["FieldDelimiter"] = self.fieldDelimiter!
                        }
                        if self.quoteCharacter != nil {
                            map["QuoteCharacter"] = self.quoteCharacter!
                        }
                        if self.commentCharacter != nil {
                            map["CommentCharacter"] = self.commentCharacter!
                        }
                        if self.range != nil {
                            map["Range"] = self.range!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("FileHeaderInfo") && dict["FileHeaderInfo"] != nil {
                            self.fileHeaderInfo = dict["FileHeaderInfo"] as! String
                        }
                        if dict.keys.contains("RecordDelimiter") && dict["RecordDelimiter"] != nil {
                            self.recordDelimiter = dict["RecordDelimiter"] as! String
                        }
                        if dict.keys.contains("FieldDelimiter") && dict["FieldDelimiter"] != nil {
                            self.fieldDelimiter = dict["FieldDelimiter"] as! String
                        }
                        if dict.keys.contains("QuoteCharacter") && dict["QuoteCharacter"] != nil {
                            self.quoteCharacter = dict["QuoteCharacter"] as! String
                        }
                        if dict.keys.contains("CommentCharacter") && dict["CommentCharacter"] != nil {
                            self.commentCharacter = dict["CommentCharacter"] as! String
                        }
                        if dict.keys.contains("Range") && dict["Range"] != nil {
                            self.range = dict["Range"] as! String
                        }
                    }
                }
                public var cSV: SelectObjectRequest.Body.SelectRequest.InputSerialization.CSV?

                public var compressionType: String?

                public override init() {
                    super.init()
                }

                public init(_ dict: [String: Any]) {
                    super.init()
                    self.fromMap(dict)
                }

                public override func validate() throws -> Void {
                    try self.cSV?.validate()
                }

                public override func toMap() -> [String : Any] {
                    var map = super.toMap()
                    if self.cSV != nil {
                        map["CSV"] = self.cSV?.toMap()
                    }
                    if self.compressionType != nil {
                        map["CompressionType"] = self.compressionType!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("CSV") && dict["CSV"] != nil {
                        var model = SelectObjectRequest.Body.SelectRequest.InputSerialization.CSV()
                        model.fromMap(dict["CSV"] as! [String: Any])
                        self.cSV = model
                    }
                    if dict.keys.contains("CompressionType") && dict["CompressionType"] != nil {
                        self.compressionType = dict["CompressionType"] as! String
                    }
                }
            }
            public class OutputSerialization : Tea.TeaModel {
                public class CSV : Tea.TeaModel {
                    public var recordDelimiter: String?

                    public var fieldDelimiter: String?

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
                        if self.recordDelimiter != nil {
                            map["RecordDelimiter"] = self.recordDelimiter!
                        }
                        if self.fieldDelimiter != nil {
                            map["FieldDelimiter"] = self.fieldDelimiter!
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("RecordDelimiter") && dict["RecordDelimiter"] != nil {
                            self.recordDelimiter = dict["RecordDelimiter"] as! String
                        }
                        if dict.keys.contains("FieldDelimiter") && dict["FieldDelimiter"] != nil {
                            self.fieldDelimiter = dict["FieldDelimiter"] as! String
                        }
                    }
                }
                public var cSV: SelectObjectRequest.Body.SelectRequest.OutputSerialization.CSV?

                public var keepAllColumns: String?

                public var outputRawData: String?

                public var enablePayloadCrc: String?

                public var outputHeader: String?

                public override init() {
                    super.init()
                }

                public init(_ dict: [String: Any]) {
                    super.init()
                    self.fromMap(dict)
                }

                public override func validate() throws -> Void {
                    try self.cSV?.validate()
                }

                public override func toMap() -> [String : Any] {
                    var map = super.toMap()
                    if self.cSV != nil {
                        map["CSV"] = self.cSV?.toMap()
                    }
                    if self.keepAllColumns != nil {
                        map["KeepAllColumns"] = self.keepAllColumns!
                    }
                    if self.outputRawData != nil {
                        map["OutputRawData"] = self.outputRawData!
                    }
                    if self.enablePayloadCrc != nil {
                        map["EnablePayloadCrc"] = self.enablePayloadCrc!
                    }
                    if self.outputHeader != nil {
                        map["OutputHeader"] = self.outputHeader!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("CSV") && dict["CSV"] != nil {
                        var model = SelectObjectRequest.Body.SelectRequest.OutputSerialization.CSV()
                        model.fromMap(dict["CSV"] as! [String: Any])
                        self.cSV = model
                    }
                    if dict.keys.contains("KeepAllColumns") && dict["KeepAllColumns"] != nil {
                        self.keepAllColumns = dict["KeepAllColumns"] as! String
                    }
                    if dict.keys.contains("OutputRawData") && dict["OutputRawData"] != nil {
                        self.outputRawData = dict["OutputRawData"] as! String
                    }
                    if dict.keys.contains("EnablePayloadCrc") && dict["EnablePayloadCrc"] != nil {
                        self.enablePayloadCrc = dict["EnablePayloadCrc"] as! String
                    }
                    if dict.keys.contains("OutputHeader") && dict["OutputHeader"] != nil {
                        self.outputHeader = dict["OutputHeader"] as! String
                    }
                }
            }
            public class Options : Tea.TeaModel {
                public var skipPartialDataRecord: String?

                public var maxSkippedRecordsAllowed: String?

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
                    if self.skipPartialDataRecord != nil {
                        map["SkipPartialDataRecord"] = self.skipPartialDataRecord!
                    }
                    if self.maxSkippedRecordsAllowed != nil {
                        map["MaxSkippedRecordsAllowed"] = self.maxSkippedRecordsAllowed!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("SkipPartialDataRecord") && dict["SkipPartialDataRecord"] != nil {
                        self.skipPartialDataRecord = dict["SkipPartialDataRecord"] as! String
                    }
                    if dict.keys.contains("MaxSkippedRecordsAllowed") && dict["MaxSkippedRecordsAllowed"] != nil {
                        self.maxSkippedRecordsAllowed = dict["MaxSkippedRecordsAllowed"] as! String
                    }
                }
            }
            public var inputSerialization: SelectObjectRequest.Body.SelectRequest.InputSerialization?

            public var outputSerialization: SelectObjectRequest.Body.SelectRequest.OutputSerialization?

            public var options: SelectObjectRequest.Body.SelectRequest.Options?

            public var expression: String?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.inputSerialization?.validate()
                try self.outputSerialization?.validate()
                try self.options?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.inputSerialization != nil {
                    map["InputSerialization"] = self.inputSerialization?.toMap()
                }
                if self.outputSerialization != nil {
                    map["OutputSerialization"] = self.outputSerialization?.toMap()
                }
                if self.options != nil {
                    map["Options"] = self.options?.toMap()
                }
                if self.expression != nil {
                    map["Expression"] = self.expression!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("InputSerialization") && dict["InputSerialization"] != nil {
                    var model = SelectObjectRequest.Body.SelectRequest.InputSerialization()
                    model.fromMap(dict["InputSerialization"] as! [String: Any])
                    self.inputSerialization = model
                }
                if dict.keys.contains("OutputSerialization") && dict["OutputSerialization"] != nil {
                    var model = SelectObjectRequest.Body.SelectRequest.OutputSerialization()
                    model.fromMap(dict["OutputSerialization"] as! [String: Any])
                    self.outputSerialization = model
                }
                if dict.keys.contains("Options") && dict["Options"] != nil {
                    var model = SelectObjectRequest.Body.SelectRequest.Options()
                    model.fromMap(dict["Options"] as! [String: Any])
                    self.options = model
                }
                if dict.keys.contains("Expression") && dict["Expression"] != nil {
                    self.expression = dict["Expression"] as! String
                }
            }
        }
        public var selectRequest: SelectObjectRequest.Body.SelectRequest?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.selectRequest, "selectRequest")
            try self.selectRequest?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.selectRequest != nil {
                map["SelectRequest"] = self.selectRequest?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("SelectRequest") && dict["SelectRequest"] != nil {
                var model = SelectObjectRequest.Body.SelectRequest()
                model.fromMap(dict["SelectRequest"] as! [String: Any])
                self.selectRequest = model
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var filter: SelectObjectRequest.Filter?

    public var body: SelectObjectRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = SelectObjectRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = SelectObjectRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class SelectObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutBucketCORSRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class CORSConfiguration : Tea.TeaModel {
            public class CORSRule : Tea.TeaModel {
                public var allowedOrigin: [String]?

                public var allowedMethod: [String]?

                public var allowedHeader: [String]?

                public var exposeHeader: [String]?

                public var maxAgeSeconds: String?

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
                    if self.allowedOrigin != nil {
                        map["AllowedOrigin"] = self.allowedOrigin!
                    }
                    if self.allowedMethod != nil {
                        map["AllowedMethod"] = self.allowedMethod!
                    }
                    if self.allowedHeader != nil {
                        map["AllowedHeader"] = self.allowedHeader!
                    }
                    if self.exposeHeader != nil {
                        map["ExposeHeader"] = self.exposeHeader!
                    }
                    if self.maxAgeSeconds != nil {
                        map["MaxAgeSeconds"] = self.maxAgeSeconds!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("AllowedOrigin") && dict["AllowedOrigin"] != nil {
                        self.allowedOrigin = dict["AllowedOrigin"] as! [String]
                    }
                    if dict.keys.contains("AllowedMethod") && dict["AllowedMethod"] != nil {
                        self.allowedMethod = dict["AllowedMethod"] as! [String]
                    }
                    if dict.keys.contains("AllowedHeader") && dict["AllowedHeader"] != nil {
                        self.allowedHeader = dict["AllowedHeader"] as! [String]
                    }
                    if dict.keys.contains("ExposeHeader") && dict["ExposeHeader"] != nil {
                        self.exposeHeader = dict["ExposeHeader"] as! [String]
                    }
                    if dict.keys.contains("MaxAgeSeconds") && dict["MaxAgeSeconds"] != nil {
                        self.maxAgeSeconds = dict["MaxAgeSeconds"] as! String
                    }
                }
            }
            public var cORSRule: [PutBucketCORSRequest.Body.CORSConfiguration.CORSRule]?

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
                if self.cORSRule != nil {
                    var tmp : [Any] = []
                    for k in self.cORSRule! {
                        tmp.append(k.toMap())
                    }
                    map["CORSRule"] = tmp
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("CORSRule") && dict["CORSRule"] != nil {
                    var tmp : [PutBucketCORSRequest.Body.CORSConfiguration.CORSRule] = []
                    for v in dict["CORSRule"] as! [Any] {
                        var model = PutBucketCORSRequest.Body.CORSConfiguration.CORSRule()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.cORSRule = tmp
                }
            }
        }
        public var cORSConfiguration: PutBucketCORSRequest.Body.CORSConfiguration?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.cORSConfiguration, "cORSConfiguration")
            try self.cORSConfiguration?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.cORSConfiguration != nil {
                map["CORSConfiguration"] = self.cORSConfiguration?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("CORSConfiguration") && dict["CORSConfiguration"] != nil {
                var model = PutBucketCORSRequest.Body.CORSConfiguration()
                model.fromMap(dict["CORSConfiguration"] as! [String: Any])
                self.cORSConfiguration = model
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketCORSRequest.Body?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketCORSRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
    }
}

public class PutBucketCORSResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutBucketRequest : Tea.TeaModel {
    public class Body : Tea.TeaModel {
        public class CreateBucketConfiguration : Tea.TeaModel {
            public var storageClass: String?

            public var dataRedundancyType: String?

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
                if self.storageClass != nil {
                    map["StorageClass"] = self.storageClass!
                }
                if self.dataRedundancyType != nil {
                    map["DataRedundancyType"] = self.dataRedundancyType!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("StorageClass") && dict["StorageClass"] != nil {
                    self.storageClass = dict["StorageClass"] as! String
                }
                if dict.keys.contains("DataRedundancyType") && dict["DataRedundancyType"] != nil {
                    self.dataRedundancyType = dict["DataRedundancyType"] as! String
                }
            }
        }
        public var createBucketConfiguration: PutBucketRequest.Body.CreateBucketConfiguration?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.createBucketConfiguration, "createBucketConfiguration")
            try self.createBucketConfiguration?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.createBucketConfiguration != nil {
                map["CreateBucketConfiguration"] = self.createBucketConfiguration?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("CreateBucketConfiguration") && dict["CreateBucketConfiguration"] != nil {
                var model = PutBucketRequest.Body.CreateBucketConfiguration()
                model.fromMap(dict["CreateBucketConfiguration"] as! [String: Any])
                self.createBucketConfiguration = model
            }
        }
    }
    public class Header : Tea.TeaModel {
        public var acl: String?

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
            if self.acl != nil {
                map["x-oss-acl"] = self.acl!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("x-oss-acl") && dict["x-oss-acl"] != nil {
                self.acl = dict["x-oss-acl"] as! String
            }
        }
    }
    public var bucketName: String?

    public var body: PutBucketRequest.Body?

    public var header: PutBucketRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.body?.validate()
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.body != nil {
            map["Body"] = self.body?.toMap()
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Body") && dict["Body"] != nil {
            var model = PutBucketRequest.Body()
            model.fromMap(dict["Body"] as! [String: Any])
            self.body = model
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = PutBucketRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class PutBucketResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class ListMultipartUploadsRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var delimiter: String?

        public var maxUploads: String?

        public var keyMarker: String?

        public var prefix_: String?

        public var uploadIdMarker: String?

        public var encodingType: String?

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
            if self.delimiter != nil {
                map["delimiter"] = self.delimiter!
            }
            if self.maxUploads != nil {
                map["max-uploads"] = self.maxUploads!
            }
            if self.keyMarker != nil {
                map["key-marker"] = self.keyMarker!
            }
            if self.prefix_ != nil {
                map["prefix"] = self.prefix_!
            }
            if self.uploadIdMarker != nil {
                map["upload-id-marker"] = self.uploadIdMarker!
            }
            if self.encodingType != nil {
                map["encoding-type"] = self.encodingType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("delimiter") && dict["delimiter"] != nil {
                self.delimiter = dict["delimiter"] as! String
            }
            if dict.keys.contains("max-uploads") && dict["max-uploads"] != nil {
                self.maxUploads = dict["max-uploads"] as! String
            }
            if dict.keys.contains("key-marker") && dict["key-marker"] != nil {
                self.keyMarker = dict["key-marker"] as! String
            }
            if dict.keys.contains("prefix") && dict["prefix"] != nil {
                self.prefix_ = dict["prefix"] as! String
            }
            if dict.keys.contains("upload-id-marker") && dict["upload-id-marker"] != nil {
                self.uploadIdMarker = dict["upload-id-marker"] as! String
            }
            if dict.keys.contains("encoding-type") && dict["encoding-type"] != nil {
                self.encodingType = dict["encoding-type"] as! String
            }
        }
    }
    public var bucketName: String?

    public var filter: ListMultipartUploadsRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = ListMultipartUploadsRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class ListMultipartUploadsResponse : Tea.TeaModel {
    public class ListMultipartUploadsResult : Tea.TeaModel {
        public class Upload : Tea.TeaModel {
            public var key: String?

            public var uploadId: String?

            public var initiated: String?

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
                if self.key != nil {
                    map["Key"] = self.key!
                }
                if self.uploadId != nil {
                    map["UploadId"] = self.uploadId!
                }
                if self.initiated != nil {
                    map["Initiated"] = self.initiated!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Key") && dict["Key"] != nil {
                    self.key = dict["Key"] as! String
                }
                if dict.keys.contains("UploadId") && dict["UploadId"] != nil {
                    self.uploadId = dict["UploadId"] as! String
                }
                if dict.keys.contains("Initiated") && dict["Initiated"] != nil {
                    self.initiated = dict["Initiated"] as! String
                }
            }
        }
        public var bucket: String?

        public var encodingType: String?

        public var keyMarker: String?

        public var uploadIdMarker: String?

        public var nextKeyMarker: String?

        public var nextUploadIdMarker: String?

        public var delimiter: String?

        public var maxUploads: String?

        public var isTruncated: String?

        public var upload: [ListMultipartUploadsResponse.ListMultipartUploadsResult.Upload]?

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
            if self.bucket != nil {
                map["Bucket"] = self.bucket!
            }
            if self.encodingType != nil {
                map["EncodingType"] = self.encodingType!
            }
            if self.keyMarker != nil {
                map["KeyMarker"] = self.keyMarker!
            }
            if self.uploadIdMarker != nil {
                map["UploadIdMarker"] = self.uploadIdMarker!
            }
            if self.nextKeyMarker != nil {
                map["NextKeyMarker"] = self.nextKeyMarker!
            }
            if self.nextUploadIdMarker != nil {
                map["NextUploadIdMarker"] = self.nextUploadIdMarker!
            }
            if self.delimiter != nil {
                map["Delimiter"] = self.delimiter!
            }
            if self.maxUploads != nil {
                map["MaxUploads"] = self.maxUploads!
            }
            if self.isTruncated != nil {
                map["IsTruncated"] = self.isTruncated!
            }
            if self.upload != nil {
                var tmp : [Any] = []
                for k in self.upload! {
                    tmp.append(k.toMap())
                }
                map["Upload"] = tmp
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Bucket") && dict["Bucket"] != nil {
                self.bucket = dict["Bucket"] as! String
            }
            if dict.keys.contains("EncodingType") && dict["EncodingType"] != nil {
                self.encodingType = dict["EncodingType"] as! String
            }
            if dict.keys.contains("KeyMarker") && dict["KeyMarker"] != nil {
                self.keyMarker = dict["KeyMarker"] as! String
            }
            if dict.keys.contains("UploadIdMarker") && dict["UploadIdMarker"] != nil {
                self.uploadIdMarker = dict["UploadIdMarker"] as! String
            }
            if dict.keys.contains("NextKeyMarker") && dict["NextKeyMarker"] != nil {
                self.nextKeyMarker = dict["NextKeyMarker"] as! String
            }
            if dict.keys.contains("NextUploadIdMarker") && dict["NextUploadIdMarker"] != nil {
                self.nextUploadIdMarker = dict["NextUploadIdMarker"] as! String
            }
            if dict.keys.contains("Delimiter") && dict["Delimiter"] != nil {
                self.delimiter = dict["Delimiter"] as! String
            }
            if dict.keys.contains("MaxUploads") && dict["MaxUploads"] != nil {
                self.maxUploads = dict["MaxUploads"] as! String
            }
            if dict.keys.contains("IsTruncated") && dict["IsTruncated"] != nil {
                self.isTruncated = dict["IsTruncated"] as! String
            }
            if dict.keys.contains("Upload") && dict["Upload"] != nil {
                var tmp : [ListMultipartUploadsResponse.ListMultipartUploadsResult.Upload] = []
                for v in dict["Upload"] as! [Any] {
                    var model = ListMultipartUploadsResponse.ListMultipartUploadsResult.Upload()
                    if v != nil {
                        model.fromMap(v as! [String: Any])
                    }
                    tmp.append(model)
                }
                self.upload = tmp
            }
        }
    }
    public var requestId: String?

    public var listMultipartUploadsResult: ListMultipartUploadsResponse.ListMultipartUploadsResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.listMultipartUploadsResult, "listMultipartUploadsResult")
        try self.listMultipartUploadsResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.listMultipartUploadsResult != nil {
            map["ListMultipartUploadsResult"] = self.listMultipartUploadsResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("ListMultipartUploadsResult") && dict["ListMultipartUploadsResult"] != nil {
            var model = ListMultipartUploadsResponse.ListMultipartUploadsResult()
            model.fromMap(dict["ListMultipartUploadsResult"] as! [String: Any])
            self.listMultipartUploadsResult = model
        }
    }
}

public class GetBucketRequestPaymentRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketRequestPaymentResponse : Tea.TeaModel {
    public class RequestPaymentConfiguration : Tea.TeaModel {
        public var payer: String?

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
            if self.payer != nil {
                map["Payer"] = self.payer!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Payer") && dict["Payer"] != nil {
                self.payer = dict["Payer"] as! String
            }
        }
    }
    public var requestId: String?

    public var requestPaymentConfiguration: GetBucketRequestPaymentResponse.RequestPaymentConfiguration?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.requestPaymentConfiguration, "requestPaymentConfiguration")
        try self.requestPaymentConfiguration?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.requestPaymentConfiguration != nil {
            map["RequestPaymentConfiguration"] = self.requestPaymentConfiguration?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("RequestPaymentConfiguration") && dict["RequestPaymentConfiguration"] != nil {
            var model = GetBucketRequestPaymentResponse.RequestPaymentConfiguration()
            model.fromMap(dict["RequestPaymentConfiguration"] as! [String: Any])
            self.requestPaymentConfiguration = model
        }
    }
}

public class GetBucketEncryptionRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketEncryptionResponse : Tea.TeaModel {
    public class ServerSideEncryptionRule : Tea.TeaModel {
        public class ApplyServerSideEncryptionByDefault : Tea.TeaModel {
            public var sSEAlgorithm: String?

            public var kMSMasterKeyID: String?

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
                if self.sSEAlgorithm != nil {
                    map["SSEAlgorithm"] = self.sSEAlgorithm!
                }
                if self.kMSMasterKeyID != nil {
                    map["KMSMasterKeyID"] = self.kMSMasterKeyID!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("SSEAlgorithm") && dict["SSEAlgorithm"] != nil {
                    self.sSEAlgorithm = dict["SSEAlgorithm"] as! String
                }
                if dict.keys.contains("KMSMasterKeyID") && dict["KMSMasterKeyID"] != nil {
                    self.kMSMasterKeyID = dict["KMSMasterKeyID"] as! String
                }
            }
        }
        public var applyServerSideEncryptionByDefault: GetBucketEncryptionResponse.ServerSideEncryptionRule.ApplyServerSideEncryptionByDefault?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.applyServerSideEncryptionByDefault, "applyServerSideEncryptionByDefault")
            try self.applyServerSideEncryptionByDefault?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.applyServerSideEncryptionByDefault != nil {
                map["ApplyServerSideEncryptionByDefault"] = self.applyServerSideEncryptionByDefault?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("ApplyServerSideEncryptionByDefault") && dict["ApplyServerSideEncryptionByDefault"] != nil {
                var model = GetBucketEncryptionResponse.ServerSideEncryptionRule.ApplyServerSideEncryptionByDefault()
                model.fromMap(dict["ApplyServerSideEncryptionByDefault"] as! [String: Any])
                self.applyServerSideEncryptionByDefault = model
            }
        }
    }
    public var requestId: String?

    public var serverSideEncryptionRule: GetBucketEncryptionResponse.ServerSideEncryptionRule?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.serverSideEncryptionRule, "serverSideEncryptionRule")
        try self.serverSideEncryptionRule?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.serverSideEncryptionRule != nil {
            map["ServerSideEncryptionRule"] = self.serverSideEncryptionRule?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("ServerSideEncryptionRule") && dict["ServerSideEncryptionRule"] != nil {
            var model = GetBucketEncryptionResponse.ServerSideEncryptionRule()
            model.fromMap(dict["ServerSideEncryptionRule"] as! [String: Any])
            self.serverSideEncryptionRule = model
        }
    }
}

public class GetBucketTagsRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketTagsResponse : Tea.TeaModel {
    public class Tagging : Tea.TeaModel {
        public class TagSet : Tea.TeaModel {
            public class Tag : Tea.TeaModel {
                public var key: String?

                public var value: String?

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
                    if self.key != nil {
                        map["Key"] = self.key!
                    }
                    if self.value != nil {
                        map["Value"] = self.value!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Key") && dict["Key"] != nil {
                        self.key = dict["Key"] as! String
                    }
                    if dict.keys.contains("Value") && dict["Value"] != nil {
                        self.value = dict["Value"] as! String
                    }
                }
            }
            public var tag: [GetBucketTagsResponse.Tagging.TagSet.Tag]?

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
                if self.tag != nil {
                    var tmp : [Any] = []
                    for k in self.tag! {
                        tmp.append(k.toMap())
                    }
                    map["Tag"] = tmp
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Tag") && dict["Tag"] != nil {
                    var tmp : [GetBucketTagsResponse.Tagging.TagSet.Tag] = []
                    for v in dict["Tag"] as! [Any] {
                        var model = GetBucketTagsResponse.Tagging.TagSet.Tag()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.tag = tmp
                }
            }
        }
        public var tagSet: GetBucketTagsResponse.Tagging.TagSet?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.tagSet, "tagSet")
            try self.tagSet?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.tagSet != nil {
                map["TagSet"] = self.tagSet?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("TagSet") && dict["TagSet"] != nil {
                var model = GetBucketTagsResponse.Tagging.TagSet()
                model.fromMap(dict["TagSet"] as! [String: Any])
                self.tagSet = model
            }
        }
    }
    public var requestId: String?

    public var tagging: GetBucketTagsResponse.Tagging?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.tagging, "tagging")
        try self.tagging?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.tagging != nil {
            map["Tagging"] = self.tagging?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("Tagging") && dict["Tagging"] != nil {
            var model = GetBucketTagsResponse.Tagging()
            model.fromMap(dict["Tagging"] as! [String: Any])
            self.tagging = model
        }
    }
}

public class GetServiceRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var prefix_: String?

        public var marker: String?

        public var maxKeys: String?

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
            if self.prefix_ != nil {
                map["prefix"] = self.prefix_!
            }
            if self.marker != nil {
                map["marker"] = self.marker!
            }
            if self.maxKeys != nil {
                map["max-keys"] = self.maxKeys!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("prefix") && dict["prefix"] != nil {
                self.prefix_ = dict["prefix"] as! String
            }
            if dict.keys.contains("marker") && dict["marker"] != nil {
                self.marker = dict["marker"] as! String
            }
            if dict.keys.contains("max-keys") && dict["max-keys"] != nil {
                self.maxKeys = dict["max-keys"] as! String
            }
        }
    }
    public var filter: GetServiceRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = GetServiceRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class GetServiceResponse : Tea.TeaModel {
    public class ListAllMyBucketsResult : Tea.TeaModel {
        public class Owner : Tea.TeaModel {
            public var iD: String?

            public var displayName: String?

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
                if self.iD != nil {
                    map["ID"] = self.iD!
                }
                if self.displayName != nil {
                    map["DisplayName"] = self.displayName!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("ID") && dict["ID"] != nil {
                    self.iD = dict["ID"] as! String
                }
                if dict.keys.contains("DisplayName") && dict["DisplayName"] != nil {
                    self.displayName = dict["DisplayName"] as! String
                }
            }
        }
        public class Buckets : Tea.TeaModel {
            public class Bucket : Tea.TeaModel {
                public var name: String?

                public var createDate: String?

                public var location: String?

                public var extranetEndpoint: String?

                public var intranetEndpoint: String?

                public var storageClass: String?

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
                    if self.name != nil {
                        map["Name"] = self.name!
                    }
                    if self.createDate != nil {
                        map["CreateDate"] = self.createDate!
                    }
                    if self.location != nil {
                        map["Location"] = self.location!
                    }
                    if self.extranetEndpoint != nil {
                        map["ExtranetEndpoint"] = self.extranetEndpoint!
                    }
                    if self.intranetEndpoint != nil {
                        map["IntranetEndpoint"] = self.intranetEndpoint!
                    }
                    if self.storageClass != nil {
                        map["StorageClass"] = self.storageClass!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Name") && dict["Name"] != nil {
                        self.name = dict["Name"] as! String
                    }
                    if dict.keys.contains("CreateDate") && dict["CreateDate"] != nil {
                        self.createDate = dict["CreateDate"] as! String
                    }
                    if dict.keys.contains("Location") && dict["Location"] != nil {
                        self.location = dict["Location"] as! String
                    }
                    if dict.keys.contains("ExtranetEndpoint") && dict["ExtranetEndpoint"] != nil {
                        self.extranetEndpoint = dict["ExtranetEndpoint"] as! String
                    }
                    if dict.keys.contains("IntranetEndpoint") && dict["IntranetEndpoint"] != nil {
                        self.intranetEndpoint = dict["IntranetEndpoint"] as! String
                    }
                    if dict.keys.contains("StorageClass") && dict["StorageClass"] != nil {
                        self.storageClass = dict["StorageClass"] as! String
                    }
                }
            }
            public var bucket: [GetServiceResponse.ListAllMyBucketsResult.Buckets.Bucket]?

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
                if self.bucket != nil {
                    var tmp : [Any] = []
                    for k in self.bucket! {
                        tmp.append(k.toMap())
                    }
                    map["Bucket"] = tmp
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Bucket") && dict["Bucket"] != nil {
                    var tmp : [GetServiceResponse.ListAllMyBucketsResult.Buckets.Bucket] = []
                    for v in dict["Bucket"] as! [Any] {
                        var model = GetServiceResponse.ListAllMyBucketsResult.Buckets.Bucket()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.bucket = tmp
                }
            }
        }
        public var prefix_: String?

        public var marker: String?

        public var maxKeys: String?

        public var isTruncated: String?

        public var nextMarker: String?

        public var owner: GetServiceResponse.ListAllMyBucketsResult.Owner?

        public var buckets: GetServiceResponse.ListAllMyBucketsResult.Buckets?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.owner, "owner")
            try self.owner?.validate()
            try self.validateRequired(self.buckets, "buckets")
            try self.buckets?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.prefix_ != nil {
                map["Prefix"] = self.prefix_!
            }
            if self.marker != nil {
                map["Marker"] = self.marker!
            }
            if self.maxKeys != nil {
                map["MaxKeys"] = self.maxKeys!
            }
            if self.isTruncated != nil {
                map["IsTruncated"] = self.isTruncated!
            }
            if self.nextMarker != nil {
                map["NextMarker"] = self.nextMarker!
            }
            if self.owner != nil {
                map["Owner"] = self.owner?.toMap()
            }
            if self.buckets != nil {
                map["Buckets"] = self.buckets?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Prefix") && dict["Prefix"] != nil {
                self.prefix_ = dict["Prefix"] as! String
            }
            if dict.keys.contains("Marker") && dict["Marker"] != nil {
                self.marker = dict["Marker"] as! String
            }
            if dict.keys.contains("MaxKeys") && dict["MaxKeys"] != nil {
                self.maxKeys = dict["MaxKeys"] as! String
            }
            if dict.keys.contains("IsTruncated") && dict["IsTruncated"] != nil {
                self.isTruncated = dict["IsTruncated"] as! String
            }
            if dict.keys.contains("NextMarker") && dict["NextMarker"] != nil {
                self.nextMarker = dict["NextMarker"] as! String
            }
            if dict.keys.contains("Owner") && dict["Owner"] != nil {
                var model = GetServiceResponse.ListAllMyBucketsResult.Owner()
                model.fromMap(dict["Owner"] as! [String: Any])
                self.owner = model
            }
            if dict.keys.contains("Buckets") && dict["Buckets"] != nil {
                var model = GetServiceResponse.ListAllMyBucketsResult.Buckets()
                model.fromMap(dict["Buckets"] as! [String: Any])
                self.buckets = model
            }
        }
    }
    public var requestId: String?

    public var listAllMyBucketsResult: GetServiceResponse.ListAllMyBucketsResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.listAllMyBucketsResult, "listAllMyBucketsResult")
        try self.listAllMyBucketsResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.listAllMyBucketsResult != nil {
            map["ListAllMyBucketsResult"] = self.listAllMyBucketsResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("ListAllMyBucketsResult") && dict["ListAllMyBucketsResult"] != nil {
            var model = GetServiceResponse.ListAllMyBucketsResult()
            model.fromMap(dict["ListAllMyBucketsResult"] as! [String: Any])
            self.listAllMyBucketsResult = model
        }
    }
}

public class DeleteBucketEncryptionRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class DeleteBucketEncryptionResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class DeleteBucketTagsRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var tagging: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.tagging, "tagging")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.tagging != nil {
                map["tagging"] = self.tagging!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("tagging") && dict["tagging"] != nil {
                self.tagging = dict["tagging"] as! String
            }
        }
    }
    public var bucketName: String?

    public var filter: DeleteBucketTagsRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = DeleteBucketTagsRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class DeleteBucketTagsResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetBucketWebsiteRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketWebsiteResponse : Tea.TeaModel {
    public class WebsiteConfiguration : Tea.TeaModel {
        public class IndexDocument : Tea.TeaModel {
            public var suffix: String?

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
                if self.suffix != nil {
                    map["Suffix"] = self.suffix!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Suffix") && dict["Suffix"] != nil {
                    self.suffix = dict["Suffix"] as! String
                }
            }
        }
        public class ErrorDocument : Tea.TeaModel {
            public var key: String?

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
                if self.key != nil {
                    map["Key"] = self.key!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Key") && dict["Key"] != nil {
                    self.key = dict["Key"] as! String
                }
            }
        }
        public class RoutingRules : Tea.TeaModel {
            public class RoutingRule : Tea.TeaModel {
                public class Condition : Tea.TeaModel {
                    public class IncludeHeader : Tea.TeaModel {
                        public var key: String?

                        public var equals: String?

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
                            if self.key != nil {
                                map["Key"] = self.key!
                            }
                            if self.equals != nil {
                                map["Equals"] = self.equals!
                            }
                            return map
                        }

                        public override func fromMap(_ dict: [String: Any]) -> Void {
                            if dict.keys.contains("Key") && dict["Key"] != nil {
                                self.key = dict["Key"] as! String
                            }
                            if dict.keys.contains("Equals") && dict["Equals"] != nil {
                                self.equals = dict["Equals"] as! String
                            }
                        }
                    }
                    public var keyPrefixEquals: String?

                    public var httpErrorCodeReturnedEquals: String?

                    public var includeHeader: GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Condition.IncludeHeader?

                    public override init() {
                        super.init()
                    }

                    public init(_ dict: [String: Any]) {
                        super.init()
                        self.fromMap(dict)
                    }

                    public override func validate() throws -> Void {
                        try self.validateRequired(self.includeHeader, "includeHeader")
                        try self.includeHeader?.validate()
                    }

                    public override func toMap() -> [String : Any] {
                        var map = super.toMap()
                        if self.keyPrefixEquals != nil {
                            map["KeyPrefixEquals"] = self.keyPrefixEquals!
                        }
                        if self.httpErrorCodeReturnedEquals != nil {
                            map["HttpErrorCodeReturnedEquals"] = self.httpErrorCodeReturnedEquals!
                        }
                        if self.includeHeader != nil {
                            map["IncludeHeader"] = self.includeHeader?.toMap()
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("KeyPrefixEquals") && dict["KeyPrefixEquals"] != nil {
                            self.keyPrefixEquals = dict["KeyPrefixEquals"] as! String
                        }
                        if dict.keys.contains("HttpErrorCodeReturnedEquals") && dict["HttpErrorCodeReturnedEquals"] != nil {
                            self.httpErrorCodeReturnedEquals = dict["HttpErrorCodeReturnedEquals"] as! String
                        }
                        if dict.keys.contains("IncludeHeader") && dict["IncludeHeader"] != nil {
                            var model = GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Condition.IncludeHeader()
                            model.fromMap(dict["IncludeHeader"] as! [String: Any])
                            self.includeHeader = model
                        }
                    }
                }
                public class Redirect : Tea.TeaModel {
                    public class MirrorHeaders : Tea.TeaModel {
                        public class Set_ : Tea.TeaModel {
                            public var key: String?

                            public var value: String?

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
                                if self.key != nil {
                                    map["Key"] = self.key!
                                }
                                if self.value != nil {
                                    map["Value"] = self.value!
                                }
                                return map
                            }

                            public override func fromMap(_ dict: [String: Any]) -> Void {
                                if dict.keys.contains("Key") && dict["Key"] != nil {
                                    self.key = dict["Key"] as! String
                                }
                                if dict.keys.contains("Value") && dict["Value"] != nil {
                                    self.value = dict["Value"] as! String
                                }
                            }
                        }
                        public var passAll: Bool?

                        public var pass: String?

                        public var remove: String?

                        public var set_: GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders.Set_?

                        public override init() {
                            super.init()
                        }

                        public init(_ dict: [String: Any]) {
                            super.init()
                            self.fromMap(dict)
                        }

                        public override func validate() throws -> Void {
                            try self.validateRequired(self.set_, "set_")
                            try self.set_?.validate()
                        }

                        public override func toMap() -> [String : Any] {
                            var map = super.toMap()
                            if self.passAll != nil {
                                map["PassAll"] = self.passAll!
                            }
                            if self.pass != nil {
                                map["Pass"] = self.pass!
                            }
                            if self.remove != nil {
                                map["Remove"] = self.remove!
                            }
                            if self.set_ != nil {
                                map["Set"] = self.set_?.toMap()
                            }
                            return map
                        }

                        public override func fromMap(_ dict: [String: Any]) -> Void {
                            if dict.keys.contains("PassAll") && dict["PassAll"] != nil {
                                self.passAll = dict["PassAll"] as! Bool
                            }
                            if dict.keys.contains("Pass") && dict["Pass"] != nil {
                                self.pass = dict["Pass"] as! String
                            }
                            if dict.keys.contains("Remove") && dict["Remove"] != nil {
                                self.remove = dict["Remove"] as! String
                            }
                            if dict.keys.contains("Set") && dict["Set"] != nil {
                                var model = GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders.Set_()
                                model.fromMap(dict["Set"] as! [String: Any])
                                self.set_ = model
                            }
                        }
                    }
                    public var redirectType: String?

                    public var passQueryString: Bool?

                    public var mirrorURL: String?

                    public var mirrorPassQueryString: Bool?

                    public var mirrorFollowRedirect: Bool?

                    public var mirrorCheckMd5: Bool?

                    public var protocol_: String?

                    public var hostName: String?

                    public var httpRedirectCode: String?

                    public var replaceKeyPrefixWith: String?

                    public var replaceKeyWith: String?

                    public var mirrorHeaders: GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders?

                    public override init() {
                        super.init()
                    }

                    public init(_ dict: [String: Any]) {
                        super.init()
                        self.fromMap(dict)
                    }

                    public override func validate() throws -> Void {
                        try self.validateRequired(self.mirrorHeaders, "mirrorHeaders")
                        try self.mirrorHeaders?.validate()
                    }

                    public override func toMap() -> [String : Any] {
                        var map = super.toMap()
                        if self.redirectType != nil {
                            map["RedirectType"] = self.redirectType!
                        }
                        if self.passQueryString != nil {
                            map["PassQueryString"] = self.passQueryString!
                        }
                        if self.mirrorURL != nil {
                            map["MirrorURL"] = self.mirrorURL!
                        }
                        if self.mirrorPassQueryString != nil {
                            map["MirrorPassQueryString"] = self.mirrorPassQueryString!
                        }
                        if self.mirrorFollowRedirect != nil {
                            map["MirrorFollowRedirect"] = self.mirrorFollowRedirect!
                        }
                        if self.mirrorCheckMd5 != nil {
                            map["MirrorCheckMd5"] = self.mirrorCheckMd5!
                        }
                        if self.protocol_ != nil {
                            map["Protocol"] = self.protocol_!
                        }
                        if self.hostName != nil {
                            map["HostName"] = self.hostName!
                        }
                        if self.httpRedirectCode != nil {
                            map["HttpRedirectCode"] = self.httpRedirectCode!
                        }
                        if self.replaceKeyPrefixWith != nil {
                            map["ReplaceKeyPrefixWith"] = self.replaceKeyPrefixWith!
                        }
                        if self.replaceKeyWith != nil {
                            map["ReplaceKeyWith"] = self.replaceKeyWith!
                        }
                        if self.mirrorHeaders != nil {
                            map["MirrorHeaders"] = self.mirrorHeaders?.toMap()
                        }
                        return map
                    }

                    public override func fromMap(_ dict: [String: Any]) -> Void {
                        if dict.keys.contains("RedirectType") && dict["RedirectType"] != nil {
                            self.redirectType = dict["RedirectType"] as! String
                        }
                        if dict.keys.contains("PassQueryString") && dict["PassQueryString"] != nil {
                            self.passQueryString = dict["PassQueryString"] as! Bool
                        }
                        if dict.keys.contains("MirrorURL") && dict["MirrorURL"] != nil {
                            self.mirrorURL = dict["MirrorURL"] as! String
                        }
                        if dict.keys.contains("MirrorPassQueryString") && dict["MirrorPassQueryString"] != nil {
                            self.mirrorPassQueryString = dict["MirrorPassQueryString"] as! Bool
                        }
                        if dict.keys.contains("MirrorFollowRedirect") && dict["MirrorFollowRedirect"] != nil {
                            self.mirrorFollowRedirect = dict["MirrorFollowRedirect"] as! Bool
                        }
                        if dict.keys.contains("MirrorCheckMd5") && dict["MirrorCheckMd5"] != nil {
                            self.mirrorCheckMd5 = dict["MirrorCheckMd5"] as! Bool
                        }
                        if dict.keys.contains("Protocol") && dict["Protocol"] != nil {
                            self.protocol_ = dict["Protocol"] as! String
                        }
                        if dict.keys.contains("HostName") && dict["HostName"] != nil {
                            self.hostName = dict["HostName"] as! String
                        }
                        if dict.keys.contains("HttpRedirectCode") && dict["HttpRedirectCode"] != nil {
                            self.httpRedirectCode = dict["HttpRedirectCode"] as! String
                        }
                        if dict.keys.contains("ReplaceKeyPrefixWith") && dict["ReplaceKeyPrefixWith"] != nil {
                            self.replaceKeyPrefixWith = dict["ReplaceKeyPrefixWith"] as! String
                        }
                        if dict.keys.contains("ReplaceKeyWith") && dict["ReplaceKeyWith"] != nil {
                            self.replaceKeyWith = dict["ReplaceKeyWith"] as! String
                        }
                        if dict.keys.contains("MirrorHeaders") && dict["MirrorHeaders"] != nil {
                            var model = GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect.MirrorHeaders()
                            model.fromMap(dict["MirrorHeaders"] as! [String: Any])
                            self.mirrorHeaders = model
                        }
                    }
                }
                public var ruleNumber: Int?

                public var condition: GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Condition?

                public var redirect: GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect?

                public override init() {
                    super.init()
                }

                public init(_ dict: [String: Any]) {
                    super.init()
                    self.fromMap(dict)
                }

                public override func validate() throws -> Void {
                    try self.validateRequired(self.condition, "condition")
                    try self.condition?.validate()
                    try self.validateRequired(self.redirect, "redirect")
                    try self.redirect?.validate()
                }

                public override func toMap() -> [String : Any] {
                    var map = super.toMap()
                    if self.ruleNumber != nil {
                        map["RuleNumber"] = self.ruleNumber!
                    }
                    if self.condition != nil {
                        map["Condition"] = self.condition?.toMap()
                    }
                    if self.redirect != nil {
                        map["Redirect"] = self.redirect?.toMap()
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("RuleNumber") && dict["RuleNumber"] != nil {
                        self.ruleNumber = dict["RuleNumber"] as! Int
                    }
                    if dict.keys.contains("Condition") && dict["Condition"] != nil {
                        var model = GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Condition()
                        model.fromMap(dict["Condition"] as! [String: Any])
                        self.condition = model
                    }
                    if dict.keys.contains("Redirect") && dict["Redirect"] != nil {
                        var model = GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule.Redirect()
                        model.fromMap(dict["Redirect"] as! [String: Any])
                        self.redirect = model
                    }
                }
            }
            public var routingRule: [GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule]?

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
                if self.routingRule != nil {
                    var tmp : [Any] = []
                    for k in self.routingRule! {
                        tmp.append(k.toMap())
                    }
                    map["RoutingRule"] = tmp
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("RoutingRule") && dict["RoutingRule"] != nil {
                    var tmp : [GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule] = []
                    for v in dict["RoutingRule"] as! [Any] {
                        var model = GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules.RoutingRule()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.routingRule = tmp
                }
            }
        }
        public var indexDocument: GetBucketWebsiteResponse.WebsiteConfiguration.IndexDocument?

        public var errorDocument: GetBucketWebsiteResponse.WebsiteConfiguration.ErrorDocument?

        public var routingRules: GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.indexDocument, "indexDocument")
            try self.indexDocument?.validate()
            try self.validateRequired(self.errorDocument, "errorDocument")
            try self.errorDocument?.validate()
            try self.validateRequired(self.routingRules, "routingRules")
            try self.routingRules?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.indexDocument != nil {
                map["IndexDocument"] = self.indexDocument?.toMap()
            }
            if self.errorDocument != nil {
                map["ErrorDocument"] = self.errorDocument?.toMap()
            }
            if self.routingRules != nil {
                map["RoutingRules"] = self.routingRules?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("IndexDocument") && dict["IndexDocument"] != nil {
                var model = GetBucketWebsiteResponse.WebsiteConfiguration.IndexDocument()
                model.fromMap(dict["IndexDocument"] as! [String: Any])
                self.indexDocument = model
            }
            if dict.keys.contains("ErrorDocument") && dict["ErrorDocument"] != nil {
                var model = GetBucketWebsiteResponse.WebsiteConfiguration.ErrorDocument()
                model.fromMap(dict["ErrorDocument"] as! [String: Any])
                self.errorDocument = model
            }
            if dict.keys.contains("RoutingRules") && dict["RoutingRules"] != nil {
                var model = GetBucketWebsiteResponse.WebsiteConfiguration.RoutingRules()
                model.fromMap(dict["RoutingRules"] as! [String: Any])
                self.routingRules = model
            }
        }
    }
    public var requestId: String?

    public var websiteConfiguration: GetBucketWebsiteResponse.WebsiteConfiguration?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.websiteConfiguration, "websiteConfiguration")
        try self.websiteConfiguration?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.websiteConfiguration != nil {
            map["WebsiteConfiguration"] = self.websiteConfiguration?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("WebsiteConfiguration") && dict["WebsiteConfiguration"] != nil {
            var model = GetBucketWebsiteResponse.WebsiteConfiguration()
            model.fromMap(dict["WebsiteConfiguration"] as! [String: Any])
            self.websiteConfiguration = model
        }
    }
}

public class DeleteLiveChannelRequest : Tea.TeaModel {
    public var bucketName: String?

    public var channelName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
    }
}

public class DeleteLiveChannelResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetBucketLocationRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketLocationResponse : Tea.TeaModel {
    public var requestId: String?

    public var locationConstraint: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.locationConstraint, "locationConstraint")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.locationConstraint != nil {
            map["LocationConstraint"] = self.locationConstraint!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("LocationConstraint") && dict["LocationConstraint"] != nil {
            self.locationConstraint = dict["LocationConstraint"] as! String
        }
    }
}

public class ListLiveChannelRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var marker: String?

        public var maxKeys: String?

        public var prefix_: String?

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
            if self.marker != nil {
                map["marker"] = self.marker!
            }
            if self.maxKeys != nil {
                map["max-keys"] = self.maxKeys!
            }
            if self.prefix_ != nil {
                map["prefix"] = self.prefix_!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("marker") && dict["marker"] != nil {
                self.marker = dict["marker"] as! String
            }
            if dict.keys.contains("max-keys") && dict["max-keys"] != nil {
                self.maxKeys = dict["max-keys"] as! String
            }
            if dict.keys.contains("prefix") && dict["prefix"] != nil {
                self.prefix_ = dict["prefix"] as! String
            }
        }
    }
    public var bucketName: String?

    public var filter: ListLiveChannelRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = ListLiveChannelRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class ListLiveChannelResponse : Tea.TeaModel {
    public class ListLiveChannelResult : Tea.TeaModel {
        public class LiveChannel : Tea.TeaModel {
            public class PublishUrls : Tea.TeaModel {
                public var url: String?

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
                    if self.url != nil {
                        map["Url"] = self.url!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Url") && dict["Url"] != nil {
                        self.url = dict["Url"] as! String
                    }
                }
            }
            public class PlayUrls : Tea.TeaModel {
                public var url: String?

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
                    if self.url != nil {
                        map["Url"] = self.url!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Url") && dict["Url"] != nil {
                        self.url = dict["Url"] as! String
                    }
                }
            }
            public var name: String?

            public var description_: String?

            public var status: String?

            public var lastModified: String?

            public var publishUrls: ListLiveChannelResponse.ListLiveChannelResult.LiveChannel.PublishUrls?

            public var playUrls: ListLiveChannelResponse.ListLiveChannelResult.LiveChannel.PlayUrls?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.validateRequired(self.publishUrls, "publishUrls")
                try self.publishUrls?.validate()
                try self.validateRequired(self.playUrls, "playUrls")
                try self.playUrls?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.name != nil {
                    map["Name"] = self.name!
                }
                if self.description_ != nil {
                    map["Description"] = self.description_!
                }
                if self.status != nil {
                    map["Status"] = self.status!
                }
                if self.lastModified != nil {
                    map["LastModified"] = self.lastModified!
                }
                if self.publishUrls != nil {
                    map["PublishUrls"] = self.publishUrls?.toMap()
                }
                if self.playUrls != nil {
                    map["PlayUrls"] = self.playUrls?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Name") && dict["Name"] != nil {
                    self.name = dict["Name"] as! String
                }
                if dict.keys.contains("Description") && dict["Description"] != nil {
                    self.description_ = dict["Description"] as! String
                }
                if dict.keys.contains("Status") && dict["Status"] != nil {
                    self.status = dict["Status"] as! String
                }
                if dict.keys.contains("LastModified") && dict["LastModified"] != nil {
                    self.lastModified = dict["LastModified"] as! String
                }
                if dict.keys.contains("PublishUrls") && dict["PublishUrls"] != nil {
                    var model = ListLiveChannelResponse.ListLiveChannelResult.LiveChannel.PublishUrls()
                    model.fromMap(dict["PublishUrls"] as! [String: Any])
                    self.publishUrls = model
                }
                if dict.keys.contains("PlayUrls") && dict["PlayUrls"] != nil {
                    var model = ListLiveChannelResponse.ListLiveChannelResult.LiveChannel.PlayUrls()
                    model.fromMap(dict["PlayUrls"] as! [String: Any])
                    self.playUrls = model
                }
            }
        }
        public var prefix_: String?

        public var marker: String?

        public var maxKeys: String?

        public var isTruncated: String?

        public var nextMarker: String?

        public var liveChannel: ListLiveChannelResponse.ListLiveChannelResult.LiveChannel?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.liveChannel, "liveChannel")
            try self.liveChannel?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.prefix_ != nil {
                map["Prefix"] = self.prefix_!
            }
            if self.marker != nil {
                map["Marker"] = self.marker!
            }
            if self.maxKeys != nil {
                map["MaxKeys"] = self.maxKeys!
            }
            if self.isTruncated != nil {
                map["IsTruncated"] = self.isTruncated!
            }
            if self.nextMarker != nil {
                map["NextMarker"] = self.nextMarker!
            }
            if self.liveChannel != nil {
                map["LiveChannel"] = self.liveChannel?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Prefix") && dict["Prefix"] != nil {
                self.prefix_ = dict["Prefix"] as! String
            }
            if dict.keys.contains("Marker") && dict["Marker"] != nil {
                self.marker = dict["Marker"] as! String
            }
            if dict.keys.contains("MaxKeys") && dict["MaxKeys"] != nil {
                self.maxKeys = dict["MaxKeys"] as! String
            }
            if dict.keys.contains("IsTruncated") && dict["IsTruncated"] != nil {
                self.isTruncated = dict["IsTruncated"] as! String
            }
            if dict.keys.contains("NextMarker") && dict["NextMarker"] != nil {
                self.nextMarker = dict["NextMarker"] as! String
            }
            if dict.keys.contains("LiveChannel") && dict["LiveChannel"] != nil {
                var model = ListLiveChannelResponse.ListLiveChannelResult.LiveChannel()
                model.fromMap(dict["LiveChannel"] as! [String: Any])
                self.liveChannel = model
            }
        }
    }
    public var requestId: String?

    public var listLiveChannelResult: ListLiveChannelResponse.ListLiveChannelResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.listLiveChannelResult, "listLiveChannelResult")
        try self.listLiveChannelResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.listLiveChannelResult != nil {
            map["ListLiveChannelResult"] = self.listLiveChannelResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("ListLiveChannelResult") && dict["ListLiveChannelResult"] != nil {
            var model = ListLiveChannelResponse.ListLiveChannelResult()
            model.fromMap(dict["ListLiveChannelResult"] as! [String: Any])
            self.listLiveChannelResult = model
        }
    }
}

public class GetObjectMetaRequest : Tea.TeaModel {
    public var bucketName: String?

    public var objectName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
    }
}

public class GetObjectMetaResponse : Tea.TeaModel {
    public var requestId: String?

    public var eTag: String?

    public var contentLength: String?

    public var lastModified: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.eTag, "eTag")
        try self.validateRequired(self.contentLength, "contentLength")
        try self.validateRequired(self.lastModified, "lastModified")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.eTag != nil {
            map["etag"] = self.eTag!
        }
        if self.contentLength != nil {
            map["content-length"] = self.contentLength!
        }
        if self.lastModified != nil {
            map["last-modified"] = self.lastModified!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("etag") && dict["etag"] != nil {
            self.eTag = dict["etag"] as! String
        }
        if dict.keys.contains("content-length") && dict["content-length"] != nil {
            self.contentLength = dict["content-length"] as! String
        }
        if dict.keys.contains("last-modified") && dict["last-modified"] != nil {
            self.lastModified = dict["last-modified"] as! String
        }
    }
}

public class GetBucketAclRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketAclResponse : Tea.TeaModel {
    public class AccessControlPolicy : Tea.TeaModel {
        public class Owner : Tea.TeaModel {
            public var iD: String?

            public var displayName: String?

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
                if self.iD != nil {
                    map["ID"] = self.iD!
                }
                if self.displayName != nil {
                    map["DisplayName"] = self.displayName!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("ID") && dict["ID"] != nil {
                    self.iD = dict["ID"] as! String
                }
                if dict.keys.contains("DisplayName") && dict["DisplayName"] != nil {
                    self.displayName = dict["DisplayName"] as! String
                }
            }
        }
        public class AccessControlList : Tea.TeaModel {
            public var grant: String?

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
                if self.grant != nil {
                    map["Grant"] = self.grant!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Grant") && dict["Grant"] != nil {
                    self.grant = dict["Grant"] as! String
                }
            }
        }
        public var owner: GetBucketAclResponse.AccessControlPolicy.Owner?

        public var accessControlList: GetBucketAclResponse.AccessControlPolicy.AccessControlList?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.owner, "owner")
            try self.owner?.validate()
            try self.validateRequired(self.accessControlList, "accessControlList")
            try self.accessControlList?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.owner != nil {
                map["Owner"] = self.owner?.toMap()
            }
            if self.accessControlList != nil {
                map["AccessControlList"] = self.accessControlList?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Owner") && dict["Owner"] != nil {
                var model = GetBucketAclResponse.AccessControlPolicy.Owner()
                model.fromMap(dict["Owner"] as! [String: Any])
                self.owner = model
            }
            if dict.keys.contains("AccessControlList") && dict["AccessControlList"] != nil {
                var model = GetBucketAclResponse.AccessControlPolicy.AccessControlList()
                model.fromMap(dict["AccessControlList"] as! [String: Any])
                self.accessControlList = model
            }
        }
    }
    public var requestId: String?

    public var accessControlPolicy: GetBucketAclResponse.AccessControlPolicy?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.accessControlPolicy, "accessControlPolicy")
        try self.accessControlPolicy?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.accessControlPolicy != nil {
            map["AccessControlPolicy"] = self.accessControlPolicy?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("AccessControlPolicy") && dict["AccessControlPolicy"] != nil {
            var model = GetBucketAclResponse.AccessControlPolicy()
            model.fromMap(dict["AccessControlPolicy"] as! [String: Any])
            self.accessControlPolicy = model
        }
    }
}

public class ListPartsRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var uploadId: String?

        public var maxParts: Int?

        public var partNumberMarker: Int?

        public var encodingType: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.uploadId, "uploadId")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.uploadId != nil {
                map["uploadId"] = self.uploadId!
            }
            if self.maxParts != nil {
                map["max-parts"] = self.maxParts!
            }
            if self.partNumberMarker != nil {
                map["part-number-marker"] = self.partNumberMarker!
            }
            if self.encodingType != nil {
                map["Encoding-type"] = self.encodingType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("uploadId") && dict["uploadId"] != nil {
                self.uploadId = dict["uploadId"] as! String
            }
            if dict.keys.contains("max-parts") && dict["max-parts"] != nil {
                self.maxParts = dict["max-parts"] as! Int
            }
            if dict.keys.contains("part-number-marker") && dict["part-number-marker"] != nil {
                self.partNumberMarker = dict["part-number-marker"] as! Int
            }
            if dict.keys.contains("Encoding-type") && dict["Encoding-type"] != nil {
                self.encodingType = dict["Encoding-type"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var filter: ListPartsRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = ListPartsRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class ListPartsResponse : Tea.TeaModel {
    public class ListPartsResult : Tea.TeaModel {
        public class Part : Tea.TeaModel {
            public var partNumber: String?

            public var lastModified: String?

            public var eTag: String?

            public var size: String?

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
                if self.partNumber != nil {
                    map["PartNumber"] = self.partNumber!
                }
                if self.lastModified != nil {
                    map["LastModified"] = self.lastModified!
                }
                if self.eTag != nil {
                    map["ETag"] = self.eTag!
                }
                if self.size != nil {
                    map["Size"] = self.size!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("PartNumber") && dict["PartNumber"] != nil {
                    self.partNumber = dict["PartNumber"] as! String
                }
                if dict.keys.contains("LastModified") && dict["LastModified"] != nil {
                    self.lastModified = dict["LastModified"] as! String
                }
                if dict.keys.contains("ETag") && dict["ETag"] != nil {
                    self.eTag = dict["ETag"] as! String
                }
                if dict.keys.contains("Size") && dict["Size"] != nil {
                    self.size = dict["Size"] as! String
                }
            }
        }
        public var bucket: String?

        public var encodingType: String?

        public var key: String?

        public var uploadId: String?

        public var partNumberMarker: String?

        public var nextPartNumberMarker: String?

        public var maxParts: String?

        public var isTruncated: String?

        public var part: [ListPartsResponse.ListPartsResult.Part]?

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
            if self.bucket != nil {
                map["Bucket"] = self.bucket!
            }
            if self.encodingType != nil {
                map["EncodingType"] = self.encodingType!
            }
            if self.key != nil {
                map["Key"] = self.key!
            }
            if self.uploadId != nil {
                map["UploadId"] = self.uploadId!
            }
            if self.partNumberMarker != nil {
                map["PartNumberMarker"] = self.partNumberMarker!
            }
            if self.nextPartNumberMarker != nil {
                map["NextPartNumberMarker"] = self.nextPartNumberMarker!
            }
            if self.maxParts != nil {
                map["MaxParts"] = self.maxParts!
            }
            if self.isTruncated != nil {
                map["IsTruncated"] = self.isTruncated!
            }
            if self.part != nil {
                var tmp : [Any] = []
                for k in self.part! {
                    tmp.append(k.toMap())
                }
                map["Part"] = tmp
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Bucket") && dict["Bucket"] != nil {
                self.bucket = dict["Bucket"] as! String
            }
            if dict.keys.contains("EncodingType") && dict["EncodingType"] != nil {
                self.encodingType = dict["EncodingType"] as! String
            }
            if dict.keys.contains("Key") && dict["Key"] != nil {
                self.key = dict["Key"] as! String
            }
            if dict.keys.contains("UploadId") && dict["UploadId"] != nil {
                self.uploadId = dict["UploadId"] as! String
            }
            if dict.keys.contains("PartNumberMarker") && dict["PartNumberMarker"] != nil {
                self.partNumberMarker = dict["PartNumberMarker"] as! String
            }
            if dict.keys.contains("NextPartNumberMarker") && dict["NextPartNumberMarker"] != nil {
                self.nextPartNumberMarker = dict["NextPartNumberMarker"] as! String
            }
            if dict.keys.contains("MaxParts") && dict["MaxParts"] != nil {
                self.maxParts = dict["MaxParts"] as! String
            }
            if dict.keys.contains("IsTruncated") && dict["IsTruncated"] != nil {
                self.isTruncated = dict["IsTruncated"] as! String
            }
            if dict.keys.contains("Part") && dict["Part"] != nil {
                var tmp : [ListPartsResponse.ListPartsResult.Part] = []
                for v in dict["Part"] as! [Any] {
                    var model = ListPartsResponse.ListPartsResult.Part()
                    if v != nil {
                        model.fromMap(v as! [String: Any])
                    }
                    tmp.append(model)
                }
                self.part = tmp
            }
        }
    }
    public var requestId: String?

    public var listPartsResult: ListPartsResponse.ListPartsResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.listPartsResult, "listPartsResult")
        try self.listPartsResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.listPartsResult != nil {
            map["ListPartsResult"] = self.listPartsResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("ListPartsResult") && dict["ListPartsResult"] != nil {
            var model = ListPartsResponse.ListPartsResult()
            model.fromMap(dict["ListPartsResult"] as! [String: Any])
            self.listPartsResult = model
        }
    }
}

public class GetLiveChannelHistoryRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var comp: String?

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
            if self.comp != nil {
                map["comp"] = self.comp!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("comp") && dict["comp"] != nil {
                self.comp = dict["comp"] as! String
            }
        }
    }
    public var bucketName: String?

    public var channelName: String?

    public var filter: GetLiveChannelHistoryRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = GetLiveChannelHistoryRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class GetLiveChannelHistoryResponse : Tea.TeaModel {
    public class LiveChannelHistory : Tea.TeaModel {
        public class LiveRecord : Tea.TeaModel {
            public var startTime: String?

            public var endTime: String?

            public var remoteAddr: String?

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
                if self.startTime != nil {
                    map["StartTime"] = self.startTime!
                }
                if self.endTime != nil {
                    map["EndTime"] = self.endTime!
                }
                if self.remoteAddr != nil {
                    map["RemoteAddr"] = self.remoteAddr!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("StartTime") && dict["StartTime"] != nil {
                    self.startTime = dict["StartTime"] as! String
                }
                if dict.keys.contains("EndTime") && dict["EndTime"] != nil {
                    self.endTime = dict["EndTime"] as! String
                }
                if dict.keys.contains("RemoteAddr") && dict["RemoteAddr"] != nil {
                    self.remoteAddr = dict["RemoteAddr"] as! String
                }
            }
        }
        public var liveRecord: [GetLiveChannelHistoryResponse.LiveChannelHistory.LiveRecord]?

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
            if self.liveRecord != nil {
                var tmp : [Any] = []
                for k in self.liveRecord! {
                    tmp.append(k.toMap())
                }
                map["LiveRecord"] = tmp
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("LiveRecord") && dict["LiveRecord"] != nil {
                var tmp : [GetLiveChannelHistoryResponse.LiveChannelHistory.LiveRecord] = []
                for v in dict["LiveRecord"] as! [Any] {
                    var model = GetLiveChannelHistoryResponse.LiveChannelHistory.LiveRecord()
                    if v != nil {
                        model.fromMap(v as! [String: Any])
                    }
                    tmp.append(model)
                }
                self.liveRecord = tmp
            }
        }
    }
    public var requestId: String?

    public var liveChannelHistory: GetLiveChannelHistoryResponse.LiveChannelHistory?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.liveChannelHistory, "liveChannelHistory")
        try self.liveChannelHistory?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.liveChannelHistory != nil {
            map["LiveChannelHistory"] = self.liveChannelHistory?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("LiveChannelHistory") && dict["LiveChannelHistory"] != nil {
            var model = GetLiveChannelHistoryResponse.LiveChannelHistory()
            model.fromMap(dict["LiveChannelHistory"] as! [String: Any])
            self.liveChannelHistory = model
        }
    }
}

public class GetBucketRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var delimiter: String?

        public var marker: String?

        public var maxKeys: String?

        public var prefix_: String?

        public var encodingType: String?

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
            if self.delimiter != nil {
                map["delimiter"] = self.delimiter!
            }
            if self.marker != nil {
                map["marker"] = self.marker!
            }
            if self.maxKeys != nil {
                map["max-keys"] = self.maxKeys!
            }
            if self.prefix_ != nil {
                map["prefix"] = self.prefix_!
            }
            if self.encodingType != nil {
                map["encoding-type"] = self.encodingType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("delimiter") && dict["delimiter"] != nil {
                self.delimiter = dict["delimiter"] as! String
            }
            if dict.keys.contains("marker") && dict["marker"] != nil {
                self.marker = dict["marker"] as! String
            }
            if dict.keys.contains("max-keys") && dict["max-keys"] != nil {
                self.maxKeys = dict["max-keys"] as! String
            }
            if dict.keys.contains("prefix") && dict["prefix"] != nil {
                self.prefix_ = dict["prefix"] as! String
            }
            if dict.keys.contains("encoding-type") && dict["encoding-type"] != nil {
                self.encodingType = dict["encoding-type"] as! String
            }
        }
    }
    public var bucketName: String?

    public var filter: GetBucketRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = GetBucketRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class GetBucketResponse : Tea.TeaModel {
    public class ListBucketResult : Tea.TeaModel {
        public class Contents : Tea.TeaModel {
            public class Owner : Tea.TeaModel {
                public var iD: String?

                public var displayName: String?

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
                    if self.iD != nil {
                        map["ID"] = self.iD!
                    }
                    if self.displayName != nil {
                        map["DisplayName"] = self.displayName!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("ID") && dict["ID"] != nil {
                        self.iD = dict["ID"] as! String
                    }
                    if dict.keys.contains("DisplayName") && dict["DisplayName"] != nil {
                        self.displayName = dict["DisplayName"] as! String
                    }
                }
            }
            public var key: String?

            public var eTag: String?

            public var lastModified: String?

            public var size: String?

            public var storageClass: String?

            public var owner: GetBucketResponse.ListBucketResult.Contents.Owner?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.validateRequired(self.owner, "owner")
                try self.owner?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.key != nil {
                    map["Key"] = self.key!
                }
                if self.eTag != nil {
                    map["ETag"] = self.eTag!
                }
                if self.lastModified != nil {
                    map["LastModified"] = self.lastModified!
                }
                if self.size != nil {
                    map["Size"] = self.size!
                }
                if self.storageClass != nil {
                    map["StorageClass"] = self.storageClass!
                }
                if self.owner != nil {
                    map["Owner"] = self.owner?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Key") && dict["Key"] != nil {
                    self.key = dict["Key"] as! String
                }
                if dict.keys.contains("ETag") && dict["ETag"] != nil {
                    self.eTag = dict["ETag"] as! String
                }
                if dict.keys.contains("LastModified") && dict["LastModified"] != nil {
                    self.lastModified = dict["LastModified"] as! String
                }
                if dict.keys.contains("Size") && dict["Size"] != nil {
                    self.size = dict["Size"] as! String
                }
                if dict.keys.contains("StorageClass") && dict["StorageClass"] != nil {
                    self.storageClass = dict["StorageClass"] as! String
                }
                if dict.keys.contains("Owner") && dict["Owner"] != nil {
                    var model = GetBucketResponse.ListBucketResult.Contents.Owner()
                    model.fromMap(dict["Owner"] as! [String: Any])
                    self.owner = model
                }
            }
        }
        public var name: String?

        public var prefix_: String?

        public var marker: String?

        public var maxKeys: String?

        public var delimiter: String?

        public var isTruncated: String?

        public var encodingType: String?

        public var commonPrefixes: String?

        public var contents: [GetBucketResponse.ListBucketResult.Contents]?

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
            if self.name != nil {
                map["Name"] = self.name!
            }
            if self.prefix_ != nil {
                map["Prefix"] = self.prefix_!
            }
            if self.marker != nil {
                map["Marker"] = self.marker!
            }
            if self.maxKeys != nil {
                map["MaxKeys"] = self.maxKeys!
            }
            if self.delimiter != nil {
                map["Delimiter"] = self.delimiter!
            }
            if self.isTruncated != nil {
                map["IsTruncated"] = self.isTruncated!
            }
            if self.encodingType != nil {
                map["EncodingType"] = self.encodingType!
            }
            if self.commonPrefixes != nil {
                map["CommonPrefixes"] = self.commonPrefixes!
            }
            if self.contents != nil {
                var tmp : [Any] = []
                for k in self.contents! {
                    tmp.append(k.toMap())
                }
                map["Contents"] = tmp
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Name") && dict["Name"] != nil {
                self.name = dict["Name"] as! String
            }
            if dict.keys.contains("Prefix") && dict["Prefix"] != nil {
                self.prefix_ = dict["Prefix"] as! String
            }
            if dict.keys.contains("Marker") && dict["Marker"] != nil {
                self.marker = dict["Marker"] as! String
            }
            if dict.keys.contains("MaxKeys") && dict["MaxKeys"] != nil {
                self.maxKeys = dict["MaxKeys"] as! String
            }
            if dict.keys.contains("Delimiter") && dict["Delimiter"] != nil {
                self.delimiter = dict["Delimiter"] as! String
            }
            if dict.keys.contains("IsTruncated") && dict["IsTruncated"] != nil {
                self.isTruncated = dict["IsTruncated"] as! String
            }
            if dict.keys.contains("EncodingType") && dict["EncodingType"] != nil {
                self.encodingType = dict["EncodingType"] as! String
            }
            if dict.keys.contains("CommonPrefixes") && dict["CommonPrefixes"] != nil {
                self.commonPrefixes = dict["CommonPrefixes"] as! String
            }
            if dict.keys.contains("Contents") && dict["Contents"] != nil {
                var tmp : [GetBucketResponse.ListBucketResult.Contents] = []
                for v in dict["Contents"] as! [Any] {
                    var model = GetBucketResponse.ListBucketResult.Contents()
                    if v != nil {
                        model.fromMap(v as! [String: Any])
                    }
                    tmp.append(model)
                }
                self.contents = tmp
            }
        }
    }
    public var requestId: String?

    public var listBucketResult: GetBucketResponse.ListBucketResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.listBucketResult, "listBucketResult")
        try self.listBucketResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.listBucketResult != nil {
            map["ListBucketResult"] = self.listBucketResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("ListBucketResult") && dict["ListBucketResult"] != nil {
            var model = GetBucketResponse.ListBucketResult()
            model.fromMap(dict["ListBucketResult"] as! [String: Any])
            self.listBucketResult = model
        }
    }
}

public class GetLiveChannelInfoRequest : Tea.TeaModel {
    public var bucketName: String?

    public var channelName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
    }
}

public class GetLiveChannelInfoResponse : Tea.TeaModel {
    public class LiveChannelConfiguration : Tea.TeaModel {
        public class Target : Tea.TeaModel {
            public var type: String?

            public var fragDuration: String?

            public var fragCount: String?

            public var playlistName: String?

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
                if self.type != nil {
                    map["Type"] = self.type!
                }
                if self.fragDuration != nil {
                    map["FragDuration"] = self.fragDuration!
                }
                if self.fragCount != nil {
                    map["FragCount"] = self.fragCount!
                }
                if self.playlistName != nil {
                    map["PlaylistName"] = self.playlistName!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Type") && dict["Type"] != nil {
                    self.type = dict["Type"] as! String
                }
                if dict.keys.contains("FragDuration") && dict["FragDuration"] != nil {
                    self.fragDuration = dict["FragDuration"] as! String
                }
                if dict.keys.contains("FragCount") && dict["FragCount"] != nil {
                    self.fragCount = dict["FragCount"] as! String
                }
                if dict.keys.contains("PlaylistName") && dict["PlaylistName"] != nil {
                    self.playlistName = dict["PlaylistName"] as! String
                }
            }
        }
        public var description_: String?

        public var status: String?

        public var target: GetLiveChannelInfoResponse.LiveChannelConfiguration.Target?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.target, "target")
            try self.target?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.description_ != nil {
                map["Description"] = self.description_!
            }
            if self.status != nil {
                map["Status"] = self.status!
            }
            if self.target != nil {
                map["Target"] = self.target?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Description") && dict["Description"] != nil {
                self.description_ = dict["Description"] as! String
            }
            if dict.keys.contains("Status") && dict["Status"] != nil {
                self.status = dict["Status"] as! String
            }
            if dict.keys.contains("Target") && dict["Target"] != nil {
                var model = GetLiveChannelInfoResponse.LiveChannelConfiguration.Target()
                model.fromMap(dict["Target"] as! [String: Any])
                self.target = model
            }
        }
    }
    public var requestId: String?

    public var liveChannelConfiguration: GetLiveChannelInfoResponse.LiveChannelConfiguration?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.liveChannelConfiguration, "liveChannelConfiguration")
        try self.liveChannelConfiguration?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.liveChannelConfiguration != nil {
            map["LiveChannelConfiguration"] = self.liveChannelConfiguration?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("LiveChannelConfiguration") && dict["LiveChannelConfiguration"] != nil {
            var model = GetLiveChannelInfoResponse.LiveChannelConfiguration()
            model.fromMap(dict["LiveChannelConfiguration"] as! [String: Any])
            self.liveChannelConfiguration = model
        }
    }
}

public class GetLiveChannelStatRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var comp: String?

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
            if self.comp != nil {
                map["comp"] = self.comp!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("comp") && dict["comp"] != nil {
                self.comp = dict["comp"] as! String
            }
        }
    }
    public var bucketName: String?

    public var channelName: String?

    public var filter: GetLiveChannelStatRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = GetLiveChannelStatRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class GetLiveChannelStatResponse : Tea.TeaModel {
    public class LiveChannelStat : Tea.TeaModel {
        public class Video : Tea.TeaModel {
            public var width: String?

            public var height: String?

            public var frameRate: String?

            public var bandwidth: String?

            public var codec: String?

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
                if self.width != nil {
                    map["Width"] = self.width!
                }
                if self.height != nil {
                    map["Height"] = self.height!
                }
                if self.frameRate != nil {
                    map["FrameRate"] = self.frameRate!
                }
                if self.bandwidth != nil {
                    map["Bandwidth"] = self.bandwidth!
                }
                if self.codec != nil {
                    map["Codec"] = self.codec!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Width") && dict["Width"] != nil {
                    self.width = dict["Width"] as! String
                }
                if dict.keys.contains("Height") && dict["Height"] != nil {
                    self.height = dict["Height"] as! String
                }
                if dict.keys.contains("FrameRate") && dict["FrameRate"] != nil {
                    self.frameRate = dict["FrameRate"] as! String
                }
                if dict.keys.contains("Bandwidth") && dict["Bandwidth"] != nil {
                    self.bandwidth = dict["Bandwidth"] as! String
                }
                if dict.keys.contains("Codec") && dict["Codec"] != nil {
                    self.codec = dict["Codec"] as! String
                }
            }
        }
        public class Audio : Tea.TeaModel {
            public var bandwidth: String?

            public var sampleRate: String?

            public var codec: String?

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
                if self.bandwidth != nil {
                    map["Bandwidth"] = self.bandwidth!
                }
                if self.sampleRate != nil {
                    map["SampleRate"] = self.sampleRate!
                }
                if self.codec != nil {
                    map["Codec"] = self.codec!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Bandwidth") && dict["Bandwidth"] != nil {
                    self.bandwidth = dict["Bandwidth"] as! String
                }
                if dict.keys.contains("SampleRate") && dict["SampleRate"] != nil {
                    self.sampleRate = dict["SampleRate"] as! String
                }
                if dict.keys.contains("Codec") && dict["Codec"] != nil {
                    self.codec = dict["Codec"] as! String
                }
            }
        }
        public var status: String?

        public var connectedTime: String?

        public var remoteAddr: String?

        public var video: GetLiveChannelStatResponse.LiveChannelStat.Video?

        public var audio: GetLiveChannelStatResponse.LiveChannelStat.Audio?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.video, "video")
            try self.video?.validate()
            try self.validateRequired(self.audio, "audio")
            try self.audio?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.status != nil {
                map["Status"] = self.status!
            }
            if self.connectedTime != nil {
                map["ConnectedTime"] = self.connectedTime!
            }
            if self.remoteAddr != nil {
                map["RemoteAddr"] = self.remoteAddr!
            }
            if self.video != nil {
                map["Video"] = self.video?.toMap()
            }
            if self.audio != nil {
                map["Audio"] = self.audio?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Status") && dict["Status"] != nil {
                self.status = dict["Status"] as! String
            }
            if dict.keys.contains("ConnectedTime") && dict["ConnectedTime"] != nil {
                self.connectedTime = dict["ConnectedTime"] as! String
            }
            if dict.keys.contains("RemoteAddr") && dict["RemoteAddr"] != nil {
                self.remoteAddr = dict["RemoteAddr"] as! String
            }
            if dict.keys.contains("Video") && dict["Video"] != nil {
                var model = GetLiveChannelStatResponse.LiveChannelStat.Video()
                model.fromMap(dict["Video"] as! [String: Any])
                self.video = model
            }
            if dict.keys.contains("Audio") && dict["Audio"] != nil {
                var model = GetLiveChannelStatResponse.LiveChannelStat.Audio()
                model.fromMap(dict["Audio"] as! [String: Any])
                self.audio = model
            }
        }
    }
    public var requestId: String?

    public var liveChannelStat: GetLiveChannelStatResponse.LiveChannelStat?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.liveChannelStat, "liveChannelStat")
        try self.liveChannelStat?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.liveChannelStat != nil {
            map["LiveChannelStat"] = self.liveChannelStat?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("LiveChannelStat") && dict["LiveChannelStat"] != nil {
            var model = GetLiveChannelStatResponse.LiveChannelStat()
            model.fromMap(dict["LiveChannelStat"] as! [String: Any])
            self.liveChannelStat = model
        }
    }
}

public class DeleteObjectRequest : Tea.TeaModel {
    public var bucketName: String?

    public var objectName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
    }
}

public class DeleteObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class AbortMultipartUploadRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var uploadId: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.uploadId, "uploadId")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.uploadId != nil {
                map["uploadId"] = self.uploadId!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("uploadId") && dict["uploadId"] != nil {
                self.uploadId = dict["uploadId"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var filter: AbortMultipartUploadRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = AbortMultipartUploadRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class AbortMultipartUploadResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class AppendObjectRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var position: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.position, "position")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.position != nil {
                map["position"] = self.position!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("position") && dict["position"] != nil {
                self.position = dict["position"] as! String
            }
        }
    }
    public class Header : Tea.TeaModel {
        public var cacheControl: String?

        public var contentDisposition: String?

        public var contentEncoding: String?

        public var contentMD5: String?

        public var expires: String?

        public var serverSideEncryption: String?

        public var objectAcl: String?

        public var storageClass: String?

        public var contentType: String?

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
            if self.cacheControl != nil {
                map["Cache-Control"] = self.cacheControl!
            }
            if self.contentDisposition != nil {
                map["Content-Disposition"] = self.contentDisposition!
            }
            if self.contentEncoding != nil {
                map["Content-Encoding"] = self.contentEncoding!
            }
            if self.contentMD5 != nil {
                map["Content-MD5"] = self.contentMD5!
            }
            if self.expires != nil {
                map["Expires"] = self.expires!
            }
            if self.serverSideEncryption != nil {
                map["x-oss-server-side-encryption"] = self.serverSideEncryption!
            }
            if self.objectAcl != nil {
                map["x-oss-object-acl"] = self.objectAcl!
            }
            if self.storageClass != nil {
                map["x-oss-storage-class"] = self.storageClass!
            }
            if self.contentType != nil {
                map["content-type"] = self.contentType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Cache-Control") && dict["Cache-Control"] != nil {
                self.cacheControl = dict["Cache-Control"] as! String
            }
            if dict.keys.contains("Content-Disposition") && dict["Content-Disposition"] != nil {
                self.contentDisposition = dict["Content-Disposition"] as! String
            }
            if dict.keys.contains("Content-Encoding") && dict["Content-Encoding"] != nil {
                self.contentEncoding = dict["Content-Encoding"] as! String
            }
            if dict.keys.contains("Content-MD5") && dict["Content-MD5"] != nil {
                self.contentMD5 = dict["Content-MD5"] as! String
            }
            if dict.keys.contains("Expires") && dict["Expires"] != nil {
                self.expires = dict["Expires"] as! String
            }
            if dict.keys.contains("x-oss-server-side-encryption") && dict["x-oss-server-side-encryption"] != nil {
                self.serverSideEncryption = dict["x-oss-server-side-encryption"] as! String
            }
            if dict.keys.contains("x-oss-object-acl") && dict["x-oss-object-acl"] != nil {
                self.objectAcl = dict["x-oss-object-acl"] as! String
            }
            if dict.keys.contains("x-oss-storage-class") && dict["x-oss-storage-class"] != nil {
                self.storageClass = dict["x-oss-storage-class"] as! String
            }
            if dict.keys.contains("content-type") && dict["content-type"] != nil {
                self.contentType = dict["content-type"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var userMeta: [String: String]?

    public var body: InputStream?

    public var filter: AppendObjectRequest.Filter?

    public var header: AppendObjectRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.userMeta != nil {
            map["UserMeta"] = self.userMeta!
        }
        if self.body != nil {
            map["body"] = self.body!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("UserMeta") && dict["UserMeta"] != nil {
            self.userMeta = dict["UserMeta"] as! [String: String]
        }
        if dict.keys.contains("body") && dict["body"] != nil {
            self.body = dict["body"] as! InputStream
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = AppendObjectRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = AppendObjectRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class AppendObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public var nextAppendPosition: String?

    public var hashCrc64ecma: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.nextAppendPosition, "nextAppendPosition")
        try self.validateRequired(self.hashCrc64ecma, "hashCrc64ecma")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.nextAppendPosition != nil {
            map["x-oss-next-append-position"] = self.nextAppendPosition!
        }
        if self.hashCrc64ecma != nil {
            map["x-oss-hash-crc64ecma"] = self.hashCrc64ecma!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("x-oss-next-append-position") && dict["x-oss-next-append-position"] != nil {
            self.nextAppendPosition = dict["x-oss-next-append-position"] as! String
        }
        if dict.keys.contains("x-oss-hash-crc64ecma") && dict["x-oss-hash-crc64ecma"] != nil {
            self.hashCrc64ecma = dict["x-oss-hash-crc64ecma"] as! String
        }
    }
}

public class UploadPartCopyRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var partNumber: String?

        public var uploadId: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.partNumber, "partNumber")
            try self.validateRequired(self.uploadId, "uploadId")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.partNumber != nil {
                map["partNumber"] = self.partNumber!
            }
            if self.uploadId != nil {
                map["uploadId"] = self.uploadId!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("partNumber") && dict["partNumber"] != nil {
                self.partNumber = dict["partNumber"] as! String
            }
            if dict.keys.contains("uploadId") && dict["uploadId"] != nil {
                self.uploadId = dict["uploadId"] as! String
            }
        }
    }
    public class Header : Tea.TeaModel {
        public var copySource: String?

        public var copySourceRange: String?

        public var copySourceIfMatch: String?

        public var copySourceIfNoneMatch: String?

        public var copySourceIfUnmodifiedSince: String?

        public var copySourceIfModifiedSince: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.copySource, "copySource")
            try self.validateRequired(self.copySourceRange, "copySourceRange")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.copySource != nil {
                map["x-oss-copy-source"] = self.copySource!
            }
            if self.copySourceRange != nil {
                map["x-oss-copy-source-range"] = self.copySourceRange!
            }
            if self.copySourceIfMatch != nil {
                map["x-oss-copy-source-if-match"] = self.copySourceIfMatch!
            }
            if self.copySourceIfNoneMatch != nil {
                map["x-oss-copy-source-if-none-match"] = self.copySourceIfNoneMatch!
            }
            if self.copySourceIfUnmodifiedSince != nil {
                map["x-oss-copy-source-if-unmodified-since"] = self.copySourceIfUnmodifiedSince!
            }
            if self.copySourceIfModifiedSince != nil {
                map["x-oss-copy-source-if-modified-since"] = self.copySourceIfModifiedSince!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("x-oss-copy-source") && dict["x-oss-copy-source"] != nil {
                self.copySource = dict["x-oss-copy-source"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-range") && dict["x-oss-copy-source-range"] != nil {
                self.copySourceRange = dict["x-oss-copy-source-range"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-match") && dict["x-oss-copy-source-if-match"] != nil {
                self.copySourceIfMatch = dict["x-oss-copy-source-if-match"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-none-match") && dict["x-oss-copy-source-if-none-match"] != nil {
                self.copySourceIfNoneMatch = dict["x-oss-copy-source-if-none-match"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-unmodified-since") && dict["x-oss-copy-source-if-unmodified-since"] != nil {
                self.copySourceIfUnmodifiedSince = dict["x-oss-copy-source-if-unmodified-since"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-modified-since") && dict["x-oss-copy-source-if-modified-since"] != nil {
                self.copySourceIfModifiedSince = dict["x-oss-copy-source-if-modified-since"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var filter: UploadPartCopyRequest.Filter?

    public var header: UploadPartCopyRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = UploadPartCopyRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = UploadPartCopyRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class UploadPartCopyResponse : Tea.TeaModel {
    public class CopyPartResult : Tea.TeaModel {
        public var lastModified: String?

        public var eTag: String?

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
            if self.lastModified != nil {
                map["LastModified"] = self.lastModified!
            }
            if self.eTag != nil {
                map["ETag"] = self.eTag!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("LastModified") && dict["LastModified"] != nil {
                self.lastModified = dict["LastModified"] as! String
            }
            if dict.keys.contains("ETag") && dict["ETag"] != nil {
                self.eTag = dict["ETag"] as! String
            }
        }
    }
    public var requestId: String?

    public var copyPartResult: UploadPartCopyResponse.CopyPartResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.copyPartResult, "copyPartResult")
        try self.copyPartResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.copyPartResult != nil {
            map["CopyPartResult"] = self.copyPartResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("CopyPartResult") && dict["CopyPartResult"] != nil {
            var model = UploadPartCopyResponse.CopyPartResult()
            model.fromMap(dict["CopyPartResult"] as! [String: Any])
            self.copyPartResult = model
        }
    }
}

public class GetVodPlaylistRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var endTime: String?

        public var startTime: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.endTime, "endTime")
            try self.validateRequired(self.startTime, "startTime")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.endTime != nil {
                map["endTime"] = self.endTime!
            }
            if self.startTime != nil {
                map["startTime"] = self.startTime!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("endTime") && dict["endTime"] != nil {
                self.endTime = dict["endTime"] as! String
            }
            if dict.keys.contains("startTime") && dict["startTime"] != nil {
                self.startTime = dict["startTime"] as! String
            }
        }
    }
    public var bucketName: String?

    public var channelName: String?

    public var filter: GetVodPlaylistRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = GetVodPlaylistRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class GetVodPlaylistResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class DeleteBucketCORSRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class DeleteBucketCORSResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetObjectRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var responseContentType: String?

        public var responseContentLanguage: String?

        public var responseExpires: String?

        public var responseCacheControl: String?

        public var responseContentDisposition: String?

        public var responseContentEncoding: String?

        public var range: String?

        public var ifModifiedSince: String?

        public var ifUnmodifiedSince: String?

        public var ifMatch: String?

        public var ifNoneMatch: String?

        public var acceptEncoding: String?

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
            if self.responseContentType != nil {
                map["response-content-type"] = self.responseContentType!
            }
            if self.responseContentLanguage != nil {
                map["response-content-language"] = self.responseContentLanguage!
            }
            if self.responseExpires != nil {
                map["response-expires"] = self.responseExpires!
            }
            if self.responseCacheControl != nil {
                map["response-cache-control"] = self.responseCacheControl!
            }
            if self.responseContentDisposition != nil {
                map["response-content-disposition"] = self.responseContentDisposition!
            }
            if self.responseContentEncoding != nil {
                map["response-content-encoding"] = self.responseContentEncoding!
            }
            if self.range != nil {
                map["Range"] = self.range!
            }
            if self.ifModifiedSince != nil {
                map["If-Modified-Since"] = self.ifModifiedSince!
            }
            if self.ifUnmodifiedSince != nil {
                map["If-Unmodified-Since"] = self.ifUnmodifiedSince!
            }
            if self.ifMatch != nil {
                map["If-Match"] = self.ifMatch!
            }
            if self.ifNoneMatch != nil {
                map["If-None-Match"] = self.ifNoneMatch!
            }
            if self.acceptEncoding != nil {
                map["Accept-Encoding"] = self.acceptEncoding!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("response-content-type") && dict["response-content-type"] != nil {
                self.responseContentType = dict["response-content-type"] as! String
            }
            if dict.keys.contains("response-content-language") && dict["response-content-language"] != nil {
                self.responseContentLanguage = dict["response-content-language"] as! String
            }
            if dict.keys.contains("response-expires") && dict["response-expires"] != nil {
                self.responseExpires = dict["response-expires"] as! String
            }
            if dict.keys.contains("response-cache-control") && dict["response-cache-control"] != nil {
                self.responseCacheControl = dict["response-cache-control"] as! String
            }
            if dict.keys.contains("response-content-disposition") && dict["response-content-disposition"] != nil {
                self.responseContentDisposition = dict["response-content-disposition"] as! String
            }
            if dict.keys.contains("response-content-encoding") && dict["response-content-encoding"] != nil {
                self.responseContentEncoding = dict["response-content-encoding"] as! String
            }
            if dict.keys.contains("Range") && dict["Range"] != nil {
                self.range = dict["Range"] as! String
            }
            if dict.keys.contains("If-Modified-Since") && dict["If-Modified-Since"] != nil {
                self.ifModifiedSince = dict["If-Modified-Since"] as! String
            }
            if dict.keys.contains("If-Unmodified-Since") && dict["If-Unmodified-Since"] != nil {
                self.ifUnmodifiedSince = dict["If-Unmodified-Since"] as! String
            }
            if dict.keys.contains("If-Match") && dict["If-Match"] != nil {
                self.ifMatch = dict["If-Match"] as! String
            }
            if dict.keys.contains("If-None-Match") && dict["If-None-Match"] != nil {
                self.ifNoneMatch = dict["If-None-Match"] as! String
            }
            if dict.keys.contains("Accept-Encoding") && dict["Accept-Encoding"] != nil {
                self.acceptEncoding = dict["Accept-Encoding"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var header: GetObjectRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = GetObjectRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class GetObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public var objectType: String?

    public var serverSideEncryption: String?

    public var taggingCount: String?

    public var restore: String?

    public var body: InputStream?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.objectType, "objectType")
        try self.validateRequired(self.serverSideEncryption, "serverSideEncryption")
        try self.validateRequired(self.taggingCount, "taggingCount")
        try self.validateRequired(self.restore, "restore")
        try self.validateRequired(self.body, "body")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.objectType != nil {
            map["x-oss-object-type"] = self.objectType!
        }
        if self.serverSideEncryption != nil {
            map["x-oss-server-side-encryption"] = self.serverSideEncryption!
        }
        if self.taggingCount != nil {
            map["x-oss-tagging-count"] = self.taggingCount!
        }
        if self.restore != nil {
            map["x-oss-restore"] = self.restore!
        }
        if self.body != nil {
            map["body"] = self.body!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("x-oss-object-type") && dict["x-oss-object-type"] != nil {
            self.objectType = dict["x-oss-object-type"] as! String
        }
        if dict.keys.contains("x-oss-server-side-encryption") && dict["x-oss-server-side-encryption"] != nil {
            self.serverSideEncryption = dict["x-oss-server-side-encryption"] as! String
        }
        if dict.keys.contains("x-oss-tagging-count") && dict["x-oss-tagging-count"] != nil {
            self.taggingCount = dict["x-oss-tagging-count"] as! String
        }
        if dict.keys.contains("x-oss-restore") && dict["x-oss-restore"] != nil {
            self.restore = dict["x-oss-restore"] as! String
        }
        if dict.keys.contains("body") && dict["body"] != nil {
            self.body = dict["body"] as! InputStream
        }
    }
}

public class UploadPartRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var partNumber: String?

        public var uploadId: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.partNumber, "partNumber")
            try self.validateRequired(self.uploadId, "uploadId")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.partNumber != nil {
                map["partNumber"] = self.partNumber!
            }
            if self.uploadId != nil {
                map["uploadId"] = self.uploadId!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("partNumber") && dict["partNumber"] != nil {
                self.partNumber = dict["partNumber"] as! String
            }
            if dict.keys.contains("uploadId") && dict["uploadId"] != nil {
                self.uploadId = dict["uploadId"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var body: InputStream?

    public var filter: UploadPartRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.body != nil {
            map["body"] = self.body!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("body") && dict["body"] != nil {
            self.body = dict["body"] as! InputStream
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = UploadPartRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class UploadPartResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetBucketCORSRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketCORSResponse : Tea.TeaModel {
    public class CORSConfiguration : Tea.TeaModel {
        public class CORSRule : Tea.TeaModel {
            public var maxAgeSeconds: String?

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
                if self.maxAgeSeconds != nil {
                    map["MaxAgeSeconds"] = self.maxAgeSeconds!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("MaxAgeSeconds") && dict["MaxAgeSeconds"] != nil {
                    self.maxAgeSeconds = dict["MaxAgeSeconds"] as! String
                }
            }
        }
        public var cORSRule: [GetBucketCORSResponse.CORSConfiguration.CORSRule]?

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
            if self.cORSRule != nil {
                var tmp : [Any] = []
                for k in self.cORSRule! {
                    tmp.append(k.toMap())
                }
                map["CORSRule"] = tmp
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("CORSRule") && dict["CORSRule"] != nil {
                var tmp : [GetBucketCORSResponse.CORSConfiguration.CORSRule] = []
                for v in dict["CORSRule"] as! [Any] {
                    var model = GetBucketCORSResponse.CORSConfiguration.CORSRule()
                    if v != nil {
                        model.fromMap(v as! [String: Any])
                    }
                    tmp.append(model)
                }
                self.cORSRule = tmp
            }
        }
    }
    public var requestId: String?

    public var cORSConfiguration: GetBucketCORSResponse.CORSConfiguration?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.cORSConfiguration, "cORSConfiguration")
        try self.cORSConfiguration?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.cORSConfiguration != nil {
            map["CORSConfiguration"] = self.cORSConfiguration?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("CORSConfiguration") && dict["CORSConfiguration"] != nil {
            var model = GetBucketCORSResponse.CORSConfiguration()
            model.fromMap(dict["CORSConfiguration"] as! [String: Any])
            self.cORSConfiguration = model
        }
    }
}

public class CopyObjectRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var copySource: String?

        public var copySourceIfMatch: String?

        public var copySourceIfNoneMatch: String?

        public var copySourceIfUnmodifiedSince: String?

        public var copySourceIfModifiedSince: String?

        public var metadataDirective: String?

        public var serverSideEncryption: String?

        public var serverSideEncryptionKeyId: String?

        public var objectAcl: String?

        public var storageClass: String?

        public var tagging: String?

        public var taggingDirective: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.copySource, "copySource")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.copySource != nil {
                map["x-oss-copy-source"] = self.copySource!
            }
            if self.copySourceIfMatch != nil {
                map["x-oss-copy-source-if-match"] = self.copySourceIfMatch!
            }
            if self.copySourceIfNoneMatch != nil {
                map["x-oss-copy-source-if-none-match"] = self.copySourceIfNoneMatch!
            }
            if self.copySourceIfUnmodifiedSince != nil {
                map["x-oss-copy-source-if-unmodified-since"] = self.copySourceIfUnmodifiedSince!
            }
            if self.copySourceIfModifiedSince != nil {
                map["x-oss-copy-source-if-modified-since"] = self.copySourceIfModifiedSince!
            }
            if self.metadataDirective != nil {
                map["x-oss-metadata-directive"] = self.metadataDirective!
            }
            if self.serverSideEncryption != nil {
                map["x-oss-server-side-encryption"] = self.serverSideEncryption!
            }
            if self.serverSideEncryptionKeyId != nil {
                map["x-oss-server-side-encryption-key-id"] = self.serverSideEncryptionKeyId!
            }
            if self.objectAcl != nil {
                map["x-oss-object-acl"] = self.objectAcl!
            }
            if self.storageClass != nil {
                map["x-oss-storage-class"] = self.storageClass!
            }
            if self.tagging != nil {
                map["x-oss-tagging"] = self.tagging!
            }
            if self.taggingDirective != nil {
                map["x-oss-tagging-directive"] = self.taggingDirective!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("x-oss-copy-source") && dict["x-oss-copy-source"] != nil {
                self.copySource = dict["x-oss-copy-source"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-match") && dict["x-oss-copy-source-if-match"] != nil {
                self.copySourceIfMatch = dict["x-oss-copy-source-if-match"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-none-match") && dict["x-oss-copy-source-if-none-match"] != nil {
                self.copySourceIfNoneMatch = dict["x-oss-copy-source-if-none-match"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-unmodified-since") && dict["x-oss-copy-source-if-unmodified-since"] != nil {
                self.copySourceIfUnmodifiedSince = dict["x-oss-copy-source-if-unmodified-since"] as! String
            }
            if dict.keys.contains("x-oss-copy-source-if-modified-since") && dict["x-oss-copy-source-if-modified-since"] != nil {
                self.copySourceIfModifiedSince = dict["x-oss-copy-source-if-modified-since"] as! String
            }
            if dict.keys.contains("x-oss-metadata-directive") && dict["x-oss-metadata-directive"] != nil {
                self.metadataDirective = dict["x-oss-metadata-directive"] as! String
            }
            if dict.keys.contains("x-oss-server-side-encryption") && dict["x-oss-server-side-encryption"] != nil {
                self.serverSideEncryption = dict["x-oss-server-side-encryption"] as! String
            }
            if dict.keys.contains("x-oss-server-side-encryption-key-id") && dict["x-oss-server-side-encryption-key-id"] != nil {
                self.serverSideEncryptionKeyId = dict["x-oss-server-side-encryption-key-id"] as! String
            }
            if dict.keys.contains("x-oss-object-acl") && dict["x-oss-object-acl"] != nil {
                self.objectAcl = dict["x-oss-object-acl"] as! String
            }
            if dict.keys.contains("x-oss-storage-class") && dict["x-oss-storage-class"] != nil {
                self.storageClass = dict["x-oss-storage-class"] as! String
            }
            if dict.keys.contains("x-oss-tagging") && dict["x-oss-tagging"] != nil {
                self.tagging = dict["x-oss-tagging"] as! String
            }
            if dict.keys.contains("x-oss-tagging-directive") && dict["x-oss-tagging-directive"] != nil {
                self.taggingDirective = dict["x-oss-tagging-directive"] as! String
            }
        }
    }
    public var bucketName: String?

    public var destObjectName: String?

    public var header: CopyObjectRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.destObjectName, "destObjectName")
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.destObjectName != nil {
            map["DestObjectName"] = self.destObjectName!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("DestObjectName") && dict["DestObjectName"] != nil {
            self.destObjectName = dict["DestObjectName"] as! String
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = CopyObjectRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class CopyObjectResponse : Tea.TeaModel {
    public class CopyObjectResult : Tea.TeaModel {
        public var lastModified: String?

        public var eTag: String?

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
            if self.lastModified != nil {
                map["LastModified"] = self.lastModified!
            }
            if self.eTag != nil {
                map["ETag"] = self.eTag!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("LastModified") && dict["LastModified"] != nil {
                self.lastModified = dict["LastModified"] as! String
            }
            if dict.keys.contains("ETag") && dict["ETag"] != nil {
                self.eTag = dict["ETag"] as! String
            }
        }
    }
    public var requestId: String?

    public var copyObjectResult: CopyObjectResponse.CopyObjectResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.copyObjectResult, "copyObjectResult")
        try self.copyObjectResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.copyObjectResult != nil {
            map["CopyObjectResult"] = self.copyObjectResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("CopyObjectResult") && dict["CopyObjectResult"] != nil {
            var model = CopyObjectResponse.CopyObjectResult()
            model.fromMap(dict["CopyObjectResult"] as! [String: Any])
            self.copyObjectResult = model
        }
    }
}

public class GetObjectTaggingRequest : Tea.TeaModel {
    public var bucketName: String?

    public var objectName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
    }
}

public class GetObjectTaggingResponse : Tea.TeaModel {
    public class Tagging : Tea.TeaModel {
        public class TagSet : Tea.TeaModel {
            public class Tag : Tea.TeaModel {
                public var key: String?

                public var value: String?

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
                    if self.key != nil {
                        map["Key"] = self.key!
                    }
                    if self.value != nil {
                        map["Value"] = self.value!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Key") && dict["Key"] != nil {
                        self.key = dict["Key"] as! String
                    }
                    if dict.keys.contains("Value") && dict["Value"] != nil {
                        self.value = dict["Value"] as! String
                    }
                }
            }
            public var tag: [GetObjectTaggingResponse.Tagging.TagSet.Tag]?

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
                if self.tag != nil {
                    var tmp : [Any] = []
                    for k in self.tag! {
                        tmp.append(k.toMap())
                    }
                    map["Tag"] = tmp
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Tag") && dict["Tag"] != nil {
                    var tmp : [GetObjectTaggingResponse.Tagging.TagSet.Tag] = []
                    for v in dict["Tag"] as! [Any] {
                        var model = GetObjectTaggingResponse.Tagging.TagSet.Tag()
                        if v != nil {
                            model.fromMap(v as! [String: Any])
                        }
                        tmp.append(model)
                    }
                    self.tag = tmp
                }
            }
        }
        public var tagSet: GetObjectTaggingResponse.Tagging.TagSet?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.tagSet, "tagSet")
            try self.tagSet?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.tagSet != nil {
                map["TagSet"] = self.tagSet?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("TagSet") && dict["TagSet"] != nil {
                var model = GetObjectTaggingResponse.Tagging.TagSet()
                model.fromMap(dict["TagSet"] as! [String: Any])
                self.tagSet = model
            }
        }
    }
    public var requestId: String?

    public var tagging: GetObjectTaggingResponse.Tagging?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.tagging, "tagging")
        try self.tagging?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.tagging != nil {
            map["Tagging"] = self.tagging?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("Tagging") && dict["Tagging"] != nil {
            var model = GetObjectTaggingResponse.Tagging()
            model.fromMap(dict["Tagging"] as! [String: Any])
            self.tagging = model
        }
    }
}

public class DeleteBucketLifecycleRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class DeleteBucketLifecycleResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class DeleteBucketLoggingRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class DeleteBucketLoggingResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class DeleteBucketWebsiteRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class DeleteBucketWebsiteResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetSymlinkRequest : Tea.TeaModel {
    public var bucketName: String?

    public var objectName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
    }
}

public class GetSymlinkResponse : Tea.TeaModel {
    public var requestId: String?

    public var symlinkTarget: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.symlinkTarget, "symlinkTarget")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.symlinkTarget != nil {
            map["x-oss-symlink-target"] = self.symlinkTarget!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("x-oss-symlink-target") && dict["x-oss-symlink-target"] != nil {
            self.symlinkTarget = dict["x-oss-symlink-target"] as! String
        }
    }
}

public class GetBucketLifecycleRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketLifecycleResponse : Tea.TeaModel {
    public class LifecycleConfiguration : Tea.TeaModel {
        public class Rule : Tea.TeaModel {
            public class Expiration : Tea.TeaModel {
                public var days: Int?

                public var createdBeforeDate: String?

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
                    if self.days != nil {
                        map["Days"] = self.days!
                    }
                    if self.createdBeforeDate != nil {
                        map["CreatedBeforeDate"] = self.createdBeforeDate!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Days") && dict["Days"] != nil {
                        self.days = dict["Days"] as! Int
                    }
                    if dict.keys.contains("CreatedBeforeDate") && dict["CreatedBeforeDate"] != nil {
                        self.createdBeforeDate = dict["CreatedBeforeDate"] as! String
                    }
                }
            }
            public class Transition : Tea.TeaModel {
                public var days: Int?

                public var storageClass: String?

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
                    if self.days != nil {
                        map["Days"] = self.days!
                    }
                    if self.storageClass != nil {
                        map["StorageClass"] = self.storageClass!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Days") && dict["Days"] != nil {
                        self.days = dict["Days"] as! Int
                    }
                    if dict.keys.contains("StorageClass") && dict["StorageClass"] != nil {
                        self.storageClass = dict["StorageClass"] as! String
                    }
                }
            }
            public class AbortMultipartUpload : Tea.TeaModel {
                public var days: Int?

                public var createdBeforeDate: String?

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
                    if self.days != nil {
                        map["Days"] = self.days!
                    }
                    if self.createdBeforeDate != nil {
                        map["CreatedBeforeDate"] = self.createdBeforeDate!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Days") && dict["Days"] != nil {
                        self.days = dict["Days"] as! Int
                    }
                    if dict.keys.contains("CreatedBeforeDate") && dict["CreatedBeforeDate"] != nil {
                        self.createdBeforeDate = dict["CreatedBeforeDate"] as! String
                    }
                }
            }
            public class Tag : Tea.TeaModel {
                public var key: String?

                public var value: String?

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
                    if self.key != nil {
                        map["Key"] = self.key!
                    }
                    if self.value != nil {
                        map["Value"] = self.value!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Key") && dict["Key"] != nil {
                        self.key = dict["Key"] as! String
                    }
                    if dict.keys.contains("Value") && dict["Value"] != nil {
                        self.value = dict["Value"] as! String
                    }
                }
            }
            public var iD: String?

            public var prefix_: String?

            public var status: String?

            public var expiration: GetBucketLifecycleResponse.LifecycleConfiguration.Rule.Expiration?

            public var transition: GetBucketLifecycleResponse.LifecycleConfiguration.Rule.Transition?

            public var abortMultipartUpload: GetBucketLifecycleResponse.LifecycleConfiguration.Rule.AbortMultipartUpload?

            public var tag: GetBucketLifecycleResponse.LifecycleConfiguration.Rule.Tag?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.validateRequired(self.expiration, "expiration")
                try self.expiration?.validate()
                try self.validateRequired(self.transition, "transition")
                try self.transition?.validate()
                try self.validateRequired(self.abortMultipartUpload, "abortMultipartUpload")
                try self.abortMultipartUpload?.validate()
                try self.validateRequired(self.tag, "tag")
                try self.tag?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.iD != nil {
                    map["ID"] = self.iD!
                }
                if self.prefix_ != nil {
                    map["Prefix"] = self.prefix_!
                }
                if self.status != nil {
                    map["Status"] = self.status!
                }
                if self.expiration != nil {
                    map["Expiration"] = self.expiration?.toMap()
                }
                if self.transition != nil {
                    map["Transition"] = self.transition?.toMap()
                }
                if self.abortMultipartUpload != nil {
                    map["AbortMultipartUpload"] = self.abortMultipartUpload?.toMap()
                }
                if self.tag != nil {
                    map["Tag"] = self.tag?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("ID") && dict["ID"] != nil {
                    self.iD = dict["ID"] as! String
                }
                if dict.keys.contains("Prefix") && dict["Prefix"] != nil {
                    self.prefix_ = dict["Prefix"] as! String
                }
                if dict.keys.contains("Status") && dict["Status"] != nil {
                    self.status = dict["Status"] as! String
                }
                if dict.keys.contains("Expiration") && dict["Expiration"] != nil {
                    var model = GetBucketLifecycleResponse.LifecycleConfiguration.Rule.Expiration()
                    model.fromMap(dict["Expiration"] as! [String: Any])
                    self.expiration = model
                }
                if dict.keys.contains("Transition") && dict["Transition"] != nil {
                    var model = GetBucketLifecycleResponse.LifecycleConfiguration.Rule.Transition()
                    model.fromMap(dict["Transition"] as! [String: Any])
                    self.transition = model
                }
                if dict.keys.contains("AbortMultipartUpload") && dict["AbortMultipartUpload"] != nil {
                    var model = GetBucketLifecycleResponse.LifecycleConfiguration.Rule.AbortMultipartUpload()
                    model.fromMap(dict["AbortMultipartUpload"] as! [String: Any])
                    self.abortMultipartUpload = model
                }
                if dict.keys.contains("Tag") && dict["Tag"] != nil {
                    var model = GetBucketLifecycleResponse.LifecycleConfiguration.Rule.Tag()
                    model.fromMap(dict["Tag"] as! [String: Any])
                    self.tag = model
                }
            }
        }
        public var rule: [GetBucketLifecycleResponse.LifecycleConfiguration.Rule]?

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
            if self.rule != nil {
                var tmp : [Any] = []
                for k in self.rule! {
                    tmp.append(k.toMap())
                }
                map["Rule"] = tmp
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Rule") && dict["Rule"] != nil {
                var tmp : [GetBucketLifecycleResponse.LifecycleConfiguration.Rule] = []
                for v in dict["Rule"] as! [Any] {
                    var model = GetBucketLifecycleResponse.LifecycleConfiguration.Rule()
                    if v != nil {
                        model.fromMap(v as! [String: Any])
                    }
                    tmp.append(model)
                }
                self.rule = tmp
            }
        }
    }
    public var requestId: String?

    public var lifecycleConfiguration: GetBucketLifecycleResponse.LifecycleConfiguration?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.lifecycleConfiguration, "lifecycleConfiguration")
        try self.lifecycleConfiguration?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.lifecycleConfiguration != nil {
            map["LifecycleConfiguration"] = self.lifecycleConfiguration?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("LifecycleConfiguration") && dict["LifecycleConfiguration"] != nil {
            var model = GetBucketLifecycleResponse.LifecycleConfiguration()
            model.fromMap(dict["LifecycleConfiguration"] as! [String: Any])
            self.lifecycleConfiguration = model
        }
    }
}

public class PutSymlinkRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var symlinkTarget: String?

        public var storageClass: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.symlinkTarget, "symlinkTarget")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.symlinkTarget != nil {
                map["x-oss-symlink-target"] = self.symlinkTarget!
            }
            if self.storageClass != nil {
                map["x-oss-storage-class"] = self.storageClass!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("x-oss-symlink-target") && dict["x-oss-symlink-target"] != nil {
                self.symlinkTarget = dict["x-oss-symlink-target"] as! String
            }
            if dict.keys.contains("x-oss-storage-class") && dict["x-oss-storage-class"] != nil {
                self.storageClass = dict["x-oss-storage-class"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var header: PutSymlinkRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = PutSymlinkRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class PutSymlinkResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetBucketRefererRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketRefererResponse : Tea.TeaModel {
    public class RefererConfiguration : Tea.TeaModel {
        public class RefererList : Tea.TeaModel {
            public var referer: [String]?

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
                if self.referer != nil {
                    map["Referer"] = self.referer!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Referer") && dict["Referer"] != nil {
                    self.referer = dict["Referer"] as! [String]
                }
            }
        }
        public var allowEmptyReferer: Bool?

        public var refererList: GetBucketRefererResponse.RefererConfiguration.RefererList?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.refererList, "refererList")
            try self.refererList?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.allowEmptyReferer != nil {
                map["AllowEmptyReferer"] = self.allowEmptyReferer!
            }
            if self.refererList != nil {
                map["RefererList"] = self.refererList?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("AllowEmptyReferer") && dict["AllowEmptyReferer"] != nil {
                self.allowEmptyReferer = dict["AllowEmptyReferer"] as! Bool
            }
            if dict.keys.contains("RefererList") && dict["RefererList"] != nil {
                var model = GetBucketRefererResponse.RefererConfiguration.RefererList()
                model.fromMap(dict["RefererList"] as! [String: Any])
                self.refererList = model
            }
        }
    }
    public var requestId: String?

    public var refererConfiguration: GetBucketRefererResponse.RefererConfiguration?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.refererConfiguration, "refererConfiguration")
        try self.refererConfiguration?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.refererConfiguration != nil {
            map["RefererConfiguration"] = self.refererConfiguration?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("RefererConfiguration") && dict["RefererConfiguration"] != nil {
            var model = GetBucketRefererResponse.RefererConfiguration()
            model.fromMap(dict["RefererConfiguration"] as! [String: Any])
            self.refererConfiguration = model
        }
    }
}

public class CallbackRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class CallbackResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetBucketLoggingRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketLoggingResponse : Tea.TeaModel {
    public class BucketLoggingStatus : Tea.TeaModel {
        public class LoggingEnabled : Tea.TeaModel {
            public var targetBucket: String?

            public var targetPrefix: String?

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
                if self.targetBucket != nil {
                    map["TargetBucket"] = self.targetBucket!
                }
                if self.targetPrefix != nil {
                    map["TargetPrefix"] = self.targetPrefix!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("TargetBucket") && dict["TargetBucket"] != nil {
                    self.targetBucket = dict["TargetBucket"] as! String
                }
                if dict.keys.contains("TargetPrefix") && dict["TargetPrefix"] != nil {
                    self.targetPrefix = dict["TargetPrefix"] as! String
                }
            }
        }
        public var loggingEnabled: GetBucketLoggingResponse.BucketLoggingStatus.LoggingEnabled?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.loggingEnabled, "loggingEnabled")
            try self.loggingEnabled?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.loggingEnabled != nil {
                map["LoggingEnabled"] = self.loggingEnabled?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("LoggingEnabled") && dict["LoggingEnabled"] != nil {
                var model = GetBucketLoggingResponse.BucketLoggingStatus.LoggingEnabled()
                model.fromMap(dict["LoggingEnabled"] as! [String: Any])
                self.loggingEnabled = model
            }
        }
    }
    public var requestId: String?

    public var bucketLoggingStatus: GetBucketLoggingResponse.BucketLoggingStatus?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.bucketLoggingStatus, "bucketLoggingStatus")
        try self.bucketLoggingStatus?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.bucketLoggingStatus != nil {
            map["BucketLoggingStatus"] = self.bucketLoggingStatus?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("BucketLoggingStatus") && dict["BucketLoggingStatus"] != nil {
            var model = GetBucketLoggingResponse.BucketLoggingStatus()
            model.fromMap(dict["BucketLoggingStatus"] as! [String: Any])
            self.bucketLoggingStatus = model
        }
    }
}

public class PutObjectAclRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var objectAcl: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.objectAcl, "objectAcl")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.objectAcl != nil {
                map["x-oss-object-acl"] = self.objectAcl!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("x-oss-object-acl") && dict["x-oss-object-acl"] != nil {
                self.objectAcl = dict["x-oss-object-acl"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var header: PutObjectAclRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = PutObjectAclRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class PutObjectAclResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetBucketInfoRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class GetBucketInfoResponse : Tea.TeaModel {
    public class BucketInfo : Tea.TeaModel {
        public class Bucket : Tea.TeaModel {
            public class Owner : Tea.TeaModel {
                public var iD: String?

                public var displayName: String?

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
                    if self.iD != nil {
                        map["ID"] = self.iD!
                    }
                    if self.displayName != nil {
                        map["DisplayName"] = self.displayName!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("ID") && dict["ID"] != nil {
                        self.iD = dict["ID"] as! String
                    }
                    if dict.keys.contains("DisplayName") && dict["DisplayName"] != nil {
                        self.displayName = dict["DisplayName"] as! String
                    }
                }
            }
            public class AccessControlList : Tea.TeaModel {
                public var grant: String?

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
                    if self.grant != nil {
                        map["Grant"] = self.grant!
                    }
                    return map
                }

                public override func fromMap(_ dict: [String: Any]) -> Void {
                    if dict.keys.contains("Grant") && dict["Grant"] != nil {
                        self.grant = dict["Grant"] as! String
                    }
                }
            }
            public var creationDate: String?

            public var extranetEndpoint: String?

            public var intranetEndpoint: String?

            public var location: String?

            public var name: String?

            public var dataRedundancyType: String?

            public var storageClass: String?

            public var comment: String?

            public var owner: GetBucketInfoResponse.BucketInfo.Bucket.Owner?

            public var accessControlList: GetBucketInfoResponse.BucketInfo.Bucket.AccessControlList?

            public override init() {
                super.init()
            }

            public init(_ dict: [String: Any]) {
                super.init()
                self.fromMap(dict)
            }

            public override func validate() throws -> Void {
                try self.validateRequired(self.owner, "owner")
                try self.owner?.validate()
                try self.validateRequired(self.accessControlList, "accessControlList")
                try self.accessControlList?.validate()
            }

            public override func toMap() -> [String : Any] {
                var map = super.toMap()
                if self.creationDate != nil {
                    map["CreationDate"] = self.creationDate!
                }
                if self.extranetEndpoint != nil {
                    map["ExtranetEndpoint"] = self.extranetEndpoint!
                }
                if self.intranetEndpoint != nil {
                    map["IntranetEndpoint"] = self.intranetEndpoint!
                }
                if self.location != nil {
                    map["Location"] = self.location!
                }
                if self.name != nil {
                    map["Name"] = self.name!
                }
                if self.dataRedundancyType != nil {
                    map["DataRedundancyType"] = self.dataRedundancyType!
                }
                if self.storageClass != nil {
                    map["StorageClass"] = self.storageClass!
                }
                if self.comment != nil {
                    map["Comment"] = self.comment!
                }
                if self.owner != nil {
                    map["Owner"] = self.owner?.toMap()
                }
                if self.accessControlList != nil {
                    map["AccessControlList"] = self.accessControlList?.toMap()
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("CreationDate") && dict["CreationDate"] != nil {
                    self.creationDate = dict["CreationDate"] as! String
                }
                if dict.keys.contains("ExtranetEndpoint") && dict["ExtranetEndpoint"] != nil {
                    self.extranetEndpoint = dict["ExtranetEndpoint"] as! String
                }
                if dict.keys.contains("IntranetEndpoint") && dict["IntranetEndpoint"] != nil {
                    self.intranetEndpoint = dict["IntranetEndpoint"] as! String
                }
                if dict.keys.contains("Location") && dict["Location"] != nil {
                    self.location = dict["Location"] as! String
                }
                if dict.keys.contains("Name") && dict["Name"] != nil {
                    self.name = dict["Name"] as! String
                }
                if dict.keys.contains("DataRedundancyType") && dict["DataRedundancyType"] != nil {
                    self.dataRedundancyType = dict["DataRedundancyType"] as! String
                }
                if dict.keys.contains("StorageClass") && dict["StorageClass"] != nil {
                    self.storageClass = dict["StorageClass"] as! String
                }
                if dict.keys.contains("Comment") && dict["Comment"] != nil {
                    self.comment = dict["Comment"] as! String
                }
                if dict.keys.contains("Owner") && dict["Owner"] != nil {
                    var model = GetBucketInfoResponse.BucketInfo.Bucket.Owner()
                    model.fromMap(dict["Owner"] as! [String: Any])
                    self.owner = model
                }
                if dict.keys.contains("AccessControlList") && dict["AccessControlList"] != nil {
                    var model = GetBucketInfoResponse.BucketInfo.Bucket.AccessControlList()
                    model.fromMap(dict["AccessControlList"] as! [String: Any])
                    self.accessControlList = model
                }
            }
        }
        public var bucket: GetBucketInfoResponse.BucketInfo.Bucket?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.bucket, "bucket")
            try self.bucket?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.bucket != nil {
                map["Bucket"] = self.bucket?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Bucket") && dict["Bucket"] != nil {
                var model = GetBucketInfoResponse.BucketInfo.Bucket()
                model.fromMap(dict["Bucket"] as! [String: Any])
                self.bucket = model
            }
        }
    }
    public var requestId: String?

    public var bucketInfo: GetBucketInfoResponse.BucketInfo?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.bucketInfo, "bucketInfo")
        try self.bucketInfo?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.bucketInfo != nil {
            map["BucketInfo"] = self.bucketInfo?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("BucketInfo") && dict["BucketInfo"] != nil {
            var model = GetBucketInfoResponse.BucketInfo()
            model.fromMap(dict["BucketInfo"] as! [String: Any])
            self.bucketInfo = model
        }
    }
}

public class PutLiveChannelStatusRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var status: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.status, "status")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.status != nil {
                map["status"] = self.status!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("status") && dict["status"] != nil {
                self.status = dict["status"] as! String
            }
        }
    }
    public var bucketName: String?

    public var channelName: String?

    public var filter: PutLiveChannelStatusRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = PutLiveChannelStatusRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class PutLiveChannelStatusResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class InitiateMultipartUploadRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var encodingType: String?

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
            if self.encodingType != nil {
                map["encoding-type"] = self.encodingType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("encoding-type") && dict["encoding-type"] != nil {
                self.encodingType = dict["encoding-type"] as! String
            }
        }
    }
    public class Header : Tea.TeaModel {
        public var cacheControl: String?

        public var contentDisposition: String?

        public var contentEncoding: String?

        public var expires: String?

        public var serverSideEncryption: String?

        public var serverSideEncryptionKeyId: String?

        public var storageClass: String?

        public var tagging: String?

        public var contentType: String?

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
            if self.cacheControl != nil {
                map["Cache-Control"] = self.cacheControl!
            }
            if self.contentDisposition != nil {
                map["Content-Disposition"] = self.contentDisposition!
            }
            if self.contentEncoding != nil {
                map["Content-Encoding"] = self.contentEncoding!
            }
            if self.expires != nil {
                map["Expires"] = self.expires!
            }
            if self.serverSideEncryption != nil {
                map["x-oss-server-side-encryption"] = self.serverSideEncryption!
            }
            if self.serverSideEncryptionKeyId != nil {
                map["x-oss-server-side-encryption-key-id"] = self.serverSideEncryptionKeyId!
            }
            if self.storageClass != nil {
                map["x-oss-storage-class"] = self.storageClass!
            }
            if self.tagging != nil {
                map["x-oss-tagging"] = self.tagging!
            }
            if self.contentType != nil {
                map["content-type"] = self.contentType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Cache-Control") && dict["Cache-Control"] != nil {
                self.cacheControl = dict["Cache-Control"] as! String
            }
            if dict.keys.contains("Content-Disposition") && dict["Content-Disposition"] != nil {
                self.contentDisposition = dict["Content-Disposition"] as! String
            }
            if dict.keys.contains("Content-Encoding") && dict["Content-Encoding"] != nil {
                self.contentEncoding = dict["Content-Encoding"] as! String
            }
            if dict.keys.contains("Expires") && dict["Expires"] != nil {
                self.expires = dict["Expires"] as! String
            }
            if dict.keys.contains("x-oss-server-side-encryption") && dict["x-oss-server-side-encryption"] != nil {
                self.serverSideEncryption = dict["x-oss-server-side-encryption"] as! String
            }
            if dict.keys.contains("x-oss-server-side-encryption-key-id") && dict["x-oss-server-side-encryption-key-id"] != nil {
                self.serverSideEncryptionKeyId = dict["x-oss-server-side-encryption-key-id"] as! String
            }
            if dict.keys.contains("x-oss-storage-class") && dict["x-oss-storage-class"] != nil {
                self.storageClass = dict["x-oss-storage-class"] as! String
            }
            if dict.keys.contains("x-oss-tagging") && dict["x-oss-tagging"] != nil {
                self.tagging = dict["x-oss-tagging"] as! String
            }
            if dict.keys.contains("content-type") && dict["content-type"] != nil {
                self.contentType = dict["content-type"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var filter: InitiateMultipartUploadRequest.Filter?

    public var header: InitiateMultipartUploadRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.filter?.validate()
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = InitiateMultipartUploadRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = InitiateMultipartUploadRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class InitiateMultipartUploadResponse : Tea.TeaModel {
    public class InitiateMultipartUploadResult : Tea.TeaModel {
        public var bucket: String?

        public var key: String?

        public var uploadId: String?

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
            if self.bucket != nil {
                map["Bucket"] = self.bucket!
            }
            if self.key != nil {
                map["Key"] = self.key!
            }
            if self.uploadId != nil {
                map["UploadId"] = self.uploadId!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Bucket") && dict["Bucket"] != nil {
                self.bucket = dict["Bucket"] as! String
            }
            if dict.keys.contains("Key") && dict["Key"] != nil {
                self.key = dict["Key"] as! String
            }
            if dict.keys.contains("UploadId") && dict["UploadId"] != nil {
                self.uploadId = dict["UploadId"] as! String
            }
        }
    }
    public var requestId: String?

    public var initiateMultipartUploadResult: InitiateMultipartUploadResponse.InitiateMultipartUploadResult?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.initiateMultipartUploadResult, "initiateMultipartUploadResult")
        try self.initiateMultipartUploadResult?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.initiateMultipartUploadResult != nil {
            map["InitiateMultipartUploadResult"] = self.initiateMultipartUploadResult?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("InitiateMultipartUploadResult") && dict["InitiateMultipartUploadResult"] != nil {
            var model = InitiateMultipartUploadResponse.InitiateMultipartUploadResult()
            model.fromMap(dict["InitiateMultipartUploadResult"] as! [String: Any])
            self.initiateMultipartUploadResult = model
        }
    }
}

public class OptionObjectRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var origin: String?

        public var accessControlRequestMethod: String?

        public var accessControlRequestHeaders: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.origin, "origin")
            try self.validateRequired(self.accessControlRequestMethod, "accessControlRequestMethod")
            try self.validateRequired(self.accessControlRequestHeaders, "accessControlRequestHeaders")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.origin != nil {
                map["Origin"] = self.origin!
            }
            if self.accessControlRequestMethod != nil {
                map["Access-Control-Request-Method"] = self.accessControlRequestMethod!
            }
            if self.accessControlRequestHeaders != nil {
                map["Access-Control-Request-Headers"] = self.accessControlRequestHeaders!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Origin") && dict["Origin"] != nil {
                self.origin = dict["Origin"] as! String
            }
            if dict.keys.contains("Access-Control-Request-Method") && dict["Access-Control-Request-Method"] != nil {
                self.accessControlRequestMethod = dict["Access-Control-Request-Method"] as! String
            }
            if dict.keys.contains("Access-Control-Request-Headers") && dict["Access-Control-Request-Headers"] != nil {
                self.accessControlRequestHeaders = dict["Access-Control-Request-Headers"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var header: OptionObjectRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = OptionObjectRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class OptionObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public var accessControlAllowOrigin: String?

    public var accessControlAllowMethods: String?

    public var accessControlAllowHeaders: String?

    public var accessControlExposeHeaders: String?

    public var accessControlMaxAge: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.accessControlAllowOrigin, "accessControlAllowOrigin")
        try self.validateRequired(self.accessControlAllowMethods, "accessControlAllowMethods")
        try self.validateRequired(self.accessControlAllowHeaders, "accessControlAllowHeaders")
        try self.validateRequired(self.accessControlExposeHeaders, "accessControlExposeHeaders")
        try self.validateRequired(self.accessControlMaxAge, "accessControlMaxAge")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.accessControlAllowOrigin != nil {
            map["access-control-allow-origin"] = self.accessControlAllowOrigin!
        }
        if self.accessControlAllowMethods != nil {
            map["access-control-allow-methods"] = self.accessControlAllowMethods!
        }
        if self.accessControlAllowHeaders != nil {
            map["access-control-allow-headers"] = self.accessControlAllowHeaders!
        }
        if self.accessControlExposeHeaders != nil {
            map["access-control-expose-headers"] = self.accessControlExposeHeaders!
        }
        if self.accessControlMaxAge != nil {
            map["access-control-max-age"] = self.accessControlMaxAge!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("access-control-allow-origin") && dict["access-control-allow-origin"] != nil {
            self.accessControlAllowOrigin = dict["access-control-allow-origin"] as! String
        }
        if dict.keys.contains("access-control-allow-methods") && dict["access-control-allow-methods"] != nil {
            self.accessControlAllowMethods = dict["access-control-allow-methods"] as! String
        }
        if dict.keys.contains("access-control-allow-headers") && dict["access-control-allow-headers"] != nil {
            self.accessControlAllowHeaders = dict["access-control-allow-headers"] as! String
        }
        if dict.keys.contains("access-control-expose-headers") && dict["access-control-expose-headers"] != nil {
            self.accessControlExposeHeaders = dict["access-control-expose-headers"] as! String
        }
        if dict.keys.contains("access-control-max-age") && dict["access-control-max-age"] != nil {
            self.accessControlMaxAge = dict["access-control-max-age"] as! String
        }
    }
}

public class PostVodPlaylistRequest : Tea.TeaModel {
    public class Filter : Tea.TeaModel {
        public var endTime: String?

        public var startTime: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.endTime, "endTime")
            try self.validateRequired(self.startTime, "startTime")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.endTime != nil {
                map["endTime"] = self.endTime!
            }
            if self.startTime != nil {
                map["startTime"] = self.startTime!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("endTime") && dict["endTime"] != nil {
                self.endTime = dict["endTime"] as! String
            }
            if dict.keys.contains("startTime") && dict["startTime"] != nil {
                self.startTime = dict["startTime"] as! String
            }
        }
    }
    public var bucketName: String?

    public var channelName: String?

    public var playlistName: String?

    public var filter: PostVodPlaylistRequest.Filter?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.channelName, "channelName")
        try self.validateRequired(self.playlistName, "playlistName")
        try self.validateRequired(self.filter, "filter")
        try self.filter?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.channelName != nil {
            map["ChannelName"] = self.channelName!
        }
        if self.playlistName != nil {
            map["PlaylistName"] = self.playlistName!
        }
        if self.filter != nil {
            map["Filter"] = self.filter?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ChannelName") && dict["ChannelName"] != nil {
            self.channelName = dict["ChannelName"] as! String
        }
        if dict.keys.contains("PlaylistName") && dict["PlaylistName"] != nil {
            self.playlistName = dict["PlaylistName"] as! String
        }
        if dict.keys.contains("Filter") && dict["Filter"] != nil {
            var model = PostVodPlaylistRequest.Filter()
            model.fromMap(dict["Filter"] as! [String: Any])
            self.filter = model
        }
    }
}

public class PostVodPlaylistResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PostObjectRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var accessKeyId: String?

        public var policy: String?

        public var signature: String?

        public var successActionStatus: String?

        public var file: TeaFileForm.FileField?

        public var key: String?

        public var userMeta: [String: String]?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.accessKeyId, "accessKeyId")
            try self.validateRequired(self.policy, "policy")
            try self.validateRequired(self.signature, "signature")
            try self.validateRequired(self.file, "file")
            try self.file?.validate()
            try self.validateRequired(self.key, "key")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.accessKeyId != nil {
                map["OSSAccessKeyId"] = self.accessKeyId!
            }
            if self.policy != nil {
                map["policy"] = self.policy!
            }
            if self.signature != nil {
                map["Signature"] = self.signature!
            }
            if self.successActionStatus != nil {
                map["success_action_status"] = self.successActionStatus!
            }
            if self.file != nil {
                map["file"] = self.file?.toMap()
            }
            if self.key != nil {
                map["key"] = self.key!
            }
            if self.userMeta != nil {
                map["UserMeta"] = self.userMeta!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("OSSAccessKeyId") && dict["OSSAccessKeyId"] != nil {
                self.accessKeyId = dict["OSSAccessKeyId"] as! String
            }
            if dict.keys.contains("policy") && dict["policy"] != nil {
                self.policy = dict["policy"] as! String
            }
            if dict.keys.contains("Signature") && dict["Signature"] != nil {
                self.signature = dict["Signature"] as! String
            }
            if dict.keys.contains("success_action_status") && dict["success_action_status"] != nil {
                self.successActionStatus = dict["success_action_status"] as! String
            }
            if dict.keys.contains("file") && dict["file"] != nil {
                var model = TeaFileForm.FileField()
                model.fromMap(dict["file"] as! [String: Any])
                self.file = model
            }
            if dict.keys.contains("key") && dict["key"] != nil {
                self.key = dict["key"] as! String
            }
            if dict.keys.contains("UserMeta") && dict["UserMeta"] != nil {
                self.userMeta = dict["UserMeta"] as! [String: String]
            }
        }
    }
    public var bucketName: String?

    public var header: PostObjectRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.header != nil {
            map["header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("header") && dict["header"] != nil {
            var model = PostObjectRequest.Header()
            model.fromMap(dict["header"] as! [String: Any])
            self.header = model
        }
    }
}

public class PostObjectResponse : Tea.TeaModel {
    public class PostResponse : Tea.TeaModel {
        public var bucket: String?

        public var eTag: String?

        public var location: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.bucket, "bucket")
            try self.validateRequired(self.eTag, "eTag")
            try self.validateRequired(self.location, "location")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.bucket != nil {
                map["Bucket"] = self.bucket!
            }
            if self.eTag != nil {
                map["ETag"] = self.eTag!
            }
            if self.location != nil {
                map["Location"] = self.location!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Bucket") && dict["Bucket"] != nil {
                self.bucket = dict["Bucket"] as! String
            }
            if dict.keys.contains("ETag") && dict["ETag"] != nil {
                self.eTag = dict["ETag"] as! String
            }
            if dict.keys.contains("Location") && dict["Location"] != nil {
                self.location = dict["Location"] as! String
            }
        }
    }
    public var postResponse: PostObjectResponse.PostResponse?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.postResponse, "postResponse")
        try self.postResponse?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.postResponse != nil {
            map["PostResponse"] = self.postResponse?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("PostResponse") && dict["PostResponse"] != nil {
            var model = PostObjectResponse.PostResponse()
            model.fromMap(dict["PostResponse"] as! [String: Any])
            self.postResponse = model
        }
    }
}

public class HeadObjectRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var ifModifiedSince: String?

        public var ifUnmodifiedSince: String?

        public var ifMatch: String?

        public var ifNoneMatch: String?

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
            if self.ifModifiedSince != nil {
                map["If-Modified-Since"] = self.ifModifiedSince!
            }
            if self.ifUnmodifiedSince != nil {
                map["If-Unmodified-Since"] = self.ifUnmodifiedSince!
            }
            if self.ifMatch != nil {
                map["If-Match"] = self.ifMatch!
            }
            if self.ifNoneMatch != nil {
                map["If-None-Match"] = self.ifNoneMatch!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("If-Modified-Since") && dict["If-Modified-Since"] != nil {
                self.ifModifiedSince = dict["If-Modified-Since"] as! String
            }
            if dict.keys.contains("If-Unmodified-Since") && dict["If-Unmodified-Since"] != nil {
                self.ifUnmodifiedSince = dict["If-Unmodified-Since"] as! String
            }
            if dict.keys.contains("If-Match") && dict["If-Match"] != nil {
                self.ifMatch = dict["If-Match"] as! String
            }
            if dict.keys.contains("If-None-Match") && dict["If-None-Match"] != nil {
                self.ifNoneMatch = dict["If-None-Match"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var header: HeadObjectRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = HeadObjectRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class HeadObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public var userMeta: [String: String]?

    public var serverSideEncryption: String?

    public var serverSideEncryptionKeyId: String?

    public var storageClass: String?

    public var objectType: String?

    public var nextAppendPosition: String?

    public var hashCrc64ecma: String?

    public var expiration: String?

    public var restore: String?

    public var processStatus: String?

    public var requestCharged: String?

    public var contentMd5: String?

    public var lastModified: String?

    public var accessControlAllowOrigin: String?

    public var accessControlAllowMethods: String?

    public var accessControlMaxAge: String?

    public var accessControlAllowHeaders: String?

    public var accessControlExposeHeaders: String?

    public var taggingCount: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.userMeta, "userMeta")
        try self.validateRequired(self.serverSideEncryption, "serverSideEncryption")
        try self.validateRequired(self.serverSideEncryptionKeyId, "serverSideEncryptionKeyId")
        try self.validateRequired(self.storageClass, "storageClass")
        try self.validateRequired(self.objectType, "objectType")
        try self.validateRequired(self.nextAppendPosition, "nextAppendPosition")
        try self.validateRequired(self.hashCrc64ecma, "hashCrc64ecma")
        try self.validateRequired(self.expiration, "expiration")
        try self.validateRequired(self.restore, "restore")
        try self.validateRequired(self.processStatus, "processStatus")
        try self.validateRequired(self.requestCharged, "requestCharged")
        try self.validateRequired(self.contentMd5, "contentMd5")
        try self.validateRequired(self.lastModified, "lastModified")
        try self.validateRequired(self.accessControlAllowOrigin, "accessControlAllowOrigin")
        try self.validateRequired(self.accessControlAllowMethods, "accessControlAllowMethods")
        try self.validateRequired(self.accessControlMaxAge, "accessControlMaxAge")
        try self.validateRequired(self.accessControlAllowHeaders, "accessControlAllowHeaders")
        try self.validateRequired(self.accessControlExposeHeaders, "accessControlExposeHeaders")
        try self.validateRequired(self.taggingCount, "taggingCount")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.userMeta != nil {
            map["usermeta"] = self.userMeta!
        }
        if self.serverSideEncryption != nil {
            map["x-oss-server-side-encryption"] = self.serverSideEncryption!
        }
        if self.serverSideEncryptionKeyId != nil {
            map["x-oss-server-side-encryption-key-id"] = self.serverSideEncryptionKeyId!
        }
        if self.storageClass != nil {
            map["x-oss-storage-class"] = self.storageClass!
        }
        if self.objectType != nil {
            map["x-oss-object-type"] = self.objectType!
        }
        if self.nextAppendPosition != nil {
            map["x-oss-next-append-position"] = self.nextAppendPosition!
        }
        if self.hashCrc64ecma != nil {
            map["x-oss-hash-crc64ecma"] = self.hashCrc64ecma!
        }
        if self.expiration != nil {
            map["x-oss-expiration"] = self.expiration!
        }
        if self.restore != nil {
            map["x-oss-restore"] = self.restore!
        }
        if self.processStatus != nil {
            map["x-oss-process-status"] = self.processStatus!
        }
        if self.requestCharged != nil {
            map["x-oss-request-charged"] = self.requestCharged!
        }
        if self.contentMd5 != nil {
            map["content-md5"] = self.contentMd5!
        }
        if self.lastModified != nil {
            map["last-modified"] = self.lastModified!
        }
        if self.accessControlAllowOrigin != nil {
            map["access-control-allow-origin"] = self.accessControlAllowOrigin!
        }
        if self.accessControlAllowMethods != nil {
            map["access-control-allow-methods"] = self.accessControlAllowMethods!
        }
        if self.accessControlMaxAge != nil {
            map["access-control-max-age"] = self.accessControlMaxAge!
        }
        if self.accessControlAllowHeaders != nil {
            map["access-control-allow-headers"] = self.accessControlAllowHeaders!
        }
        if self.accessControlExposeHeaders != nil {
            map["access-control-expose-headers"] = self.accessControlExposeHeaders!
        }
        if self.taggingCount != nil {
            map["x-oss-tagging-count"] = self.taggingCount!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("usermeta") && dict["usermeta"] != nil {
            self.userMeta = dict["usermeta"] as! [String: String]
        }
        if dict.keys.contains("x-oss-server-side-encryption") && dict["x-oss-server-side-encryption"] != nil {
            self.serverSideEncryption = dict["x-oss-server-side-encryption"] as! String
        }
        if dict.keys.contains("x-oss-server-side-encryption-key-id") && dict["x-oss-server-side-encryption-key-id"] != nil {
            self.serverSideEncryptionKeyId = dict["x-oss-server-side-encryption-key-id"] as! String
        }
        if dict.keys.contains("x-oss-storage-class") && dict["x-oss-storage-class"] != nil {
            self.storageClass = dict["x-oss-storage-class"] as! String
        }
        if dict.keys.contains("x-oss-object-type") && dict["x-oss-object-type"] != nil {
            self.objectType = dict["x-oss-object-type"] as! String
        }
        if dict.keys.contains("x-oss-next-append-position") && dict["x-oss-next-append-position"] != nil {
            self.nextAppendPosition = dict["x-oss-next-append-position"] as! String
        }
        if dict.keys.contains("x-oss-hash-crc64ecma") && dict["x-oss-hash-crc64ecma"] != nil {
            self.hashCrc64ecma = dict["x-oss-hash-crc64ecma"] as! String
        }
        if dict.keys.contains("x-oss-expiration") && dict["x-oss-expiration"] != nil {
            self.expiration = dict["x-oss-expiration"] as! String
        }
        if dict.keys.contains("x-oss-restore") && dict["x-oss-restore"] != nil {
            self.restore = dict["x-oss-restore"] as! String
        }
        if dict.keys.contains("x-oss-process-status") && dict["x-oss-process-status"] != nil {
            self.processStatus = dict["x-oss-process-status"] as! String
        }
        if dict.keys.contains("x-oss-request-charged") && dict["x-oss-request-charged"] != nil {
            self.requestCharged = dict["x-oss-request-charged"] as! String
        }
        if dict.keys.contains("content-md5") && dict["content-md5"] != nil {
            self.contentMd5 = dict["content-md5"] as! String
        }
        if dict.keys.contains("last-modified") && dict["last-modified"] != nil {
            self.lastModified = dict["last-modified"] as! String
        }
        if dict.keys.contains("access-control-allow-origin") && dict["access-control-allow-origin"] != nil {
            self.accessControlAllowOrigin = dict["access-control-allow-origin"] as! String
        }
        if dict.keys.contains("access-control-allow-methods") && dict["access-control-allow-methods"] != nil {
            self.accessControlAllowMethods = dict["access-control-allow-methods"] as! String
        }
        if dict.keys.contains("access-control-max-age") && dict["access-control-max-age"] != nil {
            self.accessControlMaxAge = dict["access-control-max-age"] as! String
        }
        if dict.keys.contains("access-control-allow-headers") && dict["access-control-allow-headers"] != nil {
            self.accessControlAllowHeaders = dict["access-control-allow-headers"] as! String
        }
        if dict.keys.contains("access-control-expose-headers") && dict["access-control-expose-headers"] != nil {
            self.accessControlExposeHeaders = dict["access-control-expose-headers"] as! String
        }
        if dict.keys.contains("x-oss-tagging-count") && dict["x-oss-tagging-count"] != nil {
            self.taggingCount = dict["x-oss-tagging-count"] as! String
        }
    }
}

public class DeleteObjectTaggingRequest : Tea.TeaModel {
    public var bucketName: String?

    public var objectName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
    }
}

public class DeleteObjectTaggingResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class RestoreObjectRequest : Tea.TeaModel {
    public var bucketName: String?

    public var objectName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
    }
}

public class RestoreObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class GetObjectAclRequest : Tea.TeaModel {
    public var bucketName: String?

    public var objectName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
    }
}

public class GetObjectAclResponse : Tea.TeaModel {
    public class AccessControlPolicy : Tea.TeaModel {
        public class Owner : Tea.TeaModel {
            public var iD: String?

            public var displayName: String?

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
                if self.iD != nil {
                    map["ID"] = self.iD!
                }
                if self.displayName != nil {
                    map["DisplayName"] = self.displayName!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("ID") && dict["ID"] != nil {
                    self.iD = dict["ID"] as! String
                }
                if dict.keys.contains("DisplayName") && dict["DisplayName"] != nil {
                    self.displayName = dict["DisplayName"] as! String
                }
            }
        }
        public class AccessControlList : Tea.TeaModel {
            public var grant: String?

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
                if self.grant != nil {
                    map["Grant"] = self.grant!
                }
                return map
            }

            public override func fromMap(_ dict: [String: Any]) -> Void {
                if dict.keys.contains("Grant") && dict["Grant"] != nil {
                    self.grant = dict["Grant"] as! String
                }
            }
        }
        public var owner: GetObjectAclResponse.AccessControlPolicy.Owner?

        public var accessControlList: GetObjectAclResponse.AccessControlPolicy.AccessControlList?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.owner, "owner")
            try self.owner?.validate()
            try self.validateRequired(self.accessControlList, "accessControlList")
            try self.accessControlList?.validate()
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.owner != nil {
                map["Owner"] = self.owner?.toMap()
            }
            if self.accessControlList != nil {
                map["AccessControlList"] = self.accessControlList?.toMap()
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Owner") && dict["Owner"] != nil {
                var model = GetObjectAclResponse.AccessControlPolicy.Owner()
                model.fromMap(dict["Owner"] as! [String: Any])
                self.owner = model
            }
            if dict.keys.contains("AccessControlList") && dict["AccessControlList"] != nil {
                var model = GetObjectAclResponse.AccessControlPolicy.AccessControlList()
                model.fromMap(dict["AccessControlList"] as! [String: Any])
                self.accessControlList = model
            }
        }
    }
    public var requestId: String?

    public var accessControlPolicy: GetObjectAclResponse.AccessControlPolicy?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.accessControlPolicy, "accessControlPolicy")
        try self.accessControlPolicy?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.accessControlPolicy != nil {
            map["AccessControlPolicy"] = self.accessControlPolicy?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("AccessControlPolicy") && dict["AccessControlPolicy"] != nil {
            var model = GetObjectAclResponse.AccessControlPolicy()
            model.fromMap(dict["AccessControlPolicy"] as! [String: Any])
            self.accessControlPolicy = model
        }
    }
}

public class PutBucketAclRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var acl: String?

        public override init() {
            super.init()
        }

        public init(_ dict: [String: Any]) {
            super.init()
            self.fromMap(dict)
        }

        public override func validate() throws -> Void {
            try self.validateRequired(self.acl, "acl")
        }

        public override func toMap() -> [String : Any] {
            var map = super.toMap()
            if self.acl != nil {
                map["x-oss-acl"] = self.acl!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("x-oss-acl") && dict["x-oss-acl"] != nil {
                self.acl = dict["x-oss-acl"] as! String
            }
        }
    }
    public var bucketName: String?

    public var header: PutBucketAclRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.header, "header")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = PutBucketAclRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class PutBucketAclResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class DeleteBucketRequest : Tea.TeaModel {
    public var bucketName: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
    }
}

public class DeleteBucketResponse : Tea.TeaModel {
    public var requestId: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
    }
}

public class PutObjectRequest : Tea.TeaModel {
    public class Header : Tea.TeaModel {
        public var authorization: String?

        public var cacheControl: String?

        public var contentDisposition: String?

        public var contentEncoding: String?

        public var contentMD5: String?

        public var contentLength: String?

        public var eTag: String?

        public var expires: String?

        public var serverSideEncryption: String?

        public var serverSideEncryptionKeyId: String?

        public var objectAcl: String?

        public var storageClass: String?

        public var tagging: String?

        public var contentType: String?

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
            if self.authorization != nil {
                map["Authorization"] = self.authorization!
            }
            if self.cacheControl != nil {
                map["Cache-Control"] = self.cacheControl!
            }
            if self.contentDisposition != nil {
                map["Content-Disposition"] = self.contentDisposition!
            }
            if self.contentEncoding != nil {
                map["Content-Encoding"] = self.contentEncoding!
            }
            if self.contentMD5 != nil {
                map["Content-MD5"] = self.contentMD5!
            }
            if self.contentLength != nil {
                map["Content-Length"] = self.contentLength!
            }
            if self.eTag != nil {
                map["CETag"] = self.eTag!
            }
            if self.expires != nil {
                map["Expires"] = self.expires!
            }
            if self.serverSideEncryption != nil {
                map["x-oss-server-side-encryption"] = self.serverSideEncryption!
            }
            if self.serverSideEncryptionKeyId != nil {
                map["x-oss-server-side-encryption-key-id"] = self.serverSideEncryptionKeyId!
            }
            if self.objectAcl != nil {
                map["x-oss-object-acl"] = self.objectAcl!
            }
            if self.storageClass != nil {
                map["x-oss-storage-class"] = self.storageClass!
            }
            if self.tagging != nil {
                map["x-oss-tagging"] = self.tagging!
            }
            if self.contentType != nil {
                map["content-type"] = self.contentType!
            }
            return map
        }

        public override func fromMap(_ dict: [String: Any]) -> Void {
            if dict.keys.contains("Authorization") && dict["Authorization"] != nil {
                self.authorization = dict["Authorization"] as! String
            }
            if dict.keys.contains("Cache-Control") && dict["Cache-Control"] != nil {
                self.cacheControl = dict["Cache-Control"] as! String
            }
            if dict.keys.contains("Content-Disposition") && dict["Content-Disposition"] != nil {
                self.contentDisposition = dict["Content-Disposition"] as! String
            }
            if dict.keys.contains("Content-Encoding") && dict["Content-Encoding"] != nil {
                self.contentEncoding = dict["Content-Encoding"] as! String
            }
            if dict.keys.contains("Content-MD5") && dict["Content-MD5"] != nil {
                self.contentMD5 = dict["Content-MD5"] as! String
            }
            if dict.keys.contains("Content-Length") && dict["Content-Length"] != nil {
                self.contentLength = dict["Content-Length"] as! String
            }
            if dict.keys.contains("CETag") && dict["CETag"] != nil {
                self.eTag = dict["CETag"] as! String
            }
            if dict.keys.contains("Expires") && dict["Expires"] != nil {
                self.expires = dict["Expires"] as! String
            }
            if dict.keys.contains("x-oss-server-side-encryption") && dict["x-oss-server-side-encryption"] != nil {
                self.serverSideEncryption = dict["x-oss-server-side-encryption"] as! String
            }
            if dict.keys.contains("x-oss-server-side-encryption-key-id") && dict["x-oss-server-side-encryption-key-id"] != nil {
                self.serverSideEncryptionKeyId = dict["x-oss-server-side-encryption-key-id"] as! String
            }
            if dict.keys.contains("x-oss-object-acl") && dict["x-oss-object-acl"] != nil {
                self.objectAcl = dict["x-oss-object-acl"] as! String
            }
            if dict.keys.contains("x-oss-storage-class") && dict["x-oss-storage-class"] != nil {
                self.storageClass = dict["x-oss-storage-class"] as! String
            }
            if dict.keys.contains("x-oss-tagging") && dict["x-oss-tagging"] != nil {
                self.tagging = dict["x-oss-tagging"] as! String
            }
            if dict.keys.contains("content-type") && dict["content-type"] != nil {
                self.contentType = dict["content-type"] as! String
            }
        }
    }
    public var bucketName: String?

    public var objectName: String?

    public var userMeta: [String: String]?

    public var body: InputStream?

    public var header: PutObjectRequest.Header?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.bucketName, "bucketName")
        if self.bucketName != nil {
            try self.validatePattern(self.bucketName, "bucketName", "[a-zA-Z0-9-_]+")
        }
        try self.validateRequired(self.objectName, "objectName")
        try self.header?.validate()
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.bucketName != nil {
            map["BucketName"] = self.bucketName!
        }
        if self.objectName != nil {
            map["ObjectName"] = self.objectName!
        }
        if self.userMeta != nil {
            map["UserMeta"] = self.userMeta!
        }
        if self.body != nil {
            map["body"] = self.body!
        }
        if self.header != nil {
            map["Header"] = self.header?.toMap()
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("BucketName") && dict["BucketName"] != nil {
            self.bucketName = dict["BucketName"] as! String
        }
        if dict.keys.contains("ObjectName") && dict["ObjectName"] != nil {
            self.objectName = dict["ObjectName"] as! String
        }
        if dict.keys.contains("UserMeta") && dict["UserMeta"] != nil {
            self.userMeta = dict["UserMeta"] as! [String: String]
        }
        if dict.keys.contains("body") && dict["body"] != nil {
            self.body = dict["body"] as! InputStream
        }
        if dict.keys.contains("Header") && dict["Header"] != nil {
            var model = PutObjectRequest.Header()
            model.fromMap(dict["Header"] as! [String: Any])
            self.header = model
        }
    }
}

public class PutObjectResponse : Tea.TeaModel {
    public var requestId: String?

    public var hashCrc64ecma: String?

    public var serverTime: String?

    public var bucketVersion: String?

    public override init() {
        super.init()
    }

    public init(_ dict: [String: Any]) {
        super.init()
        self.fromMap(dict)
    }

    public override func validate() throws -> Void {
        try self.validateRequired(self.requestId, "requestId")
        try self.validateRequired(self.hashCrc64ecma, "hashCrc64ecma")
        try self.validateRequired(self.serverTime, "serverTime")
        try self.validateRequired(self.bucketVersion, "bucketVersion")
    }

    public override func toMap() -> [String : Any] {
        var map = super.toMap()
        if self.requestId != nil {
            map["x-oss-request-id"] = self.requestId!
        }
        if self.hashCrc64ecma != nil {
            map["x-oss-hash-crc64ecma"] = self.hashCrc64ecma!
        }
        if self.serverTime != nil {
            map["x-oss-server-time"] = self.serverTime!
        }
        if self.bucketVersion != nil {
            map["x-oss-bucket-version"] = self.bucketVersion!
        }
        return map
    }

    public override func fromMap(_ dict: [String: Any]) -> Void {
        if dict.keys.contains("x-oss-request-id") && dict["x-oss-request-id"] != nil {
            self.requestId = dict["x-oss-request-id"] as! String
        }
        if dict.keys.contains("x-oss-hash-crc64ecma") && dict["x-oss-hash-crc64ecma"] != nil {
            self.hashCrc64ecma = dict["x-oss-hash-crc64ecma"] as! String
        }
        if dict.keys.contains("x-oss-server-time") && dict["x-oss-server-time"] != nil {
            self.serverTime = dict["x-oss-server-time"] as! String
        }
        if dict.keys.contains("x-oss-bucket-version") && dict["x-oss-bucket-version"] != nil {
            self.bucketVersion = dict["x-oss-bucket-version"] as! String
        }
    }
}
