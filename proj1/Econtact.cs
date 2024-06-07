using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using proj1.econtactClasses;
using System.Data;

namespace proj1
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        contactClasses c = new contactClasses();

        private ComboBox GetCmbGender()
        {
            return cmbGender;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the value from input field
            c.FirstName = txtFirstname.Text;
            c.LastName = txtLastname.Text;
            c.ContactNo = txtContactno.Text;
            c.Address = txtAddress.Text;
            c.Gender = cmbGender.Text;

            // Insert data into database using the method created contacatclasses
            bool success = c.Insert(c);

            if (success = true)
            {
                MessageBox.Show("New Contact Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add new Contact. Try again");
            }

            // load data on datagrid
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;


            /*
            string connectionString = "Server=localhost;Database=econtact;Uid=root;Pwd=Romibaba123;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM details";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MessageBox.Show(reader["Contact_ID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            */
        }

        private void txtContactId_TextChanged(object sender, EventArgs e)
         {
            // load data on datagrid
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }
        

    }
}
