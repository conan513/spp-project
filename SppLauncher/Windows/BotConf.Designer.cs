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
            this.txbMinbot.Location = new System.Drawing.Point(132, 46);
            this.txbMinbot.MaxLength = 10;
            this.txbMinbot.Name = "txbMinbot";
            this.txbMinbot.Size = new System.Drawing.Size(97, 20);
            this.txbMinbot.TabIndex = 1;
            this.txbMinbot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min bots:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max bots:";
            // 
            // txbMaxBot
            // 
            this.txbMaxBot.Location = new System.Drawing.Point(132, 76);
            this.txbMaxBot.MaxLength = 10;
            this.txbMaxBot.Name = "txbMaxBot";
            this.txbMaxBot.Size = new System.Drawing.Size(97, 20);
            this.txbMaxBot.TabIndex = 2;
            this.txbMaxBot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min bots/interval:";
            // 
            // txbMinBotInter
            // 
            this.txbMinBotInter.Location = new System.Drawing.Point(132, 102);
            this.txbMinBotInter.MaxLength = 10;
            this.txbMinBotInter.Name = "txbMinBotInter";
            this.txbMinBotInter.Size = new System.Drawing.Size(97, 20);
            this.txbMinBotInter.TabIndex = 3;
            this.txbMinBotInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max bots/interval:";
            // 
            // txbMaxBotInter
            // 
            this.txbMaxBotInter.Location = new System.Drawing.Point(132, 128);
            this.txbMaxBotInter.MaxLength = 10;
            this.txbMaxBotInter.Name = "txbMaxBotInter";
            this.txbMaxBotInter.Size = new System.Drawing.Size(97, 20);
            this.txbMaxBotInter.TabIndex = 4;
            this.txbMaxBotInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Update Interval:";
            // 
            // txbUpdateInter
            // 
            this.txbUpdateInter.Location = new System.Drawing.Point(132, 180);
            this.txbUpdateInter.MaxLength = 10;
            this.txbUpdateInter.Name = "txbUpdateInter";
            this.txbUpdateInter.Size = new System.Drawing.Size(97, 20);
            this.txbUpdateInter.TabIndex = 6;
            this.txbUpdateInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bots Account:";
            // 
            // txbBotAccount
            // 
            this.txbBotAccount.Enabled = false;
            this.txbBotAccount.Location = new System.Drawing.Point(132, 154);
            this.txbBotAccount.MaxLength = 10;
            this.txbBotAccount.Name = "txbBotAccount";
            this.txbBotAccount.Size = new System.Drawing.Size(97, 20);
            this.txbBotAccount.TabIndex = 5;
            this.txbBotAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbBots
            // 
            this.cbBots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBots.FormattingEnabled = true;
            this.cbBots.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cbBots.Location = new System.Drawing.Point(132, 19);
            this.cbBots.Name = "cbBots";
            this.cbBots.Size = new System.Drawing.Size(97, 21);
            this.cbBots.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bots:";
            // 
            // cbDel
            // 
            this.cbDel.AutoSize = true;
            this.cbDel.Enabled = false;
            this.cbDel.Location = new System.Drawing.Point(18, 19);
            this.cbDel.Name = "cbDel";
            this.cbDel.Size = new System.Drawing.Size(119, 17);
            this.cbDel.TabIndex = 7;
            this.cbDel.Text = "Delete Bot Account";
            this.cbDel.UseVisualStyleBackColor = true;
            // 
            // cbJoin
            // 
            this.cbJoin.AutoSize = true;
            this.cbJoin.Location = new System.Drawing.Point(18, 39);
            this.cbJoin.Name = "cbJoin";
            this.cbJoin.Size = new System.Drawing.Size(87, 17);
            this.cbJoin.TabIndex = 8;
            this.cbJoin.Text = "Bot Join LFG";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 216);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEastern
            // 
            this.cbEastern.AutoSize = true;
            this.cbEastern.Location = new System.Drawing.Point(15, 19);
            this.cbEastern.Name = "cbEastern";
            this.cbEastern.Size = new System.Drawing.Size(111, 17);
            this.cbEastern.TabIndex = 14;
            this.cbEastern.Text = "Eastern Kingdoms";
            this.cbEastern.UseVisualStyleBackColor = true;
            this.cbEastern.CheckedChanged += new System.EventHandler(this.cbEastern_CheckedChanged);
            // 
            // cbKalimdor
            // 
            this.cbKalimdor.AutoSize = true;
            this.cbKalimdor.Location = new System.Drawing.Point(15, 39);
            this.cbKalimdor.Name = "cbKalimdor";
            this.cbKalimdor.Size = new System.Drawing.Size(66, 17);
            this.cbKalimdor.TabIndex = 17;
            this.cbKalimdor.Text = "Kalimdor";
            this.cbKalimdor.UseVisualStyleBackColor = true;
            // 
            // cbOutland
            // 
            this.cbOutland.AutoSize = true;
            this.cbOutland.Location = new System.Drawing.Point(15, 59);
            this.cbOutland.Name = "cbOutland";
            this.cbOutland.Size = new System.Drawing.Size(68, 17);
            this.cbOutland.TabIndex = 18;
            this.cbOutland.Text = "Outlands";
            this.cbOutland.UseVisualStyleBackColor = true;
            // 
            // cbNorthrend
            // 
            this.cbNorthrend.AutoSize = true;
            this.cbNorthrend.Location = new System.Drawing.Point(15, 79);
            this.cbNorthrend.Name = "cbNorthrend";
            this.cbNorthrend.Size = new System.Drawing.Size(73, 17);
            this.cbNorthrend.TabIndex = 19;
            this.cbNorthrend.Text = "Northrend";
            this.cbNorthrend.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEastern);
            this.groupBox2.Controls.Add(this.cbNorthrend);
            this.groupBox2.Controls.Add(this.cbKalimdor);
            this.groupBox2.Controls.Add(this.cbOutland);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 105);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot Maps";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRndBotLgn);
            this.groupBox3.Controls.Add(this.cbDel);
            this.groupBox3.Controls.Add(this.cbJoin);
            this.groupBox3.Location = new System.Drawing.Point(163, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 105);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // cbRndBotLgn
            // 
            this.cbRndBotLgn.AutoSize = true;
            this.cbRndBotLgn.Location = new System.Drawing.Point(18, 59);
            this.cbRndBotLgn.Name = "cbRndBotLgn";
            this.cbRndBotLgn.Size = new System.Drawing.Size(89, 17);
            this.cbRndBotLgn.TabIndex = 9;
            this.cbRndBotLgn.Text = "Rnd bot login";
            this.cbRndBotLgn.UseVisualStyleBackColor = true;
            this.cbRndBotLgn.MouseHover += new System.EventHandler(this.cbRndBotLgn_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Load default";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BotConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 378);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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