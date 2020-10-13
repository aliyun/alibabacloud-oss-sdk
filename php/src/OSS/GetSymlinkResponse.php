<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class GetSymlinkResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description x-oss-symlink-target
     *
     * @var string
     */
    public $symlinkTarget;
    protected $_name = [
        'requestId'     => 'x-oss-request-id',
        'symlinkTarget' => 'x-oss-symlink-target',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('symlinkTarget', $this->symlinkTarget, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->symlinkTarget) {
            $res['x-oss-symlink-target'] = $this->symlinkTarget;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSymlinkResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['x-oss-symlink-target'])) {
            $model->symlinkTarget = $map['x-oss-symlink-target'];
        }

        return $model;
    }
}
