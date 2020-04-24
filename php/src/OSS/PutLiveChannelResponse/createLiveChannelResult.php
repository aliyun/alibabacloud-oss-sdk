<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelResponse;

use AlibabaCloud\SDK\OSS\OSS\createLiveChannelResult\playUrls;
use AlibabaCloud\SDK\OSS\OSS\createLiveChannelResult\publishUrls;
use AlibabaCloud\Tea\Model;

class createLiveChannelResult extends Model
{
    /**
     * @description PublishUrls
     *
     * @var createLiveChannelResult.publishUrls
     */
    public $publishUrls;

    /**
     * @description PlayUrls
     *
     * @var createLiveChannelResult.playUrls
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
            $model->publishUrls = createLiveChannelResult\publishUrls::fromMap($map['PublishUrls']);
        }
        if (isset($map['PlayUrls'])) {
            $model->playUrls = createLiveChannelResult\playUrls::fromMap($map['PlayUrls']);
        }

        return $model;
    }
}
