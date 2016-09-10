function zc()
{
    var yhh = document.getElementById("yhh").value;
    var mm = document.getElementById("mm").value;
    var qrmm = document.getElementById("qrmm").value;
    var email = document.getElementById("email").value;
    var pd = document.getElementById("ch");
    var reg1 = /^[a-zA-Z0-9_]{6,20}$/;
    if (yhh == "")
    {
        alert("请输入用户名");
    }
    else if (yhh.length < 4||yhh.length>20)
    {
        alert("用户名长度不对，4到20位之间");
    }
    else if (!reg1.test(yhh)) {
        alert('用户名不能输入中文');
    }
    else if (mm == "") {
        alert("请输入密码");
    }
    else if (mm.length < 4)
    {
        alert("密码长度不能少于4位数");
    }
    else if (qrmm == "") {
        alert("请再次输入密码");
    }
    else if (mm != qrmm) {
        alert("两次密码输入不一致");
    }
    else if (email == "")
    {
        alert("请输入电子邮箱");
    }
    else if (email.indexOf("@") <0 || email.indexOf(".com")<0)
    {
        alert("邮箱格式不正确");
    }
    else if (pd.checked == false) {
        alert("您还没勾选确认服务信息");
    }
    else {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            xmlhttp = new XMLHttpRequest();
        }
        else {
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var fanhui = xmlhttp.responseText;
                if (fanhui == "注册成功")
                {
                    alert("注册成功");
                    window.location.href = 'userscenter.aspx';
                }
                else
                {
                    alert(fanhui);
                }
            }
        }
        xmlhttp.open("POST", "regist.aspx?yhh="+escape(yhh)+"&mm="+escape(mm)+"&email="+escape(email)+"", true); //编译字符串，反乱码
        xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        xmlhttp.send();
    }
}
function dl() {
    var yhh = document.getElementById("yhh").value;
    var mm = document.getElementById("mm").value;
    if (yhh == "") {
        alert("请输入用户名");
    }
    else if (mm == "") {
        alert("请输入密码");
    }
    else {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            xmlhttp = new XMLHttpRequest();
        }
        else {
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var fanhui = xmlhttp.responseText;
                if (fanhui == "登录成功") {
                    window.location.href = 'userscenter.aspx';
                }
                else {
                    alert(fanhui);
                }
            }
        }
        xmlhttp.open("POST", "dl.aspx?yhh=" + escape(yhh) + "&mm=" + escape(mm) + "", true); //编译字符串，反乱码
        xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        xmlhttp.send();
    }
}

function dl1(str)
{
    document.getElementById("yxz").innerText = str;
    document.getElementById("dl").style.display = "none";
    document.getElementById("xl").style.display = "block";
    document.getElementById("cx").style.display = "block";
    var xmlhttp;
    if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
    }
    else {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var fanhui = xmlhttp.responseText;
            document.getElementById("Label3").innerHTML = fanhui;
        }
    }
    xmlhttp.open("POST", "fb.aspx?zhi=" + escape(str) + "", true); //编译字符串，反乱码
    xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xmlhttp.send();
}
function cx1()
{
    document.getElementById("dl").style.display = "block";
    document.getElementById("xl").style.display = "none";
    document.getElementById("cx").style.display = "none";
}
function xzs(str) {
    var zhi1 = str;
    var city = document.getElementById("Label1").innerText;
    var dl = document.getElementById("yxz").innerText;
    var zhi3 = city + "|" + dl + "," + str;
    window.location.href = "erjifabu.aspx?fname="+zhi3;
}

function chtg(str1,str2)
{
    if (str1.checked) {
        document.getElementById("tgs").value += str2 + ","
    }
    else {
        var zhi1 = document.getElementById("tgs").value;
        var zhi2 = str2 + ",";
        var zhi3 = zhi1.replace(zhi2, "");
        document.getElementById("tgs").value = zhi3;
    }
}

