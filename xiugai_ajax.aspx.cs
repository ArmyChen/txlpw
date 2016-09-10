using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class update_ajax : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string neirong = Request.Form["str"];
                int mid = Convert.ToInt32(Request.Form["mid"]);
                //获取关联表
                string b = "";
                foreach (DataRow dt in dal.select("select * from mode where mid=" + mid + "").Rows)
                {
                    b = dt["mbiao"].ToString();
                }
                string c = "";
                string lei = "";
                foreach (DataRow dt in dal.select("select * from cpu_center where zwm='" + b + "'").Rows)
                {
                    c = dt["sjk"].ToString();
                    lei = dt["lei"].ToString();
                }
                string zdm = "";
                foreach (DataRow dt in dal.select("select name from syscolumns where id=object_id('" + c + "')").Rows)
                {
                    zdm += dt[0].ToString() + ",";
                }
                string[] zds = zdm.Split(',');
                string zhi3 = neirong.Replace("[,]", "⋚");
                string[] shu1 = zhi3.Split('⋚');
                string[] shu2 = lei.Split(',');
                string sql1 = "";
                for (int i = 0; i < shu1.Length - 1; i++)
                {
                    if (i == shu1.Length - 2)
                    {
                        if (shu2[i] == "varchar")
                        {
                            sql1 += zds[i+1].ToString()+"='" + shu1[i] + "'";
                        }
                        else if (shu2[i] == "decimal")
                        {
                            sql1 += zds[i + 1].ToString() + "=" + Convert.ToDouble(shu1[i]) + "";
                        }
                        else
                        {
                            sql1 += zds[i + 1].ToString() + "=" + Convert.ToInt32(shu1[i]) + "";
                        }
                    }
                    else
                    {
                        if (shu2[i] == "varchar")
                        {
                            sql1 += zds[i + 1].ToString() + "='" + shu1[i] + "',";
                        }
                        else if (shu2[i] == "decimal")
                        {
                            sql1 += zds[i + 1].ToString() + "=" + Convert.ToDouble(shu1[i]) + ",";
                        }
                        else
                        {
                            sql1 += zds[i + 1].ToString() + "=" + Convert.ToInt32(shu1[i]) + ",";
                        }
                    }
                }
                int bid = Convert.ToInt32(Request.Form["bid"]);
                dal.caozuo("update "+c+" set "+sql1+" where id="+bid+"");
                fanhui = "修改成功";
            }
            catch (Exception es)
            {
                fanhui = "系统提示：" + es.Message + "请检查您的输入项是否有误！"; 
            }
            Response.Write(fanhui);
            Response.End();
        }
    }
}