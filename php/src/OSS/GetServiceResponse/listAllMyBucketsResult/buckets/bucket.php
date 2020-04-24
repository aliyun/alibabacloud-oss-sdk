<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetServiceResponse\listAllMyBucketsResult\buckets;

use AlibabaCloud\Tea\Model;

class bucket extends Model
{
    /**
     * @description Name
     *
     * @var string
     */
    public $name;

    /**
     * @description CreateDate
     *
     * @var string
     */
    public $createDate;

    /**
     * @description Location
     *
     * @var string
     */
    public $location;

    /**
     * @description ExtranetEndpoint
     *
     * @var string
     */
    public $extranetEndpoint;

    /**
     * @description IntranetEndpoint
     *
     * @var string
     */
    public $intranetEndpoint;

    /**
     * @description StorageClass
     *
     * @var string
     */
    public $storageClass;
    protected $_name = [
        'name'             => 'Name',
        'createDate'       => 'CreateDate',
        'location'         => 'Location',
        'extranetEndpoint' => 'ExtranetEndpoint',
        'intranetEndpoint' => 'IntranetEndpoint',
        'storageClass'     => 'StorageClass',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                     = [];
        $res['Name']             = $this->name;
        $res['CreateDate']       = $this->createDate;
        $res['Location']         = $this->location;
        $res['ExtranetEndpoint'] = $this->extranetEndpoint;
        $res['IntranetEndpoint'] = $this->intranetEndpoint;
        $res['StorageClass']     = $this->storageClass;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bucket
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Name'])) {
            $model->name = $map['Name'];
        }
        if (isset($map['CreateDate'])) {
            $model->createDate = $map['CreateDate'];
        }
        if (isset($map['Location'])) {
            $model->location = $map['Location'];
        }
        if (isset($map['ExtranetEndpoint'])) {
            $model->extranetEndpoint = $map['ExtranetEndpoint'];
        }
        if (isset($map['IntranetEndpoint'])) {
            $model->intranetEndpoint = $map['IntranetEndpoint'];
        }
        if (isset($map['StorageClass'])) {
            $model->storageClass = $map['StorageClass'];
        }

        return $model;
    }
}
