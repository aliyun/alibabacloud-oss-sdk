<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest;

use AlibabaCloud\SDK\OSS\OSS\PutBucketWebsiteRequest\body\websiteConfiguration;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description WebsiteConfiguration
     *
     * @var websiteConfiguration
     */
    public $websiteConfiguration;
    protected $_name = [
        'websiteConfiguration' => 'WebsiteConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('websiteConfiguration', $this->websiteConfiguration, true);
    }

    public function toMap()
    {
        $res                         = [];
        $res['WebsiteConfiguration'] = null !== $this->websiteConfiguration ? $this->websiteConfiguration->toMap() : null;

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
        if (isset($map['WebsiteConfiguration'])) {
            $model->websiteConfiguration = websiteConfiguration::fromMap($map['WebsiteConfiguration']);
        }

        return $model;
    }
}
