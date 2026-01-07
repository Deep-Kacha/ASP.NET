<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <!-- Tailwind CSS CDN -->
    <script src="https://cdn.tailwindcss.com"></script>
</head>
<body class="min-h-screen bg-gradient-to-br from-indigo-500 to-purple-600 flex items-center justify-center">

    <form id="form1" runat="server" class="w-full max-w-md bg-white rounded-xl shadow-xl p-8 space-y-6">

        <!-- Title -->
        <h1 class="text-3xl font-bold text-center text-gray-800">
            Login Page
        </h1>

        <!-- Username -->
        <div>
            <asp:Label ID="lblUser" runat="server" Text="Username"
                CssClass="block text-sm font-semibold text-gray-700 mb-1">
            </asp:Label>

            <asp:TextBox ID="txtUser" runat="server"
                CssClass="w-full px-4 py-2 border rounded-lg focus:ring-2 focus:ring-indigo-500 focus:outline-none"
                placeholder="Enter username">
            </asp:TextBox>
        </div>

        <!-- Password -->
        <div>
            <asp:Label ID="lblPass" runat="server" Text="Password"
                CssClass="block text-sm font-semibold text-gray-700 mb-1">
            </asp:Label>

            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"
                CssClass="w-full px-4 py-2 border rounded-lg focus:ring-2 focus:ring-indigo-500 focus:outline-none"
                placeholder="Enter password">
            </asp:TextBox>
        </div>

        <!-- Button -->
        <asp:Button ID="btnSubmit" runat="server"
            Text="Login"
            OnClick="btnSubmit_Click"
            CssClass="w-full bg-indigo-600 text-white py-2 rounded-lg font-semibold hover:bg-indigo-700 transition duration-300">
        </asp:Button>

        <!-- Message -->
        <asp:Label ID="lblMsg" runat="server"
            CssClass="block text-center text-sm text-red-600">
        </asp:Label>

    </form>

</body>
</html>
