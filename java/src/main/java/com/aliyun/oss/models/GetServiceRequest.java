// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetServiceRequest extends TeaModel {
    // Filter
    @NameInMap("Filter")
    public GetServiceRequestFilter filter;

    public static GetServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceRequest self = new GetServiceRequest();
        return TeaModel.build(map, self);
    }

    public GetServiceRequest setFilter(GetServiceRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public GetServiceRequestFilter getFilter() {
        return this.filter;
    }

    public static class GetServiceRequestFilter extends TeaModel {
        // prefix
        @NameInMap("prefix")
        public String prefix;

        // marker
        @NameInMap("marker")
        public String marker;

        // max-keys
        @NameInMap("max-keys")
        public String maxKeys;

        public static GetServiceRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            GetServiceRequestFilter self = new GetServiceRequestFilter();
            return TeaModel.build(map, self);
        }

        public GetServiceRequestFilter setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public GetServiceRequestFilter setMarker(String marker) {
            this.marker = marker;
            return this;
        }
        public String getMarker() {
            return this.marker;
        }

        public GetServiceRequestFilter setMaxKeys(String maxKeys) {
            this.maxKeys = maxKeys;
            return this;
        }
        public String getMaxKeys() {
            return this.maxKeys;
        }

    }

}
