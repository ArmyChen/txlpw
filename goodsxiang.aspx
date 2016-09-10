<%@ Page Language="C#" AutoEventWireup="true" CodeFile="goodsxiang.aspx.cs" Inherits="goodxiang" %>

<%@ Register src="tx_top.ascx" tagname="tx_top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title><%=sname %>-天下礼品</title>
    <script type="text/javascript">
        var mobileAgent = new Array("iphone", "ipod", "ipad", "android", "mobile", "blackberry", "webos", "incognito", "webmate", "bada", "nokia", "lg", "ucweb", "skyfire");

        var browser = navigator.userAgent.toLowerCase();

        var isMobile = false;

        for (var i = 0; i < mobileAgent.length; i++) {
            if (browser.indexOf(mobileAgent[i]) != -1) {
                isMobile = true;

                //alert(mobileAgent[i]);

                sjdj.style.display = "block";

                break;
            }
            else {
                sjdj.style.display = "none";
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <uc1:tx_top ID="tx_top1" runat="server" />

        </div>
    <div style="text-align:center; margin:0px auto 0px auto;">
    <div style="width:998px; border:1px solid #dddddd; background-color:white; text-align:left; margin:0px auto 0px auto; border-top:2px solid #e07621;">
                    <table width="998px">
                        <tr>
                            <td style="width:795px; border-right:1px solid #dddddd;" valign="top">
                                <div style="padding:20px 16px 20px 20px;clear:both;">
                                    <div>
                                        <span style="font-size:20px; color:#333333;"><font face="微软雅黑"><span id="Label2"><%=sname %></span></font></span>
                                    </div>
                                    <div style="padding-top:10px; clear:both;">
                                        <span style="font-size:12px; color:#999999;"><font face="宋体">信息编号:<span id="Label3">txlp-<%=bh %></span></font></span>
                                        <span style="font-size:12px; color:#999999;"><font face="宋体">&nbsp;发布于:<span id="Label4"><%=sj %></span></font></span>
                                        <span style="font-size:12px; color:#999999;"><font face="宋体">&nbsp;浏览:<span id="Label5"><%=cs %></span>次</font></span>
                                        <a href="index.aspx" style="font-size:12px;color:#999999;">返回首页</a>
                                    </div>
                                    <div style="padding-top:20px; overflow:hidden; clear:both;">
                                        <div style="width:352px; float:left;">
                                            <div>
                                                <img src="<%=tp %>" id="snt" style="width:352px;height:352px;" />                                          
                                            </div>

                                        </div>
                                        <div style="width:400px; float:left;">
                                            <div style="padding-left:40px; clear:both;">
                                                <div>
                                                    <span id="Label7"><table width='355px'><tr><td style='text-align:left;width:60px;padding-bottom:20px;'><span style='font-size:14px;color:#999999;'><font face='宋体'>地区</font></span></td><td style='padding-bottom:20px;padding-left:10px;'><span style='font-size:18px;color:#e06021;'><font face='arial'><%=dq %></font></span></td></tr><tr><td style='text-align:left;width:60px;padding-bottom:20px;'><span style='font-size:14px;color:#999999;'><font face='宋体'>详情</font></span></td><td style='padding-bottom:20px;padding-left:10px;'><span style='font-size:14px;color:#333333;'><font face='宋体'><%=cd %></font></span></td></tr><tr><td style='text-align:left;width:60px;padding-bottom:20px;'>&nbsp;</td><td style='padding-bottom:20px;padding-left:10px;'><span style='font-size:14px;color:#333333;'><font face='宋体'></font></span></td></tr><tr><td style='text-align:left;width:60px;padding-bottom:20px;'>&nbsp;</td><td style='padding-bottom:20px;padding-left:10px;'><span style='font-size:14px;color:#333333;'><font face='宋体'></font></span></td></tr><tr><td style='text-align:left;width:60px;padding-bottom:20px;'><span style='font-size:14px;color:#999999;'><font face='宋体'>&nbsp;</font></span></td><td style='padding-bottom:20px;padding-left:10px;'><span style='font-size:14px;color:#333333;'><font face='宋体'>&nbsp;</font></span></td></tr><tr><td style='text-align:left;width:60px;padding-bottom:20px;'><span style='font-size:14px;color:#999999;'><font face='宋体'>&nbsp;</font></span></td><td style='padding-bottom:20px;padding-left:10px;'><span style='font-size:14px;color:#333333;'><font face='宋体'>&nbsp;</font></span></td></tr><tr><td style='text-align:left;width:60px;padding-bottom:20px;'><span style='font-size:14px;color:#999999;'><font face='宋体'>&nbsp;</font></span></td><td style='padding-bottom:20px;padding-left:10px;'><span style='font-size:14px;color:#333333;'><font face='宋体'>&nbsp;</font></span></td></tr></table></span>
                                                </div>
                                                <div style="height:83px; overflow:hidden; background-image:url(tpimg/ly.jpg); background-repeat:no-repeat;">
                                                    <div style="position:relative; z-index:1;">
                                                        <span style="position:absolute; top:16px; font-size:18px; color:#e06021; left:28px; z-index:999;"><font face="微软雅黑"><span id="Label8"><%=lxr %></span></font></span>
                                                        <span style="position:absolute; top:50px; font-size:12px; color:#999999; left:28px; z-index:999;"><font face="宋体">联系人姓名&nbsp;</font></span>
                                                        <span style="position:absolute; top:16px; font-size:24px; color:#d41d0f; left:184px; z-index:999;"><font face="arial"><span id="Label9"><%=lxdh %></span></font></span>
                                                    </div><input name="wzdh" type="text" id="wzdh" style="display:none;" value="13452980898" />
                                                </div>
                                                <div style="padding-top:10px; clear:both;">
                                                    <span id="Label15"></span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div style="padding-top:10px; clear:both;">
                                        <div style="padding:7px 0px 9px 15px; clear:both; background-color:#ece5d3;">
                                            <img src="tpimg/sjx.jpg" style="vertical-align:middle;" />
                                            <span style="font-size:12px; vertical-align:middle; color:#e06021;"><font face="宋体">郑重提示：为避免上当受骗，请您勿在签订合同前支付任何形式的费用。</font></span>
                                        </div>
                                    </div>
                                    <div style="padding-top:10px; clear:both;">
                                        <div style="width:759px; overflow:hidden;">
                                        <span id="Label10"><div style='padding:10px 0px 0px 0px; clear:both; border-bottom:2px solid #e07621; overflow:hidden;'><span style='padding:10px 20px 10px 20px; float:left; background-color:#e07621;font-size:14px; color:#ffffff;'><font face='宋体'><b>商品描述</b></font></span></div><div style='padding-top:10px;padding-bottom:10px; clear:both;'><P><%=nr %></P>&nbsp;<P>&nbsp;</P></div>
                                    </div>
                                </div>
                            </td>
                            <td valign="top" style="background-color:#f7eee7;">
                                <div>
                                    <div style="padding:12px 0px 0px 19px; clear:both;">
                                        <span style="color:#e06021;font-size:12px;"><font face="宋体"><span id="Label12">商家信息</span></font></span>
                                    </div>

                                    <div style="padding-top:7px; clear:both; margin:0px auto 0px auto; text-align:center;">
                                        <span style="color:#0066cc; font-size:12px;"><font face="宋体"><span id="Label13"><%=lxr %></span></font></span>
                                    </div>
                                    <div style="padding-top:7px; clear:both; margin:0px auto 0px auto; text-align:center;">
                                        <span style="color:#0066cc; font-size:12px;"><font face="宋体"><span id="Span1"><%=lxdh %></span></font></span>
                                    </div>
                                   
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
    </div>
        <div id="sjdj" style="position:fixed; _position:absolute; display:none; text-align:center; bottom:0px; left:0px; z-index:999; width:100%; background-color:#e07621; padding:20px;">
            <span style="font-size:20px; margin-right:20px; vertical-align:middle; color:white;"><font face="微软雅黑">联系人：<%=lxr %></font></span><a href="tel:<%=lxdh %>" mce_href="tel:<%=lxdh %>"><img src="tpimg/lxdh.png" style="border:0px; height:40px; vertical-align:middle;" /></a>
        </div>
    </form>
</body>
</html>
