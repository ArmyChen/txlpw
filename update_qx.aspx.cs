using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class update_qx : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string zhi = Request.Form["zhi"];
                string in1 =Request.Form["in1"];
                
                string up = Request.Form["up"];
                string de = Request.Form["de"];
                string se = Request.Form["se"];
                string sh = Request.Form["sh"];
                string gj = Request.Form["gj"];
                int id = Convert.ToInt32(Request.Form["id"]);
                if (dal.caozuo("update qx set qname='" + zhi + "',qinsert='" + in1 + "',qupdate='" + up + "',qdelete='" + de + "',qselect='" + se + "',qshenhe='" + sh + "',qgaoji='" + gj + "' where id=" + id + "") > 0)
                {
                    fanhui = "修改成功";
                }
                else
                {
                    fanhui = "修改失败";
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