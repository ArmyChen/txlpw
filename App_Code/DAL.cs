using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// DAL 的摘要说明
/// </summary>
public class DAL
{

   string sql = "server=sql.w354.vhostgo.com;database=txlp;uid=txlp;pwd=txlp123456;";
    SqlConnection con;
	public DAL()
	{
        con = new SqlConnection(sql);
	}
    public int caozuo(string str)
    {
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        int a = cmd.ExecuteNonQuery();
        con.Close();
        return a;
    }
    public int sqlcaozuo(string data_sql,string data_at,string data_zhi)
    {
        SqlCommand cmd = new SqlCommand(data_sql, con);
        con.Open();
        if (data_at != "")
        {
            string[] array1 = data_at.Split(',');
            string[] array2 = data_zhi.Split(',');
            for (int i = 0; i < array1.Length - 1; i++)
            {
                cmd.Parameters.Add(array1[i], array2[i]);
            }
        }
        int a = cmd.ExecuteNonQuery();
        con.Close();
        return a;
    }
    public int sqlcaozuo1(string data_sql, string data_at, string data_zhi)
    {
        SqlCommand cmd = new SqlCommand(data_sql, con);
        con.Open();
        if (data_at != "")
        {
            string[] array1 = data_at.Split(',');
            string[] array2 = data_zhi.Split('★');
            for (int i = 0; i < array1.Length - 1; i++)
            {
                cmd.Parameters.Add(array1[i], array2[i]);
            }
        }
        int a = cmd.ExecuteNonQuery();
        con.Close();
        return a;
    }

    public int land(string str)
    {
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        int a =Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        return a;
    }
    public int sqlland(string data_sql, string data_at, string data_zhi)
    {
        SqlCommand cmd = new SqlCommand(data_sql, con);
        con.Open();
        if (data_at != "")
        {
            string[] array1 = data_at.Split(',');
            string[] array2 = data_zhi.Split(',');
            for (int i = 0; i < array1.Length - 1; i++)
            {
                cmd.Parameters.Add(array1[i], array2[i]);
            }
        }
        int a = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        return a;
    }
    public DataTable select(string str)
    {
        SqlDataAdapter dt = new SqlDataAdapter(str, con);
        DataSet ds = new DataSet();
        dt.Fill(ds);
        return ds.Tables[0];
    }
    public DataTable sqlselect(string data_sql, string data_at, string data_zhi)
    { 
        SqlDataAdapter dt=new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand(data_sql, con);
        if (data_at != "")
        {
            string[] array1 = data_at.Split(',');
            string[] array2 = data_zhi.Split(',');
            for (int i = 0; i < array1.Length - 1; i++)
            {
                cmd.Parameters.Add(array1[i], array2[i]);
            }
        }
        dt.SelectCommand=cmd;
        DataSet ds=new DataSet();
        dt.Fill(ds);
        return ds.Tables[0];
    }
}