using AlibabaCloud.OSS.Attributes;

using Xunit;

namespace unitTest.Attributes
{
    public class EncodeAttributeTest
    {
        [Fact]
        public void TestEncodeAttribute()
        {
            EncodeAttribute attribute = new EncodeAttribute("test");
            Assert.Equal("test", attribute.Encode);
        }
    }
}
