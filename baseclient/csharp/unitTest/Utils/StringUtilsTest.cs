using AlibabaCloud.OSS.Utils;

using Xunit;

namespace unitTest.Utils
{
    public class StringUtilsTest
    {
        [Fact]
        public void TestSubStringCount()
        {
            string str = "teste";
            Assert.Equal(2, StringUtils.SubStringCount(str, "te"));

            Assert.Equal(0, StringUtils.SubStringCount(str, "zz"));
        }
    }
}
