<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="webapp1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="User Id : "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Ink Free"></asp:TextBox>
        <br />
        <br />
        Password :
        <asp:TextBox ID="TextBox2" runat="server" ToolTip="Enter Password: "></asp:TextBox>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="109px" ImageUrl="~/Images/50643.jpg" OnClick="ImageButton1_Click" Width="173px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>
