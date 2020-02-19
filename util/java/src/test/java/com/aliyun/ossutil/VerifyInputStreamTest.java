package com.aliyun.ossutil;

import com.aliyun.tea.TeaRequest;
import org.junit.Assert;
import org.junit.Test;

import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.util.HashMap;
import java.util.Map;

public class VerifyInputStreamTest {

    @Test
    public void read() throws Exception {
        InputStream is = new ByteArrayInputStream("test".getBytes(TeaRequest.URL_ENCODING));
        Map<String, String> map = new HashMap<>();
        VerifyInputStream verifyInputStream = new VerifyInputStream(is, map);
        Assert.assertEquals("t", new String(new byte[]{(byte) verifyInputStream.read()}));

        is.reset();
        byte[] bytes = new byte[4];
        Assert.assertEquals(4, verifyInputStream.read(bytes));
        Assert.assertEquals(-1, verifyInputStream.read(bytes));
        Assert.assertEquals("18020588380933092773", map.get("crc"));
        Assert.assertEquals("CY9rzUYh03PK3k6DJie09g==", map.get("md5"));
    }
}
