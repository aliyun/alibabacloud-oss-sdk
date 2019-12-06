using Tea;

namespace AlibabaCloud.OSS.Models
{
    public class ErrorModel : TeaModel
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string RequestId { get; set; }

        public string HostId { get; set; }
    }

    public class ServiceError : TeaModel
    {
        public ErrorModel Error { get; set; }
    }
}
