<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PostObjectRequest;

use AlibabaCloud\Tea\Model;
use FileForm\FileField;

class header extends Model
{
    /**
     * @description OSSAccessKeyId
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description policy
     *
     * @var string
     */
    public $policy;

    /**
     * @description Signature
     *
     * @var string
     */
    public $signature;

    /**
     * @description success_action_status
     *
     * @var string
     */
    public $successActionStatus;

    /**
     * @var FileField
     */
    public $file;

    /**
     * @description key
     *
     * @var string
     */
    public $key;

    /**
     * @description UserMeta
     *
     * @var array
     */
    public $userMeta;
    protected $_name = [
        'accessKeyId'         => 'OSSAccessKeyId',
        'policy'              => 'policy',
        'signature'           => 'Signature',
        'successActionStatus' => 'success_action_status',
        'key'                 => 'key',
        'userMeta'            => 'UserMeta',
    ];

    public function validate()
    {
        Model::validateRequired('accessKeyId', $this->accessKeyId, true);
        Model::validateRequired('policy', $this->policy, true);
        Model::validateRequired('signature', $this->signature, true);
        Model::validateRequired('file', $this->file, true);
        Model::validateRequired('key', $this->key, true);
    }

    public function toMap()
    {
        $res                          = [];
        $res['OSSAccessKeyId']        = $this->accessKeyId;
        $res['policy']                = $this->policy;
        $res['Signature']             = $this->signature;
        $res['success_action_status'] = $this->successActionStatus;
        $res['file']                  = null !== $this->file ? $this->file->toMap() : null;
        $res['key']                   = $this->key;
        $res['UserMeta']              = $this->userMeta;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return header
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['OSSAccessKeyId'])) {
            $model->accessKeyId = $map['OSSAccessKeyId'];
        }
        if (isset($map['policy'])) {
            $model->policy = $map['policy'];
        }
        if (isset($map['Signature'])) {
            $model->signature = $map['Signature'];
        }
        if (isset($map['success_action_status'])) {
            $model->successActionStatus = $map['success_action_status'];
        }
        if (isset($map['file'])) {
            $model->file = AlibabaCloud\SDK\OSS\OSS\FileField::fromMap($map['file']);
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['UserMeta'])) {
            $model->userMeta = $map['UserMeta'];
        }

        return $model;
    }
}
