using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace �Ƶ����ϵͳ
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private IContainer components;
        private bool isAdmin;
        private bool login;
		public MainForm()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
            login = false;
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//

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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem9,
            this.menuItem10});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "��������";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "�ͷ���������";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "�ͷ���Ϣ����";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            this.menuItem4.Text = "ҵ�����";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Ԥ���������";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "��ס�������";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "����ҵ�����ѹ���";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 3;
            this.menuItem8.Text = "�˷�����";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "����״̬";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            this.menuItem10.Text = "�˳�ϵͳ";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 607);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1008, 22);
            this.statusBar1.TabIndex = 2;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.MinWidth = 200;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = " ��ӭʹ�þƵ����ϵͳV1.0";
            this.statusBarPanel1.Width = 500;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 200;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(111, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "�ͷ���������";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(222, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "�ͷ���Ϣ����";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(333, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ԥ���������";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(444, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 84);
            this.button4.TabIndex = 7;
            this.button4.Text = "��ס�������";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(666, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 84);
            this.button5.TabIndex = 8;
            this.button5.Text = "�˷�����";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(777, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 84);
            this.button6.TabIndex = 9;
            this.button6.Text = "����״̬����";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(555, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 84);
            this.button7.TabIndex = 10;
            this.button7.Text = "����ҵ������";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 629);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusBar1);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "�Ƶ����ϵͳ V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        /*


		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

         */
		//----------------------��ѯMDI�Ӵ����Ƿ����-----------------------------
		private bool checkChildFrmExist(string childFrmName)
		{
			foreach(Form childFrm in this.MdiChildren)
			{
				if(childFrm.Name == childFrmName) //���Ӵ����Name�����жϣ����������������
				{
					if(childFrm.WindowState == FormWindowState.Minimized)
						childFrm.WindowState = FormWindowState.Normal;
					childFrm.Activate();
					return true;
				}
			}
			return false;
		}

		//-----------------��ʾ�ͷ����͹������ô���-----------------------
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("RoomType") == true)
			{
				return;
			}
			RoomType newFrm=new RoomType(this);
			newFrm.MdiParent = this;
			newFrm.Show();		
		}

		//-----------------��ʾ�ͷ���Ϣ�������ô���-----------------------
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("RoomInfo") == true)
			{
				return;
			}
			RoomInfo newFrm=new RoomInfo(this);
			newFrm.MdiParent = this;
			newFrm.Show();	
		
		}

		//-----------------��ʾ�ͷ�Ԥ����Ϣ����-----------------------
		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("HotelReserve") == true)
			{
				return;
			}
			HotelReserve newFrm=new HotelReserve(this);
			newFrm.MdiParent = this;
			newFrm.Show();	
		
		}
        
		//-----------------��ʾ��ס������Ϣ����-----------------------
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("HotelArrival") == true)
			{
				return;
			}
			HotelArrival newFrm=new HotelArrival(this);
			newFrm.MdiParent = this;
			newFrm.Show();	
		
		}

		//-----------------��ʾ���Ѽ��ʴ���-----------------------
		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("ClientConsume") == true)
			{
				return;
			}
			ClientConsume newFrm=new ClientConsume(this);
			newFrm.MdiParent = this;
			newFrm.Show();
		
		}

		//-----------��ʾ�����˷�����---------------
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("HotelLeave") == true)
			{
				return;
			}
			HotelLeave newFrm=new HotelLeave(this);
			newFrm.MdiParent = this;
			newFrm.Show();		
		}
        
		//-----------��ʾ��̬ͼ---------------
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			//ͨ���������Ʋ�ѯ�ô����Ƿ��Ѿ����ڣ����������ʾ��������´���һ��
			if (this.checkChildFrmExist("RoomStatus") == true)
			{
				return;
			}
			RoomStatus newFrm=new RoomStatus(0,this);
			newFrm.MdiParent = this;
			newFrm.Show();		
		}

		//--------�˳�ϵͳ-----------
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
        public void myHide()
        {
            button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = false;
            button7.Visible = false; button6.Visible = false; button5.Visible = false;
        }
        public void myShow()
        {
            button1.Visible = true; button2.Visible = true; button3.Visible = true; button4.Visible = true;
            button7.Visible = true; button6.Visible = true; button5.Visible = true;
        }
        public void setAdmin(bool boolIsAdmin)
        {
            isAdmin = boolIsAdmin;
        }
        public bool getAdmin() { return isAdmin; }
        public void setLogin(bool lg)
        {
            login = lg;
        }
        public bool getLogin() { return login; }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
            this.Dispose();
            this.Close();
        }

	}
}
