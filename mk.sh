#!/usr/bin/env bash

bash --version 2>&1 | head -n 1

set -eo pipefail
SCRIPT_DIR=$(cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd)

###########################################################################
# CONFIGURATION
###########################################################################

BUILD_PROJECT_FILE="$SCRIPT_DIR/build/_build.csproj"
TEMP_DIRECTORY="$SCRIPT_DIR//.nuke/temp"

DOTNET_GLOBAL_FILE="$SCRIPT_DIR//global.json"
DOTNET_INSTALL_URL="https://dot.net/v1/dotnet-install.sh"
DOTNET_CHANNEL="STS"

export DOTNET_CLI_TELEMETRY_OPTOUT=1
export DOTNET_NOLOGO=1

###########################################################################
# EXECUTION
###########################################################################

echo "Microsoft (R) .NET SDK version $(dotnet --version)"

if [[ ! -z ${NUKE_ENTERPRISE_TOKEN+x} && "$NUKE_ENTERPRISE_TOKEN" != "" ]]; then
    dotnet nuget remove source "nuke-enterprise" &>/dev/null || true
    dotnet nuget add source "https://f.feedz.io/nuke/enterprise/nuget" --name "nuke-enterprise" --username "PAT" --password "$NUKE_ENTERPRISE_TOKEN" --store-password-in-clear-text &>/dev/null || true
fi

dotnet build "$BUILD_PROJECT_FILE" -nodeReuse:false -p:UseSharedCompilation=false -nologo -clp:NoSummary --verbosity quiet
dotnet run --project "$BUILD_PROJECT_FILE" --no-build -- "$@"
