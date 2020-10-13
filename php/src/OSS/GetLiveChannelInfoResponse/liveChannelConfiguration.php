<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelInfoResponse;

use AlibabaCloud\SDK\OSS\OSS\GetLiveChannelInfoResponse\liveChannelConfiguration\target;
use AlibabaCloud\Tea\Model;

class liveChannelConfiguration extends Model
{
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
     * @description Target
     *
     * @var target
     */
    public $target;
    protected $_name = [
        'description' => 'Description',
        'status'      => 'Status',
        'target'      => 'Target',
    ];

    public function validate()
    {
        Model::validateRequired('target', $this->target, true);
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['Description'] = $this->description;
        }
        if (null !== $this->status) {
            $res['Status'] = $this->status;
        }
        if (null !== $this->target) {
            $res['Target'] = null !== $this->target ? $this->target->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveChannelConfiguration
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Description'])) {
            $model->description = $map['Description'];
        }
        if (isset($map['Status'])) {
            $model->status = $map['Status'];
        }
        if (isset($map['Target'])) {
            $model->target = target::fromMap($map['Target']);
        }

        return $model;
    }
}
