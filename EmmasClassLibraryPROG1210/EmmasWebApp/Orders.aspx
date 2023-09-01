<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="EmmasWebApp.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 581px">
    <form id="form1" runat="server">
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
            </strong>
            <br />
        </div>
        <strong>Orders</strong><p>
            Search by Order Number:
            <asp:TextBox ID="txtOrderNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="bttnSearchOrders" runat="server" OnClick="bttnSearchOrders_Click" Text="Search Orders" />
            <asp:Button ID="bttnShowAllOrders" runat="server" OnClick="bttnShowAllOrders_Click" Text="Show All Orders" />
        </p>
        <asp:ListBox ID="searchResults" runat="server" Height="251px" Width="393px"></asp:ListBox>
        <br />
        <asp:Button ID="bttnSelectOrder" runat="server" OnClick="bttnSelectOrder_Click" Text="Select Order" />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="EmmasClassLibraryPROG1210.EmmasDataSetTableAdapters.orderByPOrdNumber">
            <SelectParameters>
                <asp:ControlParameter ControlID="searchResults" DefaultValue="" Name="Param1" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="lblRecordCount" runat="server"></asp:Label>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging" Width="125px">
            <Fields>
                <asp:TemplateField HeaderText="pordNumber" SortExpression="pordNumber">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("pordNumber") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("pordNumber") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("pordNumber") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="pordDateOrdered" HeaderText="pordDateOrdered" SortExpression="pordDateOrdered" />
                <asp:CheckBoxField DataField="pordPaid" HeaderText="pordPaid" SortExpression="pordPaid" />
                <asp:BoundField DataField="empID" HeaderText="empID" SortExpression="empID" />
                <asp:BoundField DataField="custID" HeaderText="custID" SortExpression="custID" />
                <asp:BoundField DataField="custFirst" HeaderText="custFirst" SortExpression="custFirst" />
                <asp:BoundField DataField="custLast" HeaderText="custLast" SortExpression="custLast" />
                <asp:BoundField DataField="empFirst" HeaderText="empFirst" SortExpression="empFirst" />
                <asp:BoundField DataField="empLast" HeaderText="empLast" SortExpression="empLast" />
                <asp:BoundField DataField="inventoryID" HeaderText="inventoryID" SortExpression="inventoryID" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
