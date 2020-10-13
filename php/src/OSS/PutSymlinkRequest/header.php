<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutSymlinkRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description x-oss-symlink-target
     *
     * @var string
     */
    public $symlinkTarget;

    /**
     * @description x-oss-storage-class
     *
     * @var string
     */
    public $storageClass;
    protected $_name = [
        'symlinkTarget' => 'x-oss-symlink-target',
        'storageClass'  => 'x-oss-storage-class',
    ];

    public function validate()
    {
        Model::validateRequired('symlinkTarget', $this->symlinkTarget, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->symlinkTarget) {
            $res['x-oss-symlink-target'] = $this->symlinkTarget;
        }
        if (null !== $this->storageClass) {
            $res['x-oss-storage-class'] = $this->storageClass;
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
        if (isset($map['x-oss-symlink-target'])) {
            $model->symlinkTarget = $map['x-oss-symlink-target'];
        }
        if (isset($map['x-oss-storage-class'])) {
            $model->storageClass = $map['x-oss-storage-class'];
        }

        return $model;
    }
}
