using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SppLauncher.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] Files = Directory.GetFiles("update", "mr*mangos*sql", SearchOption.TopDirectoryOnly);
            foreach (String aFile in Files)
            {

                try
                {
                    string conn1 =
                        "server=127.0.0.1;user=root;pwd=123456;database=mangos;port=3310;convertzerodatetime=true;";
                    MySqlBackup mb1 = new MySqlBackup(conn1);
                    mb1.ImportInfo.FileName = aFile;
                    mb1.Import();
                    listBox1.Items.Add("Import:" + aFile);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;
                }
                catch
                {
                    listBox1.Items.Add("ERROR:" + aFile);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;
                    //listBox2.Items.Add(ex);
                   // listBox2.SelectedIndex = listBox2.Items.Count - 1;
                   // listBox2.SelectedIndex = -1;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            //try
            //{
            //    string conn1 =
            //        "server=127.0.0.1;user=root;pwd=123456;database=mangos;port=3310;convertzerodatetime=true;";
            //    MySqlBackup mb1 = new MySqlBackup(conn1);
            //    mb1.ImportInfo.FileName = "D:\\SPP\\Single Player Project Real v2\\update\\YTDB_0.14.7_R640_cMaNGOS_R12529_SD2_R2903_ACID_R310_RuDB_R62.sql";
            //    mb1.Import();

            //}
            //catch
            //{
            //    MessageBox.Show("nemoké");
            //}
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completed");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string conn1 =
                    "server=127.0.0.1;user=root;pwd=123456;database=mangos;port=3310;convertzerodatetime=true;";
                MySqlBackup mb1 = new MySqlBackup(conn1);
                mb1.ImportInfo.FileName = "D:\\SPP\\Single Player Project Real v2\\update\\YTDB_0.14.7_R640_cMaNGOS_R12529_SD2_R2903_ACID_R310_RuDB_R62.sql";
                mb1.Import();

            }
            catch
            {
                MessageBox.Show("nemoké2");
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completed backgroundworker2","Info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string conn1 =
                    "server=127.0.0.1;user=root;pwd=123456;database=mangos;port=3310;convertzerodatetime=true;";
                MySqlBackup mb1 = new MySqlBackup(conn1);
                mb1.ImportInfo.FileName = "D:\\SPP\\Single Player Project Real v2\\update\\custom_mangos_tables.sql";
                mb1.Import();

            }
            catch
            {
                MessageBox.Show("nemoké2");
            }
        }
    }
}
