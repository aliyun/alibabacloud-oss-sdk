<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo;

use AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo\bucket\accessControlList;
use AlibabaCloud\SDK\OSS\OSS\GetBucketInfoResponse\bucketInfo\bucket\owner;
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
     * @var owner
     */
    public $owner;

    /**
     * @description AccessControlList
     *
     * @var accessControlList
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
        $res = [];
        if (null !== $this->creationDate) {
            $res['CreationDate'] = $this->creationDate;
        }
        if (null !== $this->extranetEndpoint) {
            $res['ExtranetEndpoint'] = $this->extranetEndpoint;
        }
        if (null !== $this->intranetEndpoint) {
            $res['IntranetEndpoint'] = $this->intranetEndpoint;
        }
        if (null !== $this->location) {
            $res['Location'] = $this->location;
        }
        if (null !== $this->name) {
            $res['Name'] = $this->name;
        }
        if (null !== $this->dataRedundancyType) {
            $res['DataRedundancyType'] = $this->dataRedundancyType;
        }
        if (null !== $this->storageClass) {
            $res['StorageClass'] = $this->storageClass;
        }
        if (null !== $this->comment) {
            $res['Comment'] = $this->comment;
        }
        if (null !== $this->owner) {
            $res['Owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }
        if (null !== $this->accessControlList) {
            $res['AccessControlList'] = null !== $this->accessControlList ? $this->accessControlList->toMap() : null;
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
            $model->owner = owner::fromMap($map['Owner']);
        }
        if (isset($map['AccessControlList'])) {
            $model->accessControlList = accessControlList::fromMap($map['AccessControlList']);
        }

        return $model;
    }
}
