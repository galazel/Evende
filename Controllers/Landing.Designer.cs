namespace Evende.Controllers
{
    partial class Landing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.register_button = new Guna.UI2.WinForms.Guna2Button();
            this.evende_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.login_button.Location = new System.Drawing.Point(95, 265);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(180, 45);
            this.login_button.TabIndex = 10;
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
            this.register_button.Location = new System.Drawing.Point(95, 316);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(180, 45);
            this.register_button.TabIndex = 11;
            this.register_button.Text = "Register";
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // evende_label
            // 
            this.evende_label.BackColor = System.Drawing.Color.Transparent;
            this.evende_label.Location = new System.Drawing.Point(164, 105);
            this.evende_label.Name = "evende_label";
            this.evende_label.Size = new System.Drawing.Size(40, 15);
            this.evende_label.TabIndex = 12;
            this.evende_label.Text = "Evende";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.evende_label);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Landing";
            this.Size = new System.Drawing.Size(370, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2Button register_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel evende_label;
    }
}
