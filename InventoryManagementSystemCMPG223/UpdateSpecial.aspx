<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateSpecial.aspx.cs" Inherits="InventoryManagementSystemCMPG223.UpdateSpecial" %>

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
        .auto-style12 {
            width: 307px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="lblAddSpecial" runat="server" Text="Update Special"></asp:Label>
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
                        <asp:Label ID="lblProductId" runat="server" Text="Product ID:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        <div>
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
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblEndDate" runat="server" Text="End Date:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>

                </td>

                <td>
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnAdd_Click" Text="Update" Width="88px" />
                    <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
