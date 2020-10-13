<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetObjectResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description x-oss-object-type
     *
     * @var string
     */
    public $objectType;

    /**
     * @description x-oss-server-side-encryption
     *
     * @var string
     */
    public $serverSideEncryption;

    /**
     * @description x-oss-tagging-count
     *
     * @var string
     */
    public $taggingCount;

    /**
     * @description x-oss-restore
     *
     * @var string
     */
    public $restore;

    /**
     * @description body
     *
     * @var Stream
     */
    public $body;
    protected $_name = [
        'requestId'            => 'x-oss-request-id',
        'objectType'           => 'x-oss-object-type',
        'serverSideEncryption' => 'x-oss-server-side-encryption',
        'taggingCount'         => 'x-oss-tagging-count',
        'restore'              => 'x-oss-restore',
        'body'                 => 'body',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('objectType', $this->objectType, true);
        Model::validateRequired('serverSideEncryption', $this->serverSideEncryption, true);
        Model::validateRequired('taggingCount', $this->taggingCount, true);
        Model::validateRequired('restore', $this->restore, true);
        Model::validateRequired('body', $this->body, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->objectType) {
            $res['x-oss-object-type'] = $this->objectType;
        }
        if (null !== $this->serverSideEncryption) {
            $res['x-oss-server-side-encryption'] = $this->serverSideEncryption;
        }
        if (null !== $this->taggingCount) {
            $res['x-oss-tagging-count'] = $this->taggingCount;
        }
        if (null !== $this->restore) {
            $res['x-oss-restore'] = $this->restore;
        }
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetObjectResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['x-oss-object-type'])) {
            $model->objectType = $map['x-oss-object-type'];
        }
        if (isset($map['x-oss-server-side-encryption'])) {
            $model->serverSideEncryption = $map['x-oss-server-side-encryption'];
        }
        if (isset($map['x-oss-tagging-count'])) {
            $model->taggingCount = $map['x-oss-tagging-count'];
        }
        if (isset($map['x-oss-restore'])) {
            $model->restore = $map['x-oss-restore'];
        }
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }

        return $model;
    }
}
