<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse\listLiveChannelResult;

use AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse\listLiveChannelResult\liveChannel\playUrls;
use AlibabaCloud\SDK\OSS\OSS\ListLiveChannelResponse\listLiveChannelResult\liveChannel\publishUrls;
use AlibabaCloud\Tea\Model;

class liveChannel extends Model
{
    /**
     * @description Name
     *
     * @var string
     */
    public $name;

    /**
     * @description Description
     *
     * @var string
     */
    public $description;

    /**
     * @description Status
     *
     * @var string
     */
    public $status;

    /**
     * @description LastModified
     *
     * @var string
     */
    public $lastModified;

    /**
     * @description PublishUrls
     *
     * @var publishUrls
     */
    public $publishUrls;

    /**
     * @description PlayUrls
     *
     * @var playUrls
     */
    public $playUrls;
    protected $_name = [
        'name'         => 'Name',
        'description'  => 'Description',
        'status'       => 'Status',
        'lastModified' => 'LastModified',
        'publishUrls'  => 'PublishUrls',
        'playUrls'     => 'PlayUrls',
    ];

    public function validate()
    {
        Model::validateRequired('publishUrls', $this->publishUrls, true);
        Model::validateRequired('playUrls', $this->playUrls, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['Name']         = $this->name;
        $res['Description']  = $this->description;
        $res['Status']       = $this->status;
        $res['LastModified'] = $this->lastModified;
        $res['PublishUrls']  = null !== $this->publishUrls ? $this->publishUrls->toMap() : null;
        $res['PlayUrls']     = null !== $this->playUrls ? $this->playUrls->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveChannel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Name'])) {
            $model->name = $map['Name'];
        }
        if (isset($map['Description'])) {
            $model->description = $map['Description'];
        }
        if (isset($map['Status'])) {
            $model->status = $map['Status'];
        }
        if (isset($map['LastModified'])) {
            $model->lastModified = $map['LastModified'];
        }
        if (isset($map['PublishUrls'])) {
            $model->publishUrls = publishUrls::fromMap($map['PublishUrls']);
        }
        if (isset($map['PlayUrls'])) {
            $model->playUrls = playUrls::fromMap($map['PlayUrls']);
        }

        return $model;
    }
}
