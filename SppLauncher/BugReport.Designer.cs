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
            this.txbMail.Location = new System.Drawing.Point(120, 24);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(164, 20);
            this.txbMail.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(151, 356);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send Report";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(60, 27);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(54, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Your Mail:";
            // 
            // cbBugType
            // 
            this.cbBugType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBugType.FormattingEnabled = true;
            this.cbBugType.Items.AddRange(new object[] {
            "Aibot",
            "Emulator",
            "Launcher",
            "Tools"});
            this.cbBugType.Location = new System.Drawing.Point(120, 50);
            this.cbBugType.Name = "cbBugType";
            this.cbBugType.Size = new System.Drawing.Size(164, 21);
            this.cbBugType.TabIndex = 3;
            // 
            // lblbug
            // 
            this.lblbug.AutoSize = true;
            this.lblbug.Location = new System.Drawing.Point(58, 53);
            this.lblbug.Name = "lblbug";
            this.lblbug.Size = new System.Drawing.Size(56, 13);
            this.lblbug.TabIndex = 4;
            this.lblbug.Text = "Bug Type:";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(27, 102);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(297, 132);
            this.txbDesc.TabIndex = 5;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 337);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "System Information";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(27, 260);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 59);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Report";
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