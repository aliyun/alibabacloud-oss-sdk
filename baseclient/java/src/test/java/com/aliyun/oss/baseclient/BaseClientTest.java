package com.aliyun.oss.baseclient;


import com.aliyun.tea.TeaRequest;
import com.aliyun.tea.TeaResponse;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.lang.reflect.Method;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.HashMap;
import java.util.Locale;
import java.util.Map;
import java.util.SimpleTimeZone;

public class BaseClientTest {
    private BaseClient client;

    @Before
    public void createBaseclient() throws Exception {
        Map<String, Object> config = new HashMap<>();
        config.put("accessKeyId","sdk_testAK");
        config.put("accessKeySecret", "sdk_testSk");
        client = new BaseClient(config);
    }

    @Test
    public void _getDateTest() throws ParseException {
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat("EEE, dd MMM yyyy HH:mm:ss zzz", Locale.US);
        simpleDateFormat.setTimeZone(new SimpleTimeZone(0, "GMT"));
        String dateString = client._getDate();
        Assert.assertNotNull(simpleDateFormat.parse(dateString));
    }

    @Test
    public void getOssSignatureTest() throws Exception {
        Class clazz = client.getClass();
        Method getOssSignature = clazz.getDeclaredMethod("getOssSignature", String.class, String.class);
        getOssSignature.setAccessible(true);
        String result = (String) getOssSignature.invoke(client, "testsk", "test");
        Assert.assertEquals("V/JNsQl6ZAnD6NSmFF3gI0QrjvLLGFTHmSDpbXqhS6o=", result);
    }

    @Test
    public void uriEncodeTest() {
        String str = "a{A[0:/_";
        String result = client.UriEncode(str, true);
        Assert.assertEquals("a%7bA%5b0%3a%2F_", result);

        result = client.UriEncode(str, false);
        Assert.assertEquals("a%7bA%5b0%3a/_", result);
    }

    @Test
    public void _getHostTest() {
        String host = client._getHost("testBucket");
        Assert.assertEquals("testBucket.oss-cn-hangzhou.aliyuncs.com", host);

        client._hostModel = "ip";
        host = client._getHost("testBucket");
        Assert.assertEquals("oss-cn-hangzhou.aliyuncs.com/testBucket", host);

        client._hostModel = "cname";
        host = client._getHost("testBucket");
        Assert.assertEquals("oss-cn-hangzhou.aliyuncs.com", host);

        host = client._getHost(null);
        Assert.assertEquals("oss-cn-hangzhou.aliyuncs.com", host);
    }

    @Test
    public void _defaultTest() {
        String result = client._default("test", "default");
        Assert.assertEquals("test", result);

        result = client._default(null, "default");
        Assert.assertEquals("default", result);

        Number number = client._defaultNumber(3, 4L);
        Assert.assertEquals(3, number);

        number = client._defaultNumber(null, 4L);
        Assert.assertEquals(4L, number);

        number = client._defaultNumber(-1, 4L);
        Assert.assertEquals(4L, number);
    }

    @Test
    public void _isFailTest() {
        TeaResponse response = new TeaResponse();
        response.statusCode = 100;
        Assert.assertFalse(client._isFail(null));
        Assert.assertTrue(client._isFail(response));

        response.statusCode = 400;
        Assert.assertTrue(client._isFail(response));

        response.statusCode = 200;
        Assert.assertFalse(client._isFail(response));
    }

    @Test
    public void _toQueryTest() throws Exception {
        Map<String, Object> query = new HashMap<>();
        query.put("test", "1");
        query.put("nulTest", null);
        Map<String, String> result = client._toQuery(null);
        Assert.assertEquals(0, result.size());

        result = client._toQuery(query);
        Assert.assertEquals("1", result.get("test"));
        Assert.assertFalse(result.containsKey("nullTest"));
    }

    @Test
    public void _toMetaTest() throws Exception {
        Map<String, String> header = new HashMap<>();
        header.put("size", "1");
        header.put("test.key.id", "9527");
        Map<String, String> result = client._toMeta(header, "test.key.");
        Assert.assertEquals("9527", result.get("test.key.id"));
        Assert.assertTrue(result.containsKey("test.key.size"));
    }

    @Test
    public void _parseMetaTest() throws Exception {
        Map<String, String> header = new HashMap<>();
        header.put("size", "1");
        header.put("test.key.id", "9527");
        Map<String, String> result = client._parseMeta(null, "test.key.");
        Assert.assertEquals(0, result.size());

        result = client._parseMeta(header, "test.key.");
        Assert.assertEquals("1", result.get("size"));
        Assert.assertTrue(result.containsKey("id"));
    }

