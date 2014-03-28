using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace �Ƶ����ϵͳ
{
	public class HotelReserve : ҽԺ����ϵͳ.ParentForm
	{
		public static string[] roomInfo;//����ӷ�̬ͼ�з��ص���Ϣ
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private �Ƶ����ϵͳ.DataSet2 dataSet21;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelReserve));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet21 = new �Ƶ����ϵͳ.DataSet2();
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
            this.label1.Text = "�ֵ�ʱ��";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "Ԥ������";
            // 
            // label3
            // 
            this.label3.Text = "Ԥ����";
            // 
            // toolBar1
            // 
            this.toolBar1.Size = new System.Drawing.Size(728, 41);
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "Ԥ����";
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
            new System.Data.Common.DataTableMapping("Table", "Ԥ����", new System.Data.Common.DataColumnMapping[] {
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
                        new System.Data.Common.DataColumnMapping("ҵ��Ա", "ҵ��Ա")})});
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
            new System.Data.Common.DataTableMapping("Table", "�ͷ�����", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("���ͱ��", "���ͱ��"),
                        new System.Data.Common.DataColumnMapping("��������", "��������")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT ���ͱ��, �������� FROM �ͷ�����";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.Ԥ������", true));
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
            this.label4.Text = "Ԥ������";
            // 
            // cmb1
            // 
            this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet21, "Ԥ����.�ͷ�����", true));
            this.cmb1.DataSource = this.dataSet21;
            this.cmb1.DisplayMember = "�ͷ�����.��������";
            this.cmb1.Enabled = false;
            this.cmb1.Location = new System.Drawing.Point(152, 32);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(112, 20);
            this.cmb1.TabIndex = 118;
            this.cmb1.ValueMember = "�ͷ�����.���ͱ��";
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.��ϵ�绰", true));
            this.txt5.Location = new System.Drawing.Point(568, 32);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(136, 21);
            this.txt5.TabIndex = 117;
            // 
            // cmb2
            // 
            this.cmb2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.�ֵ�ʱ��", true));
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
            this.cmb3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.���ʱ��", true));
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
            this.label5.Text = "��ϵ�绰";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(152, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 114;
            this.label6.Text = "�ͷ�����";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(280, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "�ֵ�ʱ��";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(424, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 116;
            this.label10.Text = "���ʱ��";
            // 
            // txt7
            // 
            this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.�ͷ��۸�", true));
            this.txt7.Location = new System.Drawing.Point(128, 78);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(72, 21);
            this.txt7.TabIndex = 129;
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.�ͷ����", true));
            this.txt6.Location = new System.Drawing.Point(24, 78);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(64, 21);
            this.txt6.TabIndex = 127;
            // 
            // txt8
            // 
            this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.��ס�۸�", true));
            this.txt8.Location = new System.Drawing.Point(216, 78);
            this.txt8.Name = "txt8";
            this.txt8.ReadOnly = true;
            this.txt8.Size = new System.Drawing.Size(72, 21);
            this.txt8.TabIndex = 128;
            // 
            // txt9
            // 
            this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.�ۿ�", true));
            this.txt9.Location = new System.Drawing.Point(304, 78);
            this.txt9.Name = "txt9";
            this.txt9.ReadOnly = true;
            this.txt9.Size = new System.Drawing.Size(64, 21);
            this.txt9.TabIndex = 130;
            // 
            // txt10
            // 
            this.txt10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.�ۿ�ԭ��", true));
            this.txt10.Location = new System.Drawing.Point(392, 78);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(128, 21);
            this.txt10.TabIndex = 132;
            // 
            // txt11
            // 
            this.txt11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.��ס����", true));
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
            this.label9.Text = "�ͷ����";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(128, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "�ͷ��۸�";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(208, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 125;
            this.label11.Text = "��ס�۸�";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(304, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 124;
            this.label12.Text = "�ۿ�";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(392, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 122;
            this.label13.Text = "�ۿ�ԭ��";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(544, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 126;
            this.label14.Text = "��ס����";
            // 
            // txt13
            // 
            this.txt13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.Ԥ�տ�", true));
            this.txt13.Location = new System.Drawing.Point(120, 120);
            this.txt13.Name = "txt13";
            this.txt13.ReadOnly = true;
            this.txt13.Size = new System.Drawing.Size(64, 21);
            this.txt13.TabIndex = 164;
            // 
            // txt14
            // 
            this.txt14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.����״̬", true));
            this.txt14.Location = new System.Drawing.Point(208, 120);
            this.txt14.Name = "txt14";
            this.txt14.ReadOnly = true;
            this.txt14.Size = new System.Drawing.Size(72, 21);
            this.txt14.TabIndex = 165;
            // 
            // txt12
            // 
            this.txt12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.�Ӵ��۸�", true));
            this.txt12.Location = new System.Drawing.Point(24, 120);
            this.txt12.Name = "txt12";
            this.txt12.ReadOnly = true;
            this.txt12.Size = new System.Drawing.Size(72, 21);
            this.txt12.TabIndex = 162;
            // 
            // txt15
            // 
            this.txt15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.Ԥ����", true));
            this.txt15.Location = new System.Drawing.Point(304, 120);
            this.txt15.Name = "txt15";
            this.txt15.ReadOnly = true;
            this.txt15.Size = new System.Drawing.Size(72, 21);
            this.txt15.TabIndex = 163;
            // 
            // txt16
            // 
            this.txt16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.ҵ��Ա", true));
            this.txt16.Location = new System.Drawing.Point(400, 120);
            this.txt16.Name = "txt16";
            this.txt16.ReadOnly = true;
            this.txt16.Size = new System.Drawing.Size(72, 21);
            this.txt16.TabIndex = 166;
            // 
            // txt17
            // 
            this.txt17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.����Ա", true));
            this.txt17.Location = new System.Drawing.Point(496, 120);
            this.txt17.Name = "txt17";
            this.txt17.ReadOnly = true;
            this.txt17.Size = new System.Drawing.Size(72, 21);
            this.txt17.TabIndex = 168;
            // 
            // txt18
            // 
            this.txt18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "Ԥ����.��Ա���", true));
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
            this.label15.Text = "Ԥ����";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(120, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 154;
            this.label16.Text = "Ԥ�տ�";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(24, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 151;
            this.label17.Text = "�Ӵ��۸�";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(208, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 152;
            this.label18.Text = "����״̬";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(400, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 155;
            this.label19.Text = "ҵ��Ա";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(496, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 158;
            this.label20.Text = "����Ա";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(584, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 159;
            this.label21.Text = "��Ա���";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(24, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 157;
            this.label22.Text = "Ԥ����˾";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(200, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 156;
            this.label23.Text = "��ע";
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet21, "Ԥ����.�Ƿ�Ӵ�", true));
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(616, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 24);
            this.checkBox1.TabIndex = 169;
            this.checkBox1.Text = "�Ƿ�Ӵ�";
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
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 36, "Ԥ������"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 10, "�ֵ�ʱ��"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 20, "Ԥ����")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            new System.Data.SqlClient.SqlParameter("@ҵ��Ա", System.Data.SqlDbType.VarChar, 50, "ҵ��Ա")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 510, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "�ۿ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 510, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(2)), "�ۿ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 60, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null)});
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
            this.Text = "���ͷ�Ԥ����";
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

		//----------��������ʱ���������ݲ�������ݿؼ�����---------
		private void HotelReserve_Load(object sender, System.EventArgs e)
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
			this.cmOrders=(CurrencyManager) BindingContext[dataSet21,"Ԥ����"];
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
			txt19.ReadOnly=!blnEdit;
			txt20.ReadOnly=!blnEdit;
			
			cmb2.Enabled=blnEdit;
			cmb3.Enabled=blnEdit;

			checkBox1.Enabled=blnEdit;

			btnRoom.Enabled=blnEdit;
		}

		//-------��д������¼ʱ����Ĭ��ֵ����--------
		protected override void SetDefaultValue()
		{
			//base.SetDefaultValue();
			
			txt14.Text="Ԥ��";//��������״̬ΪԤ��
			//�Զ������±��
			string connStr="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
			SqlConnection cn=new SqlConnection(connStr);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			if(dataSet21.Ԥ����.Rows.Count==0)
				cmd.CommandText="select max(Ԥ������) ����� from Ԥ������ʷ";
			else
                cmd.CommandText="select max(Ԥ������) ����� from Ԥ����";
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
			txt4.Text=newID;//�Զ����ɱ��
			cmb2.Text=System.DateTime.Now.Date.ToString();//�ֵ�ʱ��Ĭ��Ϊ����
			cmb3.Text=System.DateTime.Now.Date.AddDays(3).ToString();//���ʱ��Ϊ3���
			
		}

		//-------��д���ǿ��ֶκ���--------
		protected override bool CheckNotNull()
		{
						
			if(txt4.Text.Trim()=="")// ���Ԥ�����
			{
				MessageBox.Show("Ԥ����Ų���Ϊ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(txt6.Text.Trim()=="")//���ͷ����
			{
				MessageBox.Show("��ѡ��ͷ����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb2.Text.Trim()=="")//���ֵ�ʱ��
			{
				MessageBox.Show("��ѡ��ֵ�ʱ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}			
			return base.CheckNotNull ();
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

		//--------����������������������----------
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

		//----------��ʾ��̬ͼ��ѡ�񷿼�---------
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
			txt6.Text=roomInfo[0];//��ʾ������
			cmb1.Text=roomInfo[1];//��ʾ��������
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="SELECT �۸� FROM �ͷ����� where ��������='"+cmb1.Text+"'";
			txt7.Text=cmd.ExecuteScalar().ToString().Trim();//��������Ϳͷ��۸�
			txt8.Text=txt7.Text;//��ס�۸�Ĭ�ϺͿͷ��۸�һ��
		}

		//---------����Ԥ��������·�̬-----------
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//�ڱ������ݺ��ٽ��д���
			if(e.Button.ToolTipText=="�ύ")
			{
				//����Ԥ������״̬
				string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
                //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
				SqlConnection cn=new SqlConnection(strConn);
				cn.Open();
				SqlCommand cmd=cn.CreateCommand();
				cmd.CommandText="update �ͷ���Ϣ set ״̬='����' where �ͷ����='"+txt6.Text+"'";
				cmd.ExecuteNonQuery();
			}
		}

        private void HotelReserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }


	}
}

