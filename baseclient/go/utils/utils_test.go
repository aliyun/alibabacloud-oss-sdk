package utils

import (
	"strings"
	"testing"
)

func Test_GetUUID(t *testing.T) {
	uuid := GetUUID()
	AssertEqual(t, len(uuid), 32)
}

func Test_GetTimeInFormatISO8601(t *testing.T) {
	time := GetTimeInFormatISO8601()
	AssertEqual(t, len(time), 20)
}

func Test_TypeByExtension(t *testing.T) {
	typ := TypeByExtension("test")
	AssertEqual(t, typ, "text/plain")
}

func Test_GetUrlFormedMap(t *testing.T) {
	tmp := map[string]string{
		"key": "value",
	}
	encode := GetUrlFormedMap(tmp)
	AssertEqual(t, encode, "key=value")
}

func Test_CalcMD5(t *testing.T) {
	body := strings.NewReader("oss")
	_, b64 := CalcMD5(body, 3, 5)
	AssertEqual(t, b64, "NpZEESCkAveTpwR2ZUDmng==")

	buf := strings.NewReader("oss")
	_, b64 = CalcMD5(buf, 0, 5)
	AssertEqual(t, b64, "NpZEESCkAveTpwR2ZUDmng==")
}
