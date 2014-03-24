using System;
using System.Linq;
using System.Windows.Forms;
using SppLauncher.Properties;

namespace SppLauncher
{
    public partial class BotConf : Form
    {
        readonly IniFileClass _ahbot = new IniFileClass("config\\ahbot.CONF");
        readonly IniFileClass _aiplayerbot             = new IniFileClass("config\\aiplayerbot.CONF");

        private string _maps                     = " ", _mapsWrite = " ";
        private string[] _arr1                   = new string[4];
        private bool _defaultL;
        public BotConf()
        {
            InitializeComponent();
            ReadBotConf();
            ToolTip tt = new ToolTip();
            ToolTip tt2 = new ToolTip();
            tt.SetToolTip(label6, Resources.Function_is_temporarily_disabled);
            tt2.SetToolTip(label8, "Ignored if more than MaxPlayerLevel mangosd.conf value");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SaveIni();
        }

        public void SaveIni()
        {

            _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.MinRandomBots", " " + txbMinbot.Text);
            _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.MaxRandomBots", " " + txbMaxBot.Text);
            _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.MinRandomBotsPerInterval", " " + txbMinBotInter.Text);
            _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.MaxRandomBotsPerInterval", " " + txbMaxBotInter.Text);
            _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotAccountCount", " " + txbBotAccount.Text);
            _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotMinLevel", " " + txbMinLevel.Text);
            _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotMaxLevel", " " + txbMaxLevel.Text);

            try
            {
                switch (cbDel.Checked)
                {
                    case true:
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.DeleteRandomBotAccounts", " 1");
                        break;
                    case false:
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.DeleteRandomBotAccounts", " 0");
                        break;
                }
                switch (cbJoin.Checked)
                {
                    case true:
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotJoinLfg", " 1");
                        break;
                    case false:
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotJoinLfg", " 0");
                        break;
                }

                switch (cbBots.Text)
                {
                    case "Enabled":
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.Enabled", " 1");

                        break;
                    case "Disabled":
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.Enabled", " 0");
                        break;
                }

                switch (cbAHbot.Text)
                {
                    case "Enabled":
                        _ahbot.Write("AhbotConf", "AuctionHouseBot.Seller.Enabled", " 1");
                        _ahbot.Write("AhbotConf", "AuctionHouseBot.Buyer.Enabled", " 1");

                        break;
                    case "Disabled":
                        _ahbot.Write("AhbotConf", "AuctionHouseBot.Seller.Enabled", " 0");
                        _ahbot.Write("AhbotConf", "AuctionHouseBot.Buyer.Enabled", " 0");
                        break;
                }

                switch (cbRndBotLgn.Checked)
                {
                    case true:
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotLoginAtStartup", " 1");
                        break;
                    case false:
                        _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotLoginAtStartup", " 0");
                        break;
                }

                string[] arr = new string[4];

                if (cbEastern.Checked)
                    arr[0] = "0";

                if (cbKalimdor.Checked)
                    arr[1] = "1";

                if (cbNorthrend.Checked)
                    arr[2] = "571";

                if (cbOutland.Checked)
                    arr[3] = "530";

                var res = String.Join(",", arr.Where(s => !string.IsNullOrEmpty(s)));

                _aiplayerbot.Write("AiPlayerbotConf", "AiPlayerbot.RandomBotMaps", " " + res);
            }
            catch (Exception)
            {
                MessageBox.Show("Some exception: write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(!_defaultL ? Resources.BotConf_SaveIni_ : Resources.BotConf_SaveIni_default, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void ReadBotConf()
        {
            switch (_ahbot.Read("AhbotConf", "AuctionHouseBot.Seller.Enabled"))
            {
                case "1":
                    cbAHbot.Text = "Enabled";
                    break;
                case "0":
                    cbAHbot.Text = "Disabled";
                    break;
            }

            switch (_aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.Enabled"))
            {
                case "1":
                    cbBots.Text = "Enabled";
                    break;
                case "0":
                    cbBots.Text = "Disabled";
                    break;
            }
            txbMinbot.Text      = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.MinRandomBots");
            txbMaxBot.Text      = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.MaxRandomBots");
            txbMinBotInter.Text = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.MinRandomBotsPerInterval");
            txbMaxBotInter.Text = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.MaxRandomBotsPerInterval");
            txbBotAccount.Text  = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.RandomBotAccountCount");
            txbUpdateInter.Text = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.RandomBotUpdateInterval");
            txbMinLevel.Text = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.RandomBotMinLevel");
            txbMaxLevel.Text = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.RandomBotMaxLevel");

            if(txbMaxLevel.Text.Contains("(ignored"))
            {
                string[] a = txbMaxLevel.Text.Split('(');
                txbMaxLevel.Text = a[0].Trim();
            }

            switch (_aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.DeleteRandomBotAccounts"))
            {
                case "1":
                    cbDel.Checked = true;
                    break;
                case "2":
                    cbDel.Checked = true;
                    break;
            }

            switch (_aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.RandomBotJoinLfg"))
            {
                case "1":
                    cbJoin.Checked = true;
                    break;
                case "0":
                    cbJoin.Checked = false;
                    break;
            }

            switch (_aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.RandomBotLoginAtStartup"))
            {
                case "1":
                    cbRndBotLgn.Checked = true;
                    break;
                case "0":
                    cbRndBotLgn.Checked = false;
                    break;
            }

            _maps = _aiplayerbot.Read("AiPlayerbotConf", "AiPlayerbot.RandomBotMaps");
            _arr1 = _maps.Split(',');

            if (_arr1.Contains("0"))
            {
                cbEastern.Checked = true;
            }

            if (_arr1.Contains("1"))
            {
                cbKalimdor.Checked = true;
            }

            if (_arr1.Contains("530"))
            {
                cbOutland.Checked = true;
            }

            if (_arr1.Contains("571"))
            {
                cbNorthrend.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbBots.Text         = "Enabled";
            txbMinbot.Text      = "50";
            txbMaxBot.Text      = "100";
            txbMinBotInter.Text = "50";
            txbMaxBotInter.Text = "100";
            txbBotAccount.Text  = "50";
            txbUpdateInter.Text = "60";

            cbEastern.Checked   = true;
            cbKalimdor.Checked  = true;
            cbNorthrend.Checked = false;
            cbOutland.Checked   = false;
            cbJoin.Checked      = true;
            _defaultL            = true;
            SaveIni();
        }

        private void cbEastern_CheckedChanged(object sender, EventArgs e)
        {
            _mapsWrite = _mapsWrite + "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbRndBotLgn_MouseHover(object sender, EventArgs e)
        {
            tTrndBot.Show(Resources.BotConf_cbRndBotLgn_MouseHover_All_bots_join_on_start_, cbRndBotLgn, 100000);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
