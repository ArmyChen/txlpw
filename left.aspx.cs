using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class left : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string systemStr = "";
            string qxs = "";
            foreach (DataRow dt in dal.select("select * from admin where aname='" + Request.Cookies["tcadmin"].Value + "'").Rows)
            {
                qxs = dt["shu"].ToString();
            }
            string ck = "";
            foreach (DataRow dt in dal.select("select * from qx where qname='" + qxs + "'").Rows)
            {
                ck = dt["qselect"].ToString();
            }
            foreach (DataRow dt in dal.select("select * from mode where mdeng=1 order by mpai desc").Rows)
            {
                int mid = Convert.ToInt32(dt["mid"].ToString());
                systemStr += "<span onclick=qh(" + mid + ") style='display:block;width=160px;text-align:left;font-size:12px;color:#f9f3f3;padding:5px 0px 5px 10px;cursor:pointer; clear:both;background-color:#469ade;border-bottom:1px solid #39adb6'><font face='微软雅黑'>+" + dt["mname"].ToString() + "</font></span>";
                systemStr += "<div class='a" + mid + "' style='display:none;'>";
                foreach (DataRow dt1 in dal.select("select * from mode where msu=" + mid + " order by mpai desc").Rows)
                {
                    string ctszhi = dt1["mname"].ToString() + ",";
                    if (ck.IndexOf(ctszhi) != -1)
                    {
                        systemStr += "<a id='b" + dt1["mid"].ToString() + "' onmouseover=yd(" + dt1["mid"].ToString() + ") onmouseout=yk(" + dt1["mid"].ToString() + ") href='" + dt1["murl"].ToString() + "' target='midFrame' style='display:block;width=160px;text-align:left;font-size:12px;color:#0e5060;padding:5px 0px 5px 10px;cursor:pointer;text-decoration:none; clear:both;background-color:white;'><font face='微软雅黑'>--" + dt1["mname"].ToString() + "</font></a>";
                    }
                }
                systemStr += "</div>";
            }
            this.Label1.Text = systemStr;
        }
    }
}