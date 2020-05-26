<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse;

use AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse\listLiveChannelResult\liveChannel;
use AlibabaCloud\Tea\Model;

class listLiveChannelResult extends Model
{
    /**
     * @description Prefix
     *
     * @var string
     */
    public $prefix;

    /**
     * @description Marker
     *
     * @var string
     */
    public $marker;

    /**
     * @description MaxKeys
     *
     * @var string
     */
    public $maxKeys;

    /**
     * @description IsTruncated
     *
     * @var string
     */
    public $isTruncated;

    /**
     * @description NextMarker
     *
     * @var string
     */
    public $nextMarker;

    /**
     * @description LiveChannel
     *
     * @var liveChannel
     */
    public $liveChannel;
    protected $_name = [
        'prefix'      => 'Prefix',
        'marker'      => 'Marker',
        'maxKeys'     => 'MaxKeys',
        'isTruncated' => 'IsTruncated',
        'nextMarker'  => 'NextMarker',
        'liveChannel' => 'LiveChannel',
    ];

    public function validate()
    {
        Model::validateRequired('liveChannel', $this->liveChannel, true);
    }

    public function toMap()
    {
        $res                = [];
        $res['Prefix']      = $this->prefix;
        $res['Marker']      = $this->marker;
        $res['MaxKeys']     = $this->maxKeys;
        $res['IsTruncated'] = $this->isTruncated;
        $res['NextMarker']  = $this->nextMarker;
        $res['LiveChannel'] = null !== $this->liveChannel ? $this->liveChannel->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return listLiveChannelResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Prefix'])) {
            $model->prefix = $map['Prefix'];
        }
        if (isset($map['Marker'])) {
            $model->marker = $map['Marker'];
        }
        if (isset($map['MaxKeys'])) {
            $model->maxKeys = $map['MaxKeys'];
        }
        if (isset($map['IsTruncated'])) {
            $model->isTruncated = $map['IsTruncated'];
        }
        if (isset($map['NextMarker'])) {
            $model->nextMarker = $map['NextMarker'];
        }
        if (isset($map['LiveChannel'])) {
            $model->liveChannel = liveChannel::fromMap($map['LiveChannel']);
        }

        return $model;
    }
}
