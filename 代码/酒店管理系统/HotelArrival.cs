using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace �Ƶ����ϵͳ
{
	public class HotelArrival : ҽԺ����ϵͳ.ParentForm
	{
		public static string[] roomInfo;//�ӷ�̬ͼ�з��ص���Ϣ
		public static DataRow dRow;//��Ԥ���������з��ص���Ϣ
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmb2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmb3;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txt10;
		private System.Windows.Forms.TextBox txt11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt13;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txt14;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txt12;
		private System.Windows.Forms.TextBox txt15;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txt16;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txt17;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txt18;
		private System.Windows.Forms.TextBox txt20;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button btnImport;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter da2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private �Ƶ����ϵͳ.DataSet2 dataSet21;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.ComboBox cmb4;
		private System.Windows.Forms.TextBox txt19;
		private System.Windows.Forms.MonthCalendar calen1;
		private System.Windows.Forms.Button btnRoom;
		private System.ComponentModel.IContainer components = null;
        private MainForm mainForm;
		public HotelArrival(MainForm mf)
		{
            mainForm = mf;
            mainForm.myHide();
			// �õ����� Windows ���������������ġ�
			InitializeComponent();
            if (mainForm.getAdmin() == false) toolBar1.Enabled = false;
			// TODO: �� InitializeComponent ���ú�����κγ�ʼ��
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region ��������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelArrival));
            this.txt4 = new System.Windows.Forms.TextBox();
            this.dataSet21 = new �Ƶ����ϵͳ.DataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt14 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt17 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt18 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt19 = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.calen1 = new System.Windows.Forms.MonthCalendar();
            this.btnRoom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "�ͷ����";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "��ס����";
            // 
            // label3
            // 
            this.label3.Text = "�ֵ�ʱ��";
            // 
            // toolBar1
            // 
            this.toolBar1.Size = new System.Drawing.Size(728, 41);
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tBtnDelete
            // 
            this.tBtnDelete.Visible = false;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "��ס��";
            this.dataGrid1.DataSource = this.dataSet21;
            this.dataGrid1.Size = new System.Drawing.Size(728, 176);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRoom);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt7);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmb2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmb3);
            this.groupBox2.Controls.Add(this.txt8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt9);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt10);
            this.groupBox2.Controls.Add(this.txt11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt14);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txt12);
            this.groupBox2.Controls.Add(this.txt15);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txt16);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txt17);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txt18);
            this.groupBox2.Controls.Add(this.txt20);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.cmb4);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txt19);
            this.groupBox2.Location = new System.Drawing.Point(0, 272);
            this.groupBox2.Size = new System.Drawing.Size(728, 248);
            // 
            // da1
            // 
            this.da1.DeleteCommand = this.sqlDeleteCommand1;
            this.da1.InsertCommand = this.sqlInsertCommand1;
            this.da1.SelectCommand = this.sqlSelectCommand1;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "��ס��", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
                        new System.Data.Common.DataColumnMapping("Ԥ������", "Ԥ������"),
                        new System.Data.Common.DataColumnMapping("��Ա���", "��Ա���"),
                        new System.Data.Common.DataColumnMapping("�ͷ�����", "�ͷ�����"),
                        new System.Data.Common.DataColumnMapping("�ֵ�ʱ��", "�ֵ�ʱ��"),
                        new System.Data.Common.DataColumnMapping("���ʱ��", "���ʱ��"),
                        new System.Data.Common.DataColumnMapping("����״̬", "����״̬"),
                        new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
                        new System.Data.Common.DataColumnMapping("�ͷ����", "�ͷ����"),
                        new System.Data.Common.DataColumnMapping("�ͷ��۸�", "�ͷ��۸�"),
                        new System.Data.Common.DataColumnMapping("��ס�۸�", "��ס�۸�"),
                        new System.Data.Common.DataColumnMapping("�ۿ�", "�ۿ�"),
                        new System.Data.Common.DataColumnMapping("�ۿ�ԭ��", "�ۿ�ԭ��"),
                        new System.Data.Common.DataColumnMapping("�Ƿ�Ӵ�", "�Ƿ�Ӵ�"),
                        new System.Data.Common.DataColumnMapping("�Ӵ��۸�", "�Ӵ��۸�"),
                        new System.Data.Common.DataColumnMapping("Ԥ�տ�", "Ԥ�տ�"),
                        new System.Data.Common.DataColumnMapping("Ԥ����", "Ԥ����"),
                        new System.Data.Common.DataColumnMapping("Ԥ����˾", "Ԥ����˾"),
                        new System.Data.Common.DataColumnMapping("��ϵ�绰", "��ϵ�绰"),
                        new System.Data.Common.DataColumnMapping("��ע", "��ע"),
                        new System.Data.Common.DataColumnMapping("����Ա", "����Ա"),
                        new System.Data.Common.DataColumnMapping("ҵ��Ա", "ҵ��Ա"),
                        new System.Data.Common.DataColumnMapping("���", "���"),
                        new System.Data.Common.DataColumnMapping("����", "����"),
                        new System.Data.Common.DataColumnMapping("����", "����"),
                        new System.Data.Common.DataColumnMapping("vip", "vip"),
                        new System.Data.Common.DataColumnMapping("�绰�ȼ�", "�绰�ȼ�"),
                        new System.Data.Common.DataColumnMapping("��Ҫ˵��", "��Ҫ˵��"),
                        new System.Data.Common.DataColumnMapping("Ӧ���ʿ�", "Ӧ���ʿ�"),
                        new System.Data.Common.DataColumnMapping("�Ƿ����", "�Ƿ����"),
                        new System.Data.Common.DataColumnMapping("���ʽ��", "���ʽ��"),
                        new System.Data.Common.DataColumnMapping("��������", "��������"),
                        new System.Data.Common.DataColumnMapping("���ʽ", "���ʽ")})});
            this.da1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.��ס����", true));
            this.txt4.Location = new System.Drawing.Point(24, 34);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(112, 21);
            this.txt4.TabIndex = 52;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.Locale = new System.Globalization.CultureInfo("zh-CN");
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "��ס����";
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.��ϵ�绰", true));
            this.txt5.Location = new System.Drawing.Point(568, 34);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(136, 21);
            this.txt5.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(568, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "��ϵ�绰";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(152, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "�ͷ�����";
            // 
            // txt7
            // 
            this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.�ͷ��۸�", true));
            this.txt7.Location = new System.Drawing.Point(128, 80);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(72, 21);
            this.txt7.TabIndex = 63;
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.�ͷ����", true));
            this.txt6.Location = new System.Drawing.Point(24, 82);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(64, 21);
            this.txt6.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "�ͷ����";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(120, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "�ͷ��۸�";
            // 
            // cmb2
            // 
            this.cmb2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.�ֵ�ʱ��", true));
            this.cmb2.Enabled = false;
            this.cmb2.Location = new System.Drawing.Point(280, 34);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(128, 20);
            this.cmb2.TabIndex = 70;
            this.cmb2.DropDown += new System.EventHandler(this.cmb2_DropDown);
            this.cmb2.Leave += new System.EventHandler(this.cmb2_Leave);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(280, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "�ֵ�ʱ��";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(424, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "���ʱ��";
            // 
            // cmb3
            // 
            this.cmb3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.���ʱ��", true));
            this.cmb3.Enabled = false;
            this.cmb3.Location = new System.Drawing.Point(424, 34);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(128, 20);
            this.cmb3.TabIndex = 69;
            this.cmb3.DropDown += new System.EventHandler(this.cmb3_DropDown);
            this.cmb3.Leave += new System.EventHandler(this.cmb3_Leave);
            // 
            // txt8
            // 
            this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.��ס�۸�", true));
            this.txt8.Location = new System.Drawing.Point(216, 80);
            this.txt8.Name = "txt8";
            this.txt8.ReadOnly = true;
            this.txt8.Size = new System.Drawing.Size(72, 21);
            this.txt8.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(216, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "��ס�۸�";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(304, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "�ۿ�";
            // 
            // txt9
            // 
            this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.�ۿ�", true));
            this.txt9.Location = new System.Drawing.Point(304, 82);
            this.txt9.Name = "txt9";
            this.txt9.ReadOnly = true;
            this.txt9.Size = new System.Drawing.Size(64, 21);
            this.txt9.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(392, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "�ۿ�ԭ��";
            // 
            // txt10
            // 
            this.txt10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.�ۿ�ԭ��", true));
            this.txt10.Location = new System.Drawing.Point(392, 82);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(128, 21);
            this.txt10.TabIndex = 64;
            // 
            // txt11
            // 
            this.txt11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.��ס����", true));
            this.txt11.Location = new System.Drawing.Point(544, 82);
            this.txt11.Name = "txt11";
            this.txt11.ReadOnly = true;
            this.txt11.Size = new System.Drawing.Size(56, 21);
            this.txt11.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(544, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "��ס����";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(304, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 14);
            this.label15.TabIndex = 40;
            this.label15.Text = "�绰�ȼ�";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(120, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Ԥ�տ�";
            // 
            // txt13
            // 
            this.txt13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.Ԥ�տ�", true));
            this.txt13.Location = new System.Drawing.Point(120, 130);
            this.txt13.Name = "txt13";
            this.txt13.ReadOnly = true;
            this.txt13.Size = new System.Drawing.Size(64, 21);
            this.txt13.TabIndex = 66;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(24, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "�Ӵ��۸�";
            // 
            // txt14
            // 
            this.txt14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.����״̬", true));
            this.txt14.Location = new System.Drawing.Point(208, 130);
            this.txt14.Name = "txt14";
            this.txt14.ReadOnly = true;
            this.txt14.Size = new System.Drawing.Size(72, 21);
            this.txt14.TabIndex = 65;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(208, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 47;
            this.label18.Text = "����״̬";
            // 
            // txt12
            // 
            this.txt12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.�Ӵ��۸�", true));
            this.txt12.Location = new System.Drawing.Point(24, 130);
            this.txt12.Name = "txt12";
            this.txt12.ReadOnly = true;
            this.txt12.Size = new System.Drawing.Size(72, 21);
            this.txt12.TabIndex = 60;
            // 
            // txt15
            // 
            this.txt15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.ҵ��Ա", true));
            this.txt15.Location = new System.Drawing.Point(408, 130);
            this.txt15.Name = "txt15";
            this.txt15.ReadOnly = true;
            this.txt15.Size = new System.Drawing.Size(72, 21);
            this.txt15.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(400, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "ҵ��Ա";
            // 
            // txt16
            // 
            this.txt16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.����Ա", true));
            this.txt16.Location = new System.Drawing.Point(496, 130);
            this.txt16.Name = "txt16";
            this.txt16.ReadOnly = true;
            this.txt16.Size = new System.Drawing.Size(72, 21);
            this.txt16.TabIndex = 58;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(496, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 36;
            this.label20.Text = "����Ա";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(584, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 38;
            this.label21.Text = "��Ա���";
            // 
            // txt17
            // 
            this.txt17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.��Ա���", true));
            this.txt17.Location = new System.Drawing.Point(584, 130);
            this.txt17.Name = "txt17";
            this.txt17.ReadOnly = true;
            this.txt17.Size = new System.Drawing.Size(120, 21);
            this.txt17.TabIndex = 59;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(24, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 48;
            this.label22.Text = "Ԥ����˾";
            // 
            // txt18
            // 
            this.txt18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.Ԥ����˾", true));
            this.txt18.Location = new System.Drawing.Point(24, 176);
            this.txt18.Name = "txt18";
            this.txt18.ReadOnly = true;
            this.txt18.Size = new System.Drawing.Size(144, 21);
            this.txt18.TabIndex = 56;
            // 
            // txt20
            // 
            this.txt20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.��ע", true));
            this.txt20.Location = new System.Drawing.Point(24, 218);
            this.txt20.Name = "txt20";
            this.txt20.ReadOnly = true;
            this.txt20.Size = new System.Drawing.Size(680, 21);
            this.txt20.TabIndex = 57;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(24, 202);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 16);
            this.label23.TabIndex = 49;
            this.label23.Text = "��ע";
            // 
            // cmb4
            // 
            this.cmb4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.�绰�ȼ�", true));
            this.cmb4.Enabled = false;
            this.cmb4.Items.AddRange(new object[] {
            "����ͨ",
            "�л�",
            "���ڳ�;",
            "���ʳ�;"});
            this.cmb4.Location = new System.Drawing.Point(303, 130);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(80, 20);
            this.cmb4.TabIndex = 68;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(504, 160);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 16);
            this.label24.TabIndex = 48;
            this.label24.Text = "��Ԥ��������";
            // 
            // txt19
            // 
            this.txt19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "��ס��.Ԥ������", true));
            this.txt19.Location = new System.Drawing.Point(504, 176);
            this.txt19.Name = "txt19";
            this.txt19.ReadOnly = true;
            this.txt19.Size = new System.Drawing.Size(168, 21);
            this.txt19.TabIndex = 56;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(680, 173);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(24, 24);
            this.btnImport.TabIndex = 72;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            this.btnImport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnImport_MouseUp);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 36, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 4, "�ֵ�ʱ��")});
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
            new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 36, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@Ԥ������", System.Data.SqlDbType.VarChar, 36, "Ԥ������"),
            new System.Data.SqlClient.SqlParameter("@��Ա���", System.Data.SqlDbType.Int, 4, "��Ա���"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 4, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, "�ֵ�ʱ��"),
            new System.Data.SqlClient.SqlParameter("@���ʱ��", System.Data.SqlDbType.DateTime, 4, "���ʱ��"),
            new System.Data.SqlClient.SqlParameter("@����״̬", System.Data.SqlDbType.VarChar, 20, "����״̬"),
            new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.Int, 4, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Money, 8, "�ͷ��۸�"),
            new System.Data.SqlClient.SqlParameter("@��ס�۸�", System.Data.SqlDbType.Money, 8, "��ס�۸�"),
            new System.Data.SqlClient.SqlParameter("@�ۿ�", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "�ۿ�", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 60, "�ۿ�ԭ��"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�Ӵ�"),
            new System.Data.SqlClient.SqlParameter("@�Ӵ��۸�", System.Data.SqlDbType.Money, 8, "�Ӵ��۸�"),
            new System.Data.SqlClient.SqlParameter("@Ԥ�տ�", System.Data.SqlDbType.Money, 8, "Ԥ�տ�"),
            new System.Data.SqlClient.SqlParameter("@Ԥ����", System.Data.SqlDbType.VarChar, 20, "Ԥ����"),
            new System.Data.SqlClient.SqlParameter("@Ԥ����˾", System.Data.SqlDbType.VarChar, 60, "Ԥ����˾"),
            new System.Data.SqlClient.SqlParameter("@��ϵ�绰", System.Data.SqlDbType.VarChar, 40, "��ϵ�绰"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 510, "��ע"),
            new System.Data.SqlClient.SqlParameter("@����Ա", System.Data.SqlDbType.VarChar, 10, "����Ա"),
            new System.Data.SqlClient.SqlParameter("@ҵ��Ա", System.Data.SqlDbType.VarChar, 50, "ҵ��Ա"),
            new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Bit, 1, "���"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"),
            new System.Data.SqlClient.SqlParameter("@vip", System.Data.SqlDbType.Bit, 1, "vip"),
            new System.Data.SqlClient.SqlParameter("@�绰�ȼ�", System.Data.SqlDbType.VarChar, 20, "�绰�ȼ�"),
            new System.Data.SqlClient.SqlParameter("@��Ҫ˵��", System.Data.SqlDbType.VarChar, 50, "��Ҫ˵��"),
            new System.Data.SqlClient.SqlParameter("@Ӧ���ʿ�", System.Data.SqlDbType.Money, 8, "Ӧ���ʿ�"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ����", System.Data.SqlDbType.Bit, 1, "�Ƿ����"),
            new System.Data.SqlClient.SqlParameter("@���ʽ��", System.Data.SqlDbType.Money, 8, "���ʽ��"),
            new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 4, "��������"),
            new System.Data.SqlClient.SqlParameter("@���ʽ", System.Data.SqlDbType.VarChar, 20, "���ʽ")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 36, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@Ԥ������", System.Data.SqlDbType.VarChar, 36, "Ԥ������"),
            new System.Data.SqlClient.SqlParameter("@��Ա���", System.Data.SqlDbType.Int, 4, "��Ա���"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 4, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, "�ֵ�ʱ��"),
            new System.Data.SqlClient.SqlParameter("@���ʱ��", System.Data.SqlDbType.DateTime, 4, "���ʱ��"),
            new System.Data.SqlClient.SqlParameter("@����״̬", System.Data.SqlDbType.VarChar, 20, "����״̬"),
            new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.Int, 4, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Money, 8, "�ͷ��۸�"),
            new System.Data.SqlClient.SqlParameter("@��ס�۸�", System.Data.SqlDbType.Money, 8, "��ס�۸�"),
            new System.Data.SqlClient.SqlParameter("@�ۿ�", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "�ۿ�", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 60, "�ۿ�ԭ��"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�Ӵ�"),
            new System.Data.SqlClient.SqlParameter("@�Ӵ��۸�", System.Data.SqlDbType.Money, 8, "�Ӵ��۸�"),
            new System.Data.SqlClient.SqlParameter("@Ԥ�տ�", System.Data.SqlDbType.Money, 8, "Ԥ�տ�"),
            new System.Data.SqlClient.SqlParameter("@Ԥ����", System.Data.SqlDbType.VarChar, 20, "Ԥ����"),
            new System.Data.SqlClient.SqlParameter("@Ԥ����˾", System.Data.SqlDbType.VarChar, 60, "Ԥ����˾"),
            new System.Data.SqlClient.SqlParameter("@��ϵ�绰", System.Data.SqlDbType.VarChar, 40, "��ϵ�绰"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 510, "��ע"),
            new System.Data.SqlClient.SqlParameter("@����Ա", System.Data.SqlDbType.VarChar, 10, "����Ա"),
            new System.Data.SqlClient.SqlParameter("@ҵ��Ա", System.Data.SqlDbType.VarChar, 50, "ҵ��Ա"),
            new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Bit, 1, "���"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"),
            new System.Data.SqlClient.SqlParameter("@vip", System.Data.SqlDbType.Bit, 1, "vip"),
            new System.Data.SqlClient.SqlParameter("@�绰�ȼ�", System.Data.SqlDbType.VarChar, 20, "�绰�ȼ�"),
            new System.Data.SqlClient.SqlParameter("@��Ҫ˵��", System.Data.SqlDbType.VarChar, 50, "��Ҫ˵��"),
            new System.Data.SqlClient.SqlParameter("@Ӧ���ʿ�", System.Data.SqlDbType.Money, 8, "Ӧ���ʿ�"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ����", System.Data.SqlDbType.Bit, 1, "�Ƿ����"),
            new System.Data.SqlClient.SqlParameter("@���ʽ��", System.Data.SqlDbType.Money, 8, "���ʽ��"),
            new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 4, "��������"),
            new System.Data.SqlClient.SqlParameter("@���ʽ", System.Data.SqlDbType.VarChar, 20, "���ʽ"),
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_vip", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "vip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʽ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʽ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 510, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ӧ���ʿ�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ӧ���ʿ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "�ۿ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��Ҫ˵��", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��Ҫ˵��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�绰�ȼ�", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�绰�ȼ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʽ��", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʽ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_vip", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "vip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʽ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʽ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 510, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ӧ���ʿ�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ӧ���ʿ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "�ۿ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��Ҫ˵��", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��Ҫ˵��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�绰�ȼ�", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�绰�ȼ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʽ��", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʽ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null)});
            // 
            // da2
            // 
            this.da2.SelectCommand = this.sqlSelectCommand2;
            this.da2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "�ͷ�����", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("���ͱ��", "���ͱ��"),
                        new System.Data.Common.DataColumnMapping("��������", "��������")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT ���ͱ��, �������� FROM �ͷ�����";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // cmb1
            // 
            this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet21, "��ס��.�ͷ�����", true));
            this.cmb1.DataSource = this.dataSet21;
            this.cmb1.DisplayMember = "�ͷ�����.��������";
            this.cmb1.Enabled = false;
            this.cmb1.Location = new System.Drawing.Point(152, 35);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(112, 20);
            this.cmb1.TabIndex = 119;
            this.cmb1.ValueMember = "�ͷ�����.���ͱ��";
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet21, "��ס��.�Ƿ�Ӵ�", true));
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(624, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 24);
            this.checkBox1.TabIndex = 123;
            this.checkBox1.Text = "�Ƿ�Ӵ�";
            // 
            // checkBox2
            // 
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet21, "��ס��.���", true));
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(176, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 24);
            this.checkBox2.TabIndex = 128;
            this.checkBox2.Text = "�ṩ���";
            // 
            // checkBox3
            // 
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet21, "��ס��.����", true));
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(256, 176);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 24);
            this.checkBox3.TabIndex = 127;
            this.checkBox3.Text = "��ʱ����";
            // 
            // checkBox4
            // 
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet21, "��ס��.����", true));
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(336, 176);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 24);
            this.checkBox4.TabIndex = 125;
            this.checkBox4.Text = "��ס����";
            // 
            // checkBox5
            // 
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet21, "��ס��.vip", true));
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(416, 176);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 24);
            this.checkBox5.TabIndex = 126;
            this.checkBox5.Text = "VIP���";
            // 
            // calen1
            // 
            this.calen1.Location = new System.Drawing.Point(232, 128);
            this.calen1.Name = "calen1";
            this.calen1.TabIndex = 130;
            this.calen1.Visible = false;
            this.calen1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calen1_DateSelected);
            // 
            // btnRoom
            // 
            this.btnRoom.Enabled = false;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.Location = new System.Drawing.Point(96, 80);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(24, 24);
            this.btnRoom.TabIndex = 129;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            this.btnRoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRoom_MouseUp);
            // 
            // HotelArrival
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 525);
            this.Controls.Add(this.calen1);
            this.Name = "HotelArrival";
            this.Text = "����ס����";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotelArrival_FormClosing);
            this.Load += new System.EventHandler(this.HotelArrival_Load);
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

		//----------����������Ϣ��������-----------
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
			dataSet21.Clear();//ˢ�����ݼ�
			da1.Fill(dataSet21);
			//���������ź���������
			da2.Fill(dataSet21);
		}

		//-----------��������ʱ��������-------------
		private void HotelArrival_Load(object sender, System.EventArgs e)
		{
			//������ݼ�
			da2.Fill(dataSet21);

			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[1].Value="%";
			da1.SelectCommand.Parameters[2].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[2].Value="%";
			da1.Fill(dataSet21);//���ͷ�Ԥ����Ϣ
			base.dataSet11=this.dataSet21;
			this.cmOrders=(CurrencyManager) BindingContext[dataSet21,"��ס��"];
		}

		//----------��д���ÿؼ�ֻ�����Ժ���----------
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
			txt20.ReadOnly=!blnEdit;
			
			
			cmb2.Enabled=blnEdit;
			cmb3.Enabled=blnEdit;
			cmb4.Enabled=blnEdit;

			checkBox1.Enabled=blnEdit;
			checkBox2.Enabled=blnEdit;
			checkBox3.Enabled=blnEdit;
			checkBox4.Enabled=blnEdit;
			checkBox5.Enabled=blnEdit;

			btnImport.Enabled=blnEdit;
			btnRoom.Enabled=blnEdit;
		}

		//-------��д������¼ʱ����Ĭ��ֵ����--------
		protected override void SetDefaultValue()
		{
			//base.SetDefaultValue();
			
			txt14.Text="��ס";//��������״̬ΪԤ��
			//�Զ������±��
			string connStr="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
			SqlConnection cn=new SqlConnection(connStr);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			if(dataSet21.��ס��.Rows.Count==0)
				cmd.CommandText="select max(��ס����) ����� from ��ס����ʷ";
			else
                cmd.CommandText="select max(��ס����) ����� from ��ס��";
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
					newID="RZ0000000"+order.ToString();
					break;
				case 2:
					newID="RZ000000"+order.ToString();
					break;
				case 3:
					newID="RZ00000"+order.ToString();
					break;
				case 4:
					newID="RZ0000"+order.ToString();
					break;
				case 5:
					newID="RZ000"+order.ToString();
					break;
				case 6:
					newID="RZ00"+order.ToString();
					break;
				case 7:
					newID="RZ0"+order.ToString();
					break;
			}
			txt4.Text=newID;//�Զ����ɱ��
			cmb2.Text=System.DateTime.Now.Date.ToString();//�ֵ�ʱ�䵱��
			cmb3.Text=System.DateTime.Now.Date.AddDays(3).ToString();//���ʱ��Ϊ3���
			cmb1.Text="��׼��";
		}

		//-------��д���ǿ��ֶκ���--------
		protected override bool CheckNotNull()
		{
						
			if(txt4.Text.Trim()=="")// ��鷿����
			{
				MessageBox.Show("����Ų���Ϊ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(txt6.Text.Trim()=="")//���ͷ����
			{
				MessageBox.Show("��ѡ��ͷ����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb2.Text.Trim()=="")//���¥��
			{
				MessageBox.Show("��ֵ�ʱ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}			
			return base.CheckNotNull ();
		}

		//------------��Ԥ������˫��ѡ��Ԥ����Ϣ-------------
		private void btnImport_Click(object sender, System.EventArgs e)
		{
			string sql="select * from Ԥ����";
			SelectTable newfrm=new SelectTable(sql,1);
			newfrm.Text="˫��ѡ��Ԥ������";
			newfrm.ShowDialog();
		}

		//----------��ʾԤ����Ϣ-------------
		private void btnImport_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            
			if(dRow["Ԥ������"].ToString().Trim()=="")
				return;
			txt19.Text=dRow["Ԥ������"].ToString().Trim();
			cmb2.Text=dRow["�ֵ�ʱ��"].ToString().Trim();
			cmb3.Text=dRow["���ʱ��"].ToString().Trim();
			txt5.Text=dRow["��ϵ�绰"].ToString().Trim();
			txt6.Text=dRow["�ͷ����"].ToString().Trim();
			txt7.Text=dRow["�ͷ��۸�"].ToString().Trim();
			txt8.Text=dRow["��ס�۸�"].ToString().Trim();
			txt9.Text=dRow["�ۿ�"].ToString().Trim();
			txt10.Text=dRow["�ۿ�ԭ��"].ToString().Trim();
			txt11.Text=dRow["��ס����"].ToString().Trim();
			txt12.Text=dRow["�Ӵ��۸�"].ToString().Trim();
			txt13.Text=dRow["Ԥ�տ�"].ToString().Trim();
			checkBox1.Checked=Convert.ToBoolean(dRow["�Ƿ�Ӵ�"]);
			txt15.Text=dRow["ҵ��Ա"].ToString().Trim();
			txt16.Text=dRow["����Ա"].ToString().Trim();
			txt17.Text=dRow["��Ա���"].ToString().Trim();
			txt18.Text=dRow["Ԥ����˾"].ToString().Trim();

						
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			string sql="SELECT b.�������� FROM �ͷ����� b,Ԥ���� a where (a.�ͷ�����=b.���ͱ��)and(a.Ԥ������='"+txt19.Text+"')";
			cmd.CommandText=sql;
			
			cmb1.Text=cmd.ExecuteScalar().ToString().Trim();//����Ԥ���ͷ�����

			txt6.ReadOnly=true;//Ԥ�����䲻���޸�
			cmb1.Enabled=false;			
		}

		//-----��ʾ��ѡ��ֵ����ں��������-----
		private void cmb2_DropDown(object sender, System.EventArgs e)
		{
			selectDate(cmb2);
		
		}
		private void cmb3_DropDown(object sender, System.EventArgs e)
		{
			selectDate(cmb3);
		}		

		//----------�ر����ڿؼ�����ʾ----------
		private void cmb2_Leave(object sender, System.EventArgs e)
		{
			calen1.Visible=false;		
		}
		private void cmb3_Leave(object sender, System.EventArgs e)
		{
			calen1.Visible=false;
		}		

		//-----------���������б��������ͷʱ��ʾ�����Թ�ѡ��---------------
		private void selectDate(ComboBox cb)
		{
			calen1.Left=cb.Left;//�������ڿؼ���λ��
			calen1.Top=cb.Top-calen1.Height-10+groupBox2.Top;
			if(cb.Text.Trim()!="")
			{	
				calen1.SelectionStart=Convert.ToDateTime(cb.Text);//������ʾ��ʱ��Ϊ����ʱ��
				calen1.SelectionEnd=Convert.ToDateTime(cb.Text);
			}
			calen1.Visible=true;//��ʾ����
			calen1.Show();
		}

		//-----------�������ؼ���ѡ��������Ϣ------------
		private void calen1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			//�ж������ĸ������б������������Ա����������Ϣ
			if(calen1.Left==cmb2.Left)
				cmb2.Text=calen1.SelectionEnd.ToString();
			if(calen1.Left==cmb3.Left)
				cmb3.Text=calen1.SelectionEnd.ToString();			
		}

		//---------���·�̬����Ԥ����Ϣ������ʷ---------
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//�ڱ������ݺ��ٽ��д���
			if(e.Button.ToolTipText=="�ύ")
			{
				string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
                //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
				SqlConnection cn=new SqlConnection(strConn);
				cn.Open();
				SqlCommand cmd=cn.CreateCommand();
				//�Ȱ�����״̬Ϊ�Ѿ���ס�ķ����Ϊ�շ�
				cmd.CommandText="update �ͷ���Ϣ set ״̬='�շ�' where ״̬='ס��'";
				cmd.ExecuteNonQuery();
				//Ȼ�������ס���е���Ϣ�����ô�����̣�������ס��������Ѿ���ס��Ԥ����
				foreach(DataRow aRow in dataSet21.��ס��.Rows)
				{					
					try
					{
						cmd.CommandText="exec sf_������ס�� '"+aRow["��ס����"].ToString()+"'";
						cmd.ExecuteNonQuery();
					}
					catch(Exception express)
					{
						MessageBox.Show(express.ToString());
					}
				}
			}
	
		}

		//----------��ʾ��̬ͼ��ѡ�񷿼�---------
		private void btnRoom_Click(object sender, System.EventArgs e)
		{
			RoomStatus newfrm=new RoomStatus(2,mainForm);
			newfrm.ShowDialog();		
		}

		//---------------���뷿̬ͼ�з��ص���Ϣ----------------
		private void btnRoom_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txt6.Text=roomInfo[0];//��ʾ������
			cmb1.Text=roomInfo[1];//��ʾ��������
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
           // string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="SELECT �۸� FROM �ͷ����� where ��������='"+cmb1.Text+"'";
			txt7.Text=cmd.ExecuteScalar().ToString().Trim();//��������Ϳͷ��۸�
			txt8.Text=txt7.Text;//��ס�۸�Ĭ�ϺͿͷ��۸�һ��
		}

        private void HotelArrival_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }		
	}
}

