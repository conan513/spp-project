namespace StatServer
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.NotifyCounter = new System.Windows.Forms.NotifyIcon(this.components);
            this.gBStat = new System.Windows.Forms.GroupBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblReportt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsUp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReload = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.gBhistory = new System.Windows.Forms.GroupBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssUptime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.btnChange = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.Getip = new System.Windows.Forms.Timer(this.components);
            this.gBStat.SuspendLayout();
            this.cmsUp.SuspendLayout();
            this.gBhistory.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyCounter
            // 
            this.NotifyCounter.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyCounter.Icon")));
            this.NotifyCounter.Text = "Stat Server";
            this.NotifyCounter.Visible = true;
            this.NotifyCounter.DoubleClick += new System.EventHandler(this.NotifyCounter_DoubleClick);
            this.NotifyCounter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyCounter_MouseClick);
            // 
            // gBStat
            // 
            this.gBStat.Controls.Add(this.lblReport);
            this.gBStat.Controls.Add(this.lblReportt);
            this.gBStat.Location = new System.Drawing.Point(9, 11);
            this.gBStat.Margin = new System.Windows.Forms.Padding(2);
            this.gBStat.Name = "gBStat";
            this.gBStat.Padding = new System.Windows.Forms.Padding(2);
            this.gBStat.Size = new System.Drawing.Size(217, 47);
            this.gBStat.TabIndex = 0;
            this.gBStat.TabStop = false;
            this.gBStat.Text = "Usable Statistics";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReport.Location = new System.Drawing.Point(101, 21);
            this.lblReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(14, 13);
            this.lblReport.TabIndex = 11;
            this.lblReport.Text = "0";
            // 
            // lblReportt
            // 
            this.lblReportt.AutoSize = true;
            this.lblReportt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReportt.Location = new System.Drawing.Point(4, 19);
            this.lblReportt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportt.Name = "lblReportt";
            this.lblReportt.Size = new System.Drawing.Size(47, 15);
            this.lblReportt.TabIndex = 10;
            this.lblReportt.Text = "Report:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(156, 338);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmsUp
            // 
            this.cmsUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsUp.Name = "contextMenuStrip1";
            this.cmsUp.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(91, 338);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(56, 20);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(14, 18);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(189, 225);
            this.lbHistory.TabIndex = 8;
            // 
            // gBhistory
            // 
            this.gBhistory.Controls.Add(this.lbHistory);
            this.gBhistory.Location = new System.Drawing.Point(9, 62);
            this.gBhistory.Margin = new System.Windows.Forms.Padding(2);
            this.gBhistory.Name = "gBhistory";
            this.gBhistory.Padding = new System.Windows.Forms.Padding(2);
            this.gBhistory.Size = new System.Drawing.Size(217, 258);
            this.gBhistory.TabIndex = 8;
            this.gBhistory.TabStop = false;
            this.gBhistory.Text = "Server History";
            // 
            // ssStatus
            // 
            this.ssStatus.GripMargin = new System.Windows.Forms.Padding(0);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUptime,
            this.tssStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 372);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssStatus.Size = new System.Drawing.Size(237, 22);
            this.ssStatus.SizingGrip = false;
            this.ssStatus.Stretch = false;
            this.ssStatus.TabIndex = 0;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tssUptime
            // 
            this.tssUptime.Name = "tssUptime";
            this.tssUptime.Size = new System.Drawing.Size(184, 17);
            this.tssUptime.Spring = true;
            this.tssUptime.Text = "Uptime";
            this.tssUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(42, 17);
            this.tssStatus.Text = "Online";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerUp
            // 
            this.timerUp.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerSave
            // 
            this.timerSave.Interval = 300000;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(30, 338);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(56, 20);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button3_Click);
            // 
            // Getip
            // 
            this.Getip.Interval = 600000;
            this.Getip.Tick += new System.EventHandler(this.Getip_Tick);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 394);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gBhistory);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gBStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.gBStat.ResumeLayout(false);
            this.gBStat.PerformLayout();
            this.cmsUp.ResumeLayout(false);
            this.gBhistory.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyCounter;
        private System.Windows.Forms.GroupBox gBStat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsUp;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.GroupBox gBhistory;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.ToolStripStatusLabel tssUptime;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblReportt;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Timer Getip;
    }
}

