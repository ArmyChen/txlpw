<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="mobile_index" %>

<%@ Register src="mobile_txlp_top.ascx" tagname="mobile_txlp_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" /><meta name="apple-mobile-web-app-capable" content="yes" /><meta name="format-detection" content="telephone=no" />
    <title>天下礼品</title>
    <script>
        function hq(str)
        {
            location.href = "xq.aspx?xid="+str+"";
        }
    </script>
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
    
        <uc1:mobile_txlp_top ID="mobile_txlp_top1" runat="server" />
    
    </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
<div style="padding:10px;background-color:black;font-size:14px;text-align:center;color:white;">
18623335589
</div>
    </form>
</body>
</html>
