<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSpecial.aspx.cs" Inherits="InventoryManagementSystemCMPG223.AddSpecial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            width: 307px;
        }
        .auto-style3 {
            width: 236px;
        }
        .auto-style7 {
            width: 309px;
            text-align: center;
        }
        .auto-style6 {
            width: 237px;
            text-align: center;
        }
        .auto-style8 {
            width: 309px;
            height: 23px;
            text-align: center;
        }
        .auto-style9 {
            width: 237px;
            height: 23px;
            text-align: center;
        }
        .auto-style10 {
            height: 23px;
        }
        .auto-style11 {
            width: 236px;
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
                        <asp:Label ID="lblAddSpecial" runat="server" Text="Add Special"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblProductId" runat="server" Text="Product ID:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblDiscount" runat="server" Text="Discount:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="lblStartDate" runat="server" Text="Start Date:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblEndDate" runat="server" Text="End Date:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>

                </td>

                <td>
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="88px" />
                    <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
