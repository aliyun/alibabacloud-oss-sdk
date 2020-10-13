// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetLiveChannelHistoryResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // LiveChannelHistory
    @NameInMap("LiveChannelHistory")
    @Validation(required = true)
    public GetLiveChannelHistoryResponseLiveChannelHistory liveChannelHistory;

    public static GetLiveChannelHistoryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLiveChannelHistoryResponse self = new GetLiveChannelHistoryResponse();
        return TeaModel.build(map, self);
    }

    public GetLiveChannelHistoryResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetLiveChannelHistoryResponse setLiveChannelHistory(GetLiveChannelHistoryResponseLiveChannelHistory liveChannelHistory) {
        this.liveChannelHistory = liveChannelHistory;
        return this;
    }
    public GetLiveChannelHistoryResponseLiveChannelHistory getLiveChannelHistory() {
        return this.liveChannelHistory;
    }

    public static class GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord extends TeaModel {
        // StartTime
        @NameInMap("StartTime")
        public String startTime;

        // EndTime
        @NameInMap("EndTime")
        public String endTime;

        // RemoteAddr
        @NameInMap("RemoteAddr")
        public String remoteAddr;

        public static GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord self = new GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

        public GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord setRemoteAddr(String remoteAddr) {
            this.remoteAddr = remoteAddr;
            return this;
        }
        public String getRemoteAddr() {
            return this.remoteAddr;
        }

    }

    public static class GetLiveChannelHistoryResponseLiveChannelHistory extends TeaModel {
        // LiveRecord
        @NameInMap("LiveRecord")
        public java.util.List<GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord> liveRecord;

        public static GetLiveChannelHistoryResponseLiveChannelHistory build(java.util.Map<String, ?> map) throws Exception {
            GetLiveChannelHistoryResponseLiveChannelHistory self = new GetLiveChannelHistoryResponseLiveChannelHistory();
            return TeaModel.build(map, self);
        }

        public GetLiveChannelHistoryResponseLiveChannelHistory setLiveRecord(java.util.List<GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord> liveRecord) {
            this.liveRecord = liveRecord;
            return this;
        }
        public java.util.List<GetLiveChannelHistoryResponseLiveChannelHistoryLiveRecord> getLiveRecord() {
            return this.liveRecord;
        }

    }

}
