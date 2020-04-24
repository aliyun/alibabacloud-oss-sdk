<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketTagsRequest\body\tagging;

use AlibabaCloud\Tea\Model;

class tagSet extends Model
{
    /**
     * @description Tag
     *
     * @var array
     */
    public $tag;
    protected $_name = [
        'tag' => 'Tag',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res        = [];
        $res['Tag'] = [];
        if (null !== $this->tag && \is_array($this->tag)) {
            $n = 0;
            foreach ($this->tag as $item) {
                $res['Tag'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tagSet
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Tag'])) {
            if (!empty($map['Tag'])) {
                $model->tag = [];
                $n          = 0;
                foreach ($map['Tag'] as $item) {
                    $model->tag[$n++] = null !== $item ? PutBucketTagsRequest\body\tagging\tagSet\tag::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
