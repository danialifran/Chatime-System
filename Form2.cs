using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            String username, password;
            int id;

            username = txtUsername.Text;
            password = txtPassword.Text;

            if(username == "danial" && password == "1234")
            {
                id = 5213142;
                frmCashier frmCashier = new frmCashier(username,id);
                frmCashier.Show();
                this.Hide();
            }
            else if (username == "Karim" && password == "qwe123")
            {
                id = 52213150;
                frmCashier frmCashier = new frmCashier(username, id);
                frmCashier.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
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
