<%@ Page Language="C#" AutoEventWireup="true" CodeFile="beifenxiazai.aspx.cs" Inherits="beifenxiazai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/tjw.css" rel="stylesheet" />
</head>
<body style="background-color:#ffffff;">
    <form id="form1" runat="server">
    <div>
    <div style="padding:10px 0px 15px 28px; background-color:#f5f5f5; position:relative; z-index:1; border-bottom:1px solid #d1d1d1; clear:both;">
            <img src="images/fangzi.jpg" style="vertical-align:middle;" />
            <span style="font-size:12px; color:#464646; vertical-align:middle;"><font face="宋体">您当前的位置：系统设置 > 下载数据备份</font></span>
        </div>
        <div style="padding:20px; clear:both;">
            <div style="background-color:white;">
                <div style="border-top:4px solid #2f83d5;">
                    <div style="padding:9px 0px 10px 20px; border-bottom:1px solid #e5e5e5; background-color:#b9d8f6; clear:both;">
                        <span style="font-size:14px; color:#464646; vertical-align:middle;"><font face="微软雅黑"><b>下载数据备份</b></font></span>
                    </div>
                    
                    <div style="min-height:370px;border:1px solid #e5e5e5; border-top:0px;">
                        <div style="padding:10px; clear:both;">
                            <div style="height:460px; background-color:#f1f1f1; overflow:scroll;">
                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>