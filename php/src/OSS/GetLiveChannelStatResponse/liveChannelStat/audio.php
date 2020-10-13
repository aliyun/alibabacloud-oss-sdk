<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse\liveChannelStat;

use AlibabaCloud\Tea\Model;

class audio extends Model
{
    /**
     * @description Bandwidth
     *
     * @var string
     */
    public $bandwidth;

    /**
     * @description SampleRate
     *
     * @var string
     */
    public $sampleRate;

    /**
     * @description Codec
     *
     * @var string
     */
    public $codec;
    protected $_name = [
        'bandwidth'  => 'Bandwidth',
        'sampleRate' => 'SampleRate',
        'codec'      => 'Codec',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bandwidth) {
            $res['Bandwidth'] = $this->bandwidth;
        }
        if (null !== $this->sampleRate) {
            $res['SampleRate'] = $this->sampleRate;
        }
        if (null !== $this->codec) {
            $res['Codec'] = $this->codec;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return audio
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Bandwidth'])) {
            $model->bandwidth = $map['Bandwidth'];
        }
        if (isset($map['SampleRate'])) {
            $model->sampleRate = $map['SampleRate'];
        }
        if (isset($map['Codec'])) {
            $model->codec = $map['Codec'];
        }

        return $model;
    }
}
