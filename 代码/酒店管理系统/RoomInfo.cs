using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace �Ƶ����ϵͳ
{
	public class RoomInfo : ҽԺ����ϵͳ.ParentForm
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
		private �Ƶ����ϵͳ.DataSet1 dataSet11;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            this.txt4 = new System.Windows.Forms.TextBox();
            this.dataSet11 = new �Ƶ����ϵͳ.DataSet1();
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
            this.label1.Text = "���ͱ��";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "�ͷ����";
            // 
            // label3
            // 
            this.label3.Text = "¥����";
            // 
            // toolBar1
            // 
            this.toolBar1.Size = new System.Drawing.Size(736, 41);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "�ͷ���Ϣ";
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
            new System.Data.Common.DataTableMapping("Table", "�ͷ���Ϣ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("�ͷ����", "�ͷ����"),
                        new System.Data.Common.DataColumnMapping("���ͱ��", "���ͱ��"),
                        new System.Data.Common.DataColumnMapping("¥����", "¥����"),
                        new System.Data.Common.DataColumnMapping("�����", "�����"),
                        new System.Data.Common.DataColumnMapping("����", "����"),
                        new System.Data.Common.DataColumnMapping("�ͷ�����", "�ͷ�����"),
                        new System.Data.Common.DataColumnMapping("��ע", "��ע"),
                        new System.Data.Common.DataColumnMapping("״̬", "״̬"),
                        new System.Data.Common.DataColumnMapping("�Ƿ�ɼӴ�", "�Ƿ�ɼӴ�")})});
            this.da1.UpdateCommand = this.sqlCommand7;
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ���Ϣ.�ͷ����", true));
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
            this.label4.Text = "�ͷ����";
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ���Ϣ.�����", true));
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
            this.label5.Text = "�ͷ�����";
            // 
            // txt8
            // 
            this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ���Ϣ.�ͷ�����", true));
            this.txt8.Location = new System.Drawing.Point(40, 86);
            this.txt8.Name = "txt8";
            this.txt8.ReadOnly = true;
            this.txt8.Size = new System.Drawing.Size(232, 21);
            this.txt8.TabIndex = 17;
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ���Ϣ.����", true));
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
            this.label9.Text = "�����";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(40, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "�ͷ�����";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(312, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "¥��";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(528, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "����";
            // 
            // cmb2
            // 
            this.cmb2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet11, "�ͷ���Ϣ.���ͱ��", true));
            this.cmb2.DataSource = this.dataSet11;
            this.cmb2.DisplayMember = "�ͷ�����.��������";
            this.cmb2.Enabled = false;
            this.cmb2.Location = new System.Drawing.Point(176, 40);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(120, 20);
            this.cmb2.TabIndex = 19;
            this.cmb2.ValueMember = "�ͷ���Ϣ.���ͱ��";
            // 
            // cmb3
            // 
            this.cmb3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet11, "�ͷ���Ϣ.¥����", true));
            this.cmb3.DataSource = this.dataSet11;
            this.cmb3.DisplayMember = "¥����Ϣ.¥������";
            this.cmb3.Enabled = false;
            this.cmb3.Location = new System.Drawing.Point(312, 40);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(104, 20);
            this.cmb3.TabIndex = 18;
            this.cmb3.ValueMember = "¥����Ϣ.¥����";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(616, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "״̬";
            // 
            // txt7
            // 
            this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ���Ϣ.״̬", true));
            this.txt7.Location = new System.Drawing.Point(616, 40);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(88, 21);
            this.txt7.TabIndex = 14;
            // 
            // txt9
            // 
            this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "�ͷ���Ϣ.��ע", true));
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
            this.label11.Text = "��ע";
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSet11, "�ͷ���Ϣ.�Ƿ�ɼӴ�", true));
            this.checkBox1.Location = new System.Drawing.Point(568, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "�Ƿ�ɼӴ�";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT �ͷ����, ���ͱ��, ¥����, �����, ����, �ͷ�����, ��ע, ״̬, �Ƿ�ɼӴ� FROM �ͷ���Ϣ WHERE (�ͷ���� LIKE" +
    " @Param4) AND (���ͱ�� LIKE @Param5) AND (¥���� LIKE @Param6)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.Int, 4, "¥����")});
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
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@¥����", System.Data.SqlDbType.Int, 4, "¥����"),
            new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 100, "��ע"),
            new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 4, "״̬"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�ɼӴ�")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@¥����", System.Data.SqlDbType.Int, 4, "¥����"),
            new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 100, "��ע"),
            new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 4, "״̬"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�ɼӴ�"),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�ɼӴ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_¥����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "¥����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�����", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�ɼӴ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_¥����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "¥����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�����", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT �ͷ����, ���ͱ��, ¥����, �����, ����, �ͷ�����, ��ע, ״̬, �Ƿ�ɼӴ� FROM �ͷ���Ϣ WHERE (�ͷ���� LIKE" +
    " @Param4) AND (���ͱ�� LIKE @Param5) AND (¥���� LIKE @Param6)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.Int, 4, "¥����")});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConnection1;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@¥����", System.Data.SqlDbType.Int, 4, "¥����"),
            new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 100, "��ע"),
            new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 4, "״̬"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�ɼӴ�")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConnection1;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@¥����", System.Data.SqlDbType.Int, 4, "¥����"),
            new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 100, "��ע"),
            new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 4, "״̬"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�ɼӴ�"),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�ɼӴ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_¥����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "¥����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�����", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�ɼӴ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_¥����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "¥����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�����", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT �ͷ����, ���ͱ��, ¥����, �����, ����, �ͷ�����, ��ע, ״̬, �Ƿ�ɼӴ� FROM �ͷ���Ϣ WHERE (�ͷ���� LIKE" +
    " @Param4) AND (���ͱ�� LIKE @Param5) AND (¥���� LIKE @Param6)";
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 4, "¥����")});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlConnection1;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@¥����", System.Data.SqlDbType.Int, 4, "¥����"),
            new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 100, "��ע"),
            new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 4, "״̬"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�ɼӴ�")});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            this.sqlCommand7.Connection = this.sqlConnection1;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 12, "�ͷ����"),
            new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 4, "���ͱ��"),
            new System.Data.SqlClient.SqlParameter("@¥����", System.Data.SqlDbType.Int, 4, "¥����"),
            new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"),
            new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"),
            new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 100, "��ע"),
            new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 4, "״̬"),
            new System.Data.SqlClient.SqlParameter("@�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�ɼӴ�"),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�ɼӴ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_¥����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "¥����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�����", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlConnection1;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�ɼӴ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�Ƿ�ɼӴ�", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_¥����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "¥����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "״̬", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�����", System.Data.DataRowVersion.Original, null)});
            // 
            // da2
            // 
            this.da2.SelectCommand = this.sqlSelectCommand2;
            this.da2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "¥����Ϣ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("¥����", "¥����"),
                        new System.Data.Common.DataColumnMapping("¥������", "¥������")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT ¥����, ¥������ FROM ¥����Ϣ";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // da3
            // 
            this.da3.SelectCommand = this.sqlSelectCommand3;
            this.da3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "�ͷ�����", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("���ͱ��", "���ͱ��"),
                        new System.Data.Common.DataColumnMapping("��������", "��������"),
                        new System.Data.Common.DataColumnMapping("�۸�", "�۸�"),
                        new System.Data.Common.DataColumnMapping("�Ӵ��۸�", "�Ӵ��۸�"),
                        new System.Data.Common.DataColumnMapping("�ɳ�Ԥ����", "�ɳ�Ԥ����"),
                        new System.Data.Common.DataColumnMapping("�Ƿ�ɼӴ�", "�Ƿ�ɼӴ�")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT ���ͱ��, ��������, �۸�, �Ӵ��۸�, �ɳ�Ԥ����, �Ƿ�ɼӴ� FROM �ͷ�����";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // RoomInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 509);
            this.Name = "RoomInfo";
            this.Text = "���ͷ���Ϣ���á�";
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

		//----------��ʼ������ʱ����ȫ����Ϣ--------------
		private void RoomInfo_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].Value="%";
			da1.SelectCommand.Parameters[2].SqlDbType=SqlDbType.VarChar;
			da1.SelectCommand.Parameters[2].Value="%";
			da1.Fill(dataSet11);//���ͷ���Ϣ
			//�������ݵ����ؼ�
			this.cmOrders=(CurrencyManager) BindingContext[dataSet11,"�ͷ���Ϣ"];	
			//�������е����ݼ����������е����ݼ�����
			base.dataSet11=this.dataSet11;
			//���������ź���������
			da2.Fill(dataSet11);
			da3.Fill(dataSet11);
			
		}

		//-----------�������룬������Ϣ----------
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
			dataSet11.Clear();//ˢ�����ݼ�
			da1.Fill(dataSet11);
			//���������ź���������
			da2.Fill(dataSet11);
			da3.Fill(dataSet11);
			
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
			
			cmb2.Enabled=blnEdit;
			cmb3.Enabled=blnEdit;

			checkBox1.Enabled=blnEdit;
         }

		//-------��д������¼ʱ����Ĭ��ֵ����--------
		protected override void SetDefaultValue()
		{
			base.SetDefaultValue ();
			cmb2.SelectedText="";
			cmb3.SelectedText="";
			txt7.Text="�շ�";//��������Ĭ�϶�Ϊ�շ�
		}

		//-------��д���ǿ��ֶκ���--------
		protected override bool CheckNotNull()
		{
						
			if(txt4.Text.Trim()=="")// ��鷿����
			{
				MessageBox.Show("����Ų���Ϊ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb2.Text.Trim()=="")//���ͷ�����
			{
				MessageBox.Show("��ѡ��ͷ�����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb3.Text.Trim()=="")//���¥��
			{
				MessageBox.Show("��ѡ��¥��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
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

