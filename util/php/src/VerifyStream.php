<?php

namespace AlibabaCloud\Tea\OSSUtils;

use GuzzleHttp\Psr7\Stream;

class VerifyStream extends Stream
{
    /**
     * @var Crc64
     */
    private $crcRead;

    private $content;

    private $res = [];

    public function __construct($stream, &$res = [])
    {
        $this->crcRead = new Crc64();
        $this->res     = &$res;
        if ($stream instanceof Stream) {
            $stream->rewind();
            $stream = fopen('data://text/plain;base64,' . base64_encode($stream->getContents()), 'r');
        }
        parent::__construct($stream, []);
    }

    public function read($length)
    {
        $string = parent::read($length);
        if (!empty($string)) {
            $this->crcRead->append($string);
            $this->content .= $string;
        }

        return $string;
    }

    public function getVerify()
    {
        $this->res = [
            'md5' => base64_encode(md5($this->content, true)),
            'crc' => $this->crcRead->getValue(),
        ];

        return $this->res;
    }
}
