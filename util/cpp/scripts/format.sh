#!/bin/bash

basepath=$(cd `dirname $0`/../; pwd)

cd "$basepath/" || exit

find ./src -iname *.hpp -o -iname *.cpp | xargs clang-format -i -style=llvm
find ./include -iname *.hpp -o -iname *.cpp | xargs clang-format -i -style=llvm
