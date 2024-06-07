using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using proj1.econtactClasses;
using System.Configuration;
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

                // call the method to clear
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new Contact. Try again");
            }

            // load data on datagrid
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            // load data on datagrid
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void txtContactId_TextChanged(object sender, EventArgs e)
        {
            // load data on datagrid
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // method to clear fields

        public void Clear()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtContactno.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            txtContactId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get data from text boxes
            c.ContactID = int.Parse(txtContactId.Text);
            c.FirstName = txtFirstname.Text;
            c.LastName = txtLastname.Text;
            c.ContactNo = txtContactno.Text;
            c.Address = txtAddress.Text;
            c.Gender = cmbGender.Text;

            // update data in database
            bool success = c.Update(c);
            if (success == true)
            {
                // update success
                MessageBox.Show("Contact has been Updated");
                // load data on datagrid
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                // clear textbox
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to  Update Contact");
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get data from Grid view and load it into the  textbox respectively
            // identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtContactId.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtContactno.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get data from textbox
            c.ContactID = Convert.ToInt32(txtContactId.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Contact successfully Deleted");
                // load data on datagrid
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                // clear grid
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete Contact. Try  again");
            }
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the value from textbox
            string keyword = txtSearch.Text;

            MySqlConnection conn = new MySqlConnection(myconnstr);
            MySqlDataAdapter sdn = new MySqlDataAdapter("SELECT * FROM details WHERE First_Name LIKE '%"+keyword+"%' OR Last_Name LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sdn.Fill(dt);
            dgvContactList.DataSource=dt;
        }
    }
}
