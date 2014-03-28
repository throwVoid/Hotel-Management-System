using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace 酒店管理系统
{
    public partial class Login : Form
    {
        private MainForm mainForm;
        public Login(MainForm mf)
        {
            mainForm = mf;
            InitializeComponent();
        }

        /*
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Login());
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text.Trim().Length==0) ||(textBox2.Text.Trim().Length==0))
            {
                MessageBox.Show("请输入正确的账号或者密码");
                return;
            }
            DataSet ds = check(textBox1.Text.Trim(), textBox2.Text.Trim());
            if ( ds != null)
            { 
                if (ds.Tables[0].Rows.Count > 0)
                {
                   // Console.WriteLine("{0},{1}", (string)(ds.Tables[0].Rows[0][1]), (string)(ds.Tables[0].Rows[0][2]));
                    if (((string)(ds.Tables[0].Rows[0][2])).Trim() == "是")
                    {
                        mainForm.setAdmin(true);
                    }
                    else
                    {
                        mainForm.setAdmin(false);
                    }
                    mainForm.setLogin(true);
                   // MessageBox.Show("密码正确"); 
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("密码错误");
                   
                }
            }
            else
            {
                MessageBox.Show("数据库处理出错，检查数据库配置");
                textBox2.Text = "";
                return;
            }
        }
        public DataSet check(string name, string passwd)
        {
            try
            {
                string cmd = "select * from " + "管理员" + " where 账号=" + "'" + name + "' and " + "密码=" + "'" + passwd + "'";
               // Console.WriteLine("{0}",cmd);
                string strConn = "workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
                //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
                SqlConnection cn = new SqlConnection(strConn);
                cn.Open();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(cmd, cn);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "管理员");
                return thisDataSet;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Console.WriteLine("{正在关闭}");
            
            if (mainForm.getLogin()==false)
            {
                mainForm.Dispose();
            }
        }
  
    }
}
