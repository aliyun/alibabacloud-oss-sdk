// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ossutil.models;

import com.aliyun.tea.*;

public class RuntimeOptions extends TeaModel {
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

    @NameInMap("uploadLimitSpeed")
    public Integer uploadLimitSpeed;

    @NameInMap("listener")
    public Object listener;

    public static RuntimeOptions build(java.util.Map<String, ?> map) {
        RuntimeOptions self = new RuntimeOptions();
        return TeaModel.build(map, self);
    }

}
