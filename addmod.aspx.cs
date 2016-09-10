using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class addmod : System.Web.UI.Page
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
            foreach (DataRow dt in dal.select("select * from mode where mid="+Convert.ToInt32(DropDownList3.SelectedValue)+"").Rows)
            {
                mdeng =int.Parse(dt["mdeng"].ToString())+1;
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
                if (dal.land("select count(*) from mode where mname='"+mname+"'") > 0)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('该模块已存在');</script>");
                }
                else
                {
                    if (dal.caozuo("insert into mode values('" + mname + "'," + mdeng + "," + shu + "," + pai + ",'" + url + "','" + biao + "','" + lei + "','" + lan + "')") > 0)
                    {
                        int mid = 0;
                        foreach (DataRow dt in dal.select("select * from mode where mname='"+mname+"'").Rows)
                        {
                            mid = int.Parse(dt["mid"].ToString());
                        }
                        if (dal.caozuo("update mode set murl='backstage_system.aspx?mid="+mid+"' where mname='"+mname+"'") > 0)
                        {
                            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('新增模块成功');</script>");
                        }
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
                if (dal.land("select count(*) from mode where mname='" + mname + "'") > 0)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('该模块已存在');</script>");
                }
                else
                {
                    if (dal.caozuo("insert into mode values('" + mname + "'," + mdeng + "," + shu + "," + pai + ",'" + url + "','" + biao + "','" + lei + "','" + lan + "')") > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('新增模块成功');</script>");
                    }
                }
            }
        }
        catch (Exception es)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('"+es.Message+"');</script>");
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