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
using ASM_Final_StoreX.DB_Helper;

namespace ASM_Final_StoreX.FORMS
{
    public partial class Customer_Form : Form
    {
        dataHelper dbh = new dataHelper();
        public Customer_Form()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }
        private void DeleteCustomer(string id)
        {
            string query = "update Customer set IsDeleted =0 where CustomerID =@CustomerID";
            SqlParameter[] parameters = { new SqlParameter("@CustomerID", id) };
            int rows = dbh.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }
        private void Customer_Form_Load(object sender, EventArgs e)
        {
            string query = "select CustomerID,CustomerName,Address,Phone from Customer where IsDeleted =1";
            DataTable data = dbh.GetData(query);
            dgvCustomer.DataSource = data;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex]; // get the data row that user just selected
                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "select CustomerID,CustomerName,Address,Phone from Customer where IsDeleted =1 and CustomerID=@CustomerID";
            SqlParameter[] parameter = { new SqlParameter("@CustomerID", txtCustomerID.Text) };
            DataTable data = dbh.GetData(query,parameter);
            dgvCustomer.DataSource = data;
            clear();
            if (data.Rows.Count <1 ) {
                MessageBox.Show("This customer was not found");
                dgvCustomer.DataSource=dbh.GetData("select CustomerID,CustomerName,Address,Phone from Customer where IsDeleted =1");
                clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text)||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter complete Customer information!");
                return;
            }
            try
            {
                    // create query
                    string query = @"insert into Customer (CustomerName,Address,Phone) values (@CustomerName,@Address,@Phone)";
                    SqlParameter[] parameters =
                      {
                                new SqlParameter("@CustomerName",txtCustomerName.Text),
                                new SqlParameter("@Address",txtAddress.Text),
                                new SqlParameter("@Phone",txtPhone.Text)
                       };
                    // call executeNonQuery() function in DBH
                    int result = dbh.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        MessageBox.Show("successfully added new Customer");
                        // reload dgv
                        clear();
                        dgvCustomer.DataSource = dbh.GetData("select CustomerID,CustomerName,Address,Phone from Customer where IsDeleted =1");
                    }
                    else
                    {
                        MessageBox.Show("adding new Customer failed");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"update Customer set CustomerName= @CustomerName,
					 Address =@Address,
					 Phone = @Phone
                     where CustomerID=@CustomerID";
                SqlParameter[] parameters =
                {
                new SqlParameter("@CustomerID",txtCustomerID.Text),
                new SqlParameter("@CustomerName",txtCustomerName.Text),
                new SqlParameter("@Address",txtAddress.Text),
                new SqlParameter("@Phone",txtPhone.Text),
            };
                int result = dbh.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("updated successfully");
                    clear();
                    dgvCustomer.DataSource = dbh.GetData("select CustomerID,CustomerName,Address,Phone from Customer where IsDeleted =1");
                }
                else
                {
                    MessageBox.Show("update failed");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this Customer?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                DeleteCustomer(txtCustomerID.Text);
                dgvCustomer.DataSource = dbh.GetData("select CustomerID,CustomerName,Address,Phone from Customer where IsDeleted =1");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
