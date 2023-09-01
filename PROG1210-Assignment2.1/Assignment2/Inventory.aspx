<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="Assignment2.Inventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 136px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierName" runat="server" Text="Select Supplier Name"></asp:Label>
            <div style="height: 53px; margin-top: 63px">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="SupplierName" DataValueField="SupplierID" Height="21px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="373px" style="margin-top: 0px">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.InventoyDatasetTableAdapters.SportSupplierTableAdapter"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.InventoyDatasetTableAdapters.DataTable1TableAdapter" OnSelecting="ObjectDataSource2_Selecting">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="Param1" PropertyName="SelectedValue" Type="Int64" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:FormView ID="FormView1" runat="server" DataKeyNames="SupplierID" DataSourceID="ObjectDataSource1" OnPageIndexChanging="FormView1_PageIndexChanging" Width="622px" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <EditItemTemplate>
                        SupplierID:
                        <asp:Label ID="SupplierIDLabel1" runat="server" Text='<%# Eval("SupplierID") %>' />
                        <br />
                        SupplierName:
                        <asp:TextBox ID="SupplierNameTextBox" runat="server" Text='<%# Bind("SupplierName") %>' />
                        <br />
                        SupplierContactName:
                        <asp:TextBox ID="SupplierContactNameTextBox" runat="server" Text='<%# Bind("SupplierContactName") %>' />
                        <br />
                        SupplierContactPhone:
                        <asp:TextBox ID="SupplierContactPhoneTextBox" runat="server" Text='<%# Bind("SupplierContactPhone") %>' />
                        <br />
                        SupplierAddress:
                        <asp:TextBox ID="SupplierAddressTextBox" runat="server" Text='<%# Bind("SupplierAddress") %>' />
                        <br />
                        SupplierCity:
                        <asp:TextBox ID="SupplierCityTextBox" runat="server" Text='<%# Bind("SupplierCity") %>' />
                        <br />
                        StateAbbreviation:
                        <asp:TextBox ID="StateAbbreviationTextBox" runat="server" Text='<%# Bind("StateAbbreviation") %>' />
                        <br />
                        SupplierZip:
                        <asp:TextBox ID="SupplierZipTextBox" runat="server" Text='<%# Bind("SupplierZip") %>' />
                        <br />
                        SupplierPhone:
                        <asp:TextBox ID="SupplierPhoneTextBox" runat="server" Text='<%# Bind("SupplierPhone") %>' />
                        <br />
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>
                    <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <InsertItemTemplate>
                        SupplierName:
                        <asp:TextBox ID="SupplierNameTextBox" runat="server" Text='<%# Bind("SupplierName") %>' />
                        <br />
                        SupplierContactName:
                        <asp:TextBox ID="SupplierContactNameTextBox" runat="server" Text='<%# Bind("SupplierContactName") %>' />
                        <br />
                        SupplierContactPhone:
                        <asp:TextBox ID="SupplierContactPhoneTextBox" runat="server" Text='<%# Bind("SupplierContactPhone") %>' />
                        <br />
                        SupplierAddress:
                        <asp:TextBox ID="SupplierAddressTextBox" runat="server" Text='<%# Bind("SupplierAddress") %>' />
                        <br />
                        SupplierCity:
                        <asp:TextBox ID="SupplierCityTextBox" runat="server" Text='<%# Bind("SupplierCity") %>' />
                        <br />
                        StateAbbreviation:
                        <asp:TextBox ID="StateAbbreviationTextBox" runat="server" Text='<%# Bind("StateAbbreviation") %>' />
                        <br />
                        SupplierZip:
                        <asp:TextBox ID="SupplierZipTextBox" runat="server" Text='<%# Bind("SupplierZip") %>' />
                        <br />
                        SupplierPhone:
                        <asp:TextBox ID="SupplierPhoneTextBox" runat="server" Text='<%# Bind("SupplierPhone") %>' />
                        <br />
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        ID:
                        <asp:Label ID="SupplierIDLabel" runat="server" Text='<%# Eval("SupplierID") %>' />
                        <br />
                        <br />
                        Name:
                        <asp:Label ID="SupplierNameLabel" runat="server" Text='<%# Bind("SupplierName") %>' />
                        <br />
                        <br />
                        ContactName:
                        <asp:Label ID="SupplierContactNameLabel" runat="server" Text='<%# Bind("SupplierContactName") %>' />
                        <br />
                        <br />
                        ContactPhone:
                        <asp:Label ID="SupplierContactPhoneLabel" runat="server" Text='<%# Bind("SupplierContactPhone") %>' />
                        <br />
                        <br />
                        Address:
                        <asp:Label ID="SupplierAddressLabel" runat="server" Text='<%# Bind("SupplierAddress") %>' />
                        <br />
                        <br />
                        City:
                        <asp:Label ID="SupplierCityLabel" runat="server" Text='<%# Bind("SupplierCity") %>' />
                        <br />
                        <br />
                        State Abbreviation:
                        <asp:Label ID="StateAbbreviationLabel" runat="server" Text='<%# Bind("StateAbbreviation") %>' />
                        <br />
                        <br />
                        ZIP Code:
                        <asp:Label ID="SupplierZipLabel" runat="server" Text='<%# Bind("SupplierZip") %>' />
                        <br />
                        <br />
                        Phone:
                        <asp:Label ID="SupplierPhoneLabel" runat="server" Text='<%# Bind("SupplierPhone") %>' />
                        <br />

                    </ItemTemplate>
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                </asp:FormView>
                <asp:FormView ID="FormView2" runat="server" DataSourceID="ObjectDataSource2" OnPageIndexChanging="FormView2_PageIndexChanging" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="621px">
                    <EditItemTemplate>
                        InventoryDescription:
                        <asp:TextBox ID="InventoryDescriptionTextBox" runat="server" Text='<%# Bind("InventoryDescription") %>' />
                        <br />
                        InventorySize:
                        <asp:TextBox ID="InventorySizeTextBox" runat="server" Text='<%# Bind("InventorySize") %>' />
                        <br />
                        ColorDescription:
                        <asp:TextBox ID="ColorDescriptionTextBox" runat="server" Text='<%# Bind("ColorDescription") %>' />
                        <br />
                        InventoryQOH:
                        <asp:TextBox ID="InventoryQOHTextBox" runat="server" Text='<%# Bind("InventoryQOH") %>' />
                        <br />
                        InventorySuggestedPrice:
                        <asp:TextBox ID="InventorySuggestedPriceTextBox" runat="server" Text='<%# Bind("InventorySuggestedPrice") %>' />
                        <br />
                        CategoryDescription:
                        <asp:TextBox ID="CategoryDescriptionTextBox" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                        <br />
                        SubCategoryDescription:
                        <asp:TextBox ID="SubCategoryDescriptionTextBox" runat="server" Text='<%# Bind("SubCategoryDescription") %>' />
                        <br />
                        SupplierID:
                        <asp:TextBox ID="SupplierIDTextBox" runat="server" Text='<%# Bind("SupplierID") %>' />
                        <br />
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>
                    <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <InsertItemTemplate>
                        InventoryDescription:
                        <asp:TextBox ID="InventoryDescriptionTextBox" runat="server" Text='<%# Bind("InventoryDescription") %>' />
                        <br />
                        InventorySize:
                        <asp:TextBox ID="InventorySizeTextBox" runat="server" Text='<%# Bind("InventorySize") %>' />
                        <br />
                        ColorDescription:
                        <asp:TextBox ID="ColorDescriptionTextBox" runat="server" Text='<%# Bind("ColorDescription") %>' />
                        <br />
                        InventoryQOH:
                        <asp:TextBox ID="InventoryQOHTextBox" runat="server" Text='<%# Bind("InventoryQOH") %>' />
                        <br />
                        InventorySuggestedPrice:
                        <asp:TextBox ID="InventorySuggestedPriceTextBox" runat="server" Text='<%# Bind("InventorySuggestedPrice") %>' />
                        <br />
                        CategoryDescription:
                        <asp:TextBox ID="CategoryDescriptionTextBox" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                        <br />
                        SubCategoryDescription:
                        <asp:TextBox ID="SubCategoryDescriptionTextBox" runat="server" Text='<%# Bind("SubCategoryDescription") %>' />
                        <br />
                        SupplierID:
                        <asp:TextBox ID="SupplierIDTextBox" runat="server" Text='<%# Bind("SupplierID") %>' />
                        <br />
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        InventoryDescription:
                        <asp:Label ID="InventoryDescriptionLabel" runat="server" Text='<%# Bind("InventoryDescription") %>' />
                        <br />
                        <br />
                        InventorySize:
                        <asp:Label ID="InventorySizeLabel" runat="server" Text='<%# Bind("InventorySize") %>' />
                        <br />
                        <br />
                        ColorDescription:
                        <asp:Label ID="ColorDescriptionLabel" runat="server" Text='<%# Bind("ColorDescription") %>' />
                        <br />
                        <br />
                        InventoryQOH:
                        <asp:Label ID="InventoryQOHLabel" runat="server" Text='<%# Bind("InventoryQOH") %>' />
                        <br />
                        <br />
                        InventorySuggestedPrice:
                        <asp:Label ID="InventorySuggestedPriceLabel" runat="server" Text='<%# Bind("InventorySuggestedPrice") %>' />
                        <br />
                        <br />
                        CategoryDescription:
                        <asp:Label ID="CategoryDescriptionLabel" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                        <br />
                        <br />
                        SubCategoryDescription:
                        <asp:Label ID="SubCategoryDescriptionLabel" runat="server" Text='<%# Bind("SubCategoryDescription") %>' />
                        <br />

                    </ItemTemplate>
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                </asp:FormView>
                <asp:Menu ID="Menu1" runat="server">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>
    </form>
</body>
</html>
