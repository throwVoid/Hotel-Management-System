using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace �Ƶ����ϵͳ
{
	/// <summary>
	/// SelectTable ��ժҪ˵����
	/// </summary>
	public class SelectTable : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private DataSet ds;//���ݼ�
		private string sql;//���ڶ�ȡ���ݵ�SQL���
		private int formIndex;//��ʾ���ĸ������е���

		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SelectTable(string sqlStr,int Index)//�޸Ĺ��캯��
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
			this.sql=sqlStr;//ͨ�����캯������SQL���
			this.formIndex=Index;//���봰���ʾ
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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

		//-------���ݹ��캯���е�sql��䣬�������ݲ���ʾ�ڱ����---------
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

		//-------˫��ѡ��һ�У�������һ��Ԥ�����ŷ��ص���ס����--------
		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			int i=dataGrid1.CurrentRowIndex;
			if(formIndex==1)//����ס���д���Ԥ��������
			    HotelArrival.dRow=ds.Tables[0].Rows[i];
			if(formIndex==2)//�����Ѽ��ʴ����д�����ס�����
				ClientConsume.RZid=dataGrid1[i,0].ToString().Trim();
			this.Close();
		}

        private void SelectTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            //mainForm.Show();
        }
	}
}
