using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class bool_ajax : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fanhui = "";
            try
            {
                string bm = Request.Cookies["bsmcookies"].Value;
                string ren = Request.Cookies["tcadmin"].Value;
                if (dal.land("select count(*) from bsm where bname='" + ren + "' and bma='" + bm + "'") > 0)
                {

                }
                else
                {
                    fanhui = "0";
                    HttpCookie chp = new HttpCookie("bsmcookies");
                    chp.Expires = DateTime.Now.AddYears(-1);
                    Response.Cookies.Add(chp);
                    HttpCookie chp1 = new HttpCookie("tcadmin");
                    chp1.Expires = DateTime.Now.AddYears(-1);
                    Response.Cookies.Add(chp1);
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