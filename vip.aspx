<%@ Page Language="C#" AutoEventWireup="true" CodeFile="vip.aspx.cs" Inherits="vip" %>
<!DOCTYPE html>
<html lang="en"> 
<head>
	<meta charset="utf-8">
	<title>立游</title>
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
  	<link rel="stylesheet" href="ysb/zerogrid.css">
	<link rel="stylesheet" href="ysb/style.css">
    <link rel="stylesheet" href="ysb/responsive.css">
</head>
<body>
	<header>
    	<span class="icon23"><a href="usercenter.aspx"><img src="images/icon54.png"/></a></span>
        <div class="title1">个人中心</div><!--end search-->
    </header>
	<!--------------Content--------------->
     <section class="zerogrid">
          <div class="ms_notLogin">
                <div class="ms_notLogin_register1">
                	<span><a href="#"><img src="images/liyou28.png"/></a></span>
                </div>
          </div><!--end ms_notLogin-->
          
          <div>
              <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          </div>
          <div class="ms_login_con1" style="margin:0;">
                <p><input type="submit" value="充值成为VIP"/></p>
            </div><!--end ms_login_con1-->
    </section>
    <div style="height:20px;"></div>
</body>
</html>
