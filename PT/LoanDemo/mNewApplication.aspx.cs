using System;
using System.Web.UI;

namespace LoanDemo
{
    public partial class mNewApplication : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblsubmit.Visible = true;
        }

        protected void txtsavingaccount_TextChanged(object sender, EventArgs e)
        {
            // Example auto-fill (dummy data)
            if (txtAccountNo.Text == "1001")
            {
                txtAccHolderName.Text = "John Doe";
            }
            else
            {
                txtAccHolderName.Text = "";
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearForm()
        {
            txtAccountNo.Text = "";
            txtAccHolderName.Text = "";
            txtDate.Text = "";
            txtAmount.Text = "";
            txtCurrentAddress.Text = "";
            txtRemarks.Text = "";
        }
    }
}
