<%@ Page Language="C#" AutoEventWireup="true" CodeFile="land.aspx.cs" Inherits="land" %>

<%@ Register src="tx_top.ascx" tagname="tx_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>天下礼品-会员登陆</title>
    <style type="text/css">
        .t1 {
            vertical-align: middle;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <uc1:tx_top ID="tx_top1" runat="server" />

        </div>
    <div style="text-align:center;">
        <div>
            <span style="font-size:14px; color:black; vertical-align:middle;">账号：</span><asp:TextBox CssClass="t1" ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div style="padding-top:20px;">
            <span style="font-size:14px; color:black; vertical-align:middle;">密码：</span><asp:TextBox CssClass="t1" ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div style="padding-top:20px;">
            <asp:Button ID="Button1" runat="server" Text="登陆" Width="106px" OnClick="Button1_Click" />
        </div>
    </div>
    </form>
</body>
</html>
