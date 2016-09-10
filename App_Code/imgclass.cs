using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// imgclass 的摘要说明
/// </summary>
public class imgclass
{
	public imgclass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public string GetFirstHtmlImg(string HtmlContent)
    {

        Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);

        // 搜索匹配的字符串 
        MatchCollection matches = regImg.Matches(HtmlContent);
        string sUrlList = "";

        // 取得匹配项列表 
        int zhi1 = 0;
        foreach (Match match in matches)
        {
            if (zhi1 == 0)
            {
                sUrlList = match.Groups["imgUrl"].Value;
            }
            else
            {
                sUrlList += "";
            }
            zhi1 += 1;
        }
        return sUrlList; 

    }
    public string MyGetImgUrl(string html)
    {

        Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);

        // 搜索匹配的字符串 
        MatchCollection matches = regImg.Matches(html);
        string sUrlList ="";

        // 取得匹配项列表 
        foreach (Match match in matches)
        {
            sUrlList += match.Groups["imgUrl"].Value+",";
        }
        return sUrlList; 

    }
}