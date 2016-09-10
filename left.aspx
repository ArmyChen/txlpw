<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        function qh(str)
        {
            var cl = "a" + str;
            $("." + cl).slideToggle(500);
        }
        function yd(str)
        {
            var id = "b" + str;
            document.getElementById(id).style.backgroundColor = "#d2e7f7";
        }
        function yk(str) {
            var id = "b" + str;
            document.getElementById(id).style.backgroundColor = "#ffffff";
        }
    </script>
</head>
<body style="background-color:#d2d3d4; height:auto;">
    <form id="form1" runat="server">
    <div>
        <div style="width:170px; text-align:center; padding:7px 0px 7px 0px; clear:both; font-size:14px; background-color:#e5e6e6;">
            <span style="color:#323232;"><font face="黑体">控制面板</font></span>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
