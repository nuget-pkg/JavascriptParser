#! /usr/bin/env bash
find . -name "*.cs" -exec sed -i -e "s/Acornima/JavascriptParser/g" {} +
find . -name "*.csproj" -exec sed -i -e "s/>Acornima</>JavascriptParser</g" {} +
#find . -name "*.csproj" -exec sed -i -e "s/>Acornima.Extras</>JavascriptParser.Extras</g" {} +
