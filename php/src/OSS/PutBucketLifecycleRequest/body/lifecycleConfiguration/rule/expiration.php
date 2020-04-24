<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration\rule;

use AlibabaCloud\Tea\Model;

class expiration extends Model
{
    /**
     * @description Days
     *
     * @var int
     */
    public $days;

    /**
     * @description CreatedBeforeDate
     *
     * @var string
     */
    public $createdBeforeDate;
    protected $_name = [
        'days'              => 'Days',
        'createdBeforeDate' => 'CreatedBeforeDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                      = [];
        $res['Days']              = $this->days;
        $res['CreatedBeforeDate'] = $this->createdBeforeDate;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return expiration
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Days'])) {
            $model->days = $map['Days'];
        }
        if (isset($map['CreatedBeforeDate'])) {
            $model->createdBeforeDate = $map['CreatedBeforeDate'];
        }

        return $model;
    }
}
