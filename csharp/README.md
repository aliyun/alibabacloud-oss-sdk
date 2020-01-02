English | [简体中文](README-CN.md)
![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

## Alibaba Cloud OSS Client SDK for .Net

## Installation

Use .Net CLI ( Recommand )

    dotnet add package AlibabaCloud.SDK.OSS.Client

Use Package Manager

    Install-Package AlibabaCloud.SDK.OSS.Client

## Demo
```csharp
using System.IO;
using System.Text;

using AlibabaCloud.OSS;
using AlibabaCloud.OSS.Models;

using Aliyun.Credentials.Utils;

namespace AliyunComdeSample
{
    class Program
    {

        static void Main(string[] args)
        {
            Config config = new Config
            {
                AccessKeyId = "<your-AccessKeyId>",
                AccessKeySecret = "<your-ACCESS_KEY_SECRET>",
                Type = AuthConstant.AccessKey.ToString(),
                SignatureVersion = "V2"
            };

            RuntimeObject runtime = new RuntimeObject
            {
                Md5Threshold = 1000,
                MaxIdleConns = 3
            };
            Client client = new Client(config);

            //putObject
            PutObjectResponse putObjectResponse = PutObject(client, runtime);

            //getObject
            GetObjectResponse getObjectResponse = GetObject(client, runtime);
        }

        public static PutObjectResponse PutObject(Client client, RuntimeObject runtime)
        {
            PutObjectRequest.PutObjectRequestHeader header = new PutObjectRequest.PutObjectRequestHeader
            {
                StorageClass = "Standard"
            };
            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = "<your-bucketName>",
                Header = header,
                Body = new MemoryStream(Encoding.UTF8.GetBytes("test")),
                ObjectName = "<your-objectName>"
            };
            return client.putObject(request, runtime);
        }

        public static GetObjectResponse GetObject(Client client, RuntimeObject runtime)
        {
            GetObjectRequest request = new GetObjectRequest
            {
                BucketName = "<your-bucketName>",
                ObjectName = "<your-objectName>"
            };
            return client.getObject(request, runtime);
        }
    }
}

        
```

## Issues
[Opening an Issue](https://github.com/aliyun/alibabacloud-oss-sdk/issues/new), Issues not conforming to the guidelines may be closed immediately.

## Changelog
Detailed changes for each release are documented in the [release notes](./ChangeLog.md).

## References
* [Latest Release](https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/langs/csharp)

## License
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Copyright (c) 2009-present, Alibaba Cloud All rights reserved.