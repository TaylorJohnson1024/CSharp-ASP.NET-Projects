<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Number of Tiles
            <asp:TextBox ID="tbNumberTiles" runat="server"></asp:TextBox>
            &nbsp;<br />
            <asp:Button ID="btnSize" runat="server" OnClick="btnSize_Click" Text="Set Size" />
        </div>
        <div runat="server" id="CheckerBoard">
        </div>
    </form>
</body>
</html>
