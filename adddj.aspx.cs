using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adddj : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='sjdj.aspx';</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (dal.land("select count(*) from cpu_center where zwm='"+djmc.Value+"'") > 0)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('对不起，该对接名称已存在');</script>");
        }
        else
        {
            dal.caozuo("insert into cpu_center values('" + bm.Value + "','" + djmc.Value + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox3.Text + "','" + DateTime.Now.ToString() + "','','" + TextBox4.Text + "')");
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('新增成功');window.location.href='sjdj.aspx';</script>");
        }
    }
}