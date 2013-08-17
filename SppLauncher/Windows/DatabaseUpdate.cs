using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SppLauncher.Windows
{
    public partial class DatabaseUpdate : Form
    {
        private int count, complete;
        private readonly Launcher launcher;
        public DatabaseUpdate(Launcher otLauncher)
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            launcher = otLauncher;
            DisableCloseButton();
            Start();
            
        }

        #region DisableX

        private const int ScClose = 0xF060;
        private const int MfGrayed = 0x1;
        private const int MfEnabled = 0x00000000;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hwndValue, bool revert);

        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr tMenu, int targetItem, int targetStatus);

        private void EnableCloseButton()
        {
            EnableMenuItem(GetSystemMenu(Handle, false), ScClose, MfEnabled);
        }

        private void DisableCloseButton()
        {
            EnableMenuItem(GetSystemMenu(Handle, false), ScClose, MfGrayed);
        }

        #endregion

        private void Start()
        {
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

            if (Directory.Exists("update\\mangos"))
            {
                if (Directory.Exists("update\\ytdb\\update"))
                {
                    label3.Text = "YTDB Update";
                    InsertMultiple(@"update\ytdb\update", "*mangos*sql", true);
                }
            }
            if (Directory.Exists(@"update\mangos\updates"))
            {
                label3.Text = "Mangos Update";
                InsertMultiple(@"update\mangos\updates", "*sql", true);
            }
            if (Directory.Exists(@"update\mangos\sql_mr"))
            {
                label3.Text = "Custom Mangos Tables";
                InsertSingle(@"update\mangos\sql_mr\custom_mangos_tables.sql");
                label3.Text = "Update Mangos";
                InsertMultiple(@"update\mangos\sql_mr", "mr*mangos*sql", true);
            }

            label3.Text = "Update ScriptDev2";
            RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2_drop_database.sql");
            RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_database.sql");
            RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_structure_mysql.sql");
            RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\custom_scriptdev2_bsw_table.sql");
            RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_clear.sql");
            RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_full.sql");

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

        private void bWdbUp1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Launcher.dbupdate = false;
            launcher.Show();

            if (!Launcher.OnlyMysqlStart) { launcher.RealmdStart(); }
            else
            {
                launcher.pbAvailableM.Visible = false;
                launcher.pbNotAvailM.Visible = true;
                Launcher.OnlyMysqlStart = false;
                Launcher.MysqlON = false;
                Launcher.ShutdownSql();
            }
            Close();
        }

        private void bWdbUp_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (Directory.Exists("update\\mangos"))
            //{
            //    if (Directory.Exists("update\\ytdb\\update"))
            //    {
            //        label3.Text = "YTDB Update";
            //        InsertMultiple(@"update\ytdb\update", "*mangos*sql",true);
            //    }
            //}
            //if (Directory.Exists(@"update\mangos\updates"))
            //{
            //    label3.Text = "Mangos Update";
            //    InsertMultiple(@"update\mangos\updates", "*sql",true);
            //}
            //if (Directory.Exists(@"update\mangos\sql_mr"))
            //{
            //    label3.Text = "Custom Mangos Tables";
            //    InsertSingle(@"update\mangos\sql_mr\custom_mangos_tables.sql");
            //    label3.Text = "Update Mangos";
            //    InsertMultiple(@"update\mangos\sql_mr", "mr*mangos*sql",true);
            //}
        }

        private void bWdbUp_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
        }

        private void bWdbUp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //progressBar1.Style = ProgressBarStyle.Marquee;
            //progressBar1.MarqueeAnimationSpeed = 100;
            //bWdbUpS.RunWorkerAsync();
        }

        private void bWdbUpS_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (Directory.Exists("update\\scriptdev"))
            //{
            //    label3.Text = "Update ScriptDev2";
            //    RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2_drop_database.sql");
            //    RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_database.sql");
            //    RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_structure_mysql.sql");
            //    RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\custom_scriptdev2_bsw_table.sql");
            //    RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_clear.sql");
            //    RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_full.sql");
            //}
        }

        private void bWdbUpS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //progressBar1.Style = ProgressBarStyle.Blocks;
            //bWdvUpS1.RunWorkerAsync();
        }

        private void bWdvUpS1_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void bWdvUpS1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
        }

        private void bWdvUpS1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //launcher.Show();

            //if (!Launcher.OnlyMysqlStart) { launcher.RealmdStart(); }
            //else
            //{
            //    launcher.pbAvailableM.Visible = false;
            //    launcher.pbNotAvailM.Visible = true;
            //    Launcher.OnlyMysqlStart = false;
            //    Launcher.MysqlON = false;
            //    Launcher.ShutdownSql();
            //}
            //Close();
        }

        private void InsertMultiple(string updatePath, string filter, bool bwup1)
        {
            try
            {
                String[] files = Directory.GetFiles(updatePath, filter, SearchOption.TopDirectoryOnly);
                progressBar1.Maximum = files.Length;
                complete = 0;
                Thread.Sleep(10);
                foreach (String aFile in files)
                {
                    label2.Text = Path.GetFileName(aFile);
                    RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", aFile);

                    complete++; bWdbUp1.ReportProgress(complete);
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertMultiple1(string updatePath,string db, string filter)
        {
            try
            {
                String[] files = Directory.GetFiles(updatePath, filter, SearchOption.TopDirectoryOnly);
                progressBar1.Maximum = files.Length;
                complete = 0;
                Thread.Sleep(10);
                foreach (String aFile in files)
                {
                    label2.Text = Path.GetFileName(aFile);
                    RunMySql("127.0.0.1", 3310, "root", "123456", db, aFile);

                    complete++;
                    bWdbUp1.ReportProgress(complete);
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertSingle(string Path)
        {
            try
            {
            if (Path == null) throw new ArgumentNullException("Path");

            string path = Path;


                RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void RunMySql(string server, int port, string user, string password, string database, string filename)
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

            //process.OutputDataReceived += (o, e) => Console.Out.WriteLine(e.Data);
            //process.ErrorDataReceived  += (o, e) => Console.Error.WriteLine(e.Data);
            ////process.Start();
            //process.BeginErrorReadLine();
            //process.BeginOutputReadLine();
            //process.StandardInput.Close();
            process.WaitForExit();
        }

        private static void RunMySqlWitoutDb(string server, int port, string user, string password, string filename)
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


           // process.OutputDataReceived += (o, e) => Console.Out.WriteLine(e.Data);
           // process.ErrorDataReceived += (o, e) => Console.Error.WriteLine(e.Data);
           //// process.Start();
           // process.BeginErrorReadLine();
           // process.BeginOutputReadLine();
           // process.StandardInput.Close();
            process.WaitForExit();
        }

        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }

        private void bWdbUp1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bWdbUp1_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }


}
