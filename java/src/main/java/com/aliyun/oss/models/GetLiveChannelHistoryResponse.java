// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelHistoryResponse extends TeaModel {
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    @NameInMap("LiveChannelHistory")
    @Validation(required = true)
    public GetLiveChannelHistoryResponseLiveChannelHistory liveChannelHistory;

    public static class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord extends TeaModel {
        @NameInMap("StartTime")
        public String startTime;

        @NameInMap("EndTime")
        public String endTime;

        @NameInMap("RemoteAddr")
        public String remoteAddr;

    }

    public static class GetLiveChannelHistoryResponseLiveChannelHistory extends TeaModel {
        @NameInMap("LiveRecord")
        public GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord[] liveRecord;

    }

}