function ljfb(str)
{
    var zhi1ss = document.getElementById("tgs").value;
    var asd = new Array();
    
    if (zhi1ss != "")
    {
        asd = zhi1ss.split(',');
    }
    if (asd.length>2) {
        alert("置顶服务只能选择一项进行推广");
    }
    else {
        var bz = 0;
        var k = document.getElementById("k").value;
        var asd1 = new Array();
        if (k != "")
        {
            asd1 = k.split(',');
        }
        for (var i = 0; i < asd1.length-1; i++)
        {
            var asd2 = new Array();
            asd2 = asd1[i].split('|');
            if (document.getElementById(asd2[0]).value == "") {
                bz = 1;
                alert(asd2[1]);
                break;
            }
        }
        if (bz == 1) {
        }
        else if (bz == 0) {
            var zhi = document.getElementById("qz").value;
            var shu1 = new Array();
            shu1 = zhi.split(',');
            var zhis = "";
            for (var i = 0; i < shu1.length - 1; i++) {
                var shu2 = new Array();
                shu2 = shu1[i].split('|');
                var id = shu2[0];
                var lei = shu2[1];
                if (lei == "文本框") {
                    zhis += document.getElementById(id).value + "[,]";
                }
                else if (lei == "详细信息框") {
                    var zhi2 = new Array();
                    zhi2 = id.split('_');
                    var zhi1 = zhi2[1];
                    var html1 = $(document.getElementsByTagName('iframe')[zhi1].contentWindow.document.body).html();
                    zhis += html1 + "[,]";
                }
                else if (lei == "下拉框") {
                    var obj = document.getElementById(id); //定位id

                    var index = obj.selectedIndex; // 选中索引

                    var text = obj.options[index].text; // 选中文本

                    var value = obj.options[index].value; // 选中值
                    zhis += value + "[,]";
                }
                else if (lei == "图片上传控件") {
                    var zhi2 = new Array();
                    zhi2 = id.split('_');
                    var zhi1 = zhi2[1];
                    var html1 = $(document.getElementsByTagName('iframe')[zhi1].contentWindow.document.body).html();
                    zhis += html1 + "[,]";
                }
            }
            var xmlhttp;
            if (window.XMLHttpRequest) {
                xmlhttp = new XMLHttpRequest();
            }
            else {
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    var fanhui = xmlhttp.responseText;
                    if (fanhui.indexOf("新增成功") != -1) {
                        var fh = new Array();
                        fh = fanhui.split(',');
                        window.location.href = "message_sussce.aspx?cs="+escape(document.getElementById("cs").value)+"&lb="+escape(document.getElementById("lb").value);
                    }
                    else {
                        alert(fanhui);
                    }
                }
            }
            xmlhttp.open("POST", "fabumessage.aspx?cs="+escape(document.getElementById("cs").value)+"&tg="+zhi1ss+"&str=" + escape(zhis) + "&mid=" + escape(str) + "&lb="+escape(document.getElementById("lb").value)+"", true); //编译字符串，反乱码
            xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            xmlhttp.send();
        }
    }
    

}

function djd(str)
{
    var array1 = new Array();
    array1 = str.split('⋚');
    var class1 = array1[1];
    $("." + class1).css("color", "#0066cc");
    $("." + class1).css("font-weight", "normal");
    var array2 = new Array();
    array2 = array1[0].split('/');
    var id = array2[1];
    $("#" + id).css("color", "#333333");
    $("#" + id).css("font-weight", "bold");
    var array3 = new Array();
    var zhi = document.getElementById("Label4").innerText;
    var array4 = array2[0].split('ψ');
    var zhi1 = "";
    if (zhi != "") {
        array3 = zhi.split(',');
        for (var i = 0; i < array3.length - 1; i++)
        {
            if (array3[i].indexOf(array4[0]) != -1) {

            }
            else {
                zhi1 += array3[i]+",";
            }
        }
        zhi1 += array2[0] + ","
        document.getElementById("Label4").innerText = zhi1;
    }
    else {
        document.getElementById("Label4").innerText += array2[0] + ",";
    }

    var xmlhttp;
    if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
    }
    else {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var fanhui = xmlhttp.responseText;
            document.getElementById("Label7").innerHTML = fanhui;
        }
    }
    xmlhttp.open("POST", "cxmessage.aspx?tiaojian=" + escape(document.getElementById("Label4").innerText) + "&leibie="+escape(document.getElementById("sjlb").value)+"", true); //编译字符串，反乱码
    xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xmlhttp.send();

}

function djd1(str) {
    var array1 = new Array();
    array1 = str.split('⋚');
    var class1 = array1[1];
    $("." + class1).css("color", "#0066cc");
    $("." + class1).css("font-weight", "normal");
    var array2 = new Array();
    array2 = array1[0].split('/');
    var id = array2[1];
    $("#" + id).css("color", "#333333");
    $("#" + id).css("font-weight", "bold");
    var array3 = new Array();
    var zhi = document.getElementById("Label4").innerText;
    var array4 = array2[0].split('ψ');
    var zhi1 = "";
    if (zhi != "") {
        array3 = zhi.split(',');
        for (var i = 0; i < array3.length - 1; i++) {
            if (array3[i].indexOf(array4[0]) != -1) {

            }
            else {
                zhi1 += array3[i] + ",";
            }
        }
        zhi1 += array2[0] + ","
        document.getElementById("Label4").innerText = zhi1;
    }
    else {
        document.getElementById("Label4").innerText += array2[0] + ",";
    }

    var xmlhttp;
    if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
    }
    else {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var fanhui = xmlhttp.responseText;
            document.getElementById("Label7").innerHTML = fanhui;
        }
    }
    xmlhttp.open("POST", "fwc.aspx?tiaojian=" + escape(document.getElementById("Label4").innerText) + "&leibie=" + escape(document.getElementById("sjlb").value) + "", true); //编译字符串，反乱码
    xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xmlhttp.send();

}

