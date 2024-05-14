Pod::Spec.new do |spec|

  spec.name         = "AlibabaCloudOSSUtil"
  spec.version      = "1.0.1"
  spec.license      = "Apache 2.0"
  spec.summary      = "AlibabaCloud OSS Util SDK for Swift"
  spec.homepage     = "https://github.com/alibabacloud-sdk-swift/tea-oss-utils" 
  spec.author       = { "Alibaba Cloud SDK" => "sdk-team@alibabacloud.com" }

  spec.source       = { :git => spec.homepage + '.git', :tag => spec.version }
  spec.source_files = 'Sources/**/*.swift'

  spec.ios.framework   = 'Foundation'

  spec.ios.deployment_target     = '13.0'
  spec.osx.deployment_target     = '10.15'
  spec.watchos.deployment_target = '6.0'
  spec.tvos.deployment_target    = '13.0'

  spec.dependency 'Tea',  '~> 1.0.2'

  spec.swift_version='5.6'
end
