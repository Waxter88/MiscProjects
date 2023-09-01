<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emma.aspx.cs" Inherits="PROG1210_A3_Web.Emma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Search by Customer...&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            First Name:
            <asp:TextBox ID="txtCustFirstName" runat="server" OnTextChanged="txtCustFirstName_TextChanged"></asp:TextBox>
            <br />
            Last Name:
            <asp:TextBox ID="txtCustLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSearchCustomer" runat="server" OnClick="btnSearchCustomer_Click" Text="Search" />
            <br />
            <br />
            Search Customer by Employee...<br />
            First Name:
            <asp:TextBox ID="txtEmpFirstName" runat="server"></asp:TextBox>
            <br />
            Last Name:
            <asp:TextBox ID="txtEmpLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSearchEmployee" runat="server" Text="Search" OnClick="btnSearchEmployee_Click" />
            <br />
            <asp:Label ID="lblRecordCount" runat="server"></asp:Label>
            <br />
            Search Results:<br />
            <asp:ListBox ID="listRecipts" runat="server" Width="305px"></asp:ListBox>
            <asp:Button ID="btnSelectCustomer" runat="server" OnClick="btnSelectCustomer_Click" Text="Select Customer" />
            <asp:Table ID="tblCustomerInfo" runat="server" GridLines="Both">
            </asp:Table>
        </div>
    </form>
</body>
</html>
