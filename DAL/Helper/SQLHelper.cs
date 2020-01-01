﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL.Helper
{
    class SQLHelper
    {
        //连接语句
        private static readonly string connString = @"Server=WIN-2IG3A90QTGO;DataBase=SMDB;Uid=sa;Pwd=123456";
        //封装功能函数
        public static SqlDataReader GetReader(string sql)
        {
            //创建连接数据库对象
            SqlConnection conn = new SqlConnection(connString);
            //创建数据库操作对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            //打开数据库
            conn.Open();
            //获取返回对象
            SqlDataReader objReader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            //返回对象
            return objReader;

        }
    }
}
