using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BugReportGUI
{
    public partial class Form1 : Form
    {
        string item,item2,selectedpath;
        public Form1()
        {
            InitializeComponent();
            DirectoryInfo di = new DirectoryInfo("report");
            test(di);
        }

        private void test(DirectoryInfo dir)
        {
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                listBox1.Items.Add(d);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int i in listBox1.SelectedIndices)
            {
                item = listBox1.Items[i].ToString();
                listBox2.Items.Clear();
                clearAll();
            }

            string[] files = Directory.GetFiles("report\\" + item);
            foreach (string afile in files)
            {
                selectedpath = afile;
                string file = File.ReadAllText(afile);
                string[] content = file.Split(';');
                listBox2.Items.Add(content[1] + " (" + content[2] + ")");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in listBox2.SelectedIndices)
                {
                    item2 = listBox2.Items[i].ToString();
                }
                string s = listBox2.SelectedIndex.ToString();
                if (s == "0") s = "1";
                string file = File.ReadAllText("report\\" + item + "\\" + s + ".txt");
                string[] content = file.Split(';');
                txbMail.Text = content[1];
                txbType.Text = content[2];
                txbDesc.Text = content[3];

                txbSysinfo.Text = "Cpu:" + content[4] + Environment.NewLine + "Core:" + content[5] + Environment.NewLine + "Total Memory: " + content[6] + "Mb" + Environment.NewLine + "Operation System:" + content[7] + Environment.NewLine + content[8];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearAll()
        {
            txbMail.Text = "";
            txbDesc.Text = "";
            txbType.Text = "";
        }
    }
}
