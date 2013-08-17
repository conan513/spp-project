namespace SppLauncher
{
    partial class BugReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugReport));
            this.txbMail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.cbBugType = new System.Windows.Forms.ComboBox();
            this.lblbug = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bwGetSysInfo = new System.ComponentModel.BackgroundWorker();
            this.bwSendReport = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMail
            // 
            resources.ApplyResources(this.txbMail, "txbMail");
            this.txbMail.Name = "txbMail";
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.Name = "lblMail";
            // 
            // cbBugType
            // 
            this.cbBugType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBugType.FormattingEnabled = true;
            this.cbBugType.Items.AddRange(new object[] {
            resources.GetString("cbBugType.Items"),
            resources.GetString("cbBugType.Items1"),
            resources.GetString("cbBugType.Items2"),
            resources.GetString("cbBugType.Items3"),
            resources.GetString("cbBugType.Items4")});
            resources.ApplyResources(this.cbBugType, "cbBugType");
            this.cbBugType.Name = "cbBugType";
            // 
            // lblbug
            // 
            resources.ApplyResources(this.lblbug, "lblbug");
            this.lblbug.Name = "lblbug";
            // 
            // txbDesc
            // 
            resources.ApplyResources(this.txbDesc, "txbDesc");
            this.txbDesc.Name = "txbDesc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbDesc);
            this.groupBox1.Controls.Add(this.txbMail);
            this.groupBox1.Controls.Add(this.lblbug);
            this.groupBox1.Controls.Add(this.cbBugType);
            this.groupBox1.Controls.Add(this.lblMail);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bwGetSysInfo
            // 
            this.bwGetSysInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bwSendReport
            // 
            this.bwSendReport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSendReport_DoWork);
            // 
            // BugReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugReport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cbBugType;
        private System.Windows.Forms.Label lblbug;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bwGetSysInfo;
        private System.ComponentModel.BackgroundWorker bwSendReport;
    }
}