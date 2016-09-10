<%@ Page Language="C#" AutoEventWireup="true" CodeFile="city.aspx.cs" Inherits="city" %>

<%@ Register src="tx_top.ascx" tagname="tx_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>城市切换</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <uc1:tx_top ID="tx_top1" runat="server" />

        </div>
    <div style="padding:20px 10px 20px 60px; clear:both;">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
