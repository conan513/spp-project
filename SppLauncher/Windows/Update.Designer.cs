namespace SppLauncher
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.pb_down = new System.Windows.Forms.ProgressBar();
            this.lbl_Perecent = new System.Windows.Forms.Label();
            this.lbl_downByte = new System.Windows.Forms.Label();
            this.bw_LauncherUpdate = new System.ComponentModel.BackgroundWorker();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.bw_LangUpdate = new System.ComponentModel.BackgroundWorker();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_down
            // 
            resources.ApplyResources(this.pb_down, "pb_down");
            this.pb_down.Name = "pb_down";
            this.pb_down.Click += new System.EventHandler(this.pb_down_Click);
            // 
            // lbl_Perecent
            // 
            resources.ApplyResources(this.lbl_Perecent, "lbl_Perecent");
            this.lbl_Perecent.Name = "lbl_Perecent";
            // 
            // lbl_downByte
            // 
            resources.ApplyResources(this.lbl_downByte, "lbl_downByte");
            this.lbl_downByte.Name = "lbl_downByte";
            // 
            // bw_LauncherUpdate
            // 
            this.bw_LauncherUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_updater_DoWork);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.lbl_speed);
            this.gb_status.Controls.Add(this.lbl_status);
            this.gb_status.Controls.Add(this.pb_down);
            this.gb_status.Controls.Add(this.lbl_downByte);
            this.gb_status.Controls.Add(this.lbl_Perecent);
            resources.ApplyResources(this.gb_status, "gb_status");
            this.gb_status.Name = "gb_status";
            this.gb_status.TabStop = false;
            // 
            // lbl_speed
            // 
            resources.ApplyResources(this.lbl_speed, "lbl_speed");
            this.lbl_speed.Name = "lbl_speed";
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // bw_LangUpdate
            // 
            this.bw_LangUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_LangUpdate_DoWork);
            this.bw_LangUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_LangUpdate_RunWorkerCompleted);
            // 
            // Update
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_status);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.Update_Shown);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_down;
        private System.Windows.Forms.Label lbl_Perecent;
        private System.Windows.Forms.Label lbl_downByte;
        private System.ComponentModel.BackgroundWorker bw_LauncherUpdate;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_speed;
        public System.ComponentModel.BackgroundWorker bw_LangUpdate;
    }
}