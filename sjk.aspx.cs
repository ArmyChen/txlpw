using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class sjk : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string str = "";
            string sname = Request.QueryString["sname"];
            if (sname != null)
            {
                dal.caozuo("drop table " + sname + "");

                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('表删除成功');</script>");

            }
            foreach (DataRow dt in dal.select("Select Name FROM SysObjects Where XType='U' orDER BY Name").Rows)
            {
                str += "<tr><td style='width:200px; text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; font-size:0px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt[0].ToString() + "</font></span></div></td><td style='text-align:center; border:1px solid #186a6d;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><a href='sjk.aspx?sname=" + dt[0].ToString() + "' style='font-size:12px; color:#2b8593; text-decoration:none; margin-right:15px;'><font face='宋体'>删除表</font></a><a href='dk.aspx?sname=" + dt[0].ToString() + "' style='font-size:12px; color:#2b8593; text-decoration:none; margin-right:15px;'><font face='宋体'>打开表</font></a></div></td></tr>";
            }
            this.Label1.Text = str;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='addsjk.aspx';</script>");
    }
}