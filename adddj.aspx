<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adddj.aspx.cs" Inherits="adddj" %>

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
                <span style="font-size: 12px;"><font face="宋体">程序对接 > 新增对接</font></span>
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
                        &nbsp; 这里输入需要对接的数据库表的每一个字段名称，是中文名&nbsp; 用小写字母,区分</td>
                    </tr>
                    <tr>
                        <td class="td1">控件名称：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox2" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        &nbsp;
                            <br />
                            输入每个字段所需控件名称，供与前段与后端数据录入时使用，主要有文本框、下拉框、图片上传控件,详细信息框、&nbsp; 用小写字母,区分&nbsp;&nbsp; 如果选择下拉框则需要输入下拉框的数据源（即来源数据表）同时还要输入数据源字段名 例如：下拉框|admin/aname&nbsp; 下拉框代表控件名&nbsp; admin代表数据表&nbsp; aname代表数据表的字段名。</td>
                    </tr>
                    <tr>
                        <td class="td1">类型：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox3" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        &nbsp;如果是数字类型需要参与程序运算就输入int，反正varchar&nbsp; 用小写字母,区分</td>
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
                            输入标题，数据表，关联字段，所属字段&nbsp; 例如：价格|monery/chejia\zjiaoge</td>
                    </tr>
                    
                    <tr>
                        <td class="td1">用于搜索的字段：</td>
                        <td class="td2">
                            <asp:TextBox ID="TextBox4" CssClass="text1" TextMode="MultiLine" Width="300px" Height="150px" runat="server"></asp:TextBox>
                        &nbsp;用于后台查询的字段</td>
                    </tr>
                    <tr>
                        <td class="td1">&nbsp;</td>
                        <td class="td2">
                            <asp:Button ID="Button1" runat="server" Text="新增" CssClass="but1" OnClick="Button1_Click" />
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
