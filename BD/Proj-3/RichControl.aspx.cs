using System;
using System.IO;

public partial class RichControl : System.Web.UI.Page
{
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "Selected date is : " +
            Calendar1.SelectedDate.ToString("dd-MM-yyyy");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string files = FileUpload1.FileName;
        string path = Server.MapPath("Upload/"+files);
        FileUpload1.SaveAs(path);
        Label2.Text="File Uploaded Successfully";
    }
}
