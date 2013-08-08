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
            //lbl_oneDesc.Text = "Created by Whit33r \nSpecial thanks: ConanHUN";
            //lbl_twoDesc.Text = "If you liked it and would like to see\nmore like this software, please donate.";
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
            string cmd = "mailto:foo@bar.com";
            Process.Start(cmd);
            
        }
    }
}
