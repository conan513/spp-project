using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SppLauncher.Windows
{
    class RunMysql
    {

        public void run(List<String> commands)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"Database\bin\mysql.exe";
            processStartInfo.Arguments = String.Format(
                "-C -B --host={0} -P {1} --user={2} --password={3} --database={4} -e \"\\. {5}\"",
                server, port, user, password, database, filename);

        }

        public void RunMySql(string server, int port, string user, string password, string database, string filename)
        {
            var process = Process.Start(
                new ProcessStartInfo
                {
                    FileName = @"Database\bin\mysql.exe",
                    Arguments =
                        String.Format(
                            "-C -B --host={0} -P {1} --user={2} --password={3} --database={4} -e \"\\. {5}\"",
                            server, port, user, password, database, filename),
                    ErrorDialog = false,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    WorkingDirectory = Environment.CurrentDirectory,
                }
                );
            process.WaitForExit();
        }

        public void RunMySqlWitoutDb(string server, int port, string user, string password, string filename)
        {
            var process = Process.Start(
                new ProcessStartInfo
                {
                    FileName = @"Database\bin\mysql.exe",
                    Arguments =
                        String.Format(
                            "-C -B --host={0} -P {1} --user={2} --password={3} -e \"\\. {4}\"",
                            server, port, user, password, filename),
                    ErrorDialog = false,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    WorkingDirectory = Environment.CurrentDirectory,
                }
                );
            process.WaitForExit();
        }
    }
}
