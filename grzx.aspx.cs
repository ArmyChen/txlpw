using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class grzx : System.Web.UI.Page
{
    DAL dal = new DAL();
    imgclass imgs = new imgclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["txlpadmin"] != null)
            {
                this.DropDownList1.DataSource = dal.select("select * from address_s order by spai desc");
                this.DropDownList1.DataTextField = "sname";
                this.DropDownList1.DataValueField = "sname";
                this.DropDownList1.DataBind();
                foreach (DataRow dt in dal.select("select * from messages where shu='"+Request.Cookies["txlpadmin"].Value+"'").Rows)
                {
                    this.TextBox1.Text = dt["mname"].ToString();
                    this.DropDownList1.Text = dt["mdiqu"].ToString();
                    this.Image1.ImageUrl =imgs.GetFirstHtmlImg(dt["mtu"].ToString());
                    this.TextBox2.Text = dt["mchandi"].ToString();
                    this.TextBox4.Text = dt["mlxr"].ToString();
                    this.TextBox5.Text = dt["mlxdh"].ToString();
                    this.a1.Value = dt["mxxjs"].ToString();
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('请登录');location.href='land.aspx';</script>");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        dal.caozuo("update messages set mname='" + TextBox1.Text + "',mdiqu='" + DropDownList1.Text + "',mtu='<img src=" + Image1.ImageUrl + " >',mchandi='" + TextBox2.Text + "',mlxr='" + TextBox4.Text + "',mlxdh='" + TextBox5.Text + "',mxxjs='" + a1.Value + "',myxq='" + DateTime.Now.ToString() + "' where shu='" + Request.Cookies["txlpadmin"].Value + "'");
        Page.ClientScript.RegisterStartupScript(GetType(),"","<script>alert('修改成功');</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name1 = System.DateTime.Now.ToFileTimeUtc().ToString();
        string name = FileUpload1.FileName;//获得上传文件的名字.
        string size = FileUpload1.PostedFile.ContentLength.ToString();//文件大小.
        string type = FileUpload1.PostedFile.ContentType;//文件类型.
        string type2 = name.Substring(name.LastIndexOf(".") + 1);//LastIndexOf()最后一个索引位置匹配.Substring()里面的+1是重载.
        string ipath = Server.MapPath("upimg") + "/" + name1 + "." + type2;//取得根目录下面的upimg目录的路径.
        string fpath = Server.MapPath("upfile") + "/" + name1 + "." + type2;
        string wpath = "upimg/" + name1 + "." + type2;//获得虚拟路径.
        string wpath1 = "upfile/" + name1 + "." + type2;
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
    
}