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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblReportt = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblLanSwitch = new System.Windows.Forms.Label();
            this.lblCompiler = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmsUp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssUptime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.cmsUp.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.NotifyCounter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyCounter_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReport);
            this.groupBox1.Controls.Add(this.lblReportt);
            this.groupBox1.Controls.Add(this.lblAcc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblAll);
            this.groupBox1.Controls.Add(this.lblRes);
            this.groupBox1.Controls.Add(this.lblLanSwitch);
            this.groupBox1.Controls.Add(this.lblCompiler);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(131, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usable Statistics";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReport.Location = new System.Drawing.Point(101, 86);
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
            this.lblReportt.Location = new System.Drawing.Point(4, 84);
            this.lblReportt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportt.Name = "lblReportt";
            this.lblReportt.Size = new System.Drawing.Size(47, 15);
            this.lblReportt.TabIndex = 10;
            this.lblReportt.Text = "Report:";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAcc.Location = new System.Drawing.Point(101, 71);
            this.lblAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(14, 13);
            this.lblAcc.TabIndex = 9;
            this.lblAcc.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(4, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Acc. Creator:";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAll.Location = new System.Drawing.Point(101, 107);
            this.lblAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(14, 13);
            this.lblAll.TabIndex = 7;
            this.lblAll.Text = "0";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRes.Location = new System.Drawing.Point(101, 56);
            this.lblRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(14, 13);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "0";
            // 
            // lblLanSwitch
            // 
            this.lblLanSwitch.AutoSize = true;
            this.lblLanSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLanSwitch.Location = new System.Drawing.Point(101, 41);
            this.lblLanSwitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLanSwitch.Name = "lblLanSwitch";
            this.lblLanSwitch.Size = new System.Drawing.Size(14, 13);
            this.lblLanSwitch.TabIndex = 5;
            this.lblLanSwitch.Text = "0";
            // 
            // lblCompiler
            // 
            this.lblCompiler.AutoSize = true;
            this.lblCompiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompiler.Location = new System.Drawing.Point(101, 25);
            this.lblCompiler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompiler.Name = "lblCompiler";
            this.lblCompiler.Size = new System.Drawing.Size(14, 13);
            this.lblCompiler.TabIndex = 4;
            this.lblCompiler.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "All:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Res. Changer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LanSwitch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compiler:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 120);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(14, 18);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(418, 69);
            this.lbHistory.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHistory);
            this.groupBox2.Location = new System.Drawing.Point(157, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(448, 98);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server History";
            // 
            // ssStatus
            // 
            this.ssStatus.GripMargin = new System.Windows.Forms.Padding(0);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUptime,
            this.tssStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 156);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssStatus.Size = new System.Drawing.Size(616, 22);
            this.ssStatus.SizingGrip = false;
            this.ssStatus.Stretch = false;
            this.ssStatus.TabIndex = 0;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tssUptime
            // 
            this.tssUptime.Name = "tssUptime";
            this.tssUptime.Size = new System.Drawing.Size(563, 17);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 120);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 178);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsUp.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblLanSwitch;
        private System.Windows.Forms.Label lblCompiler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsUp;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.ToolStripStatusLabel tssUptime;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblReportt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}

