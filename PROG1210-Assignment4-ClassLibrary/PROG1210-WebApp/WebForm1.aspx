<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PROG1210_WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            height: 20px;
            width: 115px;
        }
        .auto-style5 {
            width: 115px;
        }
        .auto-style6 {
            height: 20px;
            width: 122px;
        }
        .auto-style7 {
            width: 122px;
        }
        .auto-style8 {
            height: 20px;
            width: 157px;
        }
        .auto-style9 {
            width: 157px;
        }
        .auto-style10 {
            height: 20px;
            width: 158px;
        }
        .auto-style11 {
            width: 158px;
        }
        .auto-style12 {
            height: 20px;
            width: 144px;
        }
        .auto-style13 {
            width: 144px;
        }
    </style>
</head>
<body style="height: 617px">
    <form id="form1" runat="server">
        <div id="lblTitle">
            Select a Sales Employee:</div>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="fullName" DataValueField="id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment4_ClassLibrary.EmmasDatasetTableAdapters.SalesEmployeeTableAdapter"></asp:ObjectDataSource>
        <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyField="id" DataSourceID="ObjectDataSource2" ForeColor="Black">
            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <ItemTemplate>
                <br />
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style2"></td>
                        <td class="auto-style3"><strong>#</strong></td>
                        <td class="auto-style6"><strong>Name</strong></td>
                        <td class="auto-style8"><strong>Phone</strong></td>
                        <td class="auto-style10"><strong>Order</strong></td>
                        <td class="auto-style12"><strong>Date</strong></td>
                        <td class="auto-style2"><strong>Paid</strong></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select" />
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                        </td>
                        <td class="auto-style7">
                            <asp:Label ID="custFirstLabel" runat="server" Text='<%# Eval("custFirst") %>' />
                            &nbsp;<asp:Label ID="custLastLabel" runat="server" Text='<%# Eval("custLast") %>' />
                        </td>
                        <td class="auto-style9">
                            <asp:Label ID="custPhoneLabel" runat="server" Text='<%# Eval("custPhone") %>' />
                        </td>
                        <td class="auto-style11">
                            <asp:Label ID="ordNumberLabel" runat="server" Text='<%# Eval("ordNumber") %>' />
                        </td>
                        <td class="auto-style13">
                            <asp:Label ID="ordDateLabel" runat="server" Text='<%# Eval("ordDate") %>' />
                        </td>
                        <td>
                            <asp:Label ID="ordPaidLabel" runat="server" Text='<%# Eval("ordPaid") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style7">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style13">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:DataList>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment4_ClassLibrary.EmmasDatasetTableAdapters.customerTableAdapter">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="empID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
    </form>
</body>
</html>
