[English](README.md) | 简体中文

![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

## Alibaba Cloud OSS SDK for Java


## 安装

```xml
<dependency>
   <groupId>com.aliyun</groupId>
   <artifactId>oss-baseclient</artifactId>
   <version>[1.1.0, 2.0.0)</version>
</dependency>
<dependency>
    <groupId>com.aliyun</groupId>
    <artifactId>oss-client</artifactId>
    <version>[1.1.0, 2.0.0)</version>
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
    config.signatureVersion = "V2";
    Client client = new Client(config);
    
    // putObject
    PutObjectRequest request = new PutObjectRequest();
    request.bucketName = "sdk-oss-test";
    request.objectName = "sdk.txt";
    PutObjectRequest.PutObjectRequestHeader header = new PutObjectRequest.PutObjectRequestHeader();
    header.storageClass = "Archive";
    request.header = header;
    request.body = new ByteArrayInputStream("value".getBytes("UTF-8"));
    RuntimeObject runtimeObject = new RuntimeObject();
    PutObjectResponse response = client.putObject(request, runtimeObject);
    
    // getObject
    GetObjectRequest request = new GetObjectRequest();
    request.bucketName = "sdk-oss-test";
    request.objectName = "123.txt";
    RuntimeObject runtimeObject = new RuntimeObject();
    GetObjectResponse response = client.getObject(request, runtimeObject);
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

