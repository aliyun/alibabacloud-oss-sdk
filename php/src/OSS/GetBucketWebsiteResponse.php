<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketWebsiteResponse\websiteConfiguration;
use AlibabaCloud\Tea\Model;

class GetBucketWebsiteResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description WebsiteConfiguration
     *
     * @var websiteConfiguration
     */
    public $websiteConfiguration;
    protected $_name = [
        'requestId'            => 'x-oss-request-id',
        'websiteConfiguration' => 'WebsiteConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('websiteConfiguration', $this->websiteConfiguration, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->websiteConfiguration) {
            $res['WebsiteConfiguration'] = null !== $this->websiteConfiguration ? $this->websiteConfiguration->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketWebsiteResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['WebsiteConfiguration'])) {
            $model->websiteConfiguration = websiteConfiguration::fromMap($map['WebsiteConfiguration']);
        }

        return $model;
    }
}
