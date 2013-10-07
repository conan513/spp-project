using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using SppLauncher.Properties;
using SppLauncher.Windows.WowAccountCreator;

namespace SppLauncher.Windows
{
    public partial class DatabaseUpdate : Form
    {
        private int _complete;
        private readonly Launcher.Launcher _launcher;
        private readonly RunMysql run;
        private readonly FileCopyOverWrite _fileCopy;
        public DatabaseUpdate(Launcher.Launcher otLauncher)
        {
            InitializeComponent();
            run = new RunMysql();
            _fileCopy = new FileCopyOverWrite();
            Application.EnableVisualStyles();
            _launcher = otLauncher;
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
                lblStatus.Text = "Drop Mangos";
                InsertSingle(@"update\mangos\mangos_recreate_database.sql");
                lblStatus.Text = "Insert YTDB";
                InsertMultiple(@"update\ytdb\full", "ytdb*mangos*sql", false);
            }

            if (Directory.Exists("update\\mangos"))
            {
                if (Directory.Exists("update\\ytdb\\update"))
                {
                    lblStatus.Text = "YTDB Update";
                    InsertMultiple(@"update\ytdb\update", "*mangos*sql", true);
                }
            }
            if (Directory.Exists(@"update\mangos\updates"))
            {
                lblStatus.Text = "Mangos Update";
                InsertMultiple(@"update\mangos\updates", "*sql", true);
            }
            if (Directory.Exists(@"update\mangos\sql_mr"))
            {
                lblStatus.Text = "Custom Mangos Tables";
                InsertSingle(@"update\mangos\sql_mr\custom_mangos_tables.sql");
                lblStatus.Text = "Update Mangos";
                InsertMultiple(@"update\mangos\sql_mr", "mr*mangos*sql", true);
            }

            if (Directory.Exists(@"update\scriptdev2"))
            {
                lblStatus.Text = "Update ScriptDev2";
                run.RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456",
                    @"update\scriptdev2\sql\scriptdev2_drop_database.sql");
                run.RunMySqlWitoutDb("127.0.0.1", 3310, "root", "123456",
                    @"update\scriptdev2\sql\scriptdev2_create_database.sql");
                run.RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2",
                    @"update\scriptdev2\sql\scriptdev2_create_structure_mysql.sql");
                run.RunMySql("127.0.0.1", 3310, "root", "123456", "scriptdev2",
                    @"update\scriptdev2\sql\custom_scriptdev2_bsw_table.sql");
                run.RunMySql("127.0.0.1", 3310, "root", "123456", "mangos",
                    @"update\scriptdev2\sql\mangos_scriptname_clear.sql");
                run.RunMySql("127.0.0.1", 3310, "root", "123456", "mangos",
                    @"update\scriptdev2\sql\mangos_scriptname_full.sql");

                if (Directory.Exists(@"update\scriptdev2\sql_mr"))
                {
                    Thread.Sleep(10);
                    InsertMultiple1(@"update\scriptdev2\sql_mr", "mangos", "mr*mangos*sql");
                    Thread.Sleep(10);
                    InsertMultiple1(@"update\scriptdev2\sql_mr", "scriptdev2", "*sql");
                    Thread.Sleep(10);
                }
            }

            lblStatus.Text = "Complete!";
            lblFile.Text = "-";

            try
            {
                if (Directory.Exists(@"update\server")) { _fileCopy.Copy(@"update\server", "", true); }
                File.WriteAllText(@"SingleCore\version", File.ReadAllText(@"update\version"));
                Directory.Delete(@"update", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some exception: Copy\n" + ex.Message);
            }

            if (Directory.Exists(@"Database\char"))
            {
                InsertMultiple1(@"Database\char", "characters", "*sql");
            }

            EnableCloseButton();
            Thread.Sleep(2000);
        }

        private void bWdbUp1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Launcher.Launcher.Dbupdate = false;

            _launcher.Show();

            if (!Launcher.Launcher.OnlyMysqlStart) { _launcher.RealmdStart(); }
            else
            {
                _launcher.pbAvailableM.Visible = false;
                _launcher.pbNotAvailM.Visible = true;
                Launcher.Launcher.OnlyMysqlStart = false;
                Launcher.Launcher.MysqlOn = false;
                Launcher.Launcher.ShutdownSql();
                Launcher.Launcher.Status = Resources.Launcher_bwUpdate_RunWorkerCompleted_Up_to_date;
            }
            Close();
        }

        private void InsertMultiple(string updatePath, string filter, bool bwup1)
        {
            try
            {
                String[] files = Directory.GetFiles(updatePath, filter, SearchOption.TopDirectoryOnly);
                progressBar1.Maximum = files.Length;
                _complete = 0;
                Thread.Sleep(10);
                foreach (String aFile in files)
                {
                    lblFile.Text = Path.GetFileName(aFile);
                    run.RunMySql("127.0.0.1", 3310, "root", "123456", "mangos", aFile);
                    _complete++; bWdbUp.ReportProgress(_complete);
                    Thread.Sleep(10);
                }
            }
            catch (Exception)
            {
            }
        }

        private void InsertMultiple1(string updatePath,string db, string filter)
        {
            try
            {
                String[] files = Directory.GetFiles(updatePath, filter, SearchOption.TopDirectoryOnly);
                progressBar1.Maximum = files.Length;
                _complete = 0;
                Thread.Sleep(10);
                foreach (String aFile in files)
                {
                    lblFile.Text = Path.GetFileName(aFile);
                    run.RunMySql("127.0.0.1", 3310, "root", "123456", db, aFile);

                    _complete++;
                    bWdbUp.ReportProgress(_complete);
                    Thread.Sleep(10);
                }
            }
            catch (Exception)
            {
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
            catch (Exception)
            {
            }
        }

        private void bWdbUp1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }


    }


}
