<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EmmasWebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 457px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Home</strong>
            <br />
                
                 <asp:Label ID="welcome" runat="server" Text="Welcome "></asp:Label>
                 <strong>
                 <asp:LoginName ID="LoginName" runat="server" />
                
            &nbsp;- <asp:LoginStatus ID="LoginStatus" runat="server" LogoutAction="Redirect" LogoutPageUrl="~/default.aspx" /></strong>
                
            <br />
            <br />
            <br />
            
            <asp:Login ID="LoginControl" runat="server" OnAuthenticate="LoginControl_Authenticate" DestinationPageUrl="~/login.aspx" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="271px" Width="452px">
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <TextBoxStyle Font-Size="0.8em" />
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />

            </asp:Login>
            <strong>
            <br />
            </strong><em>Login hint: User: <strong>admin</strong> Pass: <strong>password</strong></em></div>
        <p>
            <strong>PROG1210 Final Project - By: Jackson Pipe</strong></p>
    </form>
</body>
</html>
