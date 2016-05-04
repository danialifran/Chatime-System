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
            listViewDisplay.Columns.Add("User ID.", 100);
            listViewDisplay.Columns.Add("Name", 160);
            listViewDisplay.Columns.Add("Type", 90);
            listViewDisplay.Columns.Add("Username", 100);
            listViewDisplay.Columns.Add("Password", 160);

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
    }
}
