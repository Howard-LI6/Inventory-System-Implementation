<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InventoryEntry.aspx.cs" Inherits="MailDistributionLog.InventoryEntry" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">   
        <table>
            <tr><td>Inventory Entry
                </td>
            </tr>
            <tr><td><br />
                </td>
            </tr>
            <tr><td>
        Warehouse:
        <asp:TextBox ID="txtWarehouse" runat="server"></asp:TextBox></td>
            </tr>
             <tr><td><br />
                </td>
            </tr>

            <tr><td>
        ModelNo:
        <asp:TextBox ID="txtModelNo" runat="server"></asp:TextBox></td>
            </tr>
             <tr><td><br />
                </td>
            </tr>
            
            <tr><td>
        SN:
        <asp:TextBox ID="txtSn" runat="server"></asp:TextBox></td>
            </tr>
             <tr><td><br />
                </td>
            </tr>
            
            <tr><td>
        Quantity:
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr><td><br />
                </td>
            </tr>
             <tr><td><br />
                 <asp:Label ID="lblMsg" runat="server" Text=""  ForeColor=Red></asp:Label>
                </td>
            </tr>

            </table>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
