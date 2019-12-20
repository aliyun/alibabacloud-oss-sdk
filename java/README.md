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
    config.signatureVersion = "v2";
    Client client = new Client(config);
    GetBucketInfoRequest request = new GetBucketInfoRequest();
    request.bucketName = "sdk-script";
    RuntimeObject runtimeObject = new RuntimeObject();
    GetBucketInfoResponse response = client.GetBucketInfo(request, runtimeObject);
    
```

## Issues
[Opening an Issue](https://github.com/aliyun/alibabacloud-oss-sdk/issues/new), Issues not conforming to the guidelines may be closed immediately.

## Changelog
Detailed changes for each release are documented in the [release notes](./ChangeLog.txt).

## References
* [Latest Release](https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/langs/java)

## License
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Copyright 1999-2019 Alibaba Group Holding Ltd.