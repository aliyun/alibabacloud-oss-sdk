<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\OSS\OSS\GetLiveChannelStatResponse\liveChannelStat;

use AlibabaCloud\Tea\Model;

class video extends Model
{
    /**
     * @description Width
     *
     * @var string
     */
    public $width;

    /**
     * @description Height
     *
     * @var string
     */
    public $height;

    /**
     * @description FrameRate
     *
     * @var string
     */
    public $frameRate;

    /**
     * @description Bandwidth
     *
     * @var string
     */
    public $bandwidth;

    /**
     * @description Codec
     *
     * @var string
     */
    public $codec;
    protected $_name = [
        'width'     => 'Width',
        'height'    => 'Height',
        'frameRate' => 'FrameRate',
        'bandwidth' => 'Bandwidth',
        'codec'     => 'Codec',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res              = [];
        $res['Width']     = $this->width;
        $res['Height']    = $this->height;
        $res['FrameRate'] = $this->frameRate;
        $res['Bandwidth'] = $this->bandwidth;
        $res['Codec']     = $this->codec;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return video
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['Width'])) {
            $model->width = $map['Width'];
        }
        if (isset($map['Height'])) {
            $model->height = $map['Height'];
        }
        if (isset($map['FrameRate'])) {
            $model->frameRate = $map['FrameRate'];
        }
        if (isset($map['Bandwidth'])) {
            $model->bandwidth = $map['Bandwidth'];
        }
        if (isset($map['Codec'])) {
            $model->codec = $map['Codec'];
        }

        return $model;
    }
}
