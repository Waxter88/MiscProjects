<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="PROG1210___Assignment_1_Web_App.Roles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="rolesDropDown" runat="server" AutoPostBack="True" DataSourceID="Role" DataTextField="RoleDescription" DataValueField="ID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="Role" runat="server" SelectMethod="GetAllRoles" TypeName="PROG1210.Role">
            <SelectParameters>
                <asp:Parameter Direction="Output" Name="status" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <p>
        <asp:TextBox ID="txtPersonnel" runat="server" AutoPostBack="True" Height="162px" TextMode="MultiLine"></asp:TextBox>
        </p>
    </form>
</body>
</html>
