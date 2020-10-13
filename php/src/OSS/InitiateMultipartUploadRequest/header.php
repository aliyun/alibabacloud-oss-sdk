<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\InitiateMultipartUploadRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description Cache-Control
     *
     * @var string
     */
    public $cacheControl;

    /**
     * @description Content-Disposition
     *
     * @var string
     */
    public $contentDisposition;

    /**
     * @description Content-Encoding
     *
     * @var string
     */
    public $contentEncoding;

    /**
     * @description Expires
     *
     * @var string
     */
    public $expires;

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
     * @description x-oss-tagging
     *
     * @var string
     */
    public $tagging;

    /**
     * @description content-type
     *
     * @var string
     */
    public $contentType;
    protected $_name = [
        'cacheControl'              => 'Cache-Control',
        'contentDisposition'        => 'Content-Disposition',
        'contentEncoding'           => 'Content-Encoding',
        'expires'                   => 'Expires',
        'serverSideEncryption'      => 'x-oss-server-side-encryption',
        'serverSideEncryptionKeyId' => 'x-oss-server-side-encryption-key-id',
        'storageClass'              => 'x-oss-storage-class',
        'tagging'                   => 'x-oss-tagging',
        'contentType'               => 'content-type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cacheControl) {
            $res['Cache-Control'] = $this->cacheControl;
        }
        if (null !== $this->contentDisposition) {
            $res['Content-Disposition'] = $this->contentDisposition;
        }
        if (null !== $this->contentEncoding) {
            $res['Content-Encoding'] = $this->contentEncoding;
        }
        if (null !== $this->expires) {
            $res['Expires'] = $this->expires;
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
        if (null !== $this->tagging) {
            $res['x-oss-tagging'] = $this->tagging;
        }
        if (null !== $this->contentType) {
            $res['content-type'] = $this->contentType;
        }

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
        if (isset($map['Cache-Control'])) {
            $model->cacheControl = $map['Cache-Control'];
        }
        if (isset($map['Content-Disposition'])) {
            $model->contentDisposition = $map['Content-Disposition'];
        }
        if (isset($map['Content-Encoding'])) {
            $model->contentEncoding = $map['Content-Encoding'];
        }
        if (isset($map['Expires'])) {
            $model->expires = $map['Expires'];
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
        if (isset($map['x-oss-tagging'])) {
            $model->tagging = $map['x-oss-tagging'];
        }
        if (isset($map['content-type'])) {
            $model->contentType = $map['content-type'];
        }

        return $model;
    }
}
