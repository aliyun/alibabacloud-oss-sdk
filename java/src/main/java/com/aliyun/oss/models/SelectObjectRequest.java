// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class SelectObjectRequest extends TeaModel {
    @NameInMap("BucketName")
    @Validation(required = true)
    public String bucketName;

    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    @NameInMap("Filter")
    @Validation(required = true)
    public SelectObjectRequestFilter filter;

    @NameInMap("Body")
    public SelectObjectRequestBody body;

    public static SelectObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        SelectObjectRequest self = new SelectObjectRequest();
        return TeaModel.build(map, self);
    }

    public static class SelectObjectRequestFilter extends TeaModel {
        @NameInMap("x-oss-process")
        @Validation(required = true)
        public String porcess;

        public static SelectObjectRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestFilter self = new SelectObjectRequestFilter();
            return TeaModel.build(map, self);
        }

    }

    public static class SelectObjectRequestBodySelectRequestInputSerializationCSV extends TeaModel {
        @NameInMap("FileHeaderInfo")
        public String fileHeaderInfo;

        @NameInMap("RecordDelimiter")
        public String recordDelimiter;

        @NameInMap("FieldDelimiter")
        public String fieldDelimiter;

        @NameInMap("QuoteCharacter")
        public String quoteCharacter;

        @NameInMap("CommentCharacter")
        public String commentCharacter;

        @NameInMap("Range")
        public String range;

        public static SelectObjectRequestBodySelectRequestInputSerializationCSV build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestInputSerializationCSV self = new SelectObjectRequestBodySelectRequestInputSerializationCSV();
            return TeaModel.build(map, self);
        }

    }

    public static class SelectObjectRequestBodySelectRequestInputSerialization extends TeaModel {
        @NameInMap("CSV")
        public SelectObjectRequestBodySelectRequestInputSerializationCSV cSV;

        @NameInMap("CompressionType")
        public String compressionType;

        public static SelectObjectRequestBodySelectRequestInputSerialization build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestInputSerialization self = new SelectObjectRequestBodySelectRequestInputSerialization();
            return TeaModel.build(map, self);
        }

    }

    public static class SelectObjectRequestBodySelectRequestOutputSerializationCSV extends TeaModel {
        @NameInMap("RecordDelimiter")
        public String recordDelimiter;

        @NameInMap("FieldDelimiter")
        public String fieldDelimiter;

        public static SelectObjectRequestBodySelectRequestOutputSerializationCSV build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestOutputSerializationCSV self = new SelectObjectRequestBodySelectRequestOutputSerializationCSV();
            return TeaModel.build(map, self);
        }

    }

    public static class SelectObjectRequestBodySelectRequestOutputSerialization extends TeaModel {
        @NameInMap("CSV")
        public SelectObjectRequestBodySelectRequestOutputSerializationCSV cSV;

        @NameInMap("KeepAllColumns")
        public String keepAllColumns;

        @NameInMap("OutputRawData")
        public String outputRawData;

        @NameInMap("EnablePayloadCrc")
        public String enablePayloadCrc;

        @NameInMap("OutputHeader")
        public String outputHeader;

        public static SelectObjectRequestBodySelectRequestOutputSerialization build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestOutputSerialization self = new SelectObjectRequestBodySelectRequestOutputSerialization();
            return TeaModel.build(map, self);
        }

    }

    public static class SelectObjectRequestBodySelectRequestOptions extends TeaModel {
        @NameInMap("SkipPartialDataRecord")
        public String skipPartialDataRecord;

        @NameInMap("MaxSkippedRecordsAllowed")
        public String maxSkippedRecordsAllowed;

        public static SelectObjectRequestBodySelectRequestOptions build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestOptions self = new SelectObjectRequestBodySelectRequestOptions();
            return TeaModel.build(map, self);
        }

    }

    public static class SelectObjectRequestBodySelectRequest extends TeaModel {
        @NameInMap("InputSerialization")
        public SelectObjectRequestBodySelectRequestInputSerialization inputSerialization;

        @NameInMap("OutputSerialization")
        public SelectObjectRequestBodySelectRequestOutputSerialization outputSerialization;

        @NameInMap("Options")
        public SelectObjectRequestBodySelectRequestOptions options;

        @NameInMap("Expression")
        public String expression;

        public static SelectObjectRequestBodySelectRequest build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequest self = new SelectObjectRequestBodySelectRequest();
            return TeaModel.build(map, self);
        }

    }

    public static class SelectObjectRequestBody extends TeaModel {
        @NameInMap("SelectRequest")
        @Validation(required = true)
        public SelectObjectRequestBodySelectRequest selectRequest;

        public static SelectObjectRequestBody build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBody self = new SelectObjectRequestBody();
            return TeaModel.build(map, self);
        }

    }

}
