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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ASM_Final_StoreX.FORMS
{
    public partial class OrderDetail_Form : Form
    {
        dataHelper dbh = new dataHelper();
        public OrderDetail_Form()
        {
            InitializeComponent();
        }
        public void GetProduct()
        {
            string query = "select * from Products";
            DataTable data = dbh.GetData(query);
            cbProduct.DataSource = data;
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";
        }
        private void OrderDetail_Form_Load(object sender, EventArgs e)
        {
            GetProduct();
        }
        private void clear()
        {
            cbProduct.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }
        private void reload()
        {
            double sumOrder = 0;
            int count = 0;
            string query = 
                @"select p.ProductName, od.Quantity, od.UnitPrice,od.Quantity * od.UnitPrice AS TotalAmount
                from OrderDetail od
                join Products p on od.ProductID=p.ProductID
                join Orders o on od.OrderID=o.OrderID
                where od.IsDeleted=1 and o.OrderID =1";
            SqlParameter[] parameters =
            {
                new SqlParameter("@OrderID",txtOrderID.Text)
            };
            DataTable data = dbh.GetData(query, parameters);
            dgvOrderDetail.DataSource = data;
            txtTotalOrder.Text = Convert.ToString(Sum_Order(sumOrder));
            txtQuanOfProduct.Text = Convert.ToString(Sum_Product(count));
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            double sumOrder = 0;
            int count = 0;
            string query =
                @"select p.ProductName, od.Quantity, od.UnitPrice,od.Quantity * od.UnitPrice AS TotalAmount
                from OrderDetail od
                join Products p on od.ProductID=p.ProductID
                join Orders o on od.OrderID=o.OrderID
                where od.IsDeleted=1 and o.OrderID =@OrderID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@OrderID",txtOrderID.Text)
            };
            DataTable data = dbh.GetData(query, parameters);
            dgvOrderDetail.DataSource = data;
            txtTotalOrder.Text = Convert.ToString(Sum_Order(sumOrder));
            txtQuanOfProduct.Text = Convert.ToString(Sum_Product(count));
            clear();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("This Order could not be found");
                clear();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // STEP 1: Check that the data cells are not blank
            if (string.IsNullOrWhiteSpace(txtOrderID.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter complete Product information!");
                return; // Stop the function
            }
            try
            {
                string Qtest = "select count(*) from OrderDetail where ProductID = @ProductID and IsDeleted =1";
                SqlParameter[] Ptest = { new SqlParameter("@ProductID",cbProduct.SelectedValue.ToString()) };
                int count = Convert.ToInt32(dbh.ExecuteScalar(Qtest, Ptest));
                if (count > 0)
                {
                    DialogResult r = MessageBox.Show("This product already exists in the invoice, you can change the quantity",
                        "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = 
                        @"insert into OrderDetail (OrderID,ProductID,Quantity,UnitPrice) 
                        values (@OrderID,@ProductID,@Quantity,(select Price from Products where ProductID=@ProductID))";
                    SqlParameter[] parameters =
                      {
                                new SqlParameter("@OrderID",Convert.ToInt32(txtOrderID.Text.Trim())),
                                new SqlParameter("@ProductID",cbProduct.SelectedValue),
                                new SqlParameter("@ProductName",cbProduct.Text),
                                new SqlParameter("@Quantity",txtQuantity.Text)
                       };
                    // call executeNonQuery() function in DBH
                    int result = dbh.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        MessageBox.Show("successfully added new Product");
                        // reload dgv
                        clear();
                        reload();
                    }
                    else
                    {
                        MessageBox.Show("adding new Product failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }
        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvOrderDetail.Rows[e.RowIndex]; // get the data row that the user just selected
            try
            {
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                cbProduct.Text = row.Cells["ProductName"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query =
                    @"update OrderDetail set Quantity=@Quantity,UnitPrice=(select Price from Products where ProductID=@ProductID)
                    where OrderID=@OrderID and ProductID=@ProductID";
                SqlParameter[] parameters =
                {
                new SqlParameter("@ProductID",cbProduct.SelectedValue.ToString()),
                new SqlParameter("@Quantity",txtQuantity.Text),
                new SqlParameter("@OrderID",txtOrderID.Text)
                };
                int result = dbh.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("updated successfully");
                    clear();
                    reload();
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
            DialogResult r = MessageBox.Show("Are you sure you want to delete this Product?",
                "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                DeleteProduct(cbProduct.SelectedValue.ToString());
                reload();
            }
        }
        private void DeleteProduct(string id)
        {
            string query = "update OrderDetail set IsDeleted =0 where ProductID =@ProductID";
            SqlParameter[] parameters = { new SqlParameter("@ProductID", id) };
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
        private double Sum_Order(double sum)
        {
            // foreach used to loop through all rows in DataGridView
            foreach (DataGridViewRow row in dgvOrderDetail.Rows)
            {
                if (row.IsNewRow) continue;  //skip last blank line
                double value = Convert.ToDouble(row.Cells["TotalAmount"].Value);
                sum += value;
            }
            return sum;
        }
        private double Sum_Product(int sum)
        {
            // foreach used to loop through all rows in DataGridView
            foreach (DataGridViewRow row in dgvOrderDetail.Rows)
            {
                if (row.IsNewRow) continue;  //skip last blank line
                int value = Convert.ToInt32(row.Cells["Quantity"].Value);
                sum += value;
            }
            return sum;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
