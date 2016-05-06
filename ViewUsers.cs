using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project___Chatime
{
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Create connection SQL Server 2012 
            SqlConnection conn = new SqlConnection(@"Data Source =(LocalDB)\v11.0; 
                            AttachDbFileName = |DataDirectory|ChatimeDB.mdf; 
                            Integrated Security=true;");

            string viewusers = @"Select user_id, user_name, user_type, login, password
                         from users";

            SqlCommand cmd = new SqlCommand(viewusers, conn);

            //Managing our ListView
            listViewDisplay.View = View.Details;
            listViewDisplay.GridLines = true;
            listViewDisplay.Clear();
            listViewDisplay.Columns.Add("No.", 30);
            listViewDisplay.Columns.Add("User ID.", 250);
            listViewDisplay.Columns.Add("Name", 250);
            listViewDisplay.Columns.Add("Type", 90);
            listViewDisplay.Columns.Add("Username", 200);
            listViewDisplay.Columns.Add("Password", 280);

            try
            {
                this.Text = "View Chatime POS-Users";

                //open connection

                conn.Open();

                //Execute query via ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                int count = 1;
                while (rdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = count.ToString();
                    lvi.SubItems.Add(rdr.GetString(0)); //No
                    lvi.SubItems.Add(rdr.GetString(1)); //id
                    lvi.SubItems.Add(rdr.GetString(2)); //name
                    lvi.SubItems.Add(rdr.GetString(3)); //type
                    lvi.SubItems.Add(rdr.GetString(4));//username
                    lvi.SubItems.Add(rdr.GetString(4)); //password
                    listViewDisplay.Items.Add(lvi);
                    count++;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create connection SQL Server 2012 
            SqlConnection conn = new SqlConnection(@"Data Source =(LocalDB)\v11.0; 
                            AttachDbFileName = |DataDirectory|ChatimeDB.mdf; 
                            Integrated Security=true;");

            string viewreports = @"Select * from sales";

            SqlCommand cmd = new SqlCommand(viewreports, conn);

            //Managing our ListView
            listViewDisplay.View = View.Details;
            listViewDisplay.GridLines = true;
            listViewDisplay.Clear();
            listViewDisplay.Columns.Add("Bill.", 30);
            listViewDisplay.Columns.Add("User ID.", 100);
            listViewDisplay.Columns.Add("User Name", 100);
            listViewDisplay.Columns.Add("Product ID", 70);
            listViewDisplay.Columns.Add("Product Name", 100);
            listViewDisplay.Columns.Add("Quantity", 60);
            listViewDisplay.Columns.Add("Size", 40);
            listViewDisplay.Columns.Add("Price (RM)", 80);
            listViewDisplay.Columns.Add("Topping", 50);
            listViewDisplay.Columns.Add("Add-On Price (RM)", 110);
            listViewDisplay.Columns.Add("Tax (RM)", 60);
            listViewDisplay.Columns.Add("Total (RM)", 70);
            listViewDisplay.Columns.Add("Payment (RM)", 80);
            listViewDisplay.Columns.Add("Balance (RM)", 80);
            listViewDisplay.Columns.Add("Date", 70);





            try
            {
                this.Text = "View Sales Report";

                //open connection

                conn.Open();

                //Execute query via ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = (rdr.GetInt32(0).ToString()); //No
                    lvi.SubItems.Add(rdr.GetString(1)); //id
                    lvi.SubItems.Add(rdr.GetString(2)); //name
                    lvi.SubItems.Add(rdr.GetInt32(3).ToString()); //type
                    lvi.SubItems.Add(rdr.GetString(4));//username
                    lvi.SubItems.Add(rdr.GetInt32(5).ToString()); //password
                    lvi.SubItems.Add(rdr.GetString(6)); //No
                    lvi.SubItems.Add(rdr.GetDecimal(7).ToString()); //id
                    lvi.SubItems.Add(rdr.GetString(8)); //name
                    lvi.SubItems.Add(rdr.GetDecimal(9).ToString()); //type
                    lvi.SubItems.Add(rdr.GetDecimal(10).ToString());//username
                    lvi.SubItems.Add(rdr.GetDecimal(11).ToString()); //password
                    lvi.SubItems.Add(rdr.GetDecimal(12).ToString()); //type
                    lvi.SubItems.Add(rdr.GetDecimal(13).ToString());//username
                    lvi.SubItems.Add(rdr.GetDateTime(14).ToShortDateString()); //DateOfBirth
                    listViewDisplay.Items.Add(lvi);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmViewUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
