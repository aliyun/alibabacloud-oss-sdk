<?php

namespace AlibabaCloud\Tea\OSSUtils\Tests;

use AlibabaCloud\Tea\OSSUtils\Crc64;
use PHPUnit\Framework\TestCase;

/**
 * @internal
 * @coversNothing
 */
class Crc64Test extends TestCase
{
    public function testCrc64()
    {
        $crc = new Crc64();
        $crc->append('test');
        $this->assertEquals('18020588380933092773', $crc->getValue());

        $crc->append(' oss string');
        $this->assertEquals('5415765121994015315', $crc->getValue());

        $crc = new Crc64();
        $crc->append('test oss string');
        $this->assertEquals('5415765121994015315', $crc->getValue());
    }
}
