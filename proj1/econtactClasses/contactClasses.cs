using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1.econtactClasses
{
    internal class contactClasses
    {
        // Get setter properties
        // Data carrier of application
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconstring = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        
        // selecting data from database
        public DataTable Select()
        {
            /// step1 : database connection
            MySqlConnection conn = new MySqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                // step2: writting sql query
                string sql = "SELECT * FROM details";
                // create cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {


            }
            finally { 
                conn.Close();
            }
            return dt;
        }
    
        // Insert daata into database

        public bool Insert(contactClasses c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;

            // step3: connect to database
            MySqlConnection conn = new MySqlConnection(myconstring);
            try
            {
                // step2: writting sql query to insert data
                string sql = "INSERT INTO details(First_Name,Last_Name,Contact_No,Address,Gender) VALUES (@First_Name,@Last_Name,@Contact_No,@Address,@Gender)";
                // create cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // create parameter to add data
                cmd.Parameters.AddWithValue("@First_Name", c.FirstName);
                cmd.Parameters.AddWithValue("@Last_Name", c.LastName);
                cmd.Parameters.AddWithValue("@Contact_No", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                // if the query runs successfully then value of rowas will be greater than zero else its value will be0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }
            return isSuccess;   
        }

        //method to update data in database from our application

        public bool Update(contactClasses c) { 
            bool isSuccess = false;
            MySqlConnection conn = new MySqlConnection(myconstring);
            return isSuccess;

            try
            {
                // mysql to update data in my databse
                string sql = "UPDATE details SET First_Name = @First_Name,Last_Name = @Last_Name, Contact_No = @Contact_No, Address = @Address,Gender = @Gender WHERE Contact_ID = @Contact_ID";
                MySqlCommand cmd = new MySqlCommand( sql, conn);
                // create parameters to add value
                cmd.Parameters.AddWithValue("@First_Name", c.FirstName);
                cmd.Parameters.AddWithValue("@Last_Name", c.LastName);
                cmd.Parameters.AddWithValue("@Contact_No", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Contact_ID", c.ContactID);

                //open database connection
                int rows = cmd.ExecuteNonQuery();

                // if the query runs successfully the the value of rows will be greater than 0  else it will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close ();
            }
            return isSuccess;
        }

        // method to delete data from database
        public bool Delete(contactClasses c)
        {
            // create a default return value and set its value to false
            bool isSuccess = false;

            //create sql data
            MySqlConnection conn = new MySqlConnection(myconstring);
            try
            {
                string sql = "DELETE FROM details WHERE Contacat_ID = @Contact_ID";
                
                // sql command
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Contact_ID", c.ContactID);
                
                // open connection
                conn.Open ();

                int rows = cmd.ExecuteNonQuery();

                // if the query run successfully then the value of rows is greate than 0 else its value is 0
                if(rows > 0)
                {
                    isSuccess &= true;
                }
                else
                {
                    isSuccess |= false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close ();
            }

            return isSuccess;
        }

    }
}
