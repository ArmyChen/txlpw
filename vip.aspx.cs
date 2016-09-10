using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class vip : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            foreach (DataRow dt in dal.select("select * from news where id=44").Rows)
            {
                this.Label1.Text = dt["nconvert"].ToString();
            }
        }
    }
}