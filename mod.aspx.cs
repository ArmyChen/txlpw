using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class mod : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int cid=Convert.ToInt32(Request.QueryString["mid"]);
            if (cid > 0)
            {
                dal.caozuo("delete from mode where mid="+cid+"");
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('模块删除成功');</script>");
            }
            string systemStr = "";
            foreach (DataRow dt in dal.select("select * from mode where mdeng=1 order by mpai desc").Rows)
            {
                int mid = Convert.ToInt32(dt["mid"].ToString());
                systemStr += "<tr><td style='width:150px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:left;padding-left:10px;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt["mname"].ToString() + "</font></span></div></td><td style='width:100px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt["mlan"].ToString() + "</font></span></div></td><td style='width:50px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt["mpai"].ToString() + "</font></span></div></td><td style='width:100px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt["mbiao"].ToString() + "</font></span></div></td><td style='width:100px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt["mlei"].ToString() + "</font></span></div></td><td style='width:200px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt["murl"].ToString() + "</font></span></div></td><td style='text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><a href='xiumod.aspx?mid=" + dt["mid"].ToString() + "' style='font-size:12px; color:#323232; margin-right:10px;'><font face='宋体'>修改</font></a><a href='mod.aspx?mid=" + dt["mid"].ToString() + "' style='font-size:12px; color:#323232'><font face='宋体'>删除</font></a></div></td></tr>";
                foreach (DataRow dt1 in dal.select("select * from mode where msu="+mid+" order by mpai desc").Rows)
                {
                    systemStr += "<tr><td style='width:150px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:left;padding-left:10px;'><span style='font-size:12px; color:#323232'><font face='宋体'>----" + dt1["mname"].ToString() + "</font></span></div></td><td style='width:100px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt1["mlan"].ToString() + "</font></span></div></td><td style='width:50px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt1["mpai"].ToString() + "</font></span></div></td><td style='width:100px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt1["mbiao"].ToString() + "</font></span></div></td><td style='width:100px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt1["mlei"].ToString() + "</font></span></div></td><td style='width:200px;text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><span style='font-size:12px; color:#323232'><font face='宋体'>" + dt1["murl"].ToString() + "</font></span></div></td><td style='text-align:center; border:1px solid #186a6d; background-color:white;'><div style='padding-top:7px; padding-bottom:7px; clear:both; text-align:center;'><a href='xiumod.aspx?mid=" + dt1["mid"].ToString() + "' style='font-size:12px; color:#323232; margin-right:10px;'><font face='宋体'>修改</font></a><a href='mod.aspx?mid=" + dt1["mid"].ToString() + "' style='font-size:12px; color:#323232'><font face='宋体'>删除</font></a></div></td></tr>";  
                }
            }
            this.Label1.Text = systemStr;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='addmod.aspx';</script>");
    }
}