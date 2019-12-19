// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteMultipleObjectsResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("DeleteResult")
    @Validation(required = true)
    public DeleteMultipleObjectsResponseDeleteResult deleteResult;

    public static class DeleteMultipleObjectsResponseDeleteResultDeleted extends TeaModel {
        @NameInMap("Key")
        public String key;

    }

    public static class DeleteMultipleObjectsResponseDeleteResult extends TeaModel {
        @NameInMap("Quiet")
        public String quiet;

        @NameInMap("EncodingType")
        public String encodingType;

        @NameInMap("Deleted")
        public DeleteMultipleObjectsResponseDeleteResultDeleted[] deleted;

    }

}
