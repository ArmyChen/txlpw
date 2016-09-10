<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xgqx.aspx.cs" Inherits="xgqx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="js/jquery-1.7.1.min.js"></script>
<link href="css/mofei.css" rel="stylesheet" />
    <script src="js/mofei.js"></script>
    <script type="text/javascript">
        function get_time() {
            var myDate = new Date();
            var week;
            if (new Date().getDay() == 0) week = "星期日"
            if (new Date().getDay() == 1) week = "星期一"
            if (new Date().getDay() == 2) week = "星期二"
            if (new Date().getDay() == 3) week = "星期三"
            if (new Date().getDay() == 4) week = "星期四"
            if (new Date().getDay() == 5) week = "星期五"
            if (new Date().getDay() == 6) week = "星期六"

            document.getElementById("html_time").innerHTML = myDate.toLocaleString() + "&nbsp;" + week;
        }
        var zhi = setInterval(get_time, 1000);
        function add_zm() {
            location.href = "insertqx.aspx";
        }
        function djs(str1, str2)
        {
            if (str2 == "0")
            {
                if (document.getElementById("Label2").value.indexOf(str1) != -1) {
                    var zhi = str1 + ",";
                    var zhi1 = document.getElementById("Label2").value.replace(zhi, "");
                    document.getElementById("Label2").value = zhi1;
                }
                else {
                    document.getElementById("Label2").value += str1 + ",";
                }
            }
            else if (str2 == "1")
            {
                if (document.getElementById("Label3").innerText.indexOf(str1) != -1) {
                    var zhi = str1 + ",";
                    var zhi1 = document.getElementById("Label3").innerText.replace(zhi, "");
                    document.getElementById("Label3").innerText = zhi1;
                }
                else {
                    document.getElementById("Label3").innerText += str1 + ",";
                }
            }
            else if (str2 == "2") {
                if (document.getElementById("Label4").innerText.indexOf(str1) != -1) {
                    var zhi = str1 + ",";
                    var zhi1 = document.getElementById("Label4").innerText.replace(zhi, "");
                    document.getElementById("Label4").innerText = zhi1;
                }
                else {
                    document.getElementById("Label4").innerText += str1 + ",";
                }
            }
            else if (str2 == "3") {
                if (document.getElementById("Label5").innerText.indexOf(str1) != -1) {
                    var zhi = str1 + ",";
                    var zhi1 = document.getElementById("Label5").innerText.replace(zhi, "");
                    document.getElementById("Label5").innerText = zhi1;
                }
                else {
                    document.getElementById("Label5").innerText += str1 + ",";
                }
            }
            else if (str2 == "4") {
                if (document.getElementById("Label6").innerText.indexOf(str1) != -1) {
                    var zhi = str1 + ",";
                    var zhi1 = document.getElementById("Label6").innerText.replace(zhi, "");
                    document.getElementById("Label6").innerText = zhi1;
                }
                else {
                    document.getElementById("Label6").innerText += str1 + ",";
                }
            }
            else if (str2 == "5") {
                if (document.getElementById("Label7").innerText.indexOf(str1) != -1) {
                    var zhi = str1 + ",";
                    var zhi1 = document.getElementById("Label7").innerText.replace(zhi, "");
                    document.getElementById("Label7").innerText = zhi1;
                }
                else {
                    document.getElementById("Label7").innerText += str1 + ",";
                }
            }
        }
        function qs() {
            var zhi = document.getElementById("qxz").value;
            if (zhi == "") {
                alert("请输入权限组名称！");
            }
            else {
                $.ajax({
                    type: 'post',
                    contentType: "application/x-www-form-urlencoded; charset=UTF-8",
                    url: 'update_qx.aspx',
                    //data: "id:" + escape($("#t1").val()) + "&zhi:" + escape(zhi) + "&in1:" + escape(document.getElementById("Label2").innerText) + "&up:" + escape(document.getElementById("Label3").innerText) + "&de:" + escape(document.getElementById("Label4").innerText) + "&se:" + escape(document.getElementById("Label5").innerText) + "&sh:" + escape(document.getElementById("Label6").innerText) + "&gj:" + escape(document.getElementById("Label7").innerText) + "",
                    data: { id: $("#t1").val(), zhi: zhi, in1:$("#Label2").val(), up: document.getElementById("Label3").innerText, de: document.getElementById("Label4").innerText, se: document.getElementById("Label5").innerText, sh: document.getElementById("Label6").innerText, gj: document.getElementById("Label7").innerText },
                    async: true,
                    success: function (result) {
                        if (result == "修改成功") {
                            alert("修改成功");
                            window.location.href = "qx.aspx";
                        }
                        else {
                            alert(result);
                        }
                    },
                    error: function () {
                        setContainer('ERROR!');
                    }
                });
            }
        }
        function qs11123()
        {
            var zhi = document.getElementById("qxz").value;
            if(zhi=="")
            {
                alert("请输入权限组名称！");
            }
            else
            {
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
                        alert("fdsa")
                        //if (fanhui == "修改成功") {
                        //    alert(fanhui);
                        //    window.location.href = "qx.aspx";
                        //}
                        //else {
                        //    alert(fanhui);
                        //}
                        alert(fanhui);
                    }
                }
                xmlhttp.open("POST", "update_qx.aspx?id="+escape(document.getElementById("t1").value)+"&zhi=" + escape(zhi) + "&in="+escape(document.getElementById("Label2").innerText)+"&up="+escape(document.getElementById("Label3").innerText)+"&de="+escape(document.getElementById("Label4").innerText)+"&se="+escape(document.getElementById("Label5").innerText)+"&sh="+escape(document.getElementById("Label6").innerText)+"&gj="+escape(document.getElementById("Label7").innerText)+"", true); //编译字符串，反乱码
                xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
                xmlhttp.send();
            }
        }
    </script>
