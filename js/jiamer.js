function add_user()
{
    var sj = document.getElementById("iphone").value;
    var xing = document.getElementById("xing").value;
    var ming = document.getElementById("ming").value;

    var obj = document.getElementById("xb"); //定位id

    var index = obj.selectedIndex; // 选中索引

    var xb = obj.options[index].text; // 选中文本

    var obj1 = document.getElementById("s_province"); //定位id

    var index1 = obj1.selectedIndex; // 选中索引

    var sheng = obj1.options[index1].text; // 选中文本

    var obj2 = document.getElementById("s_city"); //定位id

    var index2 = obj2.selectedIndex; // 选中索引

    var shi = obj2.options[index2].text; // 选中文本

    var obj3 = document.getElementById("s_county"); //定位id

    var index3 = obj3.selectedIndex; // 选中索引

    var xian = obj3.options[index3].text; // 选中文本

    var dizhi = sheng + "-" + shi + "-" + xian;
    var sh = document.getElementById("sh").value;

    var mm = document.getElementById("mm").value;
    var myreg = /^(((13[0-9]{1})|159|153)+\d{8})$/;
    if (sj == "")
    {
        alert("请输入手机号码");
    }
    else if (sj.length != 11) {
        alert('请输入有效的手机号码！');
    }
    else if (!myreg.test(sj)) {
        alert('请输入有效的手机号码！');
    }
    else if (xing == "")
    {
        alert("请输入姓");
    }
    else if (ming == "") {
        alert("请输入名");
    }
    else if (sh == "")
    {
        alert("请输入生活地址");
    }
    else if (mm == "") {
        alert("请输入密码");
    }
    else {
        $.ajax({
            type: 'post',
            contentType: "application/x-www-form-urlencoded; charset=UTF-8",
            url: 'adduser.aspx',
            data: { sj: sj, xing: xing, ming: ming, xb: xb, dizhi: dizhi, sh: sh, mm: mm },
            async: true,
            success: function (result) {
                if (result == "注册成功") {
                    alert("注册成功！");
                    window.location.href = "userscenter.aspx";
                }
                else {
                    alert(result);
                }
            },
            error: function () {
                setContainer('ERROR!');
            }
        });
    }

}
function land()
{
    var zh = document.getElementById("zh").value;
    var mm = document.getElementById("mm").value;
    if (zh == "") {
        alert("请输入手机号码");
    }
    else if (mm == "") {
        alert("请输入密码");
    }
    else {
        $.ajax({
            type: 'post',
            contentType: "application/x-www-form-urlencoded; charset=UTF-8",
            url: 'dluser.aspx',
            data: { zh: zh, mm: mm},
            async: true,
            success: function (result) {
                if (result == "登录成功") {
                    window.location.href = "userscenter.aspx";
                }
                else {
                    alert(result);
                }
            },
            error: function () {
                setContainer('ERROR!');
            }
        });
    }
}
function addzx()
{
    location.href = "addzx.aspx";
}
