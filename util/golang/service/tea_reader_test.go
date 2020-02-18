package service

import (
	"errors"
	"io"
	"io/ioutil"
	"strings"
	"testing"

	"github.com/alibabacloud-go/tea/utils"
)

type listenerTest struct {
}

func (progress *listenerTest) ProgressChanged(event *utils.ProgressEvent) {
}

type testReader struct {
}

func (reader *testReader) Read(p []byte) (n int, err error) {
	return 0, errors.New("testReader")
}

type testWriter struct {
}

func (write *testWriter) Write(p []byte) (n int, err error) {
	return 0, errors.New("testWriter")
}

func Test_TeeReader(t *testing.T) {
	reader := &testReader{}
	var writer io.Writer
	tracker := &utils.ReaderTracker{
		CompletedBytes: 100,
	}
	listener := &listenerTest{}

	teeRead := TeeReader(reader, writer, 100, listener, tracker)
	n, err := teeRead.Read([]byte("oss"))
	utils.AssertEqual(t, 0, n)
	utils.AssertEqual(t, "testReader", err.Error())

	err = teeRead.Close()
	utils.AssertNil(t, err)

	tmp := make([]byte, 10)
	readcloser := ioutil.NopCloser(strings.NewReader("oss"))
	teeRead = TeeReader(readcloser, writer, 100, listener, tracker)
	n, err = teeRead.Read(tmp)
	utils.AssertEqual(t, 3, n)
	utils.AssertNil(t, err)

	err = teeRead.Close()
	utils.AssertNil(t, err)

	writer = &testWriter{}
	readcloser = ioutil.NopCloser(strings.NewReader("oss"))
	teeRead = TeeReader(readcloser, writer, 100, listener, tracker)
	n, err = teeRead.Read(tmp)
	utils.AssertEqual(t, 0, n)
	utils.AssertEqual(t, err.Error(), "testWriter")
}
