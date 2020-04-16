English | [简体中文](README-CN.md)
![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

## Alibaba Cloud OSS SDK for Go

## Requirements
- It's necessary for you to make sure your system have installed a Go environment which is new than 1.12.0.

## Installation
If you use `go mod` to manage your dependence, you can use the following command:

```sh
$ go get github.com/alibabacloud-go/tea-oss-sdk
```

## Demo
```go
package main

import (
  "fmt"

  ossClient "github.com/alibabacloud-go/tea-oss-sdk/client"
)

func main(){
  config := new(ossClient.Config).SetAccessKeyId("your_access_key_id").
	SetAccessKeySecret("your_access_key_secret").
	SetType("access_key")

  runtimeObject := new(ossClient.RuntimeObject).SetAutoretry(false).
	SetMd5Threshold(1000).
	SetMaxIdleConns(3)

  client, err := ossClient.NewClient(config)
  if err != nil {
    fmt.Println(err)
  }

  // Upload file
  body := bytes.NewReader([]byte("demo")) // body is a stream object
  putObecjtReq := &PutObjectRequest{}
  header := &PutObjectRequestHeader{}
  header.SetStorageClass("Standard")
  putObecjtReq.SetBucketName("demo").
	SetObjectName("demo.txt").
	SetBody(body).
	SetHeader(header)
  putObjectResp, err := client.PutObject(putObecjtReq, runtimeObject)
  if err != nil {
    fmt.Println(err)
  }

  fmt.Println(putObjectResp)

  // Download file
  getObjectReq := &GetObjectRequest{}
  getObjectReq.SetBucketName("demo").
	SetObjectName("demo.txt")
  getObjectResp, err := client.GetObject(getObjectReq, runtimeObject)
  if err != nil {
    fmt.Println(err)
  }

  fmt.Println(getObjectResp)
}    
```

## Issues
[Opening an Issue](https://github.com/aliyun/alibabacloud-oss-sdk/issues/new), Issues not conforming to the guidelines may be closed immediately.

## Changelog
Detailed changes for each release are documented in the [release notes](./ChangeLog.txt).

## References
* [Latest Release](https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/langs/golang)

## License
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Copyright (c) 2009-present, Alibaba Cloud All rights reserved.