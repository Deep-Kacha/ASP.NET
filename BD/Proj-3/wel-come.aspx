<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wel-come.aspx.cs" Inherits="wel_come" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>

    <!-- Tailwind CSS CDN -->
    <script src="https://cdn.tailwindcss.com"></script>
</head>
<body class="min-h-screen bg-gradient-to-br from-green-400 to-blue-500 flex items-center justify-center">

    <form id="form1" runat="server" class="w-full max-w-lg bg-white rounded-xl shadow-xl p-10 text-center space-y-6">

        <!-- Heading -->
        <h1 class="text-4xl font-bold text-gray-800">
            Welcome 🎉
        </h1>

        <!-- User / Cookie Label -->
        <asp:Label ID="lblCookie" runat="server"
            CssClass="block text-lg font-medium text-gray-600">
        </asp:Label>

        <!-- Optional Button (example: logout) -->
        <!--
        <asp:Button ID="btnLogout" runat="server" Text="Logout"
            CssClass="bg-red-500 text-white px-6 py-2 rounded-lg hover:bg-red-600 transition" />
        -->

    </form>

</body>
</html>
