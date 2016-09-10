<%@ Page Language="C#" AutoEventWireup="true" CodeFile="botton.aspx.cs" Inherits="botton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        var zhi = setInterval(land_bool, 5000);
        function land_bool()
        {
            $.ajax({
                type: 'post',
                contentType: "application/x-www-form-urlencoded; charset=UTF-8",
                url: 'bool_ajax.aspx',
                async: true,
                success: function (result) {
                    if (result == "0")
                    {
                        alert("您的账号已在其他地方被登录，您已下线！");
                        top.window.opener = null;
                        top.window.open("login.aspx", "_self");
                        top.window.close();
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
    <div style=" background-color:#4399de; height:34px; overflow:hidden; background-repeat:repeat-x;">
        <div style="padding-top:8px; padding-left:13px; clear:both;">
            <span style="font-size:12px; color:#ffffff;"><font face="微软雅黑">电子商务系统</font></span>
        </div>
    </div>
    </form>
</body>
</html>
