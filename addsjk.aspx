<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addsjk.aspx.cs" Inherits="addsjk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
    <script type="text/javascript">
        function xz()
        {
            var bm = document.getElementById("bm").value;
            var dm = document.getElementById("Label2").innerText;
            if (bm == "")
            {
                alert("请输入表名");
            }
            else if (dm == "") {
                alert("请选择字段进行添加");
            }
            else {
                var xmlhttp;
                if (window.XMLHttpRequest) {
                    xmlhttp = new XMLHttpRequest();
                }
                else {
                    xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
                }
                xmlhttp.onreadystatechange = function () {
                    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                        var fanhui = xmlhttp.responseText;
                        if (fanhui == "创建成功") {
                            alert("创建成功");
                            window.location.href = "sjk.aspx";
                        }
                        else {
                            alert(fanhui);
                        }
                    }
                }
                xmlhttp.open("POST", "scb.aspx?bm1=" + escape(bm) + "&dm1=" + escape(dm) + "", true); //编译字符串，反乱码
                xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
                xmlhttp.send();
            }
        }
        function tj()
        {
            var mc = document.getElementById("zd").value;

            var ddl = document.getElementById("DropDownList1")
            var index = ddl.selectedIndex;
            var Value = ddl.options[index].value;

            var ddl1 = document.getElementById("DropDownList2")
            var index1 = ddl1.selectedIndex;
            var Value1 = ddl1.options[index1].value;

            var dm = document.getElementById("Label2").innerText;
            if (mc == "")
            {
                alert("字段名不能为空！");
            }
            else {
                if (dm.indexOf(mc) != -1) {
                    alert("该字段已存在，请重新命名！");
                }
                else {
                    document.getElementById("Label2").innerText += mc + " " + Value + ",";
                    document.getElementById("Label1").innerHTML += mc + "<br/>";
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px; clear: both;">
            <div style="padding-bottom: 10px; clear: both; border-bottom: 2px solid #186a6d">
                <span style="font-size: 12px;"><font face="宋体">数据库管理 > 新增数据库</font></span>
            </div>
            <div style="padding-top: 10px; clear: both;">
                <table width="100%">
                    <tr>
                        <td class="td1">
                            表名：
                        </td>
                        <td class="td2">
                            <input type="text" id="bm" runat="server" class="text1" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td1">
                            字段：</td>
                        <td class="td2">
                            <input type="text" id="zd" runat="server" class="text1" /> 类型：<asp:DropDownList ID="DropDownList1" CssClass="d1" runat="server">
                                <asp:ListItem>int</asp:ListItem>
                                <asp:ListItem>varchar(500)</asp:ListItem>
                                <asp:ListItem>varchar(MAX)</asp:ListItem>
                                <asp:ListItem>datetime</asp:ListItem>
                                <asp:ListItem>decimal(18, 2)</asp:ListItem>
                                <asp:ListItem>float</asp:ListItem>
                                <asp:ListItem>ntext</asp:ListItem>
                            </asp:DropDownList>
                        &nbsp;是否主键:<asp:DropDownList ID="DropDownList2" CssClass="d1" runat="server">
                                <asp:ListItem>否</asp:ListItem>
                                <asp:ListItem>是</asp:ListItem>
                            </asp:DropDownList>
                        &nbsp;
                            <input type="button" class="d1" value="添加" onclick="tj()" />
                        </td>
                    </tr>
                    <tr>
                        <td class="td1">
                            已选择字段：</td>
                        <td class="td2">

                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">
                            生成代码：</td>
                        <td class="td2">

                            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="td1">
                            &nbsp;</td>
                        <td class="td2">

                            <input type="button" value="新增" onclick="xz()" class="but1" />

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
