using System;
using System.Collections.Generic;
using System.Text;

using AlibabaCloud.OSSUtil.Utils;

using Xunit;

namespace tests.Utils
{
    public class Crc64Test
    {
        [Fact]
        public void TestCrcCore()
        {
            string testStr = "This is a test.";
            byte[] content = Encoding.ASCII.GetBytes(testStr);
            Crc64 crc64 = new Crc64();
            Assert.Equal(2186167744391481992UL, crc64.Compute(content, 0, content.Length, 0));

            crc64 = new Crc64();
            Assert.Equal(2186167744391481992UL, crc64.Compute(content, 0, content.Length));
        }
    }
}
