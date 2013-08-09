namespace SppLauncher
{
    partial class BotConf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotConf));
            this.txbMinbot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaxBot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMinBotInter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMaxBotInter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUpdateInter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBotAccount = new System.Windows.Forms.TextBox();
            this.cbBots = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDel = new System.Windows.Forms.CheckBox();
            this.cbJoin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEastern = new System.Windows.Forms.CheckBox();
            this.cbKalimdor = new System.Windows.Forms.CheckBox();
            this.cbOutland = new System.Windows.Forms.CheckBox();
            this.cbNorthrend = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRndBotLgn = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tTrndBot = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMinbot
            // 
            resources.ApplyResources(this.txbMinbot, "txbMinbot");
            this.txbMinbot.Name = "txbMinbot";
            this.txbMinbot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txbMaxBot
            // 
            resources.ApplyResources(this.txbMaxBot, "txbMaxBot");
            this.txbMaxBot.Name = "txbMaxBot";
            this.txbMaxBot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txbMinBotInter
            // 
            resources.ApplyResources(this.txbMinBotInter, "txbMinBotInter");
            this.txbMinBotInter.Name = "txbMinBotInter";
            this.txbMinBotInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txbMaxBotInter
            // 
            resources.ApplyResources(this.txbMaxBotInter, "txbMaxBotInter");
            this.txbMaxBotInter.Name = "txbMaxBotInter";
            this.txbMaxBotInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txbUpdateInter
            // 
            resources.ApplyResources(this.txbUpdateInter, "txbUpdateInter");
            this.txbUpdateInter.Name = "txbUpdateInter";
            this.txbUpdateInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txbBotAccount
            // 
            resources.ApplyResources(this.txbBotAccount, "txbBotAccount");
            this.txbBotAccount.Name = "txbBotAccount";
            this.txbBotAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbBots
            // 
            this.cbBots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBots.FormattingEnabled = true;
            this.cbBots.Items.AddRange(new object[] {
            resources.GetString("cbBots.Items"),
            resources.GetString("cbBots.Items1")});
            resources.ApplyResources(this.cbBots, "cbBots");
            this.cbBots.Name = "cbBots";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cbDel
            // 
            resources.ApplyResources(this.cbDel, "cbDel");
            this.cbDel.Name = "cbDel";
            this.cbDel.UseVisualStyleBackColor = true;
            // 
            // cbJoin
            // 
            resources.ApplyResources(this.cbJoin, "cbJoin");
            this.cbJoin.Name = "cbJoin";
            this.cbJoin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBots);
            this.groupBox1.Controls.Add(this.txbMinbot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbMaxBot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbMinBotInter);
            this.groupBox1.Controls.Add(this.txbUpdateInter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbMaxBotInter);
            this.groupBox1.Controls.Add(this.txbBotAccount);
            this.groupBox1.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEastern
            // 
            resources.ApplyResources(this.cbEastern, "cbEastern");
            this.cbEastern.Name = "cbEastern";
            this.cbEastern.UseVisualStyleBackColor = true;
            this.cbEastern.CheckedChanged += new System.EventHandler(this.cbEastern_CheckedChanged);
            // 
            // cbKalimdor
            // 
            resources.ApplyResources(this.cbKalimdor, "cbKalimdor");
            this.cbKalimdor.Name = "cbKalimdor";
            this.cbKalimdor.UseVisualStyleBackColor = true;
            // 
            // cbOutland
            // 
            resources.ApplyResources(this.cbOutland, "cbOutland");
            this.cbOutland.Name = "cbOutland";
            this.cbOutland.UseVisualStyleBackColor = true;
            // 
            // cbNorthrend
            // 
            resources.ApplyResources(this.cbNorthrend, "cbNorthrend");
            this.cbNorthrend.Name = "cbNorthrend";
            this.cbNorthrend.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEastern);
            this.groupBox2.Controls.Add(this.cbNorthrend);
            this.groupBox2.Controls.Add(this.cbKalimdor);
            this.groupBox2.Controls.Add(this.cbOutland);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRndBotLgn);
            this.groupBox3.Controls.Add(this.cbDel);
            this.groupBox3.Controls.Add(this.cbJoin);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cbRndBotLgn
            // 
            resources.ApplyResources(this.cbRndBotLgn, "cbRndBotLgn");
            this.cbRndBotLgn.Name = "cbRndBotLgn";
            this.cbRndBotLgn.UseVisualStyleBackColor = true;
            this.cbRndBotLgn.MouseHover += new System.EventHandler(this.cbRndBotLgn_MouseHover);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BotConf
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BotConf";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbMinbot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaxBot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMinBotInter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMaxBotInter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUpdateInter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBotAccount;
        private System.Windows.Forms.ComboBox cbBots;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbDel;
        private System.Windows.Forms.CheckBox cbJoin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbEastern;
        private System.Windows.Forms.CheckBox cbKalimdor;
        private System.Windows.Forms.CheckBox cbOutland;
        private System.Windows.Forms.CheckBox cbNorthrend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbRndBotLgn;
        private System.Windows.Forms.ToolTip tTrndBot;
    }
}