using Tea;

namespace unitTest.Models
{
    public class ToBodyModel : TeaModel
    {
        [NameInMap("ListAllMyBucketsResult")]
        public ListAllMyBucketsResult listAllMyBucketsResult { get; set; }

    }
}
