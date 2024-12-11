namespace WinFormsApp1123211
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();

            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(235, 47);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(222, 31);
            txtUsername.TabIndex = 0;
            txtUsername.BackColor = Color.LightCyan; // Šviesiai mėlyna spalva
            txtUsername.ForeColor = Color.DarkBlue; // Tamsiai mėlyna spalva

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(235, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(222, 31);
            txtPassword.TabIndex = 1;
            txtPassword.BackColor = Color.LightCyan; // Šviesiai mėlyna spalva
            txtPassword.ForeColor = Color.DarkBlue; // Tamsiai mėlyna spalva
            txtPassword.TextChanged += txtPassword_TextChanged;

            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(235, 147);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Prisijungti";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.BackColor = Color.LightGreen; // Šviesiai žalia spalva
            btnLogin.ForeColor = Color.DarkGreen; // Tamsiai žalia spalva
            btnLogin.Click += btnLogin_Click;

            // 
            // btnExit
            // 
            btnExit.Location = new Point(345, 147);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Išeiti";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.BackColor = Color.LightCoral; // Šviesiai raudona spalva
            btnExit.ForeColor = Color.DarkRed; // Tamsiai raudona spalva
            btnExit.Click += btnExit_Click;

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(58, 47);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(171, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Prisijungimo vardas:";
            lblUsername.ForeColor = Color.DarkBlue; // Tamsiai mėlyna spalva

            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(58, 97);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Slaptažodis:";
            lblPassword.ForeColor = Color.DarkBlue; // Tamsiai mėlyna spalva

            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 285);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prisijungimas";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
