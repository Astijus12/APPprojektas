namespace WinFormsApp1123211
{
    partial class ManageHomesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbHomes;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.TextBox txtHomeName;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.TextBox txtNewServiceName;
        private System.Windows.Forms.Button btnCreateHome;
        private System.Windows.Forms.Button btnDeleteHome;
        private System.Windows.Forms.Button btnCreateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAssignServiceToHome;
        private System.Windows.Forms.Button btnRemoveServiceFromHome;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHomeName;
        private System.Windows.Forms.Label lblHomes;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label lblNewServiceName;

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
            cmbServices = new ComboBox();
            txtHomeName = new TextBox();
            txtServicePrice = new TextBox();
            txtNewServiceName = new TextBox();
            btnCreateHome = new Button();
            btnDeleteHome = new Button();
            btnCreateService = new Button();
            btnDeleteService = new Button();
            btnAssignServiceToHome = new Button();
            btnRemoveServiceFromHome = new Button();
            btnUpdatePrice = new Button();
            btnBack = new Button();
            lblHomeName = new Label();
            lblHomes = new Label();
            lblServices = new Label();
            lblServicePrice = new Label();
            lblNewServiceName = new Label();
            label1 = new Label();
            SuspendLayout();

            // ComboBox Homes
            cmbHomes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHomes.FormattingEnabled = true;
            cmbHomes.Location = new Point(127, 93);
            cmbHomes.Name = "cmbHomes";
            cmbHomes.Size = new Size(200, 33);
            cmbHomes.TabIndex = 0;
            cmbHomes.BackColor = Color.LightSkyBlue;

            // ComboBox Services
            cmbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(127, 157);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(200, 33);
            cmbServices.TabIndex = 1;
            cmbServices.BackColor = Color.LightSkyBlue;

            // TextBox Home Name
            txtHomeName.Location = new Point(127, 215);
            txtHomeName.Name = "txtHomeName";
            txtHomeName.Size = new Size(200, 31);
            txtHomeName.TabIndex = 2;
            txtHomeName.BackColor = Color.LightGoldenrodYellow;

            // TextBox Service Price
            txtServicePrice.Location = new Point(127, 273);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(200, 31);
            txtServicePrice.TabIndex = 3;
            txtServicePrice.BackColor = Color.LightGoldenrodYellow;

            // TextBox New Service Name
            txtNewServiceName.Location = new Point(127, 339);
            txtNewServiceName.Name = "txtNewServiceName";
            txtNewServiceName.Size = new Size(200, 31);
            txtNewServiceName.TabIndex = 4;
            txtNewServiceName.BackColor = Color.LightGoldenrodYellow;

            // Button Create Home
            btnCreateHome.Location = new Point(357, 93);
            btnCreateHome.Name = "btnCreateHome";
            btnCreateHome.Size = new Size(282, 30);
            btnCreateHome.TabIndex = 5;
            btnCreateHome.Text = "Sukurti namą";
            btnCreateHome.UseVisualStyleBackColor = true;
            btnCreateHome.BackColor = Color.LightGreen;
            btnCreateHome.Click += btnCreateHome_Click;

            // Button Delete Home
            btnDeleteHome.Location = new Point(357, 133);
            btnDeleteHome.Name = "btnDeleteHome";
            btnDeleteHome.Size = new Size(282, 30);
            btnDeleteHome.TabIndex = 6;
            btnDeleteHome.Text = "Pašalinti namą";
            btnDeleteHome.UseVisualStyleBackColor = true;
            btnDeleteHome.BackColor = Color.LightCoral;
            btnDeleteHome.Click += btnDeleteHome_Click_1;

            // Button Create Service
            btnCreateService.Location = new Point(357, 173);
            btnCreateService.Name = "btnCreateService";
            btnCreateService.Size = new Size(282, 30);
            btnCreateService.TabIndex = 7;
            btnCreateService.Text = "Sukurti paslaugą";
            btnCreateService.UseVisualStyleBackColor = true;
            btnCreateService.BackColor = Color.LightGreen;
            btnCreateService.Click += btnCreateService_Click_1;

            // Button Delete Service
            btnDeleteService.Location = new Point(357, 213);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(282, 30);
            btnDeleteService.TabIndex = 8;
            btnDeleteService.Text = "Pašalinti paslaugą";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.BackColor = Color.LightCoral;
            btnDeleteService.Click += btnDeleteService_Click_1;

            // Button Assign Service to Home
            btnAssignServiceToHome.Location = new Point(357, 253);
            btnAssignServiceToHome.Name = "btnAssignServiceToHome";
            btnAssignServiceToHome.Size = new Size(282, 30);
            btnAssignServiceToHome.TabIndex = 9;
            btnAssignServiceToHome.Text = "Priskirti paslaugą namui";
            btnAssignServiceToHome.UseVisualStyleBackColor = true;
            btnAssignServiceToHome.BackColor = Color.LightGreen;
            btnAssignServiceToHome.Click += btnAssignServiceToHome_Click;

            // Button Remove Service from Home
            btnRemoveServiceFromHome.Location = new Point(357, 293);
            btnRemoveServiceFromHome.Name = "btnRemoveServiceFromHome";
            btnRemoveServiceFromHome.Size = new Size(282, 30);
            btnRemoveServiceFromHome.TabIndex = 10;
            btnRemoveServiceFromHome.Text = "Pašalinti paslaugą iš namo";
            btnRemoveServiceFromHome.UseVisualStyleBackColor = true;
            btnRemoveServiceFromHome.BackColor = Color.LightCoral;
            btnRemoveServiceFromHome.Click += btnRemoveServiceFromHome_Click;

            // Button Update Price
            btnUpdatePrice.Location = new Point(357, 333);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(282, 30);
            btnUpdatePrice.TabIndex = 11;
            btnUpdatePrice.Text = "Pakeisti kainą";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            btnUpdatePrice.BackColor = Color.LightYellow;
            btnUpdatePrice.Click += btnUpdatePrice_Click;

            // Button Back
            btnBack.Location = new Point(357, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(282, 30);
            btnBack.TabIndex = 12;
            btnBack.Text = "Grįžti";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.BackColor = Color.LightGray;
            btnBack.Click += btnBack_Click;

            // Labels (Add color)
            lblHomeName.AutoSize = true;
            lblHomeName.Location = new Point(127, 65);
            lblHomeName.Name = "lblHomeName";
            lblHomeName.Size = new Size(170, 25);
            lblHomeName.TabIndex = 13;
            lblHomeName.Text = "Namo pavadinimas:";
            lblHomeName.ForeColor = Color.DarkBlue;

            lblHomes.AutoSize = true;
            lblHomes.Location = new Point(127, 65);
            lblHomes.Name = "lblHomes";
            lblHomes.Size = new Size(71, 25);
            lblHomes.TabIndex = 14;
            lblHomes.Text = "Namas:";
            lblHomes.ForeColor = Color.DarkBlue;

            lblServices.AutoSize = true;
            lblServices.Location = new Point(127, 129);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(85, 25);
            lblServices.TabIndex = 15;
            lblServices.Text = "Paslauga:";
            lblServices.ForeColor = Color.DarkBlue;

            lblServicePrice.AutoSize = true;
            lblServicePrice.Location = new Point(127, 245);
            lblServicePrice.Name = "lblServicePrice";
            lblServicePrice.Size = new Size(58, 25);
            lblServicePrice.TabIndex = 16;
            lblServicePrice.Text = "Kaina:";
            lblServicePrice.ForeColor = Color.DarkBlue;

            lblNewServiceName.AutoSize = true;
            lblNewServiceName.Location = new Point(127, 311);
            lblNewServiceName.Name = "lblNewServiceName";
            lblNewServiceName.Size = new Size(200, 25);
            lblNewServiceName.TabIndex = 17;
            lblNewServiceName.Text = "Paslaugos pavadinimas:";
            lblNewServiceName.ForeColor = Color.DarkBlue;

            label1.AutoSize = true;
            label1.Location = new Point(127, 187);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 18;
            label1.Text = "Namas:";
            label1.ForeColor = Color.DarkBlue;

            ClientSize = new Size(691, 519);
            Controls.Add(label1);
            Controls.Add(cmbHomes);
            Controls.Add(cmbServices);
            Controls.Add(txtHomeName);
            Controls.Add(txtServicePrice);
            Controls.Add(txtNewServiceName);
            Controls.Add(btnCreateHome);
            Controls.Add(btnDeleteHome);
            Controls.Add(btnCreateService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnAssignServiceToHome);
            Controls.Add(btnRemoveServiceFromHome);
            Controls.Add(btnUpdatePrice);
            Controls.Add(btnBack);
            Controls.Add(lblHomeName);
            Controls.Add(lblHomes);
            Controls.Add(lblServices);
            Controls.Add(lblServicePrice);
            Controls.Add(lblNewServiceName);
            Name = "ManageHomesForm";
            Text = "Redaguoti namus ir paslaugas";
            Load += ManageHomesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
