<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PostObjectResponse;

use AlibabaCloud\Tea\Model;

class postResponse extends Model
{
    /**
     * @description Bucket
     *
     * @var string
     */
    public $bucket;

    /**
     * @description ETag
     *
     * @var string
     */
    public $eTag;

    /**
     * @description Location
     *
     * @var string
     */
    public $location;
    protected $_name = [
        'bucket'   => 'Bucket',
        'eTag'     => 'ETag',
        'location' => 'Location',
    ];

    public function validate()
    {
        Model::validateRequired('bucket', $this->bucket, true);
        Model::validateRequired('eTag', $this->eTag, true);
        Model::validateRequired('location', $this->location, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bucket) {
            $res['Bucket'] = $this->bucket;
        }
        if (null !== $this->eTag) {
            $res['ETag'] = $this->eTag;
        }
        if (null !== $this->location) {
            $res['Location'] = $this->location;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return postResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Bucket'])) {
            $model->bucket = $map['Bucket'];
        }
        if (isset($map['ETag'])) {
            $model->eTag = $map['ETag'];
        }
        if (isset($map['Location'])) {
            $model->location = $map['Location'];
        }

        return $model;
    }
}
