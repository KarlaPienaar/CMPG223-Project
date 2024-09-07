<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletePage.aspx.cs" Inherits="InventoryManagementSystemCMPG223.DeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Product</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: large; color: #0000FF">
            Delete a record from the database<br />
            <br />
        </div>
        What would you like to delete?&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxDeleteproduct" runat="server" Width="318px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Height="61px" style="color: #6699FF" Text="Delete" Width="103px" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>

