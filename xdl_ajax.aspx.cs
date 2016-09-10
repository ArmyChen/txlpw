using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class xdl_ajax : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string zh1 = Request.Form["zh1"];
                string mm1 = Request.Form["mm1"];
                
                if (dal.sqlland("select count(*) from users where uaccount=@a1 and upwd=@a2","@a1,@a2,",""+zh1+","+mm1+",") > 0)
                {
                    fanhui = "登录成功";
                    HttpCookie cook = new HttpCookie("amshowvipcookies");
                    cook.Value = zh1;
                    Response.Cookies.Add(cook);
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