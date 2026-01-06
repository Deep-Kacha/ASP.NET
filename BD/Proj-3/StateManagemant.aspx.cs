using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StateManagemant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtViewState_TextChanged(object sender, EventArgs e)
    {
        int count = 0;

        if (ViewState["Count"] != null)
        {
            count = (int)ViewState["Count"];
        }

        count++;
        ViewState["Count"] = count;
        lblViewState.Text = "View State Count: " + count.ToString();

    }

    protected void btnHidden_Click(object sender, EventArgs e)
    {
        HiddenField1.Value = "56";
        lblHidden.Text = "Hidden Field Value: " + HiddenField1.Value;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

        Response.Cookies["MyCookie"].Value = txtCookie.Text;
        Response.Cookies["MyCookie"].Expires = DateTime.Now.AddMinutes(3);
        lblCookie.Text = "Cookie Set Successfully.";
    }

    protected void btnReadCookie_Click(object sender, EventArgs e)
    {
        if(Request.Cookies["MyCookie"] != null)
        {
            lblCookie.Text = "Cookie Value: " + Request.Cookies["MyCookie"].Value;
        }
        else
        {
            lblCookie.Text = "Cookie not found.";
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("/")
    }
}