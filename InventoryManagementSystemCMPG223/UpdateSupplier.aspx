<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateSupplier.aspx.cs" Inherits="InventoryManagementSystemCMPG223.UpdateSupplier" %>

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
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="lblUpdateSupplier" runat="server" Text="Update Supplier"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblSupplierId" runat="server" Text="Supplier ID:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtSupplierId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnAdd_Click" Text="Update" Width="88px" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>

                <td>
                    <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
