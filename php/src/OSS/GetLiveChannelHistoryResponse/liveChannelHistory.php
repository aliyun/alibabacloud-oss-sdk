<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelHistoryResponse;

use AlibabaCloud\Tea\Model;

class liveChannelHistory extends Model
{
    /**
     * @description LiveRecord
     *
     * @var array
     */
    public $liveRecord;
    protected $_name = [
        'liveRecord' => 'LiveRecord',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res               = [];
        $res['LiveRecord'] = [];
        if (null !== $this->liveRecord && \is_array($this->liveRecord)) {
            $n = 0;
            foreach ($this->liveRecord as $item) {
                $res['LiveRecord'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveChannelHistory
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['LiveRecord'])) {
            if (!empty($map['LiveRecord'])) {
                $model->liveRecord = [];
                $n                 = 0;
                foreach ($map['LiveRecord'] as $item) {
                    $model->liveRecord[$n++] = null !== $item ? GetLiveChannelHistoryResponse\liveChannelHistory\liveRecord::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
