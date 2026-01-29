using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace LoanDemo
{
    public partial class mRemoveApplication : Page
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ASP.NET\PT\LoanDemo\App_Data\LoanApp.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblsubmit.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsavingaccount.Text))
            {
                lblsubmit.Text = "Please enter Saving Account Number.";
                lblsubmit.ForeColor = System.Drawing.Color.Red;
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT AccountHolderName, LoanCategory, LoanType, LoanIssueDate, LoanAmount, CurrentAddress, LoanRemarks FROM LoanApplication WHERE SavingAccountNo = @SavingAccountNo", con);

                cmd.Parameters.AddWithValue("@SavingAccountNo",
                    txtsavingaccount.Text.Trim());

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

                    lblsubmit.Text = "";
                }
                else
                {
                    ClearForm();
                    lblsubmit.Text = "No loan record found.";
                    lblsubmit.ForeColor = System.Drawing.Color.Red;
                }

                dr.Close();
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsavingaccount.Text))
            {
                lblsubmit.Text = "Please enter Saving Account Number.";
                lblsubmit.ForeColor = System.Drawing.Color.Red;
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM LoanApplication WHERE SavingAccountNo = @SavingAccountNo", con);

                cmd.Parameters.AddWithValue("@SavingAccountNo", txtsavingaccount.Text.Trim());

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    lblsubmit.Text = "Record Remove successfully";
                    lblsubmit.ForeColor = System.Drawing.Color.Green;
                    ClearForm();
                }
                else
                {
                    lblsubmit.Text = "No record found to delete.";
                    lblsubmit.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void ClearForm()
        {
            txtsavingaccount.Text = "";
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
