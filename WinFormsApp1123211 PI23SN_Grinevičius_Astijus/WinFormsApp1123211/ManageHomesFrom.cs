using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1123211
{
    public partial class ManageHomesForm : Form
    {
        private Database db = new Database();

        public ManageHomesForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void ManageHomesForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            LoadHomes();
            LoadServices();
        }

        private void LoadHomes()
        {
            try
            {
                string query = "SELECT namo_id, namo_pavadinimas FROM namai";
                DataTable homes = db.ExecuteQuery(query);

                cmbHomes.DataSource = homes;
                cmbHomes.DisplayMember = "namo_pavadinimas";
                cmbHomes.ValueMember = "namo_id";
                cmbHomes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida rodant namus: {ex.Message}");
            }
        }

        private void LoadServices()
        {
            try
            {
                string query = "SELECT paslaugos_id, paslaugos_pavadinimas FROM paslaugos";
                DataTable services = db.ExecuteQuery(query);

                cmbServices.DataSource = services;
                cmbServices.DisplayMember = "paslaugos_pavadinimas";
                cmbServices.ValueMember = "paslaugos_id";
                cmbServices.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida rodant paslaugas: {ex.Message}");
            }
        }

        private void lblHomeName_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateHome_Click(object sender, EventArgs e)
        {
            string homeName = txtHomeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(homeName))
            {
                MessageBox.Show("Įveskite namo pavadinimą.");
                return;
            }

            try
            {
                string query = "INSERT INTO namai (namo_pavadinimas) VALUES (@homeName)";
                MySqlParameter[] parameters = { new MySqlParameter("@homeName", homeName) };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Namas sėkmingai sukurtas.");
                    RefreshData();
                    txtHomeName.Clear();
                }
                else
                {
                    MessageBox.Show("Klaida kuriant namą.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida kuriant namą: {ex.Message}");
            }
        }

        private void btnDeleteHome_Click(object sender, EventArgs e)
        {
            if (cmbHomes.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą, kurį norite ištrinti.");
                return;
            }

            int homeId = Convert.ToInt32(cmbHomes.SelectedValue);

            try
            {
                string query = "DELETE FROM namai WHERE namo_id = @homeId";
                MySqlParameter[] parameters = { new MySqlParameter("@homeId", homeId) };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Namas sėkmingai ištrintas.");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Namas sėkmingai ištrintas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Namas sėkmingai ištrintas: {ex.Message}");
            }
        }

        private void btnCreateService_Click(object sender, EventArgs e)
        {
            string serviceName = txtNewServiceName.Text.Trim();

            if (string.IsNullOrWhiteSpace(serviceName))
            {
                MessageBox.Show("Įveskite paslaugos pavadinimą.");
                return;
            }

            try
            {
                string query = "INSERT INTO paslaugos (paslaugos_pavadinimas) VALUES (@serviceName)";
                MySqlParameter[] parameters = { new MySqlParameter("@serviceName", serviceName) };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga sėkmingai sukurta.");
                    RefreshData();
                    txtNewServiceName.Clear();
                }
                else
                {
                    MessageBox.Show("Klaida kuriant paslaugą.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida kuriant paslaugą: {ex.Message}");
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (cmbServices.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite paslaugą, kurią norite ištrinti.");
                return;
            }

            int serviceId = Convert.ToInt32(cmbServices.SelectedValue);

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM kainos WHERE paslaugos_id = @serviceId";
                MySqlParameter[] checkParams = { new MySqlParameter("@serviceId", serviceId) };
                int associationCount = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));

                if (associationCount > 0)
                {
                    MessageBox.Show("Ši paslauga šiam namui jau yra priskirtia. Panaikinkite asociacija su namu.");
                    return;
                }

                string deleteQuery = "DELETE FROM paslaugos WHERE paslaugos_id = @serviceId";
                MySqlParameter[] deleteParams = { new MySqlParameter("@serviceId", serviceId) };

                int rowsAffected = db.ExecuteNonQuery(deleteQuery, deleteParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga sėkmingai panaikinta.");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Klaida naikinant paslaugą.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida naikinant paslaugą: {ex.Message}");
            }
        }

        private void btnAssignServiceToHome_Click(object sender, EventArgs e)
        {
            if (cmbHomes.SelectedValue == null || cmbServices.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą ir paslaugą.");
                return;
            }

            int homeId = Convert.ToInt32(cmbHomes.SelectedValue);
            int serviceId = Convert.ToInt32(cmbServices.SelectedValue);

            if (!decimal.TryParse(txtServicePrice.Text, out decimal price))
            {
                MessageBox.Show("Įveskite teisingą kainą .");
                return;
            }

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM kainos WHERE namo_id = @homeId AND paslaugos_id = @serviceId";
                MySqlParameter[] checkParams = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId)
                };
                int associationCount = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));

                if (associationCount > 0)
                {
                    MessageBox.Show("Ši paslauga jau yra priskirta norimam namui.");
                    return;
                }

                string insertQuery = "INSERT INTO kainos (namo_id, paslaugos_id, kaina) VALUES (@homeId, @serviceId, @price)";
                MySqlParameter[] insertParams = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId),
                    new MySqlParameter("@price", price)
                };

                int rowsAffected = db.ExecuteNonQuery(insertQuery, insertParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga ir jos kaina sėkmingai yra priskirti prie norimo namo.");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Klaida priskirant paslaugą prie namo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida priskiriant paslaugą: {ex.Message}");
            }
        }

        private void btnRemoveServiceFromHome_Click(object sender, EventArgs e)
        {
            if (cmbHomes.SelectedValue == null || cmbServices.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą ir paslaugą.");
                return;
            }

            int homeId = Convert.ToInt32(cmbHomes.SelectedValue);
            int serviceId = Convert.ToInt32(cmbServices.SelectedValue);

            try
            {
                string query = "DELETE FROM kainos WHERE namo_id = @homeId AND paslaugos_id = @serviceId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga sėkmingai pašalinta iš namo.");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Klaida naikinat paslaugą.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida: {ex.Message}");
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (cmbHomes.SelectedValue == null || cmbServices.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą ir paslaugą.");
                return;
            }

            int homeId = Convert.ToInt32(cmbHomes.SelectedValue);
            int serviceId = Convert.ToInt32(cmbServices.SelectedValue);

            if (!decimal.TryParse(txtServicePrice.Text, out decimal newPrice))
            {
                MessageBox.Show("Įveskite teisingą kainą");
                return;
            }

            try
            {
                string query = "UPDATE kainos SET kaina = @newPrice WHERE namo_id = @homeId AND paslaugos_id = @serviceId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@newPrice", newPrice),
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kainą sėkmingai atnaujinta");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Klaida atnaujinant kainą.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida atnaujinant kainą: {ex.Message}");
            }
        }

        private void btnDeleteHome_Click_1(object sender, EventArgs e)
        {
            btnDeleteHome_Click(sender, e);
        }

        private void btnCreateService_Click_1(object sender, EventArgs e)
        {
            btnCreateService_Click(sender, e);
        }

        private void btnDeleteService_Click_1(object sender, EventArgs e)
        {
            btnDeleteService_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHomeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}