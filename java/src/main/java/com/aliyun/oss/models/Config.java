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
    @Validation(pattern = "[a-zA-Z0-9-_]+")
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

    public Config setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public Config setSecurityToken(String securityToken) {
        this.securityToken = securityToken;
        return this;
    }
    public String getSecurityToken() {
        return this.securityToken;
    }

    public Config setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public Config setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public Config setEndpoint(String endpoint) {
        this.endpoint = endpoint;
        return this;
    }
    public String getEndpoint() {
        return this.endpoint;
    }

    public Config setProtocol(String protocol) {
        this.protocol = protocol;
        return this;
    }
    public String getProtocol() {
        return this.protocol;
    }

    public Config setRegionId(String regionId) {
        this.regionId = regionId;
        return this;
    }
    public String getRegionId() {
        return this.regionId;
    }

    public Config setUserAgent(String userAgent) {
        this.userAgent = userAgent;
        return this;
    }
    public String getUserAgent() {
        return this.userAgent;
    }

    public Config setHostModel(String hostModel) {
        this.hostModel = hostModel;
        return this;
    }
    public String getHostModel() {
        return this.hostModel;
    }

    public Config setSignatureVersion(String signatureVersion) {
        this.signatureVersion = signatureVersion;
        return this;
    }
    public String getSignatureVersion() {
        return this.signatureVersion;
    }

    public Config setIsEnableMD5(Boolean isEnableMD5) {
        this.isEnableMD5 = isEnableMD5;
        return this;
    }
    public Boolean getIsEnableMD5() {
        return this.isEnableMD5;
    }

    public Config setIsEnableCrc(Boolean isEnableCrc) {
        this.isEnableCrc = isEnableCrc;
        return this;
    }
    public Boolean getIsEnableCrc() {
        return this.isEnableCrc;
    }

    public Config setReadTimeout(Integer readTimeout) {
        this.readTimeout = readTimeout;
        return this;
    }
    public Integer getReadTimeout() {
        return this.readTimeout;
    }

    public Config setConnectTimeout(Integer connectTimeout) {
        this.connectTimeout = connectTimeout;
        return this;
    }
    public Integer getConnectTimeout() {
        return this.connectTimeout;
    }

    public Config setLocalAddr(String localAddr) {
        this.localAddr = localAddr;
        return this;
    }
    public String getLocalAddr() {
        return this.localAddr;
    }

    public Config setHttpProxy(String httpProxy) {
        this.httpProxy = httpProxy;
        return this;
    }
    public String getHttpProxy() {
        return this.httpProxy;
    }

    public Config setHttpsProxy(String httpsProxy) {
        this.httpsProxy = httpsProxy;
        return this;
    }
    public String getHttpsProxy() {
        return this.httpsProxy;
    }

    public Config setNoProxy(String noProxy) {
        this.noProxy = noProxy;
        return this;
    }
    public String getNoProxy() {
        return this.noProxy;
    }

    public Config setSocks5Proxy(String socks5Proxy) {
        this.socks5Proxy = socks5Proxy;
        return this;
    }
    public String getSocks5Proxy() {
        return this.socks5Proxy;
    }

    public Config setSocks5NetWork(String socks5NetWork) {
        this.socks5NetWork = socks5NetWork;
        return this;
    }
    public String getSocks5NetWork() {
        return this.socks5NetWork;
    }

    public Config setMaxIdleConns(Integer maxIdleConns) {
        this.maxIdleConns = maxIdleConns;
        return this;
    }
    public Integer getMaxIdleConns() {
        return this.maxIdleConns;
    }

    public Config setAddtionalHeaders(java.util.List<String> addtionalHeaders) {
        this.addtionalHeaders = addtionalHeaders;
        return this;
    }
    public java.util.List<String> getAddtionalHeaders() {
        return this.addtionalHeaders;
    }

}
