package service

import (
	"testing"

	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/utils"
)

func Test_CRC(t *testing.T) {
	crctable := crcTable()
	hash := NewCRC(crctable, 10)
	utils.AssertEqual(t, 8, hash.Size())
	utils.AssertEqual(t, 1, hash.BlockSize())

	utils.AssertEqual(t, uint64(10), hash.Sum64())
	hash.Reset()
	utils.AssertEqual(t, uint64(0), hash.Sum64())

	n, err := hash.Write([]byte("oss"))
	utils.AssertEqual(t, 3, n)
	utils.AssertNil(t, err)

	utils.AssertEqual(t, uint64(14794686500134955722), hash.Sum64())

	hash.Reset()
	byt := hash.Sum([]byte("oss"))
	utils.AssertEqual(t, len(string(byt)), 11)

	crcValue := CRC64Combine(uint64(1), uint64(2), uint64(0))
	utils.AssertEqual(t, uint64(1), crcValue)

	crcValue = CRC64Combine(uint64(1), uint64(2), uint64(1))
	utils.AssertEqual(t, uint64(12911341560706588525), crcValue)

	crcValue = CRC64Combine(uint64(1), uint64(2), uint64(2))
	utils.AssertEqual(t, uint64(6118555238288912655), crcValue)
}
