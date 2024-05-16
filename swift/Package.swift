// swift-tools-version:5.6
// The swift-tools-version declares the minimum version of Swift required to build this package.
import PackageDescription

let package = Package(
        name: "AlibabaCloudOssSdk",
        platforms: [.macOS(.v10_15),
                    .iOS(.v13),
                    .tvOS(.v13),
                    .watchOS(.v6)],
        products: [
            .library(
                    name: "AlibabaCloudOssSdk",
                    targets: ["AlibabaCloudOssSdk"])
        ],
        dependencies: [
            // Dependencies declare other packages that this package depends on.
            .package(url: "https://github.com/aliyun/tea-swift.git", from: "1.0.2"),
            .package(url: "https://github.com/alibabacloud-sdk-swift/tea-utils", from: "1.0.5"),
            .package(url: "https://github.com/alibabacloud-sdk-swift/tea-oss-utils", from: "1.0.1"),
            .package(url: "https://github.com/alibabacloud-sdk-swift/tea-xml", from: "1.0.1"),
            .package(url: "https://github.com/alibabacloud-sdk-swift/tea-fileform", from: "1.0.3"),
            .package(url: "https://github.com/aliyun/credentials-swift", from: "1.0.1"),
        ],
        targets: [
            .target(
                    name: "AlibabaCloudOssSdk",
                    dependencies: [
                        .product(name: "Tea", package: "tea-swift"),
                        .product(name: "TeaUtils", package: "tea-utils"),
                        .product(name: "AlibabaCloudOSSUtil", package: "tea-oss-utils"),
                        .product(name: "DarabonbaXML", package: "tea-xml"),
                        .product(name: "TeaFileForm", package: "tea-fileform"),
                        .product(name: "AlibabaCloudCredentials", package: "credentials-swift")
                    ]),
        ],
        swiftLanguageVersions: [.v5]
)
