using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SppLauncher
{
    public partial class Loader : Form
    {
        public static bool Kill = false;

        public Loader()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            DelLang();
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

        public void WasThisLangUpdate()
        {
            try
            {
                if (File.Exists(@"Languages\hu\SppLauncher.resources_new.dll"))
                {
                    File.Delete(@"Languages\hu\SppLauncher.resources.dll");
                    File.Delete(@"Languages\de\SppLauncher.resources.dll");
                    File.Delete(@"Languages\fr\SppLauncher.resources.dll");

                    File.Move(@"Languages\hu\SppLauncher.resources_new.dll", @"Languages\hu\SppLauncher.resources.dll");
                    File.SetAttributes(@"Languages\hu\SppLauncher.resources.dll", FileAttributes.Normal);

                    File.Move(@"Languages\de\SppLauncher.resources_new.dll", @"Languages\de\SppLauncher.resources.dll");
                    File.SetAttributes(@"Languages\de\SppLauncher.resources.dll", FileAttributes.Normal);

                    File.Move(@"Languages\fr\SppLauncher.resources_new.dll", @"Languages\fr\SppLauncher.resources.dll");
                    File.SetAttributes(@"Languages\fr\SppLauncher.resources.dll", FileAttributes.Normal);
                }
            }
            catch
            {
            }
        }

        public void DelLang()
        {
            try
            {
                if (File.Exists(@"hu\SppLauncher.resources.dll"))
                {
                    File.Delete(@"hu\SppLauncher.resources.dll");
                    File.Delete(@"fr\SppLauncher.resources.dll");
                    File.Delete(@"de\SppLauncher.resources.dll");

                    Directory.Delete("hu");
                    Directory.Delete("fr");
                    Directory.Delete("de");
                }
            }
            catch
            {
            }
        }

        private readonly Random _rnd = new Random();

        private int GetRandomInt()
        {
            return _rnd.Next(0, 3);
        }

        private void ShowSplashScreen_Tick(object sender, EventArgs e)
        {
            Opacity += 0.04;

            if (Opacity >= 1)
            {
                ShowSplashScreen.Stop();
                WasThisLangUpdate();
                Thread.Sleep(2000);
                HideSplashScreen.Start();
            }
        }

        private void HideSplashScreen_Tick(object sender, EventArgs e)
        {
            while (Opacity != 0)
            {
                this.Opacity -= 0.04;
                Thread.Sleep(10);
            }
            HideSplashScreen.Stop();
            GetProccess();
            Show();
            Hide();
        }

        private new void Show()
        {
            var show = new Launcher();
            show.Show();
        }

        private void CloseForm_Tick(object sender, EventArgs e)
        {
            if (Kill)
            {
                Close();
            }
        }


        private bool CheckRunsql()
        {
            return Process.GetProcessesByName("mysqld").Any();
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
