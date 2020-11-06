find_package(alibabacloud_ossutil QUIET)

if(alibabacloud_ossutil_FOUND)
  message(STATUS "Found alibabacloud_ossutil version ${alibabacloud_ossutil_VERSION}")
else()
  message(STATUS "alibabacloud_ossutil could not be located, Building alibabacloud_ossutil instead.")
  include(FetchContent)

  FetchContent_Declare(
    _alibabacloud_ossutil
    GIT_REPOSITORY https://github.com/alibabacloud-sdk-cpp/oss-util.git
    GIT_TAG master
    CMAKE_ARGS
      -DENABLE_UNIT_TESTS:BOOL="0")

  FetchContent_GetProperties(_alibabacloud_ossutil)
  if(NOT _alibabacloud_ossutil_POPULATED)
    FetchContent_Populate(_alibabacloud_ossutil)
    message(STATUS "Added alibabacloud_ossutil source : ${_alibabacloud_ossutil_SOURCE_DIR}")
    message(STATUS "Added alibabacloud_ossutil binary : ${_alibabacloud_ossutil_BINARY_DIR}")
    add_subdirectory(
      ${_alibabacloud_ossutil_SOURCE_DIR}
      ${_alibabacloud_ossutil_BINARY_DIR}
    )
  endif()
  target_include_directories(alibabacloud_oss PRIVATE "${_alibabacloud_ossutil_SOURCE_DIR}/include")
endif()
