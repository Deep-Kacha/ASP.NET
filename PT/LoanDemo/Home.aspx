<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoanDemo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align="center"> HDFC Lons - Next Step To Dream </h1>
            <br />
            <hr />
            Logged in: <asp:Label ID="lblUser" runat="server" Text="Logged in user"></asp:Label>&nbsp;&nbsp;
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click"/>
            <h2 align="center"> Welcome to the place to fullfill your dreams for the family and social needs.</h2>
            <br />
            <br />
            <hr />
            <h2> Contact Us </h2>
            <h2>HDFC Loan Systems</h2>
            <h2>Mumbai, Maharashtr, India</h2>
        </div>
    </form>
</body>
</html>
