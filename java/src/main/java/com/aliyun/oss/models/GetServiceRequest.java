// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetServiceRequest extends TeaModel {
    @NameInMap("Filter")
    public GetServiceRequestFilter filter;

    public static GetServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceRequest self = new GetServiceRequest();
        return TeaModel.build(map, self);
    }

    public static class GetServiceRequestFilter extends TeaModel {
        @NameInMap("prefix")
        public String prefix;

        @NameInMap("marker")
        public String marker;

        @NameInMap("max-keys")
        public String maxKeys;

        public static GetServiceRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRequestFilter self = new GetServiceRequestFilter();
            return TeaModel.build(map, self);
        }

    }

}
