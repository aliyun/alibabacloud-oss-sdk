<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest;

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
     * @description Content-MD5
     *
     * @var string
     */
    public $contentMD5;

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
     * @description content-type
     *
     * @var string
     */
    public $contentType;
    protected $_name = [
        'cacheControl'         => 'Cache-Control',
        'contentDisposition'   => 'Content-Disposition',
        'contentEncoding'      => 'Content-Encoding',
        'contentMD5'           => 'Content-MD5',
        'expires'              => 'Expires',
        'serverSideEncryption' => 'x-oss-server-side-encryption',
        'objectAcl'            => 'x-oss-object-acl',
        'storageClass'         => 'x-oss-storage-class',
        'contentType'          => 'content-type',
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
        if (null !== $this->contentMD5) {
            $res['Content-MD5'] = $this->contentMD5;
        }
        if (null !== $this->expires) {
            $res['Expires'] = $this->expires;
        }
        if (null !== $this->serverSideEncryption) {
            $res['x-oss-server-side-encryption'] = $this->serverSideEncryption;
        }
        if (null !== $this->objectAcl) {
            $res['x-oss-object-acl'] = $this->objectAcl;
        }
        if (null !== $this->storageClass) {
            $res['x-oss-storage-class'] = $this->storageClass;
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
        if (isset($map['Content-MD5'])) {
            $model->contentMD5 = $map['Content-MD5'];
        }
        if (isset($map['Expires'])) {
            $model->expires = $map['Expires'];
        }
        if (isset($map['x-oss-server-side-encryption'])) {
            $model->serverSideEncryption = $map['x-oss-server-side-encryption'];
        }
        if (isset($map['x-oss-object-acl'])) {
            $model->objectAcl = $map['x-oss-object-acl'];
        }
        if (isset($map['x-oss-storage-class'])) {
            $model->storageClass = $map['x-oss-storage-class'];
        }
        if (isset($map['content-type'])) {
            $model->contentType = $map['content-type'];
        }

        return $model;
    }
}
