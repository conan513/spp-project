using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppLauncher.Windows
{
    public partial class WorldConsole : Form
    {
        public WorldConsole()
        {
            InitializeComponent();
        }

        private void rtWorldDev_TextChanged(object sender, EventArgs e)
        {
            if (rtWorldDev.TextLength >= 10000)
            {
                rtWorldDev.Clear();
            }
        }
    }
}
