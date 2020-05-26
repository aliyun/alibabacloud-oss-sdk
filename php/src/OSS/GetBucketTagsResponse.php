<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\GetBucketTagsResponse\tagging;
use AlibabaCloud\Tea\Model;

class GetBucketTagsResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description Tagging
     *
     * @var tagging
     */
    public $tagging;
    protected $_name = [
        'requestId' => 'x-oss-request-id',
        'tagging'   => 'Tagging',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('tagging', $this->tagging, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['x-oss-request-id'] = $this->requestId;
        $res['Tagging']          = null !== $this->tagging ? $this->tagging->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBucketTagsResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['Tagging'])) {
            $model->tagging = tagging::fromMap($map['Tagging']);
        }

        return $model;
    }
}
