namespace BankSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_error_output = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.register_repeat_password = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_error_output = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightGreen;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(92, 445);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(254, 98);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.login_error_output);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.login_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 655);
            this.panel1.TabIndex = 2;
            // 
            // login_error_output
            // 
            this.login_error_output.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_error_output.ForeColor = System.Drawing.Color.Red;
            this.login_error_output.Location = new System.Drawing.Point(92, 382);
            this.login_error_output.Name = "login_error_output";
            this.login_error_output.Size = new System.Drawing.Size(254, 60);
            this.login_error_output.TabIndex = 6;
            this.login_error_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(92, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(92, 260);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(254, 27);
            this.login_password.TabIndex = 4;
            this.login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_password_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:  ";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(92, 190);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(254, 27);
            this.login_username.TabIndex = 2;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.register_error_output);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.registerButton);
            this.panel2.Controls.Add(this.register_repeat_password);
            this.panel2.Controls.Add(this.register_password);
            this.panel2.Controls.Add(this.register_username);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(567, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 655);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(114, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Repeat password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(114, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password: (8 char. min)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(114, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username: (2 - 20 char.)";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.LightGreen;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Image = ((System.Drawing.Image)(resources.GetObject("registerButton.Image")));
            this.registerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerButton.Location = new System.Drawing.Point(114, 445);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(254, 98);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // register_repeat_password
            // 
            this.register_repeat_password.Location = new System.Drawing.Point(114, 336);
            this.register_repeat_password.Name = "register_repeat_password";
            this.register_repeat_password.PasswordChar = '*';
            this.register_repeat_password.Size = new System.Drawing.Size(254, 27);
            this.register_repeat_password.TabIndex = 5;
            this.register_repeat_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.register_repeat_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.register_repeat_password_KeyDown);
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(114, 260);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(254, 27);
            this.register_password.TabIndex = 4;
            this.register_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_username
            // 
            this.register_username.Location = new System.Drawing.Point(114, 190);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(254, 27);
            this.register_username.TabIndex = 3;
            this.register_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(114, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 54);
            this.label4.TabIndex = 2;
            this.label4.Text = "Register";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_error_output
            // 
            this.register_error_output.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register_error_output.ForeColor = System.Drawing.Color.Red;
            this.register_error_output.Location = new System.Drawing.Point(114, 382);
            this.register_error_output.Name = "register_error_output";
            this.register_error_output.Size = new System.Drawing.Size(254, 60);
            this.register_error_output.TabIndex = 10;
            this.register_error_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1023, 655);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button loginButton;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox login_password;
        private Label label2;
        private TextBox login_username;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Button registerButton;
        private TextBox register_repeat_password;
        private TextBox register_password;
        private TextBox register_username;
        private Label label4;
        private Label label7;
        private Label login_error_output;
        private Label register_error_output;
    }
}
