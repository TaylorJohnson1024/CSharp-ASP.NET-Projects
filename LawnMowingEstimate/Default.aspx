<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Length<asp:TextBox ID="tbLength" runat="server">0</asp:TextBox>
        ft.<br />
        Width<asp:TextBox ID="tbWidth" runat="server">0</asp:TextBox>
        ft.<br />
        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate Fee" />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
        <br />
        Weekly Fee<asp:TextBox ID="tbWeeklyFee" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        Number of Weeks<asp:TextBox ID="tbNumberWeeks" runat="server">1</asp:TextBox>
&nbsp;(Max of 20)<br />
        <asp:Button ID="btnCalculateTotal" runat="server" OnClick="btnCalculateTotal_Click" Text="Calculate Total Due" />
        <br />
        <asp:Label ID="lblFinalResult" runat="server"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlPayment" runat="server">
            <asp:ListItem Value="1">One Payment</asp:ListItem>
            <asp:ListItem Value="2">Two Payments</asp:ListItem>
            <asp:ListItem Value="20">20 Payments</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnCalculateWeeklyFee" runat="server" OnClick="btnCalculateWeeklyFee_Click" Text="Calculate Payment Fee(s)" />
        <br />
        <asp:Label ID="lblTrueFinalResult" runat="server"></asp:Label>
        <br />
        <br />
        &lt; 400 sqft = 35/w<br />
        &lt;600 sqft = 50/w<br />
        &lt;1000 sqft = 70/w<br />
        &gt;1000 sqft = 100/w</div>
    </form>
</body>
</html>
