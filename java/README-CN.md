[English](README.md) | 简体中文

![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

## Alibaba Cloud OSS SDK for Java


## 安装

```xml
<dependency>
   <groupId>com.aliyun</groupId>
   <artifactId>oss-baseclient</artifactId>
   <version>1.0-SNAPSHOT</version>
</dependency>
<dependency>
    <groupId>com.aliyun</groupId>
    <artifactId>oss-client</artifactId>
    <version>1.0-SNAPSHOT</version>
</dependency>
```

## 代码案例
```java
    Config config = new Config();
    // 你的ak
    config.accessKeyId = "";
    // 你的sk
    config.accessKeySecret = "";
    // 签名版本
    config.signatureVersion = "v2";
    Client client = new Client(config);
    GetBucketInfoRequest request = new GetBucketInfoRequest();
    request.bucketName = "sdk-script";
    RuntimeObject runtimeObject = new RuntimeObject();
    GetBucketInfoResponse response = client.GetBucketInfo(request, runtimeObject);
    
```

## 问题
[提交 Issue](https://github.com/aliyun/alibabacloud-oss-sdk/issues/new)，不符合指南的问题可能会立即关闭。

## 发行说明
每个版本的详细更改记录在[发行说明](./ChangeLog.txt)中。

## 相关
* [最新源码](https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/langs/java)

## 许可证
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

版权所有 1999-2019 阿里巴巴集团

