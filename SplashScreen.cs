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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        Timer MyTimer = new Timer();
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            MyTimer.Interval = (3000); 
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
            MyTimer.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
