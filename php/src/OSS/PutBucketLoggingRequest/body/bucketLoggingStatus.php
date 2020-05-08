<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketLoggingRequest\body;

use AlibabaCloud\SDK\OSS\OSS\bucketLoggingStatus\loggingEnabled;
use AlibabaCloud\Tea\Model;

class bucketLoggingStatus extends Model
{
    /**
     * @description LoggingEnabled
     *
     * @var bucketLoggingStatus.loggingEnabled
     */
    public $loggingEnabled;
    protected $_name = [
        'loggingEnabled' => 'LoggingEnabled',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                   = [];
        $res['LoggingEnabled'] = null !== $this->loggingEnabled ? $this->loggingEnabled->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bucketLoggingStatus
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['LoggingEnabled'])) {
            $model->loggingEnabled = loggingEnabled::fromMap($map['LoggingEnabled']);
        }

        return $model;
    }
}
