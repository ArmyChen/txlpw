using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class index : System.Web.UI.Page
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
                Page.ClientScript.RegisterStartupScript(GetType(),"","<script>location.href='index.aspx?citytruename="+city+"';</script>");
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
            foreach (DataRow dt in dal.select("select * from messages where myxq!='永久' order by mpai desc").Rows)
            {
                //if (dt["myxq"].ToString() == "永久")
                //{
                //    string tupian = imgs.GetFirstHtmlImg(dt["mtu"].ToString());
                //    if (tupian == "")
                //    {
                //        tupian = "tpimg/mrtp.jpg";
                //    }
                //    this.Label1.Text += "<div style='width:270px;position:relative; background-color:#323232; height:270px; overflow:hidden; float:left; margin:10px 20px 10px 20px;'><img src='tpimg/mrtp.jpg' style='position:absolute; top:0px; left:0px; width:270px;filter:alpha(opacity=50);-moz-opacity: 0.5;opacity: 0.5; z-index:1;' /><div style='position:relative; height:270px; width:270px; text-align:center; z-index:1;'><a href='goodsxiang.aspx?gid=" + dt["id"].ToString() + "' target='_blank'><img src='" + tupian + "' style='max-height:270px; max-width:270px;' /></a><div style='padding:10px; background-color:white;filter:alpha(opacity=80);-moz-opacity: 0.7;opacity: 0.7; text-align:center; position:absolute; bottom:0px; left:0px; width:100%; z-index:999;'><a href='goodsxiang.aspx?gid=" + dt["id"].ToString() + "' target='_blank' style='font-size:14px; color:#000; text-decoration:none;'><font face='华文细黑'>" + dt["mname"].ToString() + "</font></a></div></div></div>";
                //}
                //else
                //{
                    string dqq = dt["mdiqu"].ToString();
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
                            this.Label1.Text += "<div style='width:270px;position:relative; background-color:#323232; height:270px; overflow:hidden; float:left; margin:10px 20px 10px 20px;'><img src='tpimg/mrtp.jpg' style='position:absolute; top:0px; left:0px; width:270px;filter:alpha(opacity=50);-moz-opacity: 0.5;opacity: 0.5; z-index:1;' /><div style='position:relative; height:270px; width:270px; text-align:center; z-index:1;'><a href='goodsxiang.aspx?gid=" + dt["id"].ToString() + "' target='_blank'><img src='" + tupian + "' style='max-height:270px; max-width:270px;' /></a><div style='padding:10px; background-color:white;filter:alpha(opacity=80);-moz-opacity: 0.7;opacity: 0.7; text-align:center; position:absolute; bottom:0px; left:0px; width:100%; z-index:999;'><a href='goodsxiang.aspx?gid=" + dt["id"].ToString() + "' target='_blank' style='font-size:14px; color:#000; text-decoration:none;'><font face='华文细黑'>" + dt["mname"].ToString() + "</font></a></div></div></div>";
                        }
                    }
                //}
            }
            foreach (DataRow dt in dal.select("select * from messages where myxq='永久'").Rows)
            {
                    string tupian = imgs.GetFirstHtmlImg(dt["mtu"].ToString());
                    if (tupian == "")
                    {
                        tupian = "tpimg/mrtp.jpg";
                    }
                    this.Label2.Text += "<div style='width:270px;position:relative; background-color:#323232; height:270px; overflow:hidden; float:left; margin:10px 20px 10px 20px;'><img src='tpimg/mrtp.jpg' style='position:absolute; top:0px; left:0px; width:270px;filter:alpha(opacity=50);-moz-opacity: 0.5;opacity: 0.5; z-index:1;' /><div style='position:relative; height:270px; width:270px; text-align:center; z-index:1;'><a href='goodsxiang.aspx?gid=" + dt["id"].ToString() + "' target='_blank'><img src='" + tupian + "' style='max-height:270px; max-width:270px;' /></a><div style='padding:10px; background-color:white;filter:alpha(opacity=80);-moz-opacity: 0.7;opacity: 0.7; text-align:center; position:absolute; bottom:0px; left:0px; width:100%; z-index:999;'><a href='goodsxiang.aspx?gid=" + dt["id"].ToString() + "' target='_blank' style='font-size:14px; color:#000; text-decoration:none;'><font face='华文细黑'>" + dt["mname"].ToString() + "</font></a></div></div></div>";
            }
            if (this.Label1.Text == "")
            {
                this.Label1.Text = "<div style='padding-top:20px; clear:both;text-align:center; position:absolute; top:350px; left:500px; z-index:999;'><span style-'font-size:60px; color:#000000;'><b>该地区暂无信息，请重新选择临近城市或上级城市<a href='city.aspx' style='color:#ff0000; font-size:40px;'>[点击切换城市]</a>！</b></span></div>";
            }
        }
    }
}