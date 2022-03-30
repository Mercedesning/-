namespace 用户登录界面
{
    partial class 主窗体
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主窗体));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息管理ToolStripMenuItem,
            this.课程信息管理ToolStripMenuItem,
            this.退退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(512, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("学生信息管理ToolStripMenuItem.BackgroundImage")));
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息录入ToolStripMenuItem,
            this.学生信息查询ToolStripMenuItem});
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            // 
            // 学生信息录入ToolStripMenuItem
            // 
            this.学生信息录入ToolStripMenuItem.Name = "学生信息录入ToolStripMenuItem";
            this.学生信息录入ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息录入ToolStripMenuItem.Text = "学生信息录入";
            this.学生信息录入ToolStripMenuItem.Click += new System.EventHandler(this.学生信息录入ToolStripMenuItem_Click);
            // 
            // 学生信息查询ToolStripMenuItem
            // 
            this.学生信息查询ToolStripMenuItem.Name = "学生信息查询ToolStripMenuItem";
            this.学生信息查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息查询ToolStripMenuItem.Text = "学生信息查询";
            this.学生信息查询ToolStripMenuItem.Click += new System.EventHandler(this.学生信息查询ToolStripMenuItem_Click);
            // 
            // 课程信息管理ToolStripMenuItem
            // 
            this.课程信息管理ToolStripMenuItem.Name = "课程信息管理ToolStripMenuItem";
            this.课程信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.课程信息管理ToolStripMenuItem.Text = "课程信息管理";
            this.课程信息管理ToolStripMenuItem.Click += new System.EventHandler(this.课程信息管理ToolStripMenuItem_Click);
            // 
            // 退退出系统ToolStripMenuItem
            // 
            this.退退出系统ToolStripMenuItem.Name = "退退出系统ToolStripMenuItem";
            this.退退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退退出系统ToolStripMenuItem.Text = "退出系统";
            this.退退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退退出系统ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(512, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // 主窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 282);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "主窗体";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退退出系统ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}