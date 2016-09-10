using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ydq : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DateTime t1 = DateTime.Now;
            string sql = "";
            foreach (DataRow dt in dal.select("select * from messages").Rows)
            {
                if (dt["myxq"].ToString() != "永久")
                {
                    DateTime t2 = Convert.ToDateTime(dt["myxq"].ToString());
                    TimeSpan t3 = t1.Subtract(t2);
                    if (t3.Days >= 0)
                    {
                        sql += " id=" + dt["id"].ToString() + " or";
                    }
                }
            }
            sql = sql.Substring(0,sql.Length-2);
            this.GridView1.DataSource = dal.select("select * from messages where "+sql+"");
            this.GridView1.DataBind();
        }
    }
}