using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class city : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string cname = Request.QueryString["cname"];
            if (cname != null)
            {
                HttpCookie c1 = new HttpCookie("txlpcity");
                c1.Value = Server.UrlEncode(cname);
                Response.Cookies.Add(c1);
                Page.ClientScript.RegisterStartupScript(GetType(),"","<script>location.href='index.aspx';</script>");
            }
            string[] zm = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",};
            string ioliu = "";
            for (int i = 0; i < zm.Length - 1; i++)
            {
                ioliu += "<div style='padding:10px; clear:both;'><span style='font-size:14px; color:#e07211;'><font face='arial'><b>"+zm[i]+"：</b><font>";
                if (zm[i] == "C")
                {
                    ioliu += "<a href='city.aspx?cname=重庆市' style='font-size:12px; color:#323232; text-decoration:none; margin-right:15px;'><font face='宋体'>重庆市</font></a>";
                }
                foreach (DataRow dt in dal.select("select * from address_s where dbo.f_GetPy(sname) like '"+zm[i]+"%' order by spai desc").Rows)
                {  
                    ioliu += "<a href='city.aspx?cname="+dt["sname"].ToString()+"' style='font-size:12px; color:#323232; text-decoration:none; margin-right:15px;'><font face='宋体'>"+dt["sname"].ToString()+"</font></a>";
                }
                ioliu += "</div>";
            }
            this.Label1.Text = ioliu;
        }
    }
}