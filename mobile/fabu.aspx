<%@ Page Language="C#" AutoEventWireup="true" CodeFile="fabu.aspx.cs" Inherits="mobile_fabu" %>

<%@ Register src="mobile_txlp_top.ascx" tagname="mobile_txlp_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" /><meta name="apple-mobile-web-app-capable" content="yes" /><meta name="format-detection" content="telephone=no" />
    <title>天下礼品-信息发布</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:mobile_txlp_top ID="mobile_txlp_top1" runat="server" />
    
    </div>
        <div style="text-align:left; width:100%; overflow:hidden; margin:0px auto 0px auto;">
            <table width="100%" align="left">
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; min-width:100px;">

                        标题：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                        所在城市：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                        产品图片：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                        <asp:Button ID="Button1" runat="server" Text="上传" OnClick="Button1_Click" />

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                        图片展示：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:Image ID="Image1" Height="150px" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                        QQ：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                        联系人：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                        联系电话：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                        详细介绍：</td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">
                        <textarea id='a1' runat="server" style='height:100px;'></textarea>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:1.1em; color:black; padding:8px 5px 7px 0px; width:300px;">

                    </td>
                    <td style="text-align:left; font-size:1.1em; color:black; padding:8px 5px 7px 0px;">

                        <asp:Button ID="Button2" runat="server" Text="确认发布" OnClick="Button2_Click" style="height: 21px" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
