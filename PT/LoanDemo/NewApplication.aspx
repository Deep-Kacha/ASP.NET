    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewApplication.aspx.cs" Inherits="LoanDemo.NewApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <h1>HDFC Loans - Next Step to Dream</h1>
    <br />
    <hr />
    Logged In :
    <asp:Label ID="lblUser" runat="server" Text="Logged in User"></asp:Label>
    &nbsp;
        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <hr />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="NEW LOAN APPLICATION"></asp:Label><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <table>
        <tr>
            <td>Saving Account No: </td>
            <td>
                <asp:TextBox ID="txtsavingaccount" runat="server"></asp:TextBox><br />
            </td>
        </tr>
        <tr>
            <td>Account Holder Name : </td>
            <td>
                <asp:TextBox ID="txtaccholdername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Loan Category : </td>
            <td>
                <asp:DropDownList ID="catagoryDropDownList" runat="server">
                    <asp:ListItem>Property Loan</asp:ListItem>
                    <asp:ListItem>Fixed Rate Loan</asp:ListItem>
                    <asp:ListItem>Term Loan</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Loan Type : </td>
            <td>
                <asp:DropDownList ID="typeDropDownList" runat="server">
                    <asp:ListItem>Education Loan</asp:ListItem>
                    <asp:ListItem>Home Loan</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Loan Issue Date : </td>
            <td>
                <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Loan Amount : </td>
            <td>
                <asp:TextBox ID="txtamount" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Current Address : </td>
            <td>
                <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea></td>
        </tr>
        <tr>
            <td>Loan Remarks : </td>
            <td>
                <textarea id="TextArea2" cols="20" name="S2" rows="2"></textarea></td>
        </tr>

    </table>
    <br />
    <asp:Button ID="btnsubmit" runat="server" Text="Submit Application" />&nbsp;<br />
    <asp:Label ID="lblsubmit" runat="server" Text="Record Inserted sucessfully"></asp:Label>
</div>
    </form>
</body>
</html>
