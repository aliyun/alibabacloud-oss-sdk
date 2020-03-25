<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListPartsRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    public $uploadId;

    public $maxParts;

    public $partNumberMarker;

    public $encodingType;
    protected $_name = [
        'uploadId'         => 'uploadId',
        'maxParts'         => 'max-parts',
        'partNumberMarker' => 'part-number-marker',
        'encodingType'     => 'Encoding-type',
    ];
}
