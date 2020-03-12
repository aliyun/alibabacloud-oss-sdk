<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\Models\GetBucketLifecycleResponse\lifecycleConfiguration;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\Models\rule\expiration;
use AlibabaCloud\SDK\OSS\Models\rule\transition;
use AlibabaCloud\SDK\OSS\Models\rule\abortMultipartUpload;
use AlibabaCloud\SDK\OSS\Models\rule\tag;

class rule extends Model{
    protected $_name = [];

    public $ID;

    public $Prefix;

    public $Status;

    public $Expiration;

    public $Transition;

    public $AbortMultipartUpload;

    public $Tag;

}
