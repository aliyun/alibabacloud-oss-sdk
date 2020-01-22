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

    public static DeleteMultipleObjectsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMultipleObjectsResponse self = new DeleteMultipleObjectsResponse();
        return TeaModel.build(map, self);
    }

    public static class DeleteMultipleObjectsResponseDeleteResultDeleted extends TeaModel {
        @NameInMap("Key")
        public String key;

        public static DeleteMultipleObjectsResponseDeleteResultDeleted build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsResponseDeleteResultDeleted self = new DeleteMultipleObjectsResponseDeleteResultDeleted();
            return TeaModel.build(map, self);
        }

    }

    public static class DeleteMultipleObjectsResponseDeleteResult extends TeaModel {
        @NameInMap("Quiet")
        public String quiet;

        @NameInMap("EncodingType")
        public String encodingType;

        @NameInMap("Deleted")
        public DeleteMultipleObjectsResponseDeleteResultDeleted[] deleted;

        public static DeleteMultipleObjectsResponseDeleteResult build(java.util.Map<String, ?> map) throws Exception {
            DeleteMultipleObjectsResponseDeleteResult self = new DeleteMultipleObjectsResponseDeleteResult();
            return TeaModel.build(map, self);
        }

    }

}
