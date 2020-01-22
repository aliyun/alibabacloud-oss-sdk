// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class RuntimeObject extends TeaModel {
    @NameInMap("autoretry")
    public boolean autoretry;

    @NameInMap("ignoreSSL")
    public boolean ignoreSSL;

    @NameInMap("maxAttempts")
    public Integer maxAttempts;

    @NameInMap("backoffPolicy")
    public String backoffPolicy;

    @NameInMap("backoffPeriod")
    public Integer backoffPeriod;

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

    @NameInMap("maxIdleConns")
    public Integer maxIdleConns;

    @NameInMap("socks5Proxy")
    public String socks5Proxy;

    @NameInMap("socks5NetWork")
    public String socks5NetWork;

    @NameInMap("MD5Threshold")
    public Long md5Threshold;

    @NameInMap("uploadLimitSpeed")
    public Integer uploadLimitSpeed;

    @NameInMap("listener")
    public Object listener;

    public static RuntimeObject build(java.util.Map<String, ?> map) throws Exception {
        RuntimeObject self = new RuntimeObject();
        return TeaModel.build(map, self);
    }

}
