using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
        //string page = "https://www.youtube.com/watch?v=bIiEv__QNxw";
        public static string GetConnectionString(string connectionName = "DataBase")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            //TODO: Load the info into a table
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        public static int UserSearch(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {

                return (int)cnn.ExecuteScalar<int>(sql);

            }
        }
    }
}
