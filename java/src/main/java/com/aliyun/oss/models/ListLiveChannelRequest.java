// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class ListLiveChannelRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Filter")
    public ListLiveChannelRequestFilter filter;

    public static ListLiveChannelRequest build(java.util.Map<String, ?> map) throws Exception {
        ListLiveChannelRequest self = new ListLiveChannelRequest();
        return TeaModel.build(map, self);
    }

    public static class ListLiveChannelRequestFilter extends TeaModel {
        @NameInMap("marker")
        public String marker;

        @NameInMap("max-keys")
        public String maxKeys;

        @NameInMap("prefix")
        public String prefix;

        public static ListLiveChannelRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            ListLiveChannelRequestFilter self = new ListLiveChannelRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
