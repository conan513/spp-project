using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SppLauncher
{
    public partial class WorldConf : Form
    {
        IniFileClass MyIni = new IniFileClass("config\\world.CONF");


        public WorldConf()
        {
            InitializeComponent();
            Readini();
        }

        public void Readini()
        {

            switch (MyIni.Read("MangosdConf", "AllFlightPaths"))
            {
                case "1":
                    cbPaths.Text = "Enabled";
                    break;
                case "0":
                    cbPaths.Text = "Disabled";
                    break;
            }

            txbLevel.Text       = MyIni.Read("MangosdConf", "StartPlayerLevel");
            txbMoney.Text       = MyIni.Read("MangosdConf", "StartPlayerMoney");
            txbHonor.Text       = MyIni.Read("MangosdConf", "StartHonorPoints");
            txbArena.Text       = MyIni.Read("MangosdConf", "StartArenaPoints");
            txbPoor.Text        = MyIni.Read("MangosdConf", "Rate.Drop.Item.Poor");
            txbNormal.Text      = MyIni.Read("MangosdConf", "Rate.Drop.Item.Normal");
            txbUncommon.Text    = MyIni.Read("MangosdConf", "Rate.Drop.Item.Uncommon");
            txbRare.Text        = MyIni.Read("MangosdConf", "Rate.Drop.Item.Rare");
            txbEpic.Text        = MyIni.Read("MangosdConf", "Rate.Drop.Item.Epic");
            txbLegendary.Text   = MyIni.Read("MangosdConf", "Rate.Drop.Item.Legendary");
            txbArtifact.Text    = MyIni.Read("MangosdConf", "Rate.Drop.Item.Artifact");
            txbReferenced.Text  = MyIni.Read("MangosdConf", "Rate.Drop.Item.Referenced");
            txbMoneyRate.Text   = MyIni.Read("MangosdConf", "Rate.Drop.Money");
            txbKillRate.Text    = MyIni.Read("MangosdConf", "Rate.XP.Kill");
            txbQuestRate.Text   = MyIni.Read("MangosdConf", "Rate.XP.Quest");
            txbExploreRate.Text = MyIni.Read("MangosdConf", "Rate.XP.Explore");
            txbHonorRate.Text   = MyIni.Read("MangosdConf", "Rate.Honor");
            txbTalentRate.Text  = MyIni.Read("MangosdConf", "Rate.Talent");


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyIni.Write("MangosdConf", "StartPlayerLevel", " " + txbLevel.Text);
                MyIni.Write("MangosdConf", "StartPlayerMoney", " " + txbMoney.Text);
                MyIni.Write("MangosdConf", "StartHonorPoints", " " + txbHonor.Text);
                MyIni.Write("MangosdConf", "StartArenaPoints", " " + txbArena.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Poor", " " + txbPoor.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Normal", " " + txbNormal.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Uncommon", " " + txbUncommon.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Rare", " " + txbRare.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Legendary", " " + txbLegendary.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Artifact", " " + txbArtifact.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Referenced", " " + txbReferenced.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Item.Epic", " " + txbEpic.Text);
                MyIni.Write("MangosdConf", "Rate.Drop.Money", " " + txbMoneyRate.Text);
                MyIni.Write("MangosdConf", "Rate.XP.Kill", " " + txbKillRate.Text);
                MyIni.Write("MangosdConf", "Rate.XP.Quest", " " + txbQuestRate.Text);
                MyIni.Write("MangosdConf", "Rate.XP.Explore", " " + txbExploreRate.Text);
                MyIni.Write("MangosdConf", "Rate.Honor", " " + txbHonorRate.Text);
                MyIni.Write("MangosdConf", "Rate.Talent", " " + txbTalentRate.Text);
                
                switch (cbPaths.Text)
                {
                    case "Enabled":
                        MyIni.Write("MangosdConf", "AllFlightPaths", " " + "1");
                        break;
                    case "Disabled":
                        MyIni.Write("MangosdConf", "AllFlightPaths", " " + "0");
                        break;
                }
            }
            catch 
            {
                MessageBox.Show("Some exception: write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            MessageBox.Show("World Settings Saved.\nThe changes to take effect, server restart requiered.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txbLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
