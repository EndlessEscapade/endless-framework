@echo off

set "SourcePath=%~dp0..\src\EndlessFramework"
set "TargetPath=%USERPROFILE%\Documents\My Games\Terraria\tModLoader\ModSources\EndlessFramework"

if not exist "%SourcePath%" (
    echo "ERROR: Source directory does not exist: %SourcePath%"
    pause
    exit /b 1
)

mklink /D "%TargetPath%" "%SourcePath%"
