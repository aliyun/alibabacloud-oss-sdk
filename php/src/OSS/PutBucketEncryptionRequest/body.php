<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketEncryptionRequest;

use AlibabaCloud\SDK\OSS\OSS\body\serverSideEncryptionRule;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description ServerSideEncryptionRule
     *
     * @var body.serverSideEncryptionRule
     */
    public $serverSideEncryptionRule;
    protected $_name = [
        'serverSideEncryptionRule' => 'ServerSideEncryptionRule',
    ];

    public function validate()
    {
        Model::validateRequired('serverSideEncryptionRule', $this->serverSideEncryptionRule, true);
    }

    public function toMap()
    {
        $res                             = [];
        $res['ServerSideEncryptionRule'] = null !== $this->serverSideEncryptionRule ? $this->serverSideEncryptionRule->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ServerSideEncryptionRule'])) {
            $model->serverSideEncryptionRule = serverSideEncryptionRule::fromMap($map['ServerSideEncryptionRule']);
        }

        return $model;
    }
}
