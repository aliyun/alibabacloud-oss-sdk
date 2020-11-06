#!/bin/bash

basepath=$(cd `dirname $0`/../; pwd)

cd "$basepath/" || exit

main() {
    mkdir -p cmake_build/
    cd cmake_build/ || exit
    cmake .. || {
        error_exit "Failed to cmake."
    }

    cmake --build . || {
        error_exit "Failed to make."
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
