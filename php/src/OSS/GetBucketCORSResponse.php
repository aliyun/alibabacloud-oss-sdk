<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketCORSResponse\cORSConfiguration;
use AlibabaCloud\Tea\Model;

class GetBucketCORSResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description CORSConfiguration
     *
     * @var cORSConfiguration
     */
    public $cORSConfiguration;
    protected $_name = [
        'requestId'         => 'x-oss-request-id',
        'cORSConfiguration' => 'CORSConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('cORSConfiguration', $this->cORSConfiguration, true);
    }

    public function toMap()
    {
        $res                      = [];
        $res['x-oss-request-id']  = $this->requestId;
        $res['CORSConfiguration'] = null !== $this->cORSConfiguration ? $this->cORSConfiguration->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketCORSResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['CORSConfiguration'])) {
            $model->cORSConfiguration = cORSConfiguration::fromMap($map['CORSConfiguration']);
        }

        return $model;
    }
}
