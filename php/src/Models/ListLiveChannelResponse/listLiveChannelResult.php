<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\Models\ListLiveChannelResponse;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\Models\listLiveChannelResult\liveChannel;
use AlibabaCloud\SDK\OSS\Models\listLiveChannelResult\liveChannel\publishUrls;
use AlibabaCloud\SDK\OSS\Models\listLiveChannelResult\liveChannel\playUrls;

class listLiveChannelResult extends Model{
    protected $_name = [];

    public $prefix;

    public $marker;

    public $maxKeys;

    public $isTruncated;

    public $nextMarker;

    public $liveChannel;

}
