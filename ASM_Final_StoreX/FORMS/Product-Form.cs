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
using ClosedXML.Excel;

namespace ASM_Final_StoreX.FORMS
{
    public partial class Product_Form : Form
    {
        dataHelper dbh = new dataHelper();  
        public Product_Form()
        {
            InitializeComponent();
        }
        private void Product_Form_Load(object sender, EventArgs e)
        {
            string query = @"select p.ProductID,p.ProductName,c.CategoryName,s.SupplierName,p.Price,p.Stockquantity
from Products p 
join Category c on p.CategoryID=c.CategoryId
join Supplier s on p.SupplierID=s.SupplierID
where p.IsDeleted =1 ";
            DataTable data = dbh.GetData(query);
            dgvProduct.DataSource = data;
            GetCategory();
            GetSupplier();
        }
        public void reLoad()
        {
            string query = @"select p.ProductID,p.ProductName,c.CategoryName,s.SupplierName,p.Price,p.Stockquantity
from Products p 
join Category c on p.CategoryID=c.CategoryId
join Supplier s on p.SupplierID=s.SupplierID
where p.IsDeleted =1 ";
            dgvProduct.DataSource = dbh.GetData(query);
        }
        private void clear()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtStockquantity.Text = "";
            txtPrice.Text = "";
            cbCategory.Text = string.Empty;
            cbSupplier.Text = string.Empty;
        }
        public void GetCategory()
        {
            string query = "select * from Category";
            DataTable data = dbh.GetData(query);
            cbCategory.DataSource = data;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }

        public void GetSupplier()
        {
            string query = "select * from Supplier";
            DataTable data = dbh.GetData(query);
            cbSupplier.DataSource = data;
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierID";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Please enter ProductID");
                return; // Stop 
            }
            string query = @"select p.ProductName,c.CategoryName,s.SupplierName,p.Price,p.Stockquantity
from Products p 
join Category c on p.CategoryID=c.CategoryId
join Supplier s on p.SupplierID=s.SupplierID
where p.IsDeleted =1 and ProductID=@ProductID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ProductID",txtProductID.Text)
            };
            DataTable data = dbh.GetData(query, parameters);
            dgvProduct.DataSource = data;
            clear();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("This Product could not be found");
                reLoad();
                clear();
            }
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //// if user clicks on header then skip
            DataGridViewRow row = dgvProduct.Rows[e.RowIndex]; // get the data row that the user just selected
            try
            {
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                cbCategory.Text= row.Cells["CategoryName"].Value.ToString();
                cbSupplier.Text = row.Cells["SupplierName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStockquantity.Text = row.Cells["Stockquantity"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // STEP 1: Check that the data cells are not blank
            if (
                string.IsNullOrWhiteSpace(cbCategory.Text)||
                string.IsNullOrWhiteSpace(cbSupplier.Text)||
                string.IsNullOrWhiteSpace(txtPrice.Text)||
                string.IsNullOrWhiteSpace(txtStockquantity.Text))
            {
                MessageBox.Show("Please enter complete Product information!");
                return; // Stop the function, do not let it run anymore
            }
            try
            {
                string Qtest = "select count(*) from Products where ProductName = @ProductName ";
                SqlParameter[] Ptest = { new SqlParameter("@ProductName", txtProductName.Text) };
                int count = Convert.ToInt32(dbh.ExecuteScalar(Qtest, Ptest));
                if (count > 0)
                {
                    DialogResult r = MessageBox.Show("This Product ID already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
                else
                {
                    // create query
                    string query = @"insert into Products (ProductName,CategoryID,SupplierID,Price,Stockquantity) values (@ProductName,@CategoryId,@SupplierID,@Price,@Stockquantity)";
                    SqlParameter[] parameters =
                      {
                                //new SqlParameter("@ProductID",txtProductID.Text),
                                new SqlParameter("@ProductName",txtProductName.Text),
                                new SqlParameter("@CategoryId",cbCategory.SelectedValue.ToString()),
                                new SqlParameter("@SupplierID",cbSupplier.SelectedValue.ToString()),
                                new SqlParameter("@Price",txtPrice.Text),
                                new SqlParameter("@Stockquantity",txtStockquantity.Text)
                       };
                    // call executeNonQuery() function in DBH
                    int result = dbh.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        MessageBox.Show("successfully added new Product");
                        // reload dgv
                        clear();
                        reLoad();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"Update Products set ProductName=@ProductName,
					CategoryID=@CategoryID,
					SupplierID=@SupplierID,
					Price=@Price,
					Stockquantity=@Stockquantity
                   where ProductID=@ProductID";
                SqlParameter[] parameters =
                {
                new SqlParameter("@ProductID",txtProductID.Text),
                new SqlParameter("@ProductName",txtProductName.Text),
                new SqlParameter("@CategoryID",cbCategory.SelectedValue),
                new SqlParameter("@SupplierID",cbSupplier.SelectedValue),               
                new SqlParameter("@Price",txtPrice.Text),
                new SqlParameter("@Stockquantity",txtStockquantity.Text),
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
            DialogResult r = MessageBox.Show("Are you sure you want to delete this Product?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                DeleteProduct(txtProductID.Text);
                reLoad();
            }
        }
        private void DeleteProduct(string id)
        {
            string query = "update Products set IsDeleted =0 where ProductID =@ProductID";
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Export Product Data",
                    FileName = "Product.xlsx"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook =new XLWorkbook())  // Create new Excel workbook (ClosedXML library)
                    {
                        var worksheet = workbook.Worksheets.Add("Product");  // Create a new sheet named "Products"
                                                                             // WRITE DATA
                        for (int i = 0; i < dgvProduct.Rows.Count; i++)   // Loop through each row
                        {
                            for (int j = 0; j < dgvProduct.Columns.Count; j++)   // Loop through each column
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvProduct.Rows[i].Cells[j].Value?.ToString();
                                // Write data to Excel, row + 2 because row 1 is header
                                // Use ?. to avoid error if Cell value is null
                            }
                        }
                        workbook.SaveAs(saveFileDialog.FileName);   // Save Excel file to the path selected by the user
                    }

                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)   
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
