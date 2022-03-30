using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 用户登录界面
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Welcome wel = new Welcome();
            if (wel.ShowDialog() == DialogResult.OK)
                Application.Run(new 登陆());
            else
                Application.Exit();

        }
    }
}
