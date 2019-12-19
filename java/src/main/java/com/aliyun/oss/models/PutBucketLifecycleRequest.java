// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLifecycleRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketLifecycleRequestBody body;

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("StorageClass")
        public String storageClass;

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload extends TeaModel {
        @NameInMap("Days")
        public Integer days;

        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag extends TeaModel {
        @NameInMap("Key")
        public String key;

        @NameInMap("Value")
        public String value;

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

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfiguration extends TeaModel {
        @NameInMap("Rule")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule[] rule;

    }

    public static class PutBucketLifecycleRequestBody extends TeaModel {
        @NameInMap("LifecycleConfiguration")
        @Validation(required = true)
        public PutBucketLifecycleRequestBodyLifecycleConfiguration lifecycleConfiguration;

    }

}
