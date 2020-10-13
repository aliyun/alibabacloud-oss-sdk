// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectAclResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // AccessControlPolicy
    @NameInMap("AccessControlPolicy")
    @Validation(required = true)
    public GetObjectAclResponseAccessControlPolicy accessControlPolicy;

    public static GetObjectAclResponse build(java.util.Map<String, ?> map) throws Exception {
        GetObjectAclResponse self = new GetObjectAclResponse();
        return TeaModel.build(map, self);
    }

    public GetObjectAclResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetObjectAclResponse setAccessControlPolicy(GetObjectAclResponseAccessControlPolicy accessControlPolicy) {
        this.accessControlPolicy = accessControlPolicy;
        return this;
    }
    public GetObjectAclResponseAccessControlPolicy getAccessControlPolicy() {
        return this.accessControlPolicy;
    }

    public static class GetObjectAclResponseAccessControlPolicyOwner extends TeaModel {
        // ID
        @NameInMap("ID")
        public String iD;

        // DisplayName
        @NameInMap("DisplayName")
        public String displayName;

        public static GetObjectAclResponseAccessControlPolicyOwner build(java.util.Map<String, ?> map) throws Exception {
            GetObjectAclResponseAccessControlPolicyOwner self = new GetObjectAclResponseAccessControlPolicyOwner();
            return TeaModel.build(map, self);
        }

        public GetObjectAclResponseAccessControlPolicyOwner setID(String iD) {
            this.iD = iD;
            return this;
        }
        public String getID() {
            return this.iD;
        }

        public GetObjectAclResponseAccessControlPolicyOwner setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetObjectAclResponseAccessControlPolicyAccessControlList extends TeaModel {
        // Grant
        @NameInMap("Grant")
        public String grant;

        public static GetObjectAclResponseAccessControlPolicyAccessControlList build(java.util.Map<String, ?> map) throws Exception {
            GetObjectAclResponseAccessControlPolicyAccessControlList self = new GetObjectAclResponseAccessControlPolicyAccessControlList();
            return TeaModel.build(map, self);
        }

        public GetObjectAclResponseAccessControlPolicyAccessControlList setGrant(String grant) {
            this.grant = grant;
            return this;
        }
        public String getGrant() {
            return this.grant;
        }

    }

    public static class GetObjectAclResponseAccessControlPolicy extends TeaModel {
        // Owner
        @NameInMap("Owner")
        @Validation(required = true)
        public GetObjectAclResponseAccessControlPolicyOwner owner;

        // AccessControlList
        @NameInMap("AccessControlList")
        @Validation(required = true)
        public GetObjectAclResponseAccessControlPolicyAccessControlList accessControlList;

        public static GetObjectAclResponseAccessControlPolicy build(java.util.Map<String, ?> map) throws Exception {
            GetObjectAclResponseAccessControlPolicy self = new GetObjectAclResponseAccessControlPolicy();
            return TeaModel.build(map, self);
        }

        public GetObjectAclResponseAccessControlPolicy setOwner(GetObjectAclResponseAccessControlPolicyOwner owner) {
            this.owner = owner;
            return this;
        }
        public GetObjectAclResponseAccessControlPolicyOwner getOwner() {
            return this.owner;
        }

        public GetObjectAclResponseAccessControlPolicy setAccessControlList(GetObjectAclResponseAccessControlPolicyAccessControlList accessControlList) {
            this.accessControlList = accessControlList;
            return this;
        }
        public GetObjectAclResponseAccessControlPolicyAccessControlList getAccessControlList() {
            return this.accessControlList;
        }

    }

}
