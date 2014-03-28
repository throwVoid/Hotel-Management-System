using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace 酒店管理系统
{
	public class RoomInfo : 医院管理系统.ParentForm
	{
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmb2;
		private System.Windows.Forms.ComboBox cmb3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private 酒店管理系统.DataSet1 dataSet11;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private System.Data.SqlClient.SqlCommand sqlCommand4;
		private System.Data.SqlClient.SqlCommand sqlCommand5;
		private System.Data.SqlClient.SqlCommand sqlCommand6;
		private System.Data.SqlClient.SqlCommand sqlCommand7;
		private System.Data.SqlClient.SqlCommand sqlCommand8;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter da2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlDataAdapter da3;
		private System.ComponentModel.IContainer components = null;
        private MainForm mainForm;

		public RoomInfo(MainForm mf)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            this.txt4 = new System.Windows.Forms.TextBox();
            this.dataSet11 = new 酒店管理系统.DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.da2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da3 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(736, 56);
            // 
            // label1
            // 
            this.label1.Text = "类型编号";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "客房编号";
            // 
            // label3
            // 
            this.label3.Text = "楼层编号";
            // 
            // toolBar1
            // 
            this.toolBar1.Size = new System.Drawing.Size(736, 41);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "客房信息";
            this.dataGrid1.DataSource = this.dataSet11;
            this.dataGrid1.Size = new System.Drawing.Size(736, 280);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.cmb2);
            this.groupBox2.Controls.Add(this.cmb3);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.txt8);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.txt7);
            this.groupBox2.Controls.Add(this.txt9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(0, 379);
            this.groupBox2.Size = new System.Drawing.Size(736, 128);
            // 
            // da1
            // 
            this.da1.DeleteCommand = this.sqlCommand8;
            this.da1.InsertCommand = this.sqlCommand6;
            this.da1.SelectCommand = this.sqlCommand5;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "客房信息", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
                        new System.Data.Common.DataColumnMapping("类型编号", "类型编号"),
                        new System.Data.Common.DataColumnMapping("楼层编号", "楼层编号"),
                        new System.Data.Common.DataColumnMapping("额定人数", "额定人数"),
                        new System.Data.Common.DataColumnMapping("床数", "床数"),
                        new System.Data.Common.DataColumnMapping("客房描述", "客房描述"),
                        new System.Data.Common.DataColumnMapping("备注", "备注"),
                        new System.Data.Common.DataColumnMapping("状态", "状态"),
                        new System.Data.Common.DataColumnMapping("是否可加床", "是否可加床")})});
            this.da1.UpdateCommand = this.sqlCommand7;
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房信息.客房编号", true));
            this.txt4.Location = new System.Drawing.Point(40, 40);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(112, 21);
            this.txt4.TabIndex = 15;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(40, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "客房编号";
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房信息.额定人数", true));
            this.txt5.Location = new System.Drawing.Point(440, 40);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(64, 21);
            this.txt5.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(176, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "客房类型";
            // 
            // txt8
            // 
            this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房信息.客房描述", true));
            this.txt8.Location = new System.Drawing.Point(40, 86);
            this.txt8.Name = "txt8";
            this.txt8.ReadOnly = true;
            this.txt8.Size = new System.Drawing.Size(232, 21);
            this.txt8.TabIndex = 17;
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房信息.床数", true));
            this.txt6.Location = new System.Drawing.Point(528, 40);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(64, 21);
            this.txt6.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(440, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "额定人数";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(40, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "客房描述";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(312, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "楼层";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(528, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "床数";
            // 
            // cmb2
            // 
            this.cmb2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet11, "客房信息.类型编号", true));
            this.cmb2.DataSource = this.dataSet11;
            this.cmb2.DisplayMember = "客房类型.类型名称";
            this.cmb2.Enabled = false;
            this.cmb2.Location = new System.Drawing.Point(176, 40);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(120, 20);
            this.cmb2.TabIndex = 19;
            this.cmb2.ValueMember = "客房信息.类型编号";
            // 
            // cmb3
            // 
            this.cmb3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet11, "客房信息.楼层编号", true));
            this.cmb3.DataSource = this.dataSet11;
            this.cmb3.DisplayMember = "楼层信息.楼层名称";
            this.cmb3.Enabled = false;
            this.cmb3.Location = new System.Drawing.Point(312, 40);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(104, 20);
            this.cmb3.TabIndex = 18;
            this.cmb3.ValueMember = "楼层信息.楼层编号";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(616, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "状态";
            // 
            // txt7
            // 
            this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房信息.状态", true));
            this.txt7.Location = new System.Drawing.Point(616, 40);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(88, 21);
            this.txt7.TabIndex = 14;
            // 
            // txt9
            // 
            this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "客房信息.备注", true));
            this.txt9.Location = new System.Drawing.Point(304, 86);
            this.txt9.Name = "txt9";
            this.txt9.ReadOnly = true;
            this.txt9.Size = new System.Drawing.Size(232, 21);
            this.txt9.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(304, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "备注";
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet11, "客房信息.是否可加床", true));
            this.checkBox1.Location = new System.Drawing.Point(568, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "是否可加床";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT 客房编号, 类型编号, 楼层编号, 额定人数, 床数, 客房描述, 备注, 状态, 是否可加床 FROM 客房信息 WHERE (客房编号 LIKE" +
    " @Param4) AND (类型编号 LIKE @Param5) AND (楼层编号 LIKE @Param6)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.Int, 4, "楼层编号")});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@楼层编号", System.Data.SqlDbType.Int, 4, "楼层编号"),
            new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"),
            new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"),
            new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"),
            new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 4, "状态"),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@楼层编号", System.Data.SqlDbType.Int, 4, "楼层编号"),
            new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"),
            new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"),
            new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"),
            new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 4, "状态"),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床"),
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "床数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_楼层编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "楼层编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "床数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_楼层编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "楼层编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT 客房编号, 类型编号, 楼层编号, 额定人数, 床数, 客房描述, 备注, 状态, 是否可加床 FROM 客房信息 WHERE (客房编号 LIKE" +
    " @Param4) AND (类型编号 LIKE @Param5) AND (楼层编号 LIKE @Param6)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.Int, 4, "楼层编号")});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConnection1;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@楼层编号", System.Data.SqlDbType.Int, 4, "楼层编号"),
            new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"),
            new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"),
            new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"),
            new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 4, "状态"),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConnection1;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@楼层编号", System.Data.SqlDbType.Int, 4, "楼层编号"),
            new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"),
            new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"),
            new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"),
            new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 4, "状态"),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床"),
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "床数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_楼层编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "楼层编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "床数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_楼层编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "楼层编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT 客房编号, 类型编号, 楼层编号, 额定人数, 床数, 客房描述, 备注, 状态, 是否可加床 FROM 客房信息 WHERE (客房编号 LIKE" +
    " @Param4) AND (类型编号 LIKE @Param5) AND (楼层编号 LIKE @Param6)";
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 4, "楼层编号")});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlConnection1;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@楼层编号", System.Data.SqlDbType.Int, 4, "楼层编号"),
            new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"),
            new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"),
            new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"),
            new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 4, "状态"),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床")});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            this.sqlCommand7.Connection = this.sqlConnection1;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 4, "类型编号"),
            new System.Data.SqlClient.SqlParameter("@楼层编号", System.Data.SqlDbType.Int, 4, "楼层编号"),
            new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"),
            new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"),
            new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"),
            new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 4, "状态"),
            new System.Data.SqlClient.SqlParameter("@是否可加床", System.Data.SqlDbType.Bit, 1, "是否可加床"),
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "床数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_楼层编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "楼层编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlConnection1;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "床数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否可加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否可加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_楼层编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "楼层编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null)});
            // 
            // da2
            // 
            this.da2.SelectCommand = this.sqlSelectCommand2;
            this.da2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "楼层信息", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("楼层编号", "楼层编号"),
                        new System.Data.Common.DataColumnMapping("楼层名称", "楼层名称")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT 楼层编号, 楼层名称 FROM 楼层信息";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // da3
            // 
            this.da3.SelectCommand = this.sqlSelectCommand3;
            this.da3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "客房类型", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("类型编号", "类型编号"),
                        new System.Data.Common.DataColumnMapping("类型名称", "类型名称"),
                        new System.Data.Common.DataColumnMapping("价格", "价格"),
                        new System.Data.Common.DataColumnMapping("加床价格", "加床价格"),
                        new System.Data.Common.DataColumnMapping("可超预定数", "可超预定数"),
                        new System.Data.Common.DataColumnMapping("是否可加床", "是否可加床")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT 类型编号, 类型名称, 价格, 加床价格, 可超预定数, 是否可加床 FROM 客房类型";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // RoomInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 509);
            this.Name = "RoomInfo";
            this.Text = "【客房信息设置】";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomInfo_FormClosing);
            this.Load += new System.EventHandler(this.RoomInfo_Load);
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

		//----------初始化窗体时读入全部信息--------------
		private void RoomInfo_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].Value="%";
			da1.SelectCommand.Parameters[2].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[2].Value="%";
			da1.Fill(dataSet11);//填充客房信息
			//设置数据导航控件
			this.cmOrders=(CurrencyManager) BindingContext[dataSet11,"客房信息"];	
			//将基类中的数据集与派生类中的数据集连接
			base.dataSet11=this.dataSet11;
			//填充其他编号和名称数据
			da2.Fill(dataSet11);
			da3.Fill(dataSet11);
			
		}

		//-----------根据输入，检索信息----------
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";
			da1.SelectCommand.Parameters[1].Value="%";
			da1.SelectCommand.Parameters[2].Value="%";
			if(txt1.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[0].Value="%"+txt1.Text.Trim()+"%";
			}
			if(txt2.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[1].Value="%"+txt2.Text.Trim()+"%";
			}
			if(txt3.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[2].Value="%"+txt3.Text.Trim()+"%";
			}
			dataSet11.Clear();//刷新数据集
			da1.Fill(dataSet11);
			//填充其他编号和名称数据
			da2.Fill(dataSet11);
			da3.Fill(dataSet11);
			
		}

		//----------重写设置控件只读属性函数----------
		protected override void SetModifyMode(bool blnEdit)
		{
			base.SetModifyMode (blnEdit);
			txt4.ReadOnly=!blnEdit;
			txt5.ReadOnly=!blnEdit;
			txt6.ReadOnly=!blnEdit;
			
			txt8.ReadOnly=!blnEdit;
			txt9.ReadOnly=!blnEdit;
			
			cmb2.Enabled=blnEdit;
			cmb3.Enabled=blnEdit;

			checkBox1.Enabled=blnEdit;
         }

		//-------重写新增记录时设置默认值函数--------
		protected override void SetDefaultValue()
		{
			base.SetDefaultValue ();
			cmb2.SelectedText="";
			cmb3.SelectedText="";
			txt7.Text="空房";//新增房间默认都为空房
		}

		//-------重写检查非空字段函数--------
		protected override bool CheckNotNull()
		{
						
			if(txt4.Text.Trim()=="")// 检查房间编号
			{
				MessageBox.Show("房间号不能为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb2.Text.Trim()=="")//检查客房类型
			{
				MessageBox.Show("请选择客房类型","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb3.Text.Trim()=="")//检查楼层
			{
				MessageBox.Show("请选择楼层","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			
			return base.CheckNotNull ();
		}

        private void RoomInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }
	}
}

