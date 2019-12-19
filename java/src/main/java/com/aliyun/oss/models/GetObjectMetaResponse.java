// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetObjectMetaResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("etag")
    @Validation(required = true)
    public String eTag;

    @NameInMap("content-length")
    @Validation(required = true)
    public String contentLength;

    @NameInMap("last-modified")
    @Validation(required = true)
    public String lastModified;

}
