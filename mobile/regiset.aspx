<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regiset.aspx.cs" Inherits="mobile_regiset" %>

<%@ Register src="mobile_txlp_top.ascx" tagname="mobile_txlp_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" /><meta name="apple-mobile-web-app-capable" content="yes" /><meta name="format-detection" content="telephone=no" />
    <title>天下礼品-会员注册</title>
</head>
<body style="margin-bottom: 1px">
    <form id="form1" runat="server">
    <div>
    
        <uc1:mobile_txlp_top ID="mobile_txlp_top1" runat="server" />
    
    </div>
        <div style="text-align:left; padding-top:20px; margin:0px auto 0px auto;">
            <table width="100%" align="left">
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:100px;">
                        手机号码：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:100px;">
                        密码：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:100px;">
                        确认密码：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox3" TextMode="Password" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:100px;">
                        昵称：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:100px;">

                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        <a href="../xieyi.aspx" target="_blank" style="font-size:12px; color:#0064c8;">《注册协议》</a>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:100px;">

                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" />

                    </td>
                </tr>
                </table>
                </div>
    </form>
</body>
</html>
