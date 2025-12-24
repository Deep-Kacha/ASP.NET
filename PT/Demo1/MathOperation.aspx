<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MathOperation.aspx.cs" Inherits="MathOperation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="No 1: "></asp:Label>&nbsp;
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="No 2: "></asp:Label>&nbsp;
            <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="ResultText" runat="server" Text="Result: "></asp:Label>&nbsp;
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
            <br /><br />

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="AddButton_Click" /> &nbsp;
            <asp:Button ID="btnSub" runat="server" Text="Subtract" OnClick="SubtractButton_Click" /> &nbsp;
            <asp:Button ID="btnMul" runat="server" Text="Multiply" OnClick="MultiplyButton_Click" /> &nbsp;
            <asp:Button ID="btnDiv" runat="server" Text="Divide" OnClick="DivideButton_Click" /> &nbsp;
            <asp:Button ID="btnClr" runat="server" Text="Clear" OnClick="ClearButton_Click" />

        </div>
    </form>
</body>
</html>
