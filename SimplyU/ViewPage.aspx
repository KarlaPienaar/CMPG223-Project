<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ViewPage.aspx.vb" Inherits="SimplyU.ViewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; font-size: x-large; color: #3399FF">
            HERE ARE ALL YOUR PRODUCTS<br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" ForeColor="#0033CC" Height="791px" Width="1444px">
            <Columns>
                <asp:BoundField DataField="QuantityInStock" HeaderText="QuantityInStock" SortExpression="QuantityInStock" />
                <asp:BoundField DataField="SupplierId" HeaderText="SupplierId" SortExpression="SupplierId" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="InventoryId" HeaderText="InventoryId" SortExpression="InventoryId" />
                <asp:BoundField DataField="ProductId" HeaderText="ProductId" SortExpression="ProductId" />
                <asp:BoundField DataField="ProductDescription" HeaderText="ProductDescription" SortExpression="ProductDescription" />
                <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
                <asp:BoundField DataField="ProductSize" HeaderText="ProductSize" SortExpression="ProductSize" />
            </Columns>
            <RowStyle BackColor="#FFFFCC" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CMPG223PROJECTdatabaseConnectionString %>" SelectCommand="SELECT [QuantityInStock], [SupplierId], [ProductName], [InventoryId], [ProductId], [ProductDescription], [ProductPrice], [ProductSize] FROM [InventoryTable]"></asp:SqlDataSource>
    </form>
</body>
</html>
