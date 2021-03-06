﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sybase.Data.AseClient;
using System.Data;

namespace GuestInfoQueryer
{
    class SybaseQueryer : IDisposable
    {
        private string _UserName = "";
        private string _Password = "";
        private int _Port = 0;
        private string _Database = "";
        private string _HostAddress = "";
        private string _ConnectionString = "";
        private string _Charset = "cp850";

        private AseConnection _connection;
        private AseCommand _command;
        private AseDataAdapter _adapter;

        public SybaseQueryer(string Host, string UserName, string Password, int Port = 5000, string Database = "foxhis", string Charset = "cp850")
        {
            _HostAddress = Host;
            this.UserName = UserName;
            _Password = Password;
            _Port = Port;
            _Database = Database;
            _Charset = Charset;
            _ConnectionString = GetConnectionString();
        }
        /// <summary>
        /// 测试连接
        /// </summary>
        /// <returns>返回是否连接上</returns>
        public bool TestConnection(out string msg)
        {
            using (var conn = new AseConnection(GetConnectionString()))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                    return false;
                }
            }
            msg = "";
            return true;
        }

        /// <summary>
        /// 初始化连接字符串
        /// </summary>
        private string GetConnectionString()
        {
            return "Data Source = " + _HostAddress + ";Database = " + _Database + ";Charset = " 
                + _Charset + ";Port = " + _Port + ";UID = " + UserName + ";PWD = " + _Password + ";";
        }

        #region 属性
        public string UserName { get => _UserName; set => _UserName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Database { get => _Database; set => _Database = value; }
        public string ConnectionString { get => _ConnectionString;}
        public int Port { get => _Port; set => _Port = value; }
        public string HostAddress { get => _HostAddress; set => _HostAddress = value; }
        public string Charset { get => _Charset; set => _Charset = value; }
        #endregion

        /// <summary>
        /// 初始化连接
        /// </summary>
        public void Connect()
        {
            try
            {
                _connection = new AseConnection(_ConnectionString);
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据指定的查询字符串返回结果
        /// </summary>
        /// <param name="QueryString">查询字符串</param>
        /// <returns></returns>
        public DataTable Query(string QueryString)
        {
            try
            {
                _command = new AseCommand(QueryString);
                _command.Connection = _connection;
                _adapter = new AseDataAdapter(_command);
                DataTable table = new DataTable();
                _adapter.Fill(table);
                return table;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            if(_connection != null)
            {
                if(_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
            }
            _command.Dispose();
            _adapter.Dispose();
        }
    }
}
