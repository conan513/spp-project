using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SppLauncher.Windows.Launcher;

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
                if (File.Exists(@"hu\SppLauncher.resources_new.dll"))
                {
                    if (File.Exists(@"hu\SppLauncher.resources.dll"))
                    {
                        File.Move(@"hu\SppLauncher.resources.dll", @"hu\SppLauncher.resources_old.dll");
                        File.SetAttributes(@"hu\SppLauncher.resources_old.dll", FileAttributes.Hidden);

                        File.Move(@"de\SppLauncher.resources.dll", @"de\SppLauncher.resources_old.dll");
                        File.SetAttributes(@"de\SppLauncher.resources_old.dll", FileAttributes.Hidden);

                        File.Move(@"fr\SppLauncher.resources.dll", @"fr\SppLauncher.resources_old.dll");
                        File.SetAttributes(@"fr\SppLauncher.resources_old.dll", FileAttributes.Hidden);
                    }

                    Thread.Sleep(100);

                    File.Move(@"hu\SppLauncher.resources_new.dll", @"hu\SppLauncher.resources.dll");
                    File.SetAttributes(@"hu\SppLauncher.resources.dll", FileAttributes.Normal);

                    File.Move(@"de\SppLauncher.resources_new.dll", @"de\SppLauncher.resources.dll");
                    File.SetAttributes(@"de\SppLauncher.resources.dll", FileAttributes.Normal);

                    File.Move(@"fr\SppLauncher.resources_new.dll", @"fr\SppLauncher.resources.dll");
                    File.SetAttributes(@"fr\SppLauncher.resources.dll", FileAttributes.Normal);
                }
            }
            catch (Exception)
            {
            }
        }

        public void DelLang()
        {
            try
            {
                if (Directory.Exists("Languages"))
                {
                    File.Delete(@"Languages\hu\SppLauncher.resources.dll");
                    File.Delete(@"Languages\fr\SppLauncher.resources.dll");
                    File.Delete(@"Languages\de\SppLauncher.resources.dll");
                    Directory.Delete(@"Languages\hu");
                    Directory.Delete(@"Languages\fr");
                    Directory.Delete(@"Languages\de");
                    Directory.Delete(@"Languages");
                }
            }
            catch (Exception)
            {
            }
        }

        private void DelOldLang()
        {
            try
            {
                if (File.Exists(@"hu\SppLauncher.resources_old.dll"))
                {
                    File.Delete(@"hu\SppLauncher.resources_old.dll");
                    File.Delete(@"fr\SppLauncher.resources_old.dll");
                    File.Delete(@"de\SppLauncher.resources_old.dll");
                }
            }
            catch (Exception)
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
                DelOldLang();
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
