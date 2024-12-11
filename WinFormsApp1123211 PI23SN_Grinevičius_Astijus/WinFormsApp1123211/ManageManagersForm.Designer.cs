namespace WinFormsApp1123211
{
    partial class ManageManagersForm
    {
        private System.ComponentModel.IContainer components = null;

        // Formos komponentai
        private System.Windows.Forms.ComboBox cmbHomes;
        private System.Windows.Forms.ComboBox cmbManagers;
        private System.Windows.Forms.Button btnAssignManager;
        private System.Windows.Forms.Button btnRemoveManager;
        private System.Windows.Forms.Button btnCreateManager;
        private System.Windows.Forms.Button btnDeleteManager;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHomes;
        private System.Windows.Forms.Label lblManagers;
        private System.Windows.Forms.Label lblNewManagerName;
        private System.Windows.Forms.Label lblNewManagerPassword;
        private System.Windows.Forms.TextBox txtNewManagerName;
        private System.Windows.Forms.TextBox txtNewManagerPassword;

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
            // Komponentų inicializavimas
            cmbHomes = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(218, 30),
                Name = "cmbHomes",
                Size = new Size(367, 33),
                TabIndex = 1
            };

            cmbManagers = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(218, 70),
                Name = "cmbManagers",
                Size = new Size(367, 33),
                TabIndex = 3
            };

            btnAssignManager = new Button
            {
                Location = new Point(218, 120),
                Name = "btnAssignManager",
                Size = new Size(140, 30),
                TabIndex = 4,
                Text = "Priskirti ",
                UseVisualStyleBackColor = true,
                BackColor = Color.LightGreen // Added color
            };
            btnAssignManager.Click += btnAssignManager_Click;

            btnRemoveManager = new Button
            {
                Location = new Point(364, 120),
                Name = "btnRemoveManager",
                Size = new Size(221, 30),
                TabIndex = 5,
                Text = "Pašalinti vadybininką",
                UseVisualStyleBackColor = true,
                BackColor = Color.IndianRed // Added color
            };
            btnRemoveManager.Click += btnRemoveManager_Click;

            btnCreateManager = new Button
            {
                Location = new Point(271, 250),
                Name = "btnCreateManager",
                Size = new Size(115, 30),
                TabIndex = 10,
                Text = "Sukurti ",
                UseVisualStyleBackColor = true,
                BackColor = Color.LightBlue // Added color
            };
            btnCreateManager.Click += btnCreateManager_Click;

            btnDeleteManager = new Button
            {
                Location = new Point(432, 250),
                Name = "btnDeleteManager",
                Size = new Size(104, 30),
                TabIndex = 11,
                Text = "Pašalinti ",
                UseVisualStyleBackColor = true,
                BackColor = Color.LightCoral // Added color
            };
            btnDeleteManager.Click += btnDeleteManager_Click;

            btnBack = new Button
            {
                Location = new Point(359, 315),
                Name = "btnBack",
                Size = new Size(102, 35),
                TabIndex = 12,
                Text = "Grįžti",
                UseVisualStyleBackColor = true,
                BackColor = Color.LightGray // Added color
            };
            btnBack.Click += btnBack_Click;

            lblHomes = new Label
            {
                AutoSize = true,
                Location = new Point(50, 30),
                Name = "lblHomes",
                Size = new Size(150, 25),
                TabIndex = 0,
                Text = "Namo pavadinimas:",
                ForeColor = Color.DarkBlue // Added text color
            };

            lblManagers = new Label
            {
                AutoSize = true,
                Location = new Point(50, 70),
                Name = "lblManagers",
                Size = new Size(120, 25),
                TabIndex = 2,
                Text = "Vadybininkas:",
                ForeColor = Color.DarkBlue // Added text color
            };

            lblNewManagerName = new Label
            {
                AutoSize = true,
                Location = new Point(50, 170),
                Name = "lblNewManagerName",
                Size = new Size(171, 25),
                TabIndex = 6,
                Text = "Vadybininko vardas:",
                ForeColor = Color.DarkBlue // Added text color
            };

            lblNewManagerPassword = new Label
            {
                AutoSize = true,
                Location = new Point(50, 210),
                Name = "lblNewManagerPassword",
                Size = new Size(208, 25),
                TabIndex = 8,
                Text = "Vadybininko slaptažodis:",
                ForeColor = Color.DarkBlue // Added text color
            };

            txtNewManagerName = new TextBox
            {
                Location = new Point(276, 173),
                Name = "txtNewManagerName",
                Size = new Size(260, 31),
                TabIndex = 7
            };

            txtNewManagerPassword = new TextBox
            {
                Location = new Point(276, 210),
                Name = "txtNewManagerPassword",
                Size = new Size(260, 31),
                TabIndex = 9
            };

            // Formos savybės ir valdiklių pridėjimas
            ClientSize = new Size(656, 450);
            Controls.Add(lblHomes);
            Controls.Add(cmbHomes);
            Controls.Add(lblManagers);
            Controls.Add(cmbManagers);
            Controls.Add(btnAssignManager);
            Controls.Add(btnRemoveManager);
            Controls.Add(lblNewManagerName);
            Controls.Add(txtNewManagerName);
            Controls.Add(lblNewManagerPassword);
            Controls.Add(txtNewManagerPassword);
            Controls.Add(btnCreateManager);
            Controls.Add(btnDeleteManager);
            Controls.Add(btnBack);
            Name = "ManageManagersForm";
            Text = "Vadybininkų redagavimas";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
