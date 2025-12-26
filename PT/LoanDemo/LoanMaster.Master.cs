using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanDemo
{
    public partial class LoanMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx"); // redirect to login if not logged in
            }
            String email = (string)Session["email"];
            lblUser.Text = "Welcome, " + email;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();      // Clear all session variables
            Session.Abandon();    // End session
            Response.Redirect("Login.aspx");
        }

        protected void linkBtnHome(object sender, EventArgs e)
        {
            Response.Redirect("mHome.aspx");
        }

        protected void linkBtnNewApplication(object sender, EventArgs e)
        {
            Response.Redirect("mNewApplication.aspx");
        }

        protected void linkBtnUodateApplication(object sender, EventArgs e)
        {
            Response.Redirect("mUpdateApplication.aspx");
        }

        protected void linkBtnRemoveApplication(object sender, EventArgs e)
        {
            Response.Redirect("mRemoveApplication.aspx");
        }

        protected void linkBtnViewAll(object sender, EventArgs e)
        {
            Response.Redirect("mViewAll.aspx");
        }
    }
}