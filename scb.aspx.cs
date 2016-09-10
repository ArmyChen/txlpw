using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class scb : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string bm=Request.QueryString["bm1"];
                string dm = Request.QueryString["dm1"];
                string dm2 = dm + "shu varchar(100),ftime varchar(50),mod varchar(100),lll int";
                string sql1 = "CREATE table " + bm + "(id int identity(1,1) primary key,";
                string sql3 = sql1 + dm2 + ")";
                if (dal.caozuo(sql3) > 0)
                {
                    fanhui = "创建成功";
                }
                else
                {
                    fanhui = "创建成功";
                }
            }
            catch (Exception se)
            {
                fanhui = se.Message;
            }
            Response.Write(fanhui);
            Response.End();
        }
    }
}