// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketWebsiteRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketWebsiteRequestBody body;

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument extends TeaModel {
        @NameInMap("Suffix")
        public String suffix;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument extends TeaModel {
        @NameInMap("Key")
        public String key;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Equals")
        public String equals;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition extends TeaModel {
        @NameInMap("IncludeHeader")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader includeHeader;

        @NameInMap("KeyPrefixEquals")
        public String keyPrefixEquals;

        @NameInMap("HttpErrorCodeReturnedEquals")
        public String httpErrorCodeReturnedEquals;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders extends TeaModel {
        @NameInMap("Set")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet set;

        @NameInMap("PassAll")
        public boolean passAll;

        @NameInMap("Pass")
        public String pass;

        @NameInMap("Remove")
        public String remove;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect extends TeaModel {
        @NameInMap("MirrorHeaders")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeaders mirrorHeaders;

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

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule extends TeaModel {
        @NameInMap("Condition")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleCondition condition;

        @NameInMap("Redirect")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRuleRedirect redirect;

        @NameInMap("RuleNumber")
        public Integer ruleNumber;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules extends TeaModel {
        @NameInMap("RoutingRule")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRulesRoutingRule[] routingRule;

    }

    public static class PutBucketWebsiteRequestBodyWebsiteConfiguration extends TeaModel {
        @NameInMap("IndexDocument")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationIndexDocument indexDocument;

        @NameInMap("ErrorDocument")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationErrorDocument errorDocument;

        @NameInMap("RoutingRules")
        public PutBucketWebsiteRequestBodyWebsiteConfigurationRoutingRules routingRules;

    }

    public static class PutBucketWebsiteRequestBody extends TeaModel {
        @NameInMap("WebsiteConfiguration")
        @Validation(required = true)
        public PutBucketWebsiteRequestBodyWebsiteConfiguration websiteConfiguration;

    }

}
