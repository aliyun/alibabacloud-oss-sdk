[English](README.md) | 简体中文

![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

## Alibaba Cloud OSS Client for .Net


## 安装

Use .Net CLI ( Recommand )

    dotnet add package AlibabaCloud.SDK.OSS.Client

Use Package Manager

    Install-Package AlibabaCloud.SDK.OSS.Client

## 代码示例
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
                Type = AuthConstant.AccessKey.ToString()
            };

            RuntimeObject runtime = new RuntimeObject
            {
                Md5Threshold = 1000,
                MaxIdleConns = 3
            };
            Client client = new Client(config);
            //signature version
            client.SignatureVersion = "V2";

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

## 问题
[提交 Issue](https://github.com/aliyun/alibabacloud-oss-sdk/issues/new)，不符合指南的问题可能会立即关闭。

## 发行说明
每个版本的详细更改记录在[发行说明](./ChangeLog.md)中。

## 相关
* [最新源码](https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/langs/csharp)

## 许可证
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

版权所有 1999-2019 阿里巴巴集团

