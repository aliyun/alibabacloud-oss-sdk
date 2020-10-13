<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketEncryptionRequest\body\serverSideEncryptionRule;

use AlibabaCloud\Tea\Model;

class applyServerSideEncryptionByDefault extends Model
{
    /**
     * @description SSEAlgorithm
     *
     * @var string
     */
    public $sSEAlgorithm;

    /**
     * @description KMSMasterKeyID
     *
     * @var string
     */
    public $kMSMasterKeyID;
    protected $_name = [
        'sSEAlgorithm'   => 'SSEAlgorithm',
        'kMSMasterKeyID' => 'KMSMasterKeyID',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sSEAlgorithm) {
            $res['SSEAlgorithm'] = $this->sSEAlgorithm;
        }
        if (null !== $this->kMSMasterKeyID) {
            $res['KMSMasterKeyID'] = $this->kMSMasterKeyID;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return applyServerSideEncryptionByDefault
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['SSEAlgorithm'])) {
            $model->sSEAlgorithm = $map['SSEAlgorithm'];
        }
        if (isset($map['KMSMasterKeyID'])) {
            $model->kMSMasterKeyID = $map['KMSMasterKeyID'];
        }

        return $model;
    }
}
