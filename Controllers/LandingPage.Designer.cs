namespace Evende.Controllers
{
    partial class landingPage_form
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
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.register_button = new Guna.UI2.WinForms.Guna2Button();
            this.evende_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.landingPage_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.landingPage_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(258, 241);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(180, 45);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.register_button.ForeColor = System.Drawing.Color.White;
            this.register_button.Location = new System.Drawing.Point(258, 304);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(180, 45);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Register";
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // evende_label
            // 
            this.evende_label.BackColor = System.Drawing.Color.Transparent;
            this.evende_label.Location = new System.Drawing.Point(325, 120);
            this.evende_label.Name = "evende_label";
            this.evende_label.Size = new System.Drawing.Size(40, 15);
            this.evende_label.TabIndex = 2;
            this.evende_label.Text = "Evende";
            // 
            // landingPage_panel
            // 
            this.landingPage_panel.BackColor = System.Drawing.Color.White;
            this.landingPage_panel.Controls.Add(this.evende_label);
            this.landingPage_panel.Controls.Add(this.register_button);
            this.landingPage_panel.Controls.Add(this.login_button);
            this.landingPage_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.landingPage_panel.Location = new System.Drawing.Point(0, 0);
            this.landingPage_panel.Name = "landingPage_panel";
            this.landingPage_panel.Size = new System.Drawing.Size(679, 450);
            this.landingPage_panel.TabIndex = 3;
            this.landingPage_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.landingPage_panel_Paint);
            // 
            // landingPage_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.landingPage_panel);
            this.Name = "landingPage_form";
            this.Text = "LandingPage";
            this.landingPage_panel.ResumeLayout(false);
            this.landingPage_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2Button register_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel evende_label;
        private Guna.UI2.WinForms.Guna2Panel landingPage_panel;
    }
}