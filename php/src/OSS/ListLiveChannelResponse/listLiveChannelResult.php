<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse;

use AlibabaCloud\Tea\Model;

class listLiveChannelResult extends Model
{
    public $prefix;

    public $marker;

    public $maxKeys;

    public $isTruncated;

    public $nextMarker;

    public $liveChannel;
    protected $_name = [
        'prefix'      => 'Prefix',
        'marker'      => 'Marker',
        'maxKeys'     => 'MaxKeys',
        'isTruncated' => 'IsTruncated',
        'nextMarker'  => 'NextMarker',
        'liveChannel' => 'LiveChannel',
    ];
}
