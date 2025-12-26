using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string email=txtEmail.Text;
            string password = txtPassword.Text;
            Session["email"] = txtEmail.Text; // store email in session
            Session["password"] = txtPassword.Text; // store password in session

            Response.Redirect("mHome.aspx"); // move to Home page after login
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}