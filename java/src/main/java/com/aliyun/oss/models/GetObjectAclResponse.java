// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectAclResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("AccessControlPolicy")
    @Validation(required = true)
    public GetObjectAclResponseAccessControlPolicy accessControlPolicy;

    public static class GetObjectAclResponseAccessControlPolicyOwner extends TeaModel {
        @NameInMap("ID")
        public String iD;

        @NameInMap("DisplayName")
        public String displayName;

    }

    public static class GetObjectAclResponseAccessControlPolicyAccessControlList extends TeaModel {
        @NameInMap("Grant")
        public String grant;

    }

    public static class GetObjectAclResponseAccessControlPolicy extends TeaModel {
        @NameInMap("Owner")
        @Validation(required = true)
        public GetObjectAclResponseAccessControlPolicyOwner owner;

        @NameInMap("AccessControlList")
        @Validation(required = true)
        public GetObjectAclResponseAccessControlPolicyAccessControlList accessControlList;

    }

}
