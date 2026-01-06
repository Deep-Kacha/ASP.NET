<%@ Page Language="C#" AutoEventWireup="true" CodeFile="txtArea.aspx.cs" Inherits="txtArea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Pela aa Bharo" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <p>
            <textarea id="txtArea" cols="20" name="S1" rows="2"></textarea><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Pachi aa Bharo" ForeColor="Red" ></asp:RequiredFieldValidator>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </form>
</body>
</html>
