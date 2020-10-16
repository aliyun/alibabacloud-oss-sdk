message(STATUS "Install libraries")
if (ENABLE_UNIT_TESTS)
  add_subdirectory(googletest)
endif()
