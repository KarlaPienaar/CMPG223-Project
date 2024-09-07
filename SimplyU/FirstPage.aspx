<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FirstPage.aspx.vb" Inherits="SimplyU.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; font-size: xx-large; color: #6666FF">
            INVENTORY MANAGER<br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="296px" Width="1265px">
            <Columns>
                <asp:BoundField DataField="QuantityInStock" HeaderText="QuantityInStock" SortExpression="QuantityInStock" />
                <asp:BoundField DataField="SupplierId" HeaderText="SupplierId" SortExpression="SupplierId" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="InventoryId" HeaderText="InventoryId" SortExpression="InventoryId" />
                <asp:BoundField DataField="ProductId" HeaderText="ProductId" SortExpression="ProductId" />
                <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
                <asp:BoundField DataField="ProductDescription" HeaderText="ProductDescription" SortExpression="ProductDescription" />
                <asp:BoundField DataField="ProductSize" HeaderText="ProductSize" SortExpression="ProductSize" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CMPG223PROJECTdatabaseConnectionString %>" SelectCommand="SELECT [QuantityInStock], [SupplierId], [ProductName], [InventoryId], [ProductId], [ProductPrice], [ProductDescription], [ProductSize] FROM [InventoryTable]"></asp:SqlDataSource>
        <asp:Button ID="AddButton" runat="server" Height="50px" Text="ADD product" Width="138px" />
        <p>
            <asp:Button ID="DeleteButton" runat="server" Height="50px" Text="DELETE product" Width="138px" />
        </p>
        <p>
            <asp:Button ID="UpdateButton" runat="server" Height="50px" Text="UPDATE product" Width="138px" />
        </p>
        <p>
            <asp:Button ID="ViewButton" runat="server" Height="50px" Text="View product" Width="138px" />
        </p>
    </form>
</body>
</html>
