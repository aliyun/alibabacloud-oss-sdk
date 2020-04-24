<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetObjectRequest;

use AlibabaCloud\Tea\Model;

class header extends Model
{
    /**
     * @description response-content-type
     *
     * @var string
     */
    public $responseContentType;

    /**
     * @description response-content-language
     *
     * @var string
     */
    public $responseContentLanguage;

    /**
     * @description response-expires
     *
     * @var string
     */
    public $responseExpires;

    /**
     * @description response-cache-control
     *
     * @var string
     */
    public $responseCacheControl;

    /**
     * @description response-content-disposition
     *
     * @var string
     */
    public $responseContentDisposition;

    /**
     * @description response-content-encoding
     *
     * @var string
     */
    public $responseContentEncoding;

    /**
     * @description Range
     *
     * @var string
     */
    public $range;

    /**
     * @description If-Modified-Since
     *
     * @var string
     */
    public $ifModifiedSince;

    /**
     * @description If-Unmodified-Since
     *
     * @var string
     */
    public $ifUnmodifiedSince;

    /**
     * @description If-Match
     *
     * @var string
     */
    public $ifMatch;

    /**
     * @description If-None-Match
     *
     * @var string
     */
    public $ifNoneMatch;

    /**
     * @description Accept-Encoding
     *
     * @var string
     */
    public $acceptEncoding;
    protected $_name = [
        'responseContentType'        => 'response-content-type',
        'responseContentLanguage'    => 'response-content-language',
        'responseExpires'            => 'response-expires',
        'responseCacheControl'       => 'response-cache-control',
        'responseContentDisposition' => 'response-content-disposition',
        'responseContentEncoding'    => 'response-content-encoding',
        'range'                      => 'Range',
        'ifModifiedSince'            => 'If-Modified-Since',
        'ifUnmodifiedSince'          => 'If-Unmodified-Since',
        'ifMatch'                    => 'If-Match',
        'ifNoneMatch'                => 'If-None-Match',
        'acceptEncoding'             => 'Accept-Encoding',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                                 = [];
        $res['response-content-type']        = $this->responseContentType;
        $res['response-content-language']    = $this->responseContentLanguage;
        $res['response-expires']             = $this->responseExpires;
        $res['response-cache-control']       = $this->responseCacheControl;
        $res['response-content-disposition'] = $this->responseContentDisposition;
        $res['response-content-encoding']    = $this->responseContentEncoding;
        $res['Range']                        = $this->range;
        $res['If-Modified-Since']            = $this->ifModifiedSince;
        $res['If-Unmodified-Since']          = $this->ifUnmodifiedSince;
        $res['If-Match']                     = $this->ifMatch;
        $res['If-None-Match']                = $this->ifNoneMatch;
        $res['Accept-Encoding']              = $this->acceptEncoding;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return header
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['response-content-type'])) {
            $model->responseContentType = $map['response-content-type'];
        }
        if (isset($map['response-content-language'])) {
            $model->responseContentLanguage = $map['response-content-language'];
        }
        if (isset($map['response-expires'])) {
            $model->responseExpires = $map['response-expires'];
        }
        if (isset($map['response-cache-control'])) {
            $model->responseCacheControl = $map['response-cache-control'];
        }
        if (isset($map['response-content-disposition'])) {
            $model->responseContentDisposition = $map['response-content-disposition'];
        }
        if (isset($map['response-content-encoding'])) {
            $model->responseContentEncoding = $map['response-content-encoding'];
        }
        if (isset($map['Range'])) {
            $model->range = $map['Range'];
        }
        if (isset($map['If-Modified-Since'])) {
            $model->ifModifiedSince = $map['If-Modified-Since'];
        }
        if (isset($map['If-Unmodified-Since'])) {
            $model->ifUnmodifiedSince = $map['If-Unmodified-Since'];
        }
        if (isset($map['If-Match'])) {
            $model->ifMatch = $map['If-Match'];
        }
        if (isset($map['If-None-Match'])) {
            $model->ifNoneMatch = $map['If-None-Match'];
        }
        if (isset($map['Accept-Encoding'])) {
            $model->acceptEncoding = $map['Accept-Encoding'];
        }

        return $model;
    }
}
