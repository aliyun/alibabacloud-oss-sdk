<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketTagsRequest;

use AlibabaCloud\SDK\OSS\OSS\PutBucketTagsRequest\body\tagging;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description Tagging
     *
     * @var tagging
     */
    public $tagging;
    protected $_name = [
        'tagging' => 'Tagging',
    ];

    public function validate()
    {
        Model::validateRequired('tagging', $this->tagging, true);
    }

    public function toMap()
    {
        $res            = [];
        $res['Tagging'] = null !== $this->tagging ? $this->tagging->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Tagging'])) {
            $model->tagging = tagging::fromMap($map['Tagging']);
        }

        return $model;
    }
}
