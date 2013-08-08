namespace SppLauncher.Windows
{
    partial class LanSwitcher
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
            this.btnApply = new System.Windows.Forms.Button();
            this.txbLanip = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rB_lan = new System.Windows.Forms.RadioButton();
            this.rB_offline = new System.Windows.Forms.RadioButton();
            this.bwUpdate = new System.ComponentModel.BackgroundWorker();
            this.bwSql = new System.ComponentModel.BackgroundWorker();
            this.bwUsageStatSender = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(58, 87);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(64, 22);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txbLanip
            // 
            this.txbLanip.Location = new System.Drawing.Point(58, 22);
            this.txbLanip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbLanip.Name = "txbLanip";
            this.txbLanip.Size = new System.Drawing.Size(106, 20);
            this.txbLanip.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rB_lan);
            this.groupBox1.Controls.Add(this.txbLanip);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.rB_offline);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(178, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lan ip:";
            // 
            // rB_lan
            // 
            this.rB_lan.AutoSize = true;
            this.rB_lan.Location = new System.Drawing.Point(42, 48);
            this.rB_lan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rB_lan.Name = "rB_lan";
            this.rB_lan.Size = new System.Drawing.Size(43, 17);
            this.rB_lan.TabIndex = 1;
            this.rB_lan.TabStop = true;
            this.rB_lan.Text = "Lan";
            this.rB_lan.UseVisualStyleBackColor = true;
            this.rB_lan.CheckedChanged += new System.EventHandler(this.rB_lan_CheckedChanged);
            // 
            // rB_offline
            // 
            this.rB_offline.AutoSize = true;
            this.rB_offline.Location = new System.Drawing.Point(96, 48);
            this.rB_offline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rB_offline.Name = "rB_offline";
            this.rB_offline.Size = new System.Drawing.Size(55, 17);
            this.rB_offline.TabIndex = 0;
            this.rB_offline.TabStop = true;
            this.rB_offline.Text = "Offline";
            this.rB_offline.UseVisualStyleBackColor = true;
            this.rB_offline.CheckedChanged += new System.EventHandler(this.rB_offline_CheckedChanged);
            // 
            // bwUpdate
            // 
            this.bwUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdate_DoWork);
            this.bwUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdate_RunWorkerCompleted);
            // 
            // bwSql
            // 
            this.bwSql.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSql_DoWork);
            // 
            // LanSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 150);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LanSwitcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lan Switch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txbLanip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rB_lan;
        private System.Windows.Forms.RadioButton rB_offline;
        private System.ComponentModel.BackgroundWorker bwUpdate;
        private System.ComponentModel.BackgroundWorker bwSql;
        private System.ComponentModel.BackgroundWorker bwUsageStatSender;
    }
}

