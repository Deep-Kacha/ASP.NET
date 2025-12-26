using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx"); // redirect to login if not logged in
            }
            String email = (string)Session["email"]; // retrieve email from session
            lblUser.Text = "Welcome, " + email; // display email on home page
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();      // Clear all session variables
            Session.Abandon();    // End session
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewApplication.aspx"); // move to Home page after login
        }
    }
}