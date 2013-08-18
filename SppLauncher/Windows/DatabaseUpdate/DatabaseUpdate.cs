using System;
using System.ComponentModel;
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
        private readonly RunMysql run;
        public DatabaseUpdate(Launcher otLauncher)
        {
            InitializeComponent();
            run = new RunMysql();
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
            bWdbUp.RunWorkerAsync();
            
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
            run.RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2_drop_database.sql");
            run.RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_database.sql");
            run.RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2_create_structure_mysql.sql");
            run.RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2", @"update\scriptdev2\sql\scriptdev2\sql\custom_scriptdev2_bsw_table.sql");
            run.RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_clear.sql");
            run.RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", @"update\scriptdev2\sql\scriptdev2\sql\mangos_scriptname_full.sql");

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
                    run.RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", aFile);

                    complete++; bWdbUp.ReportProgress(complete);
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
                    run.RunMySql("127.0.0.1", 3310, "root", "123456", db, aFile);

                    complete++;
                    bWdbUp.ReportProgress(complete);
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


                run.RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


    }


}
