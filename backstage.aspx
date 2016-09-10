<%@ Page Language="C#" AutoEventWireup="true" CodeFile="backstage.aspx.cs" Inherits="backstage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>电子商务系统</title>
</head>
<frameset rows="110px,*,34px" cols="*" frameborder="no" border="0px" framespacing="0" id="Frames" > 
  <frame name="topFrame" scrolling="no" noresize src="top.aspx" frameborder="0px">
  <frameset id="myFrame" cols="170px,*" frameborder="NO" border="0px" framespacing="0"> 
    <frame name="leftFrame" noresize scrolling="auto" src="left.aspx" frameborder="0px">
	<frame name="midFrame" noresize scrolling="auto" src="shouye.aspx" frameborder="0px">    
  </frameset>
  <frame name="bottom" noresize scrolling="no" src="botton.aspx" frameborder="0px"> 
</FRAMESET>
<noframes> 
</noframes>
</html>
