#!/bin/bash
set -e  # stop on error

MIGRATION_NAME=$1

if [ -z "$MIGRATION_NAME" ]; then
  echo "Usage: $0 <MigrationName>"
  exit 1
fi

# copy to backup folder
cp banddb.db Backups/banddb_$(date +%Y%m%d_%H%M%S).db

# add migration
dotnet ef migrations add "$MIGRATION_NAME"

# update DB to latest
dotnet ef database update