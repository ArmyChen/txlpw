using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class dk : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            string sname=Request.QueryString["sname"];
            if (sname != null)
            {
                this.Label1.Text = sname;
                this.GridView1.DataSource = dal.select("select * from "+sname+"");
                this.GridView1.DataBind();
            }
        }
    }
}