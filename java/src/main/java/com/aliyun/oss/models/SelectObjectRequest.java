// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class SelectObjectRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // ObjectName
    @NameInMap("ObjectName")
    @Validation(required = true)
    public String objectName;

    // Filter
    @NameInMap("Filter")
    @Validation(required = true)
    public SelectObjectRequestFilter filter;

    // Body
    @NameInMap("Body")
    public SelectObjectRequestBody body;

    public static SelectObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        SelectObjectRequest self = new SelectObjectRequest();
        return TeaModel.build(map, self);
    }

    public SelectObjectRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public SelectObjectRequest setObjectName(String objectName) {
        this.objectName = objectName;
        return this;
    }
    public String getObjectName() {
        return this.objectName;
    }

    public SelectObjectRequest setFilter(SelectObjectRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public SelectObjectRequestFilter getFilter() {
        return this.filter;
    }

    public SelectObjectRequest setBody(SelectObjectRequestBody body) {
        this.body = body;
        return this;
    }
    public SelectObjectRequestBody getBody() {
        return this.body;
    }

    public static class SelectObjectRequestFilter extends TeaModel {
        // x-oss-process
        @NameInMap("x-oss-process")
        @Validation(required = true)
        public String porcess;

        public static SelectObjectRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestFilter self = new SelectObjectRequestFilter();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestFilter setPorcess(String porcess) {
            this.porcess = porcess;
            return this;
        }
        public String getPorcess() {
            return this.porcess;
        }

    }

    public static class SelectObjectRequestBodySelectRequestInputSerializationCSV extends TeaModel {
        // FileHeaderInfo
        @NameInMap("FileHeaderInfo")
        public String fileHeaderInfo;

        // RecordDelimiter
        @NameInMap("RecordDelimiter")
        public String recordDelimiter;

        // FieldDelimiter
        @NameInMap("FieldDelimiter")
        public String fieldDelimiter;

        // QuoteCharacter
        @NameInMap("QuoteCharacter")
        public String quoteCharacter;

        // CommentCharacter
        @NameInMap("CommentCharacter")
        public String commentCharacter;

        // Range
        @NameInMap("Range")
        public String range;

        public static SelectObjectRequestBodySelectRequestInputSerializationCSV build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestInputSerializationCSV self = new SelectObjectRequestBodySelectRequestInputSerializationCSV();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestBodySelectRequestInputSerializationCSV setFileHeaderInfo(String fileHeaderInfo) {
            this.fileHeaderInfo = fileHeaderInfo;
            return this;
        }
        public String getFileHeaderInfo() {
            return this.fileHeaderInfo;
        }

        public SelectObjectRequestBodySelectRequestInputSerializationCSV setRecordDelimiter(String recordDelimiter) {
            this.recordDelimiter = recordDelimiter;
            return this;
        }
        public String getRecordDelimiter() {
            return this.recordDelimiter;
        }

        public SelectObjectRequestBodySelectRequestInputSerializationCSV setFieldDelimiter(String fieldDelimiter) {
            this.fieldDelimiter = fieldDelimiter;
            return this;
        }
        public String getFieldDelimiter() {
            return this.fieldDelimiter;
        }

        public SelectObjectRequestBodySelectRequestInputSerializationCSV setQuoteCharacter(String quoteCharacter) {
            this.quoteCharacter = quoteCharacter;
            return this;
        }
        public String getQuoteCharacter() {
            return this.quoteCharacter;
        }

        public SelectObjectRequestBodySelectRequestInputSerializationCSV setCommentCharacter(String commentCharacter) {
            this.commentCharacter = commentCharacter;
            return this;
        }
        public String getCommentCharacter() {
            return this.commentCharacter;
        }

        public SelectObjectRequestBodySelectRequestInputSerializationCSV setRange(String range) {
            this.range = range;
            return this;
        }
        public String getRange() {
            return this.range;
        }

    }

    public static class SelectObjectRequestBodySelectRequestInputSerialization extends TeaModel {
        // CSV
        @NameInMap("CSV")
        public SelectObjectRequestBodySelectRequestInputSerializationCSV cSV;

        // CompressionType
        @NameInMap("CompressionType")
        public String compressionType;

        public static SelectObjectRequestBodySelectRequestInputSerialization build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestInputSerialization self = new SelectObjectRequestBodySelectRequestInputSerialization();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestBodySelectRequestInputSerialization setCSV(SelectObjectRequestBodySelectRequestInputSerializationCSV cSV) {
            this.cSV = cSV;
            return this;
        }
        public SelectObjectRequestBodySelectRequestInputSerializationCSV getCSV() {
            return this.cSV;
        }

        public SelectObjectRequestBodySelectRequestInputSerialization setCompressionType(String compressionType) {
            this.compressionType = compressionType;
            return this;
        }
        public String getCompressionType() {
            return this.compressionType;
        }

    }

    public static class SelectObjectRequestBodySelectRequestOutputSerializationCSV extends TeaModel {
        // RecordDelimiter
        @NameInMap("RecordDelimiter")
        public String recordDelimiter;

        // FieldDelimiter
        @NameInMap("FieldDelimiter")
        public String fieldDelimiter;

        public static SelectObjectRequestBodySelectRequestOutputSerializationCSV build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestOutputSerializationCSV self = new SelectObjectRequestBodySelectRequestOutputSerializationCSV();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestBodySelectRequestOutputSerializationCSV setRecordDelimiter(String recordDelimiter) {
            this.recordDelimiter = recordDelimiter;
            return this;
        }
        public String getRecordDelimiter() {
            return this.recordDelimiter;
        }

        public SelectObjectRequestBodySelectRequestOutputSerializationCSV setFieldDelimiter(String fieldDelimiter) {
            this.fieldDelimiter = fieldDelimiter;
            return this;
        }
        public String getFieldDelimiter() {
            return this.fieldDelimiter;
        }

    }

    public static class SelectObjectRequestBodySelectRequestOutputSerialization extends TeaModel {
        // CSV
        @NameInMap("CSV")
        public SelectObjectRequestBodySelectRequestOutputSerializationCSV cSV;

        // KeepAllColumns
        @NameInMap("KeepAllColumns")
        public String keepAllColumns;

        // OutputRawData
        @NameInMap("OutputRawData")
        public String outputRawData;

        // EnablePayloadCrc
        @NameInMap("EnablePayloadCrc")
        public String enablePayloadCrc;

        // OutputHeader
        @NameInMap("OutputHeader")
        public String outputHeader;

        public static SelectObjectRequestBodySelectRequestOutputSerialization build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestOutputSerialization self = new SelectObjectRequestBodySelectRequestOutputSerialization();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestBodySelectRequestOutputSerialization setCSV(SelectObjectRequestBodySelectRequestOutputSerializationCSV cSV) {
            this.cSV = cSV;
            return this;
        }
        public SelectObjectRequestBodySelectRequestOutputSerializationCSV getCSV() {
            return this.cSV;
        }

        public SelectObjectRequestBodySelectRequestOutputSerialization setKeepAllColumns(String keepAllColumns) {
            this.keepAllColumns = keepAllColumns;
            return this;
        }
        public String getKeepAllColumns() {
            return this.keepAllColumns;
        }

        public SelectObjectRequestBodySelectRequestOutputSerialization setOutputRawData(String outputRawData) {
            this.outputRawData = outputRawData;
            return this;
        }
        public String getOutputRawData() {
            return this.outputRawData;
        }

        public SelectObjectRequestBodySelectRequestOutputSerialization setEnablePayloadCrc(String enablePayloadCrc) {
            this.enablePayloadCrc = enablePayloadCrc;
            return this;
        }
        public String getEnablePayloadCrc() {
            return this.enablePayloadCrc;
        }

        public SelectObjectRequestBodySelectRequestOutputSerialization setOutputHeader(String outputHeader) {
            this.outputHeader = outputHeader;
            return this;
        }
        public String getOutputHeader() {
            return this.outputHeader;
        }

    }

    public static class SelectObjectRequestBodySelectRequestOptions extends TeaModel {
        // SkipPartialDataRecord
        @NameInMap("SkipPartialDataRecord")
        public String skipPartialDataRecord;

        // MaxSkippedRecordsAllowed
        @NameInMap("MaxSkippedRecordsAllowed")
        public String maxSkippedRecordsAllowed;

        public static SelectObjectRequestBodySelectRequestOptions build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequestOptions self = new SelectObjectRequestBodySelectRequestOptions();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestBodySelectRequestOptions setSkipPartialDataRecord(String skipPartialDataRecord) {
            this.skipPartialDataRecord = skipPartialDataRecord;
            return this;
        }
        public String getSkipPartialDataRecord() {
            return this.skipPartialDataRecord;
        }

        public SelectObjectRequestBodySelectRequestOptions setMaxSkippedRecordsAllowed(String maxSkippedRecordsAllowed) {
            this.maxSkippedRecordsAllowed = maxSkippedRecordsAllowed;
            return this;
        }
        public String getMaxSkippedRecordsAllowed() {
            return this.maxSkippedRecordsAllowed;
        }

    }

    public static class SelectObjectRequestBodySelectRequest extends TeaModel {
        // InputSerialization
        @NameInMap("InputSerialization")
        public SelectObjectRequestBodySelectRequestInputSerialization inputSerialization;

        // OutputSerialization
        @NameInMap("OutputSerialization")
        public SelectObjectRequestBodySelectRequestOutputSerialization outputSerialization;

        // Options
        @NameInMap("Options")
        public SelectObjectRequestBodySelectRequestOptions options;

        // Expression
        @NameInMap("Expression")
        public String expression;

        public static SelectObjectRequestBodySelectRequest build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBodySelectRequest self = new SelectObjectRequestBodySelectRequest();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestBodySelectRequest setInputSerialization(SelectObjectRequestBodySelectRequestInputSerialization inputSerialization) {
            this.inputSerialization = inputSerialization;
            return this;
        }
        public SelectObjectRequestBodySelectRequestInputSerialization getInputSerialization() {
            return this.inputSerialization;
        }

        public SelectObjectRequestBodySelectRequest setOutputSerialization(SelectObjectRequestBodySelectRequestOutputSerialization outputSerialization) {
            this.outputSerialization = outputSerialization;
            return this;
        }
        public SelectObjectRequestBodySelectRequestOutputSerialization getOutputSerialization() {
            return this.outputSerialization;
        }

        public SelectObjectRequestBodySelectRequest setOptions(SelectObjectRequestBodySelectRequestOptions options) {
            this.options = options;
            return this;
        }
        public SelectObjectRequestBodySelectRequestOptions getOptions() {
            return this.options;
        }

        public SelectObjectRequestBodySelectRequest setExpression(String expression) {
            this.expression = expression;
            return this;
        }
        public String getExpression() {
            return this.expression;
        }

    }

    public static class SelectObjectRequestBody extends TeaModel {
        // SelectRequest
        @NameInMap("SelectRequest")
        @Validation(required = true)
        public SelectObjectRequestBodySelectRequest selectRequest;

        public static SelectObjectRequestBody build(java.util.Map<String, ?> map) throws Exception {
            SelectObjectRequestBody self = new SelectObjectRequestBody();
            return TeaModel.build(map, self);
        }

        public SelectObjectRequestBody setSelectRequest(SelectObjectRequestBodySelectRequest selectRequest) {
            this.selectRequest = selectRequest;
            return this;
        }
        public SelectObjectRequestBodySelectRequest getSelectRequest() {
            return this.selectRequest;
        }

    }

}