    @Test
    public void _getContentMD5Test() throws Exception {
//        Assert.assertEquals("", client._getContentMD5(null, null, 0L));
//
//        client._isEnableMD5 = true;
//        Assert.assertEquals("test", client._getContentMD5(null, "test", 0L));
//
//        TeaRequest request = new TeaRequest();
//        Assert.assertEquals("", client._getContentMD5(request, null, 0L));
//
//        InputStream is = new ByteArrayInputStream("".getBytes("UTF-8"));
//        request.body = is;
//        Assert.assertEquals("", client._getContentMD5(request, null, 0L));
//
//        is = new ByteArrayInputStream("test".getBytes("UTF-8"));
//        request.body = is;
//        Assert.assertEquals("CY9rzUYh03PK3k6DJie09g==", client._getContentMD5(request, null, 0L));
    }

    @Test
    public void _getContentLengthTest() throws Exception{
        Assert.assertEquals("test", client._getContentLength(null, "test"));

        TeaRequest request = new TeaRequest();
        Assert.assertEquals("", client._getContentLength(request, ""));

        InputStream is = new ByteArrayInputStream("test".getBytes(TeaRequest.URL_ENCODING));
        request.body = is;
        Assert.assertEquals("4", client._getContentLength(request, ""));
    }

    @Test
    public void _getSpecialValueTest() throws Exception{
        Map<String, Object> map = new HashMap<>();
        map.put("key", "value");
        Assert.assertEquals("value", client._getSpecialValue(map, "key"));
    }

    @Test
    public void _getContentTypeTest() {
        Assert.assertEquals("image/webp", client._getContentType("test.webp"));
        Assert.assertEquals("audio/mpeg", client._getContentType("test.mp3"));
    }

    @Test
    public void _isNotCrcMatchedTest() {
        Assert.assertTrue(client._isNotCrcMatched(6L, null));
        Assert.assertTrue(client._isNotCrcMatched(6L, "8"));
        Assert.assertFalse(client._isNotCrcMatched(6L, "6"));
    }

    @Test
    public void _encodeTest() throws Exception{
        String value = "test/encode/h%f";
        Assert.assertEquals(value, client._encode(value, null));
        Assert.assertEquals("test/encode/aCVm", client._encode(value, "Base64"));
        Assert.assertEquals("test/encode/h%25f", client._encode(value, "UrlEncode"));
        Assert.assertEquals(value, client._encode(value, ""));
    }

    @Test
    public void _toHeaderTest() {
        Map<String, Object> header =  null;
        Map<String, String> result = client._toHeader(header);
        Assert.assertEquals(0, result.size());

        header = new HashMap<>();
        header.put("null", null);
        header.put("test", "test");
        result = client._toHeader(header);
        Assert.assertEquals("test", result.get("test"));
        Assert.assertFalse(result.containsKey("null"));
    }

    @Test
    public void getSignedStrV1Test() throws Exception{
//        TeaRequest request = new TeaRequest();
//        request.headers.put("test", null);
//        request.headers.put("x-oss-test", "test");
//        request.headers.put("x-oss-null", null);
//        String result = client.getSignedStrV1(request, "test", "ak", "sk");
//        Assert.assertEquals("OSS ak:ygNFWQ2CLv9m2ueZfb81BHEAF3E=", result);
//
//        request.headers.put("content-type", "type");
//        request.headers.put("content-md5", "md5");
//        result = client.getSignedStrV1(request, "test", "ak", "sk");
//        Assert.assertEquals("OSS ak:f/dRV49wgDZaP2TVcnsxrhZwudA=", result);
    }

    @Test
    public void getSignatureV1Test() throws Exception{
//        client = spy(client);
//        TeaRequest request = new TeaRequest();
//        when(client.getSignedStrV1(request, "", "ak", "sk")).thenReturn("test");
//        request.query = null;
//        request.pathname = "";
//        Assert.assertEquals("test", client.getSignatureV1(request, "", "ak", "sk"));
//
//        request.query = new HashMap<>();
//        request.query.put("location", "");
//        request.query.put("style", "test");
//        request.query.put("style123", "test");
//        request.pathname = "/pathname";
//        when(client.getSignedStrV1(request, "/bucket/pathname&style=test", "ak", "sk")).thenReturn("test");
//        Assert.assertEquals("test", client.getSignatureV1(request, "bucket", "ak", "sk"));
    }

}
