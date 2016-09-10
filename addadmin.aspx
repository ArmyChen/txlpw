<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addadmin.aspx.cs" Inherits="addadmin" %>

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
        <div style="padding: 5px; font-size: 12px; color: #232323; border-bottom: 2px solid #0f89a7;clear: both;">
            <font face="宋体">
                系统管理员&nbsp;>&nbsp;新增管理员</font>
        </div>
    <div style="padding-top:10px; clear:both;">
        <table width="100%">
            <tr>
                <td class="td1">

                    管理员账号：</td>
                <td class="td2">

                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="td1">

                    管理员密码：</td>
                <td class="td2">

                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="td1">

                    管理员身份：</td>
                <td class="td2">

                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="td1">

                </td>
                <td class="td2">

                    <asp:Button ID="Button1" runat="server" Text="新增" OnClick="Button1_Click" style="height: 21px" />

                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
