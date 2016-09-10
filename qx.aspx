<%@ Page Language="C#" AutoEventWireup="true" CodeFile="qx.aspx.cs" Inherits="qx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="css/mofei.css" rel="stylesheet" />
    <script src="js/mofei.js"></script>
    <script type="text/javascript">
        function get_time() {
            var myDate = new Date();
            var week;
            if (new Date().getDay() == 0) week = "星期日"
            if (new Date().getDay() == 1) week = "星期一"
            if (new Date().getDay() == 2) week = "星期二"
            if (new Date().getDay() == 3) week = "星期三"
            if (new Date().getDay() == 4) week = "星期四"
            if (new Date().getDay() == 5) week = "星期五"
            if (new Date().getDay() == 6) week = "星期六"

            document.getElementById("html_time").innerHTML = myDate.toLocaleString() + "&nbsp;" + week;
        }
        var zhi = setInterval(get_time, 1000);
        function add_zm() {
            location.href = "insertqx.aspx";
        }
    </script>
</head>
<body style="background-color:#f1f1f1;">
    <form id="form1" runat="server">
    <div>
        <div style="padding:10px 0px 15px 28px; background-color:#f5f5f5; position:relative; z-index:1; border-bottom:1px solid #d1d1d1; clear:both;">
            <img src="images/fangzi.jpg" style="vertical-align:middle;" />
            <span style="font-size:12px; color:#464646; vertical-align:middle;"><font face="宋体">您当前的位置：OA功能首页 > 权限管理</font></span>
            <span style="font-size:12px; color:#464646;position:absolute; top:13px; right:25px; z-index:999; vertical-align:middle;"><font face="宋体"><span id="html_time">正在加载...</span></font></span>
        </div>
        <div style="padding:20px; clear:both;">
            <div style="background-color:white;">
                <div style="border-top:4px solid #00a5a5;">
                    <div style="padding:9px 0px 10px 20px; border-bottom:1px solid #e5e5e5; clear:both;">
                        <span style="font-size:14px; color:#464646; vertical-align:middle;"><font face="微软雅黑"><b>权限组</b></font></span>
                    </div>
                    <div style="padding:10px; overflow:hidden;border:1px solid #e5e5e5; border-top:0px; border-bottom:0px; clear:both;">
                        <input type="button" class="button1" id="insert1" value="新增权限组" onclick="add_zm()" />&nbsp;&nbsp;</div>
                    <div style="min-height:370px;border:1px solid #e5e5e5; border-top:0px;">
                        <div style="padding:10px; clear:both;">
                            <div style="height:460px; background-color:#f1f1f1; overflow:scroll;">
                                <table style="min-width:100%">
                                    <tr>
                                        <td class="oadata1">
                                            <font face="宋体"><b>权限组名称</b></font>
                                        </td>
                                        <td class="oadata1">
                                            <font face="宋体"><b>操作</b></font>
                                        </td>
                                    </tr>
                                    <asp:Repeater ID="sjdj" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td class="oadata2">
                                                    <%#Eval("qname") %>
                                                </td>
                                                <td class="oadata2">
                                                    <a href="xgqx.aspx?sid=<%#Eval("id") %>"><img src="images/update.png" /></a>
                                                    <a href="qx.aspx?aid=<%#Eval("id") %>"><img src="images/delete.png" /></a>
                                                </td>
  
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="datatuceng1" style="width:100%;position:absolute; min-height:700px;display:none; top:0px; left:0px; z-index:999; background-color:black;filter:alpha(opacity=50);-moz-opacity: 0.5;opacity: 0.5;">
        &nbsp;
    </div>
        <div id="datatuceng2" style="width:100%;position:absolute; display:none; min-height:700px; top:0px; left:0px; z-index:999;">
        <div style="position:relative; z-index:1;">
            <div style="width:700px; height:500px; position:absolute; top:100px; left:200px; z-index:999; background-color:white; border:0px solid #dddddd;">
                <div style="padding:10px; clear:both; background-color:#198375;cursor:move;position:relative; z-index:1;">
                    <span style="font-size:16px; color:#d6e6e1;"><font face="宋体"><b>新增</b></font></span>
                    <span style="font-size:20px; color:#ffffff; position:absolute; cursor:pointer; top:9px; right:10px; z-index:10;" onclick="hide_data()"><font face="微软雅黑"><b>X</b></font></span>
                </div>
                <div style="padding: 0px 5px 5px 5px; background-color: #198375;">
                    <div style="overflow: scroll; height: 460px;background-color:white;">
                        <div style="background-color: #ffffff; min-height: 440px;">
                            <div style="padding:10px; clear:both;">
                                <table width="100%">
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">数据表名称：</font>
                                        </td>
                                        <td class="oatd2">
                                            <input id="sjb" type="text" class="text1" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">对接中文名称：</font>
                                        </td>
                                        <td class="oatd2">
                                            <input id="zdname" type="text" class="text1" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">字段名称：</font>
                                        </td>
                                        <td class="oatd2">
                                            <textarea id="zdmc" class="text2" style="width:300px; height:150px;"></textarea></td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">对接控件：</font>
                                        </td>
                                        <td class="oatd2">
                                            <textarea id="djkj" class="text2" style="width:300px; height:150px;"></textarea>
                                            输入每个字段所需控件名称，供与前段与后端数据录入时使用，主要有文本框、下拉框、图片上传控件,详细信息框、&nbsp; 用小写字母,区分&nbsp;&nbsp; 如果选择下拉框则需要输入下拉框的数据源（即来源数据表）同时还要输入数据源字段名 例如：下拉框|admin/aname&nbsp; 下拉框代表控件名&nbsp; admin代表数据表&nbsp; aname代表数据表的字段名。
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">对接类型：</font>
                                        </td>
                                        <td class="oatd2">

                                            <textarea id="djlx" class="text2" style="width:300px; height:150px;"></textarea>
                                            类型：[int][varchar][float][decimal]
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">配置搜索字段：</font>
                                        </td>
                                        <td class="oatd2">
                                            <textarea id="sszd" class="text2" style="width:300px; height:150px;"></textarea></td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体"></font>
                                        </td>
                                        <td class="oatd2">
                                            <input type="button" class="button1" value="添加配置" onclick="add_peizhidata()" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <div id="datatuceng3" style="width:100%;position:absolute; display:none; min-height:700px; top:0px; left:0px; z-index:999;">
        <div style="position:relative; z-index:1;">
            <div style="width:700px; height:500px; position:absolute; top:100px; left:200px; z-index:999; background-color:white; border:0px solid #dddddd;">
                <div style="padding:10px; clear:both; background-color:#198375;cursor:move;position:relative; z-index:1;">
                    <span style="font-size:16px; color:#d6e6e1;"><font face="宋体"><b>修改</b></font></span>
                    <span style="font-size:20px; color:#ffffff; position:absolute; cursor:pointer; top:9px; right:10px; z-index:10;" onclick="hide_data()"><font face="微软雅黑"><b>X</b></font></span>
                </div>
                <div style="padding: 0px 5px 5px 5px; background-color: #198375;">
                    <div style="overflow: scroll; height: 460px;background-color:white;">
                        <div style="background-color: #ffffff; min-height: 440px;">
                            <div style="padding:10px; clear:both;">
                                <table width="100%">
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">数据表名称：</font>
                                        </td>
                                        <td class="oatd2">
                                            <input id="Text1" type="text" class="text1" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">对接中文名称：</font>
                                        </td>
                                        <td class="oatd2">
                                            <input id="Text2" type="text" class="text1" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">字段名称：</font>
                                        </td>
                                        <td class="oatd2">
                                            <textarea id="Textarea1" class="text2" style="width:300px; height:150px;"></textarea></td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">对接控件：</font>
                                        </td>
                                        <td class="oatd2">
                                            <textarea id="Textarea2" class="text2" style="width:300px; height:150px;"></textarea>
                                            输入每个字段所需控件名称，供与前段与后端数据录入时使用，主要有文本框、下拉框、图片上传控件,详细信息框、&nbsp; 用小写字母,区分&nbsp;&nbsp; 如果选择下拉框则需要输入下拉框的数据源（即来源数据表）同时还要输入数据源字段名 例如：下拉框|admin/aname&nbsp; 下拉框代表控件名&nbsp; admin代表数据表&nbsp; aname代表数据表的字段名。
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">对接类型：</font>
                                        </td>
                                        <td class="oatd2">

                                            <textarea id="Textarea3" class="text2" style="width:300px; height:150px;"></textarea></td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体">配置搜索字段：</font>
                                        </td>
                                        <td class="oatd2">
                                            <textarea id="Textarea4" class="text2" style="width:300px; height:150px;"></textarea></td>
                                    </tr>
                                    <tr>
                                        <td class="oatd1">
                                            <font face="宋体"></font>
                                        </td>
                                        <td class="oatd2">
                                            <input type="button" class="button1" value="更新配置" onclick="update_peizhidata()" /><input id="ccid" style="display:none;" />
                                        </td>
                                    </tr>
                                </table>
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