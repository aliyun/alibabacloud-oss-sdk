// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class DeleteLiveChannelRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9-_]+")
    public String bucketName;

    // ChannelName
    @NameInMap("ChannelName")
    @Validation(required = true)
    public String channelName;

    public static DeleteLiveChannelRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveChannelRequest self = new DeleteLiveChannelRequest();
        return TeaModel.build(map, self);
    }

    public DeleteLiveChannelRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public DeleteLiveChannelRequest setChannelName(String channelName) {
        this.channelName = channelName;
        return this;
    }
    public String getChannelName() {
        return this.channelName;
    }

}
