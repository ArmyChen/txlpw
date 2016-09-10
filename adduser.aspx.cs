using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class adduser : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string sj=Request.Form["sj"];
                string xing=Request.Form["xing"];
                string ming=Request.Form["ming"];
                string xb=Request.Form["xb"];
                string dizhi = Request.Form["dizhi"];
                string sh = Request.Form["sh"];
                string mm=Request.Form["mm"];
                if (dal.land("select count(*) from users where uiphone='" + sj + "'") > 0)
                {
                    fanhui = "该手机号码已经注册";
                }
                else
                {
                    if (dal.caozuo("insert into users values('" + sj + "','" + xing + "','" + ming + "','" + xb + "','','" + dizhi + "','" + sh + "','" + mm + "','','','0','','','','','','','','家门网','" + DateTime.Now.ToString() + "','378',0)") > 0)
                    {
                        fanhui = "注册成功";
                        HttpCookie ci = new HttpCookie("jiamer");
                        ci.Value = sj;
                        Response.Cookies.Add(ci);
                    }
                    else
                    {
                        fanhui = "注册失败";
                    }
                }
            }
            catch (Exception es)
            {
                fanhui = es.Message;
            }
            Response.Write(fanhui);
            Response.End();
        }
    }
}