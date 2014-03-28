using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;


namespace �Ƶ����ϵͳ
{
	/// <summary>
	/// RoomStatus ��ժҪ˵����
	/// </summary>
	public class RoomStatus : System.Windows.Forms.Form
	{
		private DataTable roomTable;//һ���յ�4��16�еı�
		private DataTable statusTable=new DataTable();//����ͷ���Ϣ
		private int formType=0;//ȷ��������������ʾ��̬����ѡ�񷿼䣬�Լ����ĸ��������ѡ�񷿼�
		
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.RadioButton rb1;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb3;
		private System.Windows.Forms.RadioButton rb4;
		private System.Windows.Forms.RadioButton rb5;
		private System.Windows.Forms.RadioButton rb6;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmb1;
        private GroupBox groupBox4;
        private TextBox textBoxSearchRoom;
        private Button button2;
        private Label label4;
        private Label label3;
        private ComboBox cmb2;
		private System.ComponentModel.IContainer components;
        private MainForm mainForm;
		public RoomStatus(int useType,MainForm mf)
		{
            mainForm = mf;
            mainForm.myHide();
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
            //if (mainForm.getAdmin() == false) toolBar1.Enabled = false;
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
			formType=useType;//�ɹ��캯������ȷ���Ƿ�Ϊ˫��ѡ�񷿼����
			//formType=0����������̬ͼ��ʾ��1��ʾ�ɿͷ�Ԥ��������ã�2��ʾ�ɿͷ���ס�������

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomStatus));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSearchRoom = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid1);
            this.groupBox1.Location = new System.Drawing.Point(319, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "��̬��ʾ";
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionVisible = false;
            this.dataGrid1.ColumnHeadersVisible = false;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 24);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.PreferredColumnWidth = 32;
            this.dataGrid1.PreferredRowHeight = 32;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.RowHeaderWidth = 32;
            this.dataGrid1.Size = new System.Drawing.Size(560, 368);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "״̬����";
            // 
            // cmb1
            // 
            this.cmb1.BackColor = System.Drawing.SystemColors.Window;
            this.cmb1.Location = new System.Drawing.Point(40, 72);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(96, 20);
            this.cmb1.TabIndex = 7;
            this.cmb1.SelectionChangeCommitted += new System.EventHandler(this.cmb1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "����";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(40, 48);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(96, 21);
            this.txt1.TabIndex = 5;
            this.txt1.DoubleClick += new System.EventHandler(this.txt1_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb1);
            this.groupBox3.Controls.Add(this.rb2);
            this.groupBox3.Controls.Add(this.rb3);
            this.groupBox3.Controls.Add(this.rb4);
            this.groupBox3.Controls.Add(this.rb5);
            this.groupBox3.Controls.Add(this.rb6);
            this.groupBox3.Location = new System.Drawing.Point(8, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 272);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "��̬ѡ��";
            // 
            // rb1
            // 
            this.rb1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb1.ImageIndex = 2;
            this.rb1.ImageList = this.imageList1;
            this.rb1.Location = new System.Drawing.Point(24, 24);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(84, 32);
            this.rb1.TabIndex = 3;
            this.rb1.Text = "����";
            // 
            // rb2
            // 
            this.rb2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb2.ImageIndex = 4;
            this.rb2.ImageList = this.imageList1;
            this.rb2.Location = new System.Drawing.Point(24, 64);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(84, 32);
            this.rb2.TabIndex = 3;
            this.rb2.Text = "ס��";
            // 
            // rb3
            // 
            this.rb3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb3.ImageIndex = 5;
            this.rb3.ImageList = this.imageList1;
            this.rb3.Location = new System.Drawing.Point(24, 104);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(84, 32);
            this.rb3.TabIndex = 3;
            this.rb3.Text = "����";
            // 
            // rb4
            // 
            this.rb4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb4.ImageIndex = 3;
            this.rb4.ImageList = this.imageList1;
            this.rb4.Location = new System.Drawing.Point(24, 144);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(84, 32);
            this.rb4.TabIndex = 3;
            this.rb4.Text = "ά��";
            // 
            // rb5
            // 
            this.rb5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb5.ImageIndex = 0;
            this.rb5.ImageList = this.imageList1;
            this.rb5.Location = new System.Drawing.Point(24, 184);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(84, 32);
            this.rb5.TabIndex = 3;
            this.rb5.Text = "����";
            // 
            // rb6
            // 
            this.rb6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb6.ImageIndex = 1;
            this.rb6.ImageList = this.imageList1;
            this.rb6.Location = new System.Drawing.Point(24, 224);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(84, 32);
            this.rb6.TabIndex = 3;
            this.rb6.Text = "����";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "ˢ�·���״̬��Ϣ";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(24, 372);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "���ķ���״̬";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "����";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSearchRoom);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmb2);
            this.groupBox4.Location = new System.Drawing.Point(160, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 400);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "�������";
            // 
            // cmb2
            // 
            this.cmb2.Location = new System.Drawing.Point(18, 69);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(96, 20);
            this.cmb2.TabIndex = 8;
            this.cmb2.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "������ɸѡ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "�������ɸѡ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "��ʼ����";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSearchRoom
            // 
            this.textBoxSearchRoom.Location = new System.Drawing.Point(16, 218);
            this.textBoxSearchRoom.Name = "textBoxSearchRoom";
            this.textBoxSearchRoom.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearchRoom.TabIndex = 12;
            // 
            // RoomStatus
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(897, 410);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "�ͷ�״̬����";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.RoomStatus_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomStatus_FormClosing);
            this.Load += new System.EventHandler(this.RoomStatus_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		//---------�����ʼ��ʱ�Ĵ���-------
		private void RoomStatus_Load(object sender, System.EventArgs e)
		{
			if(this.formType!=0)
			{
				groupBox1.Text+=" ˫����ߵġ����š��ı���ѡ�񷿼�";
			}
			dataGrid1.Paint+=new PaintEventHandler(dataGrid1_Paint);
			this.DataGridStateControl();
			this.AutoSizeGrid();
			this.RefreshStatus("select * from �ͷ���Ϣ");//�����������ͷ��������
			//�������пͷ�������
			cmb1.Items.Clear();
			cmb1.Items.Add("ȫ��");
            cmb2.Items.Clear();
            cmb2.Items.Add("ȫ��");
          //  string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select distinct �������� from �ͷ�����";
			SqlDataReader dr=cmd.ExecuteReader();
			while(dr.Read())
			{
				cmb1.Items.Add(dr.GetValue(0).ToString().Trim());
                cmb2.Items.Add(dr.GetValue(0).ToString().Trim());
			}	
			//���㼯�е������š��ı�����
			txt1.Focus();
		}
		
		
		//----------����dataGrid�е��п��--------
		public void AutoSizeGrid() 
 		{ 			 
			int numRows = ((DataTable)dataGrid1.DataSource).Rows.Count; //��dataGrid�����ӵı�Ŀ�� 
			Graphics g = Graphics.FromHwnd(dataGrid1.Handle);  
			StringFormat sf = new StringFormat(StringFormat.GenericTypographic); 
			SizeF size; 
 
			//����DataGridû���ṩ��DataGridRows[]��ֱ�ӵ��ã��������ʹ��һ�����䣨relection����ʵ����
			//�������ʵ����ȡ��dataGrid���еļ��ϣ�ͨ��get_DataGridRows��������Rows�ļ���
			//��ת��Ϊһ��System.Array���� 
			MethodInfo mi = dataGrid1.GetType().GetMethod("get_DataGridRows", 
 
				BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase | BindingFlags.Instance 
 
				| BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static); 
 
			System.Array dgra = (System.Array)mi.Invoke(dataGrid1,null); 
 
			// ����ת��ΪArrayList
			ArrayList DataGridRows = new ArrayList();  
			foreach (object dgrr in dgra)  
			{  
				if (dgrr.ToString().EndsWith("DataGridRelationshipRow")==true) 
					DataGridRows.Add(dgrr);  
			} 
 
			//ö��dataGrid�е������� 
			for (int i = 0; i < numRows; ++i) 
			{
				size = g.MeasureString(dataGrid1[i,1].ToString(),dataGrid1.Font,400,sf); 
				int h = Convert.ToInt32(32);//ֱ�ӽ�ÿ�е��и�����Ϊ40
				//���������д�����Ը���dataGrid�������Զ������и�
				//int h = Convert.ToInt32(size.Height); 
				
				
				// �����õ��и����û�dataGrid�� 
				PropertyInfo pi = DataGridRows[i].GetType().GetProperty("Height");  
				pi.SetValue(DataGridRows[i],h,null);  
			}  
			g.Dispose();  
		}

		//----------����һ��16*4�ı������ʾ��̬ͼ----------
		private void DataGridStateControl()
		{
			roomTable = new DataTable();
			
			for(int i=1;i<17;i++)//���16�У�����ʾ16������
			{
				roomTable.Columns.Add(i.ToString(),typeof(string));
			}
			
			this.dataGrid1.DataSource = roomTable;
			for(int i=0;i<4;i++)//��������4��,��ʾ4��¥
			{
				roomTable.Rows.Add(roomTable.NewRow());				
			}

			DataGridTableStyle ts = new DataGridTableStyle();
			DataGridTextBoxColumn aColumnTextColumn;			
			ts.AllowSorting = false;
			ts.MappingName = roomTable.TableName;
			ts.RowHeadersVisible=false;						
			for (int j = 0;j< 16;j++)
			{
				aColumnTextColumn = new DataGridTextBoxColumn();
				aColumnTextColumn.ReadOnly=true;
				aColumnTextColumn.Width=32;
				aColumnTextColumn.MappingName = roomTable.Columns[j].ColumnName;
				aColumnTextColumn.HeaderText = roomTable.Columns[j].ColumnName;
				aColumnTextColumn.NullText = "";
				aColumnTextColumn.Format = "N"; //����Ϊ���ָ�ʽ��ʾ
				ts.GridColumnStyles.Add(aColumnTextColumn);
			}
			dataGrid1.TableStyles.Add(ts);
		}
	
		//-------�ػ���̬ͼ---------
		private void dataGrid1_Paint(object sender, PaintEventArgs e)
		{
			if(this.statusTable.Rows.Count==0)
			{
				return;
			}
			string status;//����״̬
			int floor,roomNum;//¥��ͷ����
			Image pic=imageList1.Images[0];//��ʾ��ͼ��
			

			foreach(DataRow aRow in statusTable.Rows)
            {
                if (aRow.Table.Rows.Count==0) return;
				floor=Convert.ToInt32(aRow["¥����"]);
				roomNum=Convert.ToInt32(aRow["�ͷ����"])-100*floor;
				if(roomNum>14)//��ԭ�ܿ��������ɻ�����13��14��ı��
					roomNum=roomNum-2;
				status=aRow["״̬"].ToString().Trim();
				switch(status)//���ݲ�ͬ״̬��ȷ����ͬͼƬ
				{
					case "����":
						pic=imageList1.Images[0];
						break;
					case "����":
						pic=imageList1.Images[1];
						break;
					case "�շ�":
						pic=imageList1.Images[2];
						break;
					case "ά��":
						pic=imageList1.Images[3];
						break;
					case "ס��":
						pic=imageList1.Images[4];
						break;
					case "����":
						pic=imageList1.Images[5];
						break;
				}
				e.Graphics.DrawImage(pic,2+32*(roomNum-1),2+32*(floor-3));			
				e.Graphics.DrawString(aRow["�ͷ����"].ToString().Trim(),Font,SystemBrushes.WindowText,4+32*(roomNum-1),24+32*(floor-3));
			}

		}

		//----------���·�̬����---------
		private int RefreshStatus(string sql)
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
           // string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlDataAdapter da=new SqlDataAdapter(sql,cn);
          
			this.statusTable.Clear();
			da.Fill(this.statusTable);	
            //Console.WriteLine("-----{0}", statusTable.Rows.Count);
            return statusTable.Rows.Count;
		}		

		//---------����һ������ͼ��ʱ����ʾ�䷿�ź����ͣ��Լ�״̬-----------
		private void dataGrid1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int col=dataGrid1.CurrentCell.ColumnNumber;
			int row=dataGrid1.CurrentCell.RowNumber;
			row=row+3;//¥���Ŵ�3¥��ʼ
			col=col+1;//�����Ŵ�1��ʼ
			if(col>12)//���ݱ����û��13��14��������ţ������˳�ӵ�
			{
				col=col+2;
			}
			string roomID="";//������
			if(col.ToString().Length==1)//��ԭ������
			{
				roomID="0"+row.ToString()+"0"+col.ToString();
			}
			else
			{
				roomID="0"+row.ToString()+col.ToString();
			}
			DataRow[] aRows=this.statusTable.Select("�ͷ����='"+roomID+"'");
			if(aRows.Length==0)//���δѡ�з��䣬�򲻽����κδ���
			{
				txt1.Clear();//�������
				cmb1.Text="";//�������
				return;
			}
			DataRow rRow=aRows[0];//���뵱ǰ��������
			txt1.Text=rRow["�ͷ����"].ToString().Trim();
			cmb1.Text=this.ShowRoomType(txt1.Text);

			string status;//ѡ�з��䷿̬
			status=rRow["״̬"].ToString().Trim();
			switch(status)
			{
				case "�շ�":
					rb1.Checked=true;
					break;
				case "ס��":
					rb2.Checked=true;
					break;
				case "����":
					rb3.Checked=true;
					break;
				case "ά��":
					rb4.Checked=true;
					break;
				case "����":
					rb5.Checked=true;
					break;
				case "����":
					rb6.Checked=true;
					break;
			}
			txt1.Focus();			
		}

		//-------��������ķ���ţ����뷿������------
		private string ShowRoomType(string num)
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
           // string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select b.�������� from �ͷ���Ϣ a,�ͷ����� b" 
				+" where(a.���ͱ��=b.���ͱ��)and(a.�ͷ����='"+num+"')";
			string rType=cmd.ExecuteScalar().ToString().Trim();
			return(rType);
		}		

		//-------------����ѡ��ķ���������ʾ����-------------
		private void cmb1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql;			
			int i=cmb1.SelectedIndex;			
			string roomType=cmb1.Items[i].ToString().Trim();
			if(roomType=="ȫ��")
			{
				sql="select * from �ͷ���Ϣ";
			}
			else
			{
				sql="select a.* from �ͷ���Ϣ a,�ͷ����� b where (a.���ͱ��=b.���ͱ��)"
					+"and(b.��������='"+roomType+"')";
			}

			RefreshStatus(sql);//������ѡ���ͷ��������
			dataGrid1.Refresh();		
		}

		//--------ˢ�·�̬-----------
		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			string sqlStr;
			if(cmb1.Text=="")
			{
				sqlStr="select * from �ͷ���Ϣ";				
			}
			else
			{
				sqlStr="select a.* from �ͷ���Ϣ a,�ͷ����� b where (a.���ͱ��=b.���ͱ��)"
					+"and(b.��������='"+cmb1.Text+"')";
			}
			RefreshStatus(sqlStr);//���·��������
			dataGrid1.Refresh();		
		}

		//----------���ķ���״̬---------
		private void btnModify_Click(object sender, System.EventArgs e)
		{
			if(txt1.Text=="")
			{
				MessageBox.Show("����ѡ��Ҫ����״̬�ķ���!");
				return;
			}
			DialogResult dlg;
			string msg="һ������²���ֱ���ڷ�̬ͼ���޸ķ���״̬,ȷ��Ҫ�޸���";
			dlg=MessageBox.Show(msg,"ȷ���޸�",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			if(dlg==DialogResult.OK)
			{
				string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
                //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
				SqlConnection cn=new SqlConnection(strConn);
				cn.Open();
				SqlCommand cmd=cn.CreateCommand();
				string newStatus="";
				if(rb1.Checked)
					newStatus="�շ�";
				if(rb2.Checked)
					newStatus="ס��";
				if(rb3.Checked)
					newStatus="����";
				if(rb4.Checked)
					newStatus="ά��";
				if(rb5.Checked)
					newStatus="����";
				if(rb6.Checked)
					newStatus="����";

				//���ķ���״̬
				cmd.CommandText="update �ͷ���Ϣ set ״̬='"+newStatus+"' where �ͷ����='"+txt1.Text+"'";
				cmd.ExecuteNonQuery();
				RefreshStatus("select * from �ͷ���Ϣ");//��ʾȫ������
				dataGrid1.Refresh();
			}	
		
		}

		//--------˫����Ԥ������ס�����з��ؿͷ�����--------
		private void txt1_DoubleClick(object sender, System.EventArgs e)
		{
			if(this.formType==0||txt1.Text=="")//�������Ϊ��̬ͼ������ʾ��δѡ�з��䣬�򲻱ط�������
			{	
				return;
			}
			if(!rb1.Checked)
			{
				MessageBox.Show("����ѡ��շ�");
				return;
			}
			
			string[] returnInfo={"",""};
			if(this.formType==1)//��ͷ�Ԥ���������з�����Ϣ
			{
				returnInfo[0]=txt1.Text;
				returnInfo[1]=cmb1.Text;
				
				HotelReserve.roomInfo=returnInfo;
				this.Close();
			}
			if(this.formType==2)//��ͷ���ס�������з�����Ϣ
			{
				
				returnInfo[0]=txt1.Text;
				returnInfo[1]=cmb1.Text;
				
				HotelArrival.roomInfo=returnInfo;
				this.Close();
			}				
		}

		//----------ÿ�����弤��ʱ����ˢ�·�̬-------------
		private void RoomStatus_Activated(object sender, System.EventArgs e)
		{
			string sqlStr;
			if(cmb1.Text=="")
			{
				sqlStr="select * from �ͷ���Ϣ";				
			}
			else
			{
				sqlStr="select a.* from �ͷ���Ϣ a,�ͷ����� b where (a.���ͱ��=b.���ͱ��)"
					+"and(b.��������='"+cmb1.Text+"')";
			}
			RefreshStatus(sqlStr);//���·��������
			dataGrid1.Refresh();			
		}

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)//�����Ͳ���
        {
            string sql;
            int i = cmb2.SelectedIndex;
            string roomType = cmb2.Items[i].ToString().Trim();
            if (roomType == "ȫ��")
            {
                sql = "select * from �ͷ���Ϣ";
            }
            else
            {
                sql = "select a.* from �ͷ���Ϣ a,�ͷ����� b where (a.���ͱ��=b.���ͱ��)"
                    + "and(b.��������='" + roomType + "')";
            }

            RefreshStatus(sql);//������ѡ���ͷ��������
            dataGrid1.Refresh();	
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            string roomNo = textBoxSearchRoom.Text.ToString().Trim();
            if (roomNo.Length != 0)
            {
                sql = "select * " + "from �ͷ���Ϣ a where (a.�ͷ���� =" + roomNo + ")";
                if (RefreshStatus(sql) == 0)//������ѡ���������
                {
                    MessageBox.Show("�����ڸ÷���");
                }
                else 
                    dataGrid1.Refresh();
            }
            else
            {
                MessageBox.Show("δ������Ч�ķ�����");
                return;
            }
        }

        private void RoomStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }



	}
}
