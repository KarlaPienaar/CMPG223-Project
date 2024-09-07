<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdatePage.aspx.vb" Inherits="SimplyU.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div style="font-size: large; font-weight: 700; color: #0033CC">
            Change a product in the database<br />
            <br />
            WHICH PRODUCT DO YOU WNT TO CHANGE?
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ProductName" DataValueField="ProductName" Height="18px" Width="279px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CMPG223PROJECTdatabaseConnectionString2 %>" SelectCommand="SELECT [ProductName] FROM [InventoryTable]"></asp:SqlDataSource>
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Product name: "></asp:Label>
        <asp:TextBox ID="TxtProductname" runat="server" Width="334px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Quantity in stock:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxQinstock" runat="server" Width="334px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Supplier ID:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBoxSupplierID" runat="server" Width="334px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Inventory ID"></asp:Label>
            :&nbsp;
            <asp:TextBox ID="TextBoxInventoryID" runat="server" Width="334px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Product ID:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBoxProductID" runat="server" Width="334px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Product price:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBoxProductprice" runat="server" Width="334px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Product size:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBoxProductsize" runat="server" Width="334px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Product Description:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBoxProductdescription" runat="server" Width="334px"></asp:TextBox>
        </p>
        <asp:Button ID="ButtonEnter" runat="server" Height="56px" Text="ENTER" Width="174px" />
    </form> 
        <div>
        </div>
</body>
</html>
