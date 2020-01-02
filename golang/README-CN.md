[English](README.md) | 简体中文

![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

## Alibaba Cloud OSS SDK for Go

## 要求
- 您需要确保本地安装的 go 环境版本大于 1.12.0.

## 安装

你可以使用 `go mod` 来管理你的依赖，
```go
  go mod tidy
```

## 示例
```go
package main

import (
  "fmt"

  ossClient "github.com/aliyun/alibabacloud-oss-sdk/golang/client"
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

  // 上传文件
  body := bytes.NewReader([]byte("demo")) // body 为任意的流
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

  // 下载文件
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

## 问题
[提交 Issue](https://github.com/aliyun/alibabacloud-oss-sdk/issues/new)，不符合指南的问题可能会立即关闭。

## 发行说明
每个版本的详细更改记录在[发行说明](./ChangeLog.txt)中。

## 相关
* [最新源码](https://github.com/aliyun/alibabacloud-oss-sdk/tree/master/langs/golang)

## 许可证
[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Copyright (c) 2009-present, Alibaba Cloud All rights reserved.

