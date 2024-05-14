import XCTest
import Tea
@testable import AlibabacloudOSSUtil

final class AlibabaCloudOssUtilTests: XCTestCase {
    func testGetErrMessage() throws {
        let errMessage1: String = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                    "<Error>\n" +
                    "  <Code>200</Code>\n" +
                    "  <Message>test message</Message>\n" +
                    "</Error>\n"
        let result1 = Client.getErrMessage(errMessage1)
        print("res----\(result1)")
        XCTAssertEqual(result1["Code"] as? String, "200")
        XCTAssertEqual(result1["Message"] as? String, "test message")
        
        let errMessage2 = "<?xml version='1.0' encoding='UTF-8'?><Code>401</Code>"
        let result2 = Client.getErrMessage(errMessage2)
        print("result2---\(result2)")
        XCTAssertEqual(result2.count, 0)
    }
    
    func testToMeta() throws {
        let header:[String: String] = ["size": "1", "test.key.id": "9527"]
        let result:[String: String] = Client.toMeta(header, "test.key.")
        XCTAssertEqual("9527", result["test.key.id"])
        XCTAssertTrue(result["test.key.size"] != nil)
    }
    
    func testParseMeta() throws {
        let header:[String: String] = ["size": "1", "test.key.id": "9527"]
        var result:[String: String] = Client.parseMeta(nil, "test.key.")
        XCTAssertEqual(0, result.count)
        result = Client.parseMeta(header, "test.key.")
        XCTAssertEqual("1", result["size"])
        XCTAssertTrue(result["id"] != nil)
    }

    func testGetContentType() throws {
        XCTAssertEqual("image/webp", Client.getContentType("test.webp"))
        XCTAssertEqual("audio/mpeg", Client.getContentType("test.mp3"))
    }

    func testGetContentMD5() throws {
        XCTAssertEqual("CY9rzUYh03PK3k6DJie09g==", Client.getContentMD5("test", true))
    }

    func testEncode() throws {
        let value: String = "test/encode/h%f"
        XCTAssertEqual(value, Client.encode(value, nil))
        XCTAssertEqual("test/encode/aCVm", Client.encode(value, "Base64"))
        XCTAssertEqual("test/encode/h%25f", Client.encode(value, "UrlEncode"))
        XCTAssertEqual(value, Client.encode(value, ""))
    }

    func testGetHost() throws {
        var host: String = Client.getHost(nil, nil, nil, nil)
        XCTAssertEqual("oss-cn-hangzhou.aliyuncs.com", host)
        
        host = Client.getHost("testBucket", "region", "endpoint", "ip")
        XCTAssertEqual("endpoint/testBucket", host)
        
        host = Client.getHost("testBucket", "region", "endpoint", "cname")
        XCTAssertEqual("endpoint", host)
        
        host = Client.getHost("testBucket", "region", "endpoint", "test")
        XCTAssertEqual("testBucket.endpoint", host)
    }

    func testInject() throws {
        var map: [String: String]? = nil
        let verifyStream = Client.inject(nil, &map)
        verifyStream.close()
        XCTAssertTrue(verifyStream is VerifyStream)
    }
    
    func testGetSignature() throws {
        XCTAssertEqual("", Client.getSignature(nil, nil, nil, nil, nil, nil))
    }
    
    func testDecode() throws {
        var result = Client.decode("test", nil)
        XCTAssertEqual("test", result)
        
        result = Client.decode("test/url", "test")
        XCTAssertEqual("test/url", result)
        
        result = Client.decode("test/dXJs", "Base64Decode")
        XCTAssertEqual("test/url", result)
        
        result = Client.decode("JjJi", "Base64Decode")
        XCTAssertEqual("&2b", result)
        
        result = Client.decode("test/url", "UrlDecode")
        XCTAssertEqual("test/url", result)
        
        result = Client.decode("path/%262b", "UrlDecode")
        XCTAssertEqual("path/&2b", result)
    }
}
