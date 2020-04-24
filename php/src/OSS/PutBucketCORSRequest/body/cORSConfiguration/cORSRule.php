<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutBucketCORSRequest\body\cORSConfiguration;

use AlibabaCloud\Tea\Model;

class cORSRule extends Model
{
    /**
     * @description AllowedOrigin
     *
     * @var array
     */
    public $allowedOrigin;

    /**
     * @description AllowedMethod
     *
     * @var array
     */
    public $allowedMethod;

    /**
     * @description AllowedHeader
     *
     * @var array
     */
    public $allowedHeader;

    /**
     * @description ExposeHeader
     *
     * @var array
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
        $res                  = [];
        $res['AllowedOrigin'] = [];
        if (null !== $this->allowedOrigin) {
            $res['AllowedOrigin'] = $this->allowedOrigin;
        }
        $res['AllowedMethod'] = [];
        if (null !== $this->allowedMethod) {
            $res['AllowedMethod'] = $this->allowedMethod;
        }
        $res['AllowedHeader'] = [];
        if (null !== $this->allowedHeader) {
            $res['AllowedHeader'] = $this->allowedHeader;
        }
        $res['ExposeHeader'] = [];
        if (null !== $this->exposeHeader) {
            $res['ExposeHeader'] = $this->exposeHeader;
        }
        $res['MaxAgeSeconds'] = $this->maxAgeSeconds;

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
                $model->allowedOrigin = [];
                $model->allowedOrigin = $map['AllowedOrigin'];
            }
        }
        if (isset($map['AllowedMethod'])) {
            if (!empty($map['AllowedMethod'])) {
                $model->allowedMethod = [];
                $model->allowedMethod = $map['AllowedMethod'];
            }
        }
        if (isset($map['AllowedHeader'])) {
            if (!empty($map['AllowedHeader'])) {
                $model->allowedHeader = [];
                $model->allowedHeader = $map['AllowedHeader'];
            }
        }
        if (isset($map['ExposeHeader'])) {
            if (!empty($map['ExposeHeader'])) {
                $model->exposeHeader = [];
                $model->exposeHeader = $map['ExposeHeader'];
            }
        }
        if (isset($map['MaxAgeSeconds'])) {
            $model->maxAgeSeconds = $map['MaxAgeSeconds'];
        }

        return $model;
    }
}
