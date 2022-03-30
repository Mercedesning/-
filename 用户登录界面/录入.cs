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
    public partial class 录入 : Form
    {
        public 录入()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLconnection.connect();
            SqlCommand command = new SqlCommand();
            command.Connection = SQLconnection.con;
            command.CommandText="insert into student(id,name,cource) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            command.ExecuteNonQuery();
            MessageBox.Show("录入成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
