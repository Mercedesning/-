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
    public partial class 注册 : Form
    {
        public 注册()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLconnection.connect();
            SqlCommand command = new SqlCommand();
            command.Connection = SQLconnection.con;
            command.CommandText = "insert into userdata(userid,username,userpassword)values('" + textBox4.Text + "','" + textBox1.Text+"','"+textBox2.Text+"')";
            if (textBox2.Text == textBox3.Text)
            {
                command.ExecuteNonQuery();
                this.Close();
                登陆 denglu = new 登陆();
                denglu.Show();
                MessageBox.Show("注册成功，请登陆！");
            }
            else {
                MessageBox.Show("两次密码输入不一致，请重新输入！");
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
            }
            SQLconnection.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
