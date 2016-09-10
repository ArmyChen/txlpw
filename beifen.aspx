<%@ Page Language="C#" AutoEventWireup="true" CodeFile="beifen.aspx.cs" Inherits="beifen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
    <style type="text/css">
        div {
            padding-left: 5px;
            padding-right: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px; clear: both;">
            <div style="padding-bottom: 10px; clear: both; border-bottom: 2px solid #186a6d">
                <span style="font-size: 12px;"><font face="宋体">会员管理 > 数据备份</font></span>
            </div>
            <div style="padding-top: 10px; clear: both;">
                <table width="100%">
                    <tr>
                        <td class="td1">

                        </td>
                        <td class="td2">

                            <asp:Button ID="Button1" runat="server" CssClass="but1s" Text="点击备份" OnClick="Button1_Click" />

                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>