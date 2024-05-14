import Foundation

open class CRC64 {
    // ECMA-182
    private static let POLY: UInt64 = 0xc96c5795d7870f42
    private static var table = [UInt64](repeating: 0, count: 256)
    private var value: UInt64 = 0
    
    static func initializeTable() {
        for n in 0..<256 {
            var crc = UInt64(n)
            for _ in 0..<8 {
                if crc & 1 == 1 {
                    crc = (crc >> 1) ^ POLY
                } else {
                    crc = crc >> 1
                }
            }
            table[n] = crc
        }
    }
    
    init() {
        self.value = 0
        CRC64.initializeTable()
    }
    
    func getValue() -> String {
        let first = (self.value >> 1) / 5
        let second = self.value - first * 10
        return "\(first)\(second)"
    }
    
    func update(_ b: [UInt8], len: Int) {
        for i in 0..<len {
            update(b[i])
        }
    }
    
    func update(_ b: UInt8) {
        self.value = ~self.value
        self.value = CRC64.table[Int((self.value ^ UInt64(b)) & 0xff)] ^ (self.value >> 8)
        self.value = ~self.value
    }
}
