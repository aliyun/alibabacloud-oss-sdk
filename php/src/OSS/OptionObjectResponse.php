<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS;

use AlibabaCloud\Tea\Model;

class OptionObjectResponse extends Model
{
    /**
     * @description x-oss-request-id
     *
     * @var string
     */
    public $requestId;

    /**
     * @description Access-Control-Allow-Origin
     *
     * @var string
     */
    public $accessControlAllowOrigin;

    /**
     * @description Access-Control-Allow-Methods
     *
     * @var string
     */
    public $accessControlAllowMethods;

    /**
     * @description Access-Control-Allow-Headers
     *
     * @var string
     */
    public $accessControlAllowHeaders;

    /**
     * @description Access-Control-Expose-Headers
     *
     * @var string
     */
    public $accessControlExposeHeaders;

    /**
     * @description Access-Control-Max-Age
     *
     * @var string
     */
    public $accessControlMaxAge;
    protected $_name = [
        'requestId'                  => 'x-oss-request-id',
        'accessControlAllowOrigin'   => 'access-control-allow-origin',
        'accessControlAllowMethods'  => 'access-control-allow-methods',
        'accessControlAllowHeaders'  => 'access-control-allow-headers',
        'accessControlExposeHeaders' => 'access-control-expose-headers',
        'accessControlMaxAge'        => 'access-control-max-age',
    ];

    public function validate()
    {
        Model::validateRequired('requestId', $this->requestId, true);
        Model::validateRequired('accessControlAllowOrigin', $this->accessControlAllowOrigin, true);
        Model::validateRequired('accessControlAllowMethods', $this->accessControlAllowMethods, true);
        Model::validateRequired('accessControlAllowHeaders', $this->accessControlAllowHeaders, true);
        Model::validateRequired('accessControlExposeHeaders', $this->accessControlExposeHeaders, true);
        Model::validateRequired('accessControlMaxAge', $this->accessControlMaxAge, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['x-oss-request-id'] = $this->requestId;
        }
        if (null !== $this->accessControlAllowOrigin) {
            $res['access-control-allow-origin'] = $this->accessControlAllowOrigin;
        }
        if (null !== $this->accessControlAllowMethods) {
            $res['access-control-allow-methods'] = $this->accessControlAllowMethods;
        }
        if (null !== $this->accessControlAllowHeaders) {
            $res['access-control-allow-headers'] = $this->accessControlAllowHeaders;
        }
        if (null !== $this->accessControlExposeHeaders) {
            $res['access-control-expose-headers'] = $this->accessControlExposeHeaders;
        }
        if (null !== $this->accessControlMaxAge) {
            $res['access-control-max-age'] = $this->accessControlMaxAge;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OptionObjectResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['x-oss-request-id'])) {
            $model->requestId = $map['x-oss-request-id'];
        }
        if (isset($map['access-control-allow-origin'])) {
            $model->accessControlAllowOrigin = $map['access-control-allow-origin'];
        }
        if (isset($map['access-control-allow-methods'])) {
            $model->accessControlAllowMethods = $map['access-control-allow-methods'];
        }
        if (isset($map['access-control-allow-headers'])) {
            $model->accessControlAllowHeaders = $map['access-control-allow-headers'];
        }
        if (isset($map['access-control-expose-headers'])) {
            $model->accessControlExposeHeaders = $map['access-control-expose-headers'];
        }
        if (isset($map['access-control-max-age'])) {
            $model->accessControlMaxAge = $map['access-control-max-age'];
        }

        return $model;
    }
}
