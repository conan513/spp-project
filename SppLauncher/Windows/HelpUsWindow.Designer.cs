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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DonateWhiter = new System.Windows.Forms.PictureBox();
            this.DonateConan = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DonateList = new System.Windows.Forms.ListView();
            this.donatename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bWGetDonators = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonateWhiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonateConan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DonateWhiter);
            this.groupBox1.Controls.Add(this.DonateConan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.DonateList);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // DonateList
            // 
            resources.ApplyResources(this.DonateList, "DonateList");
            this.DonateList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.donatename,
            this.amount,
            this.to,
            this.datek});
            this.DonateList.FullRowSelect = true;
            this.DonateList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DonateList.Name = "DonateList";
            this.DonateList.Scrollable = false;
            this.DonateList.UseCompatibleStateImageBehavior = false;
            this.DonateList.View = System.Windows.Forms.View.Details;
            // 
            // donatename
            // 
            resources.ApplyResources(this.donatename, "donatename");
            // 
            // amount
            // 
            resources.ApplyResources(this.amount, "amount");
            // 
            // to
            // 
            resources.ApplyResources(this.to, "to");
            // 
            // datek
            // 
            resources.ApplyResources(this.datek, "datek");
            // 
            // bWGetDonators
            // 
            this.bWGetDonators.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWGetDonators_DoWork);
            // 
            // HelpUsWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox DonateWhiter;
        private System.Windows.Forms.PictureBox DonateConan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView DonateList;
        private System.Windows.Forms.ColumnHeader donatename;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.ColumnHeader datek;
        private System.ComponentModel.BackgroundWorker bWGetDonators;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}
