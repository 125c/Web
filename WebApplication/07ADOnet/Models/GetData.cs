using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace _07ADOnet.Models
{
    
    public class GetData
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["aaa"].ConnectionString);
        SqlDataAdapter adp = new SqlDataAdapter("", conn);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public DataTable querySql(string sql) {
            adp.SelectCommand.CommandText = sql;
            adp.Fill(ds);
            dt=ds.Tables[0];
            return dt;
        }
        public DataTable querySqlBySP(string sql)
        {
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.CommandText = sql;
            adp.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
    }
}