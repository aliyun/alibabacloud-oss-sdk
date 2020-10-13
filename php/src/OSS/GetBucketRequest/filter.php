<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @description delimiter
     *
     * @var string
     */
    public $delimiter;

    /**
     * @description marker
     *
     * @var string
     */
    public $marker;

    /**
     * @description max-keys
     *
     * @var string
     */
    public $maxKeys;

    /**
     * @description prefix
     *
     * @var string
     */
    public $prefix;

    /**
     * @description encoding-type
     *
     * @var string
     */
    public $encodingType;
    protected $_name = [
        'delimiter'    => 'delimiter',
        'marker'       => 'marker',
        'maxKeys'      => 'max-keys',
        'prefix'       => 'prefix',
        'encodingType' => 'encoding-type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->delimiter) {
            $res['delimiter'] = $this->delimiter;
        }
        if (null !== $this->marker) {
            $res['marker'] = $this->marker;
        }
        if (null !== $this->maxKeys) {
            $res['max-keys'] = $this->maxKeys;
        }
        if (null !== $this->prefix) {
            $res['prefix'] = $this->prefix;
        }
        if (null !== $this->encodingType) {
            $res['encoding-type'] = $this->encodingType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['delimiter'])) {
            $model->delimiter = $map['delimiter'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
        }
        if (isset($map['max-keys'])) {
            $model->maxKeys = $map['max-keys'];
        }
        if (isset($map['prefix'])) {
            $model->prefix = $map['prefix'];
        }
        if (isset($map['encoding-type'])) {
            $model->encodingType = $map['encoding-type'];
        }

        return $model;
    }
}
