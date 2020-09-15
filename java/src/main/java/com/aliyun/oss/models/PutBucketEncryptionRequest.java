// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketEncryptionRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketEncryptionRequestBody body;

    public static PutBucketEncryptionRequest build(java.util.Map<String, ?> map) {
        PutBucketEncryptionRequest self = new PutBucketEncryptionRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketEncryptionRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketEncryptionRequest setBody(PutBucketEncryptionRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketEncryptionRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends TeaModel {
        // SSEAlgorithm
        @NameInMap("SSEAlgorithm")
        public String sSEAlgorithm;

        // KMSMasterKeyID
        @NameInMap("KMSMasterKeyID")
        public String kMSMasterKeyID;

        public static PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault build(java.util.Map<String, ?> map) {
            PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault self = new PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault();
            return TeaModel.build(map, self);
        }

        public PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault setSSEAlgorithm(String sSEAlgorithm) {
            this.sSEAlgorithm = sSEAlgorithm;
            return this;
        }
        public String getSSEAlgorithm() {
            return this.sSEAlgorithm;
        }

        public PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault setKMSMasterKeyID(String kMSMasterKeyID) {
            this.kMSMasterKeyID = kMSMasterKeyID;
            return this;
        }
        public String getKMSMasterKeyID() {
            return this.kMSMasterKeyID;
        }

    }

    public static class PutBucketEncryptionRequestBodyServerSideEncryptionRule extends TeaModel {
        // ApplyServerSideEncryptionByDefault
        @NameInMap("ApplyServerSideEncryptionByDefault")
        public PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault;

        public static PutBucketEncryptionRequestBodyServerSideEncryptionRule build(java.util.Map<String, ?> map) {
            PutBucketEncryptionRequestBodyServerSideEncryptionRule self = new PutBucketEncryptionRequestBodyServerSideEncryptionRule();
            return TeaModel.build(map, self);
        }

        public PutBucketEncryptionRequestBodyServerSideEncryptionRule setApplyServerSideEncryptionByDefault(PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault) {
            this.applyServerSideEncryptionByDefault = applyServerSideEncryptionByDefault;
            return this;
        }
        public PutBucketEncryptionRequestBodyServerSideEncryptionRuleApplyServerSideEncryptionByDefault getApplyServerSideEncryptionByDefault() {
            return this.applyServerSideEncryptionByDefault;
        }

    }

    public static class PutBucketEncryptionRequestBody extends TeaModel {
        // ServerSideEncryptionRule
        @NameInMap("ServerSideEncryptionRule")
        @Validation(required = true)
        public PutBucketEncryptionRequestBodyServerSideEncryptionRule serverSideEncryptionRule;

        public static PutBucketEncryptionRequestBody build(java.util.Map<String, ?> map) {
            PutBucketEncryptionRequestBody self = new PutBucketEncryptionRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketEncryptionRequestBody setServerSideEncryptionRule(PutBucketEncryptionRequestBodyServerSideEncryptionRule serverSideEncryptionRule) {
            this.serverSideEncryptionRule = serverSideEncryptionRule;
            return this;
        }
        public PutBucketEncryptionRequestBodyServerSideEncryptionRule getServerSideEncryptionRule() {
            return this.serverSideEncryptionRule;
        }

    }

}
