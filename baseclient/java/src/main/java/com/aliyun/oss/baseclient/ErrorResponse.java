package com.aliyun.oss.baseclient;

import com.aliyun.tea.NameInMap;
import com.aliyun.tea.TeaModel;

public class ErrorResponse extends TeaModel {

    @NameInMap("Error")
    public Error error;

    public class Error extends TeaModel{
        @NameInMap("Code")
        public String code;
        @NameInMap("Message")
        public String message;
        @NameInMap("RequestId")
        public String requestId;
        @NameInMap("HostId")
        public String hostId;
    }
}
