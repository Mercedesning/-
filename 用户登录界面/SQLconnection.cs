using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace 用户登录界面
{
    class SQLconnection
    {
        public static 录入 luru;
        public static 主窗体 mainwindow;
        public static 查询 chaxun;
        public static string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\15652\\Desktop\\用户登录界面\\userdata.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection con;
        public static void connect() {
            con = new SqlConnection(connection);
            con.Open();
        }
    }
}
