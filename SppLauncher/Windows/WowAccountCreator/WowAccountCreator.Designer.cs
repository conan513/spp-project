namespace WowAccountCreator
{
    partial class WowaccountCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WowaccountCreator));
            this.cbEx = new System.Windows.Forms.ComboBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.gbAcc = new System.Windows.Forms.GroupBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.bwUpdate = new System.ComponentModel.BackgroundWorker();
            this.bwUsageStatSender = new System.ComponentModel.BackgroundWorker();
            this.gbAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEx
            // 
            this.cbEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEx.FormattingEnabled = true;
            this.cbEx.Items.AddRange(new object[] {
            resources.GetString("cbEx.Items"),
            resources.GetString("cbEx.Items1"),
            resources.GetString("cbEx.Items2")});
            resources.ApplyResources(this.cbEx, "cbEx");
            this.cbEx.Name = "cbEx";
            this.cbEx.SelectedIndexChanged += new System.EventHandler(this.cbEx_SelectedIndexChanged);
            // 
            // txbUser
            // 
            resources.ApplyResources(this.txbUser, "txbUser");
            this.txbUser.Name = "txbUser";
            // 
            // txbPass
            // 
            resources.ApplyResources(this.txbPass, "txbPass");
            this.txbPass.Name = "txbPass";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            resources.GetString("cbType.Items"),
            resources.GetString("cbType.Items1"),
            resources.GetString("cbType.Items2"),
            resources.GetString("cbType.Items3")});
            resources.ApplyResources(this.cbType, "cbType");
            this.cbType.Name = "cbType";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // gbAcc
            // 
            this.gbAcc.Controls.Add(this.lblPass);
            this.gbAcc.Controls.Add(this.cbEx);
            this.gbAcc.Controls.Add(this.lblUser);
            this.gbAcc.Controls.Add(this.cbType);
            this.gbAcc.Controls.Add(this.lblType);
            this.gbAcc.Controls.Add(this.lblEx);
            this.gbAcc.Controls.Add(this.btnCreate);
            this.gbAcc.Controls.Add(this.txbUser);
            this.gbAcc.Controls.Add(this.txbPass);
            resources.ApplyResources(this.gbAcc, "gbAcc");
            this.gbAcc.Name = "gbAcc";
            this.gbAcc.TabStop = false;
            // 
            // lblPass
            // 
            resources.ApplyResources(this.lblPass, "lblPass");
            this.lblPass.Name = "lblPass";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.Name = "lblUser";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // lblEx
            // 
            resources.ApplyResources(this.lblEx, "lblEx");
            this.lblEx.Name = "lblEx";
            // 
            // WowaccountCreator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WowaccountCreator";
            this.ShowIcon = false;
            this.gbAcc.ResumeLayout(false);
            this.gbAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEx;
        public System.Windows.Forms.TextBox txbUser;
        public System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox gbAcc;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblType;
        private System.ComponentModel.BackgroundWorker bwUpdate;
        private System.ComponentModel.BackgroundWorker bwUsageStatSender;
    }
}

