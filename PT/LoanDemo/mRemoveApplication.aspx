<%@ Page Title="" Language="C#" MasterPageFile="~/LoanMaster.Master" AutoEventWireup="true" CodeBehind="mRemoveApplication.aspx.cs" Inherits="LoanDemo.mRemoveApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <br />
    <asp:Label ID="Label1" runat="server" Text="DISCARD LOAN APPLICATION" style="font-weight: 700"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<table>
    <tr>
        <td>Saving Account No: </td>
        <td>
            <asp:TextBox ID="txtsavingaccount" runat="server"></asp:TextBox>&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Get Loan Details" Width="150px" />
            <br />
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
                <asp:ListItem>Select</asp:ListItem>
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
                <asp:ListItem>Select</asp:ListItem>
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
            <asp:TextBox ID="txtCurrentAddress" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Loan Remarks : </td>
        <td>
            <asp:TextBox ID="txtRemarks" runat="server"></asp:TextBox>
        </td>
    </tr>

</table>
<br />
<asp:Button ID="btnsubmit" runat="server" Text="Remove Application" />&nbsp;<br />
<asp:Label ID="lblsubmit" runat="server" Text="Record Remove sucessfully" ForeColor="Green"></asp:Label>
</asp:Content>
