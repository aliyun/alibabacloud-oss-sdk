// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetServiceRequest extends TeaModel {
    @NameInMap("Filter")
    public GetServiceRequestFilter filter;

    public static class GetServiceRequestFilter extends TeaModel {
        @NameInMap("prefix")
        public String prefix;

        @NameInMap("marker")
        public String marker;

        @NameInMap("max-keys")
        public String maxKeys;

    }

}
