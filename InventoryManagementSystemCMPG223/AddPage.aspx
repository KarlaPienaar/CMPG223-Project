<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="InventoryManagementSystemCMPG223.AddPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: large; font-weight: 700; color: #0033CC">
            Add a product to the database<br />
            <br />
        </div>
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
&nbsp;&nbsp;
            </p>
        <asp:Button ID="ButtonEnter" runat="server" Height="56px" Text="ENTER" Width="174px" OnClick="ButtonEnter_Click" />
        <p>
            &nbsp;</p>
        <asp:Label ID="FeedbackLbl" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

