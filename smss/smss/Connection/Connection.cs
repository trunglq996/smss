using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace smss.Connection
{
    class Connection
    {
        private readonly string _conStr;
        public readonly int Status;
        SqlConnection _connection;

        public Connection()
        {
            _conStr =
                @"Data Source=DESKTOP-NGO2712\SQLEXPRESS;Initial Catalog=otest;integrated security=true; Max Pool Size=1024; ";
            try
            {
                _connection = new SqlConnection(_conStr);
                _connection.Open();
            }
            catch (Exception)
            {
                Status = -1000;
            }
        }
        public int DoSql(string sql)
        {
            int ret = Status;
            if (ret >= 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection) { CommandType = CommandType.Text };
                    ret = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    ret = -1;
                }
            }
            _connection.Close();
            return ret;
        }

        public int GetDataByQuery(ref DataSet ds, string tableName, string sql)
        {
            ds.Tables.Add(tableName);
            int ret = Status;
            if (ret >= 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection) { CommandType = CommandType.Text };
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(ds.Tables[tableName]);
                }
                catch (Exception)
                {

                    ret = -1;
                }
            }
            _connection.Close();
            return ret;
        }
    }
}
