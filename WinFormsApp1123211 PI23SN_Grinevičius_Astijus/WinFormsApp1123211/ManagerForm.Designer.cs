using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1123211
{
    public partial class ManagerForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAssignedHome;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblServicePrice;

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
            cmbServices = new ComboBox();
            txtServicePrice = new TextBox();
            btnUpdatePrice = new Button();
            btnExit = new Button();
            lblAssignedHome = new Label();
            lblService = new Label();
            lblServicePrice = new Label();
            SuspendLayout();

            // cmbServices
            cmbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(234, 119);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(200, 33);
            cmbServices.TabIndex = 1;
            cmbServices.Font = new Font("Segoe UI", 12F);
            cmbServices.BackColor = Color.Lavender;

            // txtServicePrice
            txtServicePrice.Location = new Point(234, 159);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(200, 31);
            txtServicePrice.TabIndex = 2;
            txtServicePrice.Font = new Font("Segoe UI", 12F);
            txtServicePrice.BackColor = Color.Lavender;

            // btnUpdatePrice
            btnUpdatePrice.Location = new Point(261, 211);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(150, 40);
            btnUpdatePrice.TabIndex = 3;
            btnUpdatePrice.Text = "Keisti kainą";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            btnUpdatePrice.FlatStyle = FlatStyle.Flat;
            btnUpdatePrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdatePrice.BackColor = Color.DeepSkyBlue;
            btnUpdatePrice.ForeColor = Color.White;
            btnUpdatePrice.Click += btnUpdatePrice_Click;

            // btnExit
            btnExit.Location = new Point(261, 261);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Išeiti";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.BackColor = Color.Tomato;
            btnExit.ForeColor = Color.White;
            btnExit.Click += btnExit_Click;

            // lblAssignedHome
            lblAssignedHome.AutoSize = true;
            lblAssignedHome.Location = new Point(54, 79);
            lblAssignedHome.Name = "lblAssignedHome";
            lblAssignedHome.Size = new Size(177, 25);
            lblAssignedHome.TabIndex = 5;
            lblAssignedHome.Text = "Paskirtas namas: XYZ";
            lblAssignedHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAssignedHome.ForeColor = Color.DarkSlateGray;

            // lblService
            lblService.AutoSize = true;
            lblService.Location = new Point(54, 119);
            lblService.Name = "lblService";
            lblService.Size = new Size(85, 25);
            lblService.TabIndex = 6;
            lblService.Text = "Paslauga:";
            lblService.Font = new Font("Segoe UI", 12F);
            lblService.ForeColor = Color.DarkSlateGray;

            // lblServicePrice
            lblServicePrice.AutoSize = true;
            lblServicePrice.Location = new Point(54, 159);
            lblServicePrice.Name = "lblServicePrice";
            lblServicePrice.Size = new Size(58, 25);
            lblServicePrice.TabIndex = 7;
            lblServicePrice.Text = "Kaina:";
            lblServicePrice.Font = new Font("Segoe UI", 12F);
            lblServicePrice.ForeColor = Color.DarkSlateGray;

            // ManagerForm
            ClientSize = new Size(547, 375);
            Controls.Add(lblAssignedHome);
            Controls.Add(cmbServices);
            Controls.Add(lblService);
            Controls.Add(txtServicePrice);
            Controls.Add(lblServicePrice);
            Controls.Add(btnUpdatePrice);
            Controls.Add(btnExit);
            Name = "ManagerForm";
            Text = "Valdyti paslaugas";
            BackColor = Color.LightGray; // Formos fono spalva
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
