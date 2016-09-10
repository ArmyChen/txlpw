<%@ Control Language="C#" AutoEventWireup="true" CodeFile="tx_top.ascx.cs" Inherits="tx_top" %>
<style type="text/css">
    html {
        margin: 0px;
        padding: 0px;
    }
    body {
        padding: 0px;
        margin: 0px;
    }
</style>
<script src="js/jquery-1.7.1.min.js"></script>
<script type="text/javascript">
var mobileAgent = new Array("iphone", "ipod", "ipad", "android", "mobile", "blackberry", "webos", "incognito", "webmate", "bada", "nokia", "lg", "ucweb", "skyfire");
   
var browser = navigator.userAgent.toLowerCase();
   
var isMobile = false;
   
for (var i=0; i<mobileAgent.length; i++){ if (browser.indexOf(mobileAgent[i])!=-1){ isMobile = true;
   
//alert(mobileAgent[i]);
   
location.href = 'http://www.txlphs.com/mobile/index.aspx';
   
break; } }
    $(function () {

    })
</script>
<div style="height:160px; background-image:url(tpimg/jt.jpg); background-repeat:repeat-x;">
&nbsp;
</div>
<div style="padding:20px 0px 20px 20px; margin-bottom:10px; border-bottom:2px solid #e96e30; height:40px; position:relative; z-index:1; clear:both;">
    <span style="font-size:20px; color:red; font-weight:bold;"><font face="微软雅黑">
        </font></span><a href="city.aspx" style="font-size:20px; color:red; font-weight:bold; text-decoration:none;"><font face="微软雅黑"><asp:Label ID="Label1" runat="server" Text=""></asp:Label>[切换城市]</font></a>
    <a href="index.aspx" style="font-size:20px; color:blue; font-weight:bold; text-decoration:none; margin-left:10px;"><font face="微软雅黑">返回首页</font></a>
    <a href="fabu.aspx" target="_blank"><img src="tpimg/mffb.png" style="position:absolute; top:10px; right:10px; z-index:999;" /></a>
    <span id="dlq" runat="server"><a href="land.aspx" style="font-size:16px; color:black; text-decoration:none;margin-right:10px;">【登录】</a><a href="regiset.aspx" style="font-size:16px; color:black; text-decoration:none;margin-right:10px;">【注册】</a></span>
    <span id="dlh" runat="server" style="font-size:12px;"><span style="font-size:12px; color:black; margin-right:10px;"><font face="宋体">欢迎您！<asp:Label ID="Label2" runat="server" Text=""></asp:Label></font></span>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">退出</asp:LinkButton></span>
    <a href="grzx.aspx" style="font-size:12px; color:#0064c8; text-decoration:none; margin-left:10px">我的发布</a>
</div>