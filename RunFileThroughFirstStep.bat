echo off
title Send Email When System 'Start
echo fetching files from git wait for some time
git clone https://github.com/ZealShah96/SendEmailWhenSystemStart.git
pause
cd SendEmailWhenSystemStart
git pull https://github.com/ZealShah96/SendEmailWhenSystemStart.git
echo feting of files from git is done
echo delete csproj file
del SendEmailWhenLaptopStart.csproj
echo csproj file deleted
echo rebulid project
dotnet new console --force
echo csproj file deleted
REM echo We are changing path to that specific folder
REM cd /d D:\My Experiments\SendEmailWhenLaptopStart
echo We are running dotnet application
dotnet run program.cs
pause
