using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 酒店管理系统
{
	public class HotelLeave : 医院管理系统.ParentForm
	{
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private 酒店管理系统.DataSet1 dataSet11;
		private System.Data.SqlClient.SqlDataAdapter da2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Data.DataView dataView1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Windows.Forms.Button btnCal;
		private System.Windows.Forms.Button btnLeave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.ComponentModel.IContainer components = null;
        private MainForm mainForm;
		public HotelLeave(MainForm mf)
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
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.dataView1 = new System.Data.DataView();
            this.dataSet11 = new 酒店管理系统.DataSet1();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.da2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "客房编号";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "入住单号";
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
            // tBtnNew
            // 
            this.tBtnNew.Visible = false;
            // 
            // tBtnEdit
            // 
            this.tBtnEdit.Visible = false;
            // 
            // tBtnDelete
            // 
            this.tBtnDelete.Visible = false;
            // 
            // tBtnSubmit
            // 
            this.tBtnSubmit.Visible = false;
            // 
            // tBtnCancel
            // 
            this.tBtnCancel.Visible = false;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "入住单";
            this.dataGrid1.DataSource = this.dataSet11;
            this.dataGrid1.Size = new System.Drawing.Size(728, 160);
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.btnCal);
            this.groupBox2.Controls.Add(this.btnLeave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 408);
            this.groupBox2.Size = new System.Drawing.Size(728, 88);
            // 
            // da1
            // 
            this.da1.DeleteCommand = null;
            this.da1.InsertCommand = null;
            this.da1.SelectCommand = this.sqlSelectCommand1;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "入住单", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("入住单号", "入住单号"),
                        new System.Data.Common.DataColumnMapping("预定单号", "预定单号"),
                        new System.Data.Common.DataColumnMapping("会员编号", "会员编号"),
                        new System.Data.Common.DataColumnMapping("抵店时间", "抵店时间"),
                        new System.Data.Common.DataColumnMapping("离店时间", "离店时间"),
                        new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
                        new System.Data.Common.DataColumnMapping("客房价格", "客房价格"),
                        new System.Data.Common.DataColumnMapping("入住价格", "入住价格"),
                        new System.Data.Common.DataColumnMapping("是否加床", "是否加床"),
                        new System.Data.Common.DataColumnMapping("加床价格", "加床价格"),
                        new System.Data.Common.DataColumnMapping("预收款", "预收款"),
                        new System.Data.Common.DataColumnMapping("早餐", "早餐"),
                        new System.Data.Common.DataColumnMapping("叫醒", "叫醒"),
                        new System.Data.Common.DataColumnMapping("保密", "保密"),
                        new System.Data.Common.DataColumnMapping("vip", "vip"),
                        new System.Data.Common.DataColumnMapping("电话等级", "电话等级"),
                        new System.Data.Common.DataColumnMapping("特要说明", "特要说明"),
                        new System.Data.Common.DataColumnMapping("应收帐款", "应收帐款"),
                        new System.Data.Common.DataColumnMapping("是否结帐", "是否结帐"),
                        new System.Data.Common.DataColumnMapping("结帐金额", "结帐金额"),
                        new System.Data.Common.DataColumnMapping("结帐日期", "结帐日期"),
                        new System.Data.Common.DataColumnMapping("付款方式", "付款方式"),
                        new System.Data.Common.DataColumnMapping("入住人数", "入住人数")})});
            this.da1.UpdateCommand = null;
            // 
            // dataGrid2
            // 
            this.dataGrid2.CaptionVisible = false;
            this.dataGrid2.DataMember = "";
            this.dataGrid2.DataSource = this.dataView1;
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(0, 256);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ReadOnly = true;
            this.dataGrid2.Size = new System.Drawing.Size(728, 152);
            this.dataGrid2.TabIndex = 32;
            // 
            // dataView1
            // 
            this.dataView1.Table = this.dataSet11.帐单明细;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // da2
            // 
            this.da2.SelectCommand = this.sqlSelectCommand2;
            this.da2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "帐单明细", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("帐单编号", "帐单编号"),
                        new System.Data.Common.DataColumnMapping("入住单号", "入住单号"),
                        new System.Data.Common.DataColumnMapping("消费内容", "消费内容"),
                        new System.Data.Common.DataColumnMapping("消费金额", "消费金额"),
                        new System.Data.Common.DataColumnMapping("消费时间", "消费时间"),
                        new System.Data.Common.DataColumnMapping("备注", "备注")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT 帐单编号, 入住单号, 消费内容, 消费金额, 消费时间, 备注 FROM 帐单明细";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(56, 32);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(112, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "计算应收款";
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(464, 32);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(128, 23);
            this.btnLeave.TabIndex = 0;
            this.btnLeave.Text = "收银结帐退房";
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "入住单.应收帐款", true));
            this.txt4.Location = new System.Drawing.Point(192, 32);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 21);
            this.txt4.TabIndex = 1;
            // 
            // cmb1
            // 
            this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "入住单.付款方式", true));
            this.cmb1.Items.AddRange(new object[] {
            "现金",
            "支票",
            "信用卡",
            "代金券",
            "其他"});
            this.cmb1.Location = new System.Drawing.Point(312, 32);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 20);
            this.cmb1.TabIndex = 2;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT 入住单号, 预定单号, 会员编号, 抵店时间, 离店时间, 客房编号, 客房价格, 入住价格, 是否加床, 加床价格, 预收款, 早餐, 叫醒, 保" +
    "密, vip, 电话等级, 特要说明, 应收帐款, 是否结帐, 结帐金额, 结帐日期, 付款方式, 入住人数 FROM 入住单 WHERE (入住单号 LIKE" +
    " @Param17) AND (客房编号 LIKE @Param18)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param17", System.Data.SqlDbType.VarChar, 36, "入住单号"),
            new System.Data.SqlClient.SqlParameter("@Param18", System.Data.SqlDbType.VarChar, 12, "客房编号")});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(192, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "应付款";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(312, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "支付方式";
            // 
            // HotelLeave
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.dataGrid2);
            this.Name = "HotelLeave";
            this.Text = "收银结帐";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotelLeave_FormClosing);
            this.Load += new System.EventHandler(this.HotelLeave_Load);
            this.Controls.SetChildIndex(this.dataGrid2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.toolBar1, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//----------生成窗体时读入数据-----------
		private void HotelLeave_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";
			da1.SelectCommand.Parameters[1].Value="%";
			da1.Fill(this.dataSet11);
			da2.Fill(dataSet11);
			if(dataSet11.入住单.Rows.Count!=0)//读入第一个入住单的帐单明细
                dataView1.RowFilter="入住单号='"+dataSet11.入住单.Rows[0]["入住单号"].ToString()+"'";
			base.dataSet11=this.dataSet11;
			cmOrders=(CurrencyManager) BindingContext[this.dataSet11,"入住单"];

		}

		//---------显示帐单明细-------
		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			//根据当前行的入住单号，检索入住单帐单明细
			int i=dataGrid1.CurrentRowIndex;
			dataView1.RowFilter="入住单号='"+dataGrid1[i,0].ToString()+"'";
		}

		//-----------根据输入，检索信息---------
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
			da2.Fill(dataSet11);
			if(dataSet11.入住单.Rows.Count==0)//如果没有查到数据，则不显示帐单明细
				dataView1.RowFilter="入住单号=''";
			else//如果查到了数据，则显示明细
				dataView1.RowFilter="入住单号='"+dataSet11.入住单.Rows[0]["入住单号"].ToString()+"'";
		}

		
		//-------------计算应付房款---------------
		private void btnCal_Click(object sender, System.EventArgs e)
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			int i=dataGrid1.CurrentRowIndex;
			cmd.CommandText="exec sf_计算应收帐款 '"+dataGrid1[i,0].ToString()+"'";
			cmd.ExecuteNonQuery();
			dataSet11.Clear();//刷新数据集
			da1.Fill(dataSet11);
			da2.Fill(dataSet11);
			
			cmOrders.Position = i;//移动到刚才所选的行上
			this.dataGrid1.Select(cmOrders.Position); //选中当前行
			this.dataGrid1.CurrentRowIndex = cmOrders.Position; //移动表头指示图标
			cmb1.Text="现金";//默认付款方式
		
		}

		//------------收银结帐退房---------------
		private void btnLeave_Click(object sender, System.EventArgs e)
		{
			if(cmb1.Text.Trim()=="")//检查支付方式的选取
			{
				MessageBox.Show("请选择支付方式");
				return;
			}
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			int i=dataGrid1.CurrentRowIndex;
			cmd.CommandText="exec sf_收银退房 '"+dataGrid1[i,0].ToString()+"','"+cmb1.Text.Trim()+"'";
			cmd.ExecuteNonQuery();
			
			
			
			dataSet11.Clear();//刷新数据集
			da1.Fill(dataSet11);
			da2.Fill(dataSet11);


		}

        private void HotelLeave_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }

		


	}
}

