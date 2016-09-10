using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class goodxiang : System.Web.UI.Page
{
    DAL dal = new DAL();
    imgclass imgs = new imgclass();
    public string sname;
    public string bh;
    public string sj;
    public string cs;
    public string tp;
    public string nr;
    public string dq;
    public string cd;
    public string gg;
    public string lb;
    public string lxr;
    public string lxdh;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int gid = Convert.ToInt32(Request.QueryString["gid"]);
            dal.sqlcaozuo("update messages set lll=lll+1 where id=@a1","@a1,",""+gid.ToString()+",");
            foreach (DataRow dt in dal.sqlselect("select * from messages where id=@a1","@a1,",""+gid.ToString()+",").Rows)
            {
                sname = dt["mname"].ToString();
                bh = gid.ToString();
                sj = dt["ftime"].ToString();
                cs = dt["lll"].ToString();
                tp =imgs.GetFirstHtmlImg(dt["mtu"].ToString());
                if (tp == "")
                {
                    tp = "tpimg/mrtp.jpg";
                }
                nr = dt["mxxjs"].ToString();
                dq = dt["mdiqu"].ToString();
                cd = dt["mchandi"].ToString();
                gg = dt["mguige"].ToString();
                lb = dt["mleibie"].ToString();
                lxr = dt["mlxr"].ToString();
                lxdh = dt["mlxdh"].ToString();
            }
        }
    }
}