// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketWebsiteResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // WebsiteConfiguration
    @NameInMap("WebsiteConfiguration")
    @Validation(required = true)
    public GetBucketWebsiteResponseWebsiteConfiguration websiteConfiguration;

    public static GetBucketWebsiteResponse build(java.util.Map<String, ?> map) {
        GetBucketWebsiteResponse self = new GetBucketWebsiteResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketWebsiteResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketWebsiteResponse setWebsiteConfiguration(GetBucketWebsiteResponseWebsiteConfiguration websiteConfiguration) {
        this.websiteConfiguration = websiteConfiguration;
        return this;
    }
    public GetBucketWebsiteResponseWebsiteConfiguration getWebsiteConfiguration() {
        return this.websiteConfiguration;
    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument extends TeaModel {
        // Suffix
        @NameInMap("Suffix")
        public String suffix;

        public static GetBucketWebsiteResponseWebsiteConfigurationIndexDocument build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationIndexDocument self = new GetBucketWebsiteResponseWebsiteConfigurationIndexDocument();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationIndexDocument setSuffix(String suffix) {
            this.suffix = suffix;
            return this;
        }
        public String getSuffix() {
            return this.suffix;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        public static GetBucketWebsiteResponseWebsiteConfigurationErrorDocument build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationErrorDocument self = new GetBucketWebsiteResponseWebsiteConfigurationErrorDocument();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationErrorDocument setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Equals
        @NameInMap("Equals")
        public String equals;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader setEquals(String equals) {
            this.equals = equals;
            return this;
        }
        public String getEquals() {
            return this.equals;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition extends TeaModel {
        // KeyPrefixEquals
        @NameInMap("KeyPrefixEquals")
        public String keyPrefixEquals;

        // HttpErrorCodeReturnedEquals
        @NameInMap("HttpErrorCodeReturnedEquals")
        public String httpErrorCodeReturnedEquals;

        // IncludeHeader
        @NameInMap("IncludeHeader")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader includeHeader;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition setKeyPrefixEquals(String keyPrefixEquals) {
            this.keyPrefixEquals = keyPrefixEquals;
            return this;
        }
        public String getKeyPrefixEquals() {
            return this.keyPrefixEquals;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition setHttpErrorCodeReturnedEquals(String httpErrorCodeReturnedEquals) {
            this.httpErrorCodeReturnedEquals = httpErrorCodeReturnedEquals;
            return this;
        }
        public String getHttpErrorCodeReturnedEquals() {
            return this.httpErrorCodeReturnedEquals;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition setIncludeHeader(GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader includeHeader) {
            this.includeHeader = includeHeader;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader getIncludeHeader() {
            return this.includeHeader;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders extends TeaModel {
        // PassAll
        @NameInMap("PassAll")
        public Boolean passAll;

        // Pass
        @NameInMap("Pass")
        public String pass;

        // Remove
        @NameInMap("Remove")
        public String remove;

        // Set
        @NameInMap("Set")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet set;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setPassAll(Boolean passAll) {
            this.passAll = passAll;
            return this;
        }
        public Boolean getPassAll() {
            return this.passAll;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setPass(String pass) {
            this.pass = pass;
            return this;
        }
        public String getPass() {
            return this.pass;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setRemove(String remove) {
            this.remove = remove;
            return this;
        }
        public String getRemove() {
            return this.remove;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders setSet(GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet set) {
            this.set = set;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet getSet() {
            return this.set;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect extends TeaModel {
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

        // MirrorHeaders
        @NameInMap("MirrorHeaders")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders mirrorHeaders;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setRedirectType(String redirectType) {
            this.redirectType = redirectType;
            return this;
        }
        public String getRedirectType() {
            return this.redirectType;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setPassQueryString(Boolean passQueryString) {
            this.passQueryString = passQueryString;
            return this;
        }
        public Boolean getPassQueryString() {
            return this.passQueryString;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorURL(String mirrorURL) {
            this.mirrorURL = mirrorURL;
            return this;
        }
        public String getMirrorURL() {
            return this.mirrorURL;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorPassQueryString(Boolean mirrorPassQueryString) {
            this.mirrorPassQueryString = mirrorPassQueryString;
            return this;
        }
        public Boolean getMirrorPassQueryString() {
            return this.mirrorPassQueryString;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorFollowRedirect(Boolean mirrorFollowRedirect) {
            this.mirrorFollowRedirect = mirrorFollowRedirect;
            return this;
        }
        public Boolean getMirrorFollowRedirect() {
            return this.mirrorFollowRedirect;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorCheckMd5(Boolean mirrorCheckMd5) {
            this.mirrorCheckMd5 = mirrorCheckMd5;
            return this;
        }
        public Boolean getMirrorCheckMd5() {
            return this.mirrorCheckMd5;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setProtocol(String protocol) {
            this.protocol = protocol;
            return this;
        }
        public String getProtocol() {
            return this.protocol;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setHostName(String hostName) {
            this.hostName = hostName;
            return this;
        }
        public String getHostName() {
            return this.hostName;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setHttpRedirectCode(String httpRedirectCode) {
            this.httpRedirectCode = httpRedirectCode;
            return this;
        }
        public String getHttpRedirectCode() {
            return this.httpRedirectCode;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setReplaceKeyPrefixWith(String replaceKeyPrefixWith) {
            this.replaceKeyPrefixWith = replaceKeyPrefixWith;
            return this;
        }
        public String getReplaceKeyPrefixWith() {
            return this.replaceKeyPrefixWith;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setReplaceKeyWith(String replaceKeyWith) {
            this.replaceKeyWith = replaceKeyWith;
            return this;
        }
        public String getReplaceKeyWith() {
            return this.replaceKeyWith;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect setMirrorHeaders(GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders mirrorHeaders) {
            this.mirrorHeaders = mirrorHeaders;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders getMirrorHeaders() {
            return this.mirrorHeaders;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule extends TeaModel {
        // RuleNumber
        @NameInMap("RuleNumber")
        public Integer ruleNumber;

        // Condition
        @NameInMap("Condition")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition condition;

        // Redirect
        @NameInMap("Redirect")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect redirect;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule setRuleNumber(Integer ruleNumber) {
            this.ruleNumber = ruleNumber;
            return this;
        }
        public Integer getRuleNumber() {
            return this.ruleNumber;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule setCondition(GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition condition) {
            this.condition = condition;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition getCondition() {
            return this.condition;
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule setRedirect(GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect redirect) {
            this.redirect = redirect;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect getRedirect() {
            return this.redirect;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules extends TeaModel {
        // RoutingRule
        @NameInMap("RoutingRule")
        public java.util.List<GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule> routingRule;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRules build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRules self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRules();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRules setRoutingRule(java.util.List<GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule> routingRule) {
            this.routingRule = routingRule;
            return this;
        }
        public java.util.List<GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule> getRoutingRule() {
            return this.routingRule;
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfiguration extends TeaModel {
        // IndexDocument
        @NameInMap("IndexDocument")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationIndexDocument indexDocument;

        // ErrorDocument
        @NameInMap("ErrorDocument")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationErrorDocument errorDocument;

        // RoutingRules
        @NameInMap("RoutingRules")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRules routingRules;

        public static GetBucketWebsiteResponseWebsiteConfiguration build(java.util.Map<String, ?> map) {
            GetBucketWebsiteResponseWebsiteConfiguration self = new GetBucketWebsiteResponseWebsiteConfiguration();
            return TeaModel.build(map, self);
        }

        public GetBucketWebsiteResponseWebsiteConfiguration setIndexDocument(GetBucketWebsiteResponseWebsiteConfigurationIndexDocument indexDocument) {
            this.indexDocument = indexDocument;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationIndexDocument getIndexDocument() {
            return this.indexDocument;
        }

        public GetBucketWebsiteResponseWebsiteConfiguration setErrorDocument(GetBucketWebsiteResponseWebsiteConfigurationErrorDocument errorDocument) {
            this.errorDocument = errorDocument;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationErrorDocument getErrorDocument() {
            return this.errorDocument;
        }

        public GetBucketWebsiteResponseWebsiteConfiguration setRoutingRules(GetBucketWebsiteResponseWebsiteConfigurationRoutingRules routingRules) {
            this.routingRules = routingRules;
            return this;
        }
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRules getRoutingRules() {
            return this.routingRules;
        }

    }

}
