// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

import com.aliyun.tea.*;

public class ListLiveChannelRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("Filter")
    public ListLiveChannelRequestFilter filter;

    public static class ListLiveChannelRequestFilter extends TeaModel {
        @NameInMap("marker")
        public String marker;

        @NameInMap("max-keys")
        public String maxKeys;

        @NameInMap("prefix")
        public String prefix;

    }

}
