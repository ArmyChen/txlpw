using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mobile_fabu : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            this.DropDownList1.DataSource=dal.select("select * from address_s order by spai desc");
this.DropDownList1.DataTextField="sname";
this.DropDownList1.DataValueField="sname";
this.DropDownList1.DataBind();
this.Image1.ImageUrl="../tpimg/mrtp.jpg";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name1 = System.DateTime.Now.ToFileTimeUtc().ToString();
        string name = FileUpload1.FileName;//获得上传文件的名字.
        string size = FileUpload1.PostedFile.ContentLength.ToString();//文件大小.
        string type = FileUpload1.PostedFile.ContentType;//文件类型.
        string type2 = name.Substring(name.LastIndexOf(".") + 1);//LastIndexOf()最后一个索引位置匹配.Substring()里面的+1是重载.
        string ipath = Server.MapPath("../upimg") + "/" + name1 + "." + type2;//取得根目录下面的upimg目录的路径.
        string fpath = Server.MapPath("../upfile") + "/" + name1 + "." + type2;
        string wpath = "../upimg/" + name1 + "." + type2;//获得虚拟路径.
        string wpath1 = "../upfile/" + name1 + "." + type2;
        if (type2 == "jpg" || type2 == "gif" || type2 == "bmp" || type2 == "png" || type2 == "JPG" || type2 == "GIF" || type2 == "BMP" || type2 == "PNG" || type2 == "JPEG" || type2 == "jpeg")
        {
            FileUpload1.SaveAs(ipath);//保存方法,参数是一个地址字符串.
            Image1.ImageUrl = wpath;
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('上传成功');</script>");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('格式错误');</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            //if (Request.Cookies["txlpadmin"] != null)
            //{
            if (TextBox1.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请输入产品名称');</script>");
            }
            else
            {
                DateTime t1 = DateTime.Now.AddDays(7);
                dal.sqlcaozuo1("insert into messages values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13,@a14,@a15)", "@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13,@a14,@a15,", "" + TextBox1.Text + "★" + DropDownList1.Text + "★<img src=" + Image1.ImageUrl.Replace("../","") + " />★" + TextBox2.Text + "★★" + TextBox4.Text + "★" + TextBox5.Text + "★" + t1.ToString() + "★★" + a1.Value + "★0★游客★" + DateTime.Now.ToString() + "★511★0★");
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('发布成功');location.href='index.aspx';</script>");
            }
            //}
            //else
            //{
            //    Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请登录');location.href='land.aspx';</script>");
            //}
        }
        catch (Exception es)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('" + es.Message + "');</script>");
        }
    }
}