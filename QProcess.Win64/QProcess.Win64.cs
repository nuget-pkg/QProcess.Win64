//+#inc QProcess.Win64.swig.cs
//+#nuget EasyObject
using System;

namespace QProcess;

public class Win64
{
    public static int Execute(string exe, string[] args, string? cwd = null)
    {
        if (cwd == null) cwd = "";
        Global.EasyObject.Log(new { exe = exe, args = args, cwd = cwd });
        return QProcess_Win64.Execute3(exe, string.Join("\t", args), cwd);
    }
    public static void Launch(string exe, string[] args, string? cwd = null)
    {
        if (cwd == null) cwd = "";
        Global.EasyObject.Log(new { exe = exe, args = args, cwd = cwd });
        QProcess_Win64.Launch3(exe, string.Join("\t", args), cwd);
        //QProcess_Win64.Execute4(true, exe, string.Join("\t", args), cwd);
    }
    public static int Run(bool windowed, string exe, string[] args, string? cwd = null)
    {
        if (cwd == null) cwd = "";
        Global.EasyObject.Log(new { exe = exe, args = args, cwd = cwd });
        int exitCode = QProcess_Win64.Execute4(windowed, exe, string.Join("\t", args), cwd);
        return exitCode;
    }
    public static int RunAndPause(bool windowed, string exe, string[] args, string? cwd = null)
    {
        if (cwd == null) cwd = "";
        Global.EasyObject.Log(new { exe = exe, args = args, cwd = cwd });
        int exitCode = QProcess_Win64.Execute4(windowed, exe, string.Join("\t", args), cwd);
        Console.Error.Write("Press ENTER to continue: ");
        Console.In.ReadLine();
        return exitCode;
    }
}
