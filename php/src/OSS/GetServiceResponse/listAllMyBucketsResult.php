<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetServiceResponse;

use AlibabaCloud\SDK\OSS\OSS\listAllMyBucketsResult\buckets;
use AlibabaCloud\SDK\OSS\OSS\listAllMyBucketsResult\owner;
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
     * @var listAllMyBucketsResult.owner
     */
    public $owner;

    /**
     * @description Buckets
     *
     * @var listAllMyBucketsResult.buckets
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
        $res                = [];
        $res['Prefix']      = $this->prefix;
        $res['Marker']      = $this->marker;
        $res['MaxKeys']     = $this->maxKeys;
        $res['IsTruncated'] = $this->isTruncated;
        $res['NextMarker']  = $this->nextMarker;
        $res['Owner']       = null !== $this->owner ? $this->owner->toMap() : null;
        $res['Buckets']     = null !== $this->buckets ? $this->buckets->toMap() : null;

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
