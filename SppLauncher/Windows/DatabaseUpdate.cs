using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SppLauncher.Windows
{
    public partial class DatabaseUpdate : Form
    {
        private int count, complete;
        private Launcher launcher;
        public DatabaseUpdate(Launcher otLauncher)
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            this.launcher = otLauncher;
            DisableCloseButton();
            start();
        }

        #region DisableX

        internal const int SC_CLOSE = 0xF060;
        internal const int MF_GRAYED = 0x1;
        internal const int MF_ENABLED = 0x00000000;
        internal const int MF_DISABLED = 0x00000002;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr HWNDValue, bool Revert);

        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr tMenu, int targetItem, int targetStatus);

        public void EnableCloseButton() //A standard void function to invoke EnableMenuItem()
        {
            EnableMenuItem(GetSystemMenu(this.Handle, false), SC_CLOSE, MF_ENABLED);
        }

        public void DisableCloseButton() //A standard void function to invoke EnableMenuItem()
        {
            EnableMenuItem(GetSystemMenu(this.Handle, false), SC_CLOSE, MF_GRAYED);
        }

        #endregion



        public void start()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 100;
            bWdbUp1.RunWorkerAsync();
        }

        private void bWdbUp1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Directory.Exists("update\\mangos"))
            {
                label3.Text = "Drop Mangos";
                InsertSingle(@"update\mangos\mangos_recreate_database.sql");
                label3.Text = "Insert YTDB";
                InsertMultiple(@"update\ytdb\full", "ytdb*mangos*sql", false);
            }
        }

        private void bWdbUp1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;

            bWdbUp.RunWorkerAsync();
        }

        private void bWdbUp_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Directory.Exists("update\\mangos"))
            {
                if (Directory.Exists("update\\ytdb\\update"))
                {
                    label3.Text = "YTDB Update";
                    InsertMultiple(@"update\ytdb\update", "*mangos*sql",true);
                }
            }
            if (Directory.Exists(@"update\mangos\updates"))
            {
                label3.Text = "Mangos Update";
                InsertMultiple(@"update\mangos\updates", "*sql",true);
            }
            if (Directory.Exists(@"update\mangos\sql_mr"))
            {
                label3.Text = "Custom Mangos Tables";
                InsertSingle(@"update\mangos\sql_mr\custom_mangos_tables.sql");
                label3.Text = "Update Mangos";
                InsertMultiple(@"update\mangos\sql_mr", "mr*mangos*sql",true);
            }
        }

        private void bWdbUp_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bWdbUp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 100;
            bWdbUpS.RunWorkerAsync();
        }

        private void bWdbUpS_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Directory.Exists("update\\scriptdev"))
            {
                label3.Text = "Update ScriptDev2";
                RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2_drop_database.sql");
                RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_database.sql");
                RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_structure_mysql.sql");
                RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\custom_scriptdev2_bsw_table.sql");
                RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_clear.sql");
                RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_full.sql");
            }
        }

        private void bWdbUpS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            bWdvUpS1.RunWorkerAsync();
        }

        private void bWdvUpS1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(10);
                InsertMultiple1(@"update\scriptdev2\sql_mr", "mangos", "mr*mangos*sql");
                Thread.Sleep(10);
                InsertMultiple1(@"update\scriptdev2\sql_mr", "scriptdev2", "mr*scriptdev2*sql");
                Thread.Sleep(10);
                label3.Text = "Complete!";
                label2.Text = "-";
                if (Directory.Exists(@"update\server")) { Copy(@"update\server", @"\SingleCore"); }
                Directory.Delete(@"update", true);
                EnableCloseButton();
                Thread.Sleep(2000);
            

        }

        private void bWdvUpS1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bWdvUpS1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            launcher.Show();

            if(!Launcher.OnlyMysqlStart){this.launcher.RealmdStart();}
            else
            {
                launcher.pbAvailableM.Visible = false;
                launcher.pbNotAvailM.Visible = true;
                Launcher.OnlyMysqlStart = false;
                Launcher.MysqlON = false;
               Launcher.ShutdownSql();
            }
            this.Close();
        }

        public void InsertMultiple(string updatePath, string filter, bool bwup1)
        {
            try
            {
                String[] Files = Directory.GetFiles(updatePath, filter, SearchOption.TopDirectoryOnly);
                if(bwup1){progressBar1.Maximum = Files.Length;}
                complete = 0;
                Thread.Sleep(10);
                foreach (String aFile in Files)
                {
                    label2.Text = Path.GetFileName(aFile);
                    RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", aFile);

                    if (bwup1) { complete++; bWdbUp.ReportProgress(complete); }
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertMultiple1(string updatePath,string db, string filter)
        {
            try
            {
                String[] Files = Directory.GetFiles(updatePath, filter, SearchOption.TopDirectoryOnly);
                progressBar1.Maximum = Files.Length;
                complete = 0;
                Thread.Sleep(10);
                foreach (String aFile in Files)
                {
                    label2.Text = Path.GetFileName(aFile);
                    RunMySql("127.0.0.1", 3310, "root", "123456", db, aFile);

                    complete++; 
                    bWdvUpS1.ReportProgress(complete);
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertSingle(string Path)
        {

            string path = Path;

            try
            {
                RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int RunMySql(string server, int port, string user, string password, string database, string filename)
        {
                var process = Process.Start(
                    new ProcessStartInfo
                    {
                        FileName = @"Database\bin\mysql.exe",
                        Arguments =
                            String.Format(
                                "-C -B --host={0} -P {1} --user={2} --password={3} --database={4} -e \"\\. {5}\"",
                                server, port, user, password, database, filename),
                        ErrorDialog            = false,
                        CreateNoWindow         = true,
                        UseShellExecute        = false,
                        RedirectStandardError  = true,
                        RedirectStandardInput  = true,
                        RedirectStandardOutput = true,
                        WorkingDirectory       = Environment.CurrentDirectory,
                    }
                    );
            

            process.OutputDataReceived += (o, e) => Console.Out.WriteLine(e.Data);
            process.ErrorDataReceived  += (o, e) => Console.Error.WriteLine(e.Data);
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.StandardInput.Close();
            process.WaitForExit();
            return process.ExitCode;
        }

        public static int RunMySqlWitoutDb(string server, int port, string user, string password, string filename)
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


            process.OutputDataReceived += (o, e) => Console.Out.WriteLine(e.Data);
            process.ErrorDataReceived += (o, e) => Console.Error.WriteLine(e.Data);
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.StandardInput.Close();
            process.WaitForExit();
            return process.ExitCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisableCloseButton();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }
    }


}
