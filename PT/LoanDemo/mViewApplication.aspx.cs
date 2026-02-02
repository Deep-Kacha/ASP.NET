using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace LoanDemo
{
    public partial class mViewAllApplication : Page
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=D:\ASP.NET\PT\LoanDemo\App_Data\LoanApp.mdf;
              Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadApplications();
            }
        }

        private void LoadApplications()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT SavingAccountNo, AccountHolderName, LoanCategory,
                             LoanType, LoanIssueDate, LoanAmount,
                             CurrentAddress, LoanRemarks
                      FROM LoanApplication", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    gvApplications.DataSource = dt;
                    gvApplications.DataBind();
                }
                else
                {
                    lblMessage.Text = "No Loan Applications Found.";
                }
            }
        }
    }
}
