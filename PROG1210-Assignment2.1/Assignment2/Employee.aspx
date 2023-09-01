<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Assignment2.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="DepartmentName" DataValueField="DepartmentID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.EmployeeDatasetTableAdapters.SportDepartmentTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_DepartmentID" Type="Int64" />
                <asp:Parameter Name="Original_DepartmentName" Type="String" />
                <asp:Parameter Name="Original_DepartmentManagerID" Type="Int64" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="DepartmentName" Type="String" />
                <asp:Parameter Name="DepartmentManagerID" Type="Int64" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="DepartmentName" Type="String" />
                <asp:Parameter Name="DepartmentManagerID" Type="Int64" />
                <asp:Parameter Name="Original_DepartmentID" Type="Int64" />
                <asp:Parameter Name="Original_DepartmentName" Type="String" />
                <asp:Parameter Name="Original_DepartmentManagerID" Type="Int64" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="fullName" DataValueField="EmployeeID" Width="221px" AutoPostBack="True"></asp:ListBox>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.EmployeeDatasetTableAdapters.SportEmployeeEmpNameAdapter">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Param1" PropertyName="SelectedValue" Type="Int64" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.EmployeeDatasetTableAdapters.SportOrderTableAdapter">
            <SelectParameters>
                <asp:ControlParameter ControlID="ListBox1" Name="Param1" PropertyName="SelectedValue" Type="Int64" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" CellSpacing="5" DataKeyNames="OrderID" DataSourceID="ObjectDataSource3" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="OrderID" InsertVisible="False" ReadOnly="True" SortExpression="OrderID" />
                <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
                <asp:BoundField DataField="OrderNetTotal" HeaderText="OrderNetTotal" SortExpression="OrderNetTotal" />
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" InsertVisible="False" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CustomerFullName" HeaderText="CustomerFullName" ReadOnly="True" SortExpression="CustomerFullName" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Home" Value="Home"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
</body>
</html>
