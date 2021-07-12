#!/usr/bin/env bash
# Bash script that initializes, builds, and runs a new C# project from a folder titled 2-new_project
dotnet new console -o 2-new_project -lang C#;
dotnet build 2-new_project;
dotnet run -p 2-new_project;
