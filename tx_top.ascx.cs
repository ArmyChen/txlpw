using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class tx_top : System.Web.UI.UserControl
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["txlpcity"] != null)
            {
                this.Label1.Text = Server.UrlDecode(Request.Cookies["txlpcity"].Value);
            }
            else
            {
                string conn, ipstr, addstr;
                conn = Server.MapPath("QQWry.Dat");
                ipstr = HttpContext.Current.Request.UserHostAddress;//获取客户端ip地址
                addstr = IPLocation.IPLocation.IPLocate(conn, ipstr);
                Label1.Text =addstr;
                HttpCookie c1 = new HttpCookie("txlpcity");
                c1.Value = Server.UrlEncode(addstr);
                Response.Cookies.Add(c1);
                //foreach (DataRow dt in dal.select("select top 1 * from address_s order by spai desc").Rows)
                //{
                //    string zhi = dt["sname"].ToString();
                //    this.Label1.Text = zhi;
                //    HttpCookie c1 = new HttpCookie("txlpcity");
                //    c1.Value = Server.UrlEncode(zhi);
                //    Response.Cookies.Add(c1);
                //}
            }
            if (Request.Cookies["txlpadmin"] != null)
            {
                this.Label2.Text = Request.Cookies["txlpadmin"].Value;
                dlh.Visible = true;
                dlq.Visible = false;
            }
            else
            {
                this.Label2.Text = "";
                dlh.Visible = false;
                dlq.Visible = true; 
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        HttpCookie c1 = new HttpCookie("txlpadmin");
        c1.Expires = DateTime.Now.AddDays(-1);
        Response.Cookies.Add(c1);
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>location.href='index.aspx';</script>");
    }
}