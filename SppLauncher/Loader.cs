using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace SppLauncher
{
    public partial class Loader : Form
    {
        public static bool kill = false, Available, AllowUpdaterQuestion = false, allowShow = false, test = false;
        public static double RemoteEmuVer, currEmuVer;
        public static string RemoteProgVer, currProgVer = "1.0.5", sql;
        private bool  updateNO = false;
        private bool updateYes = false;
        private Process _cmd3;
        private string sqlpath = "Database\\bin\\";

        public Loader()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();

            SqlStartCheck.Start();
            //bwUpdate.RunWorkerAsync();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            switch (GetRandomInt())
            {
                case 0:
                    pictureBox1.Visible = true;
                    break;
                case 1:
                    pictureBox2.Visible = true;
                    break;
                case 2:
                    pictureBox3.Visible = true;
                    break;
            }
            Opacity = 0;
            ShowSplashScreen.Start();
            CloseForm.Start();
        }

        private void GetProccess()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Single Player Project is already running!", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private Random rnd = new Random();

        protected int GetRandomInt()
        {
            return rnd.Next(0, 3);
        }

        private void ShowSplashScreen_Tick(object sender, EventArgs e)
        {
            Opacity += 0.04;

            if (this.Opacity >= 1)
            {
                ShowSplashScreen.Stop();
                Thread.Sleep(2000);
                HideSplashScreen.Start();
            }
        }

        private void HideSplashScreen_Tick(object sender, EventArgs e)
        {
            while (this.Opacity != 0)
            {
                this.Opacity -= 0.04;
                Thread.Sleep(10);
            }
            HideSplashScreen.Stop();
            GetProccess();
            Show();
            Hide();
        }

        public new void Show()
        {
            var show = new Launcher();
            show.Show();
        }

        private void CloseForm_Tick(object sender, EventArgs e)
        {
            if (kill)
            {
                Close();
            }
        }

        private void bwUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var client     = new WebClient();
                Stream stream  = client.OpenRead("http://dl.dropbox.com/u/7587303/Updates/SppLauncher.txt");
                var reader     = new StreamReader(stream);
                String content = reader.ReadToEnd();
                string[] parts = content.Split(':');
                content        = parts[0];
                RemoteEmuVer   = Convert.ToDouble(parts[1]);
                RemoteProgVer  = content;

                if (content != currProgVer)
                {
                    test = false;
                    if (
                        MessageBox.Show("New Version Available: V" + content + "\n" + "You want to download?",
                                        "New Version", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        updateYes = true;
                    }
                    else
                    {
                        updateNO = true;
                        test = true;
                    }
                }
                else
                {
                    test = true;
                }
            }
            catch (Exception)
            {
                Available = false;
            }

            currEmuVer = Convert.ToDouble(File.ReadAllText("SingleCore\\version"));

            if (RemoteEmuVer > currEmuVer && test)
            {
               
                if (!AllowUpdaterQuestion)
                {
                    allowShow = true;
                    DialogResult dialog =
                        MessageBox.Show(
                            "New Server/Database update available: V" + RemoteEmuVer + "\nYou want to download?",
                            "Question",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                    if (dialog == DialogResult.Yes)
                    {
                        Startsql();
                        SqlStartCheck.Start();
                        // Hide();
                        //var startInfo = new ProcessStartInfo();
                        //startInfo.FileName = "Updater.exe";
                        //startInfo.Arguments = "-u";
                        //Process.Start(startInfo);
                        //UpdateComplete.Start();
                    }
                    else
                    {
                        updateNO = true;
                        //  HideSplashScreen.Start();
                    }
                }
                else
                {
                    var startInfo       = new ProcessStartInfo();
                    startInfo.FileName  = "Updater.exe";
                    startInfo.Arguments = "-u";
                    Process.Start(startInfo);
                }
            }
        }

        private void bwUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (updateYes)
            {
                Thread.Sleep(1000);
                var update = new Update();
                update.Show();
            }

            if (!allowShow)
            {
                HideSplashScreen.Start();
            }

            if (updateNO)
            {
                HideSplashScreen.Start();

            }

            AllowUpdaterQuestion = false;
            UpdateComplete.Start();

        }

        private void UpdateComplete_Tick(object sender, EventArgs e)
        {
            try
            {
                double version = Convert.ToDouble(File.ReadAllText("SingleCore\\version"));

                if (version > currEmuVer)
                {
                    UpdateComplete.Stop();
                    if (RemoteEmuVer > version)
                    {
                        AllowUpdaterQuestion = true;
                        bwUpdate.RunWorkerAsync();
                    }

                    if (!AllowUpdaterQuestion)
                    {
                        Thread.Sleep(20);
                        foreach (Process proc in Process.GetProcessesByName("Updater"))
                        {
                            proc.Kill();
                        }

                       // Show();

                        //  NotifyBallon(1000, "Update Completed", "Server starting...", false);
                        try
                        {
                            Process.Start("notepad.exe", "Update\\changelog");
                            ShutdownSql();
                        }
                        catch (Exception)
                        {
                        }
                        //   RealmWorldRestart();


                        //   allowupdaternorunwow = false;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void SqlStartCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                if (sql.Contains("Version: '10.0.1-MariaDB'  socket: ''  port: 3310  mariadb.org binary distribution"))
                {
                    SqlStartCheck.Stop();

                    //  DateTime end1        = DateTime.Now;
                    //lblSqlStartTime.Text   = (end1 - start1).TotalSeconds.ToString();
                    //  pbAvailableM.Visible = true;
                    //  pbTempM.Visible      = false;
                    sql                      = "";
                    //   RealmdStart();
                    Hide();
                    var startInfo = new ProcessStartInfo();
                    startInfo.FileName = "Updater.exe";
                    startInfo.Arguments = "-u";
                    Process.Start(startInfo);
                    UpdateComplete.Start();
                }
            }
            catch
            {
            }
        }

        private void ShutdownSql()
        {
            var startInfo             = new ProcessStartInfo();
            startInfo.CreateNoWindow  = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName        = "Database\\bin\\mysqladmin.exe";
            startInfo.Arguments       = "-u root -p123456 --port=3310 shutdown";
            startInfo.WindowStyle     = ProcessWindowStyle.Hidden;

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    timer1.Start();
                 //  if(!CheckRunsql())
                  // Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                                    
        }

        public bool CheckRunsql()
        {
            foreach (Process proc in Process.GetProcessesByName("mysqld"))
            {
                return true;
            }
            return false;
        }

        public void Startsql()
        {
            //   start1 = DateTime.Now;

            //status              = "Starting Mysql";
            //pbTempM.Visible     = true;
            //pbNotAvailM.Visible = false;
            var cmdStartInfo      = new ProcessStartInfo("cmd.exe",
                                                    "/C " + sqlpath + "mysqld.exe" +
                                                    " --defaults-file=" + sqlpath + "my.ini" +
                                                    " --standalone --console");
            cmdStartInfo.CreateNoWindow         = true;
            cmdStartInfo.RedirectStandardInput  = true;
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError  = true;
            cmdStartInfo.UseShellExecute        = false;
            cmdStartInfo.WindowStyle            = ProcessWindowStyle.Hidden;

            _cmd3 = new Process();
            try
            {
                _cmd3.StartInfo = cmdStartInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some exception: mysql\n" + ex.Message);
            }

            if (_cmd3.Start())
            {
                _cmd3.OutputDataReceived += _cmd_OutputDataReceived3;
                _cmd3.ErrorDataReceived  += _cmd_ErrorDataReceived3;
                _cmd3.Exited             += _cmd_Exited3;
                _cmd3.BeginOutputReadLine();
                _cmd3.BeginErrorReadLine();
            }
            else
            {
                _cmd3 = null;
            }
        }

        private void _cmd_OutputDataReceived3(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole3(e.Data);
        }

        private void UpdateConsole3(string textm)
        {
            UpdateConsole3(textm, null);
        }

        private void _cmd_ErrorDataReceived3(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole3(e.Data, Brushes.Red);
        }

        private void _cmd_Exited3(object sender, EventArgs e)
        {
            _cmd3.OutputDataReceived -= _cmd_OutputDataReceived3;
            _cmd3.Exited -= _cmd_Exited3;
        }

        private void SetText3(string text1)
        {
            if (richTextBox1.InvokeRequired)
            {
                SetTextCallback d = SetText3;
                Invoke(d, new object[] { text1 });
            }
            else
            {
                sql               += text1;
                richTextBox1.Text += text1 + Environment.NewLine;
                File.WriteAllText("logs\\mysql.txt", richTextBox1.Text);
            }
        }
        private delegate void SetTextCallback(string text);

        private void UpdateConsole3(string text, Brush color)
        {
            WriteLine3(text, color);
        }
        private void WriteLine3(string text, Brush color)
        {
            if (text != null)
            {
                SetText3(text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShutdownSql();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!CheckRunsql())
            {
                timer1.Stop();
                Show();
            }
        }
    }
}
