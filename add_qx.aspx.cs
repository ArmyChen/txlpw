using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class add_qx : System.Web.UI.Page
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
                string in1 = Request.Form["in1"];
                string up = Request.Form["up"];
                string de = Request.Form["de"];
                string se = Request.Form["se"];
                string sh = Request.Form["sh"];
                string gj = Request.Form["gj"];
                dal.caozuo("insert into qx values('"+zhi+"','"+in1+"','"+up+"','"+de+"','"+se+"','"+sh+"','"+gj+"','已通过')");
                fanhui = "新增成功";
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