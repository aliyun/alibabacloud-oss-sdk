find_package(darabonba_file_form QUIET)

if(darabonba_file_form_FOUND)
  message(STATUS "Found darabonba_file_form version ${darabonba_file_form_VERSION}")
else()
  message(STATUS "darabonba_file_form could not be located, Building darabonba_file_form instead.")
  include(FetchContent)

  FetchContent_Declare(
    _darabonba_file_form
    GIT_REPOSITORY https://github.com/alibabacloud-sdk-cpp/dara-fileform.git
    GIT_TAG master
    CMAKE_ARGS
      -DENABLE_UNIT_TESTS:BOOL="0")

  FetchContent_GetProperties(_darabonba_file_form)
  if(NOT _darabonba_file_form_POPULATED)
    FetchContent_Populate(_darabonba_file_form)
    message(STATUS "Added darabonba_file_form source : ${_darabonba_file_form_SOURCE_DIR}")
    message(STATUS "Added darabonba_file_form binary : ${_darabonba_file_form_BINARY_DIR}")
    add_subdirectory(
      ${_darabonba_file_form_SOURCE_DIR}
      ${_darabonba_file_form_BINARY_DIR}
    )
  endif()
  target_include_directories(alibabacloud_oss PRIVATE "${_darabonba_file_form_SOURCE_DIR}/include")
endif()
