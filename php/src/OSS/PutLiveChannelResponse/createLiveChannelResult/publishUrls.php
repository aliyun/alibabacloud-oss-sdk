<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelResponse\createLiveChannelResult;

use AlibabaCloud\Tea\Model;

class publishUrls extends Model
{
    /**
     * @description Url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'url' => 'Url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res        = [];
        $res['Url'] = $this->url;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return publishUrls
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Url'])) {
            $model->url = $map['Url'];
        }

        return $model;
    }
}
