<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo\bucket;

use AlibabaCloud\Tea\Model;

class owner extends Model
{
    /**
     * @description ID
     *
     * @var string
     */
    public $iD;

    /**
     * @description DisplayName
     *
     * @var string
     */
    public $displayName;
    protected $_name = [
        'iD'          => 'ID',
        'displayName' => 'DisplayName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->iD) {
            $res['ID'] = $this->iD;
        }
        if (null !== $this->displayName) {
            $res['DisplayName'] = $this->displayName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return owner
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ID'])) {
            $model->iD = $map['ID'];
        }
        if (isset($map['DisplayName'])) {
            $model->displayName = $map['DisplayName'];
        }

        return $model;
    }
}
