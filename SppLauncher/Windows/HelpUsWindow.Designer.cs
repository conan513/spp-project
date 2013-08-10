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
            this.DonateWhiter = new System.Windows.Forms.PictureBox();
            this.DonateConan = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonateWhiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonateConan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.DonateWhiter);
            this.groupBox1.Controls.Add(this.DonateConan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // DonateWhiter
            // 
            resources.ApplyResources(this.DonateWhiter, "DonateWhiter");
            this.DonateWhiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateWhiter.Image = global::SppLauncher.Properties.Resources.paypal_donate_button;
            this.DonateWhiter.Name = "DonateWhiter";
            this.DonateWhiter.TabStop = false;
            this.DonateWhiter.Click += new System.EventHandler(this.DonateWhiter_Click);
            // 
            // DonateConan
            // 
            resources.ApplyResources(this.DonateConan, "DonateConan");
            this.DonateConan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateConan.Image = global::SppLauncher.Properties.Resources.paypal_donate_button;
            this.DonateConan.Name = "DonateConan";
            this.DonateConan.TabStop = false;
            this.DonateConan.Click += new System.EventHandler(this.DonateConan_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // HelpUsWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpUsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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
