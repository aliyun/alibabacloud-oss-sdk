<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\OptionObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description Origin
     *
     * @var string
     */
    public $origin;

    /**
     * @description Access-Control-Request-Method
     *
     * @var string
     */
    public $accessControlRequestMethod;

    /**
     * @description Access-Control-Request-Headers
     *
     * @var string
     */
    public $accessControlRequestHeaders;
    protected $_name = [
        'origin'                      => 'Origin',
        'accessControlRequestMethod'  => 'Access-Control-Request-Method',
        'accessControlRequestHeaders' => 'Access-Control-Request-Headers',
    ];

    public function validate()
    {
        Model::validateRequired('origin', $this->origin, true);
        Model::validateRequired('accessControlRequestMethod', $this->accessControlRequestMethod, true);
        Model::validateRequired('accessControlRequestHeaders', $this->accessControlRequestHeaders, true);
    }

    public function toMap()
    {
        $res                                   = [];
        $res['Origin']                         = $this->origin;
        $res['Access-Control-Request-Method']  = $this->accessControlRequestMethod;
        $res['Access-Control-Request-Headers'] = $this->accessControlRequestHeaders;

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
        if (isset($map['Origin'])) {
            $model->origin = $map['Origin'];
        }
        if (isset($map['Access-Control-Request-Method'])) {
            $model->accessControlRequestMethod = $map['Access-Control-Request-Method'];
        }
        if (isset($map['Access-Control-Request-Headers'])) {
            $model->accessControlRequestHeaders = $map['Access-Control-Request-Headers'];
        }

        return $model;
    }
}
