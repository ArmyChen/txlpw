using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mobile_city : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string cname = Request.QueryString["cname"];
            //Response.Write(cname);
            if (cname != null)
            {
                HttpCookie c1 = new HttpCookie("txlpcity");
                c1.Value = Server.UrlEncode(cname);
                Response.Cookies.Add(c1);
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>location.href='index.aspx?citytruename="+cname+"';</script>");
            }
            string[] zm = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            string ioliu = "";
            for (int i = 0; i < zm.Length - 1; i++)
            {
                this.Label2.Text += "<a href='city.aspx?aname=" + zm[i] + "' style='font-size:16px; color:#7724f5; text-decoration:none; float:left; margin:13px;'><font face='宋体'>" + zm[i] + "</font></a>";
                ioliu += "<div style='padding:10px; background-color:#e8e8e8; text-align:center; border-bottom:1px solid #d5d5d5;  clear:both;'><span style='font-size:14px; color:#e07211;'><font face='arial'><b>" + zm[i] + "：</b><font></span></div>";
                if (zm[i] == "C")
                {
                    ioliu += "<a href='index.aspx?citytruename=重庆市' style='font-size:1.1em; color:#7724f5; text-decoration:none; float:left; margin:15px;'><font face='微软雅黑'>重庆市</font></a>";
                }
                foreach (DataRow dt in dal.select("select * from address_s where dbo.f_GetPy(sname) like '" + zm[i] + "%' order by spai desc").Rows)
                {
                    ioliu += "<a href='index.aspx?citytruename=" + dt["sname"].ToString() + "' style='font-size:1.1em; color:#7724f5; text-decoration:none; float:left; margin:15px;'><font face='微软雅黑'>" + dt["sname"].ToString() + "</font></a>";
                }
            }
            string aname = Request.QueryString["aname"];
            if (aname != null)
            {
                ioliu = "";
                if (aname == "C")
                {
                    ioliu += "<a href='index.aspx?citytruename=重庆市' style='font-size:1.1em; color:#7724f5; text-decoration:none; float:left; margin:15px;'><font face='微软雅黑'>重庆市</font></a>";
                }
                foreach (DataRow dt in dal.select("select * from address_s where dbo.f_GetPy(sname) like '" + aname + "%' order by spai desc").Rows)
                {
                    ioliu += "<a href='index.aspx?citytruename=" + dt["sname"].ToString() + "' style='font-size:1.1em; color:#7724f5; text-decoration:none; float:left; margin:15px;'><font face='微软雅黑'>" + dt["sname"].ToString() + "</font></a>";
                }
            }
            this.Label1.Text = ioliu;
        }
    }
}