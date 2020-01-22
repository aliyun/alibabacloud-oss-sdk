// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketEncryptionResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("ServerSideEncryptionRule")
    @Validation(required = true)
    public GetBucketEncryptionResponseServerSideEncryptionRule serverSideEncryptionRule;

    public static GetBucketEncryptionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketEncryptionResponse self = new GetBucketEncryptionResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends TeaModel {
        @NameInMap("SSEAlgorithm")
        public String sSEAlgorithm;

        @NameInMap("KMSMasterKeyID")
        public String kMSMasterKeyID;

        public static GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault build(java.util.Map<String, ?> map) throws Exception {
            GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault self = new GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketEncryptionResponseServerSideEncryptionRule extends TeaModel {
        @NameInMap("ApplyServerSideEncryptionByDefault")
        @Validation(required = true)
        public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault;

        public static GetBucketEncryptionResponseServerSideEncryptionRule build(java.util.Map<String, ?> map) throws Exception {
            GetBucketEncryptionResponseServerSideEncryptionRule self = new GetBucketEncryptionResponseServerSideEncryptionRule();
            return TeaModel.build(map, self);
        }

    }

}
