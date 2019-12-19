// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketEncryptionRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketEncryptionRequestBody body;

    public static class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends TeaModel {
        @NameInMap("SSEAlgorithm")
        public String sSEAlgorithm;

        @NameInMap("KMSMasterKeyID")
        public String kMSMasterKeyID;

    }

    public static class PutBucketEncryptionRequestBodyServerSideEncryptionRule extends TeaModel {
        @NameInMap("ApplyServerSideEncryptionByDefault")
        public PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault;

    }

    public static class PutBucketEncryptionRequestBody extends TeaModel {
        @NameInMap("ServerSideEncryptionRule")
        @Validation(required = true)
        public PutBucketEncryptionRequestBodyServerSideEncryptionRule serverSideEncryptionRule;

    }

}
