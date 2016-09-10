using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mobile_index : System.Web.UI.Page
{
    DAL dal = new DAL();
    imgclass imgs = new imgclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string cityname = "";
            string city = Request.QueryString["city"];
            if (city == null)
            {
                if (Request.Cookies["txlpcity"] != null)
                {
                    cityname = Server.UrlDecode(Request.Cookies["txlpcity"].Value);
                }
                else
                {
                    HttpCookie ci1 = new HttpCookie("txlpcity");
                    ci1.Value = Server.UrlEncode("重庆市");
                    Response.Cookies.Add(ci1);
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>location.href='index.aspx?citytruename=重庆市';</script>");
                }
            }
            else
            {
                HttpCookie ci1 = new HttpCookie("txlpcity");
                ci1.Value = Server.UrlEncode(city);
                Response.Cookies.Add(ci1);
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>location.href='index.aspx?citytruename=" + city + "';</script>");
            }
            if (Request.Cookies["txlpcity"] != null)
            {
                cityname = Server.UrlDecode(Request.Cookies["txlpcity"].Value);
            }
            else
            {

                string conn, ipstr, addstr;
                conn = Server.MapPath("QQWry.Dat");
                ipstr = HttpContext.Current.Request.UserHostAddress;//获取客户端ip地址
                addstr = IPLocation.IPLocation.IPLocate(conn, ipstr);
                cityname = addstr;

            }
            foreach (DataRow dt in dal.select("select * from messages  where myxq!='永久' order by mpai desc").Rows)
            {
                string dqq = dt["mdiqu"].ToString();
                //if (dt["myxq"].ToString() == "永久")
                //{
                //    string tupian = imgs.GetFirstHtmlImg(dt["mtu"].ToString());
                //    if (tupian == "")
                //    {
                //        tupian = "tpimg/mrtp.jpg";
                //    }
                //    string zhi = dt["mlxr"].ToString();
                //    if (dt["mname"].ToString() == "")
                //    {
                //        zhi = "不详";
                //    }
                //    else
                //    {
                //        if (dt["mname"].ToString().Length > 16)
                //        {
                //            zhi = dt["mname"].ToString().Substring(0, 16) + "...";
                //        }
                //        else
                //        {
                //            zhi = dt["mname"].ToString();
                //        }
                //    }
                //    this.Label4.Text += "<div style='padding:20px 10px 20px 10px; position:relative; z-index:1; border-bottom:1px solid #e8e8e8; clear:both;'><div style='padding-top:10px; clear:both;'><a href='xq.aspx?xid=" + dt["id"].ToString() + "' style='font-size:1.1em; color:#323232; text-decoration:none;'><font face='微软雅黑'><b>" + zhi + "</b></font></a></div><div style='padding-top:10px; clear:both;'><span style='font-size:14px; color:#888888; text-decoration:none;'><font face='宋体'>" + dt["mchandi"].ToString() + "</font></span></div><a href='tel:" + dt["mlxdh"].ToString() + "' mce_href='tel:" + dt["mlxdh"].ToString() + "'><img src='images/dhtb.png' style='border:0px; width:50px; position:absolute; top:30px; right:6px; z-index:999; height:50px;'/></a></div>";
                //}
                //else
                //{
                    if (cityname.IndexOf(dqq) != -1)
                    {
                        DateTime gq = Convert.ToDateTime(dt["myxq"].ToString());
                        DateTime now = DateTime.Now;
                        TimeSpan t1 = gq.Subtract(now);
                        int hou = t1.Hours;
                        if (hou > 0)
                        {
                            string tupian = imgs.GetFirstHtmlImg(dt["mtu"].ToString());
                            if (tupian == "")
                            {
                                tupian = "tpimg/mrtp.jpg";
                            }
                            string zhi = dt["mlxr"].ToString();
                            if (dt["mname"].ToString() == "")
                            {
                                zhi = "不详";
                            }
                            else
                            {
                                if (dt["mname"].ToString().Length > 16)
                                {
                                    zhi = dt["mname"].ToString().Substring(0, 16) + "...";
                                }
                                else
                                {
                                    zhi = dt["mname"].ToString();
                                }
                            }
                            this.Label4.Text += "<div onclick=hq("+dt["id"].ToString()+") style='padding:20px 10px 20px 10px; position:relative; z-index:1; border-bottom:1px solid #e8e8e8; clear:both;'><a href='xq.aspx?xid=" + dt["id"].ToString() + "' style=' text-decoration:none;display:block'><div style='padding-top:10px; clear:both;'><a href='xq.aspx?xid=" + dt["id"].ToString() + "' style='font-size:1.1em; color:#323232; text-decoration:none;'><font face='微软雅黑'><b>" + zhi + "</b></font></a></div><div style='padding-top:10px; clear:both;'><span style='font-size:14px; color:#888888; text-decoration:none;'><font face='宋体'>" + dt["mchandi"].ToString() + "</font></span></div></a><a href='tel:" + dt["mlxdh"].ToString() + "' mce_href='tel:" + dt["mlxdh"].ToString() + "'><img src='images/dhtb.png' style='border:0px; width:50px; position:absolute; top:30px; right:6px; z-index:999; height:50px;'/></a></div>";
                        }
                    }
                //}
            }
            foreach (DataRow dt in dal.select("select * from messages where myxq='永久' order by mpai desc").Rows)
            {

                string tupian = imgs.GetFirstHtmlImg(dt["mtu"].ToString());
                if (tupian == "")
                {
                    tupian = "tpimg/mrtp.jpg";
                }
                string zhi = dt["mlxr"].ToString();
                if (dt["mname"].ToString() == "")
                {
                    zhi = "不详";
                }
                else
                {
                    if (dt["mname"].ToString().Length > 16)
                    {
                        zhi = dt["mname"].ToString().Substring(0, 16) + "...";
                    }
                    else
                    {
                        zhi = dt["mname"].ToString();
                    }
                }
                this.Label1.Text += "<a href='xq.aspx?xid=" + dt["id"].ToString() + "' style=' text-decoration:none;display:block'><div onclick=hq(" + dt["id"].ToString() + ") style='padding:20px 10px 20px 10px; position:relative; z-index:1; border-bottom:1px solid #e8e8e8; clear:both;'><div style='padding-top:10px; clear:both;'><a href='xq.aspx?xid=" + dt["id"].ToString() + "' style='font-size:1.1em; color:#323232; text-decoration:none;'><font face='微软雅黑'><b>" + zhi + "</b></font></a></div><div style='padding-top:10px; clear:both;'><span style='font-size:14px; color:#888888; text-decoration:none;'><font face='宋体'>" + dt["mchandi"].ToString() + "</font></span></div><a href='tel:" + dt["mlxdh"].ToString() + "' mce_href='tel:" + dt["mlxdh"].ToString() + "'><img src='images/dhtb.png' style='border:0px; width:50px; position:absolute; top:30px; right:6px; z-index:999; height:50px;'/></a></div></a>";
            }
            if (this.Label4.Text == "")
            {
                this.Label4.Text = "<span style-'font-size:20px; color:#000000;'><b>该地区暂无信息，请重新选择临近城市或上级城市<a href='city.aspx' style='color:#ff0000;'>[点击切换城市]</a>！</b></span>";
            }
        }
    }
}