<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regiset.aspx.cs" Inherits="regiset" %>

<%@ Register src="tx_top.ascx" tagname="tx_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>会员注册</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:tx_top ID="tx_top1" runat="server" />
    
    </div>
        <div>
            <div style="text-align:center; margin:0px auto 0px auto;">
            <table width="1000px" align="center">
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">
                        手机号码：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox1" runat="server" Width="284px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">
                        密码：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox2" TextMode="Password" runat="server" Width="284px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">
                        确认密码：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox3" TextMode="Password" runat="server" Width="284px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">
                        昵称：
                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox4" runat="server" Width="284px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        <a href="xieyi.aspx" target="_blank" style="font-size:12px; color:#0064c8;">《注册协议》</a>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" />

                    </td>
                </tr>
                </table>
                </div>
        </div>
    </form>
</body>
</html>

