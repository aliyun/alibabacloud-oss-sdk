using AlibabaCloud.OSS.Utils;

using Xunit;

namespace unitTest.Utils
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
