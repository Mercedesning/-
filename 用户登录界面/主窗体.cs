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
    public partial class 主窗体 : Form
    {
        public 主窗体()
        {
            InitializeComponent();
        }

        private void 学生信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            录入 luru = new 录入();
            luru.Show();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询 chaxun = new 查询();
            chaxun.Show();
        }

        private void 退退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 课程信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             SQLconnection.connect();
             SqlCommand command = new SqlCommand();
             command.Connection = SQLconnection.con;
             string cmdstr="select * from student";
             SqlDataAdapter dataadapter = new SqlDataAdapter(cmdstr,SQLconnection.con);
             DataSet set = new DataSet();
             dataadapter.Fill(set,"student");
             dataGridView1.DataSource = set.Tables["student"];
             SQLconnection.con.Close();
        }
    }
}
