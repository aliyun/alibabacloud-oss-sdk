package com.aliyun.oss.baseclient.utils;

import org.junit.Assert;
import org.junit.Test;
import com.aliyun.oss.baseclient.utils.GetBucketResponse.*;

import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

public class XmlUtilTest {

    @Test
    public void testList() throws Exception {
        String xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                "<ListBucketResult>\n" +
                "  <Name>sdk-script</Name>\n" +
                "  <Prefix></Prefix>\n" +
                "  <Marker></Marker>\n" +
                "  <MaxKeys>100</MaxKeys>\n" +
                "  <Delimiter></Delimiter>\n" +
                "  <IsTruncated>false</IsTruncated>\n" +
                "  <Contents>\n" +
                "    <Key>run.sh</Key>\n" +
                "    <LastModified>2019-11-18T07:18:33.000Z</LastModified>\n" +
                "    <ETag>\"7FEEB4D16A1095FC5FAFFC6B5DA5A5B7\"</ETag>\n" +
                "    <Type>Normal</Type>\n" +
                "    <Size>4527</Size>\n" +
                "    <StorageClass>Standard</StorageClass>\n" +
                "    <Owner>\n" +
                "      <ID>1325847523475998</ID>\n" +
                "      <DisplayName>1325847523475998</DisplayName>\n" +
                "    </Owner>\n" +
                "  </Contents>\n" +
                "  <Contents>\n" +
                "    <Key>task.sh</Key>\n" +
                "    <LastModified>2019-11-18T07:18:27.000Z</LastModified>\n" +
                "    <ETag>\"094ACA03805A13CB8FE559A6DF615E3A\"</ETag>\n" +
                "    <Type>Normal</Type>\n" +
                "    <Size>603</Size>\n" +
                "    <StorageClass>Standard</StorageClass>\n" +
                "    <Owner>\n" +
                "      <ID>1325847523475998</ID>\n" +
                "      <DisplayName>1325847523475998</DisplayName>\n" +
                "    </Owner>\n" +
                "  </Contents>\n" +
                "</ListBucketResult>";
        Map map = XmlUtil.DeserializeXml(xml, GetBucketResponse.class);
        Assert.assertEquals(7, ((Map) map.get("ListBucketResult")).size());
    }

    @Test
    public void mapToXml() throws Exception {
        Body body = new Body();
        GetBucketResponseListBucketResult result = new GetBucketResponseListBucketResult();
        GetBucketResponseListBucketResultContents contents = new GetBucketResponseListBucketResultContents();
        GetBucketResponseListBucketResultContents contents2 = new GetBucketResponseListBucketResultContents();
        GetBucketResponseListBucketResultContentsOwner owner = new GetBucketResponseListBucketResultContentsOwner();
        owner.displayName = "disName";
        contents.owner = owner;
        contents.key = "key";
        result.contents = new GetBucketResponseListBucketResultContents[]{contents, contents2};
        body.contents = result;
        Map<String, Object> map = body.toMap();
        String xml = XmlUtil.mapToXml(map);
        Assert.assertEquals("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                "<body><Contents><Owner><DisplayName>disName</DisplayName></Owner><Key>key</Key></Contents><Contents/></body>", xml);
    }

    @Test
    public void castTypeTest() throws Exception {
        XmlUtil xmlUtil = new XmlUtil();
        Method castType = xmlUtil.getClass().getDeclaredMethod("castType", Class.class, String.class);
        castType.setAccessible(true);
        Assert.assertTrue((boolean) castType.invoke(xmlUtil, boolean.class, "true"));
        Assert.assertTrue((Boolean) castType.invoke(xmlUtil, Boolean.class, "true"));

        Assert.assertEquals(1, (int) castType.invoke(xmlUtil, int.class, "1"));
        Assert.assertEquals(1, (int) castType.invoke(xmlUtil, Integer.class, "1"));

        Assert.assertEquals(1L, (long) castType.invoke(xmlUtil, long.class, "1"));
        Assert.assertEquals(1L, (long) castType.invoke(xmlUtil, Long.class, "1"));
    }

    @Test
    public void mapToXmlTest() throws Exception{
        Assert.assertEquals("", XmlUtil.mapToXml(null));
        Map<String, Object> map = new HashMap<>();
        Assert.assertEquals("", XmlUtil.mapToXml(map));

        map.put("1", null);
        map.put("2", null);
        try {
            XmlUtil.mapToXml(map);
            Assert.fail();
        } catch (Exception e) {
            Assert.assertEquals("This map does not have a unique root tag", e.getMessage());
        }


    }
}
