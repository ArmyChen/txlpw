<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add_backstage.aspx.cs" ValidateRequest="false" Inherits="add_backstage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" charset="utf-8" src="ueditor.config.js"></script>
    <script type="text/javascript" charset="utf-8" src="ueditor.all.min.js"> </script>
    
    <!--建议手动加在语言，避免在ie下有时因为加载语言失败导致编辑器加载失败-->
    <!--这里加载的语言文件会覆盖你在配置项目里添加的语言类型，比如你在配置项目里配置的是英文，这里加载的中文，那最后就是中文-->
    <script type="text/javascript" charset="utf-8" src="lang/zh-cn/zh-cn.js"></script>
    <script type="text/javascript">
        function fh(str)
        {
            window.location.href = "backstage_system.aspx?mid="+str;
        }
        function sc(str) {
            alert(str);
        }
        function djd(str) {

            var shu = new Array();
            shu = str.split(',');
            var dizhi = "";
            for (var i = 0; i < shu.length - 1; i++) {
                if (i == shu.length - 1) {
                    dizhi += shu[i];
                }
                else {
                    dizhi += shu[i] + "\\";
                }
            }
            document.getElementById("Label6").innerText = dizhi;
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
                    document.getElementById("Label5").innerHTML = fanhui;
                }
            }
            xmlhttp.open("POST", "xmm.aspx?str=" + escape(document.getElementById("Label6").innerText) + "", true); //编译字符串，反乱码
            xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            xmlhttp.send();
        }
        function scc()
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
                    alert(fanhui);
                }
            }
            xmlhttp.open("POST", "xmmm.aspx?str=" + escape(document.getElementById("Label6").innerText) + "", true); //编译字符串，反乱码
            xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            xmlhttp.send();
        }
        function add_bac(str) {
            var zhi = document.getElementById("qz").value;
            var shu1 = new Array();
            shu1 = zhi.split(',');
            var zhis = "";
            for (var i = 0; i < shu1.length - 1; i++) {
                var shu2 = new Array();
                shu2 = shu1[i].split('|');
                var id = shu2[0];
                var lei = shu2[1];
                if (lei == "文本框") {
                    zhis += document.getElementById(id).value + "[,]";
                }
                else if (lei == "详细信息框") {
                    //var zhi2 = new Array();
                    //zhi2 = id.split('_');
                    //var zhi1 = zhi2[1];
                    //var html1 =$(document.getElementsByTagName('iframe')[zhi1].contentWindow.document.body).html();
                    //zhis += html1 + "[,]";
                    var arr = [];
                    arr.push(UE.getEditor(id).getContent());
                    var spxq = arr.join("\n");
                    zhis += spxq + "[,]";
                }
                else if (lei == "下拉框") {
                    var obj = document.getElementById(id); //定位id

                    var index = obj.selectedIndex; // 选中索引

                    var text = obj.options[index].text; // 选中文本

                    var value = obj.options[index].value; // 选中值
                    zhis += value + "[,]";
                }
                else if (lei == "图片上传控件") {
                    var arr = [];
                    arr.push(UE.getEditor(id).getContent());
                    var spxq = arr.join("\n");
                    zhis += spxq + "[,]";
                }
            }
            $.ajax({
                type: 'post',
                contentType: "application/x-www-form-urlencoded; charset=UTF-8",
                url: 'add_ajax.aspx',
                data: { str: zhis, mid: str },
                async: true,
                success: function (result) {
                    if (result == "新增成功") {
                        alert("新增成功！");
                        window.location.href = "backstage_system.aspx?mid=" + str;
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
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="padding: 10px; clear: both;">
                <div style="padding-bottom: 10px; clear: both; border-bottom: 2px solid #186a6d">
                    <span style="font-size: 12px;"><font face="宋体"><asp:Label ID="Label1" runat="server" Text=""></asp:Label> > 新增<asp:Label ID="Label2" runat="server" Text=""></asp:Label></font></span><input type="text" id="scz" style="display:none;" /><input type="text" id="mk" runat="server" style="display:none;" /><input type="text" id="qz" runat="server" style=" display:none;" />
                </div>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <div style="padding-top:10px; clear:both;">
                    <table width="100%">
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </table>
                </div>
            </div>
    </div>
        <div style="width:434px; display:none; position:absolute; top:30px; left:350px; cursor:move; border:1px solid #6f6868; background-color:#c6c4c4; z-index:999;">
            <div style="background-color:#6b5959; padding:8px 0px 8px 13px; clear:both;">
                <span style="font-size:14px; color:#ffffff;"><font face="微软雅黑"><b>选择图片上传</b></font></span>
            </div>
            <div style="padding:5px; clear:both;">
                <div style="height:235px; border:1px solid #756e6e; background-color:white; overflow-y:auto;">
                    <div style="padding:10px; overflow:hidden; clear:both;">
                        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div style="padding-top:10px; clear:both;">
                    <span style="font-size:14px; color:#606262;"><font face="微软雅黑"><b><asp:Label ID="Label6" runat="server" Text="D:\\"></asp:Label></b></font></span>
                </div>
                <div style="padding-top:10px; clear:both;">
                    <img src="images/sc.jpg" style="cursor:pointer;" onclick="scc()" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
