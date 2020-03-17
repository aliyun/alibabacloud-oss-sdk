<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\filter;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\inputSerialization;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\inputSerialization\cSV;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\outputSerialization;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\outputSerialization\cSV;
use AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest\body\selectRequest\options;

class SelectObjectRequest extends Model{
    protected $_name = [];

    public $bucketName;

    public $objectName;

    public $filter;

    public $body;

}
