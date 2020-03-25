<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListMultipartUploadsResponse;

use AlibabaCloud\Tea\Model;

class listMultipartUploadsResult extends Model
{
    public $bucket;

    public $encodingType;

    public $keyMarker;

    public $uploadIdMarker;

    public $nextKeyMarker;

    public $nextUploadIdMarker;

    public $delimiter;

    public $maxUploads;

    public $isTruncated;

    public $upload;
    protected $_name = [
        'bucket'             => 'Bucket',
        'encodingType'       => 'EncodingType',
        'keyMarker'          => 'KeyMarker',
        'uploadIdMarker'     => 'UploadIdMarker',
        'nextKeyMarker'      => 'NextKeyMarker',
        'nextUploadIdMarker' => 'NextUploadIdMarker',
        'delimiter'          => 'Delimiter',
        'maxUploads'         => 'MaxUploads',
        'isTruncated'        => 'IsTruncated',
        'upload'             => 'Upload',
    ];
}
