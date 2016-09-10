<%@ Control Language="C#" AutoEventWireup="true" CodeFile="mobile_txlp_top.ascx.cs" Inherits="mobile_mobile_txlp_top" %>
<style type="text/css">
    body {
        padding: 0px;
        margin: 0px;
    }
    table {
        border-collapse: collapse;
    }
</style>
<div style="text-align:center; margin:0px auto 0px auto;">
    <div style="padding:10px; clear:both; text-align:left; font-size:1.1em; color:white; background-color:#f86d10;">
        <b>天下礼品</b>
        <span id="dlq" runat="server"><a href="land.aspx" style="font-size:1.0em; color:white; text-decoration:none;margin-right:10px;">【登录】</a><a href="regiset.aspx" style="font-size:1.0em; color:white; text-decoration:none;margin-right:10px;">【注册】</a></span>
    <span id="dlh" runat="server" style="font-size:1.0em;"><span style="font-size:16px; color:white; margin-right:10px;"><font face="宋体">欢迎您！<asp:Label ID="Label2" runat="server" Text=""></asp:Label></font></span>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">退出</asp:LinkButton></span>
    </div>

        <div style="padding:10px; background-color:#aa0f0f; font-size:1.1em; color:white; clear:both; text-align:center;">
            <a href="fabu.aspx" style="font-size:1.1em; color:white; text-decoration:none;"><b>免费发布信息</b></a>
    </div>
    <div style="padding:10px 0px 10px 10px; margin-bottom:0px; border-bottom:1px solid #e96e30; background-color:#fce7d8; text-align:left;; position:relative; z-index:1; clear:both;">
    <span style="font-size:16px; color:red; font-weight:bold;"><a href="city.aspx" style="font-size:16px; color:red; font-weight:bold; text-decoration:none;"><font face="微软雅黑">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></font></a></span><a href="city.aspx" style="font-size:16px; color:blue; font-weight:bold; text-decoration:none;"><font face="微软雅黑">[切换城市]</font></a>
    <a href="index.aspx" style="font-size:16px; color:blue; font-weight:bold; text-decoration:none; margin-left:10px;"><font face="微软雅黑">返回首页</font></a><br />
   
    
</div>


</div>
