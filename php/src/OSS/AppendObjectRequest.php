<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest\filter;
use AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest\header;
use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class AppendObjectRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description ObjectName
     *
     * @var string
     */
    public $objectName;

    /**
     * @description UserMeta
     *
     * @var string[]
     */
    public $userMeta;

    /**
     * @description body
     *
     * @var Stream
     */
    public $body;

    /**
     * @description Filter
     *
     * @var filter
     */
    public $filter;

    /**
     * @description Header
     *
     * @var header
     */
    public $header;
    protected $_name = [
        'bucketName' => 'BucketName',
        'objectName' => 'ObjectName',
        'userMeta'   => 'UserMeta',
        'body'       => 'body',
        'filter'     => 'Filter',
        'header'     => 'Header',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
        Model::validateRequired('objectName', $this->objectName, true);
        Model::validateRequired('filter', $this->filter, true);
        Model::validatePattern('bucketName', $this->bucketName, '[a-zA-Z0-9-_]+');
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bucketName) {
            $res['BucketName'] = $this->bucketName;
        }
        if (null !== $this->objectName) {
            $res['ObjectName'] = $this->objectName;
        }
        if (null !== $this->userMeta) {
            $res['UserMeta'] = $this->userMeta;
        }
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }
        if (null !== $this->filter) {
            $res['Filter'] = null !== $this->filter ? $this->filter->toMap() : null;
        }
        if (null !== $this->header) {
            $res['Header'] = null !== $this->header ? $this->header->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppendObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['ObjectName'])) {
            $model->objectName = $map['ObjectName'];
        }
        if (isset($map['UserMeta'])) {
            $model->userMeta = $map['UserMeta'];
        }
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }
        if (isset($map['Filter'])) {
            $model->filter = filter::fromMap($map['Filter']);
        }
        if (isset($map['Header'])) {
            $model->header = header::fromMap($map['Header']);
        }

        return $model;
    }
}
