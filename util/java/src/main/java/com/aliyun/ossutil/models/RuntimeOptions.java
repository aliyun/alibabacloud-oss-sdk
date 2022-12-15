// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ossutil.models;

import com.aliyun.tea.*;

/**
 * The OSS runtime options model
 */
public class RuntimeOptions extends TeaModel {
    /**
     * <p>autoretry</p>
     */
    @NameInMap("autoretry")
    public boolean autoretry;

    /**
     * <p>ignoreSSL</p>
     */
    @NameInMap("ignoreSSL")
    public boolean ignoreSSL;

    /**
     * <p>max attempts</p>
     */
    @NameInMap("maxAttempts")
    public Integer maxAttempts;

    /**
     * <p>backoff policy</p>
     */
    @NameInMap("backoffPolicy")
    public String backoffPolicy;

    /**
     * <p>backoff period</p>
     */
    @NameInMap("backoffPeriod")
    public Integer backoffPeriod;

    /**
     * <p>read timeout</p>
     */
    @NameInMap("readTimeout")
    public Integer readTimeout;

    /**
     * <p>connect timeout</p>
     */
    @NameInMap("connectTimeout")
    public Integer connectTimeout;

    /**
     * <p>local addr</p>
     */
    @NameInMap("localAddr")
    public String localAddr;

    /**
     * <p>http proxy</p>
     */
    @NameInMap("httpProxy")
    public String httpProxy;

    /**
     * <p>https proxy</p>
     */
    @NameInMap("httpsProxy")
    public String httpsProxy;

    /**
     * <p>no proxy</p>
     */
    @NameInMap("noProxy")
    public String noProxy;

    /**
     * <p>max idle conns</p>
     */
    @NameInMap("maxIdleConns")
    public Integer maxIdleConns;

    /**
     * <p>socks5 proxy</p>
     */
    @NameInMap("socks5Proxy")
    public String socks5Proxy;

    /**
     * <p>socks5 NetWork</p>
     */
    @NameInMap("socks5NetWork")
    public String socks5NetWork;

    /**
     * <p>upload limit speed</p>
     */
    @NameInMap("uploadLimitSpeed")
    public Integer uploadLimitSpeed;

    /**
     * <p>listener</p>
     */
    @NameInMap("listener")
    public Object listener;

    public static RuntimeOptions build(java.util.Map<String, ?> map) {
        RuntimeOptions self = new RuntimeOptions();
        return TeaModel.build(map, self);
    }

    public RuntimeOptions setAutoretry(boolean autoretry) {
        this.autoretry = autoretry;
        return this;
    }
    public boolean getAutoretry() {
        return this.autoretry;
    }

    public RuntimeOptions setIgnoreSSL(boolean ignoreSSL) {
        this.ignoreSSL = ignoreSSL;
        return this;
    }
    public boolean getIgnoreSSL() {
        return this.ignoreSSL;
    }

    public RuntimeOptions setMaxAttempts(Integer maxAttempts) {
        this.maxAttempts = maxAttempts;
        return this;
    }
    public Integer getMaxAttempts() {
        return this.maxAttempts;
    }

    public RuntimeOptions setBackoffPolicy(String backoffPolicy) {
        this.backoffPolicy = backoffPolicy;
        return this;
    }
    public String getBackoffPolicy() {
        return this.backoffPolicy;
    }

    public RuntimeOptions setBackoffPeriod(Integer backoffPeriod) {
        this.backoffPeriod = backoffPeriod;
        return this;
    }
    public Integer getBackoffPeriod() {
        return this.backoffPeriod;
    }

    public RuntimeOptions setReadTimeout(Integer readTimeout) {
        this.readTimeout = readTimeout;
        return this;
    }
    public Integer getReadTimeout() {
        return this.readTimeout;
    }

    public RuntimeOptions setConnectTimeout(Integer connectTimeout) {
        this.connectTimeout = connectTimeout;
        return this;
    }
    public Integer getConnectTimeout() {
        return this.connectTimeout;
    }

    public RuntimeOptions setLocalAddr(String localAddr) {
        this.localAddr = localAddr;
        return this;
    }
    public String getLocalAddr() {
        return this.localAddr;
    }

    public RuntimeOptions setHttpProxy(String httpProxy) {
        this.httpProxy = httpProxy;
        return this;
    }
    public String getHttpProxy() {
        return this.httpProxy;
    }

    public RuntimeOptions setHttpsProxy(String httpsProxy) {
        this.httpsProxy = httpsProxy;
        return this;
    }
    public String getHttpsProxy() {
        return this.httpsProxy;
    }

    public RuntimeOptions setNoProxy(String noProxy) {
        this.noProxy = noProxy;
        return this;
    }
    public String getNoProxy() {
        return this.noProxy;
    }

    public RuntimeOptions setMaxIdleConns(Integer maxIdleConns) {
        this.maxIdleConns = maxIdleConns;
        return this;
    }
    public Integer getMaxIdleConns() {
        return this.maxIdleConns;
    }

    public RuntimeOptions setSocks5Proxy(String socks5Proxy) {
        this.socks5Proxy = socks5Proxy;
        return this;
    }
    public String getSocks5Proxy() {
        return this.socks5Proxy;
    }

    public RuntimeOptions setSocks5NetWork(String socks5NetWork) {
        this.socks5NetWork = socks5NetWork;
        return this;
    }
    public String getSocks5NetWork() {
        return this.socks5NetWork;
    }

    public RuntimeOptions setUploadLimitSpeed(Integer uploadLimitSpeed) {
        this.uploadLimitSpeed = uploadLimitSpeed;
        return this;
    }
    public Integer getUploadLimitSpeed() {
        return this.uploadLimitSpeed;
    }

    public RuntimeOptions setListener(Object listener) {
        this.listener = listener;
        return this;
    }
    public Object getListener() {
        return this.listener;
    }

}
