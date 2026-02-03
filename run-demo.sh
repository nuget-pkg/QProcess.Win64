#! /usr/bin/env bash
set -uvx
set -e
cd "$(dirname "$0")"
cwd=`pwd`
ts=`date "+%Y.%m%d.%H%M.%S"`
dotnet run --project QProcess.Win64.Demo/QProcess.Win64.Demo.csproj --framework net462 "$@"
