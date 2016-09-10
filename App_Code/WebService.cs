using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// WebService 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    /// <summary>
    /// 大文件上传.<br></br>
    /// 2009-05-12 YJ 定义函数.<br></br>
    /// </summary>
    /// <param name="fileName">上传文件名</param>
    /// <param name="offSet">偏移</param>
    /// <param name="intoBuffer">每次上传字节数组 单位KB</param>
    /// <returns>上传是否成功</returns>
    [WebMethod]
    public bool Upload(string fileName, long offSet, byte[] intoBuffer)
    {
        //指定上传文件夹+文件名(相对路径)
        string strPath = "./vedio/" + fileName;
        string strPath1 = "vedio/" + fileName;
        
        //将相对路径转换成服务器的绝对路径
        strPath = Server.MapPath(strPath);

        if (offSet < 0)
        {
            offSet = 0;
        }

        byte[] buffer = intoBuffer;

        if (buffer != null)
        {
            //读写文件的文件流,支持同步读写也支持异步读写
            FileStream filesStream = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            filesStream.Seek(offSet, SeekOrigin.Begin);
            filesStream.Write(buffer, 0, buffer.Length);
            filesStream.Flush();
            filesStream.Close();
            filesStream.Dispose();
            HttpCookie cd = new HttpCookie("address1");
            cd.Value = strPath1;
            Context.Response.Cookies.Add(cd);
            return true;
            
        }
        return false;
    }
}
