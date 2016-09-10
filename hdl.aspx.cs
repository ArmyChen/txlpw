using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hdl : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            string as1=Request.QueryString["as1"];
            string as2 = Request.QueryString["as2"];
            if (as1 == "")
            {
                fanhui = "请输入用户名";
            }
            else if (as2 == "")
            {
                fanhui = "请输入密码";
            }
            else
            {
                if (dal.land("select count(*) from admin where aname='" + as1 + "' and apwd='" + as2 + "' and azhuang='已通过'") > 0)
                {
                    if (dal.land("select count(*) from bsm where bname='" + as1 + "'") > 0)
                    {
                        string bsms=DateTime.Now.ToFileTimeUtc().ToString();
                        dal.caozuo("update bsm set bma='"+bsms+"' where bname='"+as1+"'");
                        HttpCookie ci1 = new HttpCookie("bsmcookies");
                        ci1.Value = bsms;
                        Response.AppendCookie(ci1);
                    }
                    else
                    {
                        string bsms = DateTime.Now.ToFileTimeUtc().ToString();
                        dal.caozuo("insert into bsm values('"+as1+"','"+bsms+"')");
                        HttpCookie ci1 = new HttpCookie("bsmcookies");
                        ci1.Value = bsms;
                        Response.AppendCookie(ci1);
                    }
                    HttpCookie ci = new HttpCookie("tcadmin");
                    ci.Value = as1;
                    Response.AppendCookie(ci);
                    fanhui = "登录成功";
                }
                else
                {
                    fanhui = "登录失败";
                }
            }
            Response.Write(fanhui);
            Response.End();
        }
    }
}