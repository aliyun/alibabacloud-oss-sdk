package com.aliyun.oss.baseclient;


import com.aliyun.credentials.exception.CredentialException;
import com.aliyun.oss.baseclient.io.VerifyInputStream;
import com.aliyun.tea.TeaRequest;
import com.aliyun.tea.TeaResponse;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.lang.reflect.Method;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.HashMap;
import java.util.Locale;
import java.util.Map;
import java.util.SimpleTimeZone;

import static org.mockito.Mockito.mock;
import static org.mockito.Mockito.spy;
import static org.mockito.Mockito.when;

public class BaseClientTest {
    private BaseClient client;

    @Before
    public void createBaseclient() throws Exception {
        Map<String, Object> config = new HashMap<>();
        config.put("accessKeyId", "sdk_testAK");
        config.put("accessKeySecret", "sdk_testSk");
        client = new BaseClient(config);
    }

    @Test
    public void baseClientTest() throws ParseException, CredentialException, IOException {
        Map<String, Object> config = new HashMap<>();
        config.put("accessKeyId", "sdk_testAK");
        config.put("accessKeySecret", "sdk_testSk");
        config.put("securityToken", "sdk_testToken");
        config.put("hostModel", "hostModel");
        BaseClient client = new BaseClient(config);
        Assert.assertEquals("sdk_testToken", client._getSecurityToken());
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
        Assert.assertEquals("CY9rzUYh03PK3k6DJie09g==", client._getContentMD5("test"));
    }

    @Test
    public void _getContentLengthTest() throws Exception {
        Assert.assertEquals("test", client._getContentLength(null, "test"));

        TeaRequest request = new TeaRequest();
        Assert.assertEquals("", client._getContentLength(request, ""));

        InputStream is = new ByteArrayInputStream("test".getBytes(TeaRequest.URL_ENCODING));
        request.body = is;
        Assert.assertEquals("4", client._getContentLength(request, ""));
    }

