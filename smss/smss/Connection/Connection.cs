﻿using smss.model;
using System;
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
                @"Data Source=DESKTOP-NGO2712\SQLEXPRESS;Initial Catalog=smss;integrated security=true; Max Pool Size=1024; ";
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
        public int Login(ref staffObj obj,string code, string userpass)
        {
            int ret = Status;
            if (ret >= 0)
            {
                string sql = "select * from staff where code = @code and userpass = @userpass";
                SqlCommand cmd = new SqlCommand(sql, _connection) { CommandType = CommandType.Text };
                cmd.Parameters.AddWithValue("code", code);
                cmd.Parameters.AddWithValue("userpass", userpass);
                SqlDataReader read = cmd.ExecuteReader();
                try
                {
                    while (read.Read())
                    {
                        obj.code = read["code"].ToString();
                        obj.name = read["name"].ToString();
                        if (!String.IsNullOrEmpty(read["birthday"].ToString()))
                            obj.birthday = DateTime.Parse(read["birthday"].ToString());
                        obj.photo = read["photo"].ToString();
                    }
                }
                catch
                {
                    ret = -1;
                }
                finally
                {
                    read.Close();
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
        public int Grade(gradeObj obj, string procName)
        {
            
            int ret = Status;
            if (ret >= 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(procName, _connection) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("code", obj.code);
                    cmd.Parameters.AddWithValue("name", obj.name);
                    cmd.Parameters.AddWithValue("yearin", obj.yearin);
                    cmd.Parameters.AddWithValue("yearout", obj.yearout);
                    cmd.Parameters.AddWithValue("note", obj.note);
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
    }
}
