using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using BugReportGUI.Class;
using BugReportGUI.Properties;
using ns;

namespace BugReportGUI
{
    public partial class BugreportGUI : Form
    {
        public static string item, Bugpath, logpath,fileC;
        private bool _newItem;
        public int Chckcount;

        private DirectoryInfo di;
        public BugreportGUI()
        {
            InitializeComponent();
            Flash fl = new Flash();
            try
            {
                Bugpath = Settings.Default["path"].ToString();
                if(Bugpath != "") di = new DirectoryInfo(Bugpath);
                if(Bugpath != "") Chckcount = Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length;

                if (Bugpath == "")
                {
                    Dialog();
                }
                else
                {
                    Getdir(di);
                    tmrCheck.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            Chckcount = Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length;

            
        }

        private void ResizeColums(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        private void Getdir(DirectoryInfo dir)
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
                DelAllField();
                Bugpath                  = fbdPath.SelectedPath;
                Settings.Default["path"] = Bugpath;
                Settings.Default.Save();
                di = new DirectoryInfo(Bugpath);
                Getdir(di);
                Chckcount = Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDate.SelectedItem != null)
            {
                try
                {
                    btnCheck.Enabled = false;
                    foreach (int i in lbDate.SelectedIndices)
                    {
                        DelAllField();
                        item = lbDate.Items[i].ToString();
                    }

                    string[] files = Directory.GetFiles(Bugpath+ "\\" + item);

                    NumericComparer ns = new NumericComparer();
                    Array.Sort(files, ns); ;

                    foreach (string afile in files)
                    {
                        string file      = File.ReadAllText(afile);
                        string[] content = file.Split(';');
                        ListViewItem item1 = new ListViewItem(content[1] + " (" + content[2] + ")");
                        item1.ImageIndex = content[10] == "0" ? 1 : 0;
                        listView1.Items.Add(item1);
                        ResizeColums(listView1);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileC = fileC.Remove(fileC.Length - 1);
            int i = listView1.FocusedItem.Index + 1;
            File.WriteAllText(Bugpath + "\\" + item + "\\" + i + ".txt", fileC + "1");
            listBox1_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void changePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog();
        }

        public void refresh()
        {
            lbDate.Items.Clear();
            textBox1.Text = "";
            DelAllField();
            di = new DirectoryInfo(Bugpath);
            Getdir(di);
            Flash.FlashWindow.Start(FindForm());
            NotifyBallon(2000, "New Report!", "Click to show.");
        }

        private void NotifyBallon(int timeout, string title, string msg)
        {
            NotifyIcon.ShowBalloonTip(timeout, title, msg, ToolTipIcon.Info);
            NotifyIcon.BalloonTipClicked += new EventHandler(notifyIcon_BalloonTipClicked);
        }

        void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        public void DelAllField()
        {
            textBox1.Text = "";
            listView1.Items.Clear();
            txbMail.Text    = "";
            txbDesc.Text    = "";
            txbType.Text    = "";
            txbSysinfo.Text = "";
        }

        private void tmrCheck_Tick(object sender, EventArgs e) //? Check new files.
        {
            
            if (Chckcount != Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length)
            {
                Chckcount = Directory.GetFiles(Bugpath, "*.*", SearchOption.AllDirectories).Length;
                refresh();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Process.Start(logpath);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int s = listView1.FocusedItem.Index + 1;
                fileC = File.ReadAllText(Bugpath + "\\" + item + "\\" + s + ".txt");

                if (File.Exists(Bugpath + "\\Logs\\" + item + "\\" + s + "_Logs.zip"))
                {
                    logpath = Bugpath + "\\Logs\\" + item + "\\" + s + "_Logs.zip";
                    btnLog.Enabled = true;
                }
                else
                {
                    btnLog.Enabled = false;
                }

                string[] content = fileC.Split(';');
                txbMail.Text = content[1];
                txbType.Text = content[2];
                txbDesc.Text = content[3];
                textBox1.Text = content[9];
                btnCheck.Enabled = content[10] == "0";
                txbSysinfo.Text = "Cpu:" + content[4] + Environment.NewLine + "Core:" +
                    content[5] + Environment.NewLine + "Total Memory: " + content[6] + "Mb" +
                    Environment.NewLine + "Operation System:" + content[7] + Environment.NewLine + content[8];
            }
            catch
            {
            }
        }

        private void BugreportGUI_Activated(object sender, EventArgs e)
        {

            Flash.FlashWindow.Stop(FindForm());
        }

        private void BugreportGUI_MouseEnter(object sender, EventArgs e)
        {
            Flash.FlashWindow.Stop(FindForm());
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                NotifyIcon.ContextMenuStrip = cmsUp;
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(NotifyIcon, null);
                NotifyIcon.ContextMenuStrip = cmsUp;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void BugreportGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
