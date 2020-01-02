English | [简体中文](README-CN.md)
![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

## Alibaba Cloud OSS SDK for Java

## Installation

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

## Demo
```java
    Config config = new Config();
    // your accessKeyId
    config.accessKeyId = "";
    // your accessKeySecret
    config.accessKeySecret = "";
    // signature version 
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

## Issues
[Opening an Issue](https://github.com/aliyun/alibabacloud-oss-sdk/issues/new), Issues not conforming to the guidelines may be closed immediately.

## Changelog
Detailed changes for each release are documented in the [release notes](./ChangeLog.txt).

## References
* [Latest Release](https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/langs/java)

## License
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Copyright (c) 2009-present, Alibaba Cloud All rights reserved.