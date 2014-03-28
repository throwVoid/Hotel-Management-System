using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 酒店管理系统
{
	public class RoomType : 医院管理系统.ParentForm
	{
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private 酒店管理系统.DataSet1 dataSet11;
		private System.ComponentModel.IContainer components = null;
        private MainForm mainForm;

		public RoomType(MainForm mf)
		{
            mainForm = mf;
            mainForm.myHide();
			// 该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
            if (mainForm.getAdmin() == false) toolBar1.Enabled = false;
			// TODO: 在 InitializeComponent 调用后添加任何初始化
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomType));
            this.txt4 = new System.Windows.Forms.TextBox();
            this.dataSet11 = new 酒店管理系统.DataSet1();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "类型名称";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "类型编号";
            // 
            // txt3
            // 
            this.txt3.Visible = false;
            // 
            // label3
            // 
            this.label3.Visible = false;
            // 
            // toolBar1
            // 
            this.toolBar1.Size = new System.Drawing.Size(728, 41);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "客房类型";
            this.dataGrid1.DataSource = this.dataSet11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            // 
            // da1
            // 
            this.da1.DeleteCommand = this.sqlDeleteCommand1;
            this.da1.InsertCommand = this.sqlInsertCommand1;
            this.da1.SelectCommand = this.sqlSelectCommand1;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "客房类型", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("类型编号", "类型编号"),
                        new System.Data.Common.DataColumnMapping("类型名称", "类型名称"),
                        new System.Data.Common.DataColumnMapping("价格", "价格"),
                        new System.Data.Common.DataColumnMapping("加床价格", "加床价格"),
                        new System.Data.Common.DataColumnMapping("可超预定数", "可超预定数"),
                        new System.Data.Common.DataColumnMapping("是否可加床", "是否可加床")})});
            this.da1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房类型.类型编号", true));
            this.txt4.Location = new System.Drawing.Point(124, 62);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(136, 21);
            this.txt4.TabIndex = 6;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房类型.类型名称", true));
            this.txt5.Location = new System.Drawing.Point(292, 62);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(136, 21);
            this.txt5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(468, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "价格";
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房类型.价格", true));
            this.txt6.Location = new System.Drawing.Point(468, 62);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(136, 21);
            this.txt6.TabIndex = 5;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt6_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(296, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "类型名称";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(128, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "类型编号";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT 类型编号, 类型名称, 价格, 加床价格, 可超预定数, 是否可加床 FROM 客房类型 WHERE (类型编号 LIKE @Param3) AND" +
    " (类型名称 LIKE @Param4)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param3", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 40, "类型名称")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO 客房类型(类型编号, 类型名称, 价格, 加床价格, 可超预定数, 是否可加床) VALUES (@类型编号, @类型名称, @价格, @" +
    "加床价格, @可超预定数, @是否可加床); SELECT 类型编号, 类型名称, 价格, 加床价格, 可超预定数, 是否可加床 FROM 客房类型 WHERE" +
    " (类型编号 = @类型编号)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@类型名称", System.Data.SqlDbType.VarChar, 40, "类型名称"),
            new System.Data.SqlClient.SqlParameter("@价格", System.Data.SqlDbType.Money, 8, "价格"),
            new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Money, 8, "加床价格"),
            new System.Data.SqlClient.SqlParameter("@可超预定数", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "可超预定数", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@类型名称", System.Data.SqlDbType.VarChar, 40, "类型名称"),
            new System.Data.SqlClient.SqlParameter("@价格", System.Data.SqlDbType.Money, 8, "价格"),
            new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Money, 8, "加床价格"),
            new System.Data.SqlClient.SqlParameter("@可超预定数", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "可超预定数", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床"),
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_可超预定数", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "可超预定数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型名称", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型名称", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_可超预定数", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(3)), ((byte)(0)), "可超预定数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型名称", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型名称", System.Data.DataRowVersion.Original, null)});
            // 
            // RoomType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Name = "RoomType";
            this.Text = "【客房类型设置】";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomType_FormClosing);
            this.Load += new System.EventHandler(this.RoomType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//--------创建窗体时，读入数据-------
		private void RoomType_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].Value="%";			
			
			da1.Fill(dataSet11);
			//设置数据导航控件
			this.cmOrders=(CurrencyManager) BindingContext[dataSet11,"客房类型"];	
			//将基类中的数据集与派生类中的数据集连接
			base.dataSet11=this.dataSet11;
		}

		//-----------根据输入，检索信息----------
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].Value="%";
			
			if(txt1.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[0].Value="%"+txt1.Text.Trim()+"%";
			}
			if(txt2.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[1].Value="%"+txt2.Text.Trim()+"%";
			}
			
			dataSet11.Clear();//刷新数据集
			da1.Fill(dataSet11);		
		}

		//----------重写设置控件只读属性函数----------
		protected override void SetModifyMode(bool blnEdit)
		{
			base.SetModifyMode (blnEdit);			
			txt5.ReadOnly=!blnEdit;
			txt6.ReadOnly=!blnEdit;			
		}

		//-------重写新增记录时设置默认值函数--------
		protected override void SetDefaultValue()
		{
			//生成新的编号
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select max(类型编号) 最大编号 from 客房类型";
			object result=cmd.ExecuteScalar();
			int newID=1;
			if(result!=System.DBNull.Value)
			{
				newID=Convert.ToInt32(result)+1;
			}
			txt4.Text=newID.ToString();			
			base.SetDefaultValue ();
		}

		//-------重写检查非空字段函数--------
		protected override bool CheckNotNull()
		{
			if(txt4.Text.Trim()=="")// 客房名称不能为空
			{
				MessageBox.Show("客房名称不能为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}	
			if(txt5.Text.Trim()=="")// 价格不能为空
			{
				MessageBox.Show("价格不能为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			
			return base.CheckNotNull ();
		}

		//--------------价格文本框只能输入数字，小数点和删除--------------
		private void txt6_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(!((e.KeyChar<='9'&&e.KeyChar>='0')||e.KeyChar=='.'||e.KeyChar==8))
			{
				e.Handled=true;
			}
		}

        private void RoomType_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }
	}
}

