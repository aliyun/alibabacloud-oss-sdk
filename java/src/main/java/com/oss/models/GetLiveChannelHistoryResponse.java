// This file is auto-generated, don't edit it. Thanks.
package com.oss.models;

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
        @Validation(required = true)
        public String startTime;

        @NameInMap("EndTime")
        @Validation(required = true)
        public String endTime;

        @NameInMap("RemoteAddr")
        @Validation(required = true)
        public String remoteAddr;

    }

    public static class GetLiveChannelHistoryResponseLiveChannelHistory extends TeaModel {
        @NameInMap("LiveRecord")
        @Validation(required = true)
        public GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord[] liveRecord;

    }

}
