using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanDemo
{
    public partial class mUpdateApplication : Page
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=D:\ASP.NET\PT\LoanDemo\App_Data\LoanApp.mdf;
              Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblsubmit.Visible = false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT AccountHolderName, LoanCategory, LoanType,
                             LoanIssueDate, LoanAmount, CurrentAddress, LoanRemarks
                      FROM LoanApplication
                      WHERE SavingAccountNo = @SavingAccountNo", con);

                cmd.Parameters.AddWithValue("@SavingAccountNo", txtsavingaccount.Text.Trim());

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtaccholdername.Text = dr["AccountHolderName"].ToString();
                    catagoryDropDownList.SelectedValue = dr["LoanCategory"].ToString();
                    typeDropDownList.SelectedValue = dr["LoanType"].ToString();
                    txtdate.Text = Convert.ToDateTime(dr["LoanIssueDate"]).ToString("yyyy-MM-dd");
                    txtamount.Text = dr["LoanAmount"].ToString();
                    txtCurrentAddress.Text = dr["CurrentAddress"].ToString();
                    txtRemarks.Text = dr["LoanRemarks"].ToString();

                    lblsubmit.Visible = false;
                }
                else
                {
                    ClearForm();
                    lblsubmit.Text = "No record found for this account number.";
                    lblsubmit.ForeColor = System.Drawing.Color.Red;
                    lblsubmit.Visible = true;
                }

                dr.Close();
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE LoanApplication SET LoanCategory = @LoanCategory, LoanType = @LoanType, LoanIssueDate = @LoanIssueDate, LoanAmount = @LoanAmount, CurrentAddress = @CurrentAddress, LoanRemarks = @LoanRemarks WHERE SavingAccountNo = @SavingAccountNo", con);

                cmd.Parameters.AddWithValue("@LoanCategory", catagoryDropDownList.SelectedValue);
                cmd.Parameters.AddWithValue("@LoanType", typeDropDownList.SelectedValue);
                cmd.Parameters.AddWithValue("@LoanIssueDate", Convert.ToDateTime(txtdate.Text));
                cmd.Parameters.AddWithValue("@LoanAmount", Convert.ToDecimal(txtamount.Text));
                cmd.Parameters.AddWithValue("@CurrentAddress", txtCurrentAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@LoanRemarks", txtRemarks.Text.Trim());
                cmd.Parameters.AddWithValue("@SavingAccountNo", txtsavingaccount.Text.Trim());

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    lblsubmit.Text = "Record Updated Successfully";
                    lblsubmit.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblsubmit.Text = "Update failed. Record not found.";
                    lblsubmit.ForeColor = System.Drawing.Color.Red;
                }

                lblsubmit.Visible = true;
            }
        }

        private void ClearForm()
        {
            txtaccholdername.Text = "";
            catagoryDropDownList.SelectedIndex = 0;
            typeDropDownList.SelectedIndex = 0;
            txtdate.Text = "";
            txtamount.Text = "";
            txtCurrentAddress.Text = "";
            txtRemarks.Text = "";
        }
    }
}