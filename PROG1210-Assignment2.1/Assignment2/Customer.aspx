<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Assignment2.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            height: 260px;
        }
        .auto-style5 {
            width: 258px;
            height: 20px;
        }
        .auto-style6 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="CustomerFirstName" DataValueField="CustomerID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:FormView ID="FormView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="CustomerID" DataSourceID="ObjectDataSource1" GridLines="Horizontal" OnItemDeleted="FormView1_ItemDeleted" Width="393px" OnPageIndexChanging="FormView1_PageIndexChanging">
                <EditItemTemplate>
                    CustomerID:
                    <asp:Label ID="CustomerIDLabel1" runat="server" Text='<%# Eval("CustomerID") %>' />
                    <br />
                    CustomerLastName:
                    <asp:TextBox ID="CustomerLastNameTextBox" runat="server" Text='<%# Bind("CustomerLastName") %>' />
                    <br />
                    CustomerFirstName:
                    <asp:TextBox ID="CustomerFirstNameTextBox" runat="server" Text='<%# Bind("CustomerFirstName") %>' />
                    <br />
                    CustomerMI:
                    <asp:TextBox ID="CustomerMITextBox" runat="server" Text='<%# Bind("CustomerMI") %>' />
                    <br />
                    CustomerAddress:
                    <asp:TextBox ID="CustomerAddressTextBox" runat="server" Text='<%# Bind("CustomerAddress") %>' />
                    <br />
                    CustomerCity:
                    <asp:TextBox ID="CustomerCityTextBox" runat="server" Text='<%# Bind("CustomerCity") %>' />
                    <br />
                    StateAbbreviation:
                    <asp:TextBox ID="StateAbbreviationTextBox" runat="server" Text='<%# Bind("StateAbbreviation") %>' />
                    <br />
                    CustomerZipCode:
                    <asp:TextBox ID="CustomerZipCodeTextBox" runat="server" Text='<%# Bind("CustomerZipCode") %>' />
                    <br />
                    CustomerPhone:
                    <asp:TextBox ID="CustomerPhoneTextBox" runat="server" Text='<%# Bind("CustomerPhone") %>' />
                    <br />
                    CustomerComments:
                    <asp:TextBox ID="CustomerCommentsTextBox" runat="server" Text='<%# Bind("CustomerComments") %>' />
                    <br />
                    CustomerDiscount:
                    <asp:TextBox ID="CustomerDiscountTextBox" runat="server" Text='<%# Bind("CustomerDiscount") %>' />
                    <br />
                    CustomerUsername:
                    <asp:TextBox ID="CustomerUsernameTextBox" runat="server" Text='<%# Bind("CustomerUsername") %>' />
                    <br />
                    CustomerPassword:
                    <asp:TextBox ID="CustomerPasswordTextBox" runat="server" Text='<%# Bind("CustomerPassword") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    CustomerLastName:
                    <asp:TextBox ID="CustomerLastNameTextBox" runat="server" Text='<%# Bind("CustomerLastName") %>' />
                    <br />
                    CustomerFirstName:
                    <asp:TextBox ID="CustomerFirstNameTextBox" runat="server" Text='<%# Bind("CustomerFirstName") %>' />
                    <br />
                    CustomerMI:
                    <asp:TextBox ID="CustomerMITextBox" runat="server" Text='<%# Bind("CustomerMI") %>' />
                    <br />
                    CustomerAddress:
                    <asp:TextBox ID="CustomerAddressTextBox" runat="server" Text='<%# Bind("CustomerAddress") %>' />
                    <br />
                    CustomerCity:
                    <asp:TextBox ID="CustomerCityTextBox" runat="server" Text='<%# Bind("CustomerCity") %>' />
                    <br />
                    StateAbbreviation:
                    <asp:TextBox ID="StateAbbreviationTextBox" runat="server" Text='<%# Bind("StateAbbreviation") %>' />
                    <br />
                    CustomerZipCode:
                    <asp:TextBox ID="CustomerZipCodeTextBox" runat="server" Text='<%# Bind("CustomerZipCode") %>' />
                    <br />
                    CustomerPhone:
                    <asp:TextBox ID="CustomerPhoneTextBox" runat="server" Text='<%# Bind("CustomerPhone") %>' />
                    <br />
                    CustomerComments:
                    <asp:TextBox ID="CustomerCommentsTextBox" runat="server" Text='<%# Bind("CustomerComments") %>' />
                    <br />
                    CustomerDiscount:
                    <asp:TextBox ID="CustomerDiscountTextBox" runat="server" Text='<%# Bind("CustomerDiscount") %>' />
                    <br />
                    CustomerUsername:
                    <asp:TextBox ID="CustomerUsernameTextBox" runat="server" Text='<%# Bind("CustomerUsername") %>' />
                    <br />
                    CustomerPassword:
                    <asp:TextBox ID="CustomerPasswordTextBox" runat="server" Text='<%# Bind("CustomerPassword") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <br />
                    <br />
                    &nbsp;<br />
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style5">CustomerID:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerLastName: </td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerLastNameLabel" runat="server" Text='<%# Bind("CustomerLastName") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerFirstName: </td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerFirstNameLabel" runat="server" Text='<%# Bind("CustomerFirstName") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerMI:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerMILabel" runat="server" Text='<%# Bind("CustomerMI") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerAddress:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerAddressLabel" runat="server" Text='<%# Bind("CustomerAddress") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerCity:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerCityLabel" runat="server" Text='<%# Bind("CustomerCity") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">StateAbbreviation: </td>
                            <td class="auto-style6">
                                <asp:Label ID="StateAbbreviationLabel" runat="server" Text='<%# Bind("StateAbbreviation") %>' />
                            </td>
                            <td class="auto-style6"></td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerZipCode:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerZipCodeLabel" runat="server" Text='<%# Bind("CustomerZipCode") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerPhone:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerPhoneLabel" runat="server" Text='<%# Bind("CustomerPhone") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerComments:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerCommentsLabel" runat="server" Text='<%# Bind("CustomerComments") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerDiscount:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerDiscountLabel" runat="server" Text='<%# Bind("CustomerDiscount") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerUsername:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerUsernameLabel" runat="server" Text='<%# Bind("CustomerUsername") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">CustomerPassword:</td>
                            <td class="auto-style6">
                                <asp:Label ID="CustomerPasswordLabel" runat="server" Text='<%# Bind("CustomerPassword") %>' />
                            </td>
                            <td class="auto-style6">&nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to Delete the record?')" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                </ItemTemplate>
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
            </asp:FormView>
            <asp:Menu ID="Menu1" runat="server">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Home" Value="Home"></asp:MenuItem>
                </Items>
            </asp:Menu>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.SportMotorsDataSetTableAdapters.SportCustomerTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_CustomerID" Type="Int64" />
                    <asp:Parameter Name="Original_CustomerLastName" Type="String" />
                    <asp:Parameter Name="Original_CustomerFirstName" Type="String" />
                    <asp:Parameter Name="Original_CustomerMI" Type="String" />
                    <asp:Parameter Name="Original_CustomerAddress" Type="String" />
                    <asp:Parameter Name="Original_CustomerCity" Type="String" />
                    <asp:Parameter Name="Original_StateAbbreviation" Type="String" />
                    <asp:Parameter Name="Original_CustomerZipCode" Type="String" />
                    <asp:Parameter Name="Original_CustomerPhone" Type="String" />
                    <asp:Parameter Name="Original_CustomerComments" Type="String" />
                    <asp:Parameter Name="Original_CustomerDiscount" Type="Double" />
                    <asp:Parameter Name="Original_CustomerUsername" Type="String" />
                    <asp:Parameter Name="Original_CustomerPassword" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CustomerLastName" Type="String" />
                    <asp:Parameter Name="CustomerFirstName" Type="String" />
                    <asp:Parameter Name="CustomerMI" Type="String" />
                    <asp:Parameter Name="CustomerAddress" Type="String" />
                    <asp:Parameter Name="CustomerCity" Type="String" />
                    <asp:Parameter Name="StateAbbreviation" Type="String" />
                    <asp:Parameter Name="CustomerZipCode" Type="String" />
                    <asp:Parameter Name="CustomerPhone" Type="String" />
                    <asp:Parameter Name="CustomerComments" Type="String" />
                    <asp:Parameter Name="CustomerDiscount" Type="Double" />
                    <asp:Parameter Name="CustomerUsername" Type="String" />
                    <asp:Parameter Name="CustomerPassword" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CustomerLastName" Type="String" />
                    <asp:Parameter Name="CustomerFirstName" Type="String" />
                    <asp:Parameter Name="CustomerMI" Type="String" />
                    <asp:Parameter Name="CustomerAddress" Type="String" />
                    <asp:Parameter Name="CustomerCity" Type="String" />
                    <asp:Parameter Name="StateAbbreviation" Type="String" />
                    <asp:Parameter Name="CustomerZipCode" Type="String" />
                    <asp:Parameter Name="CustomerPhone" Type="String" />
                    <asp:Parameter Name="CustomerComments" Type="String" />
                    <asp:Parameter Name="CustomerDiscount" Type="Double" />
                    <asp:Parameter Name="CustomerUsername" Type="String" />
                    <asp:Parameter Name="CustomerPassword" Type="String" />
                    <asp:Parameter Name="Original_CustomerID" Type="Int64" />
                    <asp:Parameter Name="Original_CustomerLastName" Type="String" />
                    <asp:Parameter Name="Original_CustomerFirstName" Type="String" />
                    <asp:Parameter Name="Original_CustomerMI" Type="String" />
                    <asp:Parameter Name="Original_CustomerAddress" Type="String" />
                    <asp:Parameter Name="Original_CustomerCity" Type="String" />
                    <asp:Parameter Name="Original_StateAbbreviation" Type="String" />
                    <asp:Parameter Name="Original_CustomerZipCode" Type="String" />
                    <asp:Parameter Name="Original_CustomerPhone" Type="String" />
                    <asp:Parameter Name="Original_CustomerComments" Type="String" />
                    <asp:Parameter Name="Original_CustomerDiscount" Type="Double" />
                    <asp:Parameter Name="Original_CustomerUsername" Type="String" />
                    <asp:Parameter Name="Original_CustomerPassword" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:Label ID="lblStatus" runat="server" Text="Ready..."></asp:Label>
        </div>
    </form>
</body>
</html>
