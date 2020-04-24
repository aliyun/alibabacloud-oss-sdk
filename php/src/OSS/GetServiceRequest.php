<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetServiceRequest\filter;
use AlibabaCloud\Tea\Model;

class GetServiceRequest extends Model
{
    /**
     * @description Filter
     *
     * @var GetServiceRequest.filter
     */
    public $filter;
    protected $_name = [
        'filter' => 'Filter',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res           = [];
        $res['Filter'] = null !== $this->filter ? $this->filter->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Filter'])) {
            $model->filter = GetServiceRequest\filter::fromMap($map['Filter']);
        }

        return $model;
    }
}