function sntqh(str,str1)
{
    document.getElementById("snt").src = str;
    $(".snts").css("border", "0px");
    $("#"+str1).css("border", "2px solid #f9ae71");
}
function ckwzdh()
{
    document.getElementById("Label9").innerText = document.getElementById("wzdh").value;
}
var index = 0;
function syz(str)
{
    var zhi = document.getElementById("sz").value;
    var szz = new Array();
    szz = zhi.split(',');
    var len = szz.length - 2;
    if (index == 0)
    {
        index = len;
    }
    else {
        index = index - 1;
    }
    var src1 = szz[index];
    document.getElementById(str).src = src1;
}
function xyz(str) {
    var zhi = document.getElementById("sz").value;
    var szz = new Array();
    szz = zhi.split(',');
    var len = szz.length - 2;
    if (index == len) {
        index = 0;
    }
    else {
        index = index + 1;
    }
    var src1 = szz[index];
    document.getElementById(str).src = src1;
}
function cx(str1, str2, str3,str4)
{
    var xmlhttp;
    if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
    }
    else {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var fanhui = xmlhttp.responseText;
            document.getElementById("Label2").innerHTML = fanhui;
        }
    }
    xmlhttp.open("POST", "select_dp.aspx?zhi=" + escape(str1) + "&biao=" + escape(str2) + "&zd=" + escape(str3) + "&ren=" + escape(str4) + "", true); //编译字符串，反乱码
    xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xmlhttp.send();
}

function ljfb1()
{
    var biaoti = document.getElementById("bt").value;
    var ddl = document.getElementById("DropDownList1")
    var index = ddl.selectedIndex;
    var yj = ddl.options[index].text;

    var ddl1 = document.getElementById("DropDownList2")
    var index1 = ddl1.selectedIndex;
    var ej = ddl1.options[index1].text;
    var biaoqian = document.getElementById("bqss").value;
    var ddl2 = document.getElementById("DropDownList3")
    var index2 = ddl2.selectedIndex;
    
    var pinpai = "";
    if (index2 <0) {
        pinpai = "";
    }
    else {
        var pinpai1 = ddl2.options[index2].text;
        pinpai = pinpai1;
    }

    var jiage = document.getElementById("jg").value;

    var canshu = document.getElementById("qtcs").value;

    var tupian = $(document.getElementsByTagName('iframe')[0].contentWindow.document.body).html();
    var nr = $(document.getElementsByTagName('iframe')[1].contentWindow.document.body).html();
    var yuanjia = document.getElementById("yuanjia").value;
    var b = /^[0-9]*$/g;
    if (biaoti == "")
    {
        alert("请输入标题");
    }
    else if (jiage == "")
    {
        alert("请输入价格");
    }
    else if (b.test(jiage) == false) {
        alert("价格输入错误，只能为数字");
    }
    else {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            xmlhttp = new XMLHttpRequest();
        }
        else {
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var fanhui = xmlhttp.responseText;
                if (fanhui.indexOf("新增成功") != -1) {
                    alert("发布成功");
                    window.location.href = "my_scstore.aspx";
                }
                else {
                    alert(fanhui);
                }
            }
        }
        xmlhttp.open("POST", "fabugood.aspx?yuanjia="+escape(yuanjia)+"&bt="+escape(biaoti)+"&yj="+escape(yj)+"&ej="+escape(ej)+"&bq="+escape(biaoqian)+"&pp="+escape(pinpai)+"&jg="+jiage+"&cs="+escape(canshu)+"&tp="+escape(tupian)+"&nr="+escape(nr)+"", true); //编译字符串，反乱码
        xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        xmlhttp.send();
    }
}

function scqh(str)
{
    var xmlhttp;
    if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
    }
    else {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var fanhui = xmlhttp.responseText;
            document.getElementById("Label16").innerHTML = fanhui;
        }
    }
    xmlhttp.open("POST", "spqh1.aspx?sname="+escape(str)+"", true); //编译字符串，反乱码
    xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xmlhttp.send();
}
function fs(str) {
    var xmlhttp;
    if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
    }
    else {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var fanhui = xmlhttp.responseText;
            document.getElementById("Label22").innerHTML = fanhui;
        }
    }
    xmlhttp.open("POST", "spqh2.aspx?sname=" + escape(str) + "", true); //编译字符串，反乱码
    xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xmlhttp.send();
}
function jsgjz()
{
    var gjz = document.getElementById("gjz").value;
    if (gjz == "")
    {
        alert('请输入关键字');
    }
    else
    {
        location.href = "ss.aspx?gjz=" + escape(gjz);
    }
}