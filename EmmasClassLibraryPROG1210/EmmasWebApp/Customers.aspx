<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="EmmasWebApp.Customers" %>

<!DOCTYPE html>

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
            <asp:Label ID="Label1" runat="server" Height="57px" Text="Customers" Width="346px"></asp:Label>
            </strong>
            <br />
            First Name: <asp:TextBox ID="txtCustFirstName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        Last Name:
        <asp:TextBox ID="txtCustLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="bttnSearchCustomer" runat="server" Height="26px" OnClick="bttnSearchCustomer_Click" Text="Search Customer" />
        <asp:ObjectDataSource ID="CustomersDataSource" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="EmmasClassLibraryPROG1210.EmmasDataSetTableAdapters.customerTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_id" Type="Int32" />
                <asp:Parameter Name="Original_custFirst" Type="String" />
                <asp:Parameter Name="Original_custLast" Type="String" />
                <asp:Parameter Name="Original_custPhone" Type="String" />
                <asp:Parameter Name="Original_custAddress" Type="String" />
                <asp:Parameter Name="Original_custCity" Type="String" />
                <asp:Parameter Name="Original_custPostal" Type="String" />
                <asp:Parameter Name="Original_custEmail" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="custFirst" Type="String" />
                <asp:Parameter Name="custLast" Type="String" />
                <asp:Parameter Name="custPhone" Type="String" />
                <asp:Parameter Name="custAddress" Type="String" />
                <asp:Parameter Name="custCity" Type="String" />
                <asp:Parameter Name="custPostal" Type="String" />
                <asp:Parameter Name="custEmail" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="custFirst" Type="String" />
                <asp:Parameter Name="custLast" Type="String" />
                <asp:Parameter Name="custPhone" Type="String" />
                <asp:Parameter Name="custAddress" Type="String" />
                <asp:Parameter Name="custCity" Type="String" />
                <asp:Parameter Name="custPostal" Type="String" />
                <asp:Parameter Name="custEmail" Type="String" />
                <asp:Parameter Name="Original_id" Type="Int32" />
                <asp:Parameter Name="Original_custFirst" Type="String" />
                <asp:Parameter Name="Original_custLast" Type="String" />
                <asp:Parameter Name="Original_custPhone" Type="String" />
                <asp:Parameter Name="Original_custAddress" Type="String" />
                <asp:Parameter Name="Original_custCity" Type="String" />
                <asp:Parameter Name="Original_custPostal" Type="String" />
                <asp:Parameter Name="Original_custEmail" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        &nbsp;<asp:Button ID="bttnShowAllCustomers" runat="server" OnClick="Button1_Click" Text="Show All Customers" />
        <br />
        <asp:ListBox ID="searchResults" runat="server" Height="175px" Width="451px"></asp:ListBox>
        <br />
        <asp:Button ID="bttnSelectCustomer" runat="server" Text="Select Customer" OnClick="bttnSelectCustomer_Click" />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="EmmasClassLibraryPROG1210.EmmasDataSetTableAdapters.customerByIDTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_id" Type="Int32" />
                <asp:Parameter Name="Original_custFirst" Type="String" />
                <asp:Parameter Name="Original_custLast" Type="String" />
                <asp:Parameter Name="Original_custPhone" Type="String" />
                <asp:Parameter Name="Original_custAddress" Type="String" />
                <asp:Parameter Name="Original_custCity" Type="String" />
                <asp:Parameter Name="Original_custPostal" Type="String" />
                <asp:Parameter Name="Original_custEmail" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="custFirst" Type="String" />
                <asp:Parameter Name="custLast" Type="String" />
                <asp:Parameter Name="custPhone" Type="String" />
                <asp:Parameter Name="custAddress" Type="String" />
                <asp:Parameter Name="custCity" Type="String" />
                <asp:Parameter Name="custPostal" Type="String" />
                <asp:Parameter Name="custEmail" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="searchResults" Name="Param1" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="custFirst" Type="String" />
                <asp:Parameter Name="custLast" Type="String" />
                <asp:Parameter Name="custPhone" Type="String" />
                <asp:Parameter Name="custAddress" Type="String" />
                <asp:Parameter Name="custCity" Type="String" />
                <asp:Parameter Name="custPostal" Type="String" />
                <asp:Parameter Name="custEmail" Type="String" />
                <asp:Parameter Name="Original_id" Type="Int32" />
                <asp:Parameter Name="Original_custFirst" Type="String" />
                <asp:Parameter Name="Original_custLast" Type="String" />
                <asp:Parameter Name="Original_custPhone" Type="String" />
                <asp:Parameter Name="Original_custAddress" Type="String" />
                <asp:Parameter Name="Original_custCity" Type="String" />
                <asp:Parameter Name="Original_custPostal" Type="String" />
                <asp:Parameter Name="Original_custEmail" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="lblRecordCount" runat="server"></asp:Label>
        <asp:DetailsView ID="dvCustomer" runat="server" AutoGenerateRows="False" Height="50px" Width="263px" DataKeyNames="id" DataSourceID="ObjectDataSource1">
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="custFirst" HeaderText="custFirst" SortExpression="custFirst" />
                <asp:BoundField DataField="custLast" HeaderText="custLast" SortExpression="custLast" />
                <asp:BoundField DataField="custPhone" HeaderText="custPhone" SortExpression="custPhone" />
                <asp:BoundField DataField="custAddress" HeaderText="custAddress" SortExpression="custAddress" />
                <asp:BoundField DataField="custCity" HeaderText="custCity" SortExpression="custCity" />
                <asp:BoundField DataField="custPostal" HeaderText="custPostal" SortExpression="custPostal" />
                <asp:BoundField DataField="custEmail" HeaderText="custEmail" SortExpression="custEmail" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
