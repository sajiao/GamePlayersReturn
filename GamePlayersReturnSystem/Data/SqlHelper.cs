using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public static class SqlHelper
    {
        public static int Exucute<T>(string sql, T req) {
             
            int result = 0;
            try
            {
                using (IDbConnection connection = new MySqlConnection(Const.ConnString))
                {
                    result = connection.Execute(sql, req);
                }
            }
            catch (Exception ex)
            {
                //log
                throw ex;
            }
           
             
            return result;
        }

        public static T QueryFirst<T>(string sql, T req) {
            T result;
            try
            {
                using (IDbConnection conn = new MySqlConnection(Const.ConnString))
                {
                    result = conn.QueryFirst<T>(sql, req);
                }
            }
            catch (Exception ex)
            {
                //log
                throw ex;
            }
            
            return result;
        }

        public static IEnumerable<T> Query<T>(string sql, T req)
        {
            IEnumerable<T> result;
            try
            {
                using (IDbConnection conn = new MySqlConnection(Const.ConnString))
                {
                    result = conn.Query<T>(sql, req);
                }
            }
            catch (Exception ex)
            {
                //log
                throw ex;
            }

            return result;
        }
    }
}
