<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration;

use AlibabaCloud\Tea\Model;

class indexDocument extends Model
{
    /**
     * @description Suffix
     *
     * @var string
     */
    public $suffix;
    protected $_name = [
        'suffix' => 'Suffix',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->suffix) {
            $res['Suffix'] = $this->suffix;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return indexDocument
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Suffix'])) {
            $model->suffix = $map['Suffix'];
        }

        return $model;
    }
}
