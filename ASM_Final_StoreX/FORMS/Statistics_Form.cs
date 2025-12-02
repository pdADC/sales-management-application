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
    public partial class Statistics_Form : Form
    {
        dataHelper dbh = new dataHelper();  
        public Statistics_Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private double Total_revenue(double revenue)
        {
            // foreach used to loop through all rows in DataGridView
            foreach (DataGridViewRow row in dgvStatistic.Rows)
            {
                if (row.IsNewRow) continue;  //skip last blank line
                double value = Convert.ToDouble(row.Cells["TotalAmount"].Value);
                revenue += value;
            }
                return revenue;
        }
        private int Order_quantity(int count)
        {
            string query = @"SELECT count(*) OrderID
                            FROM Orders
                            WHERE MONTH(OrderDate) = @month
                              AND YEAR(OrderDate) = @year        
                              AND Day(OrderDate)=@day
                              AND IsDeleted=1";
            SqlParameter[] parameters = { new SqlParameter("@day", dateTimePickerOrderDate.Value.Day),
                                      new SqlParameter("@month",dateTimePickerOrderDate.Value.Month),
                                      new SqlParameter("@year",dateTimePickerOrderDate.Value.Year)};
            count = Convert.ToInt32(dbh.ExecuteScalar(query,parameters));
           return count;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            double revenue=0;
            int quantity = 0;
            // Check that the data cells are not blank
            if (rbtnDay.Checked==false && rbtnMonth.Checked==false)
            {
                MessageBox.Show("Please select the statistics type");
                return; // Stop the function, do not let it run anymore
            }
            try
            {
                if (rbtnMonth.Checked)
                {
                    int month = dateTimePickerOrderDate.Value.Month;
                    int year = dateTimePickerOrderDate.Value.Year;
                    SqlParameter[] parameters =
                      {
                new SqlParameter("@month",month),
                new SqlParameter("@year",year)};
                    DataTable dta = dbh.GetData("monthly_statistics", parameters, true);
                    dgvStatistic.DataSource = dta;
                    txtRevenue.Text = Total_revenue(revenue).ToString();
                    txtTotalOrder.Text=Order_quantity(quantity).ToString();
                }
                else if (rbtnDay.Checked)
                {
                    int day = dateTimePickerOrderDate.Value.Day;
                    int month = dateTimePickerOrderDate.Value.Month;
                    int year = dateTimePickerOrderDate.Value.Year;
                    SqlParameter[] parameters =
                       {new SqlParameter("@day",day),
                    new SqlParameter("@month",month),
                    new SqlParameter("@year",year)};
                    DataTable dt = dbh.GetData("Dayly_statistics", parameters, true);
                    dgvStatistic.DataSource = dt;
                    txtRevenue.Text = Total_revenue(revenue).ToString();
                    txtTotalOrder.Text=Order_quantity(quantity).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
