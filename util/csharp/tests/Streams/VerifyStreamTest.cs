using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AlibabaCloud.OSSUtil.Streams;
using Xunit;

namespace tests.Streams
{
    public class VerifyStreamTest
    {
        VerifyStream vStream;
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public VerifyStreamTest()
        {
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes("test"));
            vStream = new VerifyStream(stream, dict);
        }

        [Fact]
        public void TestVerifyStream()
        {
            Assert.True(vStream.CanRead);
            Assert.True(vStream.CanSeek);
            Assert.False(vStream.CanTimeout);
            Assert.True(vStream.CanWrite);
            Assert.Equal(4, vStream.Length);
            Assert.Equal(0, vStream.Position);

            byte[] buffer = new byte[4];
            vStream.Read(buffer, 0, buffer.Length);
            Assert.NotEqual(0, buffer[0]);

            buffer = new byte[4];
            vStream.Read(buffer, 0, buffer.Length);
            Assert.Equal(0, buffer[0]);
            Assert.Equal("CY9rzUYh03PK3k6DJie09g==", dict["md5"]);
            Assert.Equal("18020588380933092773", dict["crc"]);

            vStream.Position = 1;
            Assert.Equal(1, vStream.Position);

            vStream.Seek(0, SeekOrigin.Begin);
            Assert.Equal(0, vStream.Position);

            Assert.Throws<NotImplementedException>(() => { vStream.Write(buffer, 0, buffer.Length); });

            Assert.Throws<NotImplementedException>(() => { vStream.SetLength(4); });

            vStream.Flush();
            Assert.NotNull(vStream);
        }
    }
}
