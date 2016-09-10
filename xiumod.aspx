<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xiumod.aspx.cs" Inherits="xiumod" %>

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
        <div style="padding: 10px; clear: both;">
            <div style="padding-bottom: 10px; clear: both; border-bottom: 2px solid #186a6d">
                <span style="font-size: 12px;"><font face="宋体">系统设置 > 修改模块</font></span>
            </div>
            <div style="padding-top: 10px; clear: both;">
                <table width="100%">
                    <tr>
                        <td class="td1">

                            模块名称：</td>
                        <td class="td2">

                            <asp:TextBox ID="TextBox1" CssClass="text1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">

                            模块类型：</td>
                        <td class="td2">

                            <asp:DropDownList ID="DropDownList1" CssClass="d1" runat="server">
                                <asp:ListItem>系统设定</asp:ListItem>
                                <asp:ListItem>自定义</asp:ListItem>
                            </asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">

                            模块等级：</td>
                        <td class="td2">

                            <asp:DropDownList ID="DropDownList2" CssClass="d1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                <asp:ListItem>父栏目</asp:ListItem>
                                <asp:ListItem>子栏目</asp:ListItem>
                            </asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">

                            上级模块：</td>
                        <td class="td2">

                            <asp:DropDownList ID="DropDownList3" CssClass="d1" runat="server">
                            </asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">

                            模块排序：</td>
                        <td class="td2">

                            <asp:TextBox ID="TextBox2" CssClass="text1" runat="server">0</asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">

                            后台地址：</td>
                        <td class="td2">

                            <asp:TextBox ID="TextBox3" CssClass="text1" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">

                            数据源：</td>
                        <td class="td2">

                            <asp:DropDownList ID="DropDownList4" CssClass="d1" runat="server">
                            </asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">

                        </td>
                        <td class="td2">

                            <asp:Button ID="Button1" runat="server" Text="修改" CssClass="but1" OnClick="Button1_Click" />

                        &nbsp;
                            <asp:Button ID="Button2" runat="server" Text="返回" CssClass="but1" OnClick="Button2_Click" />

                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    </form>
</body>
</html>