<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteSpecial.aspx.cs" Inherits="InventoryManagementSystemCMPG223.DeleteSpecial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">



        .auto-style2 {
            width: 307px;
        }
        .auto-style11 {
            width: 236px;
            text-align: center;
        }
        .auto-style12 {
            width: 307px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="lblDeleteSpecial" runat="server" Text="Delete Special"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblSpecialId" runat="server" Text="Special ID:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtSpecialId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td>
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnAdd_Click" Text="Delete" Width="88px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
