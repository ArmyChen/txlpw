using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class beifenxiazai : System.Web.UI.Page
{
    ArrayList list = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string currentdir = "E://meprojects/软件备用项/web/sjkbf";     //搜索的目录
            if (currentdir[currentdir.Length - 1] != '\\')   //非根目录
            {
                currentdir += "\\";
            }
            FindFile(currentdir);     //调用查找文件函数
        }
    }
    public void FindFile(string dir)                           //参数为指定的目录
    {
        DirectoryInfo Dir = new DirectoryInfo(dir);
        try
        {
            foreach (DirectoryInfo d in Dir.GetDirectories())     //查找子目录   
            {
                FindFile(Dir + d.ToString() + "\\");
                list.Add(Dir + d.ToString() + "\\");
            }
            foreach (FileInfo f in Dir.GetFiles("*.*"))             //查找文件
            {
                list.Add(Dir + f.ToString());
            }
            for (int i = 0; i < list.Count; i++)
            {
                string zhi = list[i].ToString();//D://xiangmu/book/web/sjkbf\books_130784890542393750.bak
                string[] a1 = zhi.Split('\\');
                string zhi1 = a1[a1.Length - 1];
                if (zhi1.IndexOf(".bak") == -1)
                {
                    this.Label1.Text += "<div style='padding:10px; border-bottom:1px solid #969696; background-color:white;clear:both;'><a href='sjkbf/" + zhi1 + "' style='font-size:12px;color:#0064c8;text-decoration:none;'><font face='宋体'>" + zhi1 + "</font></a></div>";
                }
            }
        }
        catch (Exception)
        {

        }
    }
}