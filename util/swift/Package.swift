// swift-tools-version:5.6
// The swift-tools-version declares the minimum version of Swift required to build this package.
import PackageDescription

let package = Package(
        name: "AlibabaCloudOSSUtil",
        platforms: [.macOS(.v10_15),
                    .iOS(.v13),
                    .tvOS(.v13),
                    .watchOS(.v6)],
        products: [
            .library(
                    name: "AlibabaCloudOSSUtil",
                    targets: ["AlibabaCloudOSSUtil"])
        ],
        dependencies: [
            // Dependencies declare other packages that this package depends on.
            .package(url: "https://github.com/aliyun/tea-swift.git", from: "1.0.2"),
            .package(url: "https://github.com/krzyzanowskim/CryptoSwift.git", from: "1.5.1"),
            .package(url: "https://github.com/drmohundro/SWXMLHash.git", from: "7.0.2"),
            
        ],
        targets: [
            .target(
                    name: "AlibabaCloudOSSUtil",
                    dependencies: [
                        .product(name: "Tea", package: "tea-swift"),
                        .product(name: "SWXMLHash", package: "SWXMLHash"),
                        .product(name: "CryptoSwift", package: "CryptoSwift"),
                    ]),
            .testTarget(
                name: "AlibabaCloudOSSUtilTests",
                dependencies: [
                    "AlibabaCloudOSSUtil",
                    .product(name: "Tea", package: "tea-swift")
                ]),
        ],
        swiftLanguageVersions: [.v5]
)
