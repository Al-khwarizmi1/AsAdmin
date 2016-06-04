using System.Diagnostics;
using System.IO;

namespace cmda
{
    public class Program
    {
        private static void Main()
        {
            var p = new Process
            {
                StartInfo =
                {
                    FileName = @"C:\Windows\system32\cmd.exe",
                    UseShellExecute = true,
                    Verb = "runas",
                    Arguments = $"/s /k pushd \"{Directory.GetCurrentDirectory()}\" "
                }
            };

            p.Start();
        }
    }
}
