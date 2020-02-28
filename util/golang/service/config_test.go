package service

import (
	"reflect"
	"testing"

	"github.com/alibabacloud-go/tea/utils"
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

func Test_TypeByExtension(t *testing.T) {
	typ := typeByExtension("test")
	utils.AssertEqual(t, typ, "text/plain")
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

func Test_uriEncode(t *testing.T) {
	str := uriEncode("/?", false)
	utils.AssertEqual(t, "/%3f", str)
}
