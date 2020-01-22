// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketAclResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("AccessControlPolicy")
    @Validation(required = true)
    public GetBucketAclResponseAccessControlPolicy accessControlPolicy;

    public static GetBucketAclResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketAclResponse self = new GetBucketAclResponse();
        return TeaModel.build(map, self);
    }

    public static class GetBucketAclResponseAccessControlPolicyOwner extends TeaModel {
        @NameInMap("ID")
        public String iD;

        @NameInMap("DisplayName")
        public String displayName;

        public static GetBucketAclResponseAccessControlPolicyOwner build(java.util.Map<String, ?> map) throws Exception {
            GetBucketAclResponseAccessControlPolicyOwner self = new GetBucketAclResponseAccessControlPolicyOwner();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketAclResponseAccessControlPolicyAccessControlList extends TeaModel {
        @NameInMap("Grant")
        public String grant;

        public static GetBucketAclResponseAccessControlPolicyAccessControlList build(java.util.Map<String, ?> map) throws Exception {
            GetBucketAclResponseAccessControlPolicyAccessControlList self = new GetBucketAclResponseAccessControlPolicyAccessControlList();
            return TeaModel.build(map, self);
        }

    }

    public static class GetBucketAclResponseAccessControlPolicy extends TeaModel {
        @NameInMap("Owner")
        @Validation(required = true)
        public GetBucketAclResponseAccessControlPolicyOwner owner;

        @NameInMap("AccessControlList")
        @Validation(required = true)
        public GetBucketAclResponseAccessControlPolicyAccessControlList accessControlList;

        public static GetBucketAclResponseAccessControlPolicy build(java.util.Map<String, ?> map) throws Exception {
            GetBucketAclResponseAccessControlPolicy self = new GetBucketAclResponseAccessControlPolicy();
            return TeaModel.build(map, self);
        }

    }

}
