using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 酒店管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainForm mainForm = new MainForm();
            Login login = new Login(mainForm);
           // mainForm.setLogin(login);
            Application.Run(login);
            if((mainForm == null)||(mainForm.IsDisposed==true))
            {
            }
            else
             Application.Run(mainForm);
        }
    }
}
