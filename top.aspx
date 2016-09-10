<%@ Page Language="C#" AutoEventWireup="true" CodeFile="top.aspx.cs" Inherits="top" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image:url(tcimg/t1.jpg); height:111px; overflow:hidden; background-repeat:repeat-x;">
        <div style="padding:15px 0px 0px 295px; position:relative; z-index:1; clear:both;">
            <%--<a href="index.aspx" style="position:absolute; top:20px; left:15px; z-index:9;" target="_blank"><img src="images/logo.png" style=" height:60px;" /></a>--%>
            <a href="shouye.aspx" target="midFrame"><img src="tcimg/index.png" style="margin-right:40px;height:70px;" /></a>

    <%--        <a target="midFrame"><img src="tcimg/mkgl.png" style="margin-right:40px;height:70px;" /></a>
            <a target="midFrame"><img src="tcimg/sjk.png" style="margin-right:40px;height:70px;" /></a>
            <a target="midFrame"><img src="tcimg/dj.png" style="margin-right:40px;height:70px;" /></a>--%>
            <a href="Login.aspx" target="_parent"><img src="tcimg/tc.png" style="margin-right:40px;height:70px;" /></a>
            
        </div>
    </div>
    </form>
</body>
</html>
