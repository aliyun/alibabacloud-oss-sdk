using System;
using System.Collections.Generic;
using System.Text;
using AlibabaCloud.OSSUtil.Models;
using Xunit;

namespace tests.Models
{
    public class ServiceErrorTest
    {
        [Fact]
        public void TestServiceError()
        {
            ServiceError serviceError = new ServiceError();
            ErrorModel error = new ErrorModel();
            error.Code = "code";
            error.HostId = "hostId";
            error.Message = "message";
            error.RequestId = "requestId";
            serviceError.Error = error;
            Assert.NotNull(serviceError);
            Assert.NotNull(serviceError.Error);
            Assert.Equal("code", serviceError.Error.Code);
            Assert.Equal("hostId", serviceError.Error.HostId);
            Assert.Equal("message", serviceError.Error.Message);
            Assert.Equal("requestId", serviceError.Error.RequestId);
        }
    }
}
