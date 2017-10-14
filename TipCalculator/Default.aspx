<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Tip Percentage<asp:RadioButtonList ID="rblTipPercentage" runat="server" Height="152px" Width="71px">
            <asp:ListItem>0%</asp:ListItem>
            <asp:ListItem>5%</asp:ListItem>
            <asp:ListItem>10%</asp:ListItem>
            <asp:ListItem Selected="True">15%</asp:ListItem>
            <asp:ListItem>18%</asp:ListItem>
            <asp:ListItem>20%</asp:ListItem>
            <asp:ListItem>25%</asp:ListItem>
        </asp:RadioButtonList>
        Total Bill
        <asp:TextBox ID="tbBill" runat="server">0</asp:TextBox>
        <br />
        <asp:Button ID="btnCalculateTip" runat="server" OnClick="btnCalculateTip_Click" Text="Calculate Tip" />
        <br />
        <asp:Label ID="lblTipAmount" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
