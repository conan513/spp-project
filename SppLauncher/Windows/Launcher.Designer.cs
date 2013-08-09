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
            this.pbNotAvailR = new System.Windows.Forms.PictureBox();
            this.pbNotAvailM = new System.Windows.Forms.PictureBox();
            this.pbTempW = new System.Windows.Forms.PictureBox();
            this.pbTempR = new System.Windows.Forms.PictureBox();
            this.pbTempM = new System.Windows.Forms.PictureBox();
            this.pbAvailableM = new System.Windows.Forms.PictureBox();
            this.pbAvailableR = new System.Windows.Forms.PictureBox();
            this.pbAvailableW = new System.Windows.Forms.PictureBox();
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
            this.accountToolAdvancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txbWorldDev = new System.Windows.Forms.TextBox();
            this.rtWorldDev = new System.Windows.Forms.RichTextBox();
            this.msForm = new System.Windows.Forms.MenuStrip();
            this.runWoWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.worldSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWoWPathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllRandomBotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeBotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magyarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lanSwitcherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startstopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.UpdateCompleteChecker = new System.Windows.Forms.Timer(this.components);
            this.StatusBarUpdater = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.rstchck = new System.ComponentModel.BackgroundWorker();
            this.bwImport = new System.ComponentModel.BackgroundWorker();
            this.bwExport = new System.ComponentModel.BackgroundWorker();
            this.tmrUsage = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableW)).BeginInit();
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
            this.lblMysql.AutoSize = true;
            this.lblMysql.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblMysql.Location = new System.Drawing.Point(64, 26);
            this.lblMysql.Name = "lblMysql";
            this.lblMysql.Size = new System.Drawing.Size(165, 39);
            this.lblMysql.TabIndex = 18;
            this.lblMysql.Text = "Database";
            // 
            // lblRealm
            // 
            this.lblRealm.AutoSize = true;
            this.lblRealm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblRealm.Location = new System.Drawing.Point(235, 26);
            this.lblRealm.Name = "lblRealm";
            this.lblRealm.Size = new System.Drawing.Size(118, 39);
            this.lblRealm.TabIndex = 19;
            this.lblRealm.Text = "Realm";
            // 
            // lblWorld
            // 
            this.lblWorld.AutoSize = true;
            this.lblWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lblWorld.Location = new System.Drawing.Point(383, 26);
            this.lblWorld.Name = "lblWorld";
            this.lblWorld.Size = new System.Drawing.Size(115, 42);
            this.lblWorld.TabIndex = 20;
            this.lblWorld.Text = "World";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbarWorld);
            this.groupBox1.Controls.Add(this.pbNotAvailW);
            this.groupBox1.Controls.Add(this.pbNotAvailR);
            this.groupBox1.Controls.Add(this.pbNotAvailM);
            this.groupBox1.Controls.Add(this.pbTempW);
            this.groupBox1.Controls.Add(this.pbTempR);
            this.groupBox1.Controls.Add(this.pbTempM);
            this.groupBox1.Controls.Add(this.lblWorld);
            this.groupBox1.Controls.Add(this.lblMysql);
            this.groupBox1.Controls.Add(this.pbAvailableM);
            this.groupBox1.Controls.Add(this.lblRealm);
            this.groupBox1.Controls.Add(this.pbAvailableR);
            this.groupBox1.Controls.Add(this.pbAvailableW);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 174);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers";
            // 
            // pbarWorld
            // 
            this.pbarWorld.Location = new System.Drawing.Point(105, 136);
            this.pbarWorld.Name = "pbarWorld";
            this.pbarWorld.Size = new System.Drawing.Size(357, 25);
            this.pbarWorld.TabIndex = 31;
            this.pbarWorld.Visible = false;
            // 
            // pbNotAvailW
            // 
            this.pbNotAvailW.Image = global::SppLauncher.Properties.Resources.not_available_100x100;
            this.pbNotAvailW.Location = new System.Drawing.Point(402, 64);
            this.pbNotAvailW.Name = "pbNotAvailW";
            this.pbNotAvailW.Size = new System.Drawing.Size(60, 60);
            this.pbNotAvailW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotAvailW.TabIndex = 30;
            this.pbNotAvailW.TabStop = false;
            // 
            // pbNotAvailR
            // 
            this.pbNotAvailR.Image = global::SppLauncher.Properties.Resources.not_available_100x100;
            this.pbNotAvailR.Location = new System.Drawing.Point(251, 64);
            this.pbNotAvailR.Name = "pbNotAvailR";
            this.pbNotAvailR.Size = new System.Drawing.Size(60, 60);
            this.pbNotAvailR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotAvailR.TabIndex = 29;
            this.pbNotAvailR.TabStop = false;
            // 
            // pbNotAvailM
            // 
            this.pbNotAvailM.Image = global::SppLauncher.Properties.Resources.not_available_100x100;
            this.pbNotAvailM.Location = new System.Drawing.Point(105, 64);
            this.pbNotAvailM.Name = "pbNotAvailM";
            this.pbNotAvailM.Size = new System.Drawing.Size(60, 60);
            this.pbNotAvailM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotAvailM.TabIndex = 28;
            this.pbNotAvailM.TabStop = false;
            // 
            // pbTempW
            // 
            this.pbTempW.Image = global::SppLauncher.Properties.Resources.temporarily_not_available_100x100;
            this.pbTempW.Location = new System.Drawing.Point(402, 64);
            this.pbTempW.Name = "pbTempW";
            this.pbTempW.Size = new System.Drawing.Size(60, 60);
            this.pbTempW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTempW.TabIndex = 27;
            this.pbTempW.TabStop = false;
            // 
            // pbTempR
            // 
            this.pbTempR.Image = global::SppLauncher.Properties.Resources.temporarily_not_available_100x100;
            this.pbTempR.Location = new System.Drawing.Point(251, 64);
            this.pbTempR.Name = "pbTempR";
            this.pbTempR.Size = new System.Drawing.Size(60, 60);
            this.pbTempR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTempR.TabIndex = 26;
            this.pbTempR.TabStop = false;
            // 
            // pbTempM
            // 
            this.pbTempM.Image = global::SppLauncher.Properties.Resources.temporarily_not_available_100x100;
            this.pbTempM.Location = new System.Drawing.Point(105, 64);
            this.pbTempM.Name = "pbTempM";
            this.pbTempM.Size = new System.Drawing.Size(60, 60);
            this.pbTempM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTempM.TabIndex = 25;
            this.pbTempM.TabStop = false;
            // 
            // pbAvailableM
            // 
            this.pbAvailableM.Image = global::SppLauncher.Properties.Resources.available_100x100;
            this.pbAvailableM.Location = new System.Drawing.Point(105, 64);
            this.pbAvailableM.Name = "pbAvailableM";
            this.pbAvailableM.Size = new System.Drawing.Size(60, 60);
            this.pbAvailableM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvailableM.TabIndex = 23;
            this.pbAvailableM.TabStop = false;
            // 
            // pbAvailableR
            // 
            this.pbAvailableR.Image = global::SppLauncher.Properties.Resources.available_100x100;
            this.pbAvailableR.Location = new System.Drawing.Point(251, 62);
            this.pbAvailableR.Name = "pbAvailableR";
            this.pbAvailableR.Size = new System.Drawing.Size(60, 60);
            this.pbAvailableR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvailableR.TabIndex = 22;
            this.pbAvailableR.TabStop = false;
            // 
            // pbAvailableW
            // 
            this.pbAvailableW.Image = global::SppLauncher.Properties.Resources.available_100x100;
            this.pbAvailableW.Location = new System.Drawing.Point(402, 64);
            this.pbAvailableW.Name = "pbAvailableW";
            this.pbAvailableW.Size = new System.Drawing.Size(60, 60);
            this.pbAvailableW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvailableW.TabIndex = 21;
            this.pbAvailableW.TabStop = false;
            // 
            // SppTray
            // 
            this.SppTray.Icon = ((System.Drawing.Icon)(resources.GetObject("SppTray.Icon")));
            this.SppTray.Text = "Single Player Project";
            this.SppTray.DoubleClick += new System.EventHandler(this.SppTray_DoubleClick);
            this.SppTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SppTray_MouseClick);
            this.SppTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SppTray_MouseDoubleClick);
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
            this.cmsTray.Size = new System.Drawing.Size(196, 180);
            this.cmsTray.DoubleClick += new System.EventHandler(this.cmsTray_DoubleClick);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // startWowToolStripMenuItem
            // 
            this.startWowToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.world_of_warcraft;
            this.startWowToolStripMenuItem.Name = "startWowToolStripMenuItem";
            this.startWowToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.startWowToolStripMenuItem.Text = "Start World of Warcraft";
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // worldSettingsToolStripMenuItem1
            // 
            this.worldSettingsToolStripMenuItem1.Name = "worldSettingsToolStripMenuItem1";
            this.worldSettingsToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.worldSettingsToolStripMenuItem1.Text = "World Settings";
            this.worldSettingsToolStripMenuItem1.Click += new System.EventHandler(this.worldSettingsToolStripMenuItem1_Click);
            // 
            // botSettingsToolStripMenuItem1
            // 
            this.botSettingsToolStripMenuItem1.Name = "botSettingsToolStripMenuItem1";
            this.botSettingsToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.botSettingsToolStripMenuItem1.Text = "Bot Settings";
            this.botSettingsToolStripMenuItem1.Click += new System.EventHandler(this.botSettingsToolStripMenuItem1_Click);
            // 
            // changeWoWPathToolStripMenuItem
            // 
            this.changeWoWPathToolStripMenuItem.Name = "changeWoWPathToolStripMenuItem";
            this.changeWoWPathToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.changeWoWPathToolStripMenuItem.Text = "Change WoW Path";
            this.changeWoWPathToolStripMenuItem.Click += new System.EventHandler(this.changeWoWPathToolStripMenuItem_Click);
            // 
            // resetBotsToolStripMenuItem
            // 
            this.resetBotsToolStripMenuItem.Name = "resetBotsToolStripMenuItem";
            this.resetBotsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.resetBotsToolStripMenuItem.Text = "Reset bots";
            this.resetBotsToolStripMenuItem.Click += new System.EventHandler(this.resetBotsToolStripMenuItem_Click);
            // 
            // randomizeBotsToolStripMenuItem1
            // 
            this.randomizeBotsToolStripMenuItem1.Name = "randomizeBotsToolStripMenuItem1";
            this.randomizeBotsToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.randomizeBotsToolStripMenuItem1.Text = "Randomize bots";
            this.randomizeBotsToolStripMenuItem1.Click += new System.EventHandler(this.randomizeBotsToolStripMenuItem1_Click);
            // 
            // exportImportCharactersToolStripMenuItem
            // 
            this.exportImportCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem1,
            this.importToolStripMenuItem1});
            this.exportImportCharactersToolStripMenuItem.Name = "exportImportCharactersToolStripMenuItem";
            this.exportImportCharactersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exportImportCharactersToolStripMenuItem.Text = "Export/Import Characters";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Export_Icon_32;
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Import_Icon_32;
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem1.Text = "Import";
            this.importToolStripMenuItem1.Click += new System.EventHandler(this.importToolStripMenuItem1_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lanSwitcherToolStripMenuItem,
            this.accountToolToolStripMenuItem,
            this.accountToolAdvancedToolStripMenuItem});
            this.toolToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.icon_gear;
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // lanSwitcherToolStripMenuItem
            // 
            this.lanSwitcherToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Other_Power_Switch_User_Metro_icon;
            this.lanSwitcherToolStripMenuItem.Name = "lanSwitcherToolStripMenuItem";
            this.lanSwitcherToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.lanSwitcherToolStripMenuItem.Text = "Lan Switcher";
            this.lanSwitcherToolStripMenuItem.Click += new System.EventHandler(this.lanSwitcherToolStripMenuItem_Click);
            // 
            // accountToolToolStripMenuItem
            // 
            this.accountToolToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.WoW_icon;
            this.accountToolToolStripMenuItem.Name = "accountToolToolStripMenuItem";
            this.accountToolToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.accountToolToolStripMenuItem.Text = "Account Tool";
            this.accountToolToolStripMenuItem.Click += new System.EventHandler(this.accountToolToolStripMenuItem_Click);
            // 
            // accountToolAdvancedToolStripMenuItem
            // 
            this.accountToolAdvancedToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.WoW_icon;
            this.accountToolAdvancedToolStripMenuItem.Name = "accountToolAdvancedToolStripMenuItem";
            this.accountToolAdvancedToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.accountToolAdvancedToolStripMenuItem.Text = "Account Tool(Advanced)";
            this.accountToolAdvancedToolStripMenuItem.Click += new System.EventHandler(this.accountToolAdvancedToolStripMenuItem_Click);
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
            this.ServersStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ServersStripMenuItem.Text = "Servers";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Play_1_Hot_icon;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem2
            // 
            this.restartToolStripMenuItem2.Enabled = false;
            this.restartToolStripMenuItem2.Image = global::SppLauncher.Properties.Resources.Other_Power_Restart_Metro_icon;
            this.restartToolStripMenuItem2.Name = "restartToolStripMenuItem2";
            this.restartToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.restartToolStripMenuItem2.Text = "Restart";
            this.restartToolStripMenuItem2.Click += new System.EventHandler(this.restartToolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // autorunToolStripMenuItem
            // 
            this.autorunToolStripMenuItem.Name = "autorunToolStripMenuItem";
            this.autorunToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.autorunToolStripMenuItem.Text = "Autostart";
            this.autorunToolStripMenuItem.Click += new System.EventHandler(this.autorunToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.report_bug_icon;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reportToolStripMenuItem.Text = "Report Bug";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Information_icon;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Windows_Close_Program_icon;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
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
            // txbWorldDev
            // 
            this.txbWorldDev.BackColor = System.Drawing.Color.Black;
            this.txbWorldDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txbWorldDev.ForeColor = System.Drawing.Color.White;
            this.txbWorldDev.Location = new System.Drawing.Point(14, 365);
            this.txbWorldDev.Name = "txbWorldDev";
            this.txbWorldDev.Size = new System.Drawing.Size(495, 20);
            this.txbWorldDev.TabIndex = 26;
            this.txbWorldDev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // rtWorldDev
            // 
            this.rtWorldDev.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtWorldDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rtWorldDev.ForeColor = System.Drawing.Color.White;
            this.rtWorldDev.Location = new System.Drawing.Point(14, 207);
            this.rtWorldDev.Name = "rtWorldDev";
            this.rtWorldDev.ReadOnly = true;
            this.rtWorldDev.Size = new System.Drawing.Size(495, 159);
            this.rtWorldDev.TabIndex = 28;
            this.rtWorldDev.Text = "";
            this.rtWorldDev.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            this.msForm.Location = new System.Drawing.Point(0, 0);
            this.msForm.Name = "msForm";
            this.msForm.Size = new System.Drawing.Size(581, 24);
            this.msForm.TabIndex = 29;
            this.msForm.Text = "Menu";
            // 
            // runWoWToolStripMenuItem
            // 
            this.runWoWToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.world_of_warcraft;
            this.runWoWToolStripMenuItem.Name = "runWoWToolStripMenuItem";
            this.runWoWToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.runWoWToolStripMenuItem.Text = "Run WoW";
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
            this.exportCharactersToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.configuration_1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // worldSettingsToolStripMenuItem
            // 
            this.worldSettingsToolStripMenuItem.Name = "worldSettingsToolStripMenuItem";
            this.worldSettingsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.worldSettingsToolStripMenuItem.Text = "World Settings";
            this.worldSettingsToolStripMenuItem.Click += new System.EventHandler(this.worldSettingsToolStripMenuItem_Click);
            // 
            // botSettingsToolStripMenuItem
            // 
            this.botSettingsToolStripMenuItem.Name = "botSettingsToolStripMenuItem";
            this.botSettingsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.botSettingsToolStripMenuItem.Text = "Bot Settings";
            this.botSettingsToolStripMenuItem.Click += new System.EventHandler(this.botSettingsToolStripMenuItem_Click);
            // 
            // changeWoWPathToolStripMenuItem1
            // 
            this.changeWoWPathToolStripMenuItem1.Name = "changeWoWPathToolStripMenuItem1";
            this.changeWoWPathToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.changeWoWPathToolStripMenuItem1.Text = "Change WoW Path";
            this.changeWoWPathToolStripMenuItem1.Click += new System.EventHandler(this.changeWoWPathToolStripMenuItem1_Click);
            // 
            // resetAllRandomBotsToolStripMenuItem
            // 
            this.resetAllRandomBotsToolStripMenuItem.Name = "resetAllRandomBotsToolStripMenuItem";
            this.resetAllRandomBotsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.resetAllRandomBotsToolStripMenuItem.Text = "Reset Bots";
            this.resetAllRandomBotsToolStripMenuItem.Click += new System.EventHandler(this.resetAllRandomBotsToolStripMenuItem_Click);
            // 
            // randomizeBotsToolStripMenuItem
            // 
            this.randomizeBotsToolStripMenuItem.Name = "randomizeBotsToolStripMenuItem";
            this.randomizeBotsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.randomizeBotsToolStripMenuItem.Text = "Randomize Bots";
            this.randomizeBotsToolStripMenuItem.Click += new System.EventHandler(this.randomizeBotsToolStripMenuItem_Click);
            // 
            // exportCharactersToolStripMenuItem
            // 
            this.exportCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem2,
            this.importToolStripMenuItem2});
            this.exportCharactersToolStripMenuItem.Name = "exportCharactersToolStripMenuItem";
            this.exportCharactersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exportCharactersToolStripMenuItem.Text = "Export/Import Characters";
            // 
            // exportToolStripMenuItem2
            // 
            this.exportToolStripMenuItem2.Name = "exportToolStripMenuItem2";
            this.exportToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem2.Text = "Export";
            // 
            // importToolStripMenuItem2
            // 
            this.importToolStripMenuItem2.Name = "importToolStripMenuItem2";
            this.importToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem2.Text = "Import";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magyarToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // magyarToolStripMenuItem
            // 
            this.magyarToolStripMenuItem.Name = "magyarToolStripMenuItem";
            this.magyarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.magyarToolStripMenuItem.Text = "Magyar";
            this.magyarToolStripMenuItem.Click += new System.EventHandler(this.magyarToolStripMenuItem_Click_1);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Enabled = false;
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.frenchToolStripMenuItem.Text = "French";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Enabled = false;
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.germanToolStripMenuItem.Text = "German";
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lanSwitcherToolStripMenuItem1,
            this.accountToolToolStripMenuItem1});
            this.toolsToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.icon_gear;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // lanSwitcherToolStripMenuItem1
            // 
            this.lanSwitcherToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Other_Power_Switch_User_Metro_icon;
            this.lanSwitcherToolStripMenuItem1.Name = "lanSwitcherToolStripMenuItem1";
            this.lanSwitcherToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.lanSwitcherToolStripMenuItem1.Text = "Lan Switcher";
            this.lanSwitcherToolStripMenuItem1.Click += new System.EventHandler(this.lanSwitcherToolStripMenuItem1_Click);
            // 
            // accountToolToolStripMenuItem1
            // 
            this.accountToolToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.WoW_icon;
            this.accountToolToolStripMenuItem1.Name = "accountToolToolStripMenuItem1";
            this.accountToolToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.accountToolToolStripMenuItem1.Text = "Account Tool";
            this.accountToolToolStripMenuItem1.Click += new System.EventHandler(this.accountToolToolStripMenuItem1_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startstopToolStripMenuItem,
            this.restartToolStripMenuItem1,
            this.toolStripSeparator1,
            this.autostartToolStripMenuItem});
            this.restartToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Places_server_database_icon;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.restartToolStripMenuItem.Text = "Servers";
            // 
            // startstopToolStripMenuItem
            // 
            this.startstopToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Play_1_Hot_icon;
            this.startstopToolStripMenuItem.Name = "startstopToolStripMenuItem";
            this.startstopToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.startstopToolStripMenuItem.Text = "Start";
            this.startstopToolStripMenuItem.Click += new System.EventHandler(this.startstopToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem1
            // 
            this.restartToolStripMenuItem1.Enabled = false;
            this.restartToolStripMenuItem1.Image = global::SppLauncher.Properties.Resources.Other_Power_Restart_Metro_icon;
            this.restartToolStripMenuItem1.Name = "restartToolStripMenuItem1";
            this.restartToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.restartToolStripMenuItem1.Text = "Restart";
            this.restartToolStripMenuItem1.Click += new System.EventHandler(this.restartToolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // autostartToolStripMenuItem
            // 
            this.autostartToolStripMenuItem.Name = "autostartToolStripMenuItem";
            this.autostartToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.autostartToolStripMenuItem.Text = "Autostart";
            this.autostartToolStripMenuItem.Click += new System.EventHandler(this.autostartToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.report_bug_icon;
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.reportBugToolStripMenuItem.Text = "Report Bug";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.reportBugToolStripMenuItem_Click);
            // 
            // tsmHelpUs
            // 
            this.tsmHelpUs.Image = global::SppLauncher.Properties.Resources.heart_icon;
            this.tsmHelpUs.Name = "tsmHelpUs";
            this.tsmHelpUs.Size = new System.Drawing.Size(75, 20);
            this.tsmHelpUs.Text = "Help us";
            this.tsmHelpUs.Click += new System.EventHandler(this.tsmHelpUs_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SppLauncher.Properties.Resources.Information_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Image = global::SppLauncher.Properties.Resources.Windows_Close_Program_icon;
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLOnline,
            this.tssUsage,
            this.tssStatus});
            this.ssBar.Location = new System.Drawing.Point(0, 414);
            this.ssBar.Name = "ssBar";
            this.ssBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ssBar.ShowItemToolTips = true;
            this.ssBar.Size = new System.Drawing.Size(581, 22);
            this.ssBar.SizingGrip = false;
            this.ssBar.TabIndex = 30;
            this.ssBar.Text = "statusStrip1";
            // 
            // tssLOnline
            // 
            this.tssLOnline.Name = "tssLOnline";
            this.tssLOnline.Size = new System.Drawing.Size(91, 17);
            this.tssLOnline.Text = "Online bot: N/A";
            this.tssLOnline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssUsage
            // 
            this.tssUsage.Name = "tssUsage";
            this.tssUsage.Size = new System.Drawing.Size(494, 17);
            this.tssUsage.Spring = true;
            this.tssUsage.Text = "                      ";
            this.tssUsage.ToolTipText = "lol";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(39, 17);
            this.tssStatus.Text = "Status";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tssStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tssStatus.Click += new System.EventHandler(this.tssStatus_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 138);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 18);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Visible = false;
            // 
            // SrvAnnounce
            // 
            this.SrvAnnounce.Interval = 600000;
            this.SrvAnnounce.Tick += new System.EventHandler(this.SrvAnnounce_Tick);
            // 
            // lblWorldStartTime
            // 
            this.lblWorldStartTime.AutoSize = true;
            this.lblWorldStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblWorldStartTime.Location = new System.Drawing.Point(368, 388);
            this.lblWorldStartTime.Name = "lblWorldStartTime";
            this.lblWorldStartTime.Size = new System.Drawing.Size(17, 18);
            this.lblWorldStartTime.TabIndex = 31;
            this.lblWorldStartTime.Text = "0";
            // 
            // lblRealmStartTime
            // 
            this.lblRealmStartTime.AutoSize = true;
            this.lblRealmStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblRealmStartTime.Location = new System.Drawing.Point(214, 388);
            this.lblRealmStartTime.Name = "lblRealmStartTime";
            this.lblRealmStartTime.Size = new System.Drawing.Size(17, 18);
            this.lblRealmStartTime.TabIndex = 32;
            this.lblRealmStartTime.Text = "0";
            // 
            // lblSqlStartTime
            // 
            this.lblSqlStartTime.AutoSize = true;
            this.lblSqlStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSqlStartTime.Location = new System.Drawing.Point(95, 388);
            this.lblSqlStartTime.Name = "lblSqlStartTime";
            this.lblSqlStartTime.Size = new System.Drawing.Size(17, 18);
            this.lblSqlStartTime.TabIndex = 33;
            this.lblSqlStartTime.Text = "0";
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
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
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(581, 436);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblSqlStartTime);
            this.Controls.Add(this.lblRealmStartTime);
            this.Controls.Add(this.lblWorldStartTime);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.msForm);
            this.Controls.Add(this.rtWorldDev);
            this.Controls.Add(this.txbWorldDev);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msForm;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Player Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableW)).EndInit();
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
        private System.Windows.Forms.PictureBox pbAvailableM;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbTempM;
        private System.Windows.Forms.PictureBox pbNotAvailM;
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
        private System.Windows.Forms.ToolStripMenuItem accountToolAdvancedToolStripMenuItem;
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
        private System.Windows.Forms.Timer UpdateCompleteChecker;
        private System.Windows.Forms.ToolStripMenuItem botSettingsToolStripMenuItem1;
        private System.Windows.Forms.Timer StatusBarUpdater;
        private System.Windows.Forms.ToolStripMenuItem worldSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
        private System.Windows.Forms.ToolStripMenuItem exportCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magyarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
    }
}

