package service

import (
	"encoding/json"
	"testing"

	"github.com/aliyun/alibabacloud-oss-sdk/baseclient/go/utils"
)

func Test_mapToXML(t *testing.T) {
	obj := map[string]interface{}{
		"struct": map[string]interface{}{
			"param1": "value1",
			"list":   []string{"value2", "value3"},
			"listMap": []map[string]interface{}{
				map[string]interface{}{
					"param2": "value2",
				},
				map[string]interface{}{
					"param3": "value3",
				},
			},
			"listMapString": []map[string]string{
				map[string]string{
					"param4": "value4",
				},
				map[string]string{
					"param5": "value5",
				},
			},
			"mapString": map[string]string{
				"param6": "value6",
			},
			"listInterface": []interface{}{"10", 20},
		},
	}
	byt, _ := json.Marshal(obj)
	obj1 := make(map[string]interface{})
	json.Unmarshal(byt, &obj1)
	xml := mapToXML(obj1)
	utils.AssertContains(t, xml, `<listInterface>10</listInterface>`)
}
