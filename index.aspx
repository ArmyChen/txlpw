<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<%@ Register src="tx_top.ascx" tagname="tx_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>天下礼品</title>
    <style type="text/css">
        img {
            border: 0px;
        }
    </style>
<script>
var _hmt = _hmt || [];
(function() {
  var hm = document.createElement("script");
  hm.src = "//hm.baidu.com/hm.js?3733a85468c99d570d6625edffab4ace";
  var s = document.getElementsByTagName("script")[0];
  s.parentNode.insertBefore(hm, s);
})();
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <uc1:tx_top ID="tx_top1" runat="server" />

        </div>
    <div>
        <div style="overflow:hidden; min-height:800px;">
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            
        </div>
    </div>
        <div style="padding:20px; margin-top:10px; clear:both; text-align:center; background-color:black; font-size:12px; color:white;">
            天下礼品版权所有 备案号：渝ICP备15011680号
<a href='gsjj.aspx' style="font-size:12px; color:#fff;text-decoration:none">公司简介</a>
<a href='lxfs.aspx' style="font-size:12px; color:#fff;text-decoration:none">联系我们</a>
        </div>
    </form>
</body>
</html>
