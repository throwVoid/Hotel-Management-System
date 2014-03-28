using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;


namespace 酒店管理系统
{
	/// <summary>
	/// RoomStatus 的摘要说明。
	/// </summary>
	public class RoomStatus : System.Windows.Forms.Form
	{
		private DataTable roomTable;//一个空的4行16列的表
		private DataTable statusTable=new DataTable();//保存客房信息
		private int formType=0;//确定窗体是用于显示房态还是选择房间，以及由哪个窗体调用选择房间
		
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
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
            //if (mainForm.getAdmin() == false) toolBar1.Enabled = false;
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
			formType=useType;//由构造函数参数确定是否为双击选择房间而用
			//formType=0代表正常房态图显示，1表示由客房预定窗体调用，2表示由客房入住窗体调用

		}

		/// <summary>
		/// 清理所有正在使用的资源。
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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
            this.groupBox1.Text = "房态显示";
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
            this.groupBox2.Text = "状态管理";
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
            this.label1.Text = "房号";
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
            this.groupBox3.Text = "房态选择";
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
            this.rb1.Text = "空闲";
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
            this.rb2.Text = "住房";
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
            this.rb3.Text = "自用";
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
            this.rb4.Text = "维修";
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
            this.rb5.Text = "将到";
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
            this.rb6.Text = "将离";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新房间状态信息";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(24, 372);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "更改房间状态";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "类型";
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
            this.groupBox4.Text = "房间查找";
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
            this.label3.Text = "按类型筛选";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "按房间号筛选";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "开始检索";
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
            this.Text = "客房状态管理";
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

		//---------窗体初始化时的处理-------
		private void RoomStatus_Load(object sender, System.EventArgs e)
		{
			if(this.formType!=0)
			{
				groupBox1.Text+=" 双击左边的【房号】文本框选择房间";
			}
			dataGrid1.Paint+=new PaintEventHandler(dataGrid1_Paint);
			this.DataGridStateControl();
			this.AutoSizeGrid();
			this.RefreshStatus("select * from 客房信息");//读入所有类型房间的数据
			//读入所有客房的类型
			cmb1.Items.Clear();
			cmb1.Items.Add("全部");
            cmb2.Items.Clear();
            cmb2.Items.Add("全部");
          //  string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select distinct 类型名称 from 客房类型";
			SqlDataReader dr=cmd.ExecuteReader();
			while(dr.Read())
			{
				cmb1.Items.Add(dr.GetValue(0).ToString().Trim());
                cmb2.Items.Add(dr.GetValue(0).ToString().Trim());
			}	
			//焦点集中到【房号】文本框上
			txt1.Focus();
		}
		
		
		//----------设置dataGrid中的行宽度--------
		public void AutoSizeGrid() 
 		{ 			 
			int numRows = ((DataTable)dataGrid1.DataSource).Rows.Count; //该dataGrid所连接的表的宽度 
			Graphics g = Graphics.FromHwnd(dataGrid1.Handle);  
			StringFormat sf = new StringFormat(StringFormat.GenericTypographic); 
			SizeF size; 
 
			//由于DataGrid没有提供对DataGridRows[]的直接调用，因此我们使用一个反射（relection）来实现它
			//这个方法实际上取得dataGrid中行的集合，通过get_DataGridRows方法返回Rows的集合
			//并转化为一个System.Array对象 
			MethodInfo mi = dataGrid1.GetType().GetMethod("get_DataGridRows", 
 
				BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase | BindingFlags.Instance 
 
				| BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static); 
 
			System.Array dgra = (System.Array)mi.Invoke(dataGrid1,null); 
 
			// 将其转换为ArrayList
			ArrayList DataGridRows = new ArrayList();  
			foreach (object dgrr in dgra)  
			{  
				if (dgrr.ToString().EndsWith("DataGridRelationshipRow")==true) 
					DataGridRows.Add(dgrr);  
			} 
 
			//枚举dataGrid中的所有行 
			for (int i = 0; i < numRows; ++i) 
			{
				size = g.MeasureString(dataGrid1[i,1].ToString(),dataGrid1.Font,400,sf); 
				int h = Convert.ToInt32(32);//直接将每行的行高设置为40
				//用下面这行代码可以根据dataGrid中字体自动调整行高
				//int h = Convert.ToInt32(size.Height); 
				
				
				// 将定好的行高设置回dataGrid中 
				PropertyInfo pi = DataGridRows[i].GetType().GetProperty("Height");  
				pi.SetValue(DataGridRows[i],h,null);  
			}  
			g.Dispose();  
		}

