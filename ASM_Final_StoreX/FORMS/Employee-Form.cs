using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASM_Final_StoreX.DB_Helper;
using System.Data.SqlClient;
using ASM_Final_StoreX.Function_Forms;
using System.Collections;

namespace ASM_Final_StoreX.FORMS
{
    public partial class Employee_Form : Form
    {
        dataHelper db =new dataHelper();

        public Employee_Form()
        {
            InitializeComponent();
        }
        private void Employee_Form_Load(object sender, EventArgs e)
        {
            string query = @"select EmployeeID,EmployeeName,Birth,Role,Salary,UserName from Employee where IsDeleted =1";
            DataTable data = db.GetData(query);
            dgvEmployees.DataSource = data;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("Please enter  EmployeeID !");
                return; // Stop the function, do not let it run anymore
            }
            string query = @"select EmployeeID,EmployeeName,Birth,Role,Salary,UserName from Employee where IsDeleted =1 and EmployeeID=@EmployeeID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeID",txtEmployeeID.Text)
            };
            DataTable data = db.GetData(query, parameters);
            dgvEmployees.DataSource = data;
            clear();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("This employee could not be found");
                dgvEmployees.DataSource = db.GetData("select EmployeeID,EmployeeName,Birth,Role,Salary,UserName from Employee where IsDeleted =1");
                clear();
            }
        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //// if user clicks on header then skip
            DataGridViewRow row = dgvEmployees.Rows[e.RowIndex]; // get the data row that the user just selected
            try
            {
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                txtEmplyeeName.Text = row.Cells["EmployeeName"].Value.ToString();
                dateTimePickerEmployee.Value = Convert.ToDateTime(row.Cells["Birth"].Value);
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                cbRole.Text = row.Cells["Role"].Value.ToString();
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            txtEmployeeID.Text = "";
            txtEmplyeeName.Text = "";
            txtSalary.Text = "";
            txtUserName.Text = "";
            cbRole.Text = string.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // STEP 1: Check that the data cells are not blank
            if (
                string.IsNullOrWhiteSpace(txtEmplyeeName.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(cbRole.Text))
            {
                MessageBox.Show("Please enter complete employee information!");
                return; // Stop the function, do not let it run anymore
            }
            try
            {
                string Qtest = "select count(*) from Employee where UserName = @UserName";
                SqlParameter[] Ptest = { new SqlParameter("@UserName", txtEmployeeID.Text) };
                int count = Convert.ToInt32(db.ExecuteScalar(Qtest, Ptest));
                if (count > 0)
                {
                    DialogResult r = MessageBox.Show("This employee ID already exists", "error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // create query
                    string query =
                        @"insert into Employee (EmployeeName,Birth,Role,Salary,UserName,PasswordHash)
                        values (@EmployeeName,@birth,@RoleName,@Salary,@UserName,@Password)";                  
                    SqlParameter[] parameters =
                      {
                                new SqlParameter("@EmployeeName",txtEmplyeeName.Text),
                                new SqlParameter("@RoleName",cbRole.SelectedItem.ToString().Trim()),
                                new SqlParameter("@birth",dateTimePickerEmployee.Value),
                                new SqlParameter("@Salary",txtSalary.Text),
                                new SqlParameter("@UserName",txtUserName.Text),
                                new SqlParameter("@Password",db.HashPassword(txtPassword.Text))
                       };
                    // call executeNonQuery() function in DBH
                    int result = db.ExecuteNonQuery(query, parameters);
                    if (result > 0)
                    {
                        MessageBox.Show("successfully added new employee");
                        // reload dgv
                        clear();
                        dgvEmployees.DataSource =
                            db.GetData(@"select EmployeeID,EmployeeName,Birth,Role,Salary,UserName from Employee where IsDeleted =1");
                    }
                    else
                    {
                        MessageBox.Show("adding new employee failed");
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
                string query = 
                    @"update Employee set EmployeeName= @EmployeeName,Birth=@birth,Role=@Role,Salary=@Salary,UserName =@UserName
                      where EmployeeID=@EmployeeID and IsDeleted=1";
                SqlParameter[] parameters =
                {
                new SqlParameter("@EmployeeName",txtEmplyeeName.Text),
                new SqlParameter("@Role",cbRole.Text),
                new SqlParameter("@birth",dateTimePickerEmployee.Value),
                new SqlParameter("@Salary",Convert.ToDouble(txtSalary.Text)),
                new SqlParameter("@UserName",txtUserName.Text),
                new SqlParameter("@EmployeeID",txtEmployeeID.Text)
            };
                int result = db.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("updated successfully");
                    clear();
                    dgvEmployees.DataSource = db.GetData(@"select EmployeeID,EmployeeName,Birth,Role,Salary,UserName from Employee where IsDeleted =1");
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
            DialogResult r = MessageBox.Show("Are you sure you want to delete this employee?", "confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                DeleteEmployee(txtEmployeeID.Text);
                dgvEmployees.DataSource =
                    db.GetData(@"select EmployeeID,EmployeeName,Birth,Role,Salary,UserName from Employee where IsDeleted =1");
            }
        }
        private void DeleteEmployee(string id)
        {
            string query = "update EmPloyee set IsDeleted =0 where EmployeeID =@EmployeeID";
            SqlParameter[] parameters = { new SqlParameter("@EmployeeID",id) };
            int rows = db.ExecuteNonQuery(query, parameters);
            if (rows > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }
        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
