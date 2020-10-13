<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration\routingRules\routingRule\condition;

use AlibabaCloud\Tea\Model;

class includeHeader extends Model
{
    /**
     * @description Key
     *
     * @var string
     */
    public $key;

    /**
     * @description Equals
     *
     * @var string
     */
    public $equals;
    protected $_name = [
        'key'    => 'Key',
        'equals' => 'Equals',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->key) {
            $res['Key'] = $this->key;
        }
        if (null !== $this->equals) {
            $res['Equals'] = $this->equals;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return includeHeader
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Key'])) {
            $model->key = $map['Key'];
        }
        if (isset($map['Equals'])) {
            $model->equals = $map['Equals'];
        }

        return $model;
    }
}
