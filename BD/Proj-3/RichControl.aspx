<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RichControl.aspx.cs" Inherits="RichControl" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rich Control</title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">

        <strong>1) AdRotator</strong><br />
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile.xml" Height="200px" Width="200px" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile.xml"></asp:XmlDataSource>
        <br />

        <br />
        <br />

        <strong>2) Calendar</strong><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Select a date"></asp:Label><br />
        <asp:Calendar ID="Calendar1" runat="server"
            OnSelectionChanged="Calendar1_SelectionChanged" />

        <br />
        <br />

        <strong>3) File Upload</strong><br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>

    </form>
</body>
</html>
