#!/bin/bash
set -e  # stop on error

MIGRATION_NAME=$1

if [ -z "$MIGRATION_NAME" ]; then
  echo "Usage: $0 <MigrationName>"
  exit 1
fi

# optional: drop DB cleanly instead of deleting files
dotnet ef database drop -f

# add migration
dotnet ef migrations add "$MIGRATION_NAME"

# update DB to latest
dotnet ef database update