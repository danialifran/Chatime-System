using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace Mini_Project___Chatime
{

    public partial class frmCashier : Form
    {
        public frmCashier()
        {
            InitializeComponent();
        }
        
        
        public frmCashier(string name)
        {

            InitializeComponent();


            // Create connection SQL Server 2012 
            SqlConnection conn = new SqlConnection(@"Data Source =(LocalDB)\v11.0; 
                            AttachDbFileName = |DataDirectory|ChatimeDB.mdf; 
                            Integrated Security=true;");

            conn.Open();

            string userid = "select user_id from users where login='" + name + "'";
            SqlCommand checkid = new SqlCommand(userid, conn);
            string id = checkid.ExecuteScalar().ToString().Replace(" ", "");

            this.name = name;
            lblCashier.Text = "Casheir : "  + name;
            lblStaffId.Text = "Casheir : " + id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;

            //temperature radio button
            rdbCold.Enabled = false;
            rdbHot.Checked = false;
            rdbHot.Enabled = false;

            //size radio button
            rdbRegular.Enabled = false;
            rdbRegular.Checked = false;
            rdbLarge.Enabled = false;

            //ice radio button
            rdbNon.Enabled = false;
            rdbNon.Checked = false;
            rdbSlightly.Enabled = false;
            rdbHalf.Enabled = false;
            rdbNormal.Enabled = false;
            rdbExtra.Enabled = false;

            //topping check box
            chkPearl.Enabled = false;
            chkAiyu.Enabled = false;
            chkQQ.Enabled = false;
            chkPuding.Enabled = false;
            chkGrass.Enabled = false;
            chkCoconut.Enabled = false;

            chkAloe.Enabled = false;
            chkRainbow.Enabled = false;
            chkCoffee.Enabled = false;
            chkRed.Enabled = false;

            chkStandard.Enabled = false;


            //quantity textbox and button
            txtQuantity.Enabled = false;
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

            //button ok clear new order
            btnOk.Enabled = false;
            btnClear.Enabled = false;
            btnNewOrder.Enabled = false;



        }

        String name = "";
        private void btnMilkTea1_Click(object sender, EventArgs e)
        {
            name = "Pearl Milk Tea";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnMilkTea2_Click(object sender, EventArgs e)
        {
             name = "Grass Jelly Roasted";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
            
        }

        private void btnMilkTea3_Click(object sender, EventArgs e)
        {
             name = "Horlicks Milk Tea";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnMilkTea4_Click(object sender, EventArgs e)
        {
             name = "Earl Grey Pearl";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnMilkTea5_Click(object sender, EventArgs e)
        {
             name = "Brown Rice Green";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnMilkTea6_Click(object sender, EventArgs e)
        {
             name = "Jasmine Green";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnMilkTea7_Click(object sender, EventArgs e)
        {
             name = "Red Bean Pearl";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnMilkTea8_Click(object sender, EventArgs e)
        {
             name = "Chatime Milk Tea";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnMilkTea9_Click(object sender, EventArgs e)
        {
             name = "Roasted Milk Tea";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnMilkTea10_Click(object sender, EventArgs e)
        {
             name = "Nonish Milk Tea";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnCoffee1_Click(object sender, EventArgs e)
        {
             name = "Cham Fusion";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnCoffee2_Click(object sender, EventArgs e)
        {
             name = "Fremium Crush Coffee";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnCoffee3_Click(object sender, EventArgs e)
        {
             name = "Coffee Smoo Tea";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnCoffee4_Click(object sender, EventArgs e)
        {
             name = "Chatime Signature";
           // listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnCoffee5_Click(object sender, EventArgs e)
        {
             name = "Americano";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
            
        }

        private void btnCoffee6_Click(object sender, EventArgs e)
        {
             name = "Cappucino";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
            
        }

        private void btnCoffee7_Click(object sender, EventArgs e)
        {
             name = "Mocha";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
       
        }

        private void btnCoffee8_Click(object sender, EventArgs e)
        {
             name = "Vanilla Latte";
           // listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnCoffee9_Click(object sender, EventArgs e)
        {
             name = "Nonish Coffee";
           // listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnCoffee10_Click(object sender, EventArgs e)
        {
             name = "Caramel Latte";
          //  listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSmooTea1_Click(object sender, EventArgs e)
        {
             name = "Passionfruit Smoo Tea";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSmooTea2_Click(object sender, EventArgs e)
        {
             name = "Mango Smoo Tea";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSmooTea3_Click(object sender, EventArgs e)
        {
             name = "Mango Au Lait";
            //listViewItem.SubItems.Add(name);


            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSmooTea4_Click(object sender, EventArgs e)
        {
             name = "Honeydew Smoo Tea";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSmooTea5_Click(object sender, EventArgs e)
        {
             name = "Peach Smoo Tea";
           // listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSmooTea6_Click(object sender, EventArgs e)
        {
             name = "Strawberry Pudding Au ";
           // listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSmooTea7_Click(object sender, EventArgs e)
        {
             name = "Norish Smoo Tea";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;
        }

        private void btnChoolatea1_Click(object sender, EventArgs e)
        {
             name = "Superior Pure Cocoa";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnChocolatea2_Click(object sender, EventArgs e)
        {
             name = "Hazelnut Chocolate";
           // listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnChocolatea3_Click(object sender, EventArgs e)
        {
             name = "Cocoa Latte";
           // listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnChocolatea4_Click(object sender, EventArgs e)
        {
             name = "Horlicks Cocoa";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnChocolatea5_Click(object sender, EventArgs e)
        {
             name = "Strawberry Chocolate";
           // listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea6.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnChocolatea6_Click(object sender, EventArgs e)
        {
             name = "Cocoa Smoo Tea wiht Oreo Cookies";
            //listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea7.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnChocolatea7_Click(object sender, EventArgs e)
        {
             name = "Caramel Pudding Smoo Tea with Oreo Cookies";
           // listViewItem.SubItems.Add(name);

            //disable milk tea item button
            btnMilkTea1.Enabled = false;
            btnMilkTea2.Enabled = false;
            btnMilkTea3.Enabled = false;
            btnMilkTea4.Enabled = false;
            btnMilkTea5.Enabled = false;
            btnMilkTea6.Enabled = false;
            btnMilkTea7.Enabled = false;
            btnMilkTea8.Enabled = false;
            btnMilkTea9.Enabled = false;
            btnMilkTea10.Enabled = false;

            //disable coffee item button
            btnCoffee1.Enabled = false;
            btnCoffee2.Enabled = false;
            btnCoffee3.Enabled = false;
            btnCoffee4.Enabled = false;
            btnCoffee5.Enabled = false;
            btnCoffee6.Enabled = false;
            btnCoffee7.Enabled = false;
            btnCoffee8.Enabled = false;
            btnCoffee9.Enabled = false;
            btnCoffee10.Enabled = false;

            //disable smoo tea item button
            btnSmooTea1.Enabled = false;
            btnSmooTea2.Enabled = false;
            btnSmooTea3.Enabled = false;
            btnSmooTea4.Enabled = false;
            btnSmooTea5.Enabled = false;
            btnSmooTea6.Enabled = false;
            btnSmooTea7.Enabled = false;

            //disable chocolatea item button
            btnChocolatea1.Enabled = false;
            btnChocolatea2.Enabled = false;
            btnChocolatea3.Enabled = false;
            btnChocolatea4.Enabled = false;
            btnChocolatea5.Enabled = false;
            btnChocolatea6.Enabled = false;

            //temperature radio button
            rdbCold.Enabled = true;
            rdbHot.Enabled = true;

            //size radio button
            rdbRegular.Enabled = true;
            rdbLarge.Enabled = true;

            //ice radio button
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;

            //topping check box
            chkPearl.Enabled = true;
            chkAiyu.Enabled = true;
            chkQQ.Enabled = true;
            chkPuding.Enabled = true;
            chkGrass.Enabled = true;
            chkCoconut.Enabled = true;

            chkAloe.Enabled = true;
            chkRainbow.Enabled = true;
            chkCoffee.Enabled = true;
            chkRed.Enabled = true;

            chkStandard.Enabled = true;


            //quantity textbox and button
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //button ok clear new order
            btnOk.Enabled = true;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
                double payment = double.Parse(txtPay.Text);
                double balance = payment - disgrandtotal;
                lblBalance1.Text = balance.ToString("0.00");
           
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 4;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 3;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear quantity text box
            txtQuantity.Clear();
        }
        
        //global declaration
        double grandtotal;
        double disgrandtotal;
        double puretotal;
        private void btnOk_Click(object sender, EventArgs e)
        {
            double total = 0;
            double size = 0;
            double topping = 0;
            double quantity = 0;

            //check radio button hot and cold
            if (!rdbHot.Checked && !rdbCold.Checked)
            {
                MessageBox.Show("Please select either Hot or Cold");

            }
            else if (rdbCold.Checked) //if radio button cold checked
            {

                //if radio button ice not checked
                if (!rdbNon.Checked && !rdbSlightly.Checked && !rdbHalf.Checked && !rdbNormal.Checked && !rdbExtra.Checked)
                {
                    MessageBox.Show("Please select Ice");
                }
            }

            //if radio button large or regular not checked
            if (!rdbLarge.Checked && !rdbRegular.Checked)
            {
                MessageBox.Show("Please select either Regular or Large");
            }
            //checked topping checkbox
            if (!chkPearl.Checked && !chkAiyu.Checked && !chkQQ.Checked && !chkPuding.Checked && !chkCoconut.Checked && !chkAloe.Checked && !chkRainbow.Checked && !chkGrass.Checked && !chkCoffee.Checked && !chkRed.Checked && !chkStandard.Checked)
            {
                MessageBox.Show("Please select topping");
            }
            else
            {
                if (rdbLarge.Checked)
                {
                    size = 7.50;
                }
                if (rdbRegular.Checked)
                {
                    size = 6.50;
                }

                //topping
                if (chkStandard.Checked)
                {
                    topping = topping + 0.00;
                }
                if (chkPearl.Checked)
                {
                    topping = topping + 1.10;
                }
                if (chkAiyu.Checked)
                {
                    topping = topping + 1.10;
                }
                if (chkQQ.Checked)
                {
                    topping = topping + 1.10;
                }
                if (chkPuding.Checked)
                {
                    topping = topping + 1.10;
                }
                if (chkGrass.Checked)
                {
                    topping = topping + 1.10;
                }
                if (chkCoconut.Checked)
                {
                    topping = topping + 1.10;
                }
                if (chkAloe.Checked)
                {
                    topping = topping + 1.60;
                }
                if (chkRainbow.Checked)
                {
                    topping = topping + 1.60;
                }
                if (chkCoffee.Checked)
                {
                    topping = topping + 1.60;
                }
                if (chkRed.Checked)
                {
                    topping = topping + 1.60;
                }
            }
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Enter Quantity");
            }
            else
            {
                //convert quantity
                quantity = int.Parse(txtQuantity.Text);

                //calculate total and grand total
                total = (size + topping) * quantity;
                grandtotal = (size + topping) * quantity;
                disgrandtotal = disgrandtotal + total;
                puretotal = disgrandtotal;

                //call display function
                displayfunction(quantity, total);
            }


        }

        private void displayfunction(double quantity, double total)
        {
            ListViewItem listViewItem = new ListViewItem();

            String temptotal = total.ToString();
            String tempquantity = quantity.ToString();
            String distotal = grandtotal.ToString();

             //add quantity and total into list view
            listViewItem.SubItems.Add(name);
            listViewItem.SubItems.Add(tempquantity);
            listViewItem.SubItems.Add(temptotal);

            //display item in listview
            listView1.Items.Add(listViewItem);

             btnOk.Enabled = false;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            //clear quantity text box
            txtQuantity.Clear();

            //temperature radio button
            rdbCold.Checked = false;
            rdbHot.Checked = false;

            //size radio button
            rdbRegular.Checked = false;
            rdbLarge.Checked = false;

            //ice radio button
            rdbNon.Checked = false;
            rdbSlightly.Checked = false;
            rdbHalf.Checked = false;
            rdbNormal.Checked = false;
            rdbExtra.Checked = false;

            //topping check box
            chkPearl.Checked = false;
            chkAiyu.Checked = false;
            chkQQ.Checked = false;
            chkPuding.Checked = false;
            chkGrass.Checked = false;
            chkCoconut.Checked = false;

            chkAloe.Checked = false;
            chkRainbow.Checked = false;
            chkCoffee.Checked = false;
            chkRed.Checked = false;

            chkStandard.Checked = false;

            //temperature radio button
            rdbCold.Enabled = false;
            rdbHot.Enabled = false;

            //size radio button
            rdbRegular.Enabled = false;
            rdbLarge.Enabled = false;

            //ice radio button
            rdbNon.Enabled = false;
            rdbSlightly.Enabled = false;
            rdbHalf.Enabled = false;
            rdbNormal.Enabled = false;
            rdbExtra.Enabled = false;

            //topping check box
            chkPearl.Enabled = false;
            chkAiyu.Enabled = false;
            chkQQ.Enabled = false;
            chkPuding.Enabled = false;
            chkGrass.Enabled = false;
            chkCoconut.Enabled = false;

            chkAloe.Enabled = false;
            chkRainbow.Enabled = false;
            chkCoffee.Enabled = false;
            chkRed.Enabled = false;

            chkStandard.Enabled = false;


            //quantity textbox and button
            txtQuantity.Enabled = false;
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

            //button ok clear new order
            btnOk.Enabled = false;
            btnClear.Enabled = false;
            btnNewOrder.Enabled = false;

            //enable milk tea item button
            btnMilkTea1.Enabled = true;
            btnMilkTea2.Enabled = true;
            btnMilkTea3.Enabled = true;
            btnMilkTea4.Enabled = true;
            btnMilkTea5.Enabled = true;
            btnMilkTea6.Enabled = true;
            btnMilkTea7.Enabled = true;
            btnMilkTea8.Enabled = true;
            btnMilkTea9.Enabled = true;
            btnMilkTea10.Enabled = true;

            //enable coffee item button
            btnCoffee1.Enabled = true;
            btnCoffee2.Enabled = true;
            btnCoffee3.Enabled = true;
            btnCoffee4.Enabled = true;
            btnCoffee5.Enabled = true;
            btnCoffee6.Enabled = true;
            btnCoffee7.Enabled = true;
            btnCoffee8.Enabled = true;
            btnCoffee9.Enabled = true;
            btnCoffee10.Enabled = true;

            //enable smoo tea item button
            btnSmooTea1.Enabled = true;
            btnSmooTea2.Enabled = true;
            btnSmooTea3.Enabled = true;
            btnSmooTea4.Enabled = true;
            btnSmooTea5.Enabled = true;
            btnSmooTea6.Enabled = true;
            btnSmooTea7.Enabled = true;

            //enable chocolatea item button
            btnChocolatea1.Enabled = true;
            btnChocolatea2.Enabled = true;
            btnChocolatea3.Enabled = true;
            btnChocolatea4.Enabled = true;
            btnChocolatea5.Enabled = true;
            btnChocolatea6.Enabled = true;
            btnChocolatea7.Enabled = true;
        }

        private void rdbHot_CheckedChanged(object sender, EventArgs e)
        {
            rdbNon.Enabled = false;
            rdbSlightly.Enabled = false;
            rdbHalf.Enabled = false;
            rdbNormal.Enabled = false;
            rdbExtra.Enabled = false;
        }

        private void rdbCold_CheckedChanged(object sender, EventArgs e)
        {
            rdbNon.Enabled = true;
            rdbSlightly.Enabled = true;
            rdbHalf.Enabled = true;
            rdbNormal.Enabled = true;
            rdbExtra.Enabled = true;
        }

        private void chkStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStandard.Checked)
            {
                chkPearl.Enabled = false;
                chkAiyu.Enabled = false;
                chkQQ.Enabled = false;
                chkPuding.Enabled = false;
                chkGrass.Enabled = false;
                chkCoconut.Enabled = false;
                chkAloe.Enabled = false;
                chkRainbow.Enabled = false;
                chkCoffee.Enabled = false;
                chkRed.Enabled = false;
            }
            else
            {
                chkPearl.Enabled = true;
                chkAiyu.Enabled = true;
                chkQQ.Enabled = true;
                chkPuding.Enabled = true;
                chkGrass.Enabled = true;
                chkCoconut.Enabled = true;
                chkAloe.Enabled = true;
                chkRainbow.Enabled = true;
                chkCoffee.Enabled = true;
                chkRed.Enabled = true;
            }
        }

        private void grpTopping_Enter(object sender, EventArgs e)
        {

        }

        public string username { get; set; }

        public int id { get; set; }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEndOrder_Click(object sender, EventArgs e)
        {
            //calculate tax and grand total
            double tax = disgrandtotal * 0.06;
            disgrandtotal = disgrandtotal + tax;

            //display into tax and grand total label
            String thegrandtotal = disgrandtotal.ToString("0.00");
            String distax = tax.ToString("0.00");
            lblTax.Text = "RM" + distax;
            lblGrandTotal.Text = "RM" + thegrandtotal;

            //select first index
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Select();
            }

        }

        //global declaration index and total index
        int index, totalindex;
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                if (listView1.FocusedItem.Index < listView1.Items.Count - 1)
                {
                    index = listView1.FocusedItem.Index;
                    totalindex = index + 1;
                    listView1.Items[totalindex].Selected = true;
                    listView1.Items[totalindex].Focused = true;
                    listView1.Items[index].Selected = false;
                    listView1.Select();

                }
                else if (listView1.FocusedItem.Index >= listView1.Items.Count - 1)
                {
                    MessageBox.Show(Convert.ToString("This is the last Chatime item!"));
                }
            }
            else
            {
                MessageBox.Show(Convert.ToString("Selected Item is not Exist !"));
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                if (listView1.FocusedItem.Index <= 0)
                {

                    MessageBox.Show(Convert.ToString("This is the last Chatime item!"));
                }
                else if (listView1.FocusedItem.Index <= listView1.Items.Count - 1)
                {

                    index = listView1.FocusedItem.Index;
                    totalindex = index - 1;
                    listView1.Items[totalindex].Selected = true;
                    listView1.Items[totalindex].Focused = true;
                    listView1.Items[index].Selected = false;
                    listView1.Select();

                }
            }
            else
            {
                MessageBox.Show(Convert.ToString("Selected Item is not Exist !"));
            }
        }

        private void rdbRegular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //selected index
            index = listView1.FocusedItem.Index;
            
            //retrieve total value from listview
            String minustotal = listView1.Items[index].SubItems[3].Text.ToString();
            double mintotal = double.Parse(minustotal);

            //minus grand total wiht remove total
            puretotal = puretotal - mintotal;
            double tax = puretotal * 0.06;
            puretotal = puretotal + tax;

            //remove selected item
            this.listView1.Items.Remove(listView1.FocusedItem);
            MessageBox.Show(Convert.ToString("Your Chatime item has been deleted !"));

            //focus item
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Select();
            }

            //display into tax and grand total label
            String thegrandtotal = puretotal.ToString("0.00");
            String distax = tax.ToString("0.00");
            lblTax.Text = "RM" + distax;
            lblGrandTotal.Text = "RM" + thegrandtotal;
        }

        private void lblGrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCashier frmCashier = new frmCashier();
            frmCashier.Show();


        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                //Assume the default printer
                PrintDocument print = new PrintDocument();
                //All size are converted from mm to inchs & then multiply by 100.
                print.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
                print.PrintPage += new PrintPageEventHandler(this.print_PrintPage);
                print.Print();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured while printing", ex.ToString());
            }

        }

 
        private void print_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawString(
                " CT233 - Chatime Quill City Mall\r\n LOOB INTEGRATION SND BHD\r\n 10099378-M\r\n GST ID 000475389952\r\n LOT 5-39 5TH FLOOR NO1018\r\n JALAN SULTAN ISMAIL 50250 KL\r\n ---------------------------------------------------",
                new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, 20, 100);
            ev.Graphics.DrawString(
    " \r\n\r\n\r\n\r\n\r\n\r\n TAX INVOICE",
    new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 20, 100);
            ev.Graphics.DrawString(
" \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n Counter: "+ id + " \r\n Bill No: \r\n Date: " + DateTime.Now.ToString() + "\r\n Sales Remarks: \r\n --------------------------------------------------- ",
new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, 20, 100);
            ev.Graphics.DrawString("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n Item Name          Quantity      Price(RM)\r\n --------------------------------------------------- ", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, 20, 100);
          
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViewUsers frmViewUsers = new frmViewUsers();
            frmViewUsers.Show();
        }

      }

    
}
