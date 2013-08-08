using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SppLauncher
{
    public partial class Loader : Form
    {
        public static bool kill = false, Available, AllowUpdaterQuestion = false, allowShow = false, test = false;
        public static double RemoteEmuVer, currEmuVer;
        public static string RemoteProgVer, currProgVer = "1.0.5", sql;
        private bool  updateNO;
        private bool updateYes;
        private Process _cmd3;
        private string sqlpath = "Database\\bin\\";

        public Loader()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();

            SqlStartCheck.Start();
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

        private readonly Random rnd = new Random();

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

       

  

        public bool CheckRunsql()
        {
            foreach (Process proc in Process.GetProcessesByName("mysqld"))
            {
                return true;
            }
            return false;
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
