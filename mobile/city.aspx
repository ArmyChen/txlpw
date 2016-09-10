<%@ Page Language="C#" AutoEventWireup="true" CodeFile="city.aspx.cs" Inherits="mobile_city" %>

<%@ Register src="mobile_txlp_top.ascx" tagname="mobile_txlp_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" /><meta name="apple-mobile-web-app-capable" content="yes" /><meta name="format-detection" content="telephone=no" />

    <title>城市切换-天下礼品</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <uc1:mobile_txlp_top ID="mobile_txlp_top1" runat="server" />
        
    </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <div style="overflow:hidden; _position:relative; position:fixed; bottom:0px; left:0px; z-index:999; background-color:white; border-top:1px solid #d5d5d5; width:100%;">
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
        <div style="height:135px;">
            &nbsp;
        </div>
    </form>
</body>
</html>
