using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mobile_regiset : System.Web.UI.Page
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
        try
        {
            if (TextBox1.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入手机号码');</script>");
            }
            else if (TextBox1.Text.Length != 11)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入正确的手机号码');</script>");
            }
            else if (dal.sqlland("select count(*) from users where uaccount=@a1", "@a1,", "" + TextBox1.Text + ",") > 0)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('该手机号码已存在');</script>");
            }
            else if (TextBox2.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入密码');</script>");
            }
            else if (TextBox3.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请再次输入密码');</script>");
            }
            else if (TextBox2.Text != TextBox3.Text)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('两次密码输入不一致');</script>");
            }
            else if (CheckBox1.Checked == false)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请勾选注册协议');</script>");
            }
            else
            {
                dal.sqlcaozuo("insert into users values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)", "@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,", "" + TextBox1.Text + "," + TextBox2.Text + "," + TextBox4.Text + ",,天下礼品," + DateTime.Now.ToString() + ",514,0,");
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('注册成功');location.href='land.aspx';</script>");
            }
        }
        catch (Exception es)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('" + es.Message + "');</script>");
        }
    }
}