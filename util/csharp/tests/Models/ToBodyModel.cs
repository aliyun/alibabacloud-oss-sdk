using System;
using System.Collections.Generic;
using System.Text;
using Tea;

namespace tests.Models
{
    public class ToBodyModel : TeaModel
    {
        [NameInMap("ListAllMyBucketsResult")]
        public ListAllMyBucketsResult listAllMyBucketsResult { get; set; }

    }
}