</head>
<body style="background-color:#f1f1f1;">
    <form id="form1" runat="server">
    <div>
        <div style="padding:10px 0px 15px 28px; background-color:#f5f5f5; position:relative; z-index:1; border-bottom:1px solid #d1d1d1; clear:both;">
            <img src="images/fangzi.jpg" style="vertical-align:middle;" />
            <span style="font-size:12px; color:#464646; vertical-align:middle;"><font face="宋体">您当前的位置：OA功能首页 > 权限管理</font></span>
            <span style="font-size:12px; color:#464646;position:absolute; top:13px; right:25px; z-index:999; vertical-align:middle;"><font face="宋体"><span id="html_time">正在加载...</span></font></span>
        </div>
        <div style="padding:20px; clear:both;">
            <div style="background-color:white;">
                <div style="border-top:4px solid #00a5a5;">
                    <div style="padding:9px 0px 10px 20px; border-bottom:1px solid #e5e5e5; clear:both;">
                        <span style="font-size:14px; color:#464646; vertical-align:middle;"><font face="微软雅黑"><b>修改权限组</b></font></span>
                    </div>

                    <div style="min-height:370px;border:1px solid #e5e5e5; border-top:0px;">
                        <div style="padding:10px; clear:both;">
                            <div style="height:460px; background-color:#f1f1f1; overflow:scroll;">
                                <table width="100%">
                                    <tr>
                                        <td class="oatd1">

                                            权限组名称：</td>
                                        <td class="oatd2">
                                            <input id="qxz" runat="server" type="text" class="text1" />
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">

                                            选择权限：</td>
                                        <td class="oatd2" style="padding:20px;">

                                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">

                                            </td>
                                        <td class="oatd2" style="padding:20px;">
                                            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                                            <span style="display:none;">
                                            
                                            <input id="Label2" runat="server" type="text" />
                                            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

                                            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

                                            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>

                                            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>

                                            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                                                <input id="t1" runat="server" type="text" class="text1" />
                                            </span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">

                                        </td>
                                        <td class="oatd2">
                                            <input type="button" class="button1" value="修改权限组" onclick="qs()" />
                                        &nbsp;&nbsp;
                                            <asp:Button ID="Button2" runat="server" Text="返回" CssClass="button1" OnClick="Button2_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>