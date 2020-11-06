#!/bin/bash

basepath=$(cd `dirname $0`/../; pwd)

cd "$basepath/" || exit

main() {
    mkdir -p cmake_build/
    cd cmake_build/ || exit
    cmake .. -DENABLE_UNIT_TESTS=OFF -DCMAKE_BUILD_TYPE=Release -DCMAKE_INSTALL_PREFIX=/usr/local || {
        error_exit "Failed to cmake."
    }

    cmake --build . --target install || {
        error_exit "Failed to build."
    }
}

error_exit() {
    echo
    echo Error: "$@"
    echo "----------------------------------------------------------------------"
    echo
    exit 1
}

main "$@"
exit 0
