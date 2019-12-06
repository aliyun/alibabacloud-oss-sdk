using System;

namespace AlibabaCloud.OSS.Attributes
{
    internal class EncodeAttribute : Attribute
    {
        internal string Encode { get; set; }

        internal EncodeAttribute(string encode)
        {
            Encode = encode;
        }
    }
}
