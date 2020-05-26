<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelResponse;

use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelResponse\createLiveChannelResult\playUrls;
use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelResponse\createLiveChannelResult\publishUrls;
use AlibabaCloud\Tea\Model;

class createLiveChannelResult extends Model
{
    /**
     * @description PublishUrls
     *
     * @var publishUrls
     */
    public $publishUrls;

    /**
     * @description PlayUrls
     *
     * @var playUrls
     */
    public $playUrls;
    protected $_name = [
        'publishUrls' => 'PublishUrls',
        'playUrls'    => 'PlayUrls',
    ];

    public function validate()
    {
        Model::validateRequired('publishUrls', $this->publishUrls, true);
        Model::validateRequired('playUrls', $this->playUrls, true);
    }

    public function toMap()
    {
        $res                = [];
        $res['PublishUrls'] = null !== $this->publishUrls ? $this->publishUrls->toMap() : null;
        $res['PlayUrls']    = null !== $this->playUrls ? $this->playUrls->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return createLiveChannelResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['PublishUrls'])) {
            $model->publishUrls = publishUrls::fromMap($map['PublishUrls']);
        }
        if (isset($map['PlayUrls'])) {
            $model->playUrls = playUrls::fromMap($map['PlayUrls']);
        }

        return $model;
    }
}
