using System.Text;

using AlibabaCloud.OSS.Utils;

using Xunit;

namespace unitTest.Utils
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
