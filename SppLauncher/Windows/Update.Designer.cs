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
            this.bw_updater = new System.ComponentModel.BackgroundWorker();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_down
            // 
            this.pb_down.Location = new System.Drawing.Point(19, 35);
            this.pb_down.Margin = new System.Windows.Forms.Padding(2);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(298, 24);
            this.pb_down.TabIndex = 0;
            this.pb_down.Click += new System.EventHandler(this.pb_down_Click);
            // 
            // lbl_Perecent
            // 
            this.lbl_Perecent.AutoSize = true;
            this.lbl_Perecent.Location = new System.Drawing.Point(296, 19);
            this.lbl_Perecent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Perecent.Name = "lbl_Perecent";
            this.lbl_Perecent.Size = new System.Drawing.Size(21, 13);
            this.lbl_Perecent.TabIndex = 1;
            this.lbl_Perecent.Text = "0%";
            // 
            // lbl_downByte
            // 
            this.lbl_downByte.AutoSize = true;
            this.lbl_downByte.Location = new System.Drawing.Point(275, 61);
            this.lbl_downByte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_downByte.Name = "lbl_downByte";
            this.lbl_downByte.Size = new System.Drawing.Size(46, 13);
            this.lbl_downByte.TabIndex = 2;
            this.lbl_downByte.Text = "0 / 0 Kb";
            // 
            // bw_updater
            // 
            this.bw_updater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_updater_DoWork);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.lbl_speed);
            this.gb_status.Controls.Add(this.lbl_status);
            this.gb_status.Controls.Add(this.pb_down);
            this.gb_status.Controls.Add(this.lbl_downByte);
            this.gb_status.Controls.Add(this.lbl_Perecent);
            this.gb_status.Location = new System.Drawing.Point(9, 10);
            this.gb_status.Margin = new System.Windows.Forms.Padding(2);
            this.gb_status.Name = "gb_status";
            this.gb_status.Padding = new System.Windows.Forms.Padding(2);
            this.gb_status.Size = new System.Drawing.Size(334, 89);
            this.gb_status.TabIndex = 3;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Update Status";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(143, 61);
            this.lbl_speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(64, 13);
            this.lbl_speed.TabIndex = 4;
            this.lbl_speed.Text = "Speed: N/A";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(16, 61);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(40, 13);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Status:";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 109);
            this.Controls.Add(this.gb_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.Shown += new System.EventHandler(this.Update_Shown);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_down;
        private System.Windows.Forms.Label lbl_Perecent;
        private System.Windows.Forms.Label lbl_downByte;
        private System.ComponentModel.BackgroundWorker bw_updater;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_speed;
    }
}