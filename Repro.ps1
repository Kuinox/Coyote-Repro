dotnet publish
cd Coyote-Repro/bin/Debug/net6.0/publish
coyote rewrite .\Coyote-Repro.dll
ilverify "Coyote-Repro.dll" -r "*.dll" -r "C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.11\*.dll"