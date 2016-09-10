using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.GridView1.DataSource = dal.select("select * from admin");
            this.GridView1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("addadmin.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string SQL = "delete from admin where ";
        string CQL = "";
        CheckBox cd = new CheckBox();

        for (int i = 0; i < this.GridView1.Rows.Count; i++)
        {
            cd = (CheckBox)this.GridView1.Rows[i].Cells[0].FindControl("CheckBox1");
            if (cd.Checked == true)
            {
                CQL += "aid=" + this.GridView1.DataKeys[i].Value.ToString() + " or ";
            }
        }
        if (CQL != "")
        {
            SQL += CQL.Substring(0, CQL.Length - 3);
            try
            {

                if (dal.caozuo(SQL) > 0)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('选中管理员已删除');</script>");
                    this.GridView1.DataSource = dal.select("select * from admin");
                    this.GridView1.DataBind();
                }

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('" + ex.Message.ToString() + ",请重新登陆系统')</script>");
            }

        }
        else
        {
            SQL = "";
        }
    }
}