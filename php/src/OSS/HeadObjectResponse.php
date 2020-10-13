<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class HeadObjectResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description usermeta
     *
     * @var string[]
     */
    public $userMeta;

    /**
     * @description x-oss-server-side-encryption
     *
     * @var string
     */
    public $serverSideEncryption;

    /**
     * @description x-oss-server-side-encryption-key-id
     *
     * @var string
     */
    public $serverSideEncryptionKeyId;

    /**
     * @description x-oss-storage-class
     *
     * @var string
     */
    public $storageClass;

    /**
     * @description x-oss-object-type
     *
     * @var string
     */
    public $objectType;

    /**
     * @description x-oss-next-append-position
     *
     * @var string
     */
    public $nextAppendPosition;

    /**
     * @description x-oss-hash-crc64ecma
     *
     * @var string
     */
    public $hashCrc64ecma;

    /**
     * @description x-oss-expiration
     *
     * @var string
     */
    public $expiration;

    /**
     * @description x-oss-restore
     *
     * @var string
     */
    public $restore;

    /**
     * @description x-oss-process-status
     *
     * @var string
     */
    public $processStatus;

    /**
     * @description x-oss-request-charged
     *
     * @var string
     */
    public $requestCharged;

    /**
     * @description Content-Md5
     *
     * @var string
     */
    public $contentMd5;

    /**
     * @description Last-Modified
     *
     * @var string
     */
    public $lastModified;

    /**
     * @description Access-Control-Allow-Origin
     *
     * @var string
     */
    public $accessControlAllowOrigin;

    /**
     * @description Access-Control-Allow-Methods
     *
     * @var string
     */
    public $accessControlAllowMethods;

    /**
     * @description Access-Control-Max-Age
     *
     * @var string
     */
    public $accessControlMaxAge;

    /**
     * @description Access-Control-Allow-Headers
     *
     * @var string
     */
    public $accessControlAllowHeaders;

    /**
     * @description Access-Control-Expose-Headers
     *
     * @var string
     */
    public $accessControlExposeHeaders;

    /**
     * @description x-oss-tagging-count
     *
     * @var string
     */
    public $taggingCount;
    protected $_name = [
        'requestId'                  => 'x-oss-request-id',
        'userMeta'                   => 'usermeta',
        'serverSideEncryption'       => 'x-oss-server-side-encryption',
        'serverSideEncryptionKeyId'  => 'x-oss-server-side-encryption-key-id',
        'storageClass'               => 'x-oss-storage-class',
        'objectType'                 => 'x-oss-object-type',
        'nextAppendPosition'         => 'x-oss-next-append-position',
        'hashCrc64ecma'              => 'x-oss-hash-crc64ecma',
        'expiration'                 => 'x-oss-expiration',
        'restore'                    => 'x-oss-restore',
        'processStatus'              => 'x-oss-process-status',
        'requestCharged'             => 'x-oss-request-charged',
        'contentMd5'                 => 'content-md5',
        'lastModified'               => 'last-modified',
        'accessControlAllowOrigin'   => 'access-control-allow-origin',
        'accessControlAllowMethods'  => 'access-control-allow-methods',
        'accessControlMaxAge'        => 'access-control-max-age',
        'accessControlAllowHeaders'  => 'access-control-allow-headers',
        'accessControlExposeHeaders' => 'access-control-expose-headers',
        'taggingCount'               => 'x-oss-tagging-count',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('userMeta', $this->userMeta, true);
        Model::validateRequired('serverSideEncryption', $this->serverSideEncryption, true);
        Model::validateRequired('serverSideEncryptionKeyId', $this->serverSideEncryptionKeyId, true);
        Model::validateRequired('storageClass', $this->storageClass, true);
        Model::validateRequired('objectType', $this->objectType, true);
        Model::validateRequired('nextAppendPosition', $this->nextAppendPosition, true);
        Model::validateRequired('hashCrc64ecma', $this->hashCrc64ecma, true);
        Model::validateRequired('expiration', $this->expiration, true);
        Model::validateRequired('restore', $this->restore, true);
        Model::validateRequired('processStatus', $this->processStatus, true);
        Model::validateRequired('requestCharged', $this->requestCharged, true);
        Model::validateRequired('contentMd5', $this->contentMd5, true);
        Model::validateRequired('lastModified', $this->lastModified, true);
        Model::validateRequired('accessControlAllowOrigin', $this->accessControlAllowOrigin, true);
        Model::validateRequired('accessControlAllowMethods', $this->accessControlAllowMethods, true);
        Model::validateRequired('accessControlMaxAge', $this->accessControlMaxAge, true);
        Model::validateRequired('accessControlAllowHeaders', $this->accessControlAllowHeaders, true);
        Model::validateRequired('accessControlExposeHeaders', $this->accessControlExposeHeaders, true);
        Model::validateRequired('taggingCount', $this->taggingCount, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->userMeta) {
            $res['usermeta'] = $this->userMeta;
        }
        if (null !== $this->serverSideEncryption) {
            $res['x-oss-server-side-encryption'] = $this->serverSideEncryption;
        }
        if (null !== $this->serverSideEncryptionKeyId) {
            $res['x-oss-server-side-encryption-key-id'] = $this->serverSideEncryptionKeyId;
        }
        if (null !== $this->storageClass) {
            $res['x-oss-storage-class'] = $this->storageClass;
        }
        if (null !== $this->objectType) {
            $res['x-oss-object-type'] = $this->objectType;
        }
        if (null !== $this->nextAppendPosition) {
            $res['x-oss-next-append-position'] = $this->nextAppendPosition;
        }
        if (null !== $this->hashCrc64ecma) {
            $res['x-oss-hash-crc64ecma'] = $this->hashCrc64ecma;
        }
        if (null !== $this->expiration) {
            $res['x-oss-expiration'] = $this->expiration;
        }
        if (null !== $this->restore) {
            $res['x-oss-restore'] = $this->restore;
        }
        if (null !== $this->processStatus) {
            $res['x-oss-process-status'] = $this->processStatus;
        }
        if (null !== $this->requestCharged) {
            $res['x-oss-request-charged'] = $this->requestCharged;
        }
        if (null !== $this->contentMd5) {
            $res['content-md5'] = $this->contentMd5;
        }
        if (null !== $this->lastModified) {
            $res['last-modified'] = $this->lastModified;
        }
        if (null !== $this->accessControlAllowOrigin) {
            $res['access-control-allow-origin'] = $this->accessControlAllowOrigin;
        }
        if (null !== $this->accessControlAllowMethods) {
            $res['access-control-allow-methods'] = $this->accessControlAllowMethods;
        }
        if (null !== $this->accessControlMaxAge) {
            $res['access-control-max-age'] = $this->accessControlMaxAge;
        }
        if (null !== $this->accessControlAllowHeaders) {
            $res['access-control-allow-headers'] = $this->accessControlAllowHeaders;
        }
        if (null !== $this->accessControlExposeHeaders) {
            $res['access-control-expose-headers'] = $this->accessControlExposeHeaders;
        }
        if (null !== $this->taggingCount) {
            $res['x-oss-tagging-count'] = $this->taggingCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HeadObjectResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['usermeta'])) {
            $model->userMeta = $map['usermeta'];
        }
        if (isset($map['x-oss-server-side-encryption'])) {
            $model->serverSideEncryption = $map['x-oss-server-side-encryption'];
        }
        if (isset($map['x-oss-server-side-encryption-key-id'])) {
            $model->serverSideEncryptionKeyId = $map['x-oss-server-side-encryption-key-id'];
        }
        if (isset($map['x-oss-storage-class'])) {
            $model->storageClass = $map['x-oss-storage-class'];
        }
        if (isset($map['x-oss-object-type'])) {
            $model->objectType = $map['x-oss-object-type'];
        }
        if (isset($map['x-oss-next-append-position'])) {
            $model->nextAppendPosition = $map['x-oss-next-append-position'];
        }
        if (isset($map['x-oss-hash-crc64ecma'])) {
            $model->hashCrc64ecma = $map['x-oss-hash-crc64ecma'];
        }
        if (isset($map['x-oss-expiration'])) {
            $model->expiration = $map['x-oss-expiration'];
        }
        if (isset($map['x-oss-restore'])) {
            $model->restore = $map['x-oss-restore'];
        }
        if (isset($map['x-oss-process-status'])) {
            $model->processStatus = $map['x-oss-process-status'];
        }
        if (isset($map['x-oss-request-charged'])) {
            $model->requestCharged = $map['x-oss-request-charged'];
        }
        if (isset($map['content-md5'])) {
            $model->contentMd5 = $map['content-md5'];
        }
        if (isset($map['last-modified'])) {
            $model->lastModified = $map['last-modified'];
        }
        if (isset($map['access-control-allow-origin'])) {
            $model->accessControlAllowOrigin = $map['access-control-allow-origin'];
        }
        if (isset($map['access-control-allow-methods'])) {
            $model->accessControlAllowMethods = $map['access-control-allow-methods'];
        }
        if (isset($map['access-control-max-age'])) {
            $model->accessControlMaxAge = $map['access-control-max-age'];
        }
        if (isset($map['access-control-allow-headers'])) {
            $model->accessControlAllowHeaders = $map['access-control-allow-headers'];
        }
        if (isset($map['access-control-expose-headers'])) {
            $model->accessControlExposeHeaders = $map['access-control-expose-headers'];
        }
        if (isset($map['x-oss-tagging-count'])) {
            $model->taggingCount = $map['x-oss-tagging-count'];
        }

        return $model;
    }
}
