// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class Config : TeaModel {
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("securityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("accessKeyId")]
        [Validation(Required=true)]
        public string AccessKeyId { get; set; }

        [NameInMap("accessKeySecret")]
        [Validation(Required=true)]
        public string AccessKeySecret { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false, Pattern="[a-zA-Z0-9-_]+")]
        public string RegionId { get; set; }

        [NameInMap("userAgent")]
        [Validation(Required=false)]
        public string UserAgent { get; set; }

        [NameInMap("hostModel")]
        [Validation(Required=false)]
        public string HostModel { get; set; }

        [NameInMap("signatureVersion")]
        [Validation(Required=false)]
        public string SignatureVersion { get; set; }

        [NameInMap("isEnableMD5")]
        [Validation(Required=false)]
        public bool? IsEnableMD5 { get; set; }

        [NameInMap("isEnableCrc")]
        [Validation(Required=false)]
        public bool? IsEnableCrc { get; set; }

        [NameInMap("readTimeout")]
        [Validation(Required=false)]
        public int? ReadTimeout { get; set; }

        [NameInMap("connectTimeout")]
        [Validation(Required=false)]
        public int? ConnectTimeout { get; set; }

        [NameInMap("localAddr")]
        [Validation(Required=false)]
        public string LocalAddr { get; set; }

        [NameInMap("httpProxy")]
        [Validation(Required=false)]
        public string HttpProxy { get; set; }

        [NameInMap("httpsProxy")]
        [Validation(Required=false)]
        public string HttpsProxy { get; set; }

        [NameInMap("noProxy")]
        [Validation(Required=false)]
        public string NoProxy { get; set; }

        [NameInMap("socks5Proxy")]
        [Validation(Required=false)]
        public string Socks5Proxy { get; set; }

        [NameInMap("socks5NetWork")]
        [Validation(Required=false)]
        public string Socks5NetWork { get; set; }

        [NameInMap("maxIdleConns")]
        [Validation(Required=false)]
        public int? MaxIdleConns { get; set; }

        [NameInMap("addtionalHeaders")]
        [Validation(Required=false)]
        public List<string> AddtionalHeaders { get; set; }

    }

}
