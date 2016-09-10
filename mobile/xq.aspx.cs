using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class mobile_xq : System.Web.UI.Page
{
    DAL dal = new DAL();
    imgclass imgs = new imgclass();
    public string dh;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int xid = Convert.ToInt32(Request.QueryString["xid"]);
            foreach (DataRow dt in dal.sqlselect("select * from messages where id=@a1","@a1,",""+xid.ToString()+",").Rows)
            {
                this.Label1.Text = dt["mname"].ToString();
                this.Label2.Text = "发布时间：" + Convert.ToDateTime(dt["ftime"].ToString()).Year+"-" + Convert.ToDateTime(dt["ftime"].ToString()).Month+"-" + Convert.ToDateTime(dt["ftime"].ToString()) .Day+ "&nbsp;" + dt["lll"].ToString()+"人";
                this.Label3.Text = dt["mchandi"].ToString();
                this.Label4.Text = dt["mlxr"].ToString();
                this.Label5.Text = dt["mlxdh"].ToString();
                this.Label6.Text = "<a href='tel:" + dt["mlxdh"].ToString() + "' mce_href='tel:" + dt["mlxdh"].ToString() + "'><img src='images/dhlx.jpg' style='border:0px; width:187px; height:48px;'/></a>";
                string xxxx= dt["mxxjs"].ToString().Replace("upload","../upload");
                string tp = "../"+imgs.MyGetImgUrl(xxxx);

                this.Label7.Text=xxxx;
                this.Label8.Text = dt["mlxr"].ToString();
                this.Label9.Text = dt["mlxdh"].ToString();
                dh = dt["mlxdh"].ToString();
            }
        }
    }
}