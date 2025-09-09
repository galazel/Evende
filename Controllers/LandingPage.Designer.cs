namespace Evende.Controllers
{
    partial class LandingPage
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
            this.landingPage_split = new Krypton.Toolkit.KryptonSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.landingPage_split)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landingPage_split.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landingPage_split.Panel2)).BeginInit();
            this.landingPage_split.SuspendLayout();
            this.SuspendLayout();
            // 
            // landingPage_split
            // 
            this.landingPage_split.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.landingPage_split.Cursor = System.Windows.Forms.Cursors.Default;
            this.landingPage_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.landingPage_split.Location = new System.Drawing.Point(0, 0);
            this.landingPage_split.Size = new System.Drawing.Size(906, 541);
            this.landingPage_split.SplitterDistance = 500;
            this.landingPage_split.TabIndex = 11;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 541);
            this.Controls.Add(this.landingPage_split);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.landingPage_split.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landingPage_split.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landingPage_split)).EndInit();
            this.landingPage_split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonSplitContainer landingPage_split;
    }
}