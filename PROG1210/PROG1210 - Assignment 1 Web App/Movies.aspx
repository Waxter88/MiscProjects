<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Movies.aspx.cs" Inherits="PROG1210___Assignment_1_Web_App.Movies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="PROG1210" DataTextField="Title" DataValueField="ID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="PROG1210" runat="server" SelectMethod="GetAllMovies" TypeName="PROG1210.Movie">
            <SelectParameters>
                <asp:Parameter Direction="Output" Name="status" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtRating" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
