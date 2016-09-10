using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    if (TextBox1.Text == "")
    //    {
    //        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入用户名');</script>");
    //    }
    //    else if (TextBox2.Text == "")
    //    {
    //        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入密码');</script>");
    //    }
    //    else
    //    {
    //        if (dal.land("select count(*) from admin where aname='" + TextBox1.Text + "' and apwd='" + TextBox2.Text + "'") > 0)
    //        {
    //            HttpCookie ci = new HttpCookie("tcadmim");
    //            ci.Value = TextBox1.Text;
    //            Response.Cookies.Add(ci);
    //            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('登录成功');window.location.href='backstage.aspx';</script>");
    //        }
    //        else
    //        {
    //            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('登录失败');</script>");
    //        }
    //    }
    //}
    //protected void LinkButton2_Click(object sender, EventArgs e)
    //{
    //    TextBox1.Text = "";
    //    TextBox2.Text = "";
    //}
}