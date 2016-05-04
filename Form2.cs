using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project___Chatime
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            // Create connection SQL Server 2012 
            SqlConnection conn = new SqlConnection(@"Data Source =(LocalDB)\v11.0; 
                            AttachDbFileName = |DataDirectory|ChatimeDB.mdf; 
                            Integrated Security=true;");

            conn.Open();
            string checklogin = "select count(*) from users where login='" + txtUsername.Text + "'";
            SqlCommand com = new SqlCommand(checklogin, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkpassword = "select password from users where login='" + txtUsername.Text + "'";
                SqlCommand passCom = new SqlCommand(checkpassword, conn);
                string password = passCom.ExecuteScalar().ToString().Replace(" ","");

                if(password == txtPassword.Text)
                {
                    string name = txtUsername.Text;
                    frmCashier frmCashier = new frmCashier(name);
                    frmCashier.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid input or username not been registerd");
            }

            //String username, password;
            //int id;

            //username = txtUsername.Text;
            //password = txtPassword.Text;

            //if(username == "danial" && password == "1234")
            //{
            //    id = 5213142;
            //    frmCashier frmCashier = new frmCashier(username,id);
            //    frmCashier.Show();
            //    this.Hide();
            //}
            //else if (username == "Karim" && password == "qwe123")
            //{
            //    id = 52213150;
            //    frmCashier frmCashier = new frmCashier(username, id);
            //    frmCashier.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username or Password");
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
