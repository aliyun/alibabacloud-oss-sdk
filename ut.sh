#!/bin/bash

function upload_codecov_report {
  # upload_codecov_report <dir> <flag>
  cd "$1" || return 126
  wget --no-check-certificate https://codecov.io/bash -O codecov.sh
  pwd
  bash codecov.sh -cF "$2"
  return $?
}

function run_php {
  cd util/php/ || return 126
  composer --version
  composer install --no-dev -vvv || return 126
  composer test || return 126
  cd ../../
  upload_codecov_report php php
}

function run_go {
  cd util/golang/ || return 126
  export GO111MODULE=on
  go mod tidy || return 126
  go test -race -coverprofile=coverage.txt -covermode=atomic ./service/... || return 126
  cd ../../
  upload_codecov_report golang go
}

function run_csharp {
  # before_install
  wget https://download.visualstudio.microsoft.com/download/pr/42f39f2f-3f24-4340-8c57-0a3133620c21/0a353696275b00cbddc9f60069867cfc/dotnet-sdk-2.2.110-linux-x64.tar.gz
  mkdir -p ~/dotnet/ && tar zxf dotnet-sdk-2.2.110-linux-x64.tar.gz -C ~/dotnet/
  sudo ln -sf ~/dotnet/dotnet /usr/bin/dotnet
  dotnet --info

  # install
  cd util/csharp/tests/ || return 126
  dotnet tool install --global altcover.visualizer
  dotnet restore || return 126
  dotnet build || return 126
  cd ../

  # run tests
  dotnet test tests/ /p:AltCover=true || return 126
  cd ../../

  # upload code coverage report
  upload_codecov_report csharp csharp
}

function run_java {
  cd util/java/ || return 126
  mvn test -B || return 126
  cd ../../
  upload_codecov_report java java
}

function run_ts {
  cd util/ts/ || return 126
  npm install || return 126
  npm run test-cov || return 126
  cd ../../
  upload_codecov_report ts node_js
}

lang=$1

if [ "$lang" == "php" ]
then
  echo "run php"
  run_php
elif [ "$lang" == "go" ]
then
  echo "run golang"
  run_go
elif [ "$lang" == "csharp" ]
then
  echo "run csharp"
  run_csharp
elif [ "$lang" == "java" ]
then
  echo "run java"
  run_java
elif [ "$lang" == "ts" ]
then
  echo "run ts"
  run_ts
fi

exit $?