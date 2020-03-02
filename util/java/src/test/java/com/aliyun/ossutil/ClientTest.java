package com.aliyun.ossutil;

import com.aliyun.tea.TeaRequest;
import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ClientTest {

    @Test
    public void getErrMessageTest() throws Exception {
        String errMessage = "<?xml version='1.0' encoding='UTF-8'?><Error><Code>401</Code></Error>";
        Map result = Client.getErrMessage(errMessage);
        Assert.assertEquals("401", result.get("Code"));

        errMessage = "<?xml version='1.0' encoding='UTF-8'?><Code>401</Code>";
        result = Client.getErrMessage(errMessage);
        Assert.assertEquals(0, result.size());
    }

    @Test
    public void toQueryTest() throws Exception {
        Map<String, Object> query = new HashMap<>();
        query.put("test", "1");
        query.put("nulTest", null);
        Map<String, String> result = Client.toQuery(null);
        Assert.assertEquals(0, result.size());

        result = Client.toQuery(query);
        Assert.assertEquals("1", result.get("test"));
        Assert.assertFalse(result.containsKey("nullTest"));
    }

    @Test
    public void toMetaTest() throws Exception {
        Map<String, String> header = new HashMap<>();
        header.put("size", "1");
        header.put("test.key.id", "9527");
        Map<String, String> result = Client.toMeta(header, "test.key.");
        Assert.assertEquals("9527", result.get("test.key.id"));
        Assert.assertTrue(result.containsKey("test.key.size"));
    }

    @Test
    public void parseMetaTest() throws Exception {
        Map<String, String> header = new HashMap<>();
        header.put("size", "1");
        header.put("test.key.id", "9527");
        Map<String, String> result = Client.parseMeta(null, "test.key.");
        Assert.assertEquals(0, result.size());

        result = Client.parseMeta(header, "test.key.");
        Assert.assertEquals("1", result.get("size"));
        Assert.assertTrue(result.containsKey("id"));
    }

    @Test
    public void getContentTypeTest() throws Exception {
        Assert.assertEquals("image/webp", Client.getContentType("test.webp"));
        Assert.assertEquals("audio/mpeg", Client.getContentType("test.mp3"));
    }

    @Test
    public void getContentMD5Test() throws Exception {
        Assert.assertEquals("CY9rzUYh03PK3k6DJie09g==", Client.getContentMD5("test", true));
    }

    @Test
    public void encodeTest() throws Exception {
        String value = "test/encode/h%f";
        Assert.assertEquals(value, Client.encode(value, null));
        Assert.assertEquals("test/encode/aCVm", Client.encode(value, "Base64"));
        Assert.assertEquals("test/encode/h%25f", Client.encode(value, "UrlEncode"));
        Assert.assertEquals(value, Client.encode(value, ""));
    }

    @Test
    public void getUserAgentTest() throws Exception {
        Assert.assertTrue(Client.getUserAgent(null).contains("oss-baseClient"));
        Assert.assertTrue(Client.getUserAgent("test").contains("test"));
    }

    @Test
    public void getHostTest() throws Exception {
        String host = Client.getHost(null, null, null, null);
        Assert.assertEquals("oss-cn-hangzhou.aliyuncs.com", host);

        host = Client.getHost("testBucket", "region", "endpoint", "ip");
        Assert.assertEquals("endpoint/testBucket", host);

        host = Client.getHost("testBucket", "region", "endpoint", "cname");
        Assert.assertEquals("endpoint", host);

        host = Client.getHost("testBucket", "region", "endpoint", "test");
        Assert.assertEquals("testBucket.endpoint", host);
    }

    @Test
    public void injectTest() throws Exception {
        Assert.assertTrue(Client.inject(null, null) instanceof VerifyInputStream);
    }

    @Test
    public void getSignatureTest() throws Exception {
        TeaRequest teaRequest = new TeaRequest();
        String signatrue = Client.getSignature(teaRequest, "bucket", "accessKeyId",
                "accessKeySecret", "v2", null);
        Assert.assertEquals("OSS2 AccessKeyId:accessKeyId,Signature:MdD5Jc6O4yPMls3qSI8jFayeu6IDUKp3VqQ2gt+85Bs=", signatrue);

        List<String> list= new ArrayList<>();
        list.add("test");
        signatrue = Client.getSignature(teaRequest, "bucket", "accessKeyId",
                "accessKeySecret", "v2", list);
        Assert.assertEquals("OSS2 AccessKeyId:accessKeyId,AdditionalHeaders:test,Signature:aZtDGEXEuLKsRdVEobwgwHFFigr7cXJL2OAHGoTTEyI=", signatrue);


        signatrue = Client.getSignature(teaRequest, "bucket", "accessKeyId",
                "accessKeySecret", "v1", list);
        Assert.assertEquals("OSS accessKeyId:mE03/sQeasKAx4nd4Ts8NvgM4hI=", signatrue);


    }

    @Test
    public void getSignatureV1Test() throws Exception {
        TeaRequest request = new TeaRequest();
        request.query.put("location", null);
        request.query.put("cname", "test");
        request.query.put("v1Test", "test");
        String result = Client.getSignatureV1(request, "", "sk");
        Assert.assertEquals("6bSkMhPKt+PPdWsWAj99icsT9D8=", result);

        request.query =null;
        result = Client.getSignatureV1(request, "", "sk");
        Assert.assertEquals("YodJISUIyMNwbw2REI/CUIVZcxU=", result);
    }

    @Test
    public void decodeTest() throws Exception{
        String result = Client.decode("test", null);
        Assert.assertEquals("test", result);

        result = Client.decode("test/url", "Base64Decode");
        Assert.assertEquals("test/dXJs", result);

        result = Client.decode("test/url", "UrlDecode");
        Assert.assertEquals("test/url", result);

        result = Client.decode("test/url", "test");
        Assert.assertEquals("test/url", result);
    }

    @Test
    public void getSignedStrV1Test() throws Exception {
        TeaRequest request = new TeaRequest();
        request.headers.put("test", null);
        request.headers.put("x-oss-test", "test");
        request.headers.put("x-oss-null", null);
        String result = Client.getSignedStrV1(request, "test", "sk");
        Assert.assertEquals("ygNFWQ2CLv9m2ueZfb81BHEAF3E=", result);

        request.headers.put("content-type", "type");
        request.headers.put("content-md5", "md5");
        result = Client.getSignedStrV1(request, "test", "sk");
        Assert.assertEquals("f/dRV49wgDZaP2TVcnsxrhZwudA=", result);
    }


    @Test
    public void getSignatureV2Test() throws Exception {
        TeaRequest request = new TeaRequest();
        request.query.put("query", "test");
        request.pathname = "/test?path=a";
        String result = Client.getSignatureV2(request, "", "accessKeySecret", new String[]{"test"});
        Assert.assertEquals("BGAaTdIk3qLl1be3h9Pg5qqNFZBBGTxbv8fOdKh+o4w=", result);

        request.query.put("path", "test");
        request.query.remove("query");
        result = Client.getSignatureV2(request, "", "accessKeySecret", new String[]{"test"});
        Assert.assertEquals("AcpwaCW8AZWfYcF8qctREcWADLC5T4KJLMj7rGL21/E=", result);

        request.pathname = "/test";
        result = Client.getSignatureV2(request, "", "accessKeySecret", new String[]{"test"});
        Assert.assertEquals("OfwHiRZVnh9bbzsj1QMKvcyq4uGn49oprpdF0m/PMJA=", result);

        request.query = null;
        result = Client.getSignatureV2(request, "", "accessKeySecret", new String[]{"test"});
        Assert.assertEquals("7Wv984vfRYyHI7vaV/NUXVwez4s5u871gju0gTzyi2A=", result);

    }

    @Test
    public void uriEncodeTest() {
        String str = "a{A[0:/_";
        String result = Client.UriEncode(str, true);
        Assert.assertEquals("a%7bA%5b0%3a%2F_", result);

        result = Client.UriEncode(str, false);
        Assert.assertEquals("a%7bA%5b0%3a/_", result);
    }

    @Test
    public void getSignedStrV2Test() throws Exception {
        TeaRequest request = new TeaRequest();
        request.headers.put("test", null);
        request.headers.put("x-oss-test", "test");
        request.headers.put("content-type", "type");
        request.headers.put("content-md5", "md5");
        String result = Client.getSignedStrV2(request, "test", "sk", null);
        Assert.assertEquals("cSdiUt1HD21QgIYqERpup+57K1h8moGaukJLi10iv4s=", result);

        result = Client.getSignedStrV2(request, "test", "sk", new String[]{"x-oss-test"});
        Assert.assertEquals("xDr7V4PN0qA+luvrzusMVY0tfeTqD5U3dpLYfB5WxKY=", result);
    }

    @Test
    public void ifListEmptyTest() {
        List<String> strs = null;
        Assert.assertTrue(Client.ifListEmpty(strs));

        strs = new ArrayList<>();
        Assert.assertTrue(Client.ifListEmpty(strs));

        strs .add("test");
        Assert.assertFalse(Client.ifListEmpty(strs));
    }

}
