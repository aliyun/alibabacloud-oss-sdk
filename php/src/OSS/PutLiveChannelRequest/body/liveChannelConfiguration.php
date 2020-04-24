<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body;

use AlibabaCloud\SDK\OSS\OSS\liveChannelConfiguration\snapshot;
use AlibabaCloud\SDK\OSS\OSS\liveChannelConfiguration\target;
use AlibabaCloud\Tea\Model;

class liveChannelConfiguration extends Model
{
    /**
     * @description Target
     *
     * @var liveChannelConfiguration.target
     */
    public $target;

    /**
     * @description Snapshot
     *
     * @var liveChannelConfiguration.snapshot
     */
    public $snapshot;

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
    protected $_name = [
        'target'      => 'Target',
        'snapshot'    => 'Snapshot',
        'description' => 'Description',
        'status'      => 'Status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                = [];
        $res['Target']      = null !== $this->target ? $this->target->toMap() : null;
        $res['Snapshot']    = null !== $this->snapshot ? $this->snapshot->toMap() : null;
        $res['Description'] = $this->description;
        $res['Status']      = $this->status;

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
        if (isset($map['Target'])) {
            $model->target = liveChannelConfiguration\target::fromMap($map['Target']);
        }
        if (isset($map['Snapshot'])) {
            $model->snapshot = liveChannelConfiguration\snapshot::fromMap($map['Snapshot']);
        }
        if (isset($map['Description'])) {
            $model->description = $map['Description'];
        }
        if (isset($map['Status'])) {
            $model->status = $map['Status'];
        }

        return $model;
    }
}
