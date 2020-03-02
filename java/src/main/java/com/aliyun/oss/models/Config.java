// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class Config extends TeaModel {
    @NameInMap("type")
    public String type;

    @NameInMap("securityToken")
    public String securityToken;

    @NameInMap("accessKeyId")
    @Validation(required = true)
    public String accessKeyId;

    @NameInMap("accessKeySecret")
    @Validation(required = true)
    public String accessKeySecret;

    @NameInMap("endpoint")
    public String endpoint;

    @NameInMap("protocol")
    public String protocol;

    @NameInMap("regionId")
    public String regionId;

    @NameInMap("userAgent")
    public String userAgent;

    @NameInMap("hostModel")
    public String hostModel;

    @NameInMap("signatureVersion")
    public String signatureVersion;

    @NameInMap("isEnableMD5")
    public Boolean isEnableMD5;

    @NameInMap("isEnableCrc")
    public Boolean isEnableCrc;

    @NameInMap("readTimeout")
    public Integer readTimeout;

    @NameInMap("connectTimeout")
    public Integer connectTimeout;

    @NameInMap("localAddr")
    public String localAddr;

    @NameInMap("httpProxy")
    public String httpProxy;

    @NameInMap("httpsProxy")
    public String httpsProxy;

    @NameInMap("noProxy")
    public String noProxy;

    @NameInMap("socks5Proxy")
    public String socks5Proxy;

    @NameInMap("socks5NetWork")
    public String socks5NetWork;

    @NameInMap("maxIdleConns")
    public Integer maxIdleConns;

    @NameInMap("addtionalHeaders")
    public java.util.List<String> addtionalHeaders;

    public static Config build(java.util.Map<String, ?> map) throws Exception {
        Config self = new Config();
        return TeaModel.build(map, self);
    }

}
