<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sjdj.aspx.cs" Inherits="sjdj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding: 10px; clear: both;">
            <div style="padding-bottom: 10px; clear: both; border-bottom: 2px solid #186a6d">
                <span style="font-size: 12px;"><font face="宋体">系统设置 > 数据对接（CPU）</font></span>
            </div>
        <div style="padding-top:10px; clear:both;">
        <table width="100%" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width:100px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">数据表名称</font></span>
                    </div>
                </td>
                <td style="width:100px;text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">对接名称</font></span>
                    </div>
                </td>
                <td style="width:300px;text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">字段名称</font></span>
                    </div>
                </td>
                <td style="text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">对接控件</font></span>
                    </div>
                </td>
                <td style="width:100px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">更新时间</font></span>
                    </div>
                </td>
                <td style="width:100px;text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">操作</font></span>
                    </div>
                </td>
            </tr>
            <asp:Repeater ID="dj" runat="server">
                <ItemTemplate>
                    <tr>
                <td style="width:100px; text-align:center;  background-color:white;border:1px solid #186a6d;">
                    <div style="padding-top:7px; padding-bottom:7px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#323232"><font face="宋体"><%#Eval("sjk") %></font></span>
                    </div>
                </td>
                <td style="width:100px;text-align:center;  background-color:white; border:1px solid #186a6d;">
                    <div style="padding-top:7px; padding-bottom:7px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#323232"><font face="宋体"><%#Eval("zwm") %></font></span>
                    </div>
                </td>
                <td style="width:300px;text-align:center;  background-color:white; border:1px solid #186a6d;">
                    <div style="padding-top:7px; padding-bottom:7px;  font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#323232"><font face="宋体"><%#Eval("fieldnames") %></font></span>
                    </div>
                </td>
                <td style="text-align:center; background-color:white; border:1px solid #186a6d;">
                    <div style="padding-top:7px; padding-bottom:7px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#323232"><font face="宋体"><%#Eval("kongjian") %></font></span>
                    </div>
                </td>
                <td style="width:100px; text-align:center; background-color:white; border:1px solid #186a6d;">
                    <div style="padding-top:7px; padding-bottom:7px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#323232"><font face="宋体"><%#Eval("ftime") %></font></span>
                    </div>
                </td>
                <td style="width:100px;text-align:center; background-color:white; border:1px solid #186a6d;">
                    <div style="padding-top:7px; padding-bottom:7px; font-size:0px; clear:both; text-align:center;">
                        <a href="xgdj.aspx?cid=<%#Eval("cid") %>" style="font-size:12px; color:#323232; margin-right:10px;"><font face="宋体">修改</font></a>

                        <a href="sjdj.aspx?cid=<%#Eval("cid") %>" style="font-size:12px; color:#323232"><font face="宋体">删除</font></a>
                    </div>
                </td>
            </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
       </div>
        <div style="padding-top:10px; clear:both;">
            <asp:Button ID="Button1" runat="server" Text="新增" CssClass="but1" OnClick="Button1_Click" />
        </div>
    </div>
    </form>
</body>
</html>
