import XCTest
import Tea
@testable import AlibabaCloudOSSUtil

class VerifyStreamTest: XCTestCase {
    func testRead() throws {
        guard let data = "test".data(using: .utf8) else {
            XCTFail("Failed to create data from string")
            return
        }

        let input = InputStream(data: data)
        var map: [String: String] = [:]
        let verifyStream = VerifyStream(inputStream: input, map: &map)

        input.open()
        defer { input.close() }

        var bytes = [UInt8](repeating: 0, count: 4)
        let bytesRead = verifyStream.read(&bytes, maxLength: bytes.count)
        XCTAssertEqual(4, bytesRead)

        let endOfStream = verifyStream.read(&bytes, maxLength: bytes.count)
        XCTAssertEqual(0, endOfStream)

        let resultMap = verifyStream.getResultMap()
        XCTAssertEqual("18020588380933092773", resultMap["crc"])
        XCTAssertEqual("CY9rzUYh03PK3k6DJie09g==", resultMap["md5"])
    }
}
