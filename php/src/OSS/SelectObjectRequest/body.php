<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\SelectObjectRequest;

use AlibabaCloud\SDK\OSS\OSS\body\selectRequest;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description SelectRequest
     *
     * @var body.selectRequest
     */
    public $selectRequest;
    protected $_name = [
        'selectRequest' => 'SelectRequest',
    ];

    public function validate()
    {
        Model::validateRequired('selectRequest', $this->selectRequest, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['SelectRequest'] = null !== $this->selectRequest ? $this->selectRequest->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['SelectRequest'])) {
            $model->selectRequest = selectRequest::fromMap($map['SelectRequest']);
        }

        return $model;
    }
}
