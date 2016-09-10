using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sjdj : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int cid=Convert.ToInt32(Request.QueryString["cid"]);
            if (cid > 0)
            {
                dal.caozuo("delete from cpu_center where cid="+cid+"");
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('删除成功');</script>");
            }
            this.dj.DataSource = dal.select("select * from cpu_center");
            this.dj.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='adddj.aspx';</script>");
    }
}