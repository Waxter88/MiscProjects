<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="EmmasWebApp.Inventory" %>

<!DOCTYPE html>
<configuration>
    <system.web>
        <authorization>
            <deny users="?"/>
        </authorization>
    </system.web>
</configuration>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 625px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <strong>
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
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Height="57px" Text="Inventory" Width="346px"></asp:Label>
            </strong>
            <br />
            Product Name: <asp:TextBox ID="txtInventoryProdName" runat="server"></asp:TextBox>
        </div>
        Product Description:
        <asp:TextBox ID="txtInventoryProdDesc" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search Product" />
        <br />
        <asp:Button ID="bttnShowAllInventory" runat="server" Text="Show All Products" OnClick="bttnShowAllInventory_Click" />
        <br />
        <asp:ListBox ID="searchResults" runat="server" Height="175px" Width="451px"></asp:ListBox>
        <br />
        <asp:Button ID="bttnSelectInventory" runat="server" Text="Select Inventory" OnClick="bttnSelectInventory_Click" />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="EmmasClassLibraryPROG1210.EmmasDataSetTableAdapters.inventoryProductByProdIDAdapter">
            <SelectParameters>
                <asp:ControlParameter ControlID="searchResults" Name="Param1" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="lblRecordCount" runat="server"></asp:Label>
        <asp:DetailsView ID="dvInventory" runat="server" AutoGenerateRows="False" Height="50px" Width="263px" DataKeyNames="id" DataSourceID="ObjectDataSource1">
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="prodName" HeaderText="prodName" SortExpression="prodName" />
                <asp:BoundField DataField="prodDescription" HeaderText="prodDescription" SortExpression="prodDescription" />
                <asp:BoundField DataField="prodBrand" HeaderText="prodBrand" SortExpression="prodBrand" />
                <asp:BoundField DataField="invQuantity" HeaderText="invQuantity" SortExpression="invQuantity" />
                <asp:BoundField DataField="invSize" HeaderText="invSize" SortExpression="invSize" />
                <asp:BoundField DataField="invMeasure" HeaderText="invMeasure" SortExpression="invMeasure" />
                <asp:BoundField DataField="invPrice" HeaderText="invPrice" SortExpression="invPrice" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
