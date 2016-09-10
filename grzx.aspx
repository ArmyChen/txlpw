<%@ Page Language="C#" AutoEventWireup="true" CodeFile="grzx.aspx.cs" ValidateRequest="false" Inherits="grzx" %>

<%@ Register src="tx_top.ascx" tagname="tx_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>编辑信息-天下礼品</title>
    <script type="text/javascript" charset="utf-8" src="ueditor.config.js"></script>
    <script type="text/javascript" charset="utf-8" src="ueditor.all.min.js"> </script>
    
    <!--建议手动加在语言，避免在ie下有时因为加载语言失败导致编辑器加载失败-->
    <!--这里加载的语言文件会覆盖你在配置项目里添加的语言类型，比如你在配置项目里配置的是英文，这里加载的中文，那最后就是中文-->
    <script type="text/javascript" charset="utf-8" src="lang/zh-cn/zh-cn.js"></script>
    <style type="text/css">
        table {
            border-collapse:collapse;
        }
    </style>
    <script type="text/javascript">
        var ue = UE.getEditor('a1');
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>

            <uc1:tx_top ID="tx_top1" runat="server" />

        </div>
        <div style="text-align:center; margin:0px auto 0px auto;">
            <table width="1000px" align="center">
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        标题：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox1" runat="server" Width="284px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        所在城市：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        产品图片：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button ID="Button1" runat="server" Text="上传" OnClick="Button1_Click" />

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        图片展示：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:Image ID="Image1" Height="150px" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        QQ：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        详情：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        联系电话：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                        详细介绍：</td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">
                        <textarea id='a1' runat="server" style='width:100%;height:500px;'></textarea>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right; font-size:12px; color:black; padding:8px 5px 7px 0px; width:200px;">

                    </td>
                    <td style="text-align:left; font-size:12px; color:black; padding:8px 5px 7px 0px;">

                        <asp:Button ID="Button2" runat="server" Text="编辑" OnClick="Button2_Click" />

                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>