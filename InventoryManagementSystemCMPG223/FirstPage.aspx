<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="InventoryManagementSystemCMPG223.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; font-size: xx-large; color: #6666FF">
            INVENTORY MANAGER<br />
            
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
        <asp:Button ID="AddButton" runat="server" Height="50px" Text="ADD product" Width="138px" OnClick="AddButton_Click" />
        <p>
            <asp:Button ID="DeleteButton" runat="server" Height="50px" Text="DELETE product" Width="138px" OnClick="DeleteButton_Click" />
        </p>
        <p>
            <asp:Button ID="UpdateButton" runat="server" Height="50px" Text="UPDATE product" Width="138px" OnClick="UpdateButton_Click" />
        </p>
        <p>
            <asp:Button ID="ViewButton" runat="server" Height="50px" Text="View product" Width="138px" OnClick="ViewButton_Click" />
        </p>
        <p>
            <asp:Label ID="feedbacklabel" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

