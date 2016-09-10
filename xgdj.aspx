<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xgdj.aspx.cs" Inherits="xgdj" %>

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
                <span style="font-size: 12px;"><font face="宋体">程序对接 > 修改对接</font></span>
            </div>
            <div style="padding-top: 10px; clear: both;">
                <table width="100%">
                    <tr>
                        <td class="td1">数据库名称：
                        </td>
                        <td class="td2">
                            <input type="text" id="bm" runat="server" class="text1" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td1">对接名称：</td>
                        <td class="td2">
                            <input type="text" id="djmc" runat="server" class="text1" /></td>
                    </tr>
                    <tr>
                        <td class="td1">字段名称：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox1" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="td1">控件名称：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox2" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="td1">类型：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox3" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td1">前台字段名称：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox5" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td1">前台控件名称：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox6" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="td1">前台类型：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox7" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="td1">前台搜索：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox8" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="td1">搜索字段：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox4" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="td1">&nbsp;</td>
                        <td class="td2">
                            <asp:Button ID="Button1" runat="server" Text="修改" CssClass="but1" OnClick="Button1_Click" />
                        &nbsp;
                            <asp:Button ID="Button2" runat="server" Text="返回" CssClass="but1" OnClick="Button2_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
