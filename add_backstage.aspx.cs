using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class add_backstage : System.Web.UI.Page
{
    DAL dal = new DAL();
    ArrayList list = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //生成上传控件
            string currentdir = "D:\\";     //搜索的目录
            if (currentdir[currentdir.Length - 1] != '\\')   //非根目录
            {
                currentdir += "\\";
            }
            FindFile(currentdir);     //调用查找文件函数


            int mid = Convert.ToInt32(Request.QueryString["mid"]);
            string biaoming = "";
            foreach (DataRow dt in dal.select("select * from mode where mid=" + mid + "").Rows)
            {
                this.Label2.Text = dt["mname"].ToString();
                int su = Convert.ToInt32(dt["msu"].ToString());
                biaoming = dt["mbiao"].ToString();
                foreach (DataRow dt1 in dal.select("select * from mode where mid=" + su + "").Rows)
                {
                    this.Label1.Text = dt1["mname"].ToString();
                }
            }
            string sjzd = "";
            string kjzd = "";
            string bm = "";
            foreach (DataRow dt in dal.select("select * from cpu_center where zwm='" + biaoming + "'").Rows)
            {
                sjzd = dt["fieldnames"].ToString();
                kjzd = dt["kongjian"].ToString();
                bm = dt["sjk"].ToString();
            }
            string[] array1 = sjzd.Split(',');
            string[] array2 = kjzd.Split(',');
            string str_array1 = "";
            this.Label4.Text += "<script>";
            int zs = 0;
            for (int i = 0; i < array2.Length - 1; i++)
            {
                if (array2[i] == "文本框")
                {
                    qz.Value += "a" + i + "|文本框,";
                    str_array1 += "<tr><td class='td1'>"+array1[i].ToString()+"：</td><td class='td2'><input type='text' id='a"+i+"' class='text1'/></td></tr>";
                }
                else if (array2[i] == "详细信息框")
                {
                    qz.Value += "a" + i + "_" + zs + "|详细信息框,";
                    str_array1 += "<tr><td class='td1'>" + array1[i].ToString() + "：</td><td class='td2'><textarea id='a"+i+"_"+zs+"' style='width:100%;height:500px;'></textarea></td></tr>";
                    this.Label4.Text += "var ue = UE.getEditor('a" + i + "_" + zs + "');";
                    zs += 1;
                }
                else if (array2[i].IndexOf("下拉框")!=-1)
                {
                    qz.Value += "a" + i + "|下拉框,";
                    //获取基本信息
                    string [] array3 = array2[i].ToString().Split('|');
                    string sjgj = array3[1].ToString();
                    string[]array4 = sjgj.Split('/');
                    string b1 = array4[0].ToString();
                    string zd = array4[1].ToString();
                    string str = "";
                    str += "<select id='a" + i + "'>";
                    foreach (DataRow dt in dal.select("select * from "+b1+"").Rows)
                    {
                        str += "<option value =" + dt[zd].ToString() + ">" + dt[zd].ToString() + "</option>";
                    }
                    str += "</select>";
                    str_array1 += "<tr><td class='td1'>" + array1[i].ToString() + "：</td><td class='td2'>"+str+"</td></tr>";
                }
                else if (array2[i].IndexOf("图片上传控件") != -1)
                {
                    qz.Value += "a" + i + "_" + zs + "|图片上传控件,";
                    str_array1 += "<tr><td class='td1'>" + array1[i].ToString() + "：</td><td class='td2'><textarea id='a" + i + "_" + zs + "' style='width:100%;height:500px;'></textarea></td></tr>";
                    this.Label4.Text += "var ue = UE.getEditor('a" + i + "_" + zs + "');";
                    
                    zs += 1;
                }
            }
            str_array1 += "<tr><td class='td1'>&nbsp;</td><td class='td2'><input type='button' class='but1' onclick='add_bac("+mid+")' value='添加'/>&nbsp;<input type='button' class='but1' value='返回' onclick='fh("+mid+")'/></td></tr>";
            this.Label3.Text = str_array1;
            this.Label4.Text += "</script>";
        }
    }
    public void FindFile(string dir)                           //参数为指定的目录
    {
        DirectoryInfo Dir = new DirectoryInfo(dir);
        try
        {
            
            string str = "";
            foreach (FileInfo f in Dir.GetFiles("*.*"))             //查找文件
            {
                str += Dir + f.ToString()+",";
            }
            string str2 = "";
            string[] array1 = str.Split(',');
            for (int i = 0; i < array1.Length - 1; i++)
            {
                string[] mingc = array1[i].Split('\\');
                string m = mingc[mingc.Length - 1];
                string dizhi = "";
                for (int j = 0; j < mingc.Length; j++)
                {
                    dizhi += mingc[j] + ",";
                }
                if (array1[i].IndexOf(".jpg") != -1 || array1[i].IndexOf(".JPG") != -1 || array1[i].IndexOf(".jpeg") != -1 || array1[i].IndexOf(".JPEG") != -1 || array1[i].IndexOf(".png") != -1 || array1[i].IndexOf(".PNG") != -1 || array1[i].IndexOf(".gif") != -1 || array1[i].IndexOf(".GIF") != -1 || array1[i].IndexOf(".bmp") != -1 || array1[i].IndexOf(".BMP") != -1)
                {
                    str2 += "<div style='float:left;width:70px;margin-right:5px; margin-bottom:8px;'><img src=" + array1[i] + " title='" + array1[i] + "' onclick=djd('" +dizhi+ "') style=' cursor:pointer; width:70px;height:70px;'/><div style='padding-top:3px;text-align:center;width:70px; height:24px; overflow:hidden; clear:both;'><span style='font-size:12px;'>" + m + "</span></div></div>";
                }
            }
            string ct = "";
            foreach (DirectoryInfo d in Dir.GetDirectories())     //查找子目录   
            {
                ct += Dir + d.ToString() + ",";
            }
            string[] array2 = ct.Split(',');
            for (int i = 0; i < array2.Length - 1; i++)
            {
                string[] mingc = array2[i].Split('\\');
                string m=mingc[mingc.Length-1];
                string dizhi = "";
                for (int j = 0; j < mingc.Length; j++)
                {
                    dizhi += mingc[j] + ",";
                }
                str2 += "<div style='float:left;width:70px;margin-right:5px; margin-bottom:8px;'><img src='tcimg/wjj.png' title='" + array2[i] + "' onclick=djd('" + dizhi + "') style=' cursor:pointer; width:70px;'/><div style='padding-top:3px;text-align:center;width:70px; height:24px; overflow:hidden; clear:both;'><span style='font-size:12px;'>" + m + "</span></div></div>";
            }
            this.Label5.Text = str2;
        }
        catch (Exception)
        {

        }
    }
}