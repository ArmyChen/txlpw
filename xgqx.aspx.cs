using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class xgqx : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            int sid=Convert.ToInt32(Request.QueryString["sid"]);
            t1.Value = sid.ToString();
            string in1 = "";
            string up = "";
            string de = "";
            string se = "";
            string sh = "";
            string gj = "";
            foreach (DataRow dt in dal.select("select * from qx where id="+sid+"").Rows)
            {
                qxz.Value = dt["qname"].ToString();
                in1 = dt["qinsert"].ToString();
                up = dt["qupdate"].ToString();
                de = dt["qdelete"].ToString();
                se = dt["qselect"].ToString();
                sh = dt["qshenhe"].ToString();
                gj = dt["qgaoji"].ToString();
                this.Label2.Value = dt["qinsert"].ToString();
                this.Label3.Text = dt["qupdate"].ToString();
                this.Label4.Text = dt["qdelete"].ToString();
                this.Label5.Text = dt["qselect"].ToString();
                this.Label6.Text = dt["qshenhe"].ToString();
                this.Label7.Text = dt["qgaoji"].ToString();
            }
            
            foreach (DataRow dt in dal.select("select * from mode where mdeng=1 order by mpai desc").Rows)
            {
                this.Label1.Text += "<div style='padding-top:10px; clear:both;'><span style='font-size:12px; color:#323232;'><font face='宋体'>" + dt["mname"].ToString() + "</font></span></div>";
                foreach (DataRow dt1 in dal.select("select * from mode where mdeng=2 and msu=" + Convert.ToInt32(dt["mid"].ToString()) + " order by mpai desc").Rows)
                {
                    string in2 = "";
                    string up1 = "";
                    string de1 = "";
                    string se1 = "";
                    string sh1 = "";
                    string gj1 = "";
                    if (in1.IndexOf("新增" + dt1["mname"] + ",") != -1)
                    {
                        in2 = "checked";
                    }
                    else
                    {
                        in2 = "";
                    }
                    if (up.IndexOf("修改" + dt1["mname"] + ",") != -1)
                    {
                        up1 = "checked";
                    }
                    else
                    {
                        up1 = "";
                    }
                    if (de.IndexOf("删除" + dt1["mname"] + ",") != -1)
                    {
                        de1 = "checked";
                    }
                    else
                    {
                        de1 = "";
                    }
                    if (se.IndexOf("查看" + dt1["mname"] + ",") != -1)
                    {
                        se1 = "checked";
                    }
                    else
                    {
                        se1 = "";
                    }
                    if (sh.IndexOf("查看审核" + dt1["mname"] + ",") != -1)
                    {
                        sh1 = "checked";
                    }
                    else
                    {
                        sh1 = "";
                    }
                    this.Label1.Text += "<div style='padding-top:10px; overflow:hidden; clear:both;'><div style='float:left; width:190px;'><span style='font-size:12px; color:#323232;'><font face='宋体'>-----" + dt1["mname"].ToString() + "</font></span></div><div style='float:left;'><input type='checkbox' "+in2+" onclick=djs('新增" + dt1["mname"].ToString() + "','0') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>新增</span><input type='checkbox' "+up1+" onclick=djs('修改" + dt1["mname"].ToString() + "','1') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>修改</span><input type='checkbox' "+de1+" onclick=djs('删除" + dt1["mname"].ToString() + "','2') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>删除</span><input type='checkbox' "+se1+" onclick=djs('查看" + dt1["mname"].ToString() + "','3') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>查看</span><input type='checkbox' "+sh1+" onclick=djs('查看审核" + dt1["mname"].ToString() + "','4') class='juzhong' /><span style='vertical-align:middle; margin-right:10px;'>查看审核信息</span></div></div>";
                }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>location.href='qx.aspx';</script>");
    }
}