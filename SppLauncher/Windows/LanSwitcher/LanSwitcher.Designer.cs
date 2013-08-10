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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanSwitcher));
            this.btnApply = new System.Windows.Forms.Button();
            this.txbLanip = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bwUpdate = new System.ComponentModel.BackgroundWorker();
            this.bwSql = new System.ComponentModel.BackgroundWorker();
            this.bwUsageStatSender = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txbLanip
            // 
            resources.ApplyResources(this.txbLanip, "txbLanip");
            this.txbLanip.Name = "txbLanip";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.cbCh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbLanip);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbCh
            // 
            resources.ApplyResources(this.cbCh, "cbCh");
            this.cbCh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCh.FormattingEnabled = true;
            this.cbCh.Items.AddRange(new object[] {
            resources.GetString("cbCh.Items"),
            resources.GetString("cbCh.Items1"),
            resources.GetString("cbCh.Items2")});
            this.cbCh.Name = "cbCh";
            this.cbCh.SelectedIndexChanged += new System.EventHandler(this.cbCh_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LanSwitcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanSwitcher";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txbLanip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bwUpdate;
        private System.ComponentModel.BackgroundWorker bwSql;
        private System.ComponentModel.BackgroundWorker bwUsageStatSender;
        private System.Windows.Forms.ComboBox cbCh;
    }
}

