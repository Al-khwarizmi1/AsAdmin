using System.Diagnostics;
using System.IO;

namespace psa
{
    class Program
    {
        static void Main()
        {
            var p = new Process
            {
                StartInfo =
                {
                    FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0",
                    UseShellExecute = true,
                    Verb = "runas",
                    Arguments = $"-noexit -command \"cd '{Directory.GetCurrentDirectory()}'\" "
                }
            };

            p.Start();
        }
    }
}
