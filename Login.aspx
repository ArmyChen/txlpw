<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>电子商务系统</title>
    <link href="css/style.css" rel="stylesheet" />
    <script type="text/javascript">
        function hdl() {
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
                    if (fanhui == "登录成功") {
                        alert("登录成功");
                        window.location.href = 'backstage.aspx';
                    }
                    else {
                        alert(fanhui);
                    }
                }
            }
            xmlhttp.open("POST", "hdl.aspx?as1=" + escape(document.getElementById('as1').value) + "&as2=" + escape(document.getElementById('as2').value) + "", true); //编译字符串，反乱码
            xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            xmlhttp.send();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height:600px; background-image:url(tcimg/logobei.jpg); text-align:center; margin:0px auto 0px auto; background-repeat:repeat-x;">
        <div style="width:525px; margin:0px auto 0px auto; text-align:left;">
            <div style="padding-top:45px; clear:both; text-align:center;">
                &nbsp;</div>
            <div style="padding-top:100px; clear:both;">
                <div style="height:314px; background-image:url(tcimg/xb.jpg); position:relative; z-index:1; background-repeat:no-repeat; overflow:hidden;">
                    <input id="as1" class="yhm" />
                    <input id="as2" class="mm" type="password" />
                    <img src="tcimg/logobut.png" class="b1" style="cursor:pointer;" onclick="hdl()" />
                    
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
