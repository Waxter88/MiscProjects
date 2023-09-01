<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lookup.aspx.cs" Inherits="Assignment2.Lookup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 570px">
    <form id="form1" runat="server">
        <div>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.SportMotorsDataSetTableAdapters.SportColorTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_ColorDescription" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ColorDescription" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Original_ColorDescription" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.SportMotorsDataSetTableAdapters.SportStateTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_StateAbbreviation" Type="String" />
                    <asp:Parameter Name="Original_StateName" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="StateAbbreviation" Type="String" />
                    <asp:Parameter Name="StateName" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="StateName" Type="String" />
                    <asp:Parameter Name="Original_StateAbbreviation" Type="String" />
                    <asp:Parameter Name="Original_StateName" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PROG1210_Assignment2._1.SportMotorsDataSetTableAdapters.SportPaymentTypeTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_PaymentType" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="PaymentType" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Original_PaymentType" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ColorDescription" DataSourceID="ObjectDataSource1" OnRowDeleted="GridView1_RowDeleted" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <EditItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"  OnClientClick="return confirm('Are you sure you want to Delete the record?')" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ColorDescription" HeaderText="ColorDescription" ReadOnly="True" SortExpression="ColorDescription" />
                </Columns>
            </asp:GridView>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="ColorDescription" DataSourceID="ObjectDataSource1" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="ColorDescription" HeaderText="ColorDescription" ReadOnly="True" SortExpression="ColorDescription" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="StateAbbreviation" DataSourceID="ObjectDataSource2" OnRowDeleted="GridView2_RowDeleted" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <EditItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"  OnClientClick="return confirm('Are you sure you want to Delete the record?')" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="StateAbbreviation" HeaderText="StateAbbreviation" ReadOnly="True" SortExpression="StateAbbreviation" />
                    <asp:BoundField DataField="StateName" HeaderText="StateName" SortExpression="StateName" />
                </Columns>
            </asp:GridView>
            <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" DataKeyNames="StateAbbreviation" DataSourceID="ObjectDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="StateAbbreviation" HeaderText="StateAbbreviation" ReadOnly="True" SortExpression="StateAbbreviation" />
                    <asp:BoundField DataField="StateName" HeaderText="StateName" SortExpression="StateName" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="PaymentType" DataSourceID="ObjectDataSource3" OnRowDeleted="GridView3_RowDeleted" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <EditItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to Delete the record?')" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="PaymentType" HeaderText="PaymentType" ReadOnly="True" SortExpression="PaymentType" />
                </Columns>
            </asp:GridView>
            <asp:DetailsView ID="DetailsView3" runat="server" AutoGenerateRows="False" DataKeyNames="PaymentType" DataSourceID="ObjectDataSource3" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="PaymentType" HeaderText="PaymentType" ReadOnly="True" SortExpression="PaymentType" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:Menu ID="Menu1" runat="server">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Index.aspx" Text="Home" Value="Home"></asp:MenuItem>
                </Items>
            </asp:Menu>
            <asp:Label ID="lblStatus" runat="server" Text="Ready..."></asp:Label>
        </div>
    </form>
</body>
</html>
