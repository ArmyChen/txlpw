using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class land : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (dal.sqlland("select count(*) from users where uaccount=@a1 and upwd=@a2", "@a1,@a2,", "" + TextBox1.Text + "," + TextBox2.Text + ",") > 0)
        {
            HttpCookie c1 = new HttpCookie("txlpadmin");
            c1.Value = TextBox1.Text;
            Response.Cookies.Add(c1);
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('登陆成功');location.href='index.aspx';</script>");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('登陆失败');location.href='land.aspx';</script>");
        }
    }
}