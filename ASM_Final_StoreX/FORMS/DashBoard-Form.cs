using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_Final_StoreX.FORMS
{
    public partial class DashBoard_Form : Form
    {
        private string userRole;
        private Form activeForm;
        public DashBoard_Form(string role)
        {
            InitializeComponent();
            userRole = role;
            applyRole();
        }
        private void openchilForm(Form chilForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm =chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            //Place the child form inside a panel, just like adding a button or label to a panel.
            this.panelDesktop.Controls.Add(chilForm);           
            //BringToFront() makes sure the open child form is on top, not covered by any controls.
            chilForm.BringToFront();      
            chilForm.Show();
        }
        private void applyRole()
        {
            switch (userRole)
            {
                case "Admin":
                    btnFormCustomer.Enabled = true;
                    btnFormOrders.Enabled = true;
                    btnFromEmployee.Enabled = true;
                    btnFormProducts.Enabled = true;
                    btnOrderDetail.Enabled = true;
                    btnLogOut.Enabled = true;
                    btnStatistics.Enabled = true;
                    break;
                case "Staff":
                    btnFormCustomer.Enabled = true;
                    btnFormOrders.Enabled = true;
                    btnFromEmployee.Enabled = false;
                    btnStatistics.Enabled= false;
                    btnFormProducts.Enabled = true;
                    btnOrderDetail.Enabled = true;
                    btnLogOut.Enabled = true;
                    lblUser.Text = "STAFF";
                    break ;
                case "WareHouse":
                    btnFormCustomer.Enabled = false;
                    btnFormOrders.Enabled = false;
                    btnFromEmployee.Enabled = false;
                    btnFormProducts.Enabled = true;
                    btnOrderDetail.Enabled = false;
                    btnStatistics.Enabled=false;
                    btnLogOut.Enabled = true;
                    lblUser.Text = "WAREHOUSE";
                    break;
            }
        }

        private void btnFromEmployee_Click(object sender, EventArgs e)
        {
            openchilForm(new FORMS.Employee_Form());
        }

        private void btnFormCustomer_Click(object sender, EventArgs e)
        {
            openchilForm(new FORMS.Customer_Form());
        }

        private void btnFormProducts_Click(object sender, EventArgs e)
        {
            openchilForm(new FORMS.Product_Form());
        }

        private void btnFormOrders_Click(object sender, EventArgs e)
        {
            openchilForm(new FORMS.Order_Form());
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            openchilForm(new FORMS.OrderDetail_Form());
        }

        private void DashBoard_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogout==false)
            {
                Application.Exit();
            }
        }

        private bool isLogout = false;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Hide();
            LogIn_Form login = new LogIn_Form();
            login.Show();
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            openchilForm(new FORMS.Statistics_Form());
        }
    }

}
