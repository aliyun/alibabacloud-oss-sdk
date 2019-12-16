package service

import (
	"bytes"
	"crypto/hmac"
	"crypto/sha1"
	"crypto/sha256"
	"encoding/base64"
	"encoding/json"
	"encoding/xml"
	"fmt"
	"hash"
	"io"
	"reflect"
	"sort"
	"strconv"
	"strings"

	"github.com/alibabacloud-go/tea/tea"
)

var characters = map[string]bool{"-": true, "_": true, ".": true, "~": true}

// signKeyList is a list about params without value
var signKeyList = []string{"location", "cors", "objectMeta",
	"uploadId", "partNumber", "security-token",
	"position", "img", "style", "styleName",
	"replication", "replicationProgress",
	"replicationLocation", "cname", "qos",
	"startTime", "endTime", "symlink",
	"x-oss-process", "response-content-type",
	"response-content-language", "response-expires",
	"response-cache-control", "response-content-disposition",
	"response-content-encoding", "udf", "udfName", "udfImage",
	"udfId", "udfImageDesc", "udfApplication",
	"udfApplicationLog", "restore", "callback", "callback-var",
	"policy", "encryption", "versions", "versioning", "versionId"}

// Sorter defines the key-value structure for storing the sorted data in signHeader.
type Sorter struct {
	Keys []string
	Vals []string
}

// newSorter is an additional function for function Sign.
func newSorter(m map[string]string) *Sorter {
	hs := &Sorter{
		Keys: make([]string, 0, len(m)),
		Vals: make([]string, 0, len(m)),
	}

	for k, v := range m {
		hs.Keys = append(hs.Keys, k)
		hs.Vals = append(hs.Vals, v)
	}
	return hs
}

// Sort is an additional function for function SignHeader.
func (hs *Sorter) Sort() {
	sort.Sort(hs)
}

// Len is an additional function for function SignHeader.
func (hs *Sorter) Len() int {
	return len(hs.Vals)
}

// Less is an additional function for function SignHeader.
func (hs *Sorter) Less(i, j int) bool {
	return bytes.Compare([]byte(hs.Keys[i]), []byte(hs.Keys[j])) < 0
}

// Swap is an additional function for function SignHeader.
func (hs *Sorter) Swap(i, j int) {
	hs.Vals[i], hs.Vals[j] = hs.Vals[j], hs.Vals[i]
	hs.Keys[i], hs.Keys[j] = hs.Keys[j], hs.Keys[i]
}

// Determine whether the parameters are in signKeyList
// signKeyList is a list about params without value
func isParamSign(paramKey string) bool {
	for _, k := range signKeyList {
		if paramKey == k {
			return true
		}
	}
	return false
}

// Fill in the values in dataValue for result
func flatRepeatedList(dataValue reflect.Value, result map[string]string, prefix string) {
	if !dataValue.IsValid() {
		return
	}

	dataType := dataValue.Type()
	if dataType.Kind().String() == "slice" {
		handleRepeatedParams(dataValue, result, prefix)
	} else if dataType.Kind().String() == "map" {
		handleMap(dataValue, result, prefix)
	} else {
		result[prefix] = fmt.Sprintf("%v", dataValue.Interface())
	}
}

func handleRepeatedParams(repeatedFieldValue reflect.Value, result map[string]string, prefix string) {
	if repeatedFieldValue.IsValid() && !repeatedFieldValue.IsNil() {
		for m := 0; m < repeatedFieldValue.Len(); m++ {
			elementValue := repeatedFieldValue.Index(m)
			key := prefix + "." + strconv.Itoa(m+1)
			fieldValue := reflect.ValueOf(elementValue.Interface())
			if fieldValue.Kind().String() == "map" {
				handleMap(fieldValue, result, key)
			} else {
				result[key] = fmt.Sprintf("%v", fieldValue.Interface())
			}
		}
	}
}

func handleMap(valueField reflect.Value, result map[string]string, prefix string) {
	if valueField.IsValid() && valueField.String() != "" {
		valueFieldType := valueField.Type()
		if valueFieldType.Kind().String() == "map" {
			var byt []byte
			byt, _ = json.Marshal(valueField.Interface())
			cache := make(map[string]interface{})
			_ = json.Unmarshal(byt, &cache)
			for key, value := range cache {
				pre := ""
				if prefix != "" {
					pre = prefix + "." + key
				} else {
					pre = key
				}
				fieldValue := reflect.ValueOf(value)
				flatRepeatedList(fieldValue, result, pre)
			}
		}
	}
}

// Get XMl StartElement
func getStartElement(body []byte) string {
	d := xml.NewDecoder(bytes.NewReader(body))
	for {
		tok, err := d.Token()
		if err != nil {
			return ""
		}
		if t, ok := tok.(xml.StartElement); ok {
			return t.Name.Local
		}
	}
}

