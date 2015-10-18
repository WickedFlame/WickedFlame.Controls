@echo off

echo Begin create nuget for WickedFlame.Controls.Shell
nuget.exe pack ..\src\NuGetPackageManager\WickedFlame.Controls.Shell.nuspec

echo End create nuget for WickedFlame Controls
pause