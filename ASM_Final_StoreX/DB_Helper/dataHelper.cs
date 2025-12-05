using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ASM_Final_StoreX.DB_Helper
{
    public class dataHelper
    {
        // Connection string to SQL
        private static string ConnString = "Data Source=DESKTOP-NQHAGK3\\SQLEXPRESS;Initial Catalog=StoreX;Integrated Security=True;Encrypt=False";

        //Function 1 GetDATA - get data and fill it into DataTable
        public DataTable GetData(string query, SqlParameter[] parameters = null, bool isStoredProcedure = false )
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (isStoredProcedure)
                            cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("data error" + ex.Message);
            }
            return dataTable;
        }
        // Function 2: ExecuteNonQuery - Execute INSERT/UPDATE/DELETE
        // return the number of rows affected
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteNonQuery error" + ex.Message);
            }
            return rowsAffected;
        }
        // Function 3: ExecuteScalar - get a single value (eg: Count, SUM, ID just INSERT)
        // return object (need to cast to desired type)
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        result = cmd.ExecuteScalar();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteScalar error" + ex.Message);
            }
            return result;

        }
        // 4) PASSWORD HASH FUNCTION
        public byte[] HashPassword(string password)
        {
            // create SHA256 hash object
            using (SHA256 sha = SHA256.Create())     // use using to automatically release the object
            {
                // convert string -> byte[] array according to UTF8 standard
                byte[] inputbyte = Encoding.UTF8.GetBytes(password);

                // call ComputeHash function to hash the byte array just converted into a 32 bytes byte array
                return sha.ComputeHash(inputbyte);
            }
        }
        // 5) CHECKLOGIN FUNCTION - CHECK LOGIN
        public string CheckLogin(string userName, string password)
        {
            string query = "select  Role from Employee where UserName=@UserName and PasswordHash=@PasswordHash";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserName", userName),
                //new SqlParameter("@PasswordHash",HashPassword(password))
                new SqlParameter("@PasswordHash",HashPassword(password))
            };
            object result = ExecuteScalar(query, parameters);
            if (result == null)
            {
                return null;   // login failed, wrong account or password
            }
            else
            {
                return result.ToString();
            }
        }
    }
}
