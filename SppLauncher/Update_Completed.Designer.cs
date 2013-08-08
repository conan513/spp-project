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
            this.lbl_completed.AutoSize = true;
            this.lbl_completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_completed.Location = new System.Drawing.Point(104, 30);
            this.lbl_completed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_completed.Name = "lbl_completed";
            this.lbl_completed.Size = new System.Drawing.Size(131, 18);
            this.lbl_completed.TabIndex = 1;
            this.lbl_completed.Text = "Update Completed";
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ver.Location = new System.Drawing.Point(120, 67);
            this.lbl_ver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(62, 18);
            this.lbl_ver.TabIndex = 2;
            this.lbl_ver.Text = "Version:";
            // 
            // lbl_currVer
            // 
            this.lbl_currVer.AutoSize = true;
            this.lbl_currVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_currVer.Location = new System.Drawing.Point(182, 67);
            this.lbl_currVer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_currVer.Name = "lbl_currVer";
            this.lbl_currVer.Size = new System.Drawing.Size(28, 18);
            this.lbl_currVer.TabIndex = 3;
            this.lbl_currVer.Text = "ver";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel.Controls.Add(this.btn_ok);
            this.panel.Location = new System.Drawing.Point(-15, 192);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(281, 52);
            this.panel.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(105, 14);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pb_pic
            // 
            this.pb_pic.Image = global::SppLauncher.Properties.Resources.pic_tick;
            this.pb_pic.Location = new System.Drawing.Point(16, 30);
            this.pb_pic.Margin = new System.Windows.Forms.Padding(2);
            this.pb_pic.Name = "pb_pic";
            this.pb_pic.Size = new System.Drawing.Size(60, 65);
            this.pb_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pic.TabIndex = 0;
            this.pb_pic.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(230, 68);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "v1.0.5\nChangelog:\n- Bug report send versions";
            // 
            // Update_Completed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 241);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_currVer);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl_completed);
            this.Controls.Add(this.pb_pic);
            this.Controls.Add(this.lbl_ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Completed";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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