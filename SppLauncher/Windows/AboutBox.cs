using System;
using System.Diagnostics;
using System.Windows.Forms;
using SppLauncher.Windows.Launcher;

namespace SppLauncher
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                lblLocalemu.Text = Launcher.CurrEmuVer.ToString();
                lbl_LocalV.Text = Launcher.CurrProgVer + ".4236";
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.patreon.com/conan513");
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/whit33r");
        }
    }
}
