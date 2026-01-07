using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP.NET\\BD\\Proj-3\\App_Data\\UserDB.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select username, password from Login where Username=@username and Password=@password", con);
        cmd.Parameters.AddWithValue("@username", txtUser.Text);
        cmd.Parameters.AddWithValue("@password", txtPass.Text);
        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            // Successful login
            Session["Username"] = txtUser.Text;
            HttpCookie cookie = new HttpCookie("usercookie");
            cookie.Value = txtUser.Text;
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("wel-come.aspx");
            //Response.Redirect("StateManagemant.aspx");

        }
        else
        {
            // Invalid credentials
            lblMsg.Text = "Invalid username or password.";
        }
    }
}