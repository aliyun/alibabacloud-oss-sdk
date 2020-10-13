// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class GetBucketLifecycleResponse extends TeaModel {
    // x-oss-request-id
    @NameInMap("x-oss-request-id")
    @Validation(required = true)
    public String requestId;

    // LifecycleConfiguration
    @NameInMap("LifecycleConfiguration")
    @Validation(required = true)
    public GetBucketLifecycleResponseLifecycleConfiguration lifecycleConfiguration;

    public static GetBucketLifecycleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetBucketLifecycleResponse self = new GetBucketLifecycleResponse();
        return TeaModel.build(map, self);
    }

    public GetBucketLifecycleResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetBucketLifecycleResponse setLifecycleConfiguration(GetBucketLifecycleResponseLifecycleConfiguration lifecycleConfiguration) {
        this.lifecycleConfiguration = lifecycleConfiguration;
        return this;
    }
    public GetBucketLifecycleResponseLifecycleConfiguration getLifecycleConfiguration() {
        return this.lifecycleConfiguration;
    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration extends TeaModel {
        // Days
        @NameInMap("Days")
        public Integer days;

        // CreatedBeforeDate
        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration self = new GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration();
            return TeaModel.build(map, self);
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration setDays(Integer days) {
            this.days = days;
            return this;
        }
        public Integer getDays() {
            return this.days;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration setCreatedBeforeDate(String createdBeforeDate) {
            this.createdBeforeDate = createdBeforeDate;
            return this;
        }
        public String getCreatedBeforeDate() {
            return this.createdBeforeDate;
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleTransition extends TeaModel {
        // Days
        @NameInMap("Days")
        public Integer days;

        // StorageClass
        @NameInMap("StorageClass")
        public String storageClass;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleTransition build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleTransition self = new GetBucketLifecycleResponseLifecycleConfigurationRuleTransition();
            return TeaModel.build(map, self);
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleTransition setDays(Integer days) {
            this.days = days;
            return this;
        }
        public Integer getDays() {
            return this.days;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleTransition setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload extends TeaModel {
        // Days
        @NameInMap("Days")
        public Integer days;

        // CreatedBeforeDate
        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload self = new GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload();
            return TeaModel.build(map, self);
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload setDays(Integer days) {
            this.days = days;
            return this;
        }
        public Integer getDays() {
            return this.days;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload setCreatedBeforeDate(String createdBeforeDate) {
            this.createdBeforeDate = createdBeforeDate;
            return this;
        }
        public String getCreatedBeforeDate() {
            return this.createdBeforeDate;
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRuleTag extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static GetBucketLifecycleResponseLifecycleConfigurationRuleTag build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRuleTag self = new GetBucketLifecycleResponseLifecycleConfigurationRuleTag();
            return TeaModel.build(map, self);
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleTag setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRuleTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfigurationRule extends TeaModel {
        // ID
        @NameInMap("ID")
        public String iD;

        // Prefix
        @NameInMap("Prefix")
        public String prefix;

        // Status
        @NameInMap("Status")
        public String status;

        // Expiration
        @NameInMap("Expiration")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration expiration;

        // Transition
        @NameInMap("Transition")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleTransition transition;

        // AbortMultipartUpload
        @NameInMap("AbortMultipartUpload")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload abortMultipartUpload;

        // Tag
        @NameInMap("Tag")
        @Validation(required = true)
        public GetBucketLifecycleResponseLifecycleConfigurationRuleTag tag;

        public static GetBucketLifecycleResponseLifecycleConfigurationRule build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfigurationRule self = new GetBucketLifecycleResponseLifecycleConfigurationRule();
            return TeaModel.build(map, self);
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRule setID(String iD) {
            this.iD = iD;
            return this;
        }
        public String getID() {
            return this.iD;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRule setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRule setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRule setExpiration(GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration expiration) {
            this.expiration = expiration;
            return this;
        }
        public GetBucketLifecycleResponseLifecycleConfigurationRuleExpiration getExpiration() {
            return this.expiration;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRule setTransition(GetBucketLifecycleResponseLifecycleConfigurationRuleTransition transition) {
            this.transition = transition;
            return this;
        }
        public GetBucketLifecycleResponseLifecycleConfigurationRuleTransition getTransition() {
            return this.transition;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRule setAbortMultipartUpload(GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload abortMultipartUpload) {
            this.abortMultipartUpload = abortMultipartUpload;
            return this;
        }
        public GetBucketLifecycleResponseLifecycleConfigurationRuleAbortMultipartUpload getAbortMultipartUpload() {
            return this.abortMultipartUpload;
        }

        public GetBucketLifecycleResponseLifecycleConfigurationRule setTag(GetBucketLifecycleResponseLifecycleConfigurationRuleTag tag) {
            this.tag = tag;
            return this;
        }
        public GetBucketLifecycleResponseLifecycleConfigurationRuleTag getTag() {
            return this.tag;
        }

    }

    public static class GetBucketLifecycleResponseLifecycleConfiguration extends TeaModel {
        // Rule
        @NameInMap("Rule")
        public java.util.List<GetBucketLifecycleResponseLifecycleConfigurationRule> rule;

        public static GetBucketLifecycleResponseLifecycleConfiguration build(java.util.Map<String, ?> map) throws Exception {
            GetBucketLifecycleResponseLifecycleConfiguration self = new GetBucketLifecycleResponseLifecycleConfiguration();
            return TeaModel.build(map, self);
        }

        public GetBucketLifecycleResponseLifecycleConfiguration setRule(java.util.List<GetBucketLifecycleResponseLifecycleConfigurationRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<GetBucketLifecycleResponseLifecycleConfigurationRule> getRule() {
            return this.rule;
        }

    }

}
