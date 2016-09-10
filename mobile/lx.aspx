<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lx.aspx.cs" Inherits="mobile_lx" %>

<%@ Register src="mobile_txlp_top.ascx" tagname="mobile_txlp_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" /><meta name="apple-mobile-web-app-capable" content="yes" /><meta name="format-detection" content="telephone=no" />

    <title>天下礼品-联系方式</title>
    <style>
        img {
            width: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:mobile_txlp_top ID="mobile_txlp_top1" runat="server" />
    
    </div>
    <div style="padding:10px; line-height:25px; font-size:14px; clear:both;">
        联系人：邵老师<br />
            联系电话：18623335589<br />
            地址：重庆市江北区建新北路15号
    </div>
    </form>
</body>
</html>