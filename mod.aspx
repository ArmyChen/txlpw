<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mod.aspx.cs" Inherits="mod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style="padding:10px; clear:both;">
            <div style="padding-bottom:10px; clear:both; border-bottom:2px solid #186a6d">
                <span style="font-size:12px;"><font face="宋体">系统设置 > 网站模块管理（展示体）</font></span>
            </div>
        <div style="padding-top:10px; clear:both;">
        <table width="100%" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width:150px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">模块名称</font></span>
                    </div>
                </td>
                <td style="width:100px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">栏目类型</font></span>
                    </div>
                </td>
                <td style="width:50px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">排序</font></span>
                    </div>
                </td>
                <td style="width:100px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">数据源</font></span>
                    </div>
                </td>
                <td style="width:100px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">类型</font></span>
                    </div>
                </td>
                <td style="width:200px; text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; font-size:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">后台地址</font></span>
                    </div>
                </td>
                <td style="text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #186a6d; background-repeat:repeat-x;">
                    <div style="padding-top:0px; clear:both; text-align:center;">
                        <span style="font-size:12px; color:#0e494b"><font face="宋体">操作</font></span>
                    </div>
                </td>
            </tr>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </table>
        </div>
        <div style="padding-top:10px; clear:both;">

            <asp:Button ID="Button1" runat="server" CssClass="but1" Text="新增" OnClick="Button1_Click" />

        </div>
        </div>
    </div>
    </form>
</body>
</html>
