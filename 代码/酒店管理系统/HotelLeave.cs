using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace �Ƶ����ϵͳ
{
	public class HotelLeave : ҽԺ����ϵͳ.ParentForm
	{
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private �Ƶ����ϵͳ.DataSet1 dataSet11;
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
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.dataView1 = new System.Data.DataView();
            this.dataSet11 = new �Ƶ����ϵͳ.DataSet1();
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
            this.dataGrid1.DataMember = "��ס��";
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
            new System.Data.Common.DataTableMapping("Table", "��ס��", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
                        new System.Data.Common.DataColumnMapping("Ԥ������", "Ԥ������"),
                        new System.Data.Common.DataColumnMapping("��Ա���", "��Ա���"),
                        new System.Data.Common.DataColumnMapping("�ֵ�ʱ��", "�ֵ�ʱ��"),
                        new System.Data.Common.DataColumnMapping("���ʱ��", "���ʱ��"),
                        new System.Data.Common.DataColumnMapping("�ͷ����", "�ͷ����"),
                        new System.Data.Common.DataColumnMapping("�ͷ��۸�", "�ͷ��۸�"),
                        new System.Data.Common.DataColumnMapping("��ס�۸�", "��ס�۸�"),
                        new System.Data.Common.DataColumnMapping("�Ƿ�Ӵ�", "�Ƿ�Ӵ�"),
                        new System.Data.Common.DataColumnMapping("�Ӵ��۸�", "�Ӵ��۸�"),
                        new System.Data.Common.DataColumnMapping("Ԥ�տ�", "Ԥ�տ�"),
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
                        new System.Data.Common.DataColumnMapping("���ʽ", "���ʽ"),
                        new System.Data.Common.DataColumnMapping("��ס����", "��ס����")})});
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
            this.dataView1.Table = this.dataSet11.�ʵ���ϸ;
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
            new System.Data.Common.DataTableMapping("Table", "�ʵ���ϸ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("�ʵ����", "�ʵ����"),
                        new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
                        new System.Data.Common.DataColumnMapping("��������", "��������"),
                        new System.Data.Common.DataColumnMapping("���ѽ��", "���ѽ��"),
                        new System.Data.Common.DataColumnMapping("����ʱ��", "����ʱ��"),
                        new System.Data.Common.DataColumnMapping("��ע", "��ע")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT �ʵ����, ��ס����, ��������, ���ѽ��, ����ʱ��, ��ע FROM �ʵ���ϸ";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(56, 32);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(112, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "����Ӧ�տ�";
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(464, 32);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(128, 23);
            this.btnLeave.TabIndex = 0;
            this.btnLeave.Text = "���������˷�";
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "��ס��.Ӧ���ʿ�", true));
            this.txt4.Location = new System.Drawing.Point(192, 32);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 21);
            this.txt4.TabIndex = 1;
            // 
            // cmb1
            // 
            this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "��ס��.���ʽ", true));
            this.cmb1.Items.AddRange(new object[] {
            "�ֽ�",
            "֧Ʊ",
            "���ÿ�",
            "����ȯ",
            "����"});
            this.cmb1.Location = new System.Drawing.Point(312, 32);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 20);
            this.cmb1.TabIndex = 2;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT ��ס����, Ԥ������, ��Ա���, �ֵ�ʱ��, ���ʱ��, �ͷ����, �ͷ��۸�, ��ס�۸�, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, ���, ����, ��" +
    "��, vip, �绰�ȼ�, ��Ҫ˵��, Ӧ���ʿ�, �Ƿ����, ���ʽ��, ��������, ���ʽ, ��ס���� FROM ��ס�� WHERE (��ס���� LIKE" +
    " @Param17) AND (�ͷ���� LIKE @Param18)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param17", System.Data.SqlDbType.VarChar, 36, "��ס����"),
            new System.Data.SqlClient.SqlParameter("@Param18", System.Data.SqlDbType.VarChar, 12, "�ͷ����")});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(192, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ӧ����";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(312, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "֧����ʽ";
            // 
            // HotelLeave
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.dataGrid2);
            this.Name = "HotelLeave";
            this.Text = "��������";
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

		//----------���ɴ���ʱ��������-----------
		private void HotelLeave_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%";
			da1.SelectCommand.Parameters[1].Value="%";
			da1.Fill(this.dataSet11);
			da2.Fill(dataSet11);
			if(dataSet11.��ס��.Rows.Count!=0)//�����һ����ס�����ʵ���ϸ
                dataView1.RowFilter="��ס����='"+dataSet11.��ס��.Rows[0]["��ס����"].ToString()+"'";
			base.dataSet11=this.dataSet11;
			cmOrders=(CurrencyManager) BindingContext[this.dataSet11,"��ס��"];

		}

		//---------��ʾ�ʵ���ϸ-------
		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			//���ݵ�ǰ�е���ס���ţ�������ס���ʵ���ϸ
			int i=dataGrid1.CurrentRowIndex;
			dataView1.RowFilter="��ס����='"+dataGrid1[i,0].ToString()+"'";
		}

		//-----------�������룬������Ϣ---------
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
			dataSet11.Clear();//ˢ�����ݼ�
			da1.Fill(dataSet11);
			da2.Fill(dataSet11);
			if(dataSet11.��ס��.Rows.Count==0)//���û�в鵽���ݣ�����ʾ�ʵ���ϸ
				dataView1.RowFilter="��ס����=''";
			else//����鵽�����ݣ�����ʾ��ϸ
				dataView1.RowFilter="��ס����='"+dataSet11.��ס��.Rows[0]["��ס����"].ToString()+"'";
		}

		
		//-------------����Ӧ������---------------
		private void btnCal_Click(object sender, System.EventArgs e)
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			int i=dataGrid1.CurrentRowIndex;
			cmd.CommandText="exec sf_����Ӧ���ʿ� '"+dataGrid1[i,0].ToString()+"'";
			cmd.ExecuteNonQuery();
			dataSet11.Clear();//ˢ�����ݼ�
			da1.Fill(dataSet11);
			da2.Fill(dataSet11);
			
			cmOrders.Position = i;//�ƶ����ղ���ѡ������
			this.dataGrid1.Select(cmOrders.Position); //ѡ�е�ǰ��
			this.dataGrid1.CurrentRowIndex = cmOrders.Position; //�ƶ���ͷָʾͼ��
			cmb1.Text="�ֽ�";//Ĭ�ϸ��ʽ
		
		}

		//------------���������˷�---------------
		private void btnLeave_Click(object sender, System.EventArgs e)
		{
			if(cmb1.Text.Trim()=="")//���֧����ʽ��ѡȡ
			{
				MessageBox.Show("��ѡ��֧����ʽ");
				return;
			}
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
            //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			int i=dataGrid1.CurrentRowIndex;
			cmd.CommandText="exec sf_�����˷� '"+dataGrid1[i,0].ToString()+"','"+cmb1.Text.Trim()+"'";
			cmd.ExecuteNonQuery();
			
			
			
			dataSet11.Clear();//ˢ�����ݼ�
			da1.Fill(dataSet11);
			da2.Fill(dataSet11);


		}

        private void HotelLeave_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }

		


	}
}

