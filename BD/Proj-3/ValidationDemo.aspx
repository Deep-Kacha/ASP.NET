<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationDemo.aspx.cs" Inherits="ValidationDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <strong>Validation Dontrol Demo<br />
            </strong>
        </div>

        <p>
            <strong>1) Required Field Validator</strong>
        </p>
        <p>
            Name :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Name Is Required" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </p>
        <p>
            <strong>2) Range Validator</strong>
        </p>
        <p>
            Age :
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Age Must Be Between 18 to 40" ForeColor="Red" MaximumValue="40" MinimumValue="18" Type="Integer" SetFocusOnError="True"></asp:RangeValidator>
        &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAge" ErrorMessage="Enter Age" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <strong>3)Regular Expression Validator</strong>
        </p>
        <p>
            Email :
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is not in proper format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </p>
        <p>
            <strong>4)Compare Validator</strong>
        </p>
        <p>
            Password :
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="Enter Password Compolsary" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </p>
        <p>
            Confirm Password :
            <asp:TextBox ID="txtConfPass" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtPass" ControlToValidate="txtConfPass" ErrorMessage="Password Does Not Matching" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
        </p>
        <p>
            <strong>5) Custom Validator</strong>
        </p>
        <p>
            Enter Even Number :&nbsp;
            <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
            &nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtNum" ErrorMessage="Number Must Be Even" ForeColor="Red">*</asp:CustomValidator>
        </p>
        <p>
            &nbsp;
        
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </p>

    </form>
</body>
</html>
