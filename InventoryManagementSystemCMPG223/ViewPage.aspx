<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPage.aspx.cs" Inherits="InventoryManagementSystemCMPG223.ViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; font-size: x-large; color: #3399FF">
            HERE ARE ALL YOUR PRODUCTS<br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="InventoryId" DataSourceID="SqlDataSource1" Height="235px" Width="522px">
            <Columns>
                <asp:BoundField DataField="InventoryId" HeaderText="InventoryId" InsertVisible="False" ReadOnly="True" SortExpression="InventoryId" />
                <asp:BoundField DataField="QuantityInStock" HeaderText="QuantityInStock" SortExpression="QuantityInStock" />
                <asp:BoundField DataField="SupplierId" HeaderText="SupplierId" SortExpression="SupplierId" />
                <asp:BoundField DataField="ProductId" HeaderText="ProductId" SortExpression="ProductId" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CMPG223PROJECTdatabaseConnectionString2 %>" SelectCommand="SELECT [InventoryId], [QuantityInStock], [SupplierId], [ProductId] FROM [INVENTORY]"></asp:SqlDataSource>
    </form>
</body>
</html>

