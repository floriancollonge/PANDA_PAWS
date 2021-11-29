#!/bin/sh

dotnet pack
mv bin/Debug/*.nupkg ../libs

#dotnet add package Corkscrew --version=1.0.0 -s /media/fcollonge/82DCA32BDCA31905/Workspace/dfwa_v2/cap/libs