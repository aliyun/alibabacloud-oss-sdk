<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketCORSRequest\body\cORSConfiguration;

use AlibabaCloud\Tea\Model;

class cORSRule extends Model
{
    /**
     * @description AllowedOrigin
     *
     * @var string[]
     */
    public $allowedOrigin;

    /**
     * @description AllowedMethod
     *
     * @var string[]
     */
    public $allowedMethod;

    /**
     * @description AllowedHeader
     *
     * @var string[]
     */
    public $allowedHeader;

    /**
     * @description ExposeHeader
     *
     * @var string[]
     */
    public $exposeHeader;

    /**
     * @description MaxAgeSeconds
     *
     * @var string
     */
    public $maxAgeSeconds;
    protected $_name = [
        'allowedOrigin' => 'AllowedOrigin',
        'allowedMethod' => 'AllowedMethod',
        'allowedHeader' => 'AllowedHeader',
        'exposeHeader'  => 'ExposeHeader',
        'maxAgeSeconds' => 'MaxAgeSeconds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowedOrigin) {
            $res['AllowedOrigin'] = $this->allowedOrigin;
        }
        if (null !== $this->allowedMethod) {
            $res['AllowedMethod'] = $this->allowedMethod;
        }
        if (null !== $this->allowedHeader) {
            $res['AllowedHeader'] = $this->allowedHeader;
        }
        if (null !== $this->exposeHeader) {
            $res['ExposeHeader'] = $this->exposeHeader;
        }
        if (null !== $this->maxAgeSeconds) {
            $res['MaxAgeSeconds'] = $this->maxAgeSeconds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cORSRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['AllowedOrigin'])) {
            if (!empty($map['AllowedOrigin'])) {
                $model->allowedOrigin = $map['AllowedOrigin'];
            }
        }
        if (isset($map['AllowedMethod'])) {
            if (!empty($map['AllowedMethod'])) {
                $model->allowedMethod = $map['AllowedMethod'];
            }
        }
        if (isset($map['AllowedHeader'])) {
            if (!empty($map['AllowedHeader'])) {
                $model->allowedHeader = $map['AllowedHeader'];
            }
        }
        if (isset($map['ExposeHeader'])) {
            if (!empty($map['ExposeHeader'])) {
                $model->exposeHeader = $map['ExposeHeader'];
            }
        }
        if (isset($map['MaxAgeSeconds'])) {
            $model->maxAgeSeconds = $map['MaxAgeSeconds'];
        }

        return $model;
    }
}
