<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    public $delimiter;

    public $maxUploads;

    public $keyMarker;

    public $prefix;

    public $uploadIdMarker;

    public $encodingType;
    protected $_name = [
        'delimiter'      => 'delimiter',
        'maxUploads'     => 'max-uploads',
        'keyMarker'      => 'key-marker',
        'prefix'         => 'prefix',
        'uploadIdMarker' => 'upload-id-marker',
        'encodingType'   => 'encoding-type',
    ];
}
