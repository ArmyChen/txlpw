<%@ Page Language="C#" AutoEventWireup="true" CodeFile="backstage_system.aspx.cs" Inherits="backstage_system" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
    <script type="text/javascript">

        function dj(str1, str2)
        {
            if (str1.checked) {
                document.getElementById("scz").value += str2 + ",";
            }
            else {
                var zhi1 = document.getElementById("scz").value;
                var zhi2 = str2 + ",";
                var zhi3 = zhi1.replace(zhi2, "");
                document.getElementById("scz").value = zhi3;
            }
        }
        function sc()
        {
            var str = document.getElementById("scz").value;
            var id = document.getElementById("mk").value;
            if (str == "")
            {
                alert("请至少勾选一处进行删除！");
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
                        if (fanhui == "删除成功") {
                            alert("删除成功");
                            window.location.href = "backstage_system.aspx?mid="+id+"";
                        }
                        else {
                            alert(fanhui);
                        }
                    }
                }
                xmlhttp.open("POST", "delete_backstage.aspx?str=" + escape(str) + "&mid="+id+"", true); //编译字符串，反乱码
                xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
                xmlhttp.send();
            }
        }
    </script>
    <style type="text/css">
        div {
            padding-left: 5px;
            padding-right: 5px;
        }
    </style>
</head>
<body style="background-color:white;">
    <form id="form1" runat="server">
        <div>
            <div style="height:30px; overflow:hidden; background-color:#e5e6e6;">
                <div style="padding-top:3px; clear:both;">
                    <span style="font-size:12px; color:#323232; vertical-align:middle;"><font face="宋体">请输入关键词：</font></span>
                    <input id="ss" runat="server" class="text1" style="width:150px;padding-top:3px; padding-bottom:3px;" />
                    <asp:ImageButton ID="ImageButton1" CssClass="d1" ImageUrl="tcimg/ss.jpg" runat="server" OnClick="ImageButton1_Click" />
                    &nbsp;<asp:ImageButton ID="ImageButton6" CssClass="d1" ImageUrl="tcimg/xz.jpg" runat="server" OnClick="ImageButton6_Click" />
                    <span style="cursor:pointer;" onclick='sc()'><img src="tcimg/sc.jpg" style="vertical-align:middle;" /></span>
                    <asp:ImageButton ID="ImageButton2" CssClass="d1" ImageUrl="tcimg/sy.jpg" runat="server" OnClick="ImageButton2_Click" />
                    <asp:ImageButton ID="ImageButton3" CssClass="d1" ImageUrl="tcimg/syy.jpg" runat="server" OnClick="ImageButton3_Click" />
                    <asp:ImageButton ID="ImageButton4" CssClass="d1" ImageUrl="tcimg/xyy.jpg" runat="server" OnClick="ImageButton4_Click" />
                    <asp:ImageButton ID="ImageButton5" CssClass="d1" ImageUrl="tcimg/wy.jpg" runat="server" OnClick="ImageButton5_Click" />
                    <span style="font-size:12px; color:#323232; vertical-align:middle;"><font face="宋体">跳转到：</font></span>
                    <input id="tz" runat="server" style="width:50px;padding-top:3px; padding-bottom:3px;" value="1" class="text1" />
                    <asp:ImageButton ID="ImageButton8" CssClass="d1" ImageUrl="tcimg/tz.jpg" runat="server" OnClick="ImageButton8_Click" />
                    <span style="font-size:12px; color:#323232; vertical-align:middle;">
                        总共：<asp:Label ID="Label4" runat="server" Text=""></asp:Label>页，共<asp:Label ID="Label5" runat="server" Text=""></asp:Label>条信息，当前第：<asp:Label ID="Label6" runat="server" Text="1"></asp:Label>页</font></span>
                </div>
            </div>
            <div style="padding: 10px; background-color:white; clear: both;">
                <div style="padding-bottom: 10px; clear: both; border-bottom: 2px solid #888a8b">
                    <span style="font-size: 12px;"><font face="宋体"><asp:Label ID="Label1" runat="server" Text=""></asp:Label> > <asp:Label ID="Label2" runat="server" Text=""></asp:Label></font></span><input type="text" id="scz" style="display:none;" /><input type="text" id="mk" runat="server" style="display:none;" />
                </div>
                <div style="padding-top:10px; height:420px; overflow:scroll;">
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