    @Test
    public void _getSpecialValueTest() throws Exception {
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
    public void _encodeTest() throws Exception {
        String value = "test/encode/h%f";
        Assert.assertEquals(value, client._encode(value, null));
        Assert.assertEquals("test/encode/aCVm", client._encode(value, "Base64"));
        Assert.assertEquals("test/encode/h%25f", client._encode(value, "UrlEncode"));
        Assert.assertEquals(value, client._encode(value, ""));
    }

    @Test
    public void _toHeaderTest() {
        Map<String, Object> header = null;
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
    public void getSignedStrV1Test() throws Exception {
        TeaRequest request = new TeaRequest();
        request.headers.put("test", null);
        request.headers.put("x-oss-test", "test");
        request.headers.put("x-oss-null", null);
        String result = client.getSignedStrV1(request, "test", "sk");
        Assert.assertEquals("ygNFWQ2CLv9m2ueZfb81BHEAF3E=", result);

        request.headers.put("content-type", "type");
        request.headers.put("content-md5", "md5");
        result = client.getSignedStrV1(request, "test", "sk");
        Assert.assertEquals("f/dRV49wgDZaP2TVcnsxrhZwudA=", result);
    }

    @Test
    public void _getSignatureV1Test() throws Exception {
        client = spy(client);
        TeaRequest request = new TeaRequest();
        when(client.getSignedStrV1(request, "", "sk")).thenReturn("test");
        request.query = null;
        request.pathname = "";
        Assert.assertEquals("test", client._getSignatureV1(request, "", "sk"));

        request.query = new HashMap<>();
        request.query.put("location", "");
        request.query.put("style", "test");
        request.query.put("style123", "test");
        request.pathname = "/pathname";
        when(client.getSignedStrV1(request, "/bucket/pathname&style=test", "sk")).thenReturn("test");
        Assert.assertEquals("test", client._getSignatureV1(request, "bucket", "sk"));
    }

    @Test
    public void _getSignatureV2Test() throws Exception {
        client = spy(client);
        String[] strs = new String[]{};
        TeaRequest request = new TeaRequest();
        when(client.getSignedStrV2(request, "", "sk", strs)).thenReturn("test");
        request.query = null;
        request.pathname = "";
        String result = client._getSignatureV2(request, "", "sk", strs);
        Assert.assertEquals("test", result);

        request.query = new HashMap<>();
        request.query.put("location", "");
        request.query.put("style", "test");
        request.query.put("style123", "test");
        request.pathname = "/pathname";
        when(client.getSignedStrV2(request, "%2Fbucket%2Fpathname?location&style=test&style123=test",
                "sk", strs)).thenReturn("test");
        Assert.assertEquals("test", client._getSignatureV2(request, "bucket", "sk", strs));

        request.query = new HashMap<>();
        request.query.put("location", "");
        request.query.put("astyle", "test");
        request.query.put("style123", "test");
        request.pathname = "/pathname?test";
        when(client.getSignedStrV2(request, "%2Fbucket%2Fpathname?astyle=test&location&style123=test&test",
                "sk", strs)).thenReturn("test");
        result = client._getSignatureV2(request, "bucket", "sk", strs);
        Assert.assertEquals("test", result);
    }

    @Test
    public void getSignedStrV2Test() throws Exception {
        TeaRequest request = new TeaRequest();
        request.headers.put("test", null);
        request.headers.put("x-oss-test", "test");
        request.headers.put("content-type", "type");
        request.headers.put("content-md5", "md5");
        String result = client.getSignedStrV2(request, "test", "sk", null);
        Assert.assertEquals("cSdiUt1HD21QgIYqERpup+57K1h8moGaukJLi10iv4s=", result);

        result = client.getSignedStrV2(request, "test", "sk", new String[]{"x-oss-test"});
        Assert.assertEquals("xDr7V4PN0qA+luvrzusMVY0tfeTqD5U3dpLYfB5WxKY=", result);
    }

    @Test
    public void _getErrMessageTest() throws Exception {
        String errMessage = "<?xml version='1.0' encoding='UTF-8'?><Error><Code>401</Code></Error>";
        Map result = client._getErrMessage(errMessage);
        Assert.assertEquals("401", result.get("Code"));

        errMessage = "<?xml version='1.0' encoding='UTF-8'?><Code>401</Code>";
        result = client._getErrMessage(errMessage);
        Assert.assertEquals(0, result.size());
    }

    @Test
    public void _readAsStreamTest() throws IOException {
        TeaResponse teaResponse = mock(TeaResponse.class);
        when(teaResponse.getResponse()).thenReturn(new ByteArrayInputStream("".getBytes()));
        when(teaResponse.getResponseBody()).thenReturn("test");
        Assert.assertNotNull(client._readAsStream(teaResponse));
        Assert.assertEquals("test", client._readAsString(teaResponse));

        Assert.assertNull(client._readAsStream(null));
    }

    @Test
    public void _getUserAgentTest() {
        Assert.assertTrue(client._getUserAgent().contains("oss-baseClient"));
        Assert.assertTrue(client._getUserAgent("test").contains("test"));
    }

    @Test
    public void _toXMLTest() throws Exception {
        Map<String, Object> map = new HashMap<>();
        map.put("test", "000");
        Assert.assertEquals("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                "<test>000</test>", client._toXML(map));
    }

    @Test
    public void _emptyTest() {
        Object object = null;
        Assert.assertTrue(client._empty(object));

        object = "12";
        Assert.assertFalse(client._empty(object));
    }

    @Test
    public void _notNullTest() {
        Map<String, Object> map = new HashMap<>();
        map.put("test", null);
        Assert.assertTrue(client._notNull(map));

        map.clear();
        Assert.assertFalse(client._notNull(map));

        map = null;
        Assert.assertFalse(client._notNull(map));
    }

    @Test
    public void _ifListEmptyTest() {
        String[] strs = null;
        Assert.assertTrue(client._ifListEmpty(strs));

        strs = new String[]{};
        Assert.assertTrue(client._ifListEmpty(strs));

        strs = new String[]{"test"};
        Assert.assertFalse(client._ifListEmpty(strs));
    }

    @Test
    public void _equalTest() {
        Assert.assertFalse(client._equal("1", "2"));
    }

    @Test
    public void _getAccessKeyIDTest() {
        Assert.assertEquals("sdk_testAK", client._getAccessKeyID());
        Assert.assertEquals("sdk_testSk", client._getAccessKeySecret());
    }

    @Test
    public void _injectTest() throws Exception{
        Assert.assertTrue(client._inject(null, null) instanceof VerifyInputStream);
    }

    @Test
    public void _listToStringTest() throws Exception{
        String[] strs = new String[]{"1", "2", "3"};
        Assert.assertEquals("1;2;3", client._listToString(strs, ";"));
    }
}
