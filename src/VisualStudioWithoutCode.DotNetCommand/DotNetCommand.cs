using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace VisualStudioWithoutCode.DotNetCommand;

public interface IDotNetCommand
{
    string ProjectName { get; }
    string ProjectPath { get; }

    void CreateProject(string path, string name);
}

public class DotNetCommand : IDotNetCommand
{
    public string ProjectName { get; private set; }
    public string ProjectPath { get; private set; }

    public void CreateProject(string path, string name)
    {
        ProjectPath = path;
        ProjectName = name;

        ProcessStartInfo startInfo = new()
        {
            FileName = "cmd.exe",
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = new()
        {
            StartInfo = startInfo
        };
        process.Start();

        using (StreamWriter streamWriter = process.StandardInput)
        {
            if (streamWriter.BaseStream.CanWrite)
            {
                streamWriter.WriteLine($"cd {ProjectPath}");
                streamWriter.WriteLine($"dotnet new classlib -n {ProjectName}");
            }
        }
    }
    public IEnumerable<string> ProjectFiles;
}
