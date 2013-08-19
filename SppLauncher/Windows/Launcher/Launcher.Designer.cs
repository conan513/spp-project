namespace SppLauncher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.tmrRealm = new System.Windows.Forms.Timer(this.components);
            this.tmrWorld = new System.Windows.Forms.Timer(this.components);
            this.SqlStartCheck = new System.Windows.Forms.Timer(this.components);
            this.lblMysql = new System.Windows.Forms.Label();
            this.lblRealm = new System.Windows.Forms.Label();
            this.lblWorld = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbarWorld = new System.Windows.Forms.ProgressBar();
            this.pbNotAvailW = new System.Windows.Forms.PictureBox();
            this.pbTempW = new System.Windows.Forms.PictureBox();
            this.pbNotAvailR = new System.Windows.Forms.PictureBox();
            this.pbTempR = new System.Windows.Forms.PictureBox();
            this.pbNotAvailM = new System.Windows.Forms.PictureBox();
            this.pbTempM = new System.Windows.Forms.PictureBox();
            this.pbAvailableM = new System.Windows.Forms.PictureBox();
            this.pbAvailableR = new System.Windows.Forms.PictureBox();
            this.pbAvailableW = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rtWorldDev = new System.Windows.Forms.RichTextBox();
            this.txbWorldDev = new System.Windows.Forms.TextBox();
            this.SppTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.botSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWoWPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeBotsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImportCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lanSwitcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServersStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.autorunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckWowRun = new System.Windows.Forms.Timer(this.components);
            this.GetSqlOnlineBot = new System.Windows.Forms.Timer(this.components);
            this.msForm = new System.Windows.Forms.MenuStrip();
            this.runWoWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.worldSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWoWPathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllRandomBotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeBotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magyarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lanSwitcherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportImportCharactersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startstopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendCommandForServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autostartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelpUs = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tssLOnline = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUsage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SrvAnnounce = new System.Windows.Forms.Timer(this.components);
            this.lblWorldStartTime = new System.Windows.Forms.Label();
            this.lblRealmStartTime = new System.Windows.Forms.Label();
            this.lblSqlStartTime = new System.Windows.Forms.Label();
            this.CheckMangosCrashed = new System.Windows.Forms.Timer(this.components);
            this.bwUpdate = new System.ComponentModel.BackgroundWorker();
            this.StatusBarUpdater = new System.Windows.Forms.Timer(this.components);
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.rstchck = new System.ComponentModel.BackgroundWorker();
            this.bwImport = new System.ComponentModel.BackgroundWorker();
            this.bwExport = new System.ComponentModel.BackgroundWorker();
            this.tmrUsage = new System.Windows.Forms.Timer(this.components);
            this.bWUpEx = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableW)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.msForm.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrRealm
            // 
            this.tmrRealm.Interval = 1000;
            this.tmrRealm.Tick += new System.EventHandler(this.tmrRealm_Tick);
            // 
            // tmrWorld
            // 
            this.tmrWorld.Tick += new System.EventHandler(this.tmrWorld_Tick);
            // 
            // SqlStartCheck
            // 
            this.SqlStartCheck.Interval = 1000;
            this.SqlStartCheck.Tick += new System.EventHandler(this.SqlStartCheck_Tick);
            // 
            // lblMysql
            // 
            resources.ApplyResources(this.lblMysql, "lblMysql");
            this.lblMysql.Name = "lblMysql";
            // 
            // lblRealm
            // 
            resources.ApplyResources(this.lblRealm, "lblRealm");
            this.lblRealm.Name = "lblRealm";
            // 
            // lblWorld
            // 
            resources.ApplyResources(this.lblWorld, "lblWorld");
            this.lblWorld.Name = "lblWorld";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbarWorld);
            this.groupBox1.Controls.Add(this.pbNotAvailW);
            this.groupBox1.Controls.Add(this.pbTempW);
            this.groupBox1.Controls.Add(this.pbNotAvailR);
            this.groupBox1.Controls.Add(this.pbTempR);
            this.groupBox1.Controls.Add(this.pbNotAvailM);
            this.groupBox1.Controls.Add(this.pbTempM);
            this.groupBox1.Controls.Add(this.lblWorld);
            this.groupBox1.Controls.Add(this.lblMysql);
            this.groupBox1.Controls.Add(this.pbAvailableM);
            this.groupBox1.Controls.Add(this.lblRealm);
            this.groupBox1.Controls.Add(this.pbAvailableR);
            this.groupBox1.Controls.Add(this.pbAvailableW);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pbarWorld
            // 
            resources.ApplyResources(this.pbarWorld, "pbarWorld");
            this.pbarWorld.Name = "pbarWorld";
            // 
            // pbNotAvailW
            // 
            this.pbNotAvailW.Image = global::SppLauncher.Properties.Resources.not_available_100x100;
            resources.ApplyResources(this.pbNotAvailW, "pbNotAvailW");
            this.pbNotAvailW.Name = "pbNotAvailW";
            this.pbNotAvailW.TabStop = false;
            // 
            // pbTempW
            // 
            this.pbTempW.Image = global::SppLauncher.Properties.Resources.temporarily_not_available_100x100;
            resources.ApplyResources(this.pbTempW, "pbTempW");
            this.pbTempW.Name = "pbTempW";
            this.pbTempW.TabStop = false;
            // 
            // pbNotAvailR
            // 
            this.pbNotAvailR.Image = global::SppLauncher.Properties.Resources.not_available_100x100;
            resources.ApplyResources(this.pbNotAvailR, "pbNotAvailR");
            this.pbNotAvailR.Name = "pbNotAvailR";
            this.pbNotAvailR.TabStop = false;
            // 
            // pbTempR
            // 
            this.pbTempR.Image = global::SppLauncher.Properties.Resources.temporarily_not_available_100x100;
            resources.ApplyResources(this.pbTempR, "pbTempR");
            this.pbTempR.Name = "pbTempR";
            this.pbTempR.TabStop = false;
            // 
            // pbNotAvailM
            // 
            this.pbNotAvailM.Image = global::SppLauncher.Properties.Resources.not_available_100x100;
            resources.ApplyResources(this.pbNotAvailM, "pbNotAvailM");
            this.pbNotAvailM.Name = "pbNotAvailM";
            this.pbNotAvailM.TabStop = false;
            // 
            // pbTempM
            // 
            this.pbTempM.Image = global::SppLauncher.Properties.Resources.temporarily_not_available_100x100;
            resources.ApplyResources(this.pbTempM, "pbTempM");
            this.pbTempM.Name = "pbTempM";
            this.pbTempM.TabStop = false;
            // 
            // pbAvailableM
            // 
            this.pbAvailableM.Image = global::SppLauncher.Properties.Resources.available_100x100;
            resources.ApplyResources(this.pbAvailableM, "pbAvailableM");
            this.pbAvailableM.Name = "pbAvailableM";
            this.pbAvailableM.TabStop = false;
            this.pbAvailableM.MouseHover += new System.EventHandler(this.pbAvailableM_MouseHover);
            // 
            // pbAvailableR
            // 
            this.pbAvailableR.Image = global::SppLauncher.Properties.Resources.available_100x100;
            resources.ApplyResources(this.pbAvailableR, "pbAvailableR");
            this.pbAvailableR.Name = "pbAvailableR";
            this.pbAvailableR.TabStop = false;
            this.pbAvailableR.MouseHover += new System.EventHandler(this.pbAvailableR_MouseHover);
            // 
            // pbAvailableW
            // 
            this.pbAvailableW.Image = global::SppLauncher.Properties.Resources.available_100x100;
            resources.ApplyResources(this.pbAvailableW, "pbAvailableW");
            this.pbAvailableW.Name = "pbAvailableW";
            this.pbAvailableW.TabStop = false;
            this.pbAvailableW.MouseHover += new System.EventHandler(this.pbAvailableW_MouseHover);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.rtWorldDev);
            this.groupBox2.Controls.Add(this.txbWorldDev);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // rtWorldDev
            // 
            resources.ApplyResources(this.rtWorldDev, "rtWorldDev");
            this.rtWorldDev.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtWorldDev.ForeColor = System.Drawing.Color.YellowGreen;
            this.rtWorldDev.Name = "rtWorldDev";
            this.rtWorldDev.ReadOnly = true;
            this.rtWorldDev.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txbWorldDev
            // 
            this.txbWorldDev.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txbWorldDev, "txbWorldDev");
            this.txbWorldDev.ForeColor = System.Drawing.Color.White;
            this.txbWorldDev.Name = "txbWorldDev";
            this.txbWorldDev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // SppTray
            // 
            resources.ApplyResources(this.SppTray, "SppTray");
            this.SppTray.DoubleClick += new System.EventHandler(this.SppTray_DoubleClick);
            this.SppTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SppTray_MouseClick);
            // 
            // cmsTray
            // 
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.startWowToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.ServersStripMenuItem,
            this.reportToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.cmsTray.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cmsTray, "cmsTray");
            this.cmsTray.DoubleClick += new System.EventHandler(this.cmsTray_DoubleClick);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // startWowToolStripMenuItem
            // 
            this.startWowToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.world_of_warcraft;
            this.startWowToolStripMenuItem.Name = "startWowToolStripMenuItem";
            resources.ApplyResources(this.startWowToolStripMenuItem, "startWowToolStripMenuItem");
            this.startWowToolStripMenuItem.Click += new System.EventHandler(this.startWowToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldSettingsToolStripMenuItem1,
            this.botSettingsToolStripMenuItem1,
            this.changeWoWPathToolStripMenuItem,
            this.resetBotsToolStripMenuItem,
            this.randomizeBotsToolStripMenuItem1,
            this.exportImportCharactersToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.configuration_1;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // worldSettingsToolStripMenuItem1
            // 
            this.worldSettingsToolStripMenuItem1.Name = "worldSettingsToolStripMenuItem1";
            resources.ApplyResources(this.worldSettingsToolStripMenuItem1, "worldSettingsToolStripMenuItem1");
            this.worldSettingsToolStripMenuItem1.Click += new System.EventHandler(this.worldSettingsToolStripMenuItem1_Click);
            // 
            // botSettingsToolStripMenuItem1
            // 
            this.botSettingsToolStripMenuItem1.Name = "botSettingsToolStripMenuItem1";
            resources.ApplyResources(this.botSettingsToolStripMenuItem1, "botSettingsToolStripMenuItem1");
            this.botSettingsToolStripMenuItem1.Click += new System.EventHandler(this.botSettingsToolStripMenuItem1_Click);
            // 
            // changeWoWPathToolStripMenuItem
            // 
            this.changeWoWPathToolStripMenuItem.Name = "changeWoWPathToolStripMenuItem";
            resources.ApplyResources(this.changeWoWPathToolStripMenuItem, "changeWoWPathToolStripMenuItem");
            this.changeWoWPathToolStripMenuItem.Click += new System.EventHandler(this.changeWoWPathToolStripMenuItem_Click);
            // 
            // resetBotsToolStripMenuItem
            // 
            this.resetBotsToolStripMenuItem.Name = "resetBotsToolStripMenuItem";
            resources.ApplyResources(this.resetBotsToolStripMenuItem, "resetBotsToolStripMenuItem");
            this.resetBotsToolStripMenuItem.Click += new System.EventHandler(this.resetBotsToolStripMenuItem_Click);
            // 
            // randomizeBotsToolStripMenuItem1
            // 
            this.randomizeBotsToolStripMenuItem1.Name = "randomizeBotsToolStripMenuItem1";
            resources.ApplyResources(this.randomizeBotsToolStripMenuItem1, "randomizeBotsToolStripMenuItem1");
            this.randomizeBotsToolStripMenuItem1.Click += new System.EventHandler(this.randomizeBotsToolStripMenuItem1_Click);
            // 
            // exportImportCharactersToolStripMenuItem
            // 
            this.exportImportCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem1,
            this.importToolStripMenuItem1});
            this.exportImportCharactersToolStripMenuItem.Name = "exportImportCharactersToolStripMenuItem";
            resources.ApplyResources(this.exportImportCharactersToolStripMenuItem, "exportImportCharactersToolStripMenuItem");
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Export_Icon_32;
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            resources.ApplyResources(this.exportToolStripMenuItem1, "exportToolStripMenuItem1");
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Import_Icon_32;
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            resources.ApplyResources(this.importToolStripMenuItem1, "importToolStripMenuItem1");
            this.importToolStripMenuItem1.Click += new System.EventHandler(this.importToolStripMenuItem1_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lanSwitcherToolStripMenuItem,
            this.accountToolToolStripMenuItem});
            this.toolToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.icon_gear;
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            resources.ApplyResources(this.toolToolStripMenuItem, "toolToolStripMenuItem");
            // 
            // lanSwitcherToolStripMenuItem
            // 
            this.lanSwitcherToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Other_Power_Switch_User_Metro_icon;
            this.lanSwitcherToolStripMenuItem.Name = "lanSwitcherToolStripMenuItem";
            resources.ApplyResources(this.lanSwitcherToolStripMenuItem, "lanSwitcherToolStripMenuItem");
            this.lanSwitcherToolStripMenuItem.Click += new System.EventHandler(this.lanSwitcherToolStripMenuItem_Click);
            // 
            // accountToolToolStripMenuItem
            // 
            this.accountToolToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.WoW_icon;
            this.accountToolToolStripMenuItem.Name = "accountToolToolStripMenuItem";
            resources.ApplyResources(this.accountToolToolStripMenuItem, "accountToolToolStripMenuItem");
            this.accountToolToolStripMenuItem.Click += new System.EventHandler(this.accountToolToolStripMenuItem_Click);
            // 
            // ServersStripMenuItem
            // 
            this.ServersStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem2,
            this.toolStripSeparator2,
            this.autorunToolStripMenuItem});
            this.ServersStripMenuItem.Image = global::SppLauncher.Properties.Resources.Places_server_database_icon;
            this.ServersStripMenuItem.Name = "ServersStripMenuItem";
            resources.ApplyResources(this.ServersStripMenuItem, "ServersStripMenuItem");
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Play_1_Hot_icon;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem2
            // 
            resources.ApplyResources(this.restartToolStripMenuItem2, "restartToolStripMenuItem2");
            this.restartToolStripMenuItem2.Image = global::SppLauncher.Properties.Resources.Other_Power_Restart_Metro_icon;
            this.restartToolStripMenuItem2.Name = "restartToolStripMenuItem2";
            this.restartToolStripMenuItem2.Click += new System.EventHandler(this.restartToolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // autorunToolStripMenuItem
            // 
            this.autorunToolStripMenuItem.Name = "autorunToolStripMenuItem";
            resources.ApplyResources(this.autorunToolStripMenuItem, "autorunToolStripMenuItem");
            this.autorunToolStripMenuItem.Click += new System.EventHandler(this.autorunToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.report_bug_icon;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            resources.ApplyResources(this.reportToolStripMenuItem, "reportToolStripMenuItem");
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Information_icon;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Windows_Close_Program_icon;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // CheckWowRun
            // 
            this.CheckWowRun.Interval = 1000;
            this.CheckWowRun.Tick += new System.EventHandler(this.CheckWowRun_Tick);
            // 
            // GetSqlOnlineBot
            // 
            this.GetSqlOnlineBot.Interval = 2000;
            this.GetSqlOnlineBot.Tick += new System.EventHandler(this.GetSqlOnlineBot_Tick);
            // 
            // msForm
            // 
            this.msForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runWoWToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.tsmHelpUs,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem2});
            resources.ApplyResources(this.msForm, "msForm");
            this.msForm.Name = "msForm";
            // 
            // runWoWToolStripMenuItem
            // 
            this.runWoWToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.world_of_warcraft;
            this.runWoWToolStripMenuItem.Name = "runWoWToolStripMenuItem";
            resources.ApplyResources(this.runWoWToolStripMenuItem, "runWoWToolStripMenuItem");
            this.runWoWToolStripMenuItem.Click += new System.EventHandler(this.runWoWToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldSettingsToolStripMenuItem,
            this.botSettingsToolStripMenuItem,
            this.changeWoWPathToolStripMenuItem1,
            this.resetAllRandomBotsToolStripMenuItem,
            this.randomizeBotsToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.configuration_1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // worldSettingsToolStripMenuItem
            // 
            this.worldSettingsToolStripMenuItem.Name = "worldSettingsToolStripMenuItem";
            resources.ApplyResources(this.worldSettingsToolStripMenuItem, "worldSettingsToolStripMenuItem");
            this.worldSettingsToolStripMenuItem.Click += new System.EventHandler(this.worldSettingsToolStripMenuItem_Click);
            // 
            // botSettingsToolStripMenuItem
            // 
            this.botSettingsToolStripMenuItem.Name = "botSettingsToolStripMenuItem";
            resources.ApplyResources(this.botSettingsToolStripMenuItem, "botSettingsToolStripMenuItem");
            this.botSettingsToolStripMenuItem.Click += new System.EventHandler(this.botSettingsToolStripMenuItem_Click);
            // 
            // changeWoWPathToolStripMenuItem1
            // 
            this.changeWoWPathToolStripMenuItem1.Name = "changeWoWPathToolStripMenuItem1";
            resources.ApplyResources(this.changeWoWPathToolStripMenuItem1, "changeWoWPathToolStripMenuItem1");
            this.changeWoWPathToolStripMenuItem1.Click += new System.EventHandler(this.changeWoWPathToolStripMenuItem1_Click);
            // 
            // resetAllRandomBotsToolStripMenuItem
            // 
            this.resetAllRandomBotsToolStripMenuItem.Name = "resetAllRandomBotsToolStripMenuItem";
            resources.ApplyResources(this.resetAllRandomBotsToolStripMenuItem, "resetAllRandomBotsToolStripMenuItem");
            this.resetAllRandomBotsToolStripMenuItem.Click += new System.EventHandler(this.resetAllRandomBotsToolStripMenuItem_Click);
            // 
            // randomizeBotsToolStripMenuItem
            // 
            this.randomizeBotsToolStripMenuItem.Name = "randomizeBotsToolStripMenuItem";
            resources.ApplyResources(this.randomizeBotsToolStripMenuItem, "randomizeBotsToolStripMenuItem");
            this.randomizeBotsToolStripMenuItem.Click += new System.EventHandler(this.randomizeBotsToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magyarToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // magyarToolStripMenuItem
            // 
            this.magyarToolStripMenuItem.Name = "magyarToolStripMenuItem";
            resources.ApplyResources(this.magyarToolStripMenuItem, "magyarToolStripMenuItem");
            this.magyarToolStripMenuItem.Click += new System.EventHandler(this.magyarToolStripMenuItem_Click_1);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lanSwitcherToolStripMenuItem1,
            this.accountToolToolStripMenuItem1,
            this.toolStripSeparator3,
            this.exportImportCharactersToolStripMenuItem1,
            this.updateToolStripMenuItem});
            this.toolsToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.icon_gear;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // lanSwitcherToolStripMenuItem1
            // 
            this.lanSwitcherToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Other_Power_Switch_User_Metro_icon;
            this.lanSwitcherToolStripMenuItem1.Name = "lanSwitcherToolStripMenuItem1";
            resources.ApplyResources(this.lanSwitcherToolStripMenuItem1, "lanSwitcherToolStripMenuItem1");
            this.lanSwitcherToolStripMenuItem1.Click += new System.EventHandler(this.lanSwitcherToolStripMenuItem1_Click);
            // 
            // accountToolToolStripMenuItem1
            // 
            this.accountToolToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.WoW_icon;
            this.accountToolToolStripMenuItem1.Name = "accountToolToolStripMenuItem1";
            resources.ApplyResources(this.accountToolToolStripMenuItem1, "accountToolToolStripMenuItem1");
            this.accountToolToolStripMenuItem1.Click += new System.EventHandler(this.accountToolToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // exportImportCharactersToolStripMenuItem1
            // 
            this.exportImportCharactersToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem2,
            this.importToolStripMenuItem2});
            this.exportImportCharactersToolStripMenuItem1.Name = "exportImportCharactersToolStripMenuItem1";
            resources.ApplyResources(this.exportImportCharactersToolStripMenuItem1, "exportImportCharactersToolStripMenuItem1");
            // 
            // exportToolStripMenuItem2
            // 
            this.exportToolStripMenuItem2.Image = global::SppLauncher.Properties.Resources.Export_Icon_32;
            this.exportToolStripMenuItem2.Name = "exportToolStripMenuItem2";
            resources.ApplyResources(this.exportToolStripMenuItem2, "exportToolStripMenuItem2");
            this.exportToolStripMenuItem2.Click += new System.EventHandler(this.exportToolStripMenuItem2_Click);
            // 
            // importToolStripMenuItem2
            // 
            this.importToolStripMenuItem2.Image = global::SppLauncher.Properties.Resources.Import_Icon_32;
            this.importToolStripMenuItem2.Name = "importToolStripMenuItem2";
            resources.ApplyResources(this.importToolStripMenuItem2, "importToolStripMenuItem2");
            this.importToolStripMenuItem2.Click += new System.EventHandler(this.importToolStripMenuItem2_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startstopToolStripMenuItem,
            this.restartToolStripMenuItem1,
            this.toolStripSeparator1,
            this.sendCommandForServerToolStripMenuItem,
            this.autostartToolStripMenuItem});
            this.restartToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Places_server_database_icon;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            // 
            // startstopToolStripMenuItem
            // 
            this.startstopToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Play_1_Hot_icon;
            this.startstopToolStripMenuItem.Name = "startstopToolStripMenuItem";
            resources.ApplyResources(this.startstopToolStripMenuItem, "startstopToolStripMenuItem");
            this.startstopToolStripMenuItem.Click += new System.EventHandler(this.startstopToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem1
            // 
            resources.ApplyResources(this.restartToolStripMenuItem1, "restartToolStripMenuItem1");
            this.restartToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Other_Power_Restart_Metro_icon;
            this.restartToolStripMenuItem1.Name = "restartToolStripMenuItem1";
            this.restartToolStripMenuItem1.Click += new System.EventHandler(this.restartToolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // sendCommandForServerToolStripMenuItem
            // 
            this.sendCommandForServerToolStripMenuItem.Name = "sendCommandForServerToolStripMenuItem";
            resources.ApplyResources(this.sendCommandForServerToolStripMenuItem, "sendCommandForServerToolStripMenuItem");
            this.sendCommandForServerToolStripMenuItem.Click += new System.EventHandler(this.sendCommandForServerToolStripMenuItem_Click);
            // 
            // autostartToolStripMenuItem
            // 
            this.autostartToolStripMenuItem.Name = "autostartToolStripMenuItem";
            resources.ApplyResources(this.autostartToolStripMenuItem, "autostartToolStripMenuItem");
            this.autostartToolStripMenuItem.Click += new System.EventHandler(this.autostartToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.report_bug_icon;
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            resources.ApplyResources(this.reportBugToolStripMenuItem, "reportBugToolStripMenuItem");
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.reportBugToolStripMenuItem_Click);
            // 
            // tsmHelpUs
            // 
            this.tsmHelpUs.Image = global::SppLauncher.Properties.Resources.heart_icon;
            this.tsmHelpUs.Name = "tsmHelpUs";
            resources.ApplyResources(this.tsmHelpUs, "tsmHelpUs");
            this.tsmHelpUs.Click += new System.EventHandler(this.tsmHelpUs_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Information_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Image = global::SppLauncher.Properties.Resources.Windows_Close_Program_icon;
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            resources.ApplyResources(this.exitToolStripMenuItem2, "exitToolStripMenuItem2");
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLOnline,
            this.tssUsage,
            this.tssStatus});
            resources.ApplyResources(this.ssBar, "ssBar");
            this.ssBar.Name = "ssBar";
            this.ssBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ssBar.ShowItemToolTips = true;
            this.ssBar.SizingGrip = false;
            // 
            // tssLOnline
            // 
            this.tssLOnline.Name = "tssLOnline";
            resources.ApplyResources(this.tssLOnline, "tssLOnline");
            // 
            // tssUsage
            // 
            this.tssUsage.Name = "tssUsage";
            resources.ApplyResources(this.tssUsage, "tssUsage");
            this.tssUsage.Spring = true;
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            resources.ApplyResources(this.tssStatus, "tssStatus");
            this.tssStatus.Click += new System.EventHandler(this.tssStatus_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // SrvAnnounce
            // 
            this.SrvAnnounce.Interval = 600000;
            this.SrvAnnounce.Tick += new System.EventHandler(this.SrvAnnounce_Tick);
            // 
            // lblWorldStartTime
            // 
            resources.ApplyResources(this.lblWorldStartTime, "lblWorldStartTime");
            this.lblWorldStartTime.Name = "lblWorldStartTime";
            // 
            // lblRealmStartTime
            // 
            resources.ApplyResources(this.lblRealmStartTime, "lblRealmStartTime");
            this.lblRealmStartTime.Name = "lblRealmStartTime";
            // 
            // lblSqlStartTime
            // 
            resources.ApplyResources(this.lblSqlStartTime, "lblSqlStartTime");
            this.lblSqlStartTime.Name = "lblSqlStartTime";
            // 
            // CheckMangosCrashed
            // 
            this.CheckMangosCrashed.Interval = 5000;
            this.CheckMangosCrashed.Tick += new System.EventHandler(this.CheckMangosCrashed_Tick);
            // 
            // bwUpdate
            // 
            this.bwUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpdate_DoWork);
            this.bwUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpdate_RunWorkerCompleted);
            // 
            // StatusBarUpdater
            // 
            this.StatusBarUpdater.Tick += new System.EventHandler(this.StatusBarUpdater_Tick);
            // 
            // Check
            // 
            this.Check.Interval = 3000;
            this.Check.Tick += new System.EventHandler(this.Check_Tick);
            // 
            // rstchck
            // 
            this.rstchck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.rstchck_DoWork);
            this.rstchck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.rstchck_RunWorkerCompleted);
            // 
            // bwImport
            // 
            this.bwImport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwImport_DoWork);
            this.bwImport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwImport_RunWorkerCompleted);
            // 
            // bwExport
            // 
            this.bwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwExport_DoWork);
            this.bwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwExport_RunWorkerCompleted);
            // 
            // tmrUsage
            // 
            this.tmrUsage.Interval = 1000;
            this.tmrUsage.Tick += new System.EventHandler(this.tmrUsage_Tick);
            // 
            // bWUpEx
            // 
            this.bWUpEx.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWUpEx_DoWork);
            this.bWUpEx.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWUpEx_RunWorkerCompleted);
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSqlStartTime);
            this.Controls.Add(this.lblRealmStartTime);
            this.Controls.Add(this.lblWorldStartTime);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.msForm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msForm;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableW)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmsTray.ResumeLayout(false);
            this.msForm.ResumeLayout(false);
            this.msForm.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrRealm;
        private System.Windows.Forms.Timer tmrWorld;
        private System.Windows.Forms.Timer SqlStartCheck;
        private System.Windows.Forms.Label lblMysql;
        private System.Windows.Forms.Label lblRealm;
        private System.Windows.Forms.Label lblWorld;
        private System.Windows.Forms.PictureBox pbAvailableW;
        private System.Windows.Forms.PictureBox pbAvailableR;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbTempM;
        private System.Windows.Forms.PictureBox pbTempW;
        private System.Windows.Forms.PictureBox pbTempR;
        private System.Windows.Forms.PictureBox pbNotAvailW;
        private System.Windows.Forms.PictureBox pbNotAvailR;
        private System.Windows.Forms.NotifyIcon SppTray;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServersStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Timer CheckWowRun;
        private System.Windows.Forms.ToolStripMenuItem startWowToolStripMenuItem;
        private System.Windows.Forms.Timer GetSqlOnlineBot;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lanSwitcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolToolStripMenuItem;
        private System.Windows.Forms.TextBox txbWorldDev;
        private System.Windows.Forms.RichTextBox rtWorldDev;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWoWPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msForm;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lanSwitcherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountToolToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tssLOnline;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ProgressBar pbarWorld;
        private System.Windows.Forms.Timer SrvAnnounce;
        private System.Windows.Forms.Label lblWorldStartTime;
        private System.Windows.Forms.Label lblRealmStartTime;
        private System.Windows.Forms.Label lblSqlStartTime;
        private System.Windows.Forms.ToolStripMenuItem resetBotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeBotsToolStripMenuItem1;
        private System.Windows.Forms.Timer CheckMangosCrashed;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwUpdate;
        private System.Windows.Forms.ToolStripMenuItem botSettingsToolStripMenuItem1;
        private System.Windows.Forms.Timer StatusBarUpdater;
        private System.Windows.Forms.ToolStripMenuItem worldSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Timer Check;
        private System.ComponentModel.BackgroundWorker rstchck;
        private System.Windows.Forms.ToolStripMenuItem tsmHelpUs;
        private System.ComponentModel.BackgroundWorker bwImport;
        private System.ComponentModel.BackgroundWorker bwExport;
        private System.Windows.Forms.ToolStripStatusLabel tssUsage;
        private System.Windows.Forms.Timer tmrUsage;
        private System.Windows.Forms.ToolStripMenuItem startstopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autostartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem autorunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImportCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem runWoWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem worldSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWoWPathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetAllRandomBotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeBotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magyarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bWUpEx;
        public System.Windows.Forms.PictureBox pbAvailableM;
        public System.Windows.Forms.PictureBox pbNotAvailM;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem sendCommandForServerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImportCharactersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

