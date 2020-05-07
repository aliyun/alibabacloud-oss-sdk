<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsRequest\filter;
use AlibabaCloud\Tea\Model;

class ListMultipartUploadsRequest extends Model
{
    /**
     * @description BucketName
     *
     * @var string
     */
    public $bucketName;

    /**
     * @description Filter
     *
     * @var ListMultipartUploadsRequest.filter
     */
    public $filter;
    protected $_name = [
        'bucketName' => 'BucketName',
        'filter'     => 'Filter',
    ];

    public function validate()
    {
        Model::validateRequired('bucketName', $this->bucketName, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['BucketName'] = $this->bucketName;
        $res['Filter']     = null !== $this->filter ? $this->filter->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListMultipartUploadsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['BucketName'])) {
            $model->bucketName = $map['BucketName'];
        }
        if (isset($map['Filter'])) {
            $model->filter = filter::fromMap($map['Filter']);
        }

        return $model;
    }
}
