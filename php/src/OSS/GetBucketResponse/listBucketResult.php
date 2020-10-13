<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketResponse;

use AlibabaCloud\SDK\OSS\OSS\GetBucketResponse\listBucketResult\contents;
use AlibabaCloud\Tea\Model;

class listBucketResult extends Model
{
    /**
     * @description Name
     *
     * @var string
     */
    public $name;

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
     * @description Delimiter
     *
     * @var string
     */
    public $delimiter;

    /**
     * @description IsTruncated
     *
     * @var string
     */
    public $isTruncated;

    /**
     * @description EncodingType
     *
     * @var string
     */
    public $encodingType;

    /**
     * @description CommonPrefixes
     *
     * @var string
     */
    public $commonPrefixes;

    /**
     * @description Contents
     *
     * @var contents[]
     */
    public $contents;
    protected $_name = [
        'name'           => 'Name',
        'prefix'         => 'Prefix',
        'marker'         => 'Marker',
        'maxKeys'        => 'MaxKeys',
        'delimiter'      => 'Delimiter',
        'isTruncated'    => 'IsTruncated',
        'encodingType'   => 'EncodingType',
        'commonPrefixes' => 'CommonPrefixes',
        'contents'       => 'Contents',
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
        if (null !== $this->prefix) {
            $res['Prefix'] = $this->prefix;
        }
        if (null !== $this->marker) {
            $res['Marker'] = $this->marker;
        }
        if (null !== $this->maxKeys) {
            $res['MaxKeys'] = $this->maxKeys;
        }
        if (null !== $this->delimiter) {
            $res['Delimiter'] = $this->delimiter;
        }
        if (null !== $this->isTruncated) {
            $res['IsTruncated'] = $this->isTruncated;
        }
        if (null !== $this->encodingType) {
            $res['EncodingType'] = $this->encodingType;
        }
        if (null !== $this->commonPrefixes) {
            $res['CommonPrefixes'] = $this->commonPrefixes;
        }
        if (null !== $this->contents) {
            $res['Contents'] = [];
            if (null !== $this->contents && \is_array($this->contents)) {
                $n = 0;
                foreach ($this->contents as $item) {
                    $res['Contents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return listBucketResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Name'])) {
            $model->name = $map['Name'];
        }
        if (isset($map['Prefix'])) {
            $model->prefix = $map['Prefix'];
        }
        if (isset($map['Marker'])) {
            $model->marker = $map['Marker'];
        }
        if (isset($map['MaxKeys'])) {
            $model->maxKeys = $map['MaxKeys'];
        }
        if (isset($map['Delimiter'])) {
            $model->delimiter = $map['Delimiter'];
        }
        if (isset($map['IsTruncated'])) {
            $model->isTruncated = $map['IsTruncated'];
        }
        if (isset($map['EncodingType'])) {
            $model->encodingType = $map['EncodingType'];
        }
        if (isset($map['CommonPrefixes'])) {
            $model->commonPrefixes = $map['CommonPrefixes'];
        }
        if (isset($map['Contents'])) {
            if (!empty($map['Contents'])) {
                $model->contents = [];
                $n               = 0;
                foreach ($map['Contents'] as $item) {
                    $model->contents[$n++] = null !== $item ? contents::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
