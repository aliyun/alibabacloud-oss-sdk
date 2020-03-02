// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLifecycleRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketLifecycleRequestBody body;

    public static PutBucketLifecycleRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketLifecycleRequest self = new PutBucketLifecycleRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("StorageClass")
        public String storageClass;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRule extends TeaModel {
        @NameInMap("Expiration")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration expiration;

        @NameInMap("Transition")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition transition;

        @NameInMap("AbortMultipartUpload")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload abortMultipartUpload;

        @NameInMap("Tag")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag tag;

        @NameInMap("ID")
        public String iD;

        @NameInMap("Prefix")
        public String prefix;

        @NameInMap("Status")
        public String status;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRule build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRule self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRule();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfiguration extends TeaModel {
        @NameInMap("Rule")
        public java.util.List<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> rule;

        public static PutBucketLifecycleRequestBodyLifecycleConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfiguration self = new PutBucketLifecycleRequestBodyLifecycleConfiguration();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketLifecycleRequestBody extends TeaModel {
        @NameInMap("LifecycleConfiguration")
        @Validation(required = true)
        public PutBucketLifecycleRequestBodyLifecycleConfiguration lifecycleConfiguration;

        public static PutBucketLifecycleRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBody self = new PutBucketLifecycleRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
