<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketResponse;

use AlibabaCloud\Tea\Model;

class listBucketResult extends Model
{
    public $name;

    public $prefix;

    public $marker;

    public $maxKeys;

    public $delimiter;

    public $isTruncated;

    public $encodingType;

    public $commonPrefixes;

    public $contents;
    protected $_name = [
        'name'           => 'Name',
        'prefix'         => 'Prefix',
        'marker'         => 'Marker',
        'maxKeys'        => 'MaxKeys',
        'delimiter'      => 'Delimiter',
        'isTruncated'    => 'IsTruncated',
        'encodingType'   => 'EncodingType',
        'commonPrefixes' => 'CommonPrefixes',
        'contents'       => 'Contents',
    ];
}
