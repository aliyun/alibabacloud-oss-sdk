<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body;

use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body\liveChannelConfiguration\snapshot;
use AlibabaCloud\SDK\OSS\OSS\PutLiveChannelRequest\body\liveChannelConfiguration\target;
use AlibabaCloud\Tea\Model;

class liveChannelConfiguration extends Model
{
    /**
     * @description Target
     *
     * @var target
     */
    public $target;

    /**
     * @description Snapshot
     *
     * @var snapshot
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
        $res = [];
        if (null !== $this->target) {
            $res['Target'] = null !== $this->target ? $this->target->toMap() : null;
        }
        if (null !== $this->snapshot) {
            $res['Snapshot'] = null !== $this->snapshot ? $this->snapshot->toMap() : null;
        }
        if (null !== $this->description) {
            $res['Description'] = $this->description;
        }
        if (null !== $this->status) {
            $res['Status'] = $this->status;
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
        if (isset($map['Target'])) {
            $model->target = target::fromMap($map['Target']);
        }
        if (isset($map['Snapshot'])) {
            $model->snapshot = snapshot::fromMap($map['Snapshot']);
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
