using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Text;
using System.IO;
using System.Drawing.Printing;

namespace notepad
{
	/// <summary>
	/// Form1�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileNew;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuFileOpen;
		private System.Windows.Forms.MenuItem menuFileSave;
		private System.Windows.Forms.MenuItem menuFileNewSave;
		private System.Windows.Forms.MenuItem menuFilePage;
		private System.Windows.Forms.MenuItem menuFilePrint;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuIEdit;
		private System.Windows.Forms.MenuItem menuEditUndo;
		private System.Windows.Forms.MenuItem menuEditCut;
		private System.Windows.Forms.MenuItem menuEditCopy;
		private System.Windows.Forms.MenuItem menuEditPaste;
		private System.Windows.Forms.MenuItem menuEditDelete;
		private System.Windows.Forms.MenuItem menuEditSearch;
		private System.Windows.Forms.MenuItem menuEditNextSearch;
		private System.Windows.Forms.MenuItem menuEditChange;
		private System.Windows.Forms.MenuItem menuEditMove;
		private System.Windows.Forms.MenuItem menuEditSelectAll;
		private System.Windows.Forms.MenuItem menuEditDateTime;
		private System.Windows.Forms.MenuItem menuOption;
		private System.Windows.Forms.MenuItem menuOptionLine;
		private System.Windows.Forms.MenuItem menuOptionFont;
		private System.Windows.Forms.MenuItem menuView;
		private System.Windows.Forms.MenuItem menuViewStatus;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuHelpList;
		private System.Windows.Forms.MenuItem menuHelpVersion;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.ColorDialog colorDialog1;

