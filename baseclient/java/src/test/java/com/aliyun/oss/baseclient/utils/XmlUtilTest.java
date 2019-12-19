package com.aliyun.oss.baseclient.utils;

import org.junit.Assert;
import org.junit.Test;
import com.aliyun.oss.baseclient.utils.GetBucketResponse.*;
import java.util.Map;

public class XmlUtilTest {
    @Test
    public void testList() throws Exception{
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
        Assert.assertEquals(7,((Map) map.get("ListBucketResult")).size());
    }

    @Test
    public void mapToXml() throws Exception{
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
}
