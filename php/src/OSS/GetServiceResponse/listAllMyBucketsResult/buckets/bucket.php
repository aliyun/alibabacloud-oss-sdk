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
        $res = [];
        if (null !== $this->name) {
            $res['Name'] = $this->name;
        }
        if (null !== $this->createDate) {
            $res['CreateDate'] = $this->createDate;
        }
        if (null !== $this->location) {
            $res['Location'] = $this->location;
        }
        if (null !== $this->extranetEndpoint) {
            $res['ExtranetEndpoint'] = $this->extranetEndpoint;
        }
        if (null !== $this->intranetEndpoint) {
            $res['IntranetEndpoint'] = $this->intranetEndpoint;
        }
        if (null !== $this->storageClass) {
            $res['StorageClass'] = $this->storageClass;
        }

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
