<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketLifecycleRequest\body\lifecycleConfiguration;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\OSS\rule\expiration;
use AlibabaCloud\SDK\OSS\OSS\rule\transition;
use AlibabaCloud\SDK\OSS\OSS\rule\abortMultipartUpload;
use AlibabaCloud\SDK\OSS\OSS\rule\tag;

class rule extends Model{
    protected $_name = [];

    public $expiration;

    public $transition;

    public $abortMultipartUpload;

    public $tag;

    public $iD;

    public $prefix;

    public $status;

}