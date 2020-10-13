<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\DeleteBucketTagsRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description tagging
     *
     * @var string
     */
    public $tagging;
    protected $_name = [
        'tagging' => 'tagging',
    ];

    public function validate()
    {
        Model::validateRequired('tagging', $this->tagging, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagging) {
            $res['tagging'] = $this->tagging;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tagging'])) {
            $model->tagging = $map['tagging'];
        }

        return $model;
    }
}
