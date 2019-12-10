package service

import (
	"encoding/json"
	"reflect"
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/utils"
)

type validatorTest struct {
	Num  *int       `json:"num" require:"true"`
	Str  *string    `json:"str" pattern:"^[a-d]*$" maxLength:"4"`
	Test *errLength `json:"test"`
	List []*string  `json:"list" pattern:"^[a-d]*$" maxLength:"4"`
}

type errLength struct {
	Num *int `json:"num" maxLength:"a"`
}

type encodeType struct {
	Num  *int    `json:"num" encode:"Base64"`
	Str  *string `json:"str" encode:"UrlEncode"`
	Str2 *string `json:"str2"`
	Str3 *string `json:"str3"`
}

var num = 1
var str1, str2 = "abc", "acd"

type PrettifyTest struct {
	name     string
	Strs     []string
	Nums8    []int8
	Unum8    []uint8
	Value    string
	Mapvalue map[string]string
}

func Test_Prettify(t *testing.T) {
	prettifyTest := &PrettifyTest{
		name:     "prettify",
		Nums8:    []int8{0, 1, 2, 4},
		Unum8:    []uint8{0},
		Value:    "ok",
		Mapvalue: map[string]string{"key": "ccp", "value": "ok"},
	}
	str := Prettify(prettifyTest)
	utils.AssertContains(t, str, "Nums8")

	str = Prettify(nil)
	utils.AssertEqual(t, str, "null")
}

func Test_Sorter(t *testing.T) {
	tmp := map[string]string{
		"key":   "ccp",
		"value": "ok",
	}
	sort := newSorter(tmp)
	sort.Sort()

	len := sort.Len()
	utils.AssertEqual(t, len, 2)

	isLess := sort.Less(0, 1)
	utils.AssertEqual(t, isLess, true)

	sort.Swap(0, 1)
	isLess = sort.Less(0, 1)
	utils.AssertEqual(t, isLess, false)
}

func Test_getSignatureV1(t *testing.T) {
	request := tea.NewRequest()
	request.Query = map[string]string{
		"oss":      "ok",
		"location": "oss",
		"endTime": "now",
	}
	request.Headers = map[string]string{
		"x-oss-meta": "user",
	}
	str := getSignatureV1(request, "script", "")
	utils.AssertEqual(t, 28, len(str))
}

func Test_flatRepeatedList(t *testing.T) {
	input := map[string]interface{}{
		"Nums": []int{1, 2},
		"Maps": []map[string]string{
			map[string]string{
				"key": "value",
			},
		},
		"Nil": nil,
	}
	result := map[string]string{}
	flatRepeatedList(reflect.ValueOf(input), result, "")
	utils.AssertEqual(t, "value", result["Maps.1.key"])
	utils.AssertEqual(t, "1", result["Nums.1"])
	utils.AssertEqual(t, "2", result["Nums.2"])
}

func Test_isParamSign(t *testing.T) {
	isok := isParamSign("location")
	utils.AssertEqual(t, true, isok)
}
func Test_getSignatureV2(t *testing.T) {
	request := tea.NewRequest()
	request.Query = map[string]string{
		"oss":      "ok",
		"location": "oss",
	}
	request.Headers = map[string]string{
		"x-oss-meta": "user",
		"oss":        "ok",
	}
	str := getSignatureV2(request, "script", "", []string{})
	utils.AssertEqual(t, 44, len(str))

	request.Pathname = "?"
	str = getSignatureV2(request, "script", "", []string{"oss"})
	utils.AssertEqual(t, 44, len(str))
}

func Test_uriEncode(t *testing.T) {
	str := uriEncode("/?", false)
	utils.AssertEqual(t, "/%3f", str)
}

func Test_getStartElement(t *testing.T) {
	xmlVal := `<?xml version="1.0" encoding="utf-8" standalone="no"?>
<students>
    <student number="1001">
        <name>zhangSan</name>
        <age>23</age>
        <sex>male</sex>
    </student>
</students>`
	str := getStartElement([]byte(xmlVal))
	utils.AssertEqual(t, "students", str)

	xmlVal = `<?xml version="1.0" encoding="utf-8" standalone="no"?>
<students/\>
    <student number="1001">
        <name>zhangSan</name>
        <age>23</age>
        <sex>male</sex>
    </student>
</students>`
	str = getStartElement([]byte(xmlVal))
	utils.AssertEqual(t, "", str)
}

func Test_getFunc(t *testing.T) {
	num := 10
	intval := getIntValue(num)
	utils.AssertEqual(t, 10, intval)

	intval = getIntValue(nil)
	utils.AssertEqual(t, 0, intval)

	boolval := true
	boolval = getBoolValue(boolval)
	utils.AssertEqual(t, true, boolval)

	boolval = getBoolValue(nil)
	utils.AssertEqual(t, false, boolval)
}

type GetBucketLocationResponse struct {
	RequestId          *string `json:"x-oss-request-id" xml:"x-oss-request-id" require:"true"`
	LocationConstraint *string `json:"LocationConstraint" xml:"LocationConstraint" require:"true"`
}

func Test_XmlUnmarshal(t *testing.T) {
	result := new(GetBucketLocationResponse)
	xmlVal := `<?xml version="1.0" encoding="UTF-8"?>
<LocationConstraint>oss-cn-hangzhou</LocationConstraint >`
	out, err := XmlUnmarshal([]byte(xmlVal), result)
	utils.AssertNil(t, err)

	byt, _ := json.Marshal(out)
	utils.AssertEqual(t, `"oss-cn-hangzhou"`, string(byt))
}
