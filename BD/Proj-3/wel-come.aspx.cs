using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wel_come : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            if (Request.Cookies["usercookie"] != null)
            {
                lblCookie.Text = "Wel-Come, " + Request.Cookies["usercookie"].Value;
            }
            else
            {
                lblCookie.Text = "Cookie not found.";
            }
        }
    }
}