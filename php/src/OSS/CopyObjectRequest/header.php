<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\CopyObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description x-oss-copy-source
     *
     * @var string
     */
    public $copySource;

    /**
     * @description x-oss-copy-source-if-match
     *
     * @var string
     */
    public $copySourceIfMatch;

    /**
     * @description x-oss-copy-source-if-none-match
     *
     * @var string
     */
    public $copySourceIfNoneMatch;

    /**
     * @description x-oss-copy-source-if-unmodified-since
     *
     * @var string
     */
    public $copySourceIfUnmodifiedSince;

    /**
     * @description x-oss-copy-source-if-modified-since
     *
     * @var string
     */
    public $copySourceIfModifiedSince;

    /**
     * @description x-oss-metadata-directive
     *
     * @var string
     */
    public $metadataDirective;

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
     * @description x-oss-object-acl
     *
     * @var string
     */
    public $objectAcl;

    /**
     * @description x-oss-storage-class
     *
     * @var string
     */
    public $storageClass;

    /**
     * @description x-oss-tagging
     *
     * @var string
     */
    public $tagging;

    /**
     * @description x-oss-tagging-directive
     *
     * @var string
     */
    public $taggingDirective;
    protected $_name = [
        'copySource'                  => 'x-oss-copy-source',
        'copySourceIfMatch'           => 'x-oss-copy-source-if-match',
        'copySourceIfNoneMatch'       => 'x-oss-copy-source-if-none-match',
        'copySourceIfUnmodifiedSince' => 'x-oss-copy-source-if-unmodified-since',
        'copySourceIfModifiedSince'   => 'x-oss-copy-source-if-modified-since',
        'metadataDirective'           => 'x-oss-metadata-directive',
        'serverSideEncryption'        => 'x-oss-server-side-encryption',
        'serverSideEncryptionKeyId'   => 'x-oss-server-side-encryption-key-id',
        'objectAcl'                   => 'x-oss-object-acl',
        'storageClass'                => 'x-oss-storage-class',
        'tagging'                     => 'x-oss-tagging',
        'taggingDirective'            => 'x-oss-tagging-directive',
    ];

    public function validate()
    {
        Model::validateRequired('copySource', $this->copySource, true);
    }

    public function toMap()
    {
        $res                                          = [];
        $res['x-oss-copy-source']                     = $this->copySource;
        $res['x-oss-copy-source-if-match']            = $this->copySourceIfMatch;
        $res['x-oss-copy-source-if-none-match']       = $this->copySourceIfNoneMatch;
        $res['x-oss-copy-source-if-unmodified-since'] = $this->copySourceIfUnmodifiedSince;
        $res['x-oss-copy-source-if-modified-since']   = $this->copySourceIfModifiedSince;
        $res['x-oss-metadata-directive']              = $this->metadataDirective;
        $res['x-oss-server-side-encryption']          = $this->serverSideEncryption;
        $res['x-oss-server-side-encryption-key-id']   = $this->serverSideEncryptionKeyId;
        $res['x-oss-object-acl']                      = $this->objectAcl;
        $res['x-oss-storage-class']                   = $this->storageClass;
        $res['x-oss-tagging']                         = $this->tagging;
        $res['x-oss-tagging-directive']               = $this->taggingDirective;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return header
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-copy-source'])) {
            $model->copySource = $map['x-oss-copy-source'];
        }
        if (isset($map['x-oss-copy-source-if-match'])) {
            $model->copySourceIfMatch = $map['x-oss-copy-source-if-match'];
        }
        if (isset($map['x-oss-copy-source-if-none-match'])) {
            $model->copySourceIfNoneMatch = $map['x-oss-copy-source-if-none-match'];
        }
        if (isset($map['x-oss-copy-source-if-unmodified-since'])) {
            $model->copySourceIfUnmodifiedSince = $map['x-oss-copy-source-if-unmodified-since'];
        }
        if (isset($map['x-oss-copy-source-if-modified-since'])) {
            $model->copySourceIfModifiedSince = $map['x-oss-copy-source-if-modified-since'];
        }
        if (isset($map['x-oss-metadata-directive'])) {
            $model->metadataDirective = $map['x-oss-metadata-directive'];
        }
        if (isset($map['x-oss-server-side-encryption'])) {
            $model->serverSideEncryption = $map['x-oss-server-side-encryption'];
        }
        if (isset($map['x-oss-server-side-encryption-key-id'])) {
            $model->serverSideEncryptionKeyId = $map['x-oss-server-side-encryption-key-id'];
        }
        if (isset($map['x-oss-object-acl'])) {
            $model->objectAcl = $map['x-oss-object-acl'];
        }
        if (isset($map['x-oss-storage-class'])) {
            $model->storageClass = $map['x-oss-storage-class'];
        }
        if (isset($map['x-oss-tagging'])) {
            $model->tagging = $map['x-oss-tagging'];
        }
        if (isset($map['x-oss-tagging-directive'])) {
            $model->taggingDirective = $map['x-oss-tagging-directive'];
        }

        return $model;
    }
}
