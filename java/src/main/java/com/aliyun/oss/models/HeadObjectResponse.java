// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class HeadObjectResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("usermeta")
    @Validation(required = true)
    public java.util.Map<String, String> userMeta;

    @NameInMap("x-oss-server-side-encryption")
    @Validation(required = true)
    public String serverSideEncryption;

    @NameInMap("x-oss-server-side-encryption-key-id")
    @Validation(required = true)
    public String serverSideEncryptionKeyId;

    @NameInMap("x-oss-storage-class")
    @Validation(required = true)
    public String storageClass;

    @NameInMap("x-oss-object-type")
    @Validation(required = true)
    public String objectType;

    @NameInMap("x-oss-next-append-position")
    @Validation(required = true)
    public String nextAppendPosition;

    @NameInMap("x-oss-hash-crc64ecma")
    @Validation(required = true)
    public String hashCrc64ecma;

    @NameInMap("x-oss-expiration")
    @Validation(required = true)
    public String expiration;

    @NameInMap("x-oss-restore")
    @Validation(required = true)
    public String restore;

    @NameInMap("x-oss-process-status")
    @Validation(required = true)
    public String processStatus;

    @NameInMap("x-oss-request-charged")
    @Validation(required = true)
    public String requestCharged;

    @NameInMap("content-md5")
    @Validation(required = true)
    public String contentMd5;

    @NameInMap("last-modified")
    @Validation(required = true)
    public String lastModified;

    @NameInMap("access-control-allow-origin")
    @Validation(required = true)
    public String accessControlAllowOrigin;

    @NameInMap("access-control-allow-methods")
    @Validation(required = true)
    public String accessControlAllowMethods;

    @NameInMap("access-control-max-age")
    @Validation(required = true)
    public String accessControlMaxAge;

    @NameInMap("access-control-allow-headers")
    @Validation(required = true)
    public String accessControlAllowHeaders;

    @NameInMap("access-control-expose-headers")
    @Validation(required = true)
    public String accessControlExposeHeaders;

    @NameInMap("x-oss-tagging-count")
    @Validation(required = true)
    public String taggingCount;

    public static HeadObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        HeadObjectResponse self = new HeadObjectResponse();
        return TeaModel.build(map, self);
    }

}
