<?php

namespace AlibabaCloud\Tea\OSSUtils\Tests;

use AlibabaCloud\Tea\OSSUtils\VerifyStream;
use PHPUnit\Framework\TestCase;

/**
 * Class VerifyStreamTest.
 *
 * @internal
 * @coversNothing
 */
class VerifyStreamTest extends TestCase
{
    public function testVerifyStream()
    {
        $stream       = fopen('data://text/plain;base64,' . base64_encode('test'), 'r+');
        $verifyStream = new VerifyStream($stream);

        $verifyStream->read(1);
        $verifyStream->read(1);
        $verifyStream->read(1);
        $verifyStream->read(1);

        $verify = $verifyStream->getVerify();
        $this->assertEquals('CY9rzUYh03PK3k6DJie09g==', $verify['md5']);
        $this->assertEquals('18020588380933092773', $verify['crc']);
    }
}
