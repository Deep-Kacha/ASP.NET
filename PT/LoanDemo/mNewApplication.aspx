<%@ Page Title="" Language="C#" MasterPageFile="~/LoanMaster.Master" AutoEventWireup="true" CodeBehind="mNewApplication.aspx.cs" Inherits="LoanDemo.mNewApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 53px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="NEW LOAN APPLICATION" style="font-weight: 700"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<table>
    <tr>
        <td>Saving Account No: </td>
        <td>
            <asp:TextBox ID="txtAccountNo" runat="server" OnTextChanged="txtsavingaccount_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAccountNo" ErrorMessage="Account No is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
        </td>
    </tr>
    <tr>
        <td>Account Holder Name : </td>
        <td>
            <asp:TextBox ID="txtAccHolderName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAccHolderName" ErrorMessage="Holder name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Loan Category : </td>
        <td>
            <asp:DropDownList ID="ddlLoanCategory" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Property Loan</asp:ListItem>
                <asp:ListItem>Fixed Rate Loan</asp:ListItem>
                <asp:ListItem>Term Loan</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Select Loan Category" ForeColor="Red" InitialValue="Select" ControlToValidate="ddlLoanCategory"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Loan Type : </td>
        <td>
            <asp:DropDownList ID="ddlLoanType" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Education Loan</asp:ListItem>
                <asp:ListItem>Home Loan</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlLoanType" ErrorMessage="Select Loan Type" ForeColor="Red" InitialValue="Select"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>Loan Issue Date : </td>
        <td>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDate" ErrorMessage="Issue Date is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
    <td>Loan Amount : </td>
    <td>
        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAmount" ErrorMessage="Amount must be within 50000 to 2000000 Amount is required" ForeColor="Red" MaximumValue="2000000" MinimumValue="50000" Type="Integer"></asp:RangeValidator>
    </td>
</tr>
<tr>
    <td>Current Address : </td>
    <td>
        <asp:TextBox ID="txtCurrentAddress" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCurrentAddress" ErrorMessage="Address is Required" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>Loan Remarks : </td>
    <td>
        <asp:TextBox ID="txtRemarks" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtRemarks" ErrorMessage="Remarks is Required" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>


</table>
<br />
<asp:Button ID="btnsubmit" runat="server" Text="Submit Application" />&nbsp;<br />
<asp:Label ID="lblsubmit" runat="server" Text="Record Inserted sucessfully" ForeColor="Green"></asp:Label>
</asp:Content>
