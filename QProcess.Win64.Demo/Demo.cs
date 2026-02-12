?//+#nuget QProcess.Win64;
using Global;
using static Global.EasyObject;

Echo(new { args });
//QProcess.Win64.Execute("wget2", ["https://github.com/msys2/msys2-installer/releases/download/2025-12-13/msys2-x86_64-20251213.exe"], @"C:\ProgramData\home13\cs\process");
QProcess.Win64.Launch("wget2", ["https://github.com/msys2/msys2-installer/releases/download/2025-12-13/msys2-x86_64-20251213.exe"], @"C:\ProgramData\home13\cs\process");
