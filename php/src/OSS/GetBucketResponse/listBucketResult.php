<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetBucketResponse;

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
     * @var array
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
        $res                   = [];
        $res['Name']           = $this->name;
        $res['Prefix']         = $this->prefix;
        $res['Marker']         = $this->marker;
        $res['MaxKeys']        = $this->maxKeys;
        $res['Delimiter']      = $this->delimiter;
        $res['IsTruncated']    = $this->isTruncated;
        $res['EncodingType']   = $this->encodingType;
        $res['CommonPrefixes'] = $this->commonPrefixes;
        $res['Contents']       = [];
        if (null !== $this->contents && \is_array($this->contents)) {
            $n = 0;
            foreach ($this->contents as $item) {
                $res['Contents'][$n++] = null !== $item ? $item->toMap() : $item;
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
                    $model->contents[$n++] = null !== $item ? GetBucketResponse\listBucketResult\contents::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
