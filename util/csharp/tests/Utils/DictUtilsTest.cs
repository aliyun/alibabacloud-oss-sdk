using System;
using System.Collections.Generic;
using System.Text;
using AlibabaCloud.OSSUtil.Utils;
using Xunit;

namespace tests.Utils
{
    public class DictUtilsTest
    {
        [Fact]
        public void TestGetDicValue()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("testKey", 1);
            Assert.Null(DictUtils.GetDicValue(dict, "testNull"));
            Assert.Equal(1, DictUtils.GetDicValue(dict, "testKey"));

            Dictionary<string, string> dictStr = new Dictionary<string, string>();
            dictStr.Add("testKey", "testValue");
            Assert.Null(DictUtils.GetDicValue(dictStr, "testNull"));
            Assert.Equal("testValue", DictUtils.GetDicValue(dictStr, "testKey"));
        }
    }
}
