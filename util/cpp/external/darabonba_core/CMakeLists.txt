find_package(darabonba_core ${darabonba_core_MINIMUM_REQUIRED} QUIET COMPONENTS ${darabonba_core_COMPONENTS_REQUIRED})

if(darabonba_core_FOUND)
  message(STATUS "Found darabonba_core version ${darabonba_core_MAJOR_VERSION}.${darabonba_core_MINOR_VERSION}.${darabonba_core_SUBMINOR_VERSION}")
  add_library(darabonba_core_external PRIVATE)
else()
  message(STATUS "darabonba_core ${darabonba_core_MINIMUM_REQUIRED} could not be located, Building darabonba_core instead.")
  include(FetchContent)

  FetchContent_Declare(
    _darabonba_core
    GIT_REPOSITORY https://github.com/aliyun/tea-cpp.git
    GIT_TAG master)
  
  FetchContent_GetProperties(_darabonba_core)
  if(NOT _darabonba_core_POPULATED)
    FetchContent_Populate(_darabonba_core)
    message(STATUS "Added darabonba_core source : ${_darabonba_core_SOURCE_DIR}")
    message(STATUS "Added darabonba_core binary : ${_darabonba_core_BINARY_DIR}")
    add_subdirectory(
      ${_darabonba_core_SOURCE_DIR} 
      ${_darabonba_core_BINARY_DIR}
    )
  endif()
  target_include_directories(alibabacloud_ossutil PRIVATE "${_darabonba_core_SOURCE_DIR}/include")
  if(ENABLE_UNIT_TESTS)
    target_include_directories(tests_alibabacloud_ossutil PRIVATE "${_darabonba_core_SOURCE_DIR}/include")
  endif()
endif()
