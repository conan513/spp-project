namespace BugReportGUI
{
    partial class BugreportGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugreportGUI));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txbType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbSysinfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 147);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(104, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(219, 147);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(72, 29);
            this.txbMail.Name = "txbMail";
            this.txbMail.ReadOnly = true;
            this.txbMail.Size = new System.Drawing.Size(246, 20);
            this.txbMail.TabIndex = 5;
            this.txbMail.TabStop = false;
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(72, 102);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(246, 129);
            this.txbDesc.TabIndex = 4;
            this.txbDesc.TabStop = false;
            // 
            // txbType
            // 
            this.txbType.Location = new System.Drawing.Point(72, 55);
            this.txbType.Name = "txbType";
            this.txbType.ReadOnly = true;
            this.txbType.Size = new System.Drawing.Size(246, 20);
            this.txbType.TabIndex = 4;
            this.txbType.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bug Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mail:";
            // 
            // txbSysinfo
            // 
            this.txbSysinfo.Location = new System.Drawing.Point(69, 250);
            this.txbSysinfo.Multiline = true;
            this.txbSysinfo.Name = "txbSysinfo";
            this.txbSysinfo.ReadOnly = true;
            this.txbSysinfo.Size = new System.Drawing.Size(246, 84);
            this.txbSysinfo.TabIndex = 14;
            this.txbSysinfo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "System Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDesc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMail);
            this.groupBox1.Controls.Add(this.txbSysinfo);
            this.groupBox1.Controls.Add(this.txbType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 350);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 189);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browser";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePathToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Settings";
            // 
            // changePathToolStripMenuItem
            // 
            this.changePathToolStripMenuItem.Name = "changePathToolStripMenuItem";
            this.changePathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changePathToolStripMenuItem.Text = "Change Path";
            this.changePathToolStripMenuItem.Click += new System.EventHandler(this.changePathToolStripMenuItem_Click);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Interval = 2000;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // BugreportGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BugreportGUI";
            this.Text = "BureportGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbSysinfo;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePathToolStripMenuItem;
        private System.Windows.Forms.Timer tmrCheck;
    }
}

