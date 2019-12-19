package service

import "fmt"

func mapToXML(val map[string]interface{}) string {
	res := ""
	for key, value := range val {
		switch value.(type) {
		case []interface{}:
			for _, v := range value.([]interface{}) {
				switch v.(type) {
				case map[string]interface{}:
					res += `<` + key + `>`
					res += mapToXML(v.(map[string]interface{}))
					res += `</` + key + `>`
				default:
					if fmt.Sprintf("%v", v) != `<nil>` {
						res += `<` + key + `>`
						res += fmt.Sprintf("%v", v)
						res += `</` + key + `>`
					}
				}
			}
		case map[string]interface{}:
			res += `<` + key + `>`
			res += mapToXML(value.(map[string]interface{}))
			res += `</` + key + `>`
		default:
			if fmt.Sprintf("%v", value) != `<nil>` {
				res += `<` + key + `>`
				res += fmt.Sprintf("%v", value)
				res += `</` + key + `>`
			}
		}
	}
	return res
}
