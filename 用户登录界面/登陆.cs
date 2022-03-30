using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 用户登录界面
{
    public partial class 登陆 : Form
    {
        public 登陆()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLconnection.connect();
            SqlCommand command = new SqlCommand();
            command.Connection = SQLconnection.con;
            command.CommandText = "select * from userdata where username='"+textBox1.Text+"'and userpassword='"+textBox2.Text+"'";
            SqlDataReader result = command.ExecuteReader();
            SQLconnection.mainwindow = new 主窗体();
            if (result.Read()) { 
                MessageBox.Show("欢迎进入本系统！");
                this.Hide();
                SQLconnection.mainwindow.Show();
            }
            else MessageBox.Show("密码错误，请重试");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            注册 zhuce = new 注册();
            zhuce.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
