<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="EmmasWebApp.LoginSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 186px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Welcome "></asp:Label>
            <asp:LoginName ID="LoginName" runat="server" />
            (<asp:LoginStatus ID="LoginStatus" runat="server" LogoutAction="Redirect" LogoutPageUrl="~/default.aspx" />)
            <strong>
            <br />
            <br />
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <DynamicItemTemplate>
                    <%# Eval("Text") %>
                </DynamicItemTemplate>
                <Items>
                    <asp:MenuItem NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Customers.aspx" Text="Customers" Value="Customers"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Inventory.aspx" Text="Inventory" Value="Inventory"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Orders.aspx" Text="Orders" Value="Orders"></asp:MenuItem>
                </Items>
            </asp:Menu>
            </strong>
        </div>
    </form>
            <strong>
        <p>
            PROG1210 Final Project - By: Jackson Pipe</p>
            </strong>
            </body>
</html>
