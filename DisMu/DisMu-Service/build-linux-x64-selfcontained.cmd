del /f /q /s bin\dismu-linux-x64 > nul
rmdir /q /s bin\dismu-linux-x64
dotnet publish --configuration Release --output bin\dismu-linux-x64 --framework netcoreapp3.1 --self-contained true --runtime linux-x64
pause