using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class xgdj : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            int cid=Convert.ToInt32(Request.QueryString["cid"]);
            foreach (DataRow dt in dal.select("select * from cpu_center where cid="+cid+"").Rows)
            {
                this.bm.Value = dt["sjk"].ToString();
                this.djmc.Value = dt["zwm"].ToString();
                this.TextBox1.Text = dt["fieldnames"].ToString();
                this.TextBox2.Text = dt["kongjian"].ToString();
                this.TextBox3.Text = dt["lei"].ToString();
                this.TextBox4.Text = dt["ss"].ToString();
                this.TextBox5.Text = dt["q"].ToString();
                this.TextBox6.Text = dt["qk"].ToString();
                this.TextBox7.Text = dt["qlei"].ToString();
                this.TextBox8.Text = dt["qs"].ToString();
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='sjdj.aspx';</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dal.caozuo("update cpu_center set qs='"+TextBox8.Text+"',qlei='"+TextBox7.Text+"',q='" + TextBox5.Text + "',qk='" + TextBox6.Text + "',ss='" + TextBox4.Text + "',sjk='" + bm.Value + "',zwm='" + djmc.Value + "',fieldnames='" + TextBox1.Text + "',kongjian='" + TextBox2.Text + "',lei='" + TextBox3.Text + "' where cid=" + Convert.ToInt32(Request.QueryString["cid"]) + "");
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('修改成功');window.location.href='sjdj.aspx';</script>");
    }
}