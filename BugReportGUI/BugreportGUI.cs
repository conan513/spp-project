using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BugReportGUI.Properties;
using ns;

namespace BugReportGUI
{
    public partial class BugreportGUI : Form
    {
        public static string item, item2, selectedpath, Bugpath, logpath;
        public int chckcount;

        private DirectoryInfo di;
        public BugreportGUI()
        {
            InitializeComponent();
            try
            {
                Bugpath      = Settings.Default["path"].ToString();
                if(Bugpath  != "") di = new DirectoryInfo(Bugpath);
                if (Bugpath != "") chckcount = Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length;

                if (Bugpath == "")
                {
                    Dialog();
                }
                else
                {
                    test(di);
                    tmrCheck.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void test(DirectoryInfo dir)
        {
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                if (d.ToString() != "Logs")
                {
                    lbDate.Items.Add(d);
                }
            }
        }

        private void Dialog()
        {
            fbdPath.ShowNewFolderButton = false;
            fbdPath.RootFolder          = Environment.SpecialFolder.MyComputer;

            DialogResult result = fbdPath.ShowDialog();
            if (result          == DialogResult.OK)
            {
                lbDate.Items.Clear();
                delAllField();
                Bugpath                  = fbdPath.SelectedPath;
                Settings.Default["path"] = Bugpath;
                Settings.Default.Save();
                di = new DirectoryInfo(Bugpath);
                test(di);
                chckcount = Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDate.SelectedItem != null)
            {
                try
                {
                    foreach (int i in lbDate.SelectedIndices)
                    {
                        delAllField();
                        item = lbDate.Items[i].ToString();
                    }

                    string[] files = Directory.GetFiles(Bugpath+ "\\" + item);

                    NumericComparer ns = new NumericComparer();
                    Array.Sort(files, ns); ;

                    foreach (string afile in files)
                    {
                        selectedpath     = afile;
                        string file      = File.ReadAllText(afile);
                        string[] content = file.Split(';');
                        lbReports.Items.Add(content[1] + " (" + content[2] + ")");
                    }
                }
                catch
                {
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in lbReports.SelectedIndices)
                {
                    item2 = lbReports.Items[i].ToString();
                }
                int s = lbReports.SelectedIndex;
                s++;
                string file      = File.ReadAllText(Bugpath + "\\" + item + "\\" + s + ".txt");

                if (File.Exists(Bugpath + "\\Logs\\" + item + "\\" + s + "_Logs.zip"))
                {
                    logpath = Bugpath + "\\Logs\\" + item + "\\" + s + "_Logs.zip";
                    btnLog.Enabled = true;
                }
                else
                {
                    btnLog.Enabled = false;
                }

                string[] content = file.Split(';');
                txbMail.Text     = content[1];
                txbType.Text     = content[2];
                txbDesc.Text     = content[3];
                textBox1.Text = content[9];
                txbSysinfo.Text = "Cpu:" + content[4] + Environment.NewLine + "Core:" + content[5] + Environment.NewLine + "Total Memory: " + content[6] + "Mb" + Environment.NewLine + "Operation System:" + content[7] + Environment.NewLine + content[8];
            }
            catch
            {
            }
        }

        private void changePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog();
        }

        public void refresh()
        {
            lbDate.Items.Clear();
            delAllField();
            di = new DirectoryInfo(Bugpath);
            test(di);
        }

        public void delAllField()
        {
            lbReports.Items.Clear();
            txbMail.Text    = "";
            txbDesc.Text    = "";
            txbType.Text    = "";
            txbSysinfo.Text = "";
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            
            if (chckcount != Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length)
            {
                chckcount = Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length;
                refresh();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Process.Start(logpath);
        }
    }
}
