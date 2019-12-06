package com.oss.baseclient;

import com.aliyun.credentials.exception.CredentialException;
import com.aliyun.tea.NameInMap;
import com.aliyun.tea.TeaModel;
import org.junit.Assert;
import org.junit.Test;

import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;

public class BaseClientTest {
    @Test
    public void getDateTest() throws ParseException, IOException, CredentialException {

        BaseClient client = new BaseClient(null);
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat("EEE, dd MMM yyyy HH:mm:ss zzz", Locale.US);
        Assert.assertNotNull(simpleDateFormat.parse(client._getDate()));
        String url = "http://www.baidu.com?rqw/wqewqe/wqeqwe/wqeq-w2*ewq";
    }

    public class CallbackRequest extends TeaModel {
        @NameInMap("test_ss")
        public ToBodyTest toBodyTest;
    }

    public class ToBodyTest extends TeaModel {
        @NameInMap("BucketName")
        public List bucketName;
    }

    @Test
    public void toBodyTest() throws Exception {
        BaseClient client = new BaseClient(null);
        CallbackRequest callbackRequest = new CallbackRequest();
        List<String> list = new ArrayList();
        list.add("a");
        list.add("b");
        ToBodyTest toBodyTest = new ToBodyTest();
        toBodyTest.bucketName = list;
        callbackRequest.toBodyTest = toBodyTest;
    }
}
