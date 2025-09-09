namespace Evende.Controllers
{
    partial class GetStarted
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
            this.getStarted_button = new Guna.UI2.WinForms.Guna2Button();
            this.getStarted_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.getStarted_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // getStarted_button
            // 
            this.getStarted_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.getStarted_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.getStarted_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.getStarted_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.getStarted_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.getStarted_button.ForeColor = System.Drawing.Color.White;
            this.getStarted_button.Location = new System.Drawing.Point(372, 383);
            this.getStarted_button.Name = "getStarted_button";
            this.getStarted_button.Size = new System.Drawing.Size(180, 45);
            this.getStarted_button.TabIndex = 0;
            this.getStarted_button.Text = "Get Started";
            this.getStarted_button.Click += new System.EventHandler(this.getStarted_button_Click);
            // 
            // getStarted_panel
            // 
            this.getStarted_panel.Controls.Add(this.getStarted_button);
            this.getStarted_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getStarted_panel.Location = new System.Drawing.Point(0, 0);
            this.getStarted_panel.Name = "getStarted_panel";
            this.getStarted_panel.Size = new System.Drawing.Size(906, 541);
            this.getStarted_panel.TabIndex = 1;
            // 
            // GetStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 541);
            this.Controls.Add(this.getStarted_panel);
            this.Name = "GetStarted";
            this.Text = "Evende";
            this.getStarted_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button getStarted_button;
        private Guna.UI2.WinForms.Guna2Panel getStarted_panel;
    }
}