import Foundation
import CryptoSwift

public class VerifyStream: InputStream {
    private let inputStream: InputStream
    private var map: [String: String]
    private let crc64 =  CRC64()
    private var md5 = MD5()
    
    init(inputStream: InputStream, map: inout [String: String]) {
        self.inputStream = inputStream
        self.map = map
        super.init(data: Data())
    }
    
    public override func read(_ buffer: UnsafeMutablePointer<UInt8>, maxLength len: Int) -> Int {
        let bytesRead = inputStream.read(buffer, maxLength: len)
        if bytesRead > 0 {
            crc64.update(Array(UnsafeBufferPointer(start: buffer, count: bytesRead)), len: bytesRead)
            let dataChunk = Data(bytes: buffer, count: bytesRead)
            _ = try! md5.update(withBytes: Array(dataChunk))
        } else if bytesRead == 0 {
            map["crc"] = crc64.getValue()
            let md5Digest = try! md5.finish()
            map["md5"] = Data(md5Digest).base64EncodedString()
        }
        return bytesRead
    }
    
    public override func open() {
        inputStream.open()
    }
    
    public override func close() {
        inputStream.close()
    }
    
    func readSingleByte() -> UInt8? {
        var buffer: UInt8 = 0
        let bytesRead = self.read(&buffer, maxLength: 1)
        if bytesRead == 1 {
            return buffer
        } else {
            return 0
        }
    }
    
    func getResultMap() -> [String: String] {
        return self.map
    }
}

