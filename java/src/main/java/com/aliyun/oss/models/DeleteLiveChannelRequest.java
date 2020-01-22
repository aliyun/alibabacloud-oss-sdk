// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteLiveChannelRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    public static DeleteLiveChannelRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveChannelRequest self = new DeleteLiveChannelRequest();
        return TeaModel.build(map, self);
    }

}
