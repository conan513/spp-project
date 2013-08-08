namespace SppLauncher
{
    partial class HelpUsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpUsWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DonateWhiter = new System.Windows.Forms.PictureBox();
            this.DonateConan = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonateWhiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonateConan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DonateWhiter);
            this.groupBox1.Controls.Add(this.DonateConan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server and Database: Conan513";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Launcher and Tools: Whit33r";
            // 
            // DonateWhiter
            // 
            this.DonateWhiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateWhiter.Image = global::SppLauncher.Properties.Resources.paypal_donate_button;
            this.DonateWhiter.Location = new System.Drawing.Point(185, 57);
            this.DonateWhiter.Name = "DonateWhiter";
            this.DonateWhiter.Size = new System.Drawing.Size(62, 31);
            this.DonateWhiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DonateWhiter.TabIndex = 3;
            this.DonateWhiter.TabStop = false;
            this.DonateWhiter.Click += new System.EventHandler(this.DonateWhiter_Click);
            // 
            // DonateConan
            // 
            this.DonateConan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateConan.Image = global::SppLauncher.Properties.Resources.paypal_donate_button;
            this.DonateConan.Location = new System.Drawing.Point(185, 20);
            this.DonateConan.Name = "DonateConan";
            this.DonateConan.Size = new System.Drawing.Size(62, 31);
            this.DonateConan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DonateConan.TabIndex = 2;
            this.DonateConan.TabStop = false;
            this.DonateConan.Click += new System.EventHandler(this.DonateConan_Click);
            // 
            // HelpUsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 129);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpUsWindow";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help us";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonateWhiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonateConan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox DonateWhiter;
        private System.Windows.Forms.PictureBox DonateConan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
