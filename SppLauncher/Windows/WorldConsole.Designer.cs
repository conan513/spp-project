namespace SppLauncher.Windows
{
    partial class WorldConsole
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
            this.rtWorldDev = new System.Windows.Forms.RichTextBox();
            this.txbWorldDev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtWorldDev
            // 
            this.rtWorldDev.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtWorldDev.Location = new System.Drawing.Point(12, 12);
            this.rtWorldDev.Name = "rtWorldDev";
            this.rtWorldDev.Size = new System.Drawing.Size(260, 166);
            this.rtWorldDev.TabIndex = 0;
            this.rtWorldDev.Text = "";
            this.rtWorldDev.TextChanged += new System.EventHandler(this.rtWorldDev_TextChanged);
            // 
            // txbWorldDev
            // 
            this.txbWorldDev.Location = new System.Drawing.Point(12, 184);
            this.txbWorldDev.Name = "txbWorldDev";
            this.txbWorldDev.Size = new System.Drawing.Size(260, 20);
            this.txbWorldDev.TabIndex = 1;
            // 
            // WorldConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txbWorldDev);
            this.Controls.Add(this.rtWorldDev);
            this.Name = "WorldConsole";
            this.Text = "WorldConsole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbWorldDev;
        public System.Windows.Forms.RichTextBox rtWorldDev;
    }
}