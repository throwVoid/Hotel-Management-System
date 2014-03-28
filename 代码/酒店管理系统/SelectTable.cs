using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 酒店管理系统
{
	/// <summary>
	/// SelectTable 的摘要说明。
	/// </summary>
	public class SelectTable : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private DataSet ds;//数据集
		private string sql;//用于读取数据的SQL语句
		private int formIndex;//标示从哪个窗体中调用

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SelectTable(string sqlStr,int Index)//修改构造函数
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
			this.sql=sqlStr;//通过构造函数传入SQL语句
			this.formIndex=Index;//读入窗体标示
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionVisible = false;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.Size = new System.Drawing.Size(552, 272);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.DoubleClick += new System.EventHandler(this.dataGrid1_DoubleClick);
            // 
            // SelectTable
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(552, 269);
            this.Controls.Add(this.dataGrid1);
            this.Name = "SelectTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectTable";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectTable_FormClosing);
            this.Load += new System.EventHandler(this.SelectTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		//-------根据构造函数中的sql语句，读入数据并显示在表格中---------
		private void SelectTable_Load(object sender, System.EventArgs e)
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
           //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			ds=new DataSet();
			SqlDataAdapter da=new SqlDataAdapter(sql,cn);
			da.Fill(ds);
			dataGrid1.DataSource=ds.Tables[0];
		}

		//-------双击选择一行，并将这一条预定单号返回到入住单中--------
		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			int i=dataGrid1.CurrentRowIndex;
			if(formIndex==1)//向入住单中传送预定单数据
			    HotelArrival.dRow=ds.Tables[0].Rows[i];
			if(formIndex==2)//向消费记帐窗体中传送入住单编号
				ClientConsume.RZid=dataGrid1[i,0].ToString().Trim();
			this.Close();
		}

        private void SelectTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            //mainForm.Show();
        }
	}
}
