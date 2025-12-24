using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MathOperation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ClearButton_Click(object sender, EventArgs e)
    {
        txt1.Text = "";
        txt2.Text = "";
        ResultLabel.Text = "";
    }

    protected void AddButton_Click(object sender, EventArgs e)
    {
        int Num1 = Convert.ToInt32(txt1.Text);
        int Num2 = Convert.ToInt32(txt2.Text);
        int r = Num1 + Num2;
        ResultLabel.Text = r.ToString();
    }

    protected void SubtractButton_Click(object sender, EventArgs e)
    {
        int Num1 = Convert.ToInt32(txt1.Text);
        int Num2 = Convert.ToInt32(txt2.Text);
        int r = Num1 - Num2;
        ResultLabel.Text = r.ToString();
    }

    protected void MultiplyButton_Click(object sender, EventArgs e)
    {
        int Num1 = Convert.ToInt32(txt1.Text);
        int Num2 = Convert.ToInt32(txt2.Text);
        int r = Num1 * Num2;
        ResultLabel.Text = r.ToString();
    }

    protected void DivideButton_Click(object sender, EventArgs e)
    {
        int Num1 = Convert.ToInt32(txt1.Text);
        int Num2 = Convert.ToInt32(txt2.Text);
        int r = Num1 / Num2;
        ResultLabel.Text = r.ToString();
    }
}
