using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 酒店管理系统
{
	public class HotelReserve : 医院管理系统.ParentForm
	{
		public static string[] roomInfo;//保存从房态图中返回的信息
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private 酒店管理系统.DataSet2 dataSet21;
		private System.Data.SqlClient.SqlDataAdapter da2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.ComboBox cmb2;
		private System.Windows.Forms.ComboBox cmb3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.TextBox txt10;
		private System.Windows.Forms.TextBox txt11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt13;
		private System.Windows.Forms.TextBox txt14;
		private System.Windows.Forms.TextBox txt12;
		private System.Windows.Forms.TextBox txt15;
		private System.Windows.Forms.TextBox txt16;
		private System.Windows.Forms.TextBox txt17;
		private System.Windows.Forms.TextBox txt18;
		private System.Windows.Forms.TextBox txt19;
		private System.Windows.Forms.TextBox txt20;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.MonthCalendar calen1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.Button btnRoom;
		private System.ComponentModel.IContainer components = null;
        private MainForm mainForm;

		public HotelReserve(MainForm mf)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelReserve));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet21 = new 酒店管理系统.DataSet2();
            this.da2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.txt14 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.txt17 = new System.Windows.Forms.TextBox();
            this.txt18 = new System.Windows.Forms.TextBox();
            this.txt19 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.calen1 = new System.Windows.Forms.MonthCalendar();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.btnRoom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "抵店时间";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "预定单号";
            // 
            // label3
            // 
            this.label3.Text = "预定人";
            // 
            // toolBar1
            // 
            this.toolBar1.Size = new System.Drawing.Size(728, 41);
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "预定单";
            this.dataGrid1.DataSource = this.dataSet21;
            this.dataGrid1.Size = new System.Drawing.Size(728, 216);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRoom);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txt13);
            this.groupBox2.Controls.Add(this.txt14);
            this.groupBox2.Controls.Add(this.txt12);
            this.groupBox2.Controls.Add(this.txt15);
            this.groupBox2.Controls.Add(this.txt16);
            this.groupBox2.Controls.Add(this.txt17);
            this.groupBox2.Controls.Add(this.txt18);
            this.groupBox2.Controls.Add(this.txt19);
            this.groupBox2.Controls.Add(this.txt20);
            this.groupBox2.Controls.Add(this.txt7);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.txt8);
            this.groupBox2.Controls.Add(this.txt9);
            this.groupBox2.Controls.Add(this.txt10);
            this.groupBox2.Controls.Add(this.txt11);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.cmb2);
            this.groupBox2.Controls.Add(this.cmb3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Size = new System.Drawing.Size(728, 192);
            // 
            // da1
            // 
            this.da1.DeleteCommand = this.sqlDeleteCommand1;
            this.da1.InsertCommand = this.sqlInsertCommand1;
            this.da1.SelectCommand = this.sqlSelectCommand1;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "预定单", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("预定单号", "预定单号"),
                        new System.Data.Common.DataColumnMapping("会员编号", "会员编号"),
                        new System.Data.Common.DataColumnMapping("客房类型", "客房类型"),
                        new System.Data.Common.DataColumnMapping("抵店时间", "抵店时间"),
                        new System.Data.Common.DataColumnMapping("离店时间", "离店时间"),
                        new System.Data.Common.DataColumnMapping("单据状态", "单据状态"),
                        new System.Data.Common.DataColumnMapping("入住人数", "入住人数"),
                        new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
                        new System.Data.Common.DataColumnMapping("客房价格", "客房价格"),
                        new System.Data.Common.DataColumnMapping("入住价格", "入住价格"),
                        new System.Data.Common.DataColumnMapping("折扣", "折扣"),
                        new System.Data.Common.DataColumnMapping("折扣原因", "折扣原因"),
                        new System.Data.Common.DataColumnMapping("是否加床", "是否加床"),
                        new System.Data.Common.DataColumnMapping("加床价格", "加床价格"),
                        new System.Data.Common.DataColumnMapping("预收款", "预收款"),
                        new System.Data.Common.DataColumnMapping("预定人", "预定人"),
                        new System.Data.Common.DataColumnMapping("预定公司", "预定公司"),
                        new System.Data.Common.DataColumnMapping("联系电话", "联系电话"),
                        new System.Data.Common.DataColumnMapping("备注", "备注"),
                        new System.Data.Common.DataColumnMapping("操作员", "操作员"),
                        new System.Data.Common.DataColumnMapping("业务员", "业务员")})});
            this.da1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // da2
            // 
            this.da2.SelectCommand = this.sqlSelectCommand2;
            this.da2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "客房类型", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("类型编号", "类型编号"),
                        new System.Data.Common.DataColumnMapping("类型名称", "类型名称")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT 类型编号, 类型名称 FROM 客房类型";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.预定单号", true));
            this.txt4.Location = new System.Drawing.Point(24, 32);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(112, 21);
            this.txt4.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 96;
            this.label4.Text = "预定单号";
            // 
            // cmb1
            // 
            this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet21, "预定单.客房类型", true));
            this.cmb1.DataSource = this.dataSet21;
            this.cmb1.DisplayMember = "客房类型.类型名称";
            this.cmb1.Enabled = false;
            this.cmb1.Location = new System.Drawing.Point(152, 32);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(112, 20);
            this.cmb1.TabIndex = 118;
            this.cmb1.ValueMember = "客房类型.类型编号";
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.联系电话", true));
            this.txt5.Location = new System.Drawing.Point(568, 32);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(136, 21);
            this.txt5.TabIndex = 117;
            // 
            // cmb2
            // 
            this.cmb2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.抵店时间", true));
            this.cmb2.Enabled = false;
            this.cmb2.Location = new System.Drawing.Point(280, 32);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(128, 20);
            this.cmb2.TabIndex = 120;
            this.cmb2.DropDown += new System.EventHandler(this.cmb2_DropDown);
            this.cmb2.Leave += new System.EventHandler(this.cmb2_Leave);
            // 
            // cmb3
            // 
            this.cmb3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.离店时间", true));
            this.cmb3.Enabled = false;
            this.cmb3.Location = new System.Drawing.Point(424, 32);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(128, 20);
            this.cmb3.TabIndex = 119;
            this.cmb3.DropDown += new System.EventHandler(this.cmb3_DropDown);
            this.cmb3.Leave += new System.EventHandler(this.cmb3_Leave);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(568, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 113;
            this.label5.Text = "联系电话";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(152, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 114;
            this.label6.Text = "客房类型";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(280, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "抵店时间";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(424, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 116;
            this.label10.Text = "离店时间";
            // 
            // txt7
            // 
            this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.客房价格", true));
            this.txt7.Location = new System.Drawing.Point(128, 78);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(72, 21);
            this.txt7.TabIndex = 129;
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.客房编号", true));
            this.txt6.Location = new System.Drawing.Point(24, 78);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(64, 21);
            this.txt6.TabIndex = 127;
            // 
            // txt8
            // 
            this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.入住价格", true));
            this.txt8.Location = new System.Drawing.Point(216, 78);
            this.txt8.Name = "txt8";
            this.txt8.ReadOnly = true;
            this.txt8.Size = new System.Drawing.Size(72, 21);
            this.txt8.TabIndex = 128;
            // 
            // txt9
            // 
            this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.折扣", true));
            this.txt9.Location = new System.Drawing.Point(304, 78);
            this.txt9.Name = "txt9";
            this.txt9.ReadOnly = true;
            this.txt9.Size = new System.Drawing.Size(64, 21);
            this.txt9.TabIndex = 130;
            // 
            // txt10
            // 
            this.txt10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.折扣原因", true));
            this.txt10.Location = new System.Drawing.Point(392, 78);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(128, 21);
            this.txt10.TabIndex = 132;
            // 
            // txt11
            // 
            this.txt11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.入住人数", true));
            this.txt11.Location = new System.Drawing.Point(544, 78);
            this.txt11.Name = "txt11";
            this.txt11.ReadOnly = true;
            this.txt11.Size = new System.Drawing.Size(48, 21);
            this.txt11.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 121;
            this.label9.Text = "客房编号";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(128, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "客房价格";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(208, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 125;
            this.label11.Text = "入住价格";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(304, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 124;
            this.label12.Text = "折扣";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(392, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 122;
            this.label13.Text = "折扣原因";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(544, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 126;
            this.label14.Text = "入住人数";
            // 
            // txt13
            // 
            this.txt13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.预收款", true));
            this.txt13.Location = new System.Drawing.Point(120, 120);
            this.txt13.Name = "txt13";
            this.txt13.ReadOnly = true;
            this.txt13.Size = new System.Drawing.Size(64, 21);
            this.txt13.TabIndex = 164;
            // 
            // txt14
            // 
            this.txt14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.单据状态", true));
            this.txt14.Location = new System.Drawing.Point(208, 120);
            this.txt14.Name = "txt14";
            this.txt14.ReadOnly = true;
            this.txt14.Size = new System.Drawing.Size(72, 21);
            this.txt14.TabIndex = 165;
            // 
            // txt12
            // 
            this.txt12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.加床价格", true));
            this.txt12.Location = new System.Drawing.Point(24, 120);
            this.txt12.Name = "txt12";
            this.txt12.ReadOnly = true;
            this.txt12.Size = new System.Drawing.Size(72, 21);
            this.txt12.TabIndex = 162;
            // 
            // txt15
            // 
            this.txt15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.预定人", true));
            this.txt15.Location = new System.Drawing.Point(304, 120);
            this.txt15.Name = "txt15";
            this.txt15.ReadOnly = true;
            this.txt15.Size = new System.Drawing.Size(72, 21);
            this.txt15.TabIndex = 163;
            // 
            // txt16
            // 
            this.txt16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.业务员", true));
            this.txt16.Location = new System.Drawing.Point(400, 120);
            this.txt16.Name = "txt16";
            this.txt16.ReadOnly = true;
            this.txt16.Size = new System.Drawing.Size(72, 21);
            this.txt16.TabIndex = 166;
            // 
            // txt17
            // 
            this.txt17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.操作员", true));
            this.txt17.Location = new System.Drawing.Point(496, 120);
            this.txt17.Name = "txt17";
            this.txt17.ReadOnly = true;
            this.txt17.Size = new System.Drawing.Size(72, 21);
            this.txt17.TabIndex = 168;
            // 
            // txt18
            // 
            this.txt18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "预定单.会员编号", true));
            this.txt18.Location = new System.Drawing.Point(584, 120);
            this.txt18.Name = "txt18";
            this.txt18.ReadOnly = true;
            this.txt18.Size = new System.Drawing.Size(120, 21);
            this.txt18.TabIndex = 167;
            // 
            // txt19
            // 
            this.txt19.Location = new System.Drawing.Point(24, 168);
            this.txt19.Name = "txt19";
            this.txt19.ReadOnly = true;
            this.txt19.Size = new System.Drawing.Size(144, 21);
            this.txt19.TabIndex = 160;
            // 
            // txt20
            // 
            this.txt20.Location = new System.Drawing.Point(200, 168);
            this.txt20.Name = "txt20";
            this.txt20.ReadOnly = true;
            this.txt20.Size = new System.Drawing.Size(504, 21);
            this.txt20.TabIndex = 161;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(304, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 153;
            this.label15.Text = "预定人";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(120, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 154;
            this.label16.Text = "预收款";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(24, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 151;
            this.label17.Text = "加床价格";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(208, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 152;
            this.label18.Text = "单据状态";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(400, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 155;
            this.label19.Text = "业务员";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(496, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 158;
            this.label20.Text = "操作员";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(584, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 159;
            this.label21.Text = "会员编号";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(24, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 157;
            this.label22.Text = "预定公司";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(200, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 156;
            this.label23.Text = "备注";
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet21, "预定单.是否加床", true));
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(616, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 24);
            this.checkBox1.TabIndex = 169;
            this.checkBox1.Text = "是否加床";
            // 
            // calen1
            // 
            this.calen1.Location = new System.Drawing.Point(328, 192);
            this.calen1.Name = "calen1";
            this.calen1.TabIndex = 33;
            this.calen1.Visible = false;
            this.calen1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calen1_DateSelected);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 36, "预定单号"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 10, "抵店时间"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 20, "预定人")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@预定单号", System.Data.SqlDbType.VarChar, 36, "预定单号"),
            new System.Data.SqlClient.SqlParameter("@会员编号", System.Data.SqlDbType.Int, 4, "会员编号"),
            new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 4, "客房类型"),
            new System.Data.SqlClient.SqlParameter("@抵店时间", System.Data.SqlDbType.DateTime, 4, "抵店时间"),
            new System.Data.SqlClient.SqlParameter("@离店时间", System.Data.SqlDbType.DateTime, 4, "离店时间"),
            new System.Data.SqlClient.SqlParameter("@单据状态", System.Data.SqlDbType.VarChar, 20, "单据状态"),
            new System.Data.SqlClient.SqlParameter("@入住人数", System.Data.SqlDbType.Int, 4, "入住人数"),
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Money, 8, "客房价格"),
            new System.Data.SqlClient.SqlParameter("@入住价格", System.Data.SqlDbType.Money, 8, "入住价格"),
            new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "折扣", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@折扣原因", System.Data.SqlDbType.VarChar, 60, "折扣原因"),
            new System.Data.SqlClient.SqlParameter("@是否加床", System.Data.SqlDbType.Bit, 1, "是否加床"),
            new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Money, 8, "加床价格"),
            new System.Data.SqlClient.SqlParameter("@预收款", System.Data.SqlDbType.Money, 8, "预收款"),
            new System.Data.SqlClient.SqlParameter("@预定人", System.Data.SqlDbType.VarChar, 20, "预定人"),
            new System.Data.SqlClient.SqlParameter("@预定公司", System.Data.SqlDbType.VarChar, 60, "预定公司"),
            new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 40, "联系电话"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 510, "备注"),
            new System.Data.SqlClient.SqlParameter("@操作员", System.Data.SqlDbType.VarChar, 10, "操作员"),
            new System.Data.SqlClient.SqlParameter("@业务员", System.Data.SqlDbType.VarChar, 50, "业务员")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@预定单号", System.Data.SqlDbType.VarChar, 36, "预定单号"),
            new System.Data.SqlClient.SqlParameter("@会员编号", System.Data.SqlDbType.Int, 4, "会员编号"),
            new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 4, "客房类型"),
            new System.Data.SqlClient.SqlParameter("@抵店时间", System.Data.SqlDbType.DateTime, 4, "抵店时间"),
            new System.Data.SqlClient.SqlParameter("@离店时间", System.Data.SqlDbType.DateTime, 4, "离店时间"),
            new System.Data.SqlClient.SqlParameter("@单据状态", System.Data.SqlDbType.VarChar, 20, "单据状态"),
            new System.Data.SqlClient.SqlParameter("@入住人数", System.Data.SqlDbType.Int, 4, "入住人数"),
            new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 12, "客房编号"),
            new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Money, 8, "客房价格"),
            new System.Data.SqlClient.SqlParameter("@入住价格", System.Data.SqlDbType.Money, 8, "入住价格"),
            new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "折扣", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@折扣原因", System.Data.SqlDbType.VarChar, 60, "折扣原因"),
            new System.Data.SqlClient.SqlParameter("@是否加床", System.Data.SqlDbType.Bit, 1, "是否加床"),
            new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Money, 8, "加床价格"),
            new System.Data.SqlClient.SqlParameter("@预收款", System.Data.SqlDbType.Money, 8, "预收款"),
            new System.Data.SqlClient.SqlParameter("@预定人", System.Data.SqlDbType.VarChar, 20, "预定人"),
            new System.Data.SqlClient.SqlParameter("@预定公司", System.Data.SqlDbType.VarChar, 60, "预定公司"),
            new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 40, "联系电话"),
            new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 510, "备注"),
            new System.Data.SqlClient.SqlParameter("@操作员", System.Data.SqlDbType.VarChar, 10, "操作员"),
            new System.Data.SqlClient.SqlParameter("@业务员", System.Data.SqlDbType.VarChar, 50, "业务员"),
            new System.Data.SqlClient.SqlParameter("@Original_预定单号", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预定单号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_业务员", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "业务员", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_会员编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "会员编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_入住人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "入住人数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_入住价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "入住价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_单据状态", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "单据状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 510, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "折扣", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_折扣原因", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "折扣原因", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_抵店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "抵店时间", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_操作员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "操作员", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_离店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "离店时间", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_预定人", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预定人", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_预定公司", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预定公司", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_预收款", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预收款", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_预定单号", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预定单号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_业务员", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "业务员", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_会员编号", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "会员编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_入住人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "入住人数", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_入住价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "入住价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_单据状态", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "单据状态", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 510, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "备注", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "折扣", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_折扣原因", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "折扣原因", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_抵店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "抵店时间", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_操作员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "操作员", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_是否加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "是否加床", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_离店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "离店时间", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_预定人", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预定人", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_预定公司", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预定公司", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_预收款", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "预收款", System.Data.DataRowVersion.Original, null)});
            // 
            // btnRoom
            // 
            this.btnRoom.Enabled = false;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.Location = new System.Drawing.Point(96, 78);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(24, 24);
            this.btnRoom.TabIndex = 170;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            this.btnRoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRoom_MouseUp);
            // 
            // HotelReserve
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 517);
            this.Controls.Add(this.calen1);
            this.Name = "HotelReserve";
            this.Text = "【客房预定】";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotelReserve_FormClosing);
            this.Load += new System.EventHandler(this.HotelReserve_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.toolBar1, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.calen1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//----------创建窗体时，读入数据并完成数据控件连接---------
		private void HotelReserve_Load(object sender, System.EventArgs e)
		{
			//填充数据集
			da2.Fill(dataSet21);
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[1].Value="%";
			da1.SelectCommand.Parameters[2].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[2].Value="%";
			da1.Fill(dataSet21);//填充客房预定信息
			base.dataSet11=this.dataSet21;
			this.cmOrders=(CurrencyManager) BindingContext[dataSet21,"预定单"];
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
			txt10.ReadOnly=!blnEdit;
			txt11.ReadOnly=!blnEdit;
			txt12.ReadOnly=!blnEdit;
			txt13.ReadOnly=!blnEdit;
			
			txt15.ReadOnly=!blnEdit;
			txt16.ReadOnly=!blnEdit;
			txt17.ReadOnly=!blnEdit;
			txt18.ReadOnly=!blnEdit;
			txt19.ReadOnly=!blnEdit;
			txt20.ReadOnly=!blnEdit;
			
			cmb2.Enabled=blnEdit;
			cmb3.Enabled=blnEdit;

			checkBox1.Enabled=blnEdit;

			btnRoom.Enabled=blnEdit;
		}

		//-------重写新增记录时设置默认值函数--------
		protected override void SetDefaultValue()
		{
			//base.SetDefaultValue();
			
			txt14.Text="预定";//新增单据状态为预定
			//自动计算新编号
			string connStr="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
			SqlConnection cn=new SqlConnection(connStr);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			if(dataSet21.预定单.Rows.Count==0)
				cmd.CommandText="select max(预定单号) 最大编号 from 预定单历史";
			else
                cmd.CommandText="select max(预定单号) 最大编号 from 预定单";
			object result=cmd.ExecuteScalar();
			int order=1;
			if(result!=System.DBNull.Value)
			{
				string maxID=result.ToString().Trim();
				maxID=maxID.Substring(2,maxID.Length-2);
				order=Convert.ToInt16(maxID)+1;
			}
			int length=order.ToString().Length;
			string newID="";
			switch(length)
			{
				case 1:
					newID="YD0000000"+order.ToString();
					break;
				case 2:
					newID="YD000000"+order.ToString();
					break;
				case 3:
					newID="YD00000"+order.ToString();
					break;
				case 4:
					newID="YD0000"+order.ToString();
					break;
				case 5:
					newID="YD000"+order.ToString();
					break;
				case 6:
					newID="YD00"+order.ToString();
					break;
				case 7:
					newID="YD0"+order.ToString();
					break;
			}
			txt4.Text=newID;//自动生成编号
			cmb2.Text=System.DateTime.Now.Date.ToString();//抵店时间默认为当天
			cmb3.Text=System.DateTime.Now.Date.AddDays(3).ToString();//离店时间为3天后
			
		}

		//-------重写检查非空字段函数--------
		protected override bool CheckNotNull()
		{
						
			if(txt4.Text.Trim()=="")// 检查预定编号
			{
				MessageBox.Show("预定编号不能为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(txt6.Text.Trim()=="")//检查客房编号
			{
				MessageBox.Show("请选择客房编号","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb2.Text.Trim()=="")//检查抵店时间
			{
				MessageBox.Show("请选择抵店时间","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}			
			return base.CheckNotNull ();
		}

		//-----显示和选择抵店日期和离店日期-----
		private void cmb2_DropDown(object sender, System.EventArgs e)
		{
			selectDate(cmb2);		
		}
		private void cmb3_DropDown(object sender, System.EventArgs e)
		{
			selectDate(cmb3);
		}

		//----------关闭日期控件的显示----------
		private void cmb2_Leave(object sender, System.EventArgs e)
		{
			calen1.Visible=false;		
		}
		private void cmb3_Leave(object sender, System.EventArgs e)
		{
			calen1.Visible=false;
		}
	
		

		//-----------单击下拉列表框下拉箭头时显示日期以供选择---------------
		private void selectDate(ComboBox cb)
		{
			calen1.Left=cb.Left;//设置日期控件的位置
			calen1.Top=cb.Top-calen1.Height-10+groupBox2.Top;
			if(cb.Text.Trim()!="")
			{
				calen1.SelectionStart=Convert.ToDateTime(cb.Text);//日历显示的时间为数据时间
				calen1.SelectionEnd=Convert.ToDateTime(cb.Text);
			}

			calen1.Visible=true;//显示日期
			calen1.Show();
		}

		//-----------从日历控件中选择日期信息------------
		private void calen1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			//判断是由哪个下拉列表框调出日历，以便回馈日期信息
			if(calen1.Left==cmb2.Left)
				cmb2.Text=calen1.SelectionEnd.ToString();
			if(calen1.Left==cmb3.Left)
				cmb3.Text=calen1.SelectionEnd.ToString();			
		}

		//--------根据输入条件，搜索数据----------
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
			dataSet21.Clear();//刷新数据集
			da1.Fill(dataSet21);
			//填充其他编号和名称数据
			da2.Fill(dataSet21);
		}

		//----------显示房态图并选择房间---------
		private void btnRoom_Click(object sender, System.EventArgs e)
		{
			RoomStatus newfrm=new RoomStatus(1,mainForm);
			newfrm.ShowDialog();		
		}

		private void btnRoom_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(roomInfo[0].Trim()=="")
			{
				return;
			}
			txt6.Text=roomInfo[0];//显示房间编号
			cmb1.Text=roomInfo[1];//显示房间类型
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="SELECT 价格 FROM 客房类型 where 类型名称='"+cmb1.Text+"'";
			txt7.Text=cmd.ExecuteScalar().ToString().Trim();//读入该类型客房价格
			txt8.Text=txt7.Text;//入住价格默认和客房价格一致
		}

		//---------保存预定单后更新房态-----------
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//在保存数据后再进行处理
			if(e.Button.ToolTipText=="提交")
			{
				//更新预定房间状态
				string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
                //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
				SqlConnection cn=new SqlConnection(strConn);
				cn.Open();
				SqlCommand cmd=cn.CreateCommand();
				cmd.CommandText="update 客房信息 set 状态='将到' where 客房编号='"+txt6.Text+"'";
				cmd.ExecuteNonQuery();
			}
		}

        private void HotelReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }


	}
}

