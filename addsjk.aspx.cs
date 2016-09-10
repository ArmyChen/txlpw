using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class addsjk : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='sjk.aspx';</script>");
    }
    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (bm.Value == "")
    //        {
    //            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入表名');</script>");
    //        }
    //        else if (Label2.Text == "")
    //        {
    //            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入字段名');</script>");
    //        }
    //        else
    //        {
    //            string sql1 = "CREATE " + bm.Value + "(";
    //            string sql2 = Label2.Text;
    //            string sql3 = sql1 + sql2 + ")";
    //            if (dal.caozuo(sql3) > 0)
    //            {
    //                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('创建成功');window.location.href='sjk.aspx';</script>");
    //            }
    //            else
    //            {
    //                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('创建失败');window.location.href='sjk.aspx';</script>");
    //            }
    //        }
    //    }
    //    catch (Exception es)
    //    {
    //        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('"+es.Message+"');</script>");
    //    }
    //}
}