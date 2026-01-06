<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StateManagemant.aspx.cs" Inherits="StateManagemant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Statemanagement in ASP.NET</h2>
            <br />
            <strong>1) ViewState :</strong><br />
            <br />
        </div>
        <asp:TextBox ID="txtViewState" runat="server" OnTextChanged="txtViewState_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblViewState" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <br />
        <strong>2) Hiddenfiled Example :</strong><br />
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server"/>
        <br />
        <asp:Button ID="btnHidden" runat="server" OnClick="btnHidden_Click" Text="Store hidden Value" />
        &nbsp;&nbsp;
        <asp:Label ID="lblHidden" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <br />
        <strong>3) Cookie Example :</strong><br />
        <br />
        <asp:TextBox ID="txtCookie" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="btnCrtCookie" runat="server" Text="Create Cookie" OnClick="Button3_Click" />
        &nbsp;
        <asp:Button ID="btnReadCookie" runat="server" Text="Read Cookie" OnClick="btnReadCookie_Click" />
        &nbsp;
        <asp:Label ID="lblCookie" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <br />
        <strong>4) Query String Example :
        <br />
        </strong>
        <br />
        <asp:TextBox ID="txtQuery" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="btnQuery" runat="server" Text="Button" OnClick="Button5_Click" />
        &nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Blue"></asp:Label>
        <br />
    </form>
</body>
</html>
