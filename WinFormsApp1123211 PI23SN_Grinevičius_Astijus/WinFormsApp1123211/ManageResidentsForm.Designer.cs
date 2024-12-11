namespace WinFormsApp1123211
{
    partial class ManageResidentsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbHomes;
        private System.Windows.Forms.ComboBox cmbResidents;
        private System.Windows.Forms.TextBox txtResidentName;
        private System.Windows.Forms.TextBox txtResidentLogin;
        private System.Windows.Forms.Button btnCreateResident;
        private System.Windows.Forms.Button btnDeleteResident;
        private System.Windows.Forms.Button btnAssignResident;
        private System.Windows.Forms.Button btnRemoveResident;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblResidents;
        private System.Windows.Forms.Label lblResidentName;
        private System.Windows.Forms.Label lblResidentLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        void InitializeComponent()
        {
            cmbHomes = new ComboBox();
            cmbResidents = new ComboBox();
            txtResidentName = new TextBox();
            txtResidentLogin = new TextBox();
            btnCreateResident = new Button();
            btnDeleteResident = new Button();
            btnAssignResident = new Button();
            btnRemoveResident = new Button();
            btnBack = new Button();
            lblHome = new Label();
            lblResidents = new Label();
            lblResidentName = new Label();
            lblResidentLogin = new Label();
            SuspendLayout();

            // ComboBox for homes
            cmbHomes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHomes.FormattingEnabled = true;
            cmbHomes.Location = new Point(268, 86);
            cmbHomes.Name = "cmbHomes";
            cmbHomes.Size = new Size(200, 33);
            cmbHomes.TabIndex = 0;
            cmbHomes.BackColor = Color.LavenderBlush;
            cmbHomes.Font = new Font("Segoe UI", 12F);

            // ComboBox for residents
            cmbResidents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResidents.FormattingEnabled = true;
            cmbResidents.Location = new Point(268, 126);
            cmbResidents.Name = "cmbResidents";
            cmbResidents.Size = new Size(200, 33);
            cmbResidents.TabIndex = 1;
            cmbResidents.BackColor = Color.LavenderBlush;
            cmbResidents.Font = new Font("Segoe UI", 12F);

            // TextBox for resident name
            txtResidentName.Location = new Point(268, 166);
            txtResidentName.Name = "txtResidentName";
            txtResidentName.Size = new Size(200, 31);
            txtResidentName.TabIndex = 2;
            txtResidentName.BackColor = Color.MistyRose;
            txtResidentName.Font = new Font("Segoe UI", 12F);

            // TextBox for resident login
            txtResidentLogin.Location = new Point(268, 206);
            txtResidentLogin.Name = "txtResidentLogin";
            txtResidentLogin.Size = new Size(200, 31);
            txtResidentLogin.TabIndex = 3;
            txtResidentLogin.BackColor = Color.MistyRose;
            txtResidentLogin.Font = new Font("Segoe UI", 12F);

            // Button to create resident
            btnCreateResident.Location = new Point(518, 62);
            btnCreateResident.Name = "btnCreateResident";
            btnCreateResident.Size = new Size(191, 39);
            btnCreateResident.TabIndex = 4;
            btnCreateResident.Text = "Sukurti gyventoją";
            btnCreateResident.UseVisualStyleBackColor = true;
            btnCreateResident.BackColor = Color.MediumSeaGreen;
            btnCreateResident.ForeColor = Color.White;
            btnCreateResident.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateResident.FlatStyle = FlatStyle.Flat;
            btnCreateResident.Click += btnCreateResident_Click;

            // Button to delete resident
            btnDeleteResident.Location = new Point(518, 112);
            btnDeleteResident.Name = "btnDeleteResident";
            btnDeleteResident.Size = new Size(191, 39);
            btnDeleteResident.TabIndex = 5;
            btnDeleteResident.Text = "Pašalinti gyventoją";
            btnDeleteResident.UseVisualStyleBackColor = true;
            btnDeleteResident.BackColor = Color.Crimson;
            btnDeleteResident.ForeColor = Color.White;
            btnDeleteResident.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteResident.FlatStyle = FlatStyle.Flat;
            btnDeleteResident.Click += btnDeleteResident_Click;

            // Button to assign resident
            btnAssignResident.Location = new Point(518, 162);
            btnAssignResident.Name = "btnAssignResident";
            btnAssignResident.Size = new Size(191, 39);
            btnAssignResident.TabIndex = 6;
            btnAssignResident.Text = "Priskirti gyventoją";
            btnAssignResident.UseVisualStyleBackColor = true;
            btnAssignResident.BackColor = Color.SteelBlue;
            btnAssignResident.ForeColor = Color.White;
            btnAssignResident.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAssignResident.FlatStyle = FlatStyle.Flat;
            btnAssignResident.Click += btnAssignResident_Click;

            // Button to remove resident from house
            btnRemoveResident.Location = new Point(518, 216);
            btnRemoveResident.Name = "btnRemoveResident";
            btnRemoveResident.Size = new Size(191, 39);
            btnRemoveResident.TabIndex = 7;
            btnRemoveResident.Text = "Pašalinti iš namo";
            btnRemoveResident.UseVisualStyleBackColor = true;
            btnRemoveResident.BackColor = Color.Tomato;
            btnRemoveResident.ForeColor = Color.White;
            btnRemoveResident.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemoveResident.FlatStyle = FlatStyle.Flat;
            btnRemoveResident.Click += btnRemoveResident_Click;

            // Button to go back
            btnBack.Location = new Point(369, 266);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(99, 41);
            btnBack.TabIndex = 8;
            btnBack.Text = "Grįžti";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.BackColor = Color.Goldenrod;
            btnBack.ForeColor = Color.White;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Click += btnBack_Click;

            // Label for home selection
            lblHome.AutoSize = true;
            lblHome.Location = new Point(88, 86);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(134, 25);
            lblHome.TabIndex = 9;
            lblHome.Text = "Pasirinkti namą:";
            lblHome.Font = new Font("Segoe UI", 12F);
            lblHome.ForeColor = Color.DarkSlateGray;

            // Label for residents selection
            lblResidents.AutoSize = true;
            lblResidents.Location = new Point(88, 126);
            lblResidents.Name = "lblResidents";
            lblResidents.Size = new Size(168, 25);
            lblResidents.TabIndex = 10;
            lblResidents.Text = "Pasirinkti gyventoją:";
            lblResidents.Font = new Font("Segoe UI", 12F);
            lblResidents.ForeColor = Color.DarkSlateGray;

            // Label for resident name input
            lblResidentName.AutoSize = true;
            lblResidentName.Location = new Point(88, 166);
            lblResidentName.Name = "lblResidentName";
            lblResidentName.Size = new Size(154, 25);
            lblResidentName.TabIndex = 11;
            lblResidentName.Text = "Gyventojo vardas:";
            lblResidentName.Font = new Font("Segoe UI", 12F);
            lblResidentName.ForeColor = Color.DarkSlateGray;

            // Label for resident login input
            lblResidentLogin.AutoSize = true;
            lblResidentLogin.Location = new Point(88, 206);
            lblResidentLogin.Name = "lblResidentLogin";
            lblResidentLogin.Size = new Size(166, 25);
            lblResidentLogin.TabIndex = 12;
            lblResidentLogin.Text = "Gyventojo pavardė:";
            lblResidentLogin.Font = new Font("Segoe UI", 12F);
            lblResidentLogin.ForeColor = Color.DarkSlateGray;

            // Form settings
            ClientSize = new Size(808, 381);
            Controls.Add(lblHome);
            Controls.Add(cmbHomes);
            Controls.Add(lblResidents);
            Controls.Add(cmbResidents);
            Controls.Add(lblResidentName);
            Controls.Add(txtResidentName);
            Controls.Add(lblResidentLogin);
            Controls.Add(txtResidentLogin);
            Controls.Add(btnCreateResident);
            Controls.Add(btnDeleteResident);
            Controls.Add(btnAssignResident);
            Controls.Add(btnRemoveResident);
            Controls.Add(btnBack);
            Name = "ManageResidentsForm";
            Text = "Redaguoti gyventojus";
            BackColor = Color.LightGray; // Fono spalva
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