func getSignedStrV1(req *tea.Request, canonicalizedResource, accessKeySecret string) string {
	// Find out the "x-oss-"'s address in header of the request
	temp := make(map[string]string)

	for k, v := range req.Headers {
		if strings.HasPrefix(strings.ToLower(k), "x-oss-") {
			temp[strings.ToLower(k)] = v
		}
	}
	hs := newSorter(temp)

	// Sort the temp by the ascending order
	hs.Sort()

	// Get the canonicalizedOSSHeaders
	canonicalizedOSSHeaders := ""
	for i := range hs.Keys {
		canonicalizedOSSHeaders += hs.Keys[i] + ":" + hs.Vals[i] + "\n"
	}

	// Give other parameters values
	// when sign URL, date is expires
	date := req.Headers["date"]
	contentType := req.Headers["content-type"]
	contentMd5 := req.Headers["content-md5"]

	signStr := req.Method + "\n" + contentMd5 + "\n" + contentType + "\n" + date + "\n" + canonicalizedOSSHeaders + canonicalizedResource
	h := hmac.New(func() hash.Hash { return sha1.New() }, []byte(accessKeySecret))
	io.WriteString(h, signStr)
	signedStr := base64.StdEncoding.EncodeToString(h.Sum(nil))

	return signedStr
}

func getSignedStrV2(req *tea.Request, canonicalizedResource, accessKeySecret string, additionalHeaders []string) string {
	// Find out the "x-oss-"'s address in header of the request
	temp := make(map[string]string)
	for _, value := range additionalHeaders {
		if req.Headers[value] != "" {
			temp[strings.ToLower(value)] = req.Headers[value]
		}
	}
	for k, v := range req.Headers {
		if strings.HasPrefix(strings.ToLower(k), "x-oss-") {
			temp[strings.ToLower(k)] = v
		}
	}
	hs := newSorter(temp)

	// Sort the temp by the ascending order
	hs.Sort()

	// Get the canonicalizedOSSHeaders
	canonicalizedOSSHeaders := ""
	for i := range hs.Keys {
		canonicalizedOSSHeaders += hs.Keys[i] + ":" + hs.Vals[i] + "\n"
	}
	// Give other parameters values
	// when sign URL, date is expires
	date := req.Headers["date"]
	contentType := req.Headers["content-type"]
	contentMd5 := req.Headers["content-md5"]
	signStr := req.Method + "\n" + contentMd5 + "\n" + contentType + "\n" + date + "\n" + canonicalizedOSSHeaders + strings.Join(additionalHeaders, ";") + "\n" + canonicalizedResource
	h := hmac.New(func() hash.Hash { return sha256.New() }, []byte(accessKeySecret))
	io.WriteString(h, signStr)
	signedStr := base64.StdEncoding.EncodeToString(h.Sum(nil))
	return signedStr
}

func uriEncode(rawStr string, encodeSlash bool) string {
	res := ""
	for i := 0; i < len(rawStr); i++ {
		tmp := string(rawStr[i])
		if (tmp >= "a" && tmp <= "z") || (tmp >= "A" && tmp <= "Z") ||
			(tmp >= "0" && tmp <= "9") || characters[tmp] {
			res = res + tmp
		} else if tmp == "/" {
			if encodeSlash {
				res = res + "%2F"
			} else {
				res = res + tmp
			}
		} else {
			res = res + "%" + fmt.Sprintf("%02x", tmp)
		}
	}
	return res
}

func XmlUnmarshal(body []byte, result interface{}) (interface{}, error) {
	start := getStartElement(body)
	dataValue := reflect.ValueOf(result).Elem()
	dataType := dataValue.Type()
	for i := 0; i < dataType.NumField(); i++ {
		field := dataType.Field(i)
		name, containsNameTag := field.Tag.Lookup("xml")
		if containsNameTag {
			if name == start {
				realType := dataValue.Field(i).Type()
				realValue := reflect.New(realType).Interface()
				err := xml.Unmarshal(body, realValue)
				if err != nil {
					return nil, err
				}
				return realValue, nil
			}
		}
	}
	return nil, nil
}

func Prettify(i interface{}) string {
	resp, _ := json.MarshalIndent(i, "", "   ")
	return string(resp)
}

func getStringValue(obj interface{}) string {
	if obj == nil {
		return ""
	}
	return obj.(string)
}

func getIntValue(obj interface{}) int {
	if obj == nil {
		return 0
	}
	return obj.(int)
}

func getBoolValue(obj interface{}) bool {
	if obj == nil {
		return false
	}
	return obj.(bool)
}
