namespace SppLauncher
{
    partial class WorldConf
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbLevel = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbPaths = new System.Windows.Forms.ComboBox();
            this.txbArena = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txbHonor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbReferenced = new System.Windows.Forms.TextBox();
            this.txbArtifact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPoor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNormal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbUncommon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbRare = new System.Windows.Forms.TextBox();
            this.txbLegendary = new System.Windows.Forms.TextBox();
            this.txbEpic = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbMoneyRate = new System.Windows.Forms.TextBox();
            this.txbKillRate = new System.Windows.Forms.TextBox();
            this.txbQuestRate = new System.Windows.Forms.TextBox();
            this.txbExploreRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbHonorRate = new System.Windows.Forms.TextBox();
            this.txbTalentRate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txbLevel);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txbMoney);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbPaths);
            this.groupBox1.Controls.Add(this.txbArena);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txbHonor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indítási Beállítások";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(191, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Arena:";
            // 
            // txbLevel
            // 
            this.txbLevel.Location = new System.Drawing.Point(65, 26);
            this.txbLevel.MaxLength = 10;
            this.txbLevel.Name = "txbLevel";
            this.txbLevel.Size = new System.Drawing.Size(71, 20);
            this.txbLevel.TabIndex = 0;
            this.txbLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(150, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "All Flight Paths:";
            // 
            // txbMoney
            // 
            this.txbMoney.Location = new System.Drawing.Point(65, 52);
            this.txbMoney.MaxLength = 8;
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(71, 20);
            this.txbMoney.TabIndex = 1;
            this.txbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Money:";
            // 
            // cbPaths
            // 
            this.cbPaths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaths.FormattingEnabled = true;
            this.cbPaths.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cbPaths.Location = new System.Drawing.Point(230, 25);
            this.cbPaths.Name = "cbPaths";
            this.cbPaths.Size = new System.Drawing.Size(71, 21);
            this.cbPaths.TabIndex = 4;
            // 
            // txbArena
            // 
            this.txbArena.Location = new System.Drawing.Point(230, 52);
            this.txbArena.MaxLength = 10;
            this.txbArena.Name = "txbArena";
            this.txbArena.Size = new System.Drawing.Size(71, 20);
            this.txbArena.TabIndex = 4;
            this.txbArena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Level:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Honor:";
            // 
            // txbHonor
            // 
            this.txbHonor.Location = new System.Drawing.Point(65, 78);
            this.txbHonor.MaxLength = 10;
            this.txbHonor.Name = "txbHonor";
            this.txbHonor.Size = new System.Drawing.Size(71, 20);
            this.txbHonor.TabIndex = 2;
            this.txbHonor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbReferenced);
            this.groupBox3.Controls.Add(this.txbArtifact);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txbPoor);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txbNormal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txbUncommon);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txbRare);
            this.groupBox3.Controls.Add(this.txbLegendary);
            this.groupBox3.Controls.Add(this.txbEpic);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 132);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Drop Rates";
            // 
            // txbReferenced
            // 
            this.txbReferenced.Location = new System.Drawing.Point(230, 97);
            this.txbReferenced.MaxLength = 10;
            this.txbReferenced.Name = "txbReferenced";
            this.txbReferenced.Size = new System.Drawing.Size(68, 20);
            this.txbReferenced.TabIndex = 19;
            this.txbReferenced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // txbArtifact
            // 
            this.txbArtifact.Location = new System.Drawing.Point(230, 71);
            this.txbArtifact.MaxLength = 10;
            this.txbArtifact.Name = "txbArtifact";
            this.txbArtifact.Size = new System.Drawing.Size(68, 20);
            this.txbArtifact.TabIndex = 18;
            this.txbArtifact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Normal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Uncommon:";
            // 
            // txbPoor
            // 
            this.txbPoor.Location = new System.Drawing.Point(68, 21);
            this.txbPoor.MaxLength = 10;
            this.txbPoor.Name = "txbPoor";
            this.txbPoor.Size = new System.Drawing.Size(68, 20);
            this.txbPoor.TabIndex = 12;
            this.txbPoor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rare:";
            // 
            // txbNormal
            // 
            this.txbNormal.Location = new System.Drawing.Point(68, 47);
            this.txbNormal.MaxLength = 10;
            this.txbNormal.Name = "txbNormal";
            this.txbNormal.Size = new System.Drawing.Size(68, 20);
            this.txbNormal.TabIndex = 13;
            this.txbNormal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Epic:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Legendary:";
            // 
            // txbUncommon
            // 
            this.txbUncommon.Location = new System.Drawing.Point(68, 73);
            this.txbUncommon.MaxLength = 10;
            this.txbUncommon.Name = "txbUncommon";
            this.txbUncommon.Size = new System.Drawing.Size(68, 20);
            this.txbUncommon.TabIndex = 14;
            this.txbUncommon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Artifact:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Referenced:";
            // 
            // txbRare
            // 
            this.txbRare.Location = new System.Drawing.Point(68, 99);
            this.txbRare.MaxLength = 10;
            this.txbRare.Name = "txbRare";
            this.txbRare.Size = new System.Drawing.Size(68, 20);
            this.txbRare.TabIndex = 15;
            this.txbRare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // txbLegendary
            // 
            this.txbLegendary.Location = new System.Drawing.Point(230, 45);
            this.txbLegendary.MaxLength = 10;
            this.txbLegendary.Name = "txbLegendary";
            this.txbLegendary.Size = new System.Drawing.Size(68, 20);
            this.txbLegendary.TabIndex = 17;
            this.txbLegendary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // txbEpic
            // 
            this.txbEpic.Location = new System.Drawing.Point(230, 19);
            this.txbEpic.MaxLength = 10;
            this.txbEpic.Name = "txbEpic";
            this.txbEpic.Size = new System.Drawing.Size(68, 20);
            this.txbEpic.TabIndex = 16;
            this.txbEpic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbMoneyRate
            // 
            this.txbMoneyRate.Location = new System.Drawing.Point(68, 20);
            this.txbMoneyRate.MaxLength = 10;
            this.txbMoneyRate.Name = "txbMoneyRate";
            this.txbMoneyRate.Size = new System.Drawing.Size(68, 20);
            this.txbMoneyRate.TabIndex = 5;
            this.txbMoneyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // txbKillRate
            // 
            this.txbKillRate.Location = new System.Drawing.Point(68, 46);
            this.txbKillRate.MaxLength = 10;
            this.txbKillRate.Name = "txbKillRate";
            this.txbKillRate.Size = new System.Drawing.Size(68, 20);
            this.txbKillRate.TabIndex = 6;
            this.txbKillRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // txbQuestRate
            // 
            this.txbQuestRate.Location = new System.Drawing.Point(68, 72);
            this.txbQuestRate.MaxLength = 10;
            this.txbQuestRate.Name = "txbQuestRate";
            this.txbQuestRate.Size = new System.Drawing.Size(68, 20);
            this.txbQuestRate.TabIndex = 10;
            this.txbQuestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // txbExploreRate
            // 
            this.txbExploreRate.Location = new System.Drawing.Point(230, 20);
            this.txbExploreRate.MaxLength = 10;
            this.txbExploreRate.Name = "txbExploreRate";
            this.txbExploreRate.Size = new System.Drawing.Size(71, 20);
            this.txbExploreRate.TabIndex = 8;
            this.txbExploreRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Money:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Kill:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Quest:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Explore:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Honor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(188, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Talent:";
            // 
            // txbHonorRate
            // 
            this.txbHonorRate.Location = new System.Drawing.Point(230, 46);
            this.txbHonorRate.MaxLength = 10;
            this.txbHonorRate.Name = "txbHonorRate";
            this.txbHonorRate.Size = new System.Drawing.Size(71, 20);
            this.txbHonorRate.TabIndex = 9;
            this.txbHonorRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // txbTalentRate
            // 
            this.txbTalentRate.Location = new System.Drawing.Point(230, 72);
            this.txbTalentRate.MaxLength = 10;
            this.txbTalentRate.Name = "txbTalentRate";
            this.txbTalentRate.Size = new System.Drawing.Size(71, 20);
            this.txbTalentRate.TabIndex = 11;
            this.txbTalentRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLevel_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(276, -11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "label18";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbMoneyRate);
            this.groupBox4.Controls.Add(this.txbTalentRate);
            this.groupBox4.Controls.Add(this.txbHonorRate);
            this.groupBox4.Controls.Add(this.txbExploreRate);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txbQuestRate);
            this.groupBox4.Controls.Add(this.txbKillRate);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(12, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Szerver Értékek";
            // 
            // WorldConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 399);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorldConf";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbLevel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbPaths;
        private System.Windows.Forms.TextBox txbMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbReferenced;
        private System.Windows.Forms.TextBox txbArtifact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUncommon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbRare;
        private System.Windows.Forms.TextBox txbLegendary;
        private System.Windows.Forms.TextBox txbEpic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbHonor;
        private System.Windows.Forms.TextBox txbArena;
        private System.Windows.Forms.TextBox txbMoneyRate;
        private System.Windows.Forms.TextBox txbKillRate;
        private System.Windows.Forms.TextBox txbQuestRate;
        private System.Windows.Forms.TextBox txbExploreRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbHonorRate;
        private System.Windows.Forms.TextBox txbTalentRate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}