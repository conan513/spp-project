using System;
using System.Diagnostics;
using System.Windows.Forms;

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
            label1.Text = "Launcher and tools by Whit33r";
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                lblLocalemu.Text = Launcher.CurrEmuVer.ToString();
                lbl_LocalV.Text = Launcher.currProgVer;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://my.opera.com/conan513/blog/");
            
        }
    }
}
