using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace �Ƶ����ϵͳ
{
	public class ClientConsume : ҽԺ����ϵͳ.ParentForm
	{
		public static string RZid;//��ס�����
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private �Ƶ����ϵͳ.DataSet2 dataSet21;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.ComboBox cmb2;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.MonthCalendar calen1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;//�������ס����ѡ��õ��Ŀ�����ס����
		private System.ComponentModel.IContainer components = null;
        private MainForm mainForm;
		public ClientConsume(MainForm mf)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientConsume));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet21 = new �Ƶ����ϵͳ.DataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.calen1 = new System.Windows.Forms.MonthCalendar();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "��������";
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Text = "��ס����";
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
            this.dataGrid1.DataMember = "�ʵ���ϸ";
            this.dataGrid1.DataSource = this.dataSet21;
            this.dataGrid1.Size = new System.Drawing.Size(728, 240);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmb2);
            this.groupBox2.Location = new System.Drawing.Point(0, 336);
            this.groupBox2.Size = new System.Drawing.Size(728, 160);
            // 
            // da1
            // 
            this.da1.DeleteCommand = this.sqlDeleteCommand1;
            this.da1.InsertCommand = this.sqlInsertCommand1;
            this.da1.SelectCommand = this.sqlSelectCommand1;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "�ʵ���ϸ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("�ʵ����", "�ʵ����"),
                        new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
                        new System.Data.Common.DataColumnMapping("��������", "��������"),
                        new System.Data.Common.DataColumnMapping("���ѽ��", "���ѽ��"),
                        new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
                        new System.Data.Common.DataColumnMapping("��ע", "��ע")})});
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(96, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "��ס����";
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "�ʵ���ϸ.��ס����", true));
            this.txt4.Location = new System.Drawing.Point(96, 32);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(176, 21);
            this.txt4.TabIndex = 1;
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "�ʵ���ϸ.���ѽ��", true));
            this.txt5.Location = new System.Drawing.Point(96, 80);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(176, 21);
            this.txt5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(96, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "���ѽ��";
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "�ʵ���ϸ.��ע", true));
            this.txt6.Location = new System.Drawing.Point(96, 128);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(464, 21);
            this.txt6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(96, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "��ע";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(352, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "����ʱ��";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(352, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "��������";
            // 
            // cmb1
            // 
            this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "�ʵ���ϸ.����ʱ��", true));
            this.cmb1.Enabled = false;
            this.cmb1.Location = new System.Drawing.Point(352, 32);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(208, 20);
            this.cmb1.TabIndex = 2;
            this.cmb1.DropDown += new System.EventHandler(this.cmb1_DropDown);
            this.cmb1.Leave += new System.EventHandler(this.cmb1_Leave);
            // 
            // cmb2
            // 
            this.cmb2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet21, "�ʵ���ϸ.��������", true));
            this.cmb2.Enabled = false;
            this.cmb2.Items.AddRange(new object[] {
            "���շ���",
            "����ˮ���",
            "��Ƶ�㲥��",
            "���������",
            "��Ʒʹ�÷�",
            "��������"});
            this.cmb2.Location = new System.Drawing.Point(352, 80);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(208, 20);
            this.cmb2.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(280, 32);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(24, 24);
            this.btnSelect.TabIndex = 73;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSelect_MouseUp);
            // 
            // calen1
            // 
            this.calen1.Location = new System.Drawing.Point(432, 208);
            this.calen1.Name = "calen1";
            this.calen1.TabIndex = 131;
            this.calen1.Visible = false;
            this.calen1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calen1_DateSelected);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT �ʵ����, ��ס����, ��������, ���ѽ��, ����ʱ��, ��ע FROM �ʵ���ϸ WHERE (��ס���� LIKE @Param3) AND (" +
    "�������� LIKE @Param4 OR �������� IS NULL)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param3", System.Data.SqlDbType.VarChar, 36, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 40, "��������")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO �ʵ���ϸ(��ס����, ��������, ���ѽ��, ����ʱ��, ��ע) VALUES (@��ס����, @��������, @���ѽ��, @����ʱ��, " +
    "@��ע); SELECT �ʵ����, ��ס����, ��������, ���ѽ��, ����ʱ��, ��ע FROM �ʵ���ϸ WHERE (�ʵ���� = @@IDENTITY" +
    ")";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 36, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 40, "��������"),
            new System.Data.SqlClient.SqlParameter("@���ѽ��", System.Data.SqlDbType.Money, 8, "���ѽ��"),
            new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 4, "����ʱ��"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 80, "��ע")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 36, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 40, "��������"),
            new System.Data.SqlClient.SqlParameter("@���ѽ��", System.Data.SqlDbType.Money, 8, "���ѽ��"),
            new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.DateTime, 4, "����ʱ��"),
            new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 80, "��ע"),
            new System.Data.SqlClient.SqlParameter("@Original_�ʵ����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ʵ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ѽ��", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ѽ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@�ʵ����", System.Data.SqlDbType.Int, 4, "�ʵ����")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_�ʵ����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "�ʵ����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 36, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 80, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��ע", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "��������", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_����ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "����ʱ��", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_���ѽ��", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "���ѽ��", System.Data.DataRowVersion.Original, null)});
            // 
            // ClientConsume
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.calen1);
            this.Name = "ClientConsume";
            this.Text = "�����Ѽ��ʡ�";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientConsume_FormClosing);
            this.Load += new System.EventHandler(this.ClientConsume_Load);
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

		
		//-----��ʾ����������-----
		private void cmb1_DropDown(object sender, System.EventArgs e)
		{
			selectDate(cmb1);		
		}
		//----------�ر����ڿؼ�����ʾ----------
		private void cmb1_Leave(object sender, System.EventArgs e)
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
			cmb1.Text=calen1.SelectionEnd.ToString();			
		}

		//-------------��������ѡ����������---------------
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
			dataSet21.Clear();//ˢ�����ݼ�
			da1.Fill(dataSet21);
		
		}

		private void ClientConsume_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";			
			da1.SelectCommand.Parameters[1].Value="%";
			
			da1.Fill(dataSet21);//����ʵ���ϸ
			base.dataSet11=this.dataSet21;
			this.cmOrders=(CurrencyManager) BindingContext[dataSet21,"�ʵ���ϸ"];
		}

		//----------��д���ÿؼ�ֻ�����Ժ���----------
		protected override void SetModifyMode(bool blnEdit)
		{
			base.SetModifyMode (blnEdit);
			
			txt5.ReadOnly=!blnEdit;
			txt6.ReadOnly=!blnEdit;
						
			cmb1.Enabled=blnEdit;
			cmb2.Enabled=blnEdit;
			
			btnSelect.Enabled=blnEdit;
		}

		//-------��д������¼ʱ����Ĭ��ֵ����--------
		protected override void SetDefaultValue()
		{
			base.SetDefaultValue();			
		}

		//-------��д���ǿ��ֶκ���--------
		protected override bool CheckNotNull()
		{
						
			if(txt4.Text.Trim()=="")// �����ס����
			{
				MessageBox.Show("��ס���źŲ���Ϊ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(txt5.Text.Trim()=="")//������ѽ��
			{
				MessageBox.Show("���������ѽ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}		
			
			return base.CheckNotNull ();
		}

		//----------����ס����˫��ѡ����ס����-----------
		private void btnSelect_Click(object sender, System.EventArgs e)
		{
			string sql="select * from ��ס��";
			SelectTable newfrm=new SelectTable(sql,2);
			newfrm.Text="˫��ѡ����ס����";
			newfrm.ShowDialog();		
		}

		private void btnSelect_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(RZid=="")
				return;
			txt4.Text=RZid;
		
		}

        private void ClientConsume_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }
	}
}

