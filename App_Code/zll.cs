using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// zll 的摘要说明
/// </summary>
public class zll
{
    DAL dal = new DAL();
	public zll()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public void cj(int adminid)
    {
        string ren = "";
        double bdf = 0;
        string dqhy = "";
        foreach (DataRow dt in dal.select("select * from admin where id="+adminid+"").Rows)
        {
            ren = dt["aanzhi"].ToString();
            bdf = Convert.ToDouble(dt["abdf"].ToString());
            dqhy = dt["aname"].ToString();
        }

        for (int i = 0; i < 10; i++)
        {
            if (ren != "" && ren != "tjwadmin")
            {
                double jines = 0;
                double bfb = 0;
                foreach (DataRow dt in dal.select("select * from jiali where jbiaoshi=" + (i + 1) + "").Rows)
                {
                    bfb = Convert.ToDouble(dt["jbfb"].ToString());
                }
                jines = bfb * bdf/100;
                dal.caozuo("update admin set axianjin=axianjin+" + jines + " where aname='" + ren + "'");
                dal.caozuo("insert into caiwu values('见点奖'," + jines + ",0,'市场第"+(i+1)+"层见点奖，注册会员[" + dqhy + "]通过审核,会员[" + ren + "]得到" + jines + "现金币作为奖励','" + ren + "','" + DateTime.Now.ToString() + "','458',0)");
                foreach (DataRow dt in dal.select("select * from admin where aname='"+ren+"'").Rows)
                {
                    ren = dt["aanzhi"].ToString();
                }
            }
        }
    }
    public void tjj(int adminid)
    {
        string tjr = "";
        double bdf = 0;
        foreach (DataRow dt in dal.select("select * from admin where id=" + adminid + "").Rows)
        {
            tjr = dt["atui"].ToString();
            bdf = Convert.ToDouble(dt["abdf"].ToString());
        }
        if(tjr!=""&&tjr!="tjwadmin")
        {
            int gs = 0;
            foreach (DataRow dt in dal.select("select count(*) from admin where atui='"+tjr+"'").Rows)
            {
                gs = Convert.ToInt32(dt[0].ToString());
            }
            int yushu = gs % 3;
            double bfb = 0;
            foreach (DataRow dt in dal.select("select * from tuijj where tbiao="+yushu+"").Rows)
            {
                bfb = Convert.ToDouble(dt["tbfb"].ToString());
            }
            double jines = bdf * bfb / 100;
            dal.caozuo("update admin set axianjin=axianjin+" + jines + " where aname='" + tjr + "'");
            dal.caozuo("insert into caiwu values('直推奖'," + jines + ",0,'总共推荐"+gs+"个会员，得到" + jines + "现金币作为奖励','" + tjr + "','" + DateTime.Now.ToString() + "','458',0)");
        }
    }
}