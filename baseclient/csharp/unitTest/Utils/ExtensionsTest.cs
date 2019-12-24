using AlibabaCloud.OSS.Utils;

using Xunit;

namespace unitTest.Utils
{
    public class ExtensionsTest
    {
        [Fact]
        public void TestToSafeString()
        {
            string strNull = null;
            Assert.Null(strNull.ToSafeString());
            Assert.Empty(strNull.ToSafeString(string.Empty));

            string strTest = "test";
            Assert.Equal("test", strTest.ToSafeString());
            Assert.Equal("test", strTest.ToSafeString(string.Empty));
        }

        [Fact]
        public void TestToSafeBool()
        {
            bool? boolNull = null;
            string test = "test";
            Assert.False(boolNull.ToSafeBool());
            Assert.True(test.ToSafeBool(true));
            Assert.False(false.ToSafeBool(true));
        }

        [Fact]
        public void TestToSafeInt32()
        {
            Assert.Null("test".ToSafeInt32());
            Assert.Equal(1, 1. ToSafeInt32());

            Assert.Equal(1, 1. ToSafeInt32(1));
            Assert.Equal(2, "test".ToSafeInt32(2));
        }
    }
}
