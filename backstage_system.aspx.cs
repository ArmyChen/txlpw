using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class backstage_system : System.Web.UI.Page
{
    DAL dal = new DAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            int mid=Convert.ToInt32(Request.QueryString["mid"]);
            mk.Value = mid.ToString();
            string biaoming = "";
            foreach (DataRow dt in dal.select("select * from mode where mid="+mid+"").Rows)
            {
                this.Label2.Text = dt["mname"].ToString();
                int su = Convert.ToInt32(dt["msu"].ToString());
                biaoming = dt["mbiao"].ToString();
                foreach (DataRow dt1 in dal.select("select * from mode where mid="+su+"").Rows)
                {
                    this.Label1.Text = dt1["mname"].ToString();
                }
            }
            //获取CPU中心数据进行对接
            string sjzd = "";
            string kjzd = "";
            string bm = "";
            foreach (DataRow dt in dal.select("select * from cpu_center where zwm='"+biaoming+"'").Rows)
            {
                sjzd = dt["fieldnames"].ToString();
                kjzd = dt["kongjian"].ToString();
                bm = dt["sjk"].ToString();
            }
            string [] array1=kjzd.Split(',');
            string memory1 = "";
            for (int i = 0; i < array1.Length-1; i++)
            {
                string zhi = array1[i].ToString();
                if (zhi.IndexOf("图片上传控件") != -1 || zhi.IndexOf("详细信息框") != -1)
                {

                }
                else
                {
                    memory1 += i.ToString()+",";
                }
            }
            if (memory1 != "")
            {
                string[] array2 = memory1.Split(',');
                string[] array3 = sjzd.Split(',');
                this.Label3.Text += "<table style='min-width:100%' cellpadding='0' cellspacing='0'><tr>";
                this.Label3.Text += "<td style='text-align:center;min-width:100px; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>选择</font></span></div></td>";
                this.Label3.Text += "<td style='text-align:center;min-width:100px; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>ID</font></span></div></td>";
                for (int i = 0; i < array2.Length - 1; i++)
                {
                    this.Label3.Text += "<td style='text-align:center;min-width:100px; max-width:300px; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>" + array3[int.Parse(array2[i])] + "</font></span></div></td>";
                }
                this.Label3.Text += "<td style='text-align:center;min-width:100px; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>发布时间</font></span></div></td>";
                this.Label3.Text += "<td style='text-align:center;min-width:100px; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>操作</font></span></div></td>";
                this.Label3.Text += "</tr>";

                //获取表字段
                string zd = "";
                for (int i = 0; i < array2.Length - 1; i++)
                {
                    zd +=int.Parse(array2[i])+1+ ",";
                }
                string[] array4 = zd.Split(',');
                string zdm = "";
                foreach (DataRow dt in dal.select("select name from syscolumns where id=object_id('" + bm + "')").Rows)
                {
                    zdm += dt[0].ToString() + ",";
                }
                string[] array5 = zdm.Split(',');
                string zzzd = "";
                zzzd += array5[0] + ",";
                for (int i = 0; i < array4.Length - 1; i++)
                {
                    
                    zzzd += array5[int.Parse(array4[i])]+",";
                }
                //生成数据流
                string[] array6 = zzzd.Split(',');

                int a1=Convert.ToInt32(Request.QueryString["a1"]);
                if (a1 > 0)
                {//select top 12 * from borrow where bid not in(select top " + a1 + " bid from borrow order by bid desc) order by bid desc
                    int c = 0;
                    foreach (DataRow dt in dal.select("select top 10 * from " + bm + " where "+array6[0]+" not in(select top "+a1+" "+array6[0]+" from "+bm+" where mod='"+mid+"' order by "+array6[0]+" desc) and mod='" + mid + "' order by " + array6[0] + " desc").Rows)
                    {
                        string yance = "";
                        if (c % 2 == 0)
                        {
                            yance = "#ffffff";
                        }
                        else
                        {
                            yance = "#e8e8e8";
                        }
                        this.Label3.Text += "<tr>";
                        this.Label3.Text += "<td style='text-align:center;background-color:"+yance+";min-width:100px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='checkbox' style='cursor:pointer' onclick=dj(this," + dt[array6[0]].ToString() + ") /></div></td>";
                        for (int i = 0; i < array6.Length - 1; i++)
                        {
                            string system_zhisystem = dt[array6[i]].ToString();
                            string zhi234 = "";
                            string zhi123456 = "";
                            zhi123456 = system_zhisystem;
                            if (system_zhisystem.IndexOf("upload\\") != -1)
                            {
                                zhi234 = "<img src='" + system_zhisystem + "' style='height:100px;'/>" + zhi123456;
                            }
                            else
                            {
                                zhi234 = zhi123456;
                            }
                            this.Label3.Text += "<td style='text-align:center;background-color:" + yance + ";min-width:100px; max-width:300px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='text' style='font-size:12px; border:0px; background-color:transparent; border-style:none; color:#323232' value='" + zhi234 + "'/></div></td>";
                        }
                        this.Label3.Text += "<td style='text-align:center;background-color:" + yance + ";min-width:100px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='text' style='font-size:12px; border:0px; background-color:transparent; border-style:none; color:#323232' value='" + dt["ftime"].ToString() + "'/></div></td>";
                        this.Label3.Text += "<td style='text-align:center;background-color:" + yance + ";min-width:100px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><a href='xiu_backstage.aspx?mid=" + mid + "&bid=" + dt[array6[0]].ToString() + "' style='font-size:12px; color:#323232'><font face='宋体'><img src='tcimg/update1.jpg'/></font></a></div></td>";
                        this.Label3.Text += "</tr>";
                        c += 1;
                    }
                    string ye=Request.QueryString["ye"];
                    this.Label6.Text = ye;
                }
                else
                {
                    int c = 0;
                    foreach (DataRow dt in dal.select("select top 10 * from " + bm + " where mod='" + mid + "' order by " + array6[0] + " desc").Rows)
                    {
                        string yance = "";
                        if (c % 2 == 0)
                        {
                            yance = "#ffffff";
                        }
                        else
                        {
                            yance = "#e8e8e8";
                        }
                        this.Label3.Text += "<tr>";
                        this.Label3.Text += "<td style='text-align:center;background-color:"+yance+";min-width:100px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='checkbox' style='cursor:pointer' onclick=dj(this," + dt[array6[0]].ToString() + ") /></div></td>";
                        for (int i = 0; i < array6.Length - 1; i++)
                        {
                            string system_zhisystem = dt[array6[i]].ToString();
                            string zhi234 = "";
                            string zhi123456 = "";
                            zhi123456 = system_zhisystem;
                            if (system_zhisystem.IndexOf("upload\\") != -1)
                            {
                                zhi234 = "<img src='" + system_zhisystem + "' style='height:100px;'/>" + zhi123456;
                            }
                            else
                            {
                                zhi234 = zhi123456;
                            }
                            this.Label3.Text += "<td style='text-align:center;background-color:" + yance + ";min-width:100px; max-width:300px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='text' style='font-size:12px; border:0px; background-color:transparent; border-style:none; color:#323232' value='" + zhi234 + "'/></div></td>";
                        }
                        this.Label3.Text += "<td style='text-align:center;background-color:" + yance + ";min-width:100px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='text' style='font-size:12px; border:0px; background-color:transparent; border-style:none; color:#323232' value='" + dt["ftime"].ToString() + "'/></div></td>";
                        this.Label3.Text += "<td style='text-align:center;background-color:" + yance + ";min-width:100px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><a href='xiu_backstage.aspx?mid=" + mid + "&bid=" + dt[array6[0]].ToString() + "' style='font-size:12px; color:#323232'><font face='宋体'><img src='tcimg/update1.jpg'/></font></a></div></td>";
                        this.Label3.Text += "</tr>";
                        c += 1;
                    }
                }
                this.Label3.Text += "</tr></table>";
                //统计分页
                foreach (DataRow dt in dal.select("select count(*) from "+bm+" where mod='"+mid+"'").Rows)
                {
                    int zong = Convert.ToInt32(dt[0].ToString());

                    int zong1 = zong / 10;

                    int ye = 0;

                    if (zong1 < 1)
                    {
                        ye = 1;
                    }
                    else
                    {
                        if (zong % 10 == 0)
                        {
                            ye = zong1;
                        }
                        else
                        {
                            ye = zong1 + 1;
                        }
                    }
                    this.Label4.Text = ye.ToString();
                    this.Label5.Text = zong.ToString();
                }
            }
            else
            {
                this.Label3.Text = "<span style='font-size:12px; color:#323232;'>暂无相关展示！</span>";
            }

            
            

            //程序代码结尾
        }
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        int mid=Convert.ToInt32(Request.QueryString["mid"]);
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='add_backstage.aspx?mid="+mid+"';</script>");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        int mid = Convert.ToInt32(Request.QueryString["mid"]);
        int cid = 0;

        int a1 = 10 * cid;

        this.Label6.Text = "1";

        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='backstage_system.aspx?mid=" + mid + "&a1="+a1+"&ye=1';</script>");

    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        int mid = Convert.ToInt32(Request.QueryString["mid"]);
        int cid = Convert.ToInt32(this.Label6.Text) - 2;
        if (cid < 0)
        {
        }
        else
        {
            int a1 = 10 * cid;

            this.Label6.Text = (cid + 1).ToString();
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='backstage_system.aspx?mid=" + mid + "&a1=" + a1 + "&ye=" + (cid + 1).ToString() + "';</script>");
        }
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        int mid = Convert.ToInt32(Request.QueryString["mid"]);
        int cid = Convert.ToInt32(this.Label6.Text);
        if (cid >= Convert.ToInt32(Label4.Text))
        {
        }
        else
        {
            int a1 = 10 * cid;

            this.Label6.Text = (cid + 1).ToString();
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='backstage_system.aspx?mid=" + mid + "&a1=" + a1 + "&ye=" + (cid + 1).ToString() + "';</script>");

        }
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        int mid = Convert.ToInt32(Request.QueryString["mid"]);
        int cid = Convert.ToInt32(Label4.Text) - 1;
        int a1 = 10 * cid;

        this.Label6.Text = Label4.Text;
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='backstage_system.aspx?mid=" + mid + "&a1=" + a1 + "&ye=" + Label4.Text + "';</script>");

    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        int mid = Convert.ToInt32(Request.QueryString["mid"]);
        int cid = Convert.ToInt32(tz.Value) - 1;
        if(int.Parse(tz.Value)>int.Parse(Label4.Text))
        {
            Page.ClientScript.RegisterStartupScript(GetType(),"","<script>alert('对不起，跳转页数超过最大页数');</script>");
        }
        else if (int.Parse(tz.Value) < 1)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('对不起，跳转页数低于最小页数');</script>");
        }
        else
        {
            int a1 = 10 * cid;

            this.Label6.Text = tz.Value;
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>window.location.href='backstage_system.aspx?mid=" + mid + "&a1=" + a1 + "&ye=" + tz.Value + "';</script>");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.Label3.Text = "";
        int mid = Convert.ToInt32(Request.QueryString["mid"]);
        mk.Value = mid.ToString();
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
        //获取CPU中心数据进行对接
        string sjzd = "";
        string kjzd = "";
        string bm = "";
        string leixing = "";
        foreach (DataRow dt in dal.select("select * from cpu_center where zwm='" + biaoming + "'").Rows)
        {
            sjzd = dt["fieldnames"].ToString();
            kjzd = dt["kongjian"].ToString();
            bm = dt["sjk"].ToString();
            leixing = dt["ss"].ToString();
        }
        string[] array1 = kjzd.Split(',');
        string memory1 = "";
        for (int i = 0; i < array1.Length-1; i++)
        {
            string zhi = array1[i].ToString();
            if (zhi.IndexOf("图片上传控件") != -1 || zhi.IndexOf("详细信息框") != -1)
            {

            }
            else
            {
                memory1 += i.ToString() + ",";
            }
        }
        if (memory1 != "")
        {
            string[] array2 = memory1.Split(',');
            string[] array3 = sjzd.Split(',');
            this.Label3.Text += "<table width='100%' cellpadding='0' cellspacing='0'><tr>";
            this.Label3.Text += "<td style='text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>选择</font></span></div></td>";
            this.Label3.Text += "<td style='text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>ID</font></span></div></td>";
            for (int i = 0; i < array2.Length - 1; i++)
            {
                this.Label3.Text += "<td style='text-align:center; background-image:url(tcimg/tb.jpg); min-width:100px; max-width:300px; height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>" + array3[int.Parse(array2[i])] + "</font></span></div></td>";
            }
            this.Label3.Text += "<td style='text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>发布时间</font></span></div></td>";
            this.Label3.Text += "<td style='text-align:center; background-image:url(tcimg/tb.jpg); height:31px; border:1px solid #d0d0d0; background-repeat:repeat-x;'><div style='padding-top:0px; font-size:0px; clear:both; text-align:left;'><span style='font-size:12px; color:#0e494b'><font face='宋体'>操作</font></span></div></td>";
            this.Label3.Text += "</tr>";

            //获取表字段
            string zd = "";
            for (int i = 0; i < array2.Length - 1; i++)
            {
                zd += int.Parse(array2[i]) + 1 + ",";
            }
            string[] array4 = zd.Split(',');
            string zdm = "";
            foreach (DataRow dt in dal.select("select name from syscolumns where id=object_id('" + bm + "')").Rows)
            {
                zdm += dt[0].ToString() + ",";
            }
            string[] array5 = zdm.Split(',');
            string zzzd = "";
            zzzd += array5[0] + ",";
            for (int i = 0; i < array4.Length - 1; i++)
            {

                zzzd += array5[int.Parse(array4[i])] + ",";
            }
            //生成数据流
            string[] array6 = zzzd.Split(',');

            //定义搜索操作条件
            if (leixing != "")
            {
                string[] array7 = leixing.Split(',');
                string sstj = "(";
                for (int i = 0; i < array7.Length - 1; i++)
                {
                    if (i == array7.Length - 2)
                    {
                        sstj += array7[i] + " like '%" + ss.Value + "%') and";
                    }
                    else
                    {
                        sstj += array7[i] + " like '%" + ss.Value + "%' or ";
                    }
                }
                int c = 0;
                foreach (DataRow dt in dal.select("select top 10 * from " + bm + " where " + sstj + " mod='" + mid + "' order by " + array6[0] + " desc").Rows)
                {
                    string yance = "";
                    if (c % 2 == 0)
                    {
                        yance = "#ffffff";
                    }
                    else
                    {
                        yance = "#e8e8e8";
                    }
                    this.Label3.Text += "<tr>";
                    this.Label3.Text += "<td style='text-align:center;background-color:"+yance+"; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='checkbox' style='cursor:pointer' onclick=dj(this," + dt[array6[0]].ToString() + ") /></div></td>";
                    for (int i = 0; i < array6.Length - 1; i++)
                    {
                        string system_zhisystem = dt[array6[i]].ToString();
                        string zhi234 = "";
                        string zhi123456 = "";
                        zhi123456 = system_zhisystem;
                        if (system_zhisystem.IndexOf("upload\\") != -1)
                        {
                            zhi234 = "<img src='" + system_zhisystem + "' style='height:100px;'/>" + zhi123456;
                        }
                        else
                        {
                            zhi234 = zhi123456;
                        }
                        this.Label3.Text += "<td style='text-align:center;background-color:" + yance + ";min-width:100px; max-width:300px; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='text' style='font-size:12px; border:0px; background-color:transparent; border-style:none; color:#323232' value='" + zhi234 + "'/></div></td>";
                    }
                    this.Label3.Text += "<td style='text-align:center;background-color:" + yance + "; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><input type='text' style='font-size:12px; border:0px; background-color:transparent; border-style:none; color:#323232' value='" + dt["ftime"].ToString() + "'/></div></td>";
                    this.Label3.Text += "<td style='text-align:center;background-color:" + yance + "; cursor:text; border:1px solid #d0d0d0;'><div style='padding-top:3px; padding-bottom:1px; font-size:0px; clear:both; text-align:left;'><a href='xiu_backstage.aspx?mid=" + mid + "&bid=" + dt[array6[0]].ToString() + "' style='font-size:12px; color:#323232'><font face='宋体'><img src='tcimg/update1.jpg'/></font></a></div></td>";
                    this.Label3.Text += "</tr>";
                    c += 1;
                }
                this.Label3.Text += "</tr></table>";
                //统计分页
                foreach (DataRow dt in dal.select("select count(*) from " + bm + " where mod='" + mid + "'").Rows)
                {
                    int zong = Convert.ToInt32(dt[0].ToString());

                    int zong1 = zong / 10;

                    int ye = 0;

                    if (zong1 < 1)
                    {
                        ye = 1;
                    }
                    else
                    {
                        if (zong % 10 == 0)
                        {
                            ye = zong1;
                        }
                        else
                        {
                            ye = zong1 + 1;
                        }
                    }
                    this.Label4.Text = ye.ToString();
                    this.Label5.Text = zong.ToString();
                }
            }
        }
        else
        {
            this.Label3.Text = "<span style='font-size:12px; color:#323232;'>暂无相关展示！</span>";
        }
    }
}