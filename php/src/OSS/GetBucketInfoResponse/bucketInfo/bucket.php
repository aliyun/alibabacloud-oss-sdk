<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo;

use AlibabaCloud\SDK\OSS\OSS\bucket\accessControlList;
use AlibabaCloud\SDK\OSS\OSS\bucket\owner;
use AlibabaCloud\Tea\Model;

class bucket extends Model
{
    /**
     * @description CreationDate
     *
     * @var string
     */
    public $creationDate;

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
     * @description Location
     *
     * @var string
     */
    public $location;

    /**
     * @description Name
     *
     * @var string
     */
    public $name;

    /**
     * @description DataRedundancyType
     *
     * @var string
     */
    public $dataRedundancyType;

    /**
     * @description StorageClass
     *
     * @var string
     */
    public $storageClass;

    /**
     * @description Comment
     *
     * @var string
     */
    public $comment;

    /**
     * @description Owner
     *
     * @var bucket.owner
     */
    public $owner;

    /**
     * @description AccessControlList
     *
     * @var bucket.accessControlList
     */
    public $accessControlList;
    protected $_name = [
        'creationDate'       => 'CreationDate',
        'extranetEndpoint'   => 'ExtranetEndpoint',
        'intranetEndpoint'   => 'IntranetEndpoint',
        'location'           => 'Location',
        'name'               => 'Name',
        'dataRedundancyType' => 'DataRedundancyType',
        'storageClass'       => 'StorageClass',
        'comment'            => 'Comment',
        'owner'              => 'Owner',
        'accessControlList'  => 'AccessControlList',
    ];

    public function validate()
    {
        Model::validateRequired('owner', $this->owner, true);
        Model::validateRequired('accessControlList', $this->accessControlList, true);
    }

    public function toMap()
    {
        $res                       = [];
        $res['CreationDate']       = $this->creationDate;
        $res['ExtranetEndpoint']   = $this->extranetEndpoint;
        $res['IntranetEndpoint']   = $this->intranetEndpoint;
        $res['Location']           = $this->location;
        $res['Name']               = $this->name;
        $res['DataRedundancyType'] = $this->dataRedundancyType;
        $res['StorageClass']       = $this->storageClass;
        $res['Comment']            = $this->comment;
        $res['Owner']              = null !== $this->owner ? $this->owner->toMap() : null;
        $res['AccessControlList']  = null !== $this->accessControlList ? $this->accessControlList->toMap() : null;

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
        if (isset($map['CreationDate'])) {
            $model->creationDate = $map['CreationDate'];
        }
        if (isset($map['ExtranetEndpoint'])) {
            $model->extranetEndpoint = $map['ExtranetEndpoint'];
        }
        if (isset($map['IntranetEndpoint'])) {
            $model->intranetEndpoint = $map['IntranetEndpoint'];
        }
        if (isset($map['Location'])) {
            $model->location = $map['Location'];
        }
        if (isset($map['Name'])) {
            $model->name = $map['Name'];
        }
        if (isset($map['DataRedundancyType'])) {
            $model->dataRedundancyType = $map['DataRedundancyType'];
        }
        if (isset($map['StorageClass'])) {
            $model->storageClass = $map['StorageClass'];
        }
        if (isset($map['Comment'])) {
            $model->comment = $map['Comment'];
        }
        if (isset($map['Owner'])) {
            $model->owner = bucket\owner::fromMap($map['Owner']);
        }
        if (isset($map['AccessControlList'])) {
            $model->accessControlList = bucket\accessControlList::fromMap($map['AccessControlList']);
        }

        return $model;
    }
}
