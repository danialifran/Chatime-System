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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnAddRegister_Click(object sender, EventArgs e)
        {
            // Create connection SQL Server 2012 
            SqlConnection conn = new SqlConnection(@"Data Source =(LocalDB)\v11.0; 
                            AttachDbFileName = |DataDirectory|ChatimeDB.mdf; 
                            Integrated Security=true;");

            // Creating sql String
            string sqlInsert = " Insert into users Values (" +
                "'" + txtUserId.Text + "', " +
                "'" + txtUserName.Text + "', " +
                "'" + cmbType.Text + "', " +
                "'" + txtLogin.Text + "', " +
                "'" + txtPassword.Text + "')";

            //Create command
            SqlCommand cmd = new SqlCommand(sqlInsert, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                lblStatus.Text = "Status : New student successfully added!";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Exception Details");
            }
            finally
            {
                conn.Close();
            }
                 
        }
    }
}
