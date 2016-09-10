<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xq.aspx.cs" Inherits="mobile_xq" %>

<%@ Register src="mobile_txlp_top.ascx" tagname="mobile_txlp_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" /><meta name="apple-mobile-web-app-capable" content="yes" /><meta name="format-detection" content="telephone=no" />

    <title>天下礼品-详细信息</title>
    <style>
        img {
            width: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:mobile_txlp_top ID="mobile_txlp_top1" runat="server" />
    
    </div>
        <div style="background-color:#f2f1f1;"> 
            <div style="padding:10px; border-bottom:1px solid #d5d5d5; clear:both;">
                <div>
                    <span style="font-size:1.1em; color:#333333;"><font face="微软雅黑"><b><asp:Label ID="Label1" runat="server" Text=""></asp:Label></b></font></span>
                </div>
                <div style="padding-top:10px; clear:both;">
                    <span style="font-size:14px; color:#666666;"><font face="宋体"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></font></span>
                </div>
            </div>
        </div>
        <div style="padding:6px 10px 6px 10px; clear:both;">
            <span style="font-size:14px; color:#666666;"><font face="宋体">详情：<asp:Label ID="Label3" runat="server" Text=""></asp:Label></font></span>
        </div>
        <div style="padding:6px 10px 6px 10px; clear:both;">
            <span style="font-size:14px; color:#666666;"><font face="宋体">联系信息：</font></span><span style="font-size:14px; color:#666666;"><font face="宋体"><asp:Label ID="Label4" runat="server" Text=""></asp:Label></font></span>
        </div>
        <div style="padding:6px 10px 6px 10px; clear:both;">
            <span style="font-size:14px; color:#666666;"><font face="宋体">联系电话：</font></span><span style="font-size:14px; color:#666666;"><font face="宋体"><asp:Label ID="Label5" runat="server" Text=""></asp:Label></font></span>
        </div>
        <div style="padding:6px 10px 6px 10px; border-bottom:1px solid #e8e8e8; clear:both;">
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        </div>
        <div style="padding:6px 10px 6px 10px; clear:both;">
            <span style="font-size:12px; color:red">
                温馨提示：平台信息均属第三方商家信息，一切责任与本平台无关！
            </span>
        </div>
        <div style="width:100%; overflow:hidden; clear:both;">
            <div style="padding:10px;">
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                </div>
        </div>
        <div style="height:70px; font-size:0px;">
            &nbsp;
        </div>
        <div style=" position:fixed;_position:absolute; width:100%; background-color:white; border-top:1px solid #e96e30; bottom:0px; left:0px; z-index:999;">
            <div style="overflow:hidden;">
                <div style="width:60%; float:left;">
                    <div style="padding:10px; clear:both;">
                        <span style="font-size:1.1em;"><font face="宋体"><b><asp:Label ID="Label8" runat="server" Text=""></asp:Label></b></font></span>
                    </div>
                    <div style="padding:10px; padding-top:0px; clear:both;">
                        <span style="font-size:14px;"><font face="宋体"><asp:Label ID="Label9" runat="server" Text=""></asp:Label></font></span>
                    </div>
                </div>
                <div style="width:40%; float:left; text-align:right;">
                    <div style="padding-right:5px;">
                        <a href="tel:<%=dh %>" mce_href="tel:<%=dh %>"><img src="images/iphone.png" style="height:60px; width:60px;" /></a>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
