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

    public static class GetBucketWebsiteResponseWebsiteConfigurationIndexDocument extends TeaModel {
        @NameInMap("Suffix")
        public String suffix;

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationErrorDocument extends TeaModel {
        @NameInMap("Key")
        public String key;

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Equals")
        public String equals;

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleCondition extends TeaModel {
        @NameInMap("KeyPrefixEquals")
        public String keyPrefixEquals;

        @NameInMap("HttpErrorCodeReturnedEquals")
        public String httpErrorCodeReturnedEquals;

        @NameInMap("IncludeHeader")
        @Validation(required = true)
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleConditionIncludeHeader includeHeader;

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRuleRedirectMirrorHeadersSet extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

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

    }

    public static class GetBucketWebsiteResponseWebsiteConfigurationRoutingRules extends TeaModel {
        @NameInMap("RoutingRule")
        public GetBucketWebsiteResponseWebsiteConfigurationRoutingRulesRoutingRule[] routingRule;

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

    }

}
