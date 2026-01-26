using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace LoanDemo
{
    public partial class mNewApplication : Page
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

        // Fires when Saving Account number changes
        protected void txtsavingaccount_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT AccountHolderName FROM LoanApplication WHERE SavingAccountNo = @SavingAccountNo", con);

                cmd.Parameters.AddWithValue("@SavingAccountNo", txtAccountNo.Text.Trim());

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())      
                {
                    txtAccHolderName.Text = dr["AccountHolderName"].ToString();
                }
                else
                {
                    txtAccHolderName.Text = "";
                }

                dr.Close();
            }
        }


        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM LoanApplication WHERE SavingAccountNo = @SavingAccountNo", con);

                checkCmd.Parameters.AddWithValue("@SavingAccountNo", txtAccountNo.Text.Trim());

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    lblsubmit.Text = "This Saving Account Number already exists. Use Update Application.";
                    lblsubmit.ForeColor = System.Drawing.Color.Red;
                    lblsubmit.Visible = true;
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO LoanApplication
              (SavingAccountNo, AccountHolderName, LoanCategory, LoanType,
               LoanIssueDate, LoanAmount, CurrentAddress, LoanRemarks)
              VALUES
              (@SavingAccountNo, @AccountHolderName, @LoanCategory, @LoanType,
               @LoanIssueDate, @LoanAmount, @CurrentAddress, @LoanRemarks)", con);

                cmd.Parameters.AddWithValue("@SavingAccountNo", txtAccountNo.Text.Trim());
                cmd.Parameters.AddWithValue("@AccountHolderName", txtAccHolderName.Text.Trim());
                cmd.Parameters.AddWithValue("@LoanCategory", ddlLoanCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@LoanType", ddlLoanType.SelectedValue);
                cmd.Parameters.AddWithValue("@LoanIssueDate", Convert.ToDateTime(txtDate.Text));
                cmd.Parameters.AddWithValue("@LoanAmount", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("@CurrentAddress", txtCurrentAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@LoanRemarks", txtRemarks.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            lblsubmit.Text = "Loan Application Submitted Successfully!";
            lblsubmit.ForeColor = System.Drawing.Color.Green;
            lblsubmit.Visible = true;

            ClearForm();
        }


        private void ClearForm()
        {
            txtAccountNo.Text = "";
            txtAccHolderName.Text = "";
            ddlLoanCategory.SelectedIndex = 0;
            ddlLoanType.SelectedIndex = 0;
            txtDate.Text = "";
            txtAmount.Text = "";
            txtCurrentAddress.Text = "";
            txtRemarks.Text = "";
        }
    }
}