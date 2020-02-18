using System;
using System.Collections.Generic;
using System.Text;
using AlibabaCloud.OSSUtil.Utils;
using Xunit;

namespace tests.Utils
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