		private DialogResult result;//�޼��� �ڽ��� ��/�ƴϿ�/��� ���� ����
		private bool saveAs = false;//�����/���� �Ǵ�
		private bool changeText = false;//�ؽ�Ʈ�ڽ��� ���� �Ǵ�
		public string search = null;//�˻�� ��� ���� ����
		public bool downChecked = true;//�˻����� ��/�Ʒ� �˻����� �Ǵ�
		public bool lowerChecked = false;//�˻����� ��/�ҹ��� ���� �Ǵ�
		public int lineNum = 0;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.MenuItem menuItem3;
		public System.Windows.Forms.TextBox mainTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imageList1;//���� > �̵��޴��� �̵��� ���� ����
		private System.ComponentModel.IContainer components = null;
		public Form1()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuFileNew = new System.Windows.Forms.MenuItem();
            this.menuFileOpen = new System.Windows.Forms.MenuItem();
            this.menuFileSave = new System.Windows.Forms.MenuItem();
            this.menuFileNewSave = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuFilePage = new System.Windows.Forms.MenuItem();
            this.menuFilePrint = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuFileExit = new System.Windows.Forms.MenuItem();
            this.menuIEdit = new System.Windows.Forms.MenuItem();
            this.menuEditUndo = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuEditCut = new System.Windows.Forms.MenuItem();
            this.menuEditCopy = new System.Windows.Forms.MenuItem();
            this.menuEditPaste = new System.Windows.Forms.MenuItem();
            this.menuEditDelete = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuEditSearch = new System.Windows.Forms.MenuItem();
            this.menuEditNextSearch = new System.Windows.Forms.MenuItem();
            this.menuEditChange = new System.Windows.Forms.MenuItem();
            this.menuEditMove = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuEditSelectAll = new System.Windows.Forms.MenuItem();
            this.menuEditDateTime = new System.Windows.Forms.MenuItem();
            this.menuOption = new System.Windows.Forms.MenuItem();
            this.menuOptionLine = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuOptionFont = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuView = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuViewStatus = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuHelpList = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuHelpVersion = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuIEdit,
            this.menuOption,
            this.menuView,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileNewSave,
            this.menuItem10,
            this.menuFilePage,
            this.menuFilePrint,
            this.menuItem13,
            this.menuFileExit});
            this.menuFile.Text = "����(&F)";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Index = 0;
            this.menuFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuFileNew.Text = "���� �����(&N)";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Index = 1;
            this.menuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuFileOpen.Text = "����(&O)...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Index = 2;
            this.menuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuFileSave.Text = "����(&S)";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileNewSave
            // 
            this.menuFileNewSave.Index = 3;
            this.menuFileNewSave.Text = "�ٸ� �̸����� ����(&A)...";
            this.menuFileNewSave.Click += new System.EventHandler(this.menuFileNewSave_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 4;
            this.menuItem10.Text = "-";
            // 
            // menuFilePage
            // 
            this.menuFilePage.Index = 5;
            this.menuFilePage.Text = "������ ����(&U)...";
            this.menuFilePage.Click += new System.EventHandler(this.menuFilePage_Click);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Index = 6;
            this.menuFilePrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuFilePrint.Text = "�μ�(&P)...";
            this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 7;
            this.menuItem13.Text = "-";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Index = 8;
            this.menuFileExit.Text = "������(&X)";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuIEdit
            // 
            this.menuIEdit.Index = 1;
            this.menuIEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuEditUndo,
            this.menuItem16,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditDelete,
            this.menuItem21,
            this.menuEditSearch,
            this.menuEditNextSearch,
            this.menuEditChange,
            this.menuEditMove,
            this.menuItem26,
            this.menuEditSelectAll,
            this.menuEditDateTime});
            this.menuIEdit.Text = "����(&E)";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Enabled = false;
            this.menuEditUndo.Index = 0;
            this.menuEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.menuEditUndo.Text = "���� ���(&U)";
            this.menuEditUndo.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 1;
            this.menuItem16.Text = "-";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Enabled = false;
            this.menuEditCut.Index = 2;
            this.menuEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuEditCut.Text = "�߶󳻱�(&T)";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Enabled = false;
            this.menuEditCopy.Index = 3;
            this.menuEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuEditCopy.Text = "����(&C)";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Index = 4;
            this.menuEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuEditPaste.Text = "�ٿ��ֱ�(&P)";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuEditDelete
            // 
            this.menuEditDelete.Enabled = false;
            this.menuEditDelete.Index = 5;
            this.menuEditDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuEditDelete.Text = "����(&L)";
            this.menuEditDelete.Click += new System.EventHandler(this.menuEditDelete_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 6;
            this.menuItem21.Text = "-";
            // 
            // menuEditSearch
            // 
            this.menuEditSearch.Enabled = false;
            this.menuEditSearch.Index = 7;
            this.menuEditSearch.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.menuEditSearch.Text = "ã��(&F)...";
            this.menuEditSearch.Click += new System.EventHandler(this.menuEditSearch_Click);
            // 
            // menuEditNextSearch
            // 
            this.menuEditNextSearch.Enabled = false;
            this.menuEditNextSearch.Index = 8;
            this.menuEditNextSearch.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuEditNextSearch.Text = "���� ã��(&N)";
            this.menuEditNextSearch.Click += new System.EventHandler(this.menuEditNextSearch_Click);
            // 
            // menuEditChange
            // 
            this.menuEditChange.Index = 9;
            this.menuEditChange.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuEditChange.Text = "�ٲٱ�(&R)...";
            this.menuEditChange.Click += new System.EventHandler(this.menuEditChange_Click);
            // 
            // menuEditMove
            // 
            this.menuEditMove.Enabled = false;
            this.menuEditMove.Index = 10;
            this.menuEditMove.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.menuEditMove.Text = "�̵�(&G)...";
            this.menuEditMove.Click += new System.EventHandler(this.menuEditMove_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 11;
            this.menuItem26.Text = "-";
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Index = 12;
            this.menuEditSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuEditSelectAll.Text = "��� ����(&A)";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // menuEditDateTime
            // 
            this.menuEditDateTime.Index = 13;
            this.menuEditDateTime.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuEditDateTime.Text = "�ð�/��¥(&D)";
            this.menuEditDateTime.Click += new System.EventHandler(this.menuEditDateTime_Click);
            // 
            // menuOption
            // 
            this.menuOption.Index = 2;
            this.menuOption.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOptionLine,
            this.menuItem2,
            this.menuOptionFont,
            this.menuItem1});
            this.menuOption.Text = "����(&O)";
            // 
            // menuOptionLine
            // 
            this.menuOptionLine.Checked = true;
            this.menuOptionLine.Index = 0;
            this.menuOptionLine.Text = "�ڵ� �� �ٲ�(&W)";
            this.menuOptionLine.Click += new System.EventHandler(this.menuOptionLine_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuOptionFont
            // 
            this.menuOptionFont.Index = 2;
            this.menuOptionFont.Text = "�۲�(&F)...";
            this.menuOptionFont.Click += new System.EventHandler(this.menuOptionFont_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "����(&C)...";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuView
            // 
            this.menuView.Index = 3;
            this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuViewStatus});
            this.menuView.Text = "����(&V)";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "����(&T)";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuViewStatus
            // 
            this.menuViewStatus.Enabled = false;
            this.menuViewStatus.Index = 1;
            this.menuViewStatus.Text = "���� ǥ����(&S)";
            this.menuViewStatus.Click += new System.EventHandler(this.menuViewStatus_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 4;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelpList,
            this.menuItem33,
            this.menuHelpVersion});
            this.menuHelp.Text = "����(&H)";
            // 
            // menuHelpList
            // 
            this.menuHelpList.Index = 0;
            this.menuHelpList.Text = "���� �׸�(&H)";
            this.menuHelpList.Click += new System.EventHandler(this.menuHelpList_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 1;
            this.menuItem33.Text = "-";
            // 
            // menuHelpVersion
            // 
            this.menuHelpVersion.Index = 2;
            this.menuHelpVersion.Text = "�޸��� ����(&A)";
            this.menuHelpVersion.Click += new System.EventHandler(this.menuHelpVersion_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|��� ����|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|��� ����|*.*";
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 335);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(492, 26);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Visible = false;
            this.statusBar1.VisibleChanged += new System.EventHandler(this.statusBar1_VisibleChanged);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.MinWidth = 350;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "To. �׳࿡��...";
            this.statusBarPanel1.Width = 350;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel2.MinWidth = 2000;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 2000;
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton5});
            this.toolBar1.ButtonSize = new System.Drawing.Size(21, 21);
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(492, 23);
            this.toolBar1.TabIndex = 4;
            this.toolBar1.Visible = false;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.ToolTipText = "���� ���";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.ToolTipText = "�߶󳻱�";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.ToolTipText = "����";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.ToolTipText = "�ٿ��ֱ�";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 4;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.ToolTipText = "����";
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
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.HideSelection = false;
            this.mainTextBox.Location = new System.Drawing.Point(0, 0);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(492, 313);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            this.mainTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainTextBox_KeyUp);
            this.mainTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainTextBox_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 312);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.ClientSize = new System.Drawing.Size(492, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.statusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "���� ���� - �޸���";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// �ش� ���� ���α׷��� �� �������Դϴ�.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

		//�ؽ�Ʈ�ڽ� ��Ʈ���� ������ ���� �Ǹ�...
		private void mainTextBox_TextChanged(object sender, System.EventArgs e)
		{
			changeText = true;
			menuEditUndo.Enabled = true;
			if(mainTextBox.TextLength > 0)
			{
				menuEditSearch.Enabled = true;
				menuEditNextSearch.Enabled = true;
			}
			else
			{
				menuEditSearch.Enabled = false;
				menuEditNextSearch.Enabled = false;
				changeText = false;
			}
		}

		//�ؽ�Ʈ�ڽ� ���� ���濡 ���� ���콺 �̺�Ʈ
		private void mainTextBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			statusPos();
		}

		//�ؽ�Ʈ�ڽ� ���� ���濡 ���� Ű���� �̺�Ʈ
		private void mainTextBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			statusPos();
		}

		//���¹� ��Ʈ���� Ȱ��ȭ �Ǹ� ��ġ���� ������
		private void statusBar1_VisibleChanged(object sender, System.EventArgs e)
		{
			statusPos();
		}

		//���¹� ���� �� ǥ�� �޼ҵ�
		private void statusPos()
		{
			if(mainTextBox.SelectedText.Length > 0)//�޴����� Ȱ�� �� ��Ȱ�� �Ǵ�
			{
				menuEditCut.Enabled = true;
				menuEditCopy.Enabled = true;
				menuEditDelete.Enabled = true;
			}
			else
			{
				menuEditCut.Enabled = false;
				menuEditCopy.Enabled = false;
				menuEditDelete.Enabled = false;
			}

			if(statusBar1.Visible)//���¹ٰ� Ȱ��ȭ�Ǿ� ������ ���� �� ǥ��
			{
				int caretLine=1;//�� �ʱⰪ
				int caretCol=1;//�� �ʱⰪ
				int caretPos = mainTextBox.SelectionStart;//���� �ɷ��� ��ġ��
				char[] charText = mainTextBox.Text.ToCharArray();//�����ڵ� ���� �迭�� ��ȯ

				for(int i=0; i<caretPos; i++)//���� �ɷ� ��ġ���� �ݺ�
				{
					if(charText[i].ToString().Equals("\n"))
					{
						caretLine++;//���Ͱ��� ������ �ప�� 1����
						caretCol=1;//�ప�� 1�����ϸ� ���� 1�� �ٽ� �ʱ�ȭ
					}
					else
					{
						caretCol++;//���� ������ ������ 1����
					}
				}
				//���¹ٿ� ���
				this.statusBarPanel2.Text = "Ln "+caretLine+", Col "+caretCol;
			}
		}

		//���� > ���� �����
		private void menuFileNew_Click(object sender, System.EventArgs e)
		{
			if(changeText && mainTextBox.TextLength > 0)//�ؽ�Ʈ �ڽ� ���� �� ���� ���� 0���� ũ��...
			{
				messageChange();
				switch(result)
				{
					case DialogResult.Yes:
						menuFileSave_Click(sender, e);
						break;
					case DialogResult.No:
						allClear();
						break;
				}
			}
		allClear();
		}

		//���� > ����1
		private void menuFileOpen_Click(object sender, System.EventArgs e)
		{
			if(changeText)
			{
				messageChange();
				switch(result)
				{
					case DialogResult.Yes:
						menuFileSave_Click(sender, e);
						openFile();
						break;
					case DialogResult.No:
						openFile();
						break;
				}
			}
			else
			{
				openFile();
			}
		}

		//���� > ����2
		private void openFile()
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//���ϸ� �̾ƿ���
				string openSrc = openFileDialog1.FileName;
				int search = openSrc.LastIndexOf("\\");//��ü ���ϰ�ο��� ������ ������ ��ġ���� ��ȯ
				this.Text = openSrc.Substring(search+1);//�κ� ���ڿ��� ��ȯ
				//substring�� ���ڸ� 2�� ����� (���ڿ� ����[, ���ڿ� ��])

				//���� ����
				mainTextBox.Text = null;

				StreamReader sr = new StreamReader(openSrc, Encoding.Default);
				//stream ��ü�� ���� (���� ���, ���ڵ�) �� Default�� ANSI
				mainTextBox.Text = sr.ReadToEnd();
				sr.Close();//stream ��ü�� ����
				//stream��ü�� ���� ������� application�� ���� �ɶ����� �ش� ������ ���� �ֱ� ������ �ٸ� �۾��� ������ �� �� �����ϴ�.
				//�۾��� ������ �ݵ�� �ݾ� �ּž� �մϴ�.

				saveAs = true;
				changeText = false;
			}
		}

		//���� > ����
		private void menuFileSave_Click(object sender, System.EventArgs e)
		{
			if(saveAs && changeText)//������ ������ �ִٸ�...
			{
				StreamWriter sw;
				//���� ����
				if(openFileDialog1.FileName == null)
				{
					sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
				}
				else
				{
					sw = new StreamWriter(openFileDialog1.FileName, false, Encoding.Default);
				}
				//�� ������ ������ �� ������ ���¶�� �������� ��ġ�� ������
				sw.WriteLine(mainTextBox.Text);
				sw.Close();//stream��ü�� ����

				saveAs = true;
				changeText = false;
				//saveAs�� ������ ���� ������ �����Ҷ��� ����⸦ Ȯ���ϱ�
				//changeText�� �ؽ�Ʈ �ڽ��� ��ȭ�� ���ٸ� �������� ������ ���⳪ ���� ����⸦ ���� ������� ���̾˷α� â�� ����� ����
			}
			else//ó�� �����Ѵٸ�...
			{
				//�ٸ��̸����� ���� �̺�Ʈ �߻�
				menuFileNewSave_Click(sender, e);
			}
		}

		//���� > �ٸ��̸����� ����
		private void menuFileNewSave_Click(object sender, System.EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)//�ٸ��̸����� ����
			{
				//���ϸ� �̾ƿ���
				string saveSrc = saveFileDialog1.FileName;
				int search = saveSrc.LastIndexOf("\\");
				this.Text = saveSrc.Substring(search+1);

				//���� ����
				StreamWriter sw = new StreamWriter(saveSrc, false, Encoding.Default);
				sw.WriteLine(mainTextBox.Text);//���� ����
				sw.Close();//stream��ü ���� 

				saveAs = true;
				changeText = false;
			}
		}

		private void messageChange()
		{
			result = MessageBox.Show(this.Text+" ������ ������ ����Ǿ����ϴ�."+Environment.NewLine+Environment.NewLine+"����� ������ �����Ͻðڽ��ϱ�?","�޸���",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
		}

		private void allClear()
		{
			saveAs = false;//�⺻�� �ʱ�ȭ
			changeText = false;
			search = null;
			downChecked = true;
			lowerChecked = false;
			mainTextBox.Text = null;
			this.Text = "���� ���� - �޸���";
		}
		
		//���� > ������ ����
		private void menuFilePage_Click(object sender, System.EventArgs e)
		{
			pageSetupDialog1.ShowDialog();//������ �¾� ���̾˷α� â�� ���
		}

		//���� > �μ�
		private void menuFilePrint_Click(object sender, System.EventArgs e)
		{
			if(printDialog1.ShowDialog() == DialogResult.OK)//�μ��ϱ⸦ ������ ���
			{
				printDocument1.Print();//printDocument1�� ����Ʈ ����
			}
		}

		//�μ��� ������ ��
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			String textPrint = mainTextBox.Text;//�μ��� �ؽ�Ʈ
			Font printFont = new Font(mainTextBox.Font.Name, mainTextBox.Font.Size);//��Ʈ ����
			int leftMargin = e.MarginBounds.Left;//pagesetup�̺�Ʈ ������ �޾ƿ�
			int topMargin = e.MarginBounds.Top;
			e.Graphics.DrawString(textPrint, printFont, Brushes.Black, leftMargin, topMargin);
			//�׷��Ƚ� ��ü�� ��ο콺Ʈ�� �޼ҵ带 ����ؼ� ���� �ؽ�Ʈ�� �׷���
		}

		//���� > ������
		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			if(changeText && mainTextBox.TextLength > 0)
			{
				messageChange();
				switch(result)
				{
					case DialogResult.Yes://�ؽ�Ʈ �ڽ��� ����ǰ� �޼��� �ڽ����� �����ϱ⸦ �����ϸ�...
						menuFileSave_Click(sender, e);
						Application.Exit();
						break;
					case DialogResult.No://�ƴϿ��� �����ϸ� ���ø����̼� ����
						Application.Exit();
						break;
				}
			}
			else
			{
				Application.Exit();
			}
		}

		//���� X���߸� Ŭ��������...
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(changeText && mainTextBox.TextLength > 0)
			{
				messageChange();
				switch(result)
				{
					case DialogResult.Yes://���� > ������� ����
						menuFileSave_Click(sender, e);
						break;
					case DialogResult.Cancel://���⼭�� �ƴϿ��� �ƴ϶� ��Ҹ� ������ ���
						e.Cancel = true;//���ø����̼� ���Ḧ ��ҽ�Ŵ
						//closed�� ���� ���� �Ŀ� �̺�Ʈ �߻�
						//closing�� ���� ������ ���� �̺�Ʈ �߻�
						break;
				}
			}
		}

		//���� > ���� ���
		private void menuEditUndo_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Undo();
		}

		//���� > �߶󳻱�
		private void menuEditCut_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Cut();
		}

		//���� > ����
		private void menuEditCopy_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Copy();
		}

		//���� > �ٿ��ֱ�
		private void menuEditPaste_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Paste();
		}

		//���� > ����
		private void menuEditDelete_Click(object sender, System.EventArgs e)
		{
			mainTextBox.SelectedText = "";
		}

		//���� > ã��
		private void menuEditSearch_Click(object sender, System.EventArgs e)
		{
			search searchText = new search(this);
			searchText.Show();
		}

		//���� > ����ã��
		private void menuEditNextSearch_Click(object sender, System.EventArgs e)
		{
			if(search == null)//�˻��� �ѹ��� �õ��� ���� ���ٸ�...
			{
				menuEditSearch_Click(sender, e);//�˻�â ���̾˷α׸� �����
			}
			else//�˻��� ���ڰ� �ִٸ�...
			{
				int searchLength;//�˻��� ������ ��
				int searchStart;//�˻� ���� ��ġ
				int searchLocation;//�˻��� ������ ��ġ
				string  textLower;//��/�ҹ��� ���п� üũ�� �Ǿ� ������ �ش� ���ڿ��� �ҹ��ڷ� ��ȯ

				if(lowerChecked)//��/�ҹ��� ������ �Ѵٸ�...
				{
					textLower = mainTextBox.Text;
				}
				else//��/�ҹ��� ������ ���Ѵٸ�...
				{
					search = search.ToLower();//�˻�� �ҹ��ڷ� ��ȯ
					textLower = mainTextBox.Text.ToLower();//��ü ���ڸ� �ҹ��ڷ� ��ȯ
				}

				searchLength = search.Length;

				if(mainTextBox.SelectedText.Length > 0)//�� ���ڶ� ������ ������ �Ǿ� �ִٸ�...
				{
					searchStart = mainTextBox.SelectionStart+searchLength;
					//�ɷ� ��ġ���� �˻����� ���̸� ���� ��ġ���� �˻�
				}
				else
				{
					searchStart = mainTextBox.SelectionStart;
					//�ɷ� ��ġ�������� �˻�
				}

				//searchStart = mainTextBox.SelectionStart+searchLength;

				if(downChecked)//�Ʒ��� �˻��� üũ�Ǿ� �ִٸ�...
				{
					searchLocation = textLower.IndexOf(search, searchStart);
				}
				else//���� �˻��� üũ�Ǿ� �ִٸ�...
				{
					int st = mainTextBox.SelectionStart;
					string lastSearch = textLower.Remove(st, mainTextBox.TextLength-st);
					//�˻��� ��ġ�� ������ �̵��ؾ� �ϱ� ������ �ɷ� ��ġ���� ���ʱ����� ���ڿ��� ������ �� �� ��ġ���� �ٽ� ��ȯ��ŵ�ϴ�.
					searchLocation = lastSearch.LastIndexOf(search);
					//������ �Ǿ��� ���ڿ� ������ ������ ��ġ���� �˻�� ã�Ƽ� ��ġ���� ��ȯ
				}

				if(searchLocation >= 0)//�˻��� ���ڰ� �ִٸ�...
				//�� searchLocation�� indexof�� lastindexof���� �˻����� ��ġ���� �޾� ������ �˻�� ���ٸ� -1�� ��ȯ ���ݴϴ�.
				//�׷��� searchLocation�� 0���� ũ�ٸ� �˻�� �ִ°��Դϴ�.
				{
					mainTextBox.Select(searchLocation, searchLength);
					mainTextBox.ScrollToCaret();//���õ� ���ڰ� ���� �ۿ� �ִٸ� �ɷ��� ��ũ�� ������
				}
				else//searchLocation�� -1���� ������ ������ �ٽ� ���ؼ� �˻�� ���ٸ�...
				{
					MessageBox.Show("\""+search+"\"��(��) ã�� �� �����ϴ�.","�޸���",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				}
			}
		}

		//���� > �ٲٱ�
		private void menuEditChange_Click(object sender, System.EventArgs e)
		{
			change changeText = new change(this);
			changeText.Show();
		}

		//���� > �̵�
		private void menuEditMove_Click(object sender, System.EventArgs e)
		{
			move linemove = new move(this);
			DialogResult result = linemove.ShowDialog();

			if(result == DialogResult.OK)//�̵��� ���� �ѹ��� �Է��� �� Ȯ�ι�ư�� ������...
			{
				if(lineNum > 1)
				{
					lineNum = lineNum-1;

					int caretLine=0;
					int caretPos = mainTextBox.TextLength;//�ؽ�Ʈ�ڽ��� ��ü ���ڿ� ���̸� ��ȯ
					char[] charText = mainTextBox.Text.ToCharArray();//��ü ���ڸ� �����ڵ� �迭�� ����

					for(int i=0; i<caretPos; i++)//ó������ ���ڿ� ������ �˻�
					{
						if(charText[i].ToString().Equals("\n"))
						{
							caretLine++;
							if(caretLine == (lineNum))//�̵��� ���ΰ� ���� ������ ������...
							{
								mainTextBox.SelectionStart = i+1;//�ɷ��� ��ġ�� �ݺ��� ��ġ(i)�� �̵���Ų �� �ݺ��� Ż��
								break;
							}
						}
					}
				}
				else
				{
					mainTextBox.SelectionStart = 0;
				}
			}
		}

		//���� > ��ü ����
		private void menuEditSelectAll_Click(object sender, System.EventArgs e)
		{
			this.mainTextBox.SelectAll();
		}

		//���� > �ð�/��¥
		private void menuEditDateTime_Click(object sender, System.EventArgs e)
		{
			//insert�޼ҵ带 ����ؼ� �ɷ��� ��ġ�� ��¥���� ����
			mainTextBox.Text = mainTextBox.Text.Insert(mainTextBox.SelectionStart, DateTime.Now.ToString());
		}

		//�ɼ� > �ڵ� �� �ٲ�
		private void menuOptionLine_Click(object sender, System.EventArgs e)
		{
			if(this.menuOptionLine.Checked)
			{
				this.menuOptionLine.Checked = false;
				this.mainTextBox.WordWrap = false;

				this.menuEditMove.Enabled = true;
				this.menuViewStatus.Enabled = true;
			}
			else
			{
				this.menuOptionLine.Checked = true;
				this.mainTextBox.WordWrap = true;

				this.menuEditMove.Enabled = false;
				this.menuViewStatus.Enabled = false;
				this.menuViewStatus.Checked = false;
				this.statusBar1.Visible = false;
			}
		}

		//�ɼ� > �۲�
		private void menuOptionFont_Click(object sender, System.EventArgs e)
		{
			fontDialog1.ShowDialog();
			mainTextBox.Font = fontDialog1.Font;
		}

		//�ɼ� > ����
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			colorDialog1.ShowDialog();
			mainTextBox.ForeColor = colorDialog1.Color;
		}

		//���� > ����
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if(this.menuItem3.Checked)
			{
				this.menuItem3.Checked = false;
				this.toolBar1.Visible = false;
			}
			else
			{
				this.menuItem3.Checked = true;
				this.toolBar1.Visible = true;
			}
		}

		//���� �÷��� �̺�Ʈ
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (toolBar1.Buttons.IndexOf(e.Button))
			{
				case 0 :
					mainTextBox.Undo();
					break;
				case 1 :
					mainTextBox.Cut();
					break;
				case 2 :
					mainTextBox.Copy();
					break;
				case 3 :
					mainTextBox.Paste();
					break;
				case 4 :
					mainTextBox.SelectedText = "";
					break;
			}
		}

		//���� > ���� ǥ����
		private void menuViewStatus_Click(object sender, System.EventArgs e)
		{
			if(this.menuViewStatus.Checked)
			{
				this.menuViewStatus.Checked = false;
				this.statusBar1.Visible = false;
			}
			else
			{
				this.menuViewStatus.Checked = true;
				this.statusBar1.Visible = true;
			}
		}

		//���� ������ ����� ���¹� �г�1, 2�� ������ 7:3���� ��������
		private void Form1_SizeChanged(object sender, System.EventArgs e)
		{
			int formsize = this.Size.Width;
			this.statusBarPanel1.MinWidth = ((formsize*70)/100);
			this.statusBarPanel2.MinWidth = ((formsize*30)/100);
		}

		//�޸��� ����
		private void menuHelpList_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("���� ����� ������^^;", "����");
		}

		//�޸��� ����
		private void menuHelpVersion_Click(object sender, System.EventArgs e)
		{
			info infomation = new info();
			infomation.Show();
		}
	}
}