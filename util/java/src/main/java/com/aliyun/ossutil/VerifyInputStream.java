package com.aliyun.ossutil;


import java.io.IOException;
import java.io.InputStream;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Base64;
import java.util.Map;

public class VerifyInputStream extends InputStream {
    private InputStream inputStream;
    private Map<String, String> map;
    private CRC64 crc64 = new CRC64();
    private MessageDigest md = MessageDigest.getInstance("MD5");



    public VerifyInputStream(InputStream inputStream, Map<String, String> map) throws NoSuchAlgorithmException {
        this.inputStream = inputStream;
        this.map = map;
    }

    @Override
    public int read() throws IOException {
        return inputStream.read();
    }

    @Override
    public int read(byte[] bytes) throws IOException {
        int index = inputStream.read(bytes);
        if (index != -1) {
            crc64.update(bytes, index);
            md.update(bytes, 0, index);
        } else {
            map.put("crc", crc64.getValue());
            map.put("md5", Base64.getEncoder().encodeToString(md.digest()));
        }
        return index;
    }
}
