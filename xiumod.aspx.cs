using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class xiumod : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.DropDownList3.DataSource = dal.select("select * from mode where mdeng=0");
            this.DropDownList3.DataTextField = "mname";
            this.DropDownList3.DataValueField = "mid";
            this.DropDownList3.DataBind();
            this.DropDownList4.DataSource = dal.select("select * from cpu_center");
            this.DropDownList4.DataTextField = "zwm";
            this.DropDownList4.DataValueField = "zwm";
            this.DropDownList4.DataBind();
            int mid=Convert.ToInt32(Request.QueryString["mid"]);
            foreach (DataRow dt in dal.select("select * from mode where mid="+mid+"").Rows)
            {
                this.TextBox1.Text = dt["mname"].ToString();
                this.TextBox2.Text = dt["mpai"].ToString();
                this.TextBox3.Text = dt["murl"].ToString();
                this.DropDownList1.Text = dt["mlei"].ToString();
                this.DropDownList2.Text = dt["mlan"].ToString();
                
                this.DropDownList4.Text = dt["mbiao"].ToString();
                if (dt["mlan"].ToString() == "父栏目")
                {
                    this.DropDownList3.DataSource = dal.select("select * from mode where mdeng=0");
                    this.DropDownList3.DataTextField = "mname";
                    this.DropDownList3.DataValueField = "mid";
                    this.DropDownList3.DataBind();
                }
                else
                {
                    this.DropDownList3.DataSource = dal.select("select * from mode where mdeng=1");
                    this.DropDownList3.DataTextField = "mname";
                    this.DropDownList3.DataValueField = "mid";
                    this.DropDownList3.DataBind();
                }
                this.DropDownList3.Text = dt["msu"].ToString();
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='mod.aspx';</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int mdeng = 0;
            foreach (DataRow dt in dal.select("select * from mode where mid=" + Convert.ToInt32(DropDownList3.SelectedValue) + "").Rows)
            {
                mdeng = int.Parse(dt["mdeng"].ToString()) + 1;
            }
            if (DropDownList1.Text == "系统设定")
            {
                string mname = TextBox1.Text;
                int shu = Convert.ToInt32(DropDownList3.SelectedValue);
                int pai = Convert.ToInt32(TextBox2.Text);
                string url = "";
                string biao = DropDownList4.Text;
                string lei = "系统设定";
                string lan = DropDownList2.Text;
                if (dal.caozuo("update mode set mname='" + mname + "',mdeng=" + mdeng + ",msu=" + shu + ",mpai=" + pai + ",mbiao='" + biao + "',mlei='" + lei + "',mlan='" + lan + "' where mid=" + Convert.ToInt32(Request.QueryString["mid"]) + "") > 0)
                {
                    int mid = Convert.ToInt32(Request.QueryString["mid"]);
                    if (dal.caozuo("update mode set murl='backstage_system.aspx?mid=" + mid + "' where mid='" + mid + "'") > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('模块修改成功');</script>");
                    }
                }
            }
            else
            {
                string mname = TextBox1.Text;
                int shu = Convert.ToInt32(DropDownList3.SelectedValue);
                int pai = Convert.ToInt32(TextBox2.Text);
                string url = TextBox3.Text;
                string biao = "";
                string lei = "自定义";
                string lan = DropDownList2.Text;
                if (dal.caozuo("update mode set mname='" + mname + "',murl='" + url + "',mdeng=" + mdeng + ",msu=" + shu + ",mpai=" + pai + ",mbiao='" + biao + "',mlei='" + lei + "',mlan='" + lan + "' where mid=" + Convert.ToInt32(Request.QueryString["mid"]) + "") > 0)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('模块修改成功');</script>");
                }
            }
        }
        catch (Exception es)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('" + es.Message + "');</script>");
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.Text == "父栏目")
        {
            this.DropDownList3.DataSource = dal.select("select * from mode where mdeng=0");
            this.DropDownList3.DataTextField = "mname";
            this.DropDownList3.DataValueField = "mid";
            this.DropDownList3.DataBind();
        }
        else
        {
            this.DropDownList3.DataSource = dal.select("select * from mode where mdeng=1");
            this.DropDownList3.DataTextField = "mname";
            this.DropDownList3.DataValueField = "mid";
            this.DropDownList3.DataBind();
        }
    }
}