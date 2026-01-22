#! /usr/bin/env bash
#! /usr/bin/env bash
set -uvx
set -e
cd "$(dirname "$0")"
cwd=`pwd`
ts=`date "+%Y.%m%d.%H%M.%S"`
bash --version 2>&1 | head -n 1

rm -rf tmp
mkdir -p tmp
cd tmp
git clone --recursive https://github.com/adams85/acornima
cd acornima
rm -rf .git
echo "Microsoft (R) .NET SDK version $(dotnet --version)"
dotnet build build/_build.csproj -nodeReuse:false -p:UseSharedCompilation=false -nologo -clp:NoSummary --verbosity quiet
#dotnet run --project build/_build.csproj --no-build -- "$@"
find . -name "*.csproj" -exec rm -rf {} +
find . -name "*.cs" -exec sed -i -e "s/Acornima/JavascriptParser/g" {} +
#find . -name "*.csproj" -exec sed -i -e "s/>Acornima</>JavascriptParser</g" {} +
cp -r src/Acornima/* $cwd/src/Acornima/
cp -r src/Acornima.Extras/* $cwd/src/Acornima/

cd $cwd
cp src/Acornima/Ast/Node.cs src/Acornima/Ast/Node.cs.orig
sed -i -e "s/public abstract class Node : INode/public abstract partial class Node : INode, Global.IExportToCommonJson/g" src/Acornima/Ast/Node.cs
cp -r modified/* .
