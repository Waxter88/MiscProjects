<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Assignment2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="PROG1210 Assignment 2"></asp:Label>
        </div>
        <asp:Menu ID="Menu1" runat="server" StaticSubMenuIndent="16px">
            <Items>
                <asp:MenuItem NavigateUrl="~/Employee.aspx" Text="Employee" Value="Employee"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Inventory.aspx" Text="Inventory" Value="Inventory"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Customer.aspx" Text="Customer" Value="Customer"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Lookup.aspx" Text="Lookup" Value="Lookup"></asp:MenuItem>
            </Items>
            <StaticSelectedStyle HorizontalPadding="25px" />
        </asp:Menu>
    </form>
</body>
</html>
