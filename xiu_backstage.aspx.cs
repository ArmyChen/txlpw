using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class xiu_backstage : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
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
            int bid=Convert.ToInt32(Request.QueryString["bid"]);
            string zhiss = "";
            foreach (DataRow dt in dal.select("select * from "+bm+" where id="+bid+"").Rows)
            {
                for (int i = 0; i < array2.Length - 1; i++)
                {
                    zhiss += dt[i + 1].ToString() + "⋛";
                }
            }
            string[] array43 = zhiss.Split('⋛');
            for (int i = 0; i < array2.Length - 1; i++)
            {
                if (array2[i] == "文本框")
                {
                    qz.Value += "a" + i + "|文本框,";
                    str_array1 += "<tr><td class='td1'>" + array1[i].ToString() + "：</td><td class='td2'><input type='text' id='a" + i + "' value='"+array43[i]+"' class='text1'/></td></tr>";
                }
                else if (array2[i] == "详细信息框")
                {
                    qz.Value += "a" + i + "_" + zs + "|详细信息框,";
                    str_array1 += "<tr><td class='td1'>" + array1[i].ToString() + "：</td><td class='td2'><textarea id='a" + i + "_" + zs + "' style='width:100%;height:500px;'>" + array43[i] + "</textarea></td></tr>";
                    this.Label4.Text += "var ue = UE.getEditor('a" + i + "_" + zs + "');";
                    zs += 1;
                }
                else if (array2[i].IndexOf("下拉框") != -1)
                {
                    qz.Value += "a" + i + "|下拉框,";
                    //获取基本信息
                    string[] array3 = array2[i].ToString().Split('|');
                    string sjgj = array3[1].ToString();
                    string[] array4 = sjgj.Split('/');
                    string b1 = array4[0].ToString();
                    string zd = array4[1].ToString();
                    string str = "";
                    str += "<select id='a" + i + "'>";
                    str += "<option value =" + array43[i] + ">" + array43[i] + "</option>";
                    foreach (DataRow dt in dal.select("select * from " + b1 + "").Rows)
                    {
                        str += "<option value =" + dt[zd].ToString() + ">" + dt[zd].ToString() + "</option>";
                    }
                    str += "</select>";
                    str_array1 += "<tr><td class='td1'>" + array1[i].ToString() + "：</td><td class='td2'>" + str + "</td></tr>";
                }
                else if (array2[i].IndexOf("图片上传控件") != -1)
                {
                    qz.Value += "a" + i + "_" + zs + "|图片上传控件,";
                    str_array1 += "<tr><td class='td1'>" + array1[i].ToString() + "：</td><td class='td2'><textarea id='a" + i + "_" + zs + "' style='width:100%;height:500px;'>" + array43[i] + "</textarea></td></tr>";
                    this.Label4.Text += "var ue = UE.getEditor('a" + i + "_" + zs + "');";
                    zs += 1;
                }
            }
            str_array1 += "<tr><td class='td1'>&nbsp;</td><td class='td2'><input type='button' class='but1' onclick='add_bac(" + mid + ","+bid+")' value='修改'/>&nbsp;<input type='button' class='but1' value='返回' onclick='fh(" + mid + ")'/></td></tr>";
            this.Label3.Text = str_array1;
            this.Label4.Text += "</script>";
        }
    }
}