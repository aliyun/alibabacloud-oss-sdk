// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketWebsiteRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketWebsiteRequestBody body;

    public static PutBucketWebsiteRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketWebsiteRequest self = new PutBucketWebsiteRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketWebsiteRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketWebsiteRequest setBody(PutBucketWebsiteRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketWebsiteRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument extends TeaModel {
        // Suffix
        @NameInMap("Suffix")
        public String suffix;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument self = new PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument setSuffix(String suffix) {
            this.suffix = suffix;
            return this;
        }
        public String getSuffix() {
            return this.suffix;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument self = new PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Equals
        @NameInMap("Equals")
        public String equals;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader self = new PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader setEquals(String equals) {
            this.equals = equals;
            return this;
        }
        public String getEquals() {
            return this.equals;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition extends TeaModel {
        // IncludeHeader
        @NameInMap("IncludeHeader")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader includeHeader;

        // KeyPrefixEquals
        @NameInMap("KeyPrefixEquals")
        public String keyPrefixEquals;

        // HttpErrorCodeReturnedEquals
        @NameInMap("HttpErrorCodeReturnedEquals")
        public String httpErrorCodeReturnedEquals;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition self = new PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition setIncludeHeader(PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader includeHeader) {
            this.includeHeader = includeHeader;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader getIncludeHeader() {
            return this.includeHeader;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition setKeyPrefixEquals(String keyPrefixEquals) {
            this.keyPrefixEquals = keyPrefixEquals;
            return this;
        }
        public String getKeyPrefixEquals() {
            return this.keyPrefixEquals;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition setHttpErrorCodeReturnedEquals(String httpErrorCodeReturnedEquals) {
            this.httpErrorCodeReturnedEquals = httpErrorCodeReturnedEquals;
            return this;
        }
        public String getHttpErrorCodeReturnedEquals() {
            return this.httpErrorCodeReturnedEquals;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet self = new PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders extends TeaModel {
        // Set
        @NameInMap("Set")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet set;

        // PassAll
        @NameInMap("PassAll")
        public Boolean passAll;

        // Pass
        @NameInMap("Pass")
        public String pass;

        // Remove
        @NameInMap("Remove")
        public String remove;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders self = new PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setSet(PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet set) {
            this.set = set;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet getSet() {
            return this.set;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setPassAll(Boolean passAll) {
            this.passAll = passAll;
            return this;
        }
        public Boolean getPassAll() {
            return this.passAll;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setPass(String pass) {
            this.pass = pass;
            return this;
        }
        public String getPass() {
            return this.pass;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setRemove(String remove) {
            this.remove = remove;
            return this;
        }
        public String getRemove() {
            return this.remove;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect extends TeaModel {
        // MirrorHeaders
        @NameInMap("MirrorHeaders")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders mirrorHeaders;

        // RedirectType
        @NameInMap("RedirectType")
        public String redirectType;

        // PassQueryString
        @NameInMap("PassQueryString")
        public Boolean passQueryString;

        // MirrorURL
        @NameInMap("MirrorURL")
        public String mirrorURL;

        // MirrorPassQueryString
        @NameInMap("MirrorPassQueryString")
        public Boolean mirrorPassQueryString;

        // MirrorFollowRedirect
        @NameInMap("MirrorFollowRedirect")
        public Boolean mirrorFollowRedirect;

        // MirrorCheckMd5
        @NameInMap("MirrorCheckMd5")
        public Boolean mirrorCheckMd5;

        // Protocol
        @NameInMap("Protocol")
        public String protocol;

        // HostName
        @NameInMap("HostName")
        public String hostName;

        // HttpRedirectCode
        @NameInMap("HttpRedirectCode")
        public String httpRedirectCode;

        // ReplaceKeyPrefixWith
        @NameInMap("ReplaceKeyPrefixWith")
        public String replaceKeyPrefixWith;

        // ReplaceKeyWith
        @NameInMap("ReplaceKeyWith")
        public String replaceKeyWith;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect self = new PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorHeaders(PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders mirrorHeaders) {
            this.mirrorHeaders = mirrorHeaders;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders getMirrorHeaders() {
            return this.mirrorHeaders;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setRedirectType(String redirectType) {
            this.redirectType = redirectType;
            return this;
        }
        public String getRedirectType() {
            return this.redirectType;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setPassQueryString(Boolean passQueryString) {
            this.passQueryString = passQueryString;
            return this;
        }
        public Boolean getPassQueryString() {
            return this.passQueryString;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorURL(String mirrorURL) {
            this.mirrorURL = mirrorURL;
            return this;
        }
        public String getMirrorURL() {
            return this.mirrorURL;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorPassQueryString(Boolean mirrorPassQueryString) {
            this.mirrorPassQueryString = mirrorPassQueryString;
            return this;
        }
        public Boolean getMirrorPassQueryString() {
            return this.mirrorPassQueryString;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorFollowRedirect(Boolean mirrorFollowRedirect) {
            this.mirrorFollowRedirect = mirrorFollowRedirect;
            return this;
        }
        public Boolean getMirrorFollowRedirect() {
            return this.mirrorFollowRedirect;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorCheckMd5(Boolean mirrorCheckMd5) {
            this.mirrorCheckMd5 = mirrorCheckMd5;
            return this;
        }
        public Boolean getMirrorCheckMd5() {
            return this.mirrorCheckMd5;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setProtocol(String protocol) {
            this.protocol = protocol;
            return this;
        }
        public String getProtocol() {
            return this.protocol;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setHostName(String hostName) {
            this.hostName = hostName;
            return this;
        }
        public String getHostName() {
            return this.hostName;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setHttpRedirectCode(String httpRedirectCode) {
            this.httpRedirectCode = httpRedirectCode;
            return this;
        }
        public String getHttpRedirectCode() {
            return this.httpRedirectCode;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setReplaceKeyPrefixWith(String replaceKeyPrefixWith) {
            this.replaceKeyPrefixWith = replaceKeyPrefixWith;
            return this;
        }
        public String getReplaceKeyPrefixWith() {
            return this.replaceKeyPrefixWith;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect setReplaceKeyWith(String replaceKeyWith) {
            this.replaceKeyWith = replaceKeyWith;
            return this;
        }
        public String getReplaceKeyWith() {
            return this.replaceKeyWith;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule extends TeaModel {
        // Condition
        @NameInMap("Condition")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition condition;

        // Redirect
        @NameInMap("Redirect")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect redirect;

        // RuleNumber
        @NameInMap("RuleNumber")
        public Integer ruleNumber;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule self = new PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule setCondition(PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition condition) {
            this.condition = condition;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition getCondition() {
            return this.condition;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule setRedirect(PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect redirect) {
            this.redirect = redirect;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect getRedirect() {
            return this.redirect;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule setRuleNumber(Integer ruleNumber) {
            this.ruleNumber = ruleNumber;
            return this;
        }
        public Integer getRuleNumber() {
            return this.ruleNumber;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules extends TeaModel {
        // RoutingRule
        @NameInMap("RoutingRule")
        public java.util.List<PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule> routingRule;

        public static PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules self = new PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules setRoutingRule(java.util.List<PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule> routingRule) {
            this.routingRule = routingRule;
            return this;
        }
        public java.util.List<PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule> getRoutingRule() {
            return this.routingRule;
        }

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfiguration extends TeaModel {
        // IndexDocument
        @NameInMap("IndexDocument")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument indexDocument;

        // ErrorDocument
        @NameInMap("ErrorDocument")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument errorDocument;

        // RoutingRules
        @NameInMap("RoutingRules")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules routingRules;

        public static PutBucketWebsiteRequestBodyWebsiteConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBodyWebsiteConfiguration self = new PutBucketWebsiteRequestBodyWebsiteConfiguration();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBodyWebsiteConfiguration setIndexDocument(PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument indexDocument) {
            this.indexDocument = indexDocument;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument getIndexDocument() {
            return this.indexDocument;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfiguration setErrorDocument(PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument errorDocument) {
            this.errorDocument = errorDocument;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument getErrorDocument() {
            return this.errorDocument;
        }

        public PutBucketWebsiteRequestBodyWebsiteConfiguration setRoutingRules(PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules routingRules) {
            this.routingRules = routingRules;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules getRoutingRules() {
            return this.routingRules;
        }

    }

    public static class PutBucketWebsiteRequestBody extends TeaModel {
        // WebsiteConfiguration
        @NameInMap("WebsiteConfiguration")
        @Validation(required = true)
        public PutBucketWebsiteRequestBodyWebsiteConfiguration websiteConfiguration;

        public static PutBucketWebsiteRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketWebsiteRequestBody self = new PutBucketWebsiteRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketWebsiteRequestBody setWebsiteConfiguration(PutBucketWebsiteRequestBodyWebsiteConfiguration websiteConfiguration) {
            this.websiteConfiguration = websiteConfiguration;
            return this;
        }
        public PutBucketWebsiteRequestBodyWebsiteConfiguration getWebsiteConfiguration() {
            return this.websiteConfiguration;
        }

    }

}
