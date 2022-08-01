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
        /// <summary>
        /// 傳入selectCommand或sp名稱
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmt"></param>
        /// <returns></returns>
        public DataTable querySql(string sql,CommandType cmt) {
            adp.SelectCommand.CommandType = cmt;
            adp.SelectCommand.CommandText = sql;
            adp.Fill(ds);
            dt=ds.Tables[0];
            return dt;
        }

        internal void querySql()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 傳入selectCommand或sp名稱 可自行取datatable名稱
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmt"></param>
        /// <param name="dtName"></param>
        /// <returns></returns>
        //public DataTable querySqlBySP(string sql)
        //{
        //    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    adp.SelectCommand.CommandText = sql;
        //    adp.Fill(ds);
        //    dt = ds.Tables[0];
        //    return dt;
        //}
        public DataTable querySql(string sql, CommandType cmt,string dtName)
        {
            adp.SelectCommand.CommandType = cmt;
            adp.SelectCommand.CommandText = sql;
            adp.Fill(ds,dtName);
            dt = ds.Tables[dtName];
            return dt;
        }
    }
}