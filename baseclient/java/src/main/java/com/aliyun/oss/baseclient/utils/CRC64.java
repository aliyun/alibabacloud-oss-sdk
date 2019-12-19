package com.aliyun.oss.baseclient.utils;


import java.math.BigDecimal;

/**
 * CRC-64 implementation with ability to combine checksums calculated over
 * different blocks of data. Standard ECMA-182,
 * http://www.ecma-international.org/publications/standards/Ecma-182.htm
 */
public class CRC64 {
    // ECMA-182
    private final static long POLY = (long) 0xc96c5795d7870f42L;

    /* CRC64 calculation table. */
    private final static long[] table;

    /* Current CRC value. */
    private long value;

    static {
        table = new long[256];
        for (int n = 0; n < 256; n++) {
            long crc = n;
            for (int k = 0; k < 8; k++) {
                if ((crc & 1) == 1) {
                    crc = (crc >>> 1) ^ POLY;
                } else {
                    crc = (crc >>> 1);
                }
            }
            table[n] = crc;
        }
    }

    public CRC64() {
        this.value = 0;
    }


    public String getValue() {
        long first = (this.value >>> 1) / 5;
        long second = this.value - first * 10;
        return String.valueOf(first) + second;
    }



    /**
     * Update CRC64 with new byte block.
     **/
    public void update(byte[] b, int len) {
        for (int i = 0; i < len; i++) {
            update(b[i]);
        }
    }


    /**
     * Update CRC64 with new byte.
     **/
    public void update(byte b) {
        this.value = ~this.value;
        this.value = table[((int) (this.value ^ b)) & 0xff] ^ (this.value >>> 8);
        this.value = ~this.value;
    }


    public void reset() {
        this.value = 0;
    }

}