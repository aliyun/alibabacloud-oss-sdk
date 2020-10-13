<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PostObjectRequest;

use AlibabaCloud\Tea\FileForm\FileForm\FileField;
use AlibabaCloud\Tea\Model;

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
     * @var string[]
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
        $res = [];
        if (null !== $this->accessKeyId) {
            $res['OSSAccessKeyId'] = $this->accessKeyId;
        }
        if (null !== $this->policy) {
            $res['policy'] = $this->policy;
        }
        if (null !== $this->signature) {
            $res['Signature'] = $this->signature;
        }
        if (null !== $this->successActionStatus) {
            $res['success_action_status'] = $this->successActionStatus;
        }
        if (null !== $this->file) {
            $res['file'] = null !== $this->file ? $this->file->toMap() : null;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->userMeta) {
            $res['UserMeta'] = $this->userMeta;
        }

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
            $model->file = FileField::fromMap($map['file']);
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
