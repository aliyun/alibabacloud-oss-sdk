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

    public static class GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault extends TeaModel {
        @NameInMap("SSEAlgorithm")
        public String sSEAlgorithm;

        @NameInMap("KMSMasterKeyID")
        public String kMSMasterKeyID;

    }

    public static class GetBucketEncryptionResponseServerSideEncryptionRule extends TeaModel {
        @NameInMap("ApplyServerSideEncryptionByDefault")
        @Validation(required = true)
        public GetBucketEncryptionResponseServerSideEncryptionRuleApplyServerSideEncryptionByDefault applyServerSideEncryptionByDefault;

    }

}
