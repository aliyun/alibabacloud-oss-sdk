<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\filter;
use AlibabaCloud\Tea\Model;

class SelectObjectRequest extends Model
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
     * @description Filter
     *
     * @var filter
     */
    public $filter;

    /**
     * @description Body
     *
     * @var body
     */
    public $body;
    protected $_name = [
        'bucketName' => 'BucketName',
        'objectName' => 'ObjectName',
        'filter'     => 'Filter',
        'body'       => 'Body',
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
        $res['Filter']     = null !== $this->filter ? $this->filter->toMap() : null;
        $res['Body']       = null !== $this->body ? $this->body->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SelectObjectRequest
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
        if (isset($map['Filter'])) {
            $model->filter = filter::fromMap($map['Filter']);
        }
        if (isset($map['Body'])) {
            $model->body = body::fromMap($map['Body']);
        }

        return $model;
    }
}
