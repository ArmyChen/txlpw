using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class beifen : System.Web.UI.Page
{
    DAL dal = new DAL();
    zipys zip = new zipys();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    public void SetZipFile(string[] FilePath, string FileName, string SavePath, string PassWord)
    {
        try
        {
            ZipFile zipfile = new ZipFile(SavePath + "\\" + FileName + ".zip", Encoding.Default);
            if (PassWord != string.Empty)
                zipfile.Password = PassWord;
            zipfile.AddFiles(FilePath);

            zipfile.Save();
        }
        catch (Exception ex)
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string zhi1 = "E://meprojects/软件备用项/web/sjkbf/DataMSSQLSERVER2005_" + DateTime.Now.ToFileTimeUtc() + ".bak";
        string SqlStr2 = "backup database txlp to disk='" + zhi1 + "'";

        try
        {
            string[] zhi1s = { zhi1 };

            if (dal.caozuo(SqlStr2) > 0)
            {
                SetZipFile(zhi1s, "数据备份信息：时间" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "", "F://公司项目/2015/互助联合平台/web/sjkbf", "cqhzlm");
            }
            else
            {
                SetZipFile(zhi1s, "数据备份信息：时间" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "", "F://公司项目/2015/互助联合平台/web/sjkbf", "cqhzlm");
            }
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('备份数据成功！');</script>");

        }
        catch (Exception error)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('备份数据失败:" + error.Message + "！');</script>");
        }
    }
}