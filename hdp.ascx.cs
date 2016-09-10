using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class hdp : System.Web.UI.UserControl
{
    DAL dal = new DAL();
    imgclass imgs = new imgclass();
    public string hdps;
    public string biao = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int zhi = 1;
            foreach (DataRow dt in dal.select("select * from hdp order by hpai desc").Rows)
            {
                string img_url = imgs.GetFirstHtmlImg(dt["himgurl"].ToString());
                if (img_url == "")
                {
                    img_url = "images/mrhdp.jpg";
                }

                if (zhi == 1)
                {
                    biao += "<a title='" + dt["hname"].ToString() + "' href='javascript:void(0)' class='ggOn'><em>" + dt["hname"].ToString() + "</em></a>";
                    hdps += "<a href='"+dt["hurl"].ToString()+"' target='_blank' title='"+dt["hname"].ToString()+"' style='z-index: 3; opacity: 4;'><img src='"+img_url+"' alt='' style='width:1200px; height:380px;' /></a>";
                }
                else
                {
                    biao += "<a title='" + dt["hname"].ToString() + "' href='javascript:void(0)'><em>" + dt["hname"].ToString() + "</em></a>";
                    hdps += "<a href='" + dt["hurl"].ToString() + "' target='_blank' title='" + dt["hname"].ToString() + "'><img src='" + img_url + "' alt='' style='width:1200px; height:380px;' /></a>";
                }
                zhi += 1;

            }
        }
    }
}