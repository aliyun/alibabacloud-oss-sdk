<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetObjectMetaResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description ETag
     *
     * @var string
     */
    public $eTag;

    /**
     * @description Content-Length
     *
     * @var string
     */
    public $contentLength;

    /**
     * @description Last-Modified
     *
     * @var string
     */
    public $lastModified;
    protected $_name = [
        'requestId'     => 'x-oss-request-id',
        'eTag'          => 'etag',
        'contentLength' => 'content-length',
        'lastModified'  => 'last-modified',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('eTag', $this->eTag, true);
        Model::validateRequired('contentLength', $this->contentLength, true);
        Model::validateRequired('lastModified', $this->lastModified, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->eTag) {
            $res['etag'] = $this->eTag;
        }
        if (null !== $this->contentLength) {
            $res['content-length'] = $this->contentLength;
        }
        if (null !== $this->lastModified) {
            $res['last-modified'] = $this->lastModified;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetObjectMetaResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['etag'])) {
            $model->eTag = $map['etag'];
        }
        if (isset($map['content-length'])) {
            $model->contentLength = $map['content-length'];
        }
        if (isset($map['last-modified'])) {
            $model->lastModified = $map['last-modified'];
        }

        return $model;
    }
}
