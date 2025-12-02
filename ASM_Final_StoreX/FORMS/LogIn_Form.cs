using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ASM_Final_StoreX.DB_Helper;


namespace ASM_Final_StoreX.FORMS
{
    public partial class LogIn_Form : Form
    {
        dataHelper dbh = new dataHelper();
        public LogIn_Form()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;   // LOG IN
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                string role = dbh.CheckLogin(userName, password);
                if (role == null)
                {
                    MessageBox.Show("incorrect account or password");
                    return;
                }
                MessageBox.Show("Login successful");
                DashBoard_Form form = new DashBoard_Form(role);
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error"+ ex.Message);   
            }
        }
        // Exit the program
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogIn_Form_Enter(object sender, EventArgs e)
        {
            //btnLogin_Click(sender,e);
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                string role = dbh.CheckLogin(userName, password);
                if (role == null)
                {
                    MessageBox.Show("incorrect account or password");
                    return;
                }
                MessageBox.Show("Login successful");
                DashBoard_Form form = new DashBoard_Form(role);
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
        }

       
    }
}
