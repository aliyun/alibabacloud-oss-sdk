<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetServiceResponse;

use AlibabaCloud\SDK\OSS\OSS\GetServiceResponse\listAllMyBucketsResult\buckets;
use AlibabaCloud\SDK\OSS\OSS\GetServiceResponse\listAllMyBucketsResult\owner;
use AlibabaCloud\Tea\Model;

class listAllMyBucketsResult extends Model
{
    /**
     * @description Prefix
     *
     * @var string
     */
    public $prefix;

    /**
     * @description Marker
     *
     * @var string
     */
    public $marker;

    /**
     * @description MaxKeys
     *
     * @var string
     */
    public $maxKeys;

    /**
     * @description IsTruncated
     *
     * @var string
     */
    public $isTruncated;

    /**
     * @description NextMarker
     *
     * @var string
     */
    public $nextMarker;

    /**
     * @description Owner
     *
     * @var owner
     */
    public $owner;

    /**
     * @description Buckets
     *
     * @var buckets
     */
    public $buckets;
    protected $_name = [
        'prefix'      => 'Prefix',
        'marker'      => 'Marker',
        'maxKeys'     => 'MaxKeys',
        'isTruncated' => 'IsTruncated',
        'nextMarker'  => 'NextMarker',
        'owner'       => 'Owner',
        'buckets'     => 'Buckets',
    ];

    public function validate()
    {
        Model::validateRequired('owner', $this->owner, true);
        Model::validateRequired('buckets', $this->buckets, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->prefix) {
            $res['Prefix'] = $this->prefix;
        }
        if (null !== $this->marker) {
            $res['Marker'] = $this->marker;
        }
        if (null !== $this->maxKeys) {
            $res['MaxKeys'] = $this->maxKeys;
        }
        if (null !== $this->isTruncated) {
            $res['IsTruncated'] = $this->isTruncated;
        }
        if (null !== $this->nextMarker) {
            $res['NextMarker'] = $this->nextMarker;
        }
        if (null !== $this->owner) {
            $res['Owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }
        if (null !== $this->buckets) {
            $res['Buckets'] = null !== $this->buckets ? $this->buckets->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return listAllMyBucketsResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Prefix'])) {
            $model->prefix = $map['Prefix'];
        }
        if (isset($map['Marker'])) {
            $model->marker = $map['Marker'];
        }
        if (isset($map['MaxKeys'])) {
            $model->maxKeys = $map['MaxKeys'];
        }
        if (isset($map['IsTruncated'])) {
            $model->isTruncated = $map['IsTruncated'];
        }
        if (isset($map['NextMarker'])) {
            $model->nextMarker = $map['NextMarker'];
        }
        if (isset($map['Owner'])) {
            $model->owner = owner::fromMap($map['Owner']);
        }
        if (isset($map['Buckets'])) {
            $model->buckets = buckets::fromMap($map['Buckets']);
        }

        return $model;
    }
}
