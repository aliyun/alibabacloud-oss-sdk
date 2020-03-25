<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListPartsResponse;

use AlibabaCloud\Tea\Model;

class listPartsResult extends Model
{
    public $bucket;

    public $encodingType;

    public $key;

    public $uploadId;

    public $partNumberMarker;

    public $nextPartNumberMarker;

    public $maxParts;

    public $isTruncated;

    public $part;
    protected $_name = [
        'bucket'               => 'Bucket',
        'encodingType'         => 'EncodingType',
        'key'                  => 'Key',
        'uploadId'             => 'UploadId',
        'partNumberMarker'     => 'PartNumberMarker',
        'nextPartNumberMarker' => 'NextPartNumberMarker',
        'maxParts'             => 'MaxParts',
        'isTruncated'          => 'IsTruncated',
        'part'                 => 'Part',
    ];
}
