// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.oss.models;

import com.aliyun.tea.*;

public class PutBucketLifecycleRequest extends TeaModel {
    // BucketName
    @NameInMap("BucketName")
    @Validation(required = true, pattern = "[a-zA-Z0-9\\-\\_]+")
    public String bucketName;

    // Body
    @NameInMap("Body")
    public PutBucketLifecycleRequestBody body;

    public static PutBucketLifecycleRequest build(java.util.Map<String, ?> map) throws Exception {
        PutBucketLifecycleRequest self = new PutBucketLifecycleRequest();
        return TeaModel.build(map, self);
    }

    public PutBucketLifecycleRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public PutBucketLifecycleRequest setBody(PutBucketLifecycleRequestBody body) {
        this.body = body;
        return this;
    }
    public PutBucketLifecycleRequestBody getBody() {
        return this.body;
    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration extends TeaModel {
        // Days
        @NameInMap("Days")
        public Integer days;

        // CreatedBeforeDate
        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration();
            return TeaModel.build(map, self);
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration setDays(Integer days) {
            this.days = days;
            return this;
        }
        public Integer getDays() {
            return this.days;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration setCreatedBeforeDate(String createdBeforeDate) {
            this.createdBeforeDate = createdBeforeDate;
            return this;
        }
        public String getCreatedBeforeDate() {
            return this.createdBeforeDate;
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition extends TeaModel {
        // Days
        @NameInMap("Days")
        public Integer days;

        // StorageClass
        @NameInMap("StorageClass")
        public String storageClass;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition();
            return TeaModel.build(map, self);
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition setDays(Integer days) {
            this.days = days;
            return this;
        }
        public Integer getDays() {
            return this.days;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition setStorageClass(String storageClass) {
            this.storageClass = storageClass;
            return this;
        }
        public String getStorageClass() {
            return this.storageClass;
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload extends TeaModel {
        // Days
        @NameInMap("Days")
        public Integer days;

        // CreatedBeforeDate
        @NameInMap("CreatedBeforeDate")
        public String createdBeforeDate;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload();
            return TeaModel.build(map, self);
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload setDays(Integer days) {
            this.days = days;
            return this;
        }
        public Integer getDays() {
            return this.days;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload setCreatedBeforeDate(String createdBeforeDate) {
            this.createdBeforeDate = createdBeforeDate;
            return this;
        }
        public String getCreatedBeforeDate() {
            return this.createdBeforeDate;
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag extends TeaModel {
        // Key
        @NameInMap("Key")
        public String key;

        // Value
        @NameInMap("Value")
        public String value;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag();
            return TeaModel.build(map, self);
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfigurationRule extends TeaModel {
        // Expiration
        @NameInMap("Expiration")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration expiration;

        // Transition
        @NameInMap("Transition")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition transition;

        // AbortMultipartUpload
        @NameInMap("AbortMultipartUpload")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload abortMultipartUpload;

        // Tag
        @NameInMap("Tag")
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag tag;

        // ID
        @NameInMap("ID")
        public String iD;

        // Prefix
        @NameInMap("Prefix")
        public String prefix;

        // Status
        @NameInMap("Status")
        public String status;

        public static PutBucketLifecycleRequestBodyLifecycleConfigurationRule build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfigurationRule self = new PutBucketLifecycleRequestBodyLifecycleConfigurationRule();
            return TeaModel.build(map, self);
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule setExpiration(PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration expiration) {
            this.expiration = expiration;
            return this;
        }
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleExpiration getExpiration() {
            return this.expiration;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule setTransition(PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition transition) {
            this.transition = transition;
            return this;
        }
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTransition getTransition() {
            return this.transition;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule setAbortMultipartUpload(PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload abortMultipartUpload) {
            this.abortMultipartUpload = abortMultipartUpload;
            return this;
        }
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleAbortMultipartUpload getAbortMultipartUpload() {
            return this.abortMultipartUpload;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule setTag(PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag tag) {
            this.tag = tag;
            return this;
        }
        public PutBucketLifecycleRequestBodyLifecycleConfigurationRuleTag getTag() {
            return this.tag;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule setID(String iD) {
            this.iD = iD;
            return this;
        }
        public String getID() {
            return this.iD;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule setPrefix(String prefix) {
            this.prefix = prefix;
            return this;
        }
        public String getPrefix() {
            return this.prefix;
        }

        public PutBucketLifecycleRequestBodyLifecycleConfigurationRule setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class PutBucketLifecycleRequestBodyLifecycleConfiguration extends TeaModel {
        // Rule
        @NameInMap("Rule")
        public java.util.List<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> rule;

        public static PutBucketLifecycleRequestBodyLifecycleConfiguration build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBodyLifecycleConfiguration self = new PutBucketLifecycleRequestBodyLifecycleConfiguration();
            return TeaModel.build(map, self);
        }

        public PutBucketLifecycleRequestBodyLifecycleConfiguration setRule(java.util.List<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<PutBucketLifecycleRequestBodyLifecycleConfigurationRule> getRule() {
            return this.rule;
        }

    }

    public static class PutBucketLifecycleRequestBody extends TeaModel {
        // LifecycleConfiguration
        @NameInMap("LifecycleConfiguration")
        @Validation(required = true)
        public PutBucketLifecycleRequestBodyLifecycleConfiguration lifecycleConfiguration;

        public static PutBucketLifecycleRequestBody build(java.util.Map<String, ?> map) throws Exception {
            PutBucketLifecycleRequestBody self = new PutBucketLifecycleRequestBody();
            return TeaModel.build(map, self);
        }

        public PutBucketLifecycleRequestBody setLifecycleConfiguration(PutBucketLifecycleRequestBodyLifecycleConfiguration lifecycleConfiguration) {
            this.lifecycleConfiguration = lifecycleConfiguration;
            return this;
        }
        public PutBucketLifecycleRequestBodyLifecycleConfiguration getLifecycleConfiguration() {
            return this.lifecycleConfiguration;
        }

    }

}
