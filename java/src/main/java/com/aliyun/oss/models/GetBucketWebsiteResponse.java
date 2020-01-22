// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketWebsiteResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("WebsiteConfiguration")
    @Validation(required = true)
    public GetBucketWebsiteResponseWebsiteConfiguration websiteConfiguration;

    public static GetBucketWebsiteResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketWebsiteResponse self = new GetBucketWebsiteResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument extends TeaModel {
        @NameInMap("Suffix")
        public String suffix;

        public static GetBucketWebsiteResponseWebsiteConfigurationIndexDocument build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationIndexDocument self = new GetBucketWebsiteResponseWebsiteConfigurationIndexDocument();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument extends TeaModel {
        @NameInMap("Key")
        public String key;

        public static GetBucketWebsiteResponseWebsiteConfigurationErrorDocument build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationErrorDocument self = new GetBucketWebsiteResponseWebsiteConfigurationErrorDocument();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Equals")
        public String equals;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition extends TeaModel {
        @NameInMap("KeyPrefixEquals")
        public String keyPrefixEquals;

        @NameInMap("HttpErrorCodeReturnedEquals")
        public String httpErrorCodeReturnedEquals;

        @NameInMap("IncludeHeader")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader includeHeader;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders extends TeaModel {
        @NameInMap("PassAll")
        public boolean passAll;

        @NameInMap("Pass")
        public String pass;

        @NameInMap("Remove")
        public String remove;

        @NameInMap("Set")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet set;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect extends TeaModel {
        @NameInMap("RedirectType")
        public String redirectType;

        @NameInMap("PassQueryString")
        public boolean passQueryString;

        @NameInMap("MirrorURL")
        public String mirrorURL;

        @NameInMap("MirrorPassQueryString")
        public boolean mirrorPassQueryString;

        @NameInMap("MirrorFollowRedirect")
        public boolean mirrorFollowRedirect;

        @NameInMap("MirrorCheckMd5")
        public boolean mirrorCheckMd5;

        @NameInMap("Protocol")
        public String protocol;

        @NameInMap("HostName")
        public String hostName;

        @NameInMap("HttpRedirectCode")
        public String httpRedirectCode;

        @NameInMap("ReplaceKeyPrefixWith")
        public String replaceKeyPrefixWith;

        @NameInMap("ReplaceKeyWith")
        public String replaceKeyWith;

        @NameInMap("MirrorHeaders")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders mirrorHeaders;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule extends TeaModel {
        @NameInMap("RuleNumber")
        public Integer ruleNumber;

        @NameInMap("Condition")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition condition;

        @NameInMap("Redirect")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirect redirect;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules extends TeaModel {
        @NameInMap("RoutingRule")
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule[] routingRule;

        public static GetBucketWebsiteResponseWebsiteConfigurationRoutingRules build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfigurationRoutingRules self = new GetBucketWebsiteResponseWebsiteConfigurationRoutingRules();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketWebsiteResponseWebsiteConfiguration extends TeaModel {
        @NameInMap("IndexDocument")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationIndexDocument indexDocument;

        @NameInMap("ErrorDocument")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationErrorDocument errorDocument;

        @NameInMap("RoutingRules")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRules routingRules;

        public static GetBucketWebsiteResponseWebsiteConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketWebsiteResponseWebsiteConfiguration self = new GetBucketWebsiteResponseWebsiteConfiguration();
            return TeaModel.build(map, self);
        }

    }

}
