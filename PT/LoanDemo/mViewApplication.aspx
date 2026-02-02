<%@ Page Title="" Language="C#" MasterPageFile="~/LoanMaster.Master"
    AutoEventWireup="true" CodeBehind="mViewAllApplication.aspx.cs"
    Inherits="LoanDemo.mViewAllApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <asp:Label ID="Label1" runat="server"
        Text="VIEW ALL  LOAN APPLICATIONS"
        Style="font-weight:700"></asp:Label>
    <br /><br />

    <asp:GridView ID="gvApplications" runat="server"
        AutoGenerateColumns="False"
        BorderWidth="1px"
        GridLines="Both"
        Width="100%">

        <Columns>
            <asp:BoundField DataField="SavingAccountNo" HeaderText="Saving Account No" />
            <asp:BoundField DataField="AccountHolderName" HeaderText="Account Holder Name" />
            <asp:BoundField DataField="LoanCategory" HeaderText="Loan Category" />
            <asp:BoundField DataField="LoanType" HeaderText="Loan Type" />
            <asp:BoundField DataField="LoanIssueDate" HeaderText="Issue Date" 
                DataFormatString="{0:dd-MM-yyyy}" />
            <asp:BoundField DataField="LoanAmount" HeaderText="Loan Amount" />
            <asp:BoundField DataField="CurrentAddress" HeaderText="Current Address" />
            <asp:BoundField DataField="LoanRemarks" HeaderText="Remarks" />
        </Columns>

    </asp:GridView>

    <br />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

</asp:Content>
