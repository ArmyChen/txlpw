using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class dls_ajax : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string zh = Request.Form["yhm"];
                string mm=Request.Form["mm"];
                if (dal.land("select count(*) from users where uaccount='" + zh + "' and upwd='" + mm + "'") > 0)
                {
                    fanhui = "登录成功";
                    HttpCookie cook = new HttpCookie("liyouadmin");
                    cook.Value = zh;
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