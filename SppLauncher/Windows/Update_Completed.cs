using System;
using System.Windows.Forms;
using SppLauncher.Windows.Launcher;

namespace SppLauncher
{
    public partial class Update_Completed : Form
    {
        public Update_Completed()
        {
            InitializeComponent();
            lbl_currVer.Text = Launcher.CurrProgVer;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
