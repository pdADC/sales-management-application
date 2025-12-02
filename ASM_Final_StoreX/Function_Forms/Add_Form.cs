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

namespace ASM_Final_StoreX.Function_Forms
{
    public partial class Add_Form : Form
    {
        dataHelper dbh = new dataHelper();
        public string UserNameValue
        {
            get { return txtUserName.Text.Trim(); }
        }

        public string PasswordValue
        {
            get { return txtPassword.Text.Trim(); }
        }

        public string RoleNameValue
        {
            get { return cbRole.Text.Trim(); }
        }
        public Add_Form()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Qtest = "select count(*) from Users where UserName = @UserName";
            SqlParameter[] Ptest = { new SqlParameter("@UserName", txtUserName.Text) };
            int count = Convert.ToInt32(dbh.ExecuteScalar(Qtest, Ptest));
            if (count > 0)
            {
                DialogResult r = MessageBox.Show("This User Name already exists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("Are you sure you want to add this user?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        string query = "insert into Users (UserName,PasswordHash,RoleID)" +
                                       "\r\nvalues (@UserName,@PasswordHash,(select RoleID from Roles where RoleName =@RoleName))";
                        SqlParameter[] parameters =
                        {
                        new SqlParameter("@UserName", txtUserName.Text),
                        new SqlParameter("@PasswordHash",dbh.HashPassword(txtPassword.Text)),
                        new SqlParameter("@RoleName", cbRole.Text)
                    };
                        // gọi hàm thực thi executeNonQuery() trong DBH
                        int result = dbh.ExecuteNonQuery(query, parameters);

                        // thông báo thêm mới thành công 
                        if (result > 0)
                        {
                            MessageBox.Show("new user added successfully");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("adding new user failed");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

              
        }
    }
}
