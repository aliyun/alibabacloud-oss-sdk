<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\SDK\OSS\OSS\PostObjectResponse\postResponse;
use AlibabaCloud\Tea\Model;

class PostObjectResponse extends Model
{
    /**
     * @description PostResponse
     *
     * @var PostObjectResponse.postResponse
     */
    public $postResponse;
    protected $_name = [
        'postResponse' => 'PostResponse',
    ];

    public function validate()
    {
        Model::validateRequired('postResponse', $this->postResponse, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['PostResponse'] = null !== $this->postResponse ? $this->postResponse->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PostObjectResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['PostResponse'])) {
            $model->postResponse = postResponse::fromMap($map['PostResponse']);
        }

        return $model;
    }
}
