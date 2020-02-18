using System;
using System.Collections.Generic;
using System.Text;
using Tea;

namespace tests.Models
{
    public class ListAllMyBucketsResult : TeaModel
    {
        [NameInMap("Owner")]
        public Owner owner { get; set; }

        [NameInMap("Buckets")]
        public Buckets buckets { get; set; }

        [NameInMap("listStr")]
        public List<string> testStrList { get; set; }

        [NameInMap("Owners")]
        public List<Owner> owners { get; set; }

        public long? TestLong { get; set; }

        public short? TestShort { get; set; }

        public uint? TestUInt { get; set; }

        public ushort? TestUShort { get; set; }

        public ulong? TestULong { get; set; }

        public float? TestFloat { get; set; }

        public double? TestDouble { get; set; }

        public string TestNull { get; set; }

        public bool? TestBool { get; set; }

        public Dictionary<string, string> dict { get; set; }

        public List<string> TestListNull { get; set; }

        public class Owner : TeaModel
        {
            public int? ID { get; set; }

            public string DisplayName { get; set; }
        }

        public class Buckets : TeaModel
        {
            [NameInMap("Bucket")]
            public List<Bucket> bucket { get; set; }

            public class Bucket : TeaModel
            {
                public string CreationDate { get; set; }

                public string ExtranetEndpoint { get; set; }

                public string IntranetEndpoint { get; set; }

                public string Location { get; set; }

                public string Name { get; set; }

                public string StorageClass { get; set; }
            }
        }
    }
}
