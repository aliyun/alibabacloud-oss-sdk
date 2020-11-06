find_package(darabonba_xml QUIET)

if(darabonba_xml_FOUND)
  message(STATUS "Found darabonba_xml version ${darabonba_xml_VERSION}")
else()
  message(STATUS "darabonba_xml could not be located, Building darabonba_xml instead.")
  include(FetchContent)

  FetchContent_Declare(
    _darabonba_xml
    GIT_REPOSITORY https://github.com/alibabacloud-sdk-cpp/dara-xml.git
    GIT_TAG master
    CMAKE_ARGS
      -DENABLE_UNIT_TESTS:BOOL="0")

  FetchContent_GetProperties(_darabonba_xml)
  if(NOT _darabonba_xml_POPULATED)
    FetchContent_Populate(_darabonba_xml)
    message(STATUS "Added darabonba_xml source : ${_darabonba_xml_SOURCE_DIR}")
    message(STATUS "Added darabonba_xml binary : ${_darabonba_xml_BINARY_DIR}")
    add_subdirectory(
      ${_darabonba_xml_SOURCE_DIR}
      ${_darabonba_xml_BINARY_DIR}
    )
  endif()
  target_include_directories(alibabacloud_oss PRIVATE "${_darabonba_xml_SOURCE_DIR}/include")
endif()
