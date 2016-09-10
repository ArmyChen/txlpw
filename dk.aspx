<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dk.aspx.cs" Inherits="dk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding:10px; clear:both;">
            <div style="padding-bottom:10px; clear:both; border-bottom:2px solid #186a6d">
                <span style="font-size:12px;"><font face="宋体">系统设置 > <asp:Label ID="Label1" runat="server" Text=""></asp:Label>表信息记录</font></span>
            </div>
        <div style="padding-top:10px; clear:both;">
            <asp:GridView ID="GridView1" Width="100%" runat="server"></asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
