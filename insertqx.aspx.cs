using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class insertqx : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            foreach (DataRow dt in dal.select("select * from mode where mdeng=1 order by mpai desc").Rows)
            {
                this.Label1.Text += "<div style='padding-top:10px; clear:both;'><span style='font-size:12px; color:#323232;'><font face='宋体'>" + dt["mname"].ToString() +"</font></span></div>";
                foreach (DataRow dt1 in dal.select("select * from mode where mdeng=2 and msu=" + Convert.ToInt32(dt["mid"].ToString()) + " order by mpai desc").Rows)
                {
                    this.Label1.Text += "<div style='padding-top:10px; overflow:hidden; clear:both;'><div style='float:left; width:190px;'><span style='font-size:12px; color:#323232;'><font face='宋体'>-----" + dt1["mname"].ToString() + "</font></span></div><div style='float:left;'><input type='checkbox' onclick=djs('新增" + dt1["mname"].ToString() + "','0') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>新增</span><input type='checkbox' onclick=djs('修改" + dt1["mname"].ToString() + "','1') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>修改</span><input type='checkbox' onclick=djs('删除" + dt1["mname"].ToString() + "','2') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>删除</span><input type='checkbox' onclick=djs('查看" + dt1["mname"].ToString() + "','3') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>查看</span><input type='checkbox' onclick=djs('查看审核" + dt1["mname"].ToString() + "','4') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>查看审核信息</span></div></div>";
                }
            }
        }
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>location.href='qx.aspx';</script>");
    }
}