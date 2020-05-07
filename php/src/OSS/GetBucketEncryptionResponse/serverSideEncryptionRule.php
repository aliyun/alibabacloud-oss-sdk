<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketEncryptionResponse;

use AlibabaCloud\SDK\OSS\OSS\serverSideEncryptionRule\applyServerSideEncryptionByDefault;
use AlibabaCloud\Tea\Model;

class serverSideEncryptionRule extends Model
{
    /**
     * @description ApplyServerSideEncryptionByDefault
     *
     * @var serverSideEncryptionRule.applyServerSideEncryptionByDefault
     */
    public $applyServerSideEncryptionByDefault;
    protected $_name = [
        'applyServerSideEncryptionByDefault' => 'ApplyServerSideEncryptionByDefault',
    ];

    public function validate()
    {
        Model::validateRequired('applyServerSideEncryptionByDefault', $this->applyServerSideEncryptionByDefault, true);
    }

    public function toMap()
    {
        $res                                       = [];
        $res['ApplyServerSideEncryptionByDefault'] = null !== $this->applyServerSideEncryptionByDefault ? $this->applyServerSideEncryptionByDefault->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return serverSideEncryptionRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ApplyServerSideEncryptionByDefault'])) {
            $model->applyServerSideEncryptionByDefault = applyServerSideEncryptionByDefault::fromMap($map['ApplyServerSideEncryptionByDefault']);
        }

        return $model;
    }
}
