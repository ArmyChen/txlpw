using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class top : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HttpCookie cook = Request.Cookies["tcadmin"];
            if (cook != null)
            {
                
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.open('login.aspx','_parent','');window.close();</script>");
            }
        }
    }
}