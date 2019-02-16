<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InventoryReport.aspx.cs" Inherits="MailDistributionLog.InventoryReport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">  
     
        <table>
             <tr><td>Inventory Report
                </td>
            </tr>
            <tr><td><br />
                </td>
            </tr>
            <tr><td>
        Warehouse:
                <asp:DropDownList ID="ddlWarehouse" runat="server" >
                    <asp:ListItem Text="W1" Value="W1"></asp:ListItem>
                     <asp:ListItem Text="W2" Value="W2"></asp:ListItem>
                     <asp:ListItem Text="All" Value="All"></asp:ListItem>
                </asp:DropDownList>
                </td>
            </tr>
             <tr><td><br />
                </td>
            </tr>

        <tr><td><br />
        
                <asp:GridView ID="gwInventory" runat="server">
                    <AlternatingRowStyle BackColor="#99CCFF" />
                   
                </asp:GridView>
                 
       </td>
            </tr>
             <tr><td><br />
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
             </td>
            </tr>

            </table>
    </form>
</body>
</html>