		//----------设置一个16*4的表格，以显示房态图----------
		private void DataGridStateControl()
		{
			roomTable = new DataTable();
			
			for(int i=1;i<17;i++)//添加16列，以显示16个房间
			{
				roomTable.Columns.Add(i.ToString(),typeof(string));
			}
			
			this.dataGrid1.DataSource = roomTable;
			for(int i=0;i<4;i++)//向表中添加4行,显示4层楼
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
				aColumnTextColumn.Format = "N"; //设置为数字格式显示
				ts.GridColumnStyles.Add(aColumnTextColumn);
			}
			dataGrid1.TableStyles.Add(ts);
		}
	
		//-------重画房态图---------
		private void dataGrid1_Paint(object sender, PaintEventArgs e)
		{
			if(this.statusTable.Rows.Count==0)
			{
				return;
			}
			string status;//房屋状态
			int floor,roomNum;//楼层和房间号
			Image pic=imageList1.Images[0];//显示的图像
			

			foreach(DataRow aRow in statusTable.Rows)
            {
                if (aRow.Table.Rows.Count==0) return;
				floor=Convert.ToInt32(aRow["楼层编号"]);
				roomNum=Convert.ToInt32(aRow["客房编号"])-100*floor;
				if(roomNum>14)//还原避开的两个忌讳数字13，14后的编号
					roomNum=roomNum-2;
				status=aRow["状态"].ToString().Trim();
				switch(status)//根据不同状态，确定不同图片
				{
					case "将到":
						pic=imageList1.Images[0];
						break;
					case "将离":
						pic=imageList1.Images[1];
						break;
					case "空房":
						pic=imageList1.Images[2];
						break;
					case "维修":
						pic=imageList1.Images[3];
						break;
					case "住房":
						pic=imageList1.Images[4];
						break;
					case "自用":
						pic=imageList1.Images[5];
						break;
				}
				e.Graphics.DrawImage(pic,2+32*(roomNum-1),2+32*(floor-3));			
				e.Graphics.DrawString(aRow["客房编号"].ToString().Trim(),Font,SystemBrushes.WindowText,4+32*(roomNum-1),24+32*(floor-3));
			}

		}

		//----------更新房态数据---------
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

		//---------单击一个房间图标时，显示其房号和类型，以及状态-----------
		private void dataGrid1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int col=dataGrid1.CurrentCell.ColumnNumber;
			int row=dataGrid1.CurrentCell.RowNumber;
			row=row+3;//楼层编号从3楼开始
			col=col+1;//房间编号从1开始
			if(col>12)//房屋编号中没有13，14这两个编号，是向后顺延的
			{
				col=col+2;
			}
			string roomID="";//房间编号
			if(col.ToString().Length==1)//还原房间编号
			{
				roomID="0"+row.ToString()+"0"+col.ToString();
			}
			else
			{
				roomID="0"+row.ToString()+col.ToString();
			}
			DataRow[] aRows=this.statusTable.Select("客房编号='"+roomID+"'");
			if(aRows.Length==0)//如果未选中房间，则不进行任何处理
			{
				txt1.Clear();//清除房号
				cmb1.Text="";//清除类型
				return;
			}
			DataRow rRow=aRows[0];//读入当前房号数据
			txt1.Text=rRow["客房编号"].ToString().Trim();
			cmb1.Text=this.ShowRoomType(txt1.Text);

			string status;//选中房间房态
			status=rRow["状态"].ToString().Trim();
			switch(status)
			{
				case "空房":
					rb1.Checked=true;
					break;
				case "住房":
					rb2.Checked=true;
					break;
				case "自用":
					rb3.Checked=true;
					break;
				case "维修":
					rb4.Checked=true;
					break;
				case "将到":
					rb5.Checked=true;
					break;
				case "将离":
					rb6.Checked=true;
					break;
			}
			txt1.Focus();			
		}

		//-------根据输入的房间号，读入房间类型------
		private string ShowRoomType(string num)
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
           // string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select b.类型名称 from 客房信息 a,客房类型 b" 
				+" where(a.类型编号=b.类型编号)and(a.客房编号='"+num+"')";
			string rType=cmd.ExecuteScalar().ToString().Trim();
			return(rType);
		}		

		//-------------根据选择的房间类型显示房间-------------
		private void cmb1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql;			
			int i=cmb1.SelectedIndex;			
			string roomType=cmb1.Items[i].ToString().Trim();
			if(roomType=="全部")
			{
				sql="select * from 客房信息";
			}
			else
			{
				sql="select a.* from 客房信息 a,客房类型 b where (a.类型编号=b.类型编号)"
					+"and(b.类型名称='"+roomType+"')";
			}

			RefreshStatus(sql);//读入所选类型房间的数据
			dataGrid1.Refresh();		
		}

		//--------刷新房态-----------
		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			string sqlStr;
			if(cmb1.Text=="")
			{
				sqlStr="select * from 客房信息";				
			}
			else
			{
				sqlStr="select a.* from 客房信息 a,客房类型 b where (a.类型编号=b.类型编号)"
					+"and(b.类型名称='"+cmb1.Text+"')";
			}
			RefreshStatus(sqlStr);//更新房间的数据
			dataGrid1.Refresh();		
		}

		//----------更改房间状态---------
		private void btnModify_Click(object sender, System.EventArgs e)
		{
			if(txt1.Text=="")
			{
				MessageBox.Show("请先选择要更改状态的房间!");
				return;
			}
			DialogResult dlg;
			string msg="一般情况下不能直接在房态图中修改房间状态,确定要修改吗？";
			dlg=MessageBox.Show(msg,"确认修改",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			if(dlg==DialogResult.OK)
			{
				string strConn="workstation id=localhost;Integrated Security=SSPI;Database=hotelbook;";
                //string strConn = "data source = (local);initial catalog = hotelbook; user id = sa;password =778855";
				SqlConnection cn=new SqlConnection(strConn);
				cn.Open();
				SqlCommand cmd=cn.CreateCommand();
				string newStatus="";
				if(rb1.Checked)
					newStatus="空房";
				if(rb2.Checked)
					newStatus="住房";
				if(rb3.Checked)
					newStatus="自用";
				if(rb4.Checked)
					newStatus="维修";
				if(rb5.Checked)
					newStatus="将到";
				if(rb6.Checked)
					newStatus="将离";

				//更改房间状态
				cmd.CommandText="update 客房信息 set 状态='"+newStatus+"' where 客房编号='"+txt1.Text+"'";
				cmd.ExecuteNonQuery();
				RefreshStatus("select * from 客房信息");//显示全部房间
				dataGrid1.Refresh();
			}	
		
		}

		//--------双击向预定或入住窗体中返回客房数据--------
		private void txt1_DoubleClick(object sender, System.EventArgs e)
		{
			if(this.formType==0||txt1.Text=="")//如果类型为房态图正常显示或未选中房间，则不必返回数据
			{	
				return;
			}
			if(!rb1.Checked)
			{
				MessageBox.Show("必须选择空房");
				return;
			}
			
			string[] returnInfo={"",""};
			if(this.formType==1)//向客房预定管理窗体中返回信息
			{
				returnInfo[0]=txt1.Text;
				returnInfo[1]=cmb1.Text;
				
				HotelReserve.roomInfo=returnInfo;
				this.Close();
			}
			if(this.formType==2)//向客房入住管理窗体中返回信息
			{
				
				returnInfo[0]=txt1.Text;
				returnInfo[1]=cmb1.Text;
				
				HotelArrival.roomInfo=returnInfo;
				this.Close();
			}				
		}

		//----------每当窗体激活时，即刷新房态-------------
		private void RoomStatus_Activated(object sender, System.EventArgs e)
		{
			string sqlStr;
			if(cmb1.Text=="")
			{
				sqlStr="select * from 客房信息";				
			}
			else
			{
				sqlStr="select a.* from 客房信息 a,客房类型 b where (a.类型编号=b.类型编号)"
					+"and(b.类型名称='"+cmb1.Text+"')";
			}
			RefreshStatus(sqlStr);//更新房间的数据
			dataGrid1.Refresh();			
		}

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)//按类型查找
        {
            string sql;
            int i = cmb2.SelectedIndex;
            string roomType = cmb2.Items[i].ToString().Trim();
            if (roomType == "全部")
            {
                sql = "select * from 客房信息";
            }
            else
            {
                sql = "select a.* from 客房信息 a,客房类型 b where (a.类型编号=b.类型编号)"
                    + "and(b.类型名称='" + roomType + "')";
            }

            RefreshStatus(sql);//读入所选类型房间的数据
            dataGrid1.Refresh();	
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            string roomNo = textBoxSearchRoom.Text.ToString().Trim();
            if (roomNo.Length != 0)
            {
                sql = "select * " + "from 客房信息 a where (a.客房编号 =" + roomNo + ")";
                if (RefreshStatus(sql) == 0)//读入所选房间的数据
                {
                    MessageBox.Show("不存在该房间");
                }
                else 
                    dataGrid1.Refresh();
            }
            else
            {
                MessageBox.Show("未输入有效的房间名");
                return;
            }
        }

        private void RoomStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.myShow();
        }



	}
}
