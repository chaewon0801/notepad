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
	/// Form1에 대한 요약 설명입니다.
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

		private DialogResult result;//메세지 박스의 예/아니오/취소 선택 변수
		private bool saveAs = false;//덮어쓰기/쓰기 판단
		private bool changeText = false;//텍스트박스의 변경 판단
		public string search = null;//검색어를 담기 위한 변수
		public bool downChecked = true;//검색에서 위/아래 검색방향 판단
		public bool lowerChecked = false;//검색에서 대/소문자 구분 판단
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
		private System.Windows.Forms.ImageList imageList1;//편집 > 이동메뉴의 이동할 라인 변수
		private System.ComponentModel.IContainer components = null;
		public Form1()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
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
            this.menuFile.Text = "파일(&F)";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Index = 0;
            this.menuFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuFileNew.Text = "새로 만들기(&N)";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Index = 1;
            this.menuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuFileOpen.Text = "열기(&O)...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Index = 2;
            this.menuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuFileSave.Text = "저장(&S)";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileNewSave
            // 
            this.menuFileNewSave.Index = 3;
            this.menuFileNewSave.Text = "다른 이름으로 저장(&A)...";
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
            this.menuFilePage.Text = "페이지 설정(&U)...";
            this.menuFilePage.Click += new System.EventHandler(this.menuFilePage_Click);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Index = 6;
            this.menuFilePrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuFilePrint.Text = "인쇄(&P)...";
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
            this.menuFileExit.Text = "끝내기(&X)";
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
            this.menuIEdit.Text = "편집(&E)";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Enabled = false;
            this.menuEditUndo.Index = 0;
            this.menuEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.menuEditUndo.Text = "실행 취소(&U)";
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
            this.menuEditCut.Text = "잘라내기(&T)";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Enabled = false;
            this.menuEditCopy.Index = 3;
            this.menuEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuEditCopy.Text = "복사(&C)";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Index = 4;
            this.menuEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuEditPaste.Text = "붙여넣기(&P)";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuEditDelete
            // 
            this.menuEditDelete.Enabled = false;
            this.menuEditDelete.Index = 5;
            this.menuEditDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuEditDelete.Text = "삭제(&L)";
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
            this.menuEditSearch.Text = "찾기(&F)...";
            this.menuEditSearch.Click += new System.EventHandler(this.menuEditSearch_Click);
            // 
            // menuEditNextSearch
            // 
            this.menuEditNextSearch.Enabled = false;
            this.menuEditNextSearch.Index = 8;
            this.menuEditNextSearch.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuEditNextSearch.Text = "다음 찾기(&N)";
            this.menuEditNextSearch.Click += new System.EventHandler(this.menuEditNextSearch_Click);
            // 
            // menuEditChange
            // 
            this.menuEditChange.Index = 9;
            this.menuEditChange.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuEditChange.Text = "바꾸기(&R)...";
            this.menuEditChange.Click += new System.EventHandler(this.menuEditChange_Click);
            // 
            // menuEditMove
            // 
            this.menuEditMove.Enabled = false;
            this.menuEditMove.Index = 10;
            this.menuEditMove.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.menuEditMove.Text = "이동(&G)...";
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
            this.menuEditSelectAll.Text = "모두 선택(&A)";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // menuEditDateTime
            // 
            this.menuEditDateTime.Index = 13;
            this.menuEditDateTime.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuEditDateTime.Text = "시간/날짜(&D)";
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
            this.menuOption.Text = "서식(&O)";
            // 
            // menuOptionLine
            // 
            this.menuOptionLine.Checked = true;
            this.menuOptionLine.Index = 0;
            this.menuOptionLine.Text = "자동 줄 바꿈(&W)";
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
            this.menuOptionFont.Text = "글꼴(&F)...";
            this.menuOptionFont.Click += new System.EventHandler(this.menuOptionFont_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "색상(&C)...";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuView
            // 
            this.menuView.Index = 3;
            this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuViewStatus});
            this.menuView.Text = "보기(&V)";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "툴바(&T)";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuViewStatus
            // 
            this.menuViewStatus.Enabled = false;
            this.menuViewStatus.Index = 1;
            this.menuViewStatus.Text = "상태 표시줄(&S)";
            this.menuViewStatus.Click += new System.EventHandler(this.menuViewStatus_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 4;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelpList,
            this.menuItem33,
            this.menuHelpVersion});
            this.menuHelp.Text = "도움말(&H)";
            // 
            // menuHelpList
            // 
            this.menuHelpList.Index = 0;
            this.menuHelpList.Text = "도움말 항목(&H)";
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
            this.menuHelpVersion.Text = "메모장 정보(&A)";
            this.menuHelpVersion.Click += new System.EventHandler(this.menuHelpVersion_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";
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
            this.statusBarPanel1.Text = "To. 그녀에게...";
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
            this.toolBarButton1.ToolTipText = "실행 취소";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.ToolTipText = "잘라내기";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.ToolTipText = "복사";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.ToolTipText = "붙여넣기";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 4;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.ToolTipText = "삭제";
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
            this.Text = "제목 없음 - 메모장";
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
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

		//텍스트박스 컨트롤의 내용이 변경 되면...
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

		//텍스트박스 내용 변경에 대한 마우스 이벤트
		private void mainTextBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			statusPos();
		}

		//텍스트박스 내용 변경에 대한 키보드 이벤트
		private void mainTextBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			statusPos();
		}

		//상태바 컨트롤이 활성화 되면 위치값을 가져옴
		private void statusBar1_VisibleChanged(object sender, System.EventArgs e)
		{
			statusPos();
		}

		//상태바 열과 행 표시 메소드
		private void statusPos()
		{
			if(mainTextBox.SelectedText.Length > 0)//메뉴들의 활성 및 비활성 판단
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

			if(statusBar1.Visible)//상태바가 활성화되어 있으면 열과 행 표시
			{
				int caretLine=1;//행 초기값
				int caretCol=1;//열 초기값
				int caretPos = mainTextBox.SelectionStart;//현재 케럿의 위치값
				char[] charText = mainTextBox.Text.ToCharArray();//유니코드 문자 배열로 변환

				for(int i=0; i<caretPos; i++)//현재 케럿 위치까지 반복
				{
					if(charText[i].ToString().Equals("\n"))
					{
						caretLine++;//엔터값이 있으면 행값을 1증가
						caretCol=1;//행값이 1증가하면 열은 1로 다시 초기화
					}
					else
					{
						caretCol++;//행이 없으면 열값을 1증가
					}
				}
				//상태바에 출력
				this.statusBarPanel2.Text = "Ln "+caretLine+", Col "+caretCol;
			}
		}

		//파일 > 새로 만들기
		private void menuFileNew_Click(object sender, System.EventArgs e)
		{
			if(changeText && mainTextBox.TextLength > 0)//텍스트 박스 변경 및 글자 수가 0보다 크면...
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

		//파일 > 열기1
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

		//파일 > 열기2
		private void openFile()
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//파일명만 뽑아오기
				string openSrc = openFileDialog1.FileName;
				int search = openSrc.LastIndexOf("\\");//전체 파일경로에서 지정된 문자의 위치값을 반환
				this.Text = openSrc.Substring(search+1);//부분 문자열을 반환
				//substring은 인자를 2개 사용함 (문자열 시작[, 문자열 끝])

				//파일 오픈
				mainTextBox.Text = null;

				StreamReader sr = new StreamReader(openSrc, Encoding.Default);
				//stream 개체를 생성 (파일 경로, 인코딩) ※ Default는 ANSI
				mainTextBox.Text = sr.ReadToEnd();
				sr.Close();//stream 개체를 닫음
				//stream개체를 닫지 않을경우 application이 종료 될때까지 해당 파일을 물고 있기 때문에 다른 작업이 접근을 할 수 없습니다.
				//작업이 끝나면 반드시 닫아 주셔야 합니다.

				saveAs = true;
				changeText = false;
			}
		}

		//파일 > 저장
		private void menuFileSave_Click(object sender, System.EventArgs e)
		{
			if(saveAs && changeText)//저장을 한적이 있다면...
			{
				StreamWriter sw;
				//덮어 쓰기
				if(openFileDialog1.FileName == null)
				{
					sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
				}
				else
				{
					sw = new StreamWriter(openFileDialog1.FileName, false, Encoding.Default);
				}
				//새 파일을 저장한 후 수정한 상태라면 저장파일 위치를 가져옴
				sw.WriteLine(mainTextBox.Text);
				sw.Close();//stream개체를 닫음

				saveAs = true;
				changeText = false;
				//saveAs는 파일을 쓰면 다음에 저장할때는 덮어쓰기를 확인하기
				//changeText는 텍스트 박스에 변화가 없다면 저장하지 않으며 열기나 새로 만들기를 선택 했을경우 다이알로그 창을 띄우지 않음
			}
			else//처음 저장한다면...
			{
				//다른이름으로 저장 이벤트 발생
				menuFileNewSave_Click(sender, e);
			}
		}

		//파일 > 다른이름으로 저장
		private void menuFileNewSave_Click(object sender, System.EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)//다른이름으로 저장
			{
				//파일명만 뽑아오기
				string saveSrc = saveFileDialog1.FileName;
				int search = saveSrc.LastIndexOf("\\");
				this.Text = saveSrc.Substring(search+1);

				//파일 쓰기
				StreamWriter sw = new StreamWriter(saveSrc, false, Encoding.Default);
				sw.WriteLine(mainTextBox.Text);//파일 쓰기
				sw.Close();//stream개체 닫음 

				saveAs = true;
				changeText = false;
			}
		}

		private void messageChange()
		{
			result = MessageBox.Show(this.Text+" 파일의 내용이 변경되었습니다."+Environment.NewLine+Environment.NewLine+"변경된 내용을 저장하시겠습니까?","메모장",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
		}

		private void allClear()
		{
			saveAs = false;//기본값 초기화
			changeText = false;
			search = null;
			downChecked = true;
			lowerChecked = false;
			mainTextBox.Text = null;
			this.Text = "제목 없음 - 메모장";
		}
		
		//파일 > 페이지 설정
		private void menuFilePage_Click(object sender, System.EventArgs e)
		{
			pageSetupDialog1.ShowDialog();//페이지 셋업 아이알로그 창을 띄움
		}

		//파일 > 인쇄
		private void menuFilePrint_Click(object sender, System.EventArgs e)
		{
			if(printDialog1.ShowDialog() == DialogResult.OK)//인쇄하기를 선택할 경우
			{
				printDocument1.Print();//printDocument1을 프린트 시작
			}
		}

		//인쇄할 페이지 값
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			String textPrint = mainTextBox.Text;//인쇄할 텍스트
			Font printFont = new Font(mainTextBox.Font.Name, mainTextBox.Font.Size);//폰트 정보
			int leftMargin = e.MarginBounds.Left;//pagesetup이벤트 정보를 받아옴
			int topMargin = e.MarginBounds.Top;
			e.Graphics.DrawString(textPrint, printFont, Brushes.Black, leftMargin, topMargin);
			//그래픽스 개체의 드로우스트링 메소드를 사용해서 실제 텍스트를 그려줌
		}

		//파일 > 끝내기
		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			if(changeText && mainTextBox.TextLength > 0)
			{
				messageChange();
				switch(result)
				{
					case DialogResult.Yes://텍스트 박스가 변경되고 메세지 박스에서 저장하기를 선택하면...
						menuFileSave_Click(sender, e);
						Application.Exit();
						break;
					case DialogResult.No://아니오를 선택하면 어플리케이션 종료
						Application.Exit();
						break;
				}
			}
			else
			{
				Application.Exit();
			}
		}

		//폼의 X단추를 클릭했을때...
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(changeText && mainTextBox.TextLength > 0)
			{
				messageChange();
				switch(result)
				{
					case DialogResult.Yes://파일 > 끝내기와 같음
						menuFileSave_Click(sender, e);
						break;
					case DialogResult.Cancel://여기서는 아니오가 아니라 취소를 선택할 경우
						e.Cancel = true;//어플리케이션 종료를 취소시킴
						//closed는 폼이 닫힌 후에 이벤트 발생
						//closing는 폼이 닫히기 전에 이벤트 발생
						break;
				}
			}
		}

		//편집 > 실행 취소
		private void menuEditUndo_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Undo();
		}

		//편집 > 잘라내기
		private void menuEditCut_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Cut();
		}

		//편집 > 복사
		private void menuEditCopy_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Copy();
		}

		//편집 > 붙여넣기
		private void menuEditPaste_Click(object sender, System.EventArgs e)
		{
			mainTextBox.Paste();
		}

		//편집 > 삭제
		private void menuEditDelete_Click(object sender, System.EventArgs e)
		{
			mainTextBox.SelectedText = "";
		}

		//편집 > 찾기
		private void menuEditSearch_Click(object sender, System.EventArgs e)
		{
			search searchText = new search(this);
			searchText.Show();
		}

		//편집 > 다음찾기
		private void menuEditNextSearch_Click(object sender, System.EventArgs e)
		{
			if(search == null)//검색을 한번도 시도한 적이 없다면...
			{
				menuEditSearch_Click(sender, e);//검색창 다이알로그를 띄워줌
			}
			else//검색한 문자가 있다면...
			{
				int searchLength;//검색할 문자의 수
				int searchStart;//검색 시작 위치
				int searchLocation;//검색된 문자의 위치
				string  textLower;//대/소문자 구분에 체크가 되어 있으면 해당 문자열을 소문자로 변환

				if(lowerChecked)//대/소문자 구분을 한다면...
				{
					textLower = mainTextBox.Text;
				}
				else//대/소문자 구분을 안한다면...
				{
					search = search.ToLower();//검색어를 소문자로 변환
					textLower = mainTextBox.Text.ToLower();//전체 문자를 소문자로 변환
				}

				searchLength = search.Length;

				if(mainTextBox.SelectedText.Length > 0)//한 문자라도 블럭으로 선택이 되어 있다면...
				{
					searchStart = mainTextBox.SelectionStart+searchLength;
					//케럿 위치에서 검색어의 길이를 더한 위치부터 검색
				}
				else
				{
					searchStart = mainTextBox.SelectionStart;
					//케럿 위치에서부터 검색
				}

				//searchStart = mainTextBox.SelectionStart+searchLength;

				if(downChecked)//아래로 검색이 체크되어 있다면...
				{
					searchLocation = textLower.IndexOf(search, searchStart);
				}
				else//위로 검색이 체크되어 있다면...
				{
					int st = mainTextBox.SelectionStart;
					string lastSearch = textLower.Remove(st, mainTextBox.TextLength-st);
					//검색할 위치가 앞으로 이동해야 하기 때문에 케럿 위치부터 뒤쪽까지의 문자열을 삭제한 후 그 위치값을 다시 반환시킵니다.
					searchLocation = lastSearch.LastIndexOf(search);
					//삭제가 되어진 문자열 길이의 마지막 위치부터 검색어를 찾아서 위치값을 반환
				}

				if(searchLocation >= 0)//검색된 문자가 있다면...
				//※ searchLocation은 indexof와 lastindexof에서 검색어의 위치값을 받아 오지만 검색어가 없다면 -1을 반환 해줍니다.
				//그래서 searchLocation이 0보다 크다면 검색어가 있는것입니다.
				{
					mainTextBox.Select(searchLocation, searchLength);
					mainTextBox.ScrollToCaret();//선택된 문자가 범위 밖에 있다면 케럿을 스크롤 시켜줌
				}
				else//searchLocation이 -1값을 가지고 있으면 다시 말해서 검색어가 없다면...
				{
					MessageBox.Show("\""+search+"\"을(를) 찾을 수 없습니다.","메모장",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				}
			}
		}

		//편집 > 바꾸기
		private void menuEditChange_Click(object sender, System.EventArgs e)
		{
			change changeText = new change(this);
			changeText.Show();
		}

		//편집 > 이동
		private void menuEditMove_Click(object sender, System.EventArgs e)
		{
			move linemove = new move(this);
			DialogResult result = linemove.ShowDialog();

			if(result == DialogResult.OK)//이동할 라인 넘버를 입력한 후 확인버튼을 누르면...
			{
				if(lineNum > 1)
				{
					lineNum = lineNum-1;

					int caretLine=0;
					int caretPos = mainTextBox.TextLength;//텍스트박스의 전체 문자열 길이를 반환
					char[] charText = mainTextBox.Text.ToCharArray();//전체 문자를 유니코드 배열에 복사

					for(int i=0; i<caretPos; i++)//처음부터 문자열 끝까지 검사
					{
						if(charText[i].ToString().Equals("\n"))
						{
							caretLine++;
							if(caretLine == (lineNum))//이동할 라인과 같은 라인이 나오면...
							{
								mainTextBox.SelectionStart = i+1;//케럿의 위치를 반복한 위치(i)로 이동시킨 후 반복을 탈출
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

		//편집 > 전체 선택
		private void menuEditSelectAll_Click(object sender, System.EventArgs e)
		{
			this.mainTextBox.SelectAll();
		}

		//편집 > 시간/날짜
		private void menuEditDateTime_Click(object sender, System.EventArgs e)
		{
			//insert메소드를 사용해서 케럿의 위치에 날짜값을 삽입
			mainTextBox.Text = mainTextBox.Text.Insert(mainTextBox.SelectionStart, DateTime.Now.ToString());
		}

		//옵션 > 자동 줄 바꿈
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

		//옵션 > 글꼴
		private void menuOptionFont_Click(object sender, System.EventArgs e)
		{
			fontDialog1.ShowDialog();
			mainTextBox.Font = fontDialog1.Font;
		}

		//옵션 > 색상
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			colorDialog1.ShowDialog();
			mainTextBox.ForeColor = colorDialog1.Color;
		}

		//보기 > 툴바
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

		//툴바 컬렉션 이벤트
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

		//보기 > 상태 표시줄
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

		//폼의 사이즈 변경시 상태바 패널1, 2의 비율을 7:3으로 조정해줌
		private void Form1_SizeChanged(object sender, System.EventArgs e)
		{
			int formsize = this.Size.Width;
			this.statusBarPanel1.MinWidth = ((formsize*70)/100);
			this.statusBarPanel2.MinWidth = ((formsize*30)/100);
		}

		//메모장 도움말
		private void menuHelpList_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("직접 만들어 보세요^^;", "도움말");
		}

		//메모장 정보
		private void menuHelpVersion_Click(object sender, System.EventArgs e)
		{
			info infomation = new info();
			infomation.Show();
		}
	}
}