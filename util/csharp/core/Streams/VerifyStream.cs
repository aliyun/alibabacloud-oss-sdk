using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using AlibabaCloud.OSSUtil.Utils;

namespace AlibabaCloud.OSSUtil.Streams
{
    public class VerifyStream : Stream
    {
        private Stream _innerStream;
        private Dictionary<string, string> _ref;
        private Crc64 crc64 = new Crc64();
        private MD5 md5 = new MD5CryptoServiceProvider();

        public VerifyStream(Stream stream, Dictionary<string, string> dict)
        {
            _innerStream = stream;
            _ref = dict;
        }

        public override bool CanRead
        {
            get
            {
                return _innerStream.CanRead;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return _innerStream.CanSeek;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return _innerStream.CanWrite;
            }
        }

        public override long Length
        {
            get
            {
                return _innerStream.Length;
            }
        }

        public override long Position
        {
            get
            {
                return _innerStream.Position;
            }

            set
            {
                _innerStream.Position = value;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int index = _innerStream.Read(buffer, offset, count);
            if (index > 0)
            {
                crc64.Compute(buffer, 0, index);
                md5.TransformBlock(buffer, offset, index, buffer, 0);
            }
            else
            {
                md5.TransformFinalBlock(buffer, offset, 0);
                _ref["md5"] = Convert.ToBase64String(md5.Hash);
                _ref["crc"] = crc64.CrcValue.ToSafeString();
            }
            return index;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _innerStream.Seek(offset, origin);
        }

        public override void Flush()
        {
            _innerStream.Flush();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

    }
}
