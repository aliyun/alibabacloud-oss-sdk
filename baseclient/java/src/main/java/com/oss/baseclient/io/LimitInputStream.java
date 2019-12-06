package com.oss.baseclient.io;

import java.io.IOException;
import java.io.InputStream;

public class LimitInputStream extends InputStream {
    private InputStream inputStream;
    private int speed;

    public LimitInputStream(InputStream inputStream, int speed) {
        this.inputStream = inputStream;
        this.speed = speed;
    }

    @Override
    public int read() throws IOException {
        return inputStream.read();
    }

    @Override
    public int read(byte[] bytes) throws IOException {
        int lenght = bytes.length;
        try {
            Thread.sleep(speed * 1000 / (lenght >>> 10));
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return inputStream.read(bytes);
    }
}
