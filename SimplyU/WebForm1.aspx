<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="SimplyU.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="color: #66CCFF; font-size: x-large" Text="INVENTORY MANAGER"></asp:Label>
        <div>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="362px" Width="1182px">
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
            <br />
            <br />
        </div>
        <asp:Button ID="ButtonADD" runat="server" Height="50px" Text="ADD product" Width="176px" />
        <p>
            <asp:Button ID="ButtonDELETE" runat="server" Height="50px" Text="DELETE product" Width="176px" />
        </p>
        <p>
            <asp:Button ID="ButtonUPDATE" runat="server" Height="50px" Text="UPDATE product" Width="176px" />
        </p>
        <p>
            <asp:Button ID="VIEW" runat="server" Height="50px" Text="VIEW product" Width="176px" />
        </p>
    </form>
</body>
</html>
