<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketCORSRequest;

use AlibabaCloud\SDK\OSS\OSS\body\cORSConfiguration;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description CORSConfiguration
     *
     * @var body.cORSConfiguration
     */
    public $cORSConfiguration;
    protected $_name = [
        'cORSConfiguration' => 'CORSConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('cORSConfiguration', $this->cORSConfiguration, true);
    }

    public function toMap()
    {
        $res                      = [];
        $res['CORSConfiguration'] = null !== $this->cORSConfiguration ? $this->cORSConfiguration->toMap() : null;

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
        if (isset($map['CORSConfiguration'])) {
            $model->cORSConfiguration = body\cORSConfiguration::fromMap($map['CORSConfiguration']);
        }

        return $model;
    }
}
