<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest\filter;
use AlibabaCloud\SDK\OSS\OSS\AppendObjectRequest\header;
use AlibabaCloud\Tea\Model;

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
     * @var array
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
     * @var AppendObjectRequest.filter
     */
    public $filter;

    /**
     * @description Header
     *
     * @var AppendObjectRequest.header
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
    }

    public function toMap()
    {
        $res               = [];
        $res['BucketName'] = $this->bucketName;
        $res['ObjectName'] = $this->objectName;
        $res['UserMeta']   = $this->userMeta;
        $res['body']       = $this->body;
        $res['Filter']     = null !== $this->filter ? $this->filter->toMap() : null;
        $res['Header']     = null !== $this->header ? $this->header->toMap() : null;

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
            $model->filter = AppendObjectRequest\filter::fromMap($map['Filter']);
        }
        if (isset($map['Header'])) {
            $model->header = AppendObjectRequest\header::fromMap($map['Header']);
        }

        return $model;
    }
}
