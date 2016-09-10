using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class qx : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            int aid=Convert.ToInt32(Request.QueryString["aid"]);
            if (aid > 0)
            {
                dal.caozuo("delete from qx where id="+aid+"");
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('删除成功');</script>");
            }
            this.sjdj.DataSource = dal.select("select * from qx order by id desc");
            this.sjdj.DataBind();
        }
    }
}