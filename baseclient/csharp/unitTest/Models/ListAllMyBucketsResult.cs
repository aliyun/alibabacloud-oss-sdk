using System;
using System.Collections.Generic;
using System.Text;

using Tea;

namespace unitTest.Models
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

        public class Owner : TeaModel
        {
            public int ID { get; set; }

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
