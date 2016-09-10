<%@ Page Language="C#" AutoEventWireup="true" CodeFile="land.aspx.cs" Inherits="mobile_land" %>

<%@ Register src="mobile_txlp_top.ascx" tagname="mobile_txlp_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" /><meta name="apple-mobile-web-app-capable" content="yes" /><meta name="format-detection" content="telephone=no" />
    <title>天下礼品-登陆</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:mobile_txlp_top ID="mobile_txlp_top1" runat="server" />
    
    </div>
        <div style="padding-top:20px; clear:both;">
    <div style="text-align:center;">
        <div>
            <span style="font-size:1.1em; color:black; vertical-align:middle;">账号：</span><asp:TextBox CssClass="t1" ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div style="padding-top:20px;">
            <span style="font-size:1.1em; color:black; vertical-align:middle;">密码：</span><asp:TextBox CssClass="t1" ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div style="padding-top:20px;">
            <asp:Button ID="Button1" runat="server" Text="登陆" Width="106px" OnClick="Button1_Click" />
        </div>
    </div>
    
    </div>
    </form>
</body>
</html>
