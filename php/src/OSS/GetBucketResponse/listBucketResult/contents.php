<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketResponse\listBucketResult;

use AlibabaCloud\SDK\OSS\OSS\GetBucketResponse\listBucketResult\contents\owner;
use AlibabaCloud\Tea\Model;

class contents extends Model
{
    /**
     * @description Key
     *
     * @var string
     */
    public $key;

    /**
     * @description ETag
     *
     * @var string
     */
    public $eTag;

    /**
     * @description LastModified
     *
     * @var string
     */
    public $lastModified;

    /**
     * @description Size
     *
     * @var string
     */
    public $size;

    /**
     * @description StorageClass
     *
     * @var string
     */
    public $storageClass;

    /**
     * @description Owner
     *
     * @var owner
     */
    public $owner;
    protected $_name = [
        'key'          => 'Key',
        'eTag'         => 'ETag',
        'lastModified' => 'LastModified',
        'size'         => 'Size',
        'storageClass' => 'StorageClass',
        'owner'        => 'Owner',
    ];

    public function validate()
    {
        Model::validateRequired('owner', $this->owner, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->key) {
            $res['Key'] = $this->key;
        }
        if (null !== $this->eTag) {
            $res['ETag'] = $this->eTag;
        }
        if (null !== $this->lastModified) {
            $res['LastModified'] = $this->lastModified;
        }
        if (null !== $this->size) {
            $res['Size'] = $this->size;
        }
        if (null !== $this->storageClass) {
            $res['StorageClass'] = $this->storageClass;
        }
        if (null !== $this->owner) {
            $res['Owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contents
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Key'])) {
            $model->key = $map['Key'];
        }
        if (isset($map['ETag'])) {
            $model->eTag = $map['ETag'];
        }
        if (isset($map['LastModified'])) {
            $model->lastModified = $map['LastModified'];
        }
        if (isset($map['Size'])) {
            $model->size = $map['Size'];
        }
        if (isset($map['StorageClass'])) {
            $model->storageClass = $map['StorageClass'];
        }
        if (isset($map['Owner'])) {
            $model->owner = owner::fromMap($map['Owner']);
        }

        return $model;
    }
}
