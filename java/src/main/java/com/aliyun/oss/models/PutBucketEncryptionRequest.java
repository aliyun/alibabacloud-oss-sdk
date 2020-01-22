// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketEncryptionRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Body")
    public PutBucketEncryptionRequestBody body;

    public static PutBucketEncryptionRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketEncryptionRequest self = new PutBucketEncryptionRequest();
        return TeaModel.build(map, self);
    }

    public static class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends TeaModel {
        @NameInMap("SSEAlgorithm")
        public String sSEAlgorithm;

        @NameInMap("KMSMasterKeyID")
        public String kMSMasterKeyID;

        public static PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault build(java.util.Map<String, ?> map) throws Exception {
            PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault self = new PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketEncryptionRequestBodyServerSideEncryptionRule extends TeaModel {
        @NameInMap("ApplyServerSideEncryptionByDefault")
        public PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault;

        public static PutBucketEncryptionRequestBodyServerSideEncryptionRule build(java.util.Map<String, ?> map) throws Exception {
            PutBucketEncryptionRequestBodyServerSideEncryptionRule self = new PutBucketEncryptionRequestBodyServerSideEncryptionRule();
            return TeaModel.build(map, self);
        }

    }

    public static class PutBucketEncryptionRequestBody extends TeaModel {
        @NameInMap("ServerSideEncryptionRule")
        @Validation(required = true)
        public PutBucketEncryptionRequestBodyServerSideEncryptionRule serverSideEncryptionRule;

        public static PutBucketEncryptionRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketEncryptionRequestBody self = new PutBucketEncryptionRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
