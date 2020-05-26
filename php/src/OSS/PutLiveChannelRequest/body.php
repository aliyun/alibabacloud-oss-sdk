<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest;

use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body\liveChannelConfiguration;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description LiveChannelConfiguration
     *
     * @var liveChannelConfiguration
     */
    public $liveChannelConfiguration;
    protected $_name = [
        'liveChannelConfiguration' => 'LiveChannelConfiguration',
    ];

    public function validate()
    {
        Model::validateRequired('liveChannelConfiguration', $this->liveChannelConfiguration, true);
    }

    public function toMap()
    {
        $res                             = [];
        $res['LiveChannelConfiguration'] = null !== $this->liveChannelConfiguration ? $this->liveChannelConfiguration->toMap() : null;

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
        if (isset($map['LiveChannelConfiguration'])) {
            $model->liveChannelConfiguration = liveChannelConfiguration::fromMap($map['LiveChannelConfiguration']);
        }

        return $model;
    }
}
