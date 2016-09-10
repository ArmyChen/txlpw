using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kdq : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DateTime t1 = DateTime.Now;
            DateTime t2 = t1.AddDays(7);
            this.GridView1.DataSource = dal.select("select * from messages where myxq>='" + t1 + "' and myxq<='" + t2 + "'");
            this.GridView1.DataBind();
        }
    }
}