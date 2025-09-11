#!/bin/bash

rm banddb.db
rm -rf Migrations/
dotnet ef migrations add InitialCreate
dotnet ef database update