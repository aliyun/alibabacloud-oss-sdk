// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketAclResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // AccessControlPolicy
    @NameInMap("AccessControlPolicy")
    @Validation(required = true)
    public GetBucketAclResponseAccessControlPolicy accessControlPolicy;

    public static GetBucketAclResponse build(java.util.Map<String, ?> map) {
        GetBucketAclResponse self = new GetBucketAclResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketAclResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketAclResponse setAccessControlPolicy(GetBucketAclResponseAccessControlPolicy accessControlPolicy) {
        this.accessControlPolicy = accessControlPolicy;
        return this;
    }
    public GetBucketAclResponseAccessControlPolicy getAccessControlPolicy() {
        return this.accessControlPolicy;
    }

    public static class GetBucketAclResponseAccessControlPolicyOwner extends TeaModel {
        // ID
        @NameInMap("ID")
        public String iD;

        // DisplayName
        @NameInMap("DisplayName")
        public String displayName;

        public static GetBucketAclResponseAccessControlPolicyOwner build(java.util.Map<String, ?> map) {
            GetBucketAclResponseAccessControlPolicyOwner self = new GetBucketAclResponseAccessControlPolicyOwner();
            return TeaModel.build(map, self);
        }

        public GetBucketAclResponseAccessControlPolicyOwner setID(String iD) {
            this.iD = iD;
            return this;
        }
        public String getID() {
            return this.iD;
        }

        public GetBucketAclResponseAccessControlPolicyOwner setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetBucketAclResponseAccessControlPolicyAccessControlList extends TeaModel {
        // Grant
        @NameInMap("Grant")
        public String grant;

        public static GetBucketAclResponseAccessControlPolicyAccessControlList build(java.util.Map<String, ?> map) {
            GetBucketAclResponseAccessControlPolicyAccessControlList self = new GetBucketAclResponseAccessControlPolicyAccessControlList();
            return TeaModel.build(map, self);
        }

        public GetBucketAclResponseAccessControlPolicyAccessControlList setGrant(String grant) {
            this.grant = grant;
            return this;
        }
        public String getGrant() {
            return this.grant;
        }

    }

    public static class GetBucketAclResponseAccessControlPolicy extends TeaModel {
        // Owner
        @NameInMap("Owner")
        @Validation(required = true)
        public GetBucketAclResponseAccessControlPolicyOwner owner;

        // AccessControlList
        @NameInMap("AccessControlList")
        @Validation(required = true)
        public GetBucketAclResponseAccessControlPolicyAccessControlList accessControlList;

        public static GetBucketAclResponseAccessControlPolicy build(java.util.Map<String, ?> map) {
            GetBucketAclResponseAccessControlPolicy self = new GetBucketAclResponseAccessControlPolicy();
            return TeaModel.build(map, self);
        }

        public GetBucketAclResponseAccessControlPolicy setOwner(GetBucketAclResponseAccessControlPolicyOwner owner) {
            this.owner = owner;
            return this;
        }
        public GetBucketAclResponseAccessControlPolicyOwner getOwner() {
            return this.owner;
        }

        public GetBucketAclResponseAccessControlPolicy setAccessControlList(GetBucketAclResponseAccessControlPolicyAccessControlList accessControlList) {
            this.accessControlList = accessControlList;
            return this;
        }
        public GetBucketAclResponseAccessControlPolicyAccessControlList getAccessControlList() {
            return this.accessControlList;
        }

    }

}
