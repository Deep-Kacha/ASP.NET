<%@ Page Title="" Language="C#" MasterPageFile="~/LoanMaster.Master" AutoEventWireup="true" CodeBehind="mViewApplication.aspx.cs" Inherits="LoanDemo.mViewApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvApplications" runat="server"
    AutoGenerateColumns="False"
    DataSourceID="SqlDataSource1"
    BorderWidth="1px"
    GridLines="Both" Height="185px">

    <Columns>
        <asp:BoundField DataField="LoanNo" HeaderText="LoanNo" />
        <asp:BoundField DataField="AccountNo" HeaderText="AccountNo" />
        <asp:BoundField DataField="ActHolderName" HeaderText="ActHolderName" />
        <asp:BoundField DataField="Profession" HeaderText="Profession" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="ContactNo" HeaderText="ContactNo" />
        <asp:BoundField DataField="LoanCategory" HeaderText="LoanCategory" />
        <asp:BoundField DataField="LoanType" HeaderText="LoanType" />
        <asp:BoundField DataField="IssueDate" HeaderText="IssueDate" />
        <asp:BoundField DataField="Amount" HeaderText="Amount" />
        <asp:BoundField DataField="CurrentAddress" HeaderText="CurrentAddress" />
    </Columns>

</asp:GridView>

</asp:Content>
