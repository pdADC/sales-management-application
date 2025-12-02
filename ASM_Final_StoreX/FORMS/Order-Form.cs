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
    public partial class Order_Form : Form
    {
        dataHelper dbh = new dataHelper();
        public Order_Form()
        {
            InitializeComponent();
            GetEmployee();
        }

        private void Order_Form_Load(object sender, EventArgs e)
        {
            string query = @"select o.OrderID,o.CustomerName,e.EmployeeName,o.OrderDate,o.TotalAmount,o.Status
                            from Orders o					
                            join Employee e on o.EmployeeID=e.EmployeeID
                            where o.IsDeleted =1";
            DataTable data = dbh.GetData(query);
            dgvOrder.DataSource = data;
        }
        public void reLoad()
        {
            string query = @"select o.OrderID,o.CustomerName,e.EmployeeName,o.OrderDate,o.TotalAmount,o.Status
                            from Orders o					
                            join Employee e on o.EmployeeID=e.EmployeeID where o.IsDeleted =1";
            dgvOrder.DataSource = dbh.GetData(query);
        }
        private void clear()
        {
            txtOrderID.Text = "";
            txtCustomerName.Text = "";
            cbEmployeeName.Text = "";
            txtTotal_amount.Text = "";
            cbStatus.Text = string.Empty;
        }
        private void GetEmployee()
        {
            string query = "select * from Employee";
            DataTable data = dbh.GetData(query);
            cbEmployeeName.DataSource = data;
            cbEmployeeName.DisplayMember = "EmployeeName";
            cbEmployeeName.ValueMember = "EmployeeID";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = @"select o.OrderID,o.CustomerName,e.EmployeeName,o.OrderDate,o.TotalAmount,o.Status
                            from Orders o					
                            join Employee e on o.EmployeeID=e.EmployeeID
                            where OrderID=@OrderID and o.IsDeleted =1";
            SqlParameter[] parameters =
            {
                new SqlParameter("@OrderID",txtOrderID.Text)
            };
            DataTable data = dbh.GetData(query, parameters);
            dgvOrder.DataSource = data;
            clear();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("This Order could not be found");
                reLoad();
                clear();
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //// if user clicks on header then skip
            DataGridViewRow row = dgvOrder.Rows[e.RowIndex]; // get the data row that the user just selected
            try
            {
                txtOrderID.Text = row.Cells["OrderID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                cbEmployeeName.Text = row.Cells["EmployeeName"].Value.ToString();
                txtTotal_amount.Text = row.Cells["TotalAmount"].Value.ToString();
                cbStatus.Text=row.Cells["status"].Value.ToString();
                dateTimeOrder.Value = (DateTime)row.Cells["OrderDate"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // STEP 1: Check that the data cells are not blank
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter complete Order information!");
                return; // Stop the function, do not let it run anymore
            }
            try
            {
                // create query
                txtOrderID.Text = string.Empty;
                string query = @"insert into Orders (CustomerName,EmployeeID,OrderDate,TotalAmount,Status)
                                    values (@CustomerName,
	                                       (select EmployeeID from Employee where EmployeeName=@EmployeeName),
	                                       @date,
	                                       @TotalAmount,
	                                       @Status)";
                SqlParameter[] parameters =
                  {
                                //new SqlParameter("@OrderID",txtOrderID.Text),
                                new SqlParameter("@CustomerName",txtCustomerName.Text),
                                new SqlParameter("@EmployeeName",cbEmployeeName.Text),
                                new SqlParameter("@date",dateTimeOrder.Value),
                                new SqlParameter("@TotalAmount",txtTotal_amount.Text),
                                new SqlParameter("@Status",cbStatus.Text)
                       };
                // call executeNonQuery() function in DBH
                int result = dbh.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("successfully added new Order");
                    // reload dgv
                    clear();
                    reLoad();
                }
                else
                {
                    MessageBox.Show("adding new Order failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dateTimeOrder.Value > DateTime.Now.Date)
            {
                MessageBox.Show("The selected date cannot be greater than the current date!", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string query = @"update Orders 
                                set CustomerName =@CustomerName,
	                                EmployeeID=(select EmployeeID from Employee where EmployeeName=@EmployeeName),
	                                OrderDate=@date,
	                                TotalAmount=@TotalAmount,
	                                Status=@Status
                                where OrderID=@OrderID";
                SqlParameter[] parameters =
                {
                new SqlParameter("@OrderID",txtOrderID.Text),
                new SqlParameter("@CustomerName",txtCustomerName.Text),
                new SqlParameter("@EmployeeName",cbEmployeeName.Text),
                new SqlParameter("@date",dateTimeOrder.Value),
                new SqlParameter("@TotalAmount",txtTotal_amount.Text),
                new SqlParameter("@Status",cbStatus.Text),
            };
                int result = dbh.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("updated successfully");
                    clear();
                    reLoad();
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
            DialogResult r = MessageBox.Show("Are you sure you want to delete this Order?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                DeleteOrder(txtOrderID.Text);
                reLoad();
            }
        }
        private void DeleteOrder(string id)
        {
            string query = "update Orders set IsDeleted =0 where OrderID =@OrderID";
            SqlParameter[] parameters = { new SqlParameter("@OrderID", id) };
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
        private void cbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
