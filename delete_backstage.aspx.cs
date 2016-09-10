using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class delete_backstage : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string str1=Request.QueryString["str"];
                string[] array1 = str1.Split(',');
                int mid=Convert.ToInt32(Request.QueryString["mid"]);
                string bm = "";
                foreach (DataRow dt in dal.select("select * from mode where mid=" + mid + "").Rows)
                {
                    bm = dt["mbiao"].ToString();
                }
                string zsbm = "";
                foreach (DataRow dt in dal.select("select * from cpu_center where zwm='" + bm + "'").Rows)
                {
                    zsbm = dt["sjk"].ToString();
                }
                string sql1 = "delete from "+zsbm+" where ";
                for (int i = 0; i < array1.Length - 1; i++)
                {
                    if (i == array1.Length - 2)
                    {
                        sql1 += "id=" + Convert.ToInt32(array1[i]);
                    }
                    else
                    {
                        sql1 += "id=" + Convert.ToInt32(array1[i]) + " or ";
                    }
                }
                if (dal.caozuo(sql1) > 0)
                {
                    fanhui = "删除成功";
                }
                else
                {
                    fanhui = "删除失败";
                }
            }
            catch (Exception es)
            {
                fanhui = es.Message;
            }
            Response.Write(fanhui);
            Response.End();
        }
    }
}