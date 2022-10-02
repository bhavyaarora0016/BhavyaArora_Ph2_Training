<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="webapp1.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="FirstName : "></asp:Label>
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="LastName : "></asp:Label>
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            <p><asp:Label ID="Label3" runat="server" Text="Date of Birth : "></asp:Label>
            <asp:TextBox ID="dob" runat="server" TextMode="DateTime"></asp:TextBox>

            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" EnableTheming="True" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar></p>
            <p>City : <asp:TextBox ID="city" runat="server"></asp:TextBox>
            </p>
            <p>State :
                <asp:TextBox ID="state" runat="server"></asp:TextBox>
            </p>
            
        </div>
        <asp:Button ID="Button1" runat="server" Font-Size="Medium" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
Footer
© 2022 GitHub, Inc.
