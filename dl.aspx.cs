using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class dl : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string yhh = Request.QueryString["yhh"];
            string mm = Request.QueryString["mm"];
            string fanhui = "";
            if (dal.land("select count(*) from users where uaccount='" + yhh + "' or uemail='" + yhh + "'") > 0)
            {
                if (dal.land("select count(*) from users where (uaccount='" + yhh + "' or uemail='" + yhh + "') and upwd='" + mm + "'") > 0)
                {
                    string hy = "";
                    foreach (DataRow dt in dal.select("select * from users where uaccount='" + yhh + "' or uemail='" + yhh + "'").Rows)
                    {
                        hy = dt["uaccount"].ToString();
                    }
                    fanhui = "登录成功";
                    HttpCookie ci = new HttpCookie("taojin1");
                    ci.Value = hy;
                    Response.Cookies.Add(ci);
                }
                else
                {
                    fanhui = "用户名或密码错误";
                }
            }
            else
            {
                fanhui = "用户名不存在";
            }
            Response.Write(fanhui);
            Response.End();
        }
    }
}