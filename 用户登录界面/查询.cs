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
    public partial class 查询 : Form
    {
        public 查询()
        {
            InitializeComponent();
        }
         SqlDataAdapter dataadapter = new SqlDataAdapter();
         DataSet set = new DataSet();
         DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            SQLconnection.connect();
            SqlCommand command = new SqlCommand();
            command.Connection = SQLconnection.con;
            
            if(comboBox1.Text=="学号"){
                command.CommandText = "select * from student where id='" +textBox1.Text+ "' ";
            }
            else if (comboBox1.Text == "姓名")
            {
                command.CommandText = "select * from student where name='" + textBox1.Text + "' ";
            }
            else {
                command.CommandText = "select * from student where cource='" + textBox1.Text + "' ";
            }
            dataadapter.SelectCommand = command;
            dataadapter.Fill(set, "student");
            table=set.Tables["student"];
            dataGridView1.DataSource = table;
            SQLconnection.con.Close();
        }
        public void refrush() {
            SqlCommandBuilder builder = new SqlCommandBuilder();
            dataadapter.Update(set,"student");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            refrush();
            MessageBox.Show("修改成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定要删除此项","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(result==DialogResult.OK){
                table.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
                refrush();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
