<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PROG1210_WebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50px;
            height: 100px;
        }
        .auto-style3 {
            float: left;
            width: 67px;
        }
        .auto-style7 {
            height: 100px;
        }
        .auto-style9 {
            height: 26px;
            width: 103px;
        }
        .auto-style10 {
            width: 1469px;
        }
        .auto-style11 {
            width: 226px;
        }
        .auto-style12 {
            width: 401px;
        }
        </style>
</head>
<body style="height: 600px">
    <form id="form1" runat="server">
        <div>
            <strong>Detail View:</strong><br />
            <br />
            <asp:FormView ID="FormView2" runat="server" DataKeyNames="id" DataSourceID="ObjectDataSource1">
                <EditItemTemplate>
                    id:
                    <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
                    <br />
                    custFirst:
                    <asp:TextBox ID="custFirstTextBox" runat="server" Text='<%# Bind("custFirst") %>' />
                    <br />
                    custLast:
                    <asp:TextBox ID="custLastTextBox" runat="server" Text='<%# Bind("custLast") %>' />
                    <br />
                    custPhone:
                    <asp:TextBox ID="custPhoneTextBox" runat="server" Text='<%# Bind("custPhone") %>' />
                    <br />
                    custAddress:
                    <asp:TextBox ID="custAddressTextBox" runat="server" Text='<%# Bind("custAddress") %>' />
                    <br />
                    custCity:
                    <asp:TextBox ID="custCityTextBox" runat="server" Text='<%# Bind("custCity") %>' />
                    <br />
                    custPostal:
                    <asp:TextBox ID="custPostalTextBox" runat="server" Text='<%# Bind("custPostal") %>' />
                    <br />
                    custEmail:
                    <asp:TextBox ID="custEmailTextBox" runat="server" Text='<%# Bind("custEmail") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    custFirst:
                    <asp:TextBox ID="custFirstTextBox" runat="server" Text='<%# Bind("custFirst") %>' />
                    <br />
                    custLast:
                    <asp:TextBox ID="custLastTextBox" runat="server" Text='<%# Bind("custLast") %>' />
                    <br />
                    custPhone:
                    <asp:TextBox ID="custPhoneTextBox" runat="server" Text='<%# Bind("custPhone") %>' />
                    <br />
                    custAddress:
                    <asp:TextBox ID="custAddressTextBox" runat="server" Text='<%# Bind("custAddress") %>' />
                    <br />
                    custCity:
                    <asp:TextBox ID="custCityTextBox" runat="server" Text='<%# Bind("custCity") %>' />
                    <br />
                    custPostal:
                    <asp:TextBox ID="custPostalTextBox" runat="server" Text='<%# Bind("custPostal") %>' />
                    <br />
                    custEmail:
                    <asp:TextBox ID="custEmailTextBox" runat="server" Text='<%# Bind("custEmail") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    &nbsp;<asp:Label ID="custFirstLabel" runat="server" Font-Bold="True" Font-Size="XX-Large" Text='<%# Bind("custFirst") %>' />
                    &nbsp;
                    <asp:Label ID="custLastLabel" runat="server" Font-Bold="True" Font-Size="XX-Large" Text='<%# Bind("custLast") %>' />
                    <br />
                </ItemTemplate>
            </asp:FormView>
            <br />
            <asp:FormView ID="FormView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Horizontal">
                <EditItemTemplate>
                    id:
                    <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
                    <br />
                    custFirst:
                    <asp:TextBox ID="custFirstTextBox" runat="server" Text='<%# Bind("custFirst") %>' />
                    <br />
                    custLast:
                    <asp:TextBox ID="custLastTextBox" runat="server" Text='<%# Bind("custLast") %>' />
                    <br />
                    custPhone:
                    <asp:TextBox ID="custPhoneTextBox" runat="server" Text='<%# Bind("custPhone") %>' />
                    <br />
                    custAddress:
                    <asp:TextBox ID="custAddressTextBox" runat="server" Text='<%# Bind("custAddress") %>' />
                    <br />
                    custCity:
                    <asp:TextBox ID="custCityTextBox" runat="server" Text='<%# Bind("custCity") %>' />
                    <br />
                    custPostal:
                    <asp:TextBox ID="custPostalTextBox" runat="server" Text='<%# Bind("custPostal") %>' />
                    <br />
                    custEmail:
                    <asp:TextBox ID="custEmailTextBox" runat="server" Text='<%# Bind("custEmail") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    custFirst:
                    <asp:TextBox ID="custFirstTextBox" runat="server" Text='<%# Bind("custFirst") %>' />
                    <br />
                    custLast:
                    <asp:TextBox ID="custLastTextBox" runat="server" Text='<%# Bind("custLast") %>' />
                    <br />
                    custPhone:
                    <asp:TextBox ID="custPhoneTextBox" runat="server" Text='<%# Bind("custPhone") %>' />
                    <br />
                    custAddress:
                    <asp:TextBox ID="custAddressTextBox" runat="server" Text='<%# Bind("custAddress") %>' />
                    <br />
                    custCity:
                    <asp:TextBox ID="custCityTextBox" runat="server" Text='<%# Bind("custCity") %>' />
                    <br />
                    custPostal:
                    <asp:TextBox ID="custPostalTextBox" runat="server" Text='<%# Bind("custPostal") %>' />
                    <br />
                    custEmail:
                    <asp:TextBox ID="custEmailTextBox" runat="server" Text='<%# Bind("custEmail") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <br />
                    <strong>First</strong>:
                    <asp:Label ID="custFirstLabel" runat="server" Text='<%# Bind("custFirst") %>' />
                    <br />
                    <strong>Last</strong>:
                    <asp:Label ID="custLastLabel" runat="server" Text='<%# Bind("custLast") %>' />
                    <br />
                    <strong>Phone</strong>:
                    <asp:Label ID="custPhoneLabel" runat="server" Text='<%# Bind("custPhone") %>' />
                    <br />
                    <strong>Address</strong>:
                    <asp:Label ID="custAddressLabel" runat="server" Text='<%# Bind("custAddress") %>' />
                    <br />
                    <strong>City</strong>:
                    <asp:Label ID="custCityLabel" runat="server" Text='<%# Bind("custCity") %>' />
                    <br />
                    <strong>Postal</strong>:
                    <asp:Label ID="custPostalLabel" runat="server" Text='<%# Bind("custPostal") %>' />
                    <br />
                    <strong>Email</strong>:
                    <asp:Label ID="custEmailLabel" runat="server" Text='<%# Bind("custEmail") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                </ItemTemplate>
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            </asp:FormView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment4_ClassLibrary.EmmasDatasetTableAdapters.customer1TableAdapter" UpdateMethod="Update">
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
                    <asp:QueryStringParameter Name="custID" QueryStringField="pkID" Type="Int32" />
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
            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment4_ClassLibrary.EmmasDatasetTableAdapters.receiptTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_id" Type="Int32" />
                    <asp:Parameter Name="Original_ordNumber" Type="String" />
                    <asp:Parameter Name="Original_ordDate" Type="DateTime" />
                    <asp:Parameter Name="Original_ordPaid" Type="Boolean" />
                    <asp:Parameter Name="Original_paymentID" Type="Int32" />
                    <asp:Parameter Name="Original_custID" Type="Int32" />
                    <asp:Parameter Name="Original_empID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ordNumber" Type="String" />
                    <asp:Parameter Name="ordDate" Type="DateTime" />
                    <asp:Parameter Name="ordPaid" Type="Boolean" />
                    <asp:Parameter Name="paymentID" Type="Int32" />
                    <asp:Parameter Name="custID" Type="Int32" />
                    <asp:Parameter Name="empID" Type="Int32" />
                </InsertParameters>
                <SelectParameters>
                    <asp:QueryStringParameter Name="Param1" QueryStringField="pkID" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ordNumber" Type="String" />
                    <asp:Parameter Name="ordDate" Type="DateTime" />
                    <asp:Parameter Name="ordPaid" Type="Boolean" />
                    <asp:Parameter Name="paymentID" Type="Int32" />
                    <asp:Parameter Name="custID" Type="Int32" />
                    <asp:Parameter Name="empID" Type="Int32" />
                    <asp:Parameter Name="Original_id" Type="Int32" />
                    <asp:Parameter Name="Original_ordNumber" Type="String" />
                    <asp:Parameter Name="Original_ordDate" Type="DateTime" />
                    <asp:Parameter Name="Original_ordPaid" Type="Boolean" />
                    <asp:Parameter Name="Original_paymentID" Type="Int32" />
                    <asp:Parameter Name="Original_custID" Type="Int32" />
                    <asp:Parameter Name="Original_empID" Type="Int32" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <br />
            <table class="auto-style10">
                <tr>
                    <td class="auto-style1" style="border-style: solid; border-width: 3px; width: 250px; height: 90px; table-layout: auto; display: table-cell; float: inherit;">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Cancel" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Submit" />
                    </td>
                    <td class="auto-style12">
                        <asp:FormView ID="FormView3" runat="server" DataKeyNames="id" DataSourceID="ObjectDataSource2" Height="100px" Width="16px">
                            <EditItemTemplate>
                                id:
                                <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
                                <br />
                                ordNumber:
                                <asp:TextBox ID="ordNumberTextBox" runat="server" Text='<%# Bind("ordNumber") %>' />
                                <br />
                                ordDate:
                                <asp:TextBox ID="ordDateTextBox" runat="server" Text='<%# Bind("ordDate") %>' />
                                <br />
                                ordPaid:
                                <asp:CheckBox ID="ordPaidCheckBox" runat="server" Checked='<%# Bind("ordPaid") %>' />
                                <br />
                                paymentID:
                                <asp:TextBox ID="paymentIDTextBox" runat="server" Text='<%# Bind("paymentID") %>' />
                                <br />
                                custID:
                                <asp:TextBox ID="custIDTextBox" runat="server" Text='<%# Bind("custID") %>' />
                                <br />
                                empID:
                                <asp:TextBox ID="empIDTextBox" runat="server" Text='<%# Bind("empID") %>' />
                                <br />
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                ordNumber:
                                <asp:TextBox ID="ordNumberTextBox" runat="server" Text='<%# Bind("ordNumber") %>' />
                                <br />
                                ordDate:
                                <asp:TextBox ID="ordDateTextBox" runat="server" Text='<%# Bind("ordDate") %>' />
                                <br />
                                ordPaid:
                                <asp:CheckBox ID="ordPaidCheckBox" runat="server" Checked='<%# Bind("ordPaid") %>' />
                                <br />
                                paymentID:
                                <asp:TextBox ID="paymentIDTextBox" runat="server" Text='<%# Bind("paymentID") %>' />
                                <br />
                                custID:
                                <asp:TextBox ID="custIDTextBox" runat="server" Text='<%# Bind("custID") %>' />
                                <br />
                                empID:
                                <asp:TextBox ID="empIDTextBox" runat="server" Text='<%# Bind("empID") %>' />
                                <br />
                                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <table class="auto-style7" style="width: 400px">
                                    <tr>
                                        <td style="border-style: solid; border-width: 3px"><strong>ID</strong></td>
                                        <td style="border-style: solid; border-width: 3px"><strong>Order</strong></td>
                                        <td style="border-style: solid; border-width: 3px"><strong>Date</strong></td>
                                        <td style="border-style: solid; border-width: 3px" class="auto-style11"><strong>Paid</strong></td>
                                    </tr>
                                    <tr>
                                        <td style="border-style: solid; border-width: 3px">
                                            <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                                        </td>
                                        <td style="border-style: solid; border-width: 3px">
                                            <asp:Label ID="ordNumberLabel" runat="server" Text='<%# Bind("ordNumber") %>' />
                                        </td>
                                        <td style="border-style: solid; border-width: 3px">
                                            <asp:Label ID="ordDateLabel" runat="server" Text='<%# Bind("ordDate") %>' />
                                        </td>
                                        <td style="border-style: solid; border-width: 3px" class="auto-style11">
                                            <asp:CheckBox ID="ordPaidCheckBox" runat="server" Checked='<%# Bind("ordPaid") %>' Enabled="false" />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:FormView>
                    </td>
                    <td>
                        <asp:FormView ID="FormView4" runat="server" DataKeyNames="id" DataSourceID="ObjectDataSource3" Height="100px" Width="16px">
                            <EditItemTemplate>
                                id:
                                <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
                                <br />
                                payType:
                                <asp:TextBox ID="payTypeTextBox" runat="server" Text='<%# Bind("payType") %>' />
                                <br />
                                &nbsp;
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                payType:
                                <asp:TextBox ID="payTypeTextBox" runat="server" Text='<%# Bind("payType") %>' />
                                <br />
                                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <table class="auto-style7">
                                    <tr>
                                        <td class="auto-style9" style="border-style: solid; border-width: 3px; width: 400px;"><strong class="auto-style3" style="display: inherit;">Payment</strong></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style9" style="border-style: solid; border-width: 3px; width: 400px;">
                                            <asp:Label ID="payTypeLabel" runat="server" Text='<%# Bind("payType") %>' />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:FormView>
                    </td>
                </tr>
            </table>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment4_ClassLibrary.EmmasDatasetTableAdapters.paymentTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_id" Type="Int32" />
                    <asp:Parameter Name="Original_payType" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="payType" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="FormView3" Name="Param1" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="payType" Type="String" />
                    <asp:Parameter Name="Original_id" Type="Int32" />
                    <asp:Parameter Name="Original_payType" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment4_ClassLibrary.EmmasDatasetTableAdapters.receiptTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_id" Type="Int32" />
                    <asp:Parameter Name="Original_ordNumber" Type="String" />
                    <asp:Parameter Name="Original_ordDate" Type="DateTime" />
                    <asp:Parameter Name="Original_ordPaid" Type="Boolean" />
                    <asp:Parameter Name="Original_paymentID" Type="Int32" />
                    <asp:Parameter Name="Original_custID" Type="Int32" />
                    <asp:Parameter Name="Original_empID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ordNumber" Type="String" />
                    <asp:Parameter Name="ordDate" Type="DateTime" />
                    <asp:Parameter Name="ordPaid" Type="Boolean" />
                    <asp:Parameter Name="paymentID" Type="Int32" />
                    <asp:Parameter Name="custID" Type="Int32" />
                    <asp:Parameter Name="empID" Type="Int32" />
                </InsertParameters>
                <SelectParameters>
                    <asp:QueryStringParameter Name="Param1" QueryStringField="pkID" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ordNumber" Type="String" />
                    <asp:Parameter Name="ordDate" Type="DateTime" />
                    <asp:Parameter Name="ordPaid" Type="Boolean" />
                    <asp:Parameter Name="paymentID" Type="Int32" />
                    <asp:Parameter Name="custID" Type="Int32" />
                    <asp:Parameter Name="empID" Type="Int32" />
                    <asp:Parameter Name="Original_id" Type="Int32" />
                    <asp:Parameter Name="Original_ordNumber" Type="String" />
                    <asp:Parameter Name="Original_ordDate" Type="DateTime" />
                    <asp:Parameter Name="Original_ordPaid" Type="Boolean" />
                    <asp:Parameter Name="Original_paymentID" Type="Int32" />
                    <asp:Parameter Name="Original_custID" Type="Int32" />
                    <asp:Parameter Name="Original_empID" Type="Int32" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="ordNumber" DataValueField="ordNumber" EnableViewState="False" Height="0px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="0px">
            </asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ObjectDataSource5" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="prodName" HeaderText="Product" SortExpression="prodName" />
                    <asp:BoundField DataField="orlQuantity" HeaderText="Qty" SortExpression="orlQuantity" />
                    <asp:BoundField DataField="orlPrice" HeaderText="Price" SortExpression="orlPrice" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment4_ClassLibrary.EmmasDatasetTableAdapters.ProdOrderTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="Param1" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
