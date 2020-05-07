<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\CompleteMultipartUploadRequest;

use AlibabaCloud\SDK\OSS\OSS\body\completeMultipartUpload;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description CompleteMultipartUpload
     *
     * @var body.completeMultipartUpload
     */
    public $completeMultipartUpload;
    protected $_name = [
        'completeMultipartUpload' => 'CompleteMultipartUpload',
    ];

    public function validate()
    {
        Model::validateRequired('completeMultipartUpload', $this->completeMultipartUpload, true);
    }

    public function toMap()
    {
        $res                            = [];
        $res['CompleteMultipartUpload'] = null !== $this->completeMultipartUpload ? $this->completeMultipartUpload->toMap() : null;

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
        if (isset($map['CompleteMultipartUpload'])) {
            $model->completeMultipartUpload = completeMultipartUpload::fromMap($map['CompleteMultipartUpload']);
        }

        return $model;
    }
}
