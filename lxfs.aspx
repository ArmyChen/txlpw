<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lxfs.aspx.cs" Inherits="lxfs" %>

<%@ Register src="tx_top.ascx" tagname="tx_top" tagprefix="uc1" %>

<%@ Register src="weibu.ascx" tagname="weibu" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>天下礼品-联系方式</title>
    <style type="text/css">
        .t1 {
            vertical-align: middle;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <uc1:tx_top ID="tx_top1" runat="server" />

        </div>
    <div style="text-align:center;">
        <div style="width:1000px; margin:0px auto 0px auto; text-align:left; font-size:12px; line-height:20px;">
            联系人：邵老师<br />
            联系电话：18623335589
<br />
            地址：重庆市江北区建新北路15号
        </div>
    </div>

    </form>
</body>
</html>
