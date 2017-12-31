using System;
using System.Windows.Forms;

namespace SppLauncher
{
    public partial class WorldConf : Form
    {
        readonly IniFileClass MyIni = new IniFileClass("Settings\\world.conf");


        public WorldConf()
        {
            InitializeComponent();

            Readini();

            //143

        }

        public void Readini()
        {

            switch (MyIni.Read("worldserver", "AllFlightPaths"))
            {
                case "1":
                    cbPaths.Text = "Enabled";
                    break;
                case "0":
                    cbPaths.Text = "Disabled";
                    break;
            }

            txbLevel.Text       = MyIni.Read("worldserver", "StartPlayerLevel");
            txbMoney.Text       = MyIni.Read("worldserver", "StartPlayerMoney");
            txbHonor.Text       = MyIni.Read("worldserver", "StartHonorPoints");
            txbArena.Text       = MyIni.Read("worldserver", "StartArenaPoints");
            txbPoor.Text        = MyIni.Read("worldserver", "Rate.Drop.Item.Poor");
            txbNormal.Text      = MyIni.Read("worldserver", "Rate.Drop.Item.Normal");
            txbUncommon.Text    = MyIni.Read("worldserver", "Rate.Drop.Item.Uncommon");
            txbRare.Text        = MyIni.Read("worldserver", "Rate.Drop.Item.Rare");
            txbEpic.Text        = MyIni.Read("worldserver", "Rate.Drop.Item.Epic");
            txbLegendary.Text   = MyIni.Read("worldserver", "Rate.Drop.Item.Legendary");
            txbArtifact.Text    = MyIni.Read("worldserver", "Rate.Drop.Item.Artifact");
            txbReferenced.Text  = MyIni.Read("worldserver", "Rate.Drop.Item.Referenced");
            txbMoneyRate.Text   = MyIni.Read("worldserver", "Rate.Drop.Money");
            txbKillRate.Text    = MyIni.Read("worldserver", "Rate.XP.Kill");
            txbQuestRate.Text   = MyIni.Read("worldserver", "Rate.XP.Quest");
            txbExploreRate.Text = MyIni.Read("worldserver", "Rate.XP.Explore");
            txbHonorRate.Text   = MyIni.Read("worldserver", "Rate.Honor");
            txbTalentRate.Text  = MyIni.Read("worldserver", "Rate.Talent");


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyIni.Write("worldserver", "StartPlayerLevel", " " + txbLevel.Text);
                MyIni.Write("worldserver", "StartPlayerMoney", " " + txbMoney.Text);
                MyIni.Write("worldserver", "StartHonorPoints", " " + txbHonor.Text);
                MyIni.Write("worldserver", "StartArenaPoints", " " + txbArena.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Poor", " " + txbPoor.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Normal", " " + txbNormal.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Uncommon", " " + txbUncommon.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Rare", " " + txbRare.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Legendary", " " + txbLegendary.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Artifact", " " + txbArtifact.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Referenced", " " + txbReferenced.Text);
                MyIni.Write("worldserver", "Rate.Drop.Item.Epic", " " + txbEpic.Text);
                MyIni.Write("worldserver", "Rate.Drop.Money", " " + txbMoneyRate.Text);
                MyIni.Write("worldserver", "Rate.XP.Kill", " " + txbKillRate.Text);
                MyIni.Write("worldserver", "Rate.XP.Quest", " " + txbQuestRate.Text);
                MyIni.Write("worldserver", "Rate.XP.Explore", " " + txbExploreRate.Text);
                MyIni.Write("worldserver", "Rate.Honor", " " + txbHonorRate.Text);
                MyIni.Write("worldserver", "Rate.Talent", " " + txbTalentRate.Text);
                
                switch (cbPaths.Text)
                {
                    case "Enabled":
                        MyIni.Write("worldserver", "AllFlightPaths", " " + "1");
                        break;
                    case "Disabled":
                        MyIni.Write("worldserver", "AllFlightPaths", " " + "0");
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
