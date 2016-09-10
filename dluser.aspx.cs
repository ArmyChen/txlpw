using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dluser : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string zh = Request.Form["zh"];
                string mm = Request.Form["mm"];
                if (dal.land("select count(*) from users where uiphone='" + zh + "' and umm='"+mm+"'") > 0)
                {
                    fanhui = "登录成功";
                    HttpCookie ci = new HttpCookie("jiamer");
                    ci.Value = zh;
                    Response.Cookies.Add(ci);
                }
                else
                {
                    fanhui = "登录失败";
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