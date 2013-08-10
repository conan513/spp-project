namespace SppLauncher
{
    partial class Update_Completed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Completed));
            this.lbl_completed = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_currVer = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pb_pic = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_completed
            // 
            resources.ApplyResources(this.lbl_completed, "lbl_completed");
            this.lbl_completed.Name = "lbl_completed";
            // 
            // lbl_ver
            // 
            resources.ApplyResources(this.lbl_ver, "lbl_ver");
            this.lbl_ver.Name = "lbl_ver";
            // 
            // lbl_currVer
            // 
            resources.ApplyResources(this.lbl_currVer, "lbl_currVer");
            this.lbl_currVer.Name = "lbl_currVer";
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel.Controls.Add(this.btn_ok);
            this.panel.Name = "panel";
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pb_pic
            // 
            resources.ApplyResources(this.pb_pic, "pb_pic");
            this.pb_pic.Image = global::SppLauncher.Properties.Resources.pic_tick;
            this.pb_pic.Name = "pb_pic";
            this.pb_pic.TabStop = false;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // Update_Completed
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_currVer);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl_completed);
            this.Controls.Add(this.pb_pic);
            this.Controls.Add(this.lbl_ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Completed";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_pic;
        private System.Windows.Forms.Label lbl_completed;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label lbl_currVer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}