using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addadmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DAL dal = new DAL();
        dal.caozuo("insert into admin(aname,apwd,anc) values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"')");
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('新增成功');location.href='admin.aspx';</script>");
    }
}