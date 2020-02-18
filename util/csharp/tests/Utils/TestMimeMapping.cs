using System;
using System.Collections.Generic;
using System.Text;
using AlibabaCloud.OSSUtil.Utils;
using Xunit;

namespace tests.Utils
{
    public class MimeMappingTest
    {
        [Fact]
        public void TestMimeMapping()
        {
            Assert.Equal("text/plain", MimeMapping.GetMimeMapping("test.txt"));
            Assert.Equal(string.Empty, MimeMapping.GetMimeMapping("test"));
            Assert.Equal(string.Empty, MimeMapping.GetMimeMapping("test.txt\\test"));
        }
    }
}
