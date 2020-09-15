// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketEncryptionResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // ServerSideEncryptionRule
    @NameInMap("ServerSideEncryptionRule")
    @Validation(required = true)
    public GetBucketEncryptionResponseServerSideEncryptionRule serverSideEncryptionRule;

    public static GetBucketEncryptionResponse build(java.util.Map<String, ?> map) {
        GetBucketEncryptionResponse self = new GetBucketEncryptionResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketEncryptionResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketEncryptionResponse setServerSideEncryptionRule(GetBucketEncryptionResponseServerSideEncryptionRule serverSideEncryptionRule) {
        this.serverSideEncryptionRule = serverSideEncryptionRule;
        return this;
    }
    public GetBucketEncryptionResponseServerSideEncryptionRule getServerSideEncryptionRule() {
        return this.serverSideEncryptionRule;
    }

    public static class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends TeaModel {
        // SSEAlgorithm
        @NameInMap("SSEAlgorithm")
        public String sSEAlgorithm;

        // KMSMasterKeyID
        @NameInMap("KMSMasterKeyID")
        public String kMSMasterKeyID;

        public static GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault build(java.util.Map<String, ?> map) {
            GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault self = new GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault();
            return TeaModel.build(map, self);
        }

        public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault setSSEAlgorithm(String sSEAlgorithm) {
            this.sSEAlgorithm = sSEAlgorithm;
            return this;
        }
        public String getSSEAlgorithm() {
            return this.sSEAlgorithm;
        }

        public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault setKMSMasterKeyID(String kMSMasterKeyID) {
            this.kMSMasterKeyID = kMSMasterKeyID;
            return this;
        }
        public String getKMSMasterKeyID() {
            return this.kMSMasterKeyID;
        }

    }

    public static class GetBucketEncryptionResponseServerSideEncryptionRule extends TeaModel {
        // ApplyServerSideEncryptionByDefault
        @NameInMap("ApplyServerSideEncryptionByDefault")
        @Validation(required = true)
        public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault;

        public static GetBucketEncryptionResponseServerSideEncryptionRule build(java.util.Map<String, ?> map) {
            GetBucketEncryptionResponseServerSideEncryptionRule self = new GetBucketEncryptionResponseServerSideEncryptionRule();
            return TeaModel.build(map, self);
        }

        public GetBucketEncryptionResponseServerSideEncryptionRule setApplyServerSideEncryptionByDefault(GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault) {
            this.applyServerSideEncryptionByDefault = applyServerSideEncryptionByDefault;
            return this;
        }
        public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault getApplyServerSideEncryptionByDefault() {
            return this.applyServerSideEncryptionByDefault;
        }

    }

}
