// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLifecycleResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("LifecycleConfiguration")
    @Validation(required = true)
    public GetBucketLifecycleResponseLifecycleConfiguration lifecycleConfiguration;

    public static GetBucketLifecycleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLifecycleResponse self = new GetBucketLifecycleResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration self = new GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("StorageClass")
        public String storageClass;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleTransition build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleTransition self = new GetBucketLifecycleResponseLifecycleConfigurationRuleTransition();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload self = new GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleTag build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleTag self = new GetBucketLifecycleResponseLifecycleConfigurationRuleTag();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRule extends TeaModel {
        @NameInMap("ID")
        public String iD;

        @NameInMap("Prefix")
        public String prefix;

        @NameInMap("Status")
        public String status;

        @NameInMap("Expiration")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration expiration;

        @NameInMap("Transition")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleTransition transition;

        @NameInMap("AbortMultipartUpload")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload abortMultipartUpload;

        @NameInMap("Tag")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleTag tag;

        public static GetBucketLifecycleResponseLifecycleConfigurationRule build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRule self = new GetBucketLifecycleResponseLifecycleConfigurationRule();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfiguration extends TeaModel {
        @NameInMap("Rule")
        public GetBucketLifecycleResponseLifecycleConfigurationRule[] rule;

        public static GetBucketLifecycleResponseLifecycleConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfiguration self = new GetBucketLifecycleResponseLifecycleConfiguration();
            return TeaModel.build(map, self);
        }

    }

}
