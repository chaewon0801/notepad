using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Text;

namespace notepad
{
	/// <summary>
	/// search에 대한 요약 설명입니다.
	/// </summary>
	public class search : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;

		Form1 f1;//메인폼 변수 선언

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public search(Form1 frm)//인자로 매인폼을 받아옴
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();
			f1 = frm;//매인폼 초기화
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
				if(components != null)
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
			this.label1 = new System.Windows.Forms.Label();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "찾을 내용(&N):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(104, 7);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(224, 21);
			this.searchTextBox.TabIndex = 1;
			this.searchTextBox.Text = "";
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(336, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "다음 찾기(&F)";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(336, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "취소";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 55);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "대/소문자 구분(&C)";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(144, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 40);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "방향";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(86, 14);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(90, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "아래로(&D)";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(9, 14);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(79, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "위로(&U)";
			// 
			// search
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(432, 85);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "search";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "찾기";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.search_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//검색을 시도한 적이 있다면...
		private void search_Load(object sender, System.EventArgs e)
		{
			this.searchTextBox.Text = this.f1.search;//검색어를 입력해줌
			this.checkBox1.Checked = this.f1.lowerChecked;//대/소문자 선택
			
			if(this.f1.downChecked)//아래로 검색인지 위로 검색인지를 선택
			{
				this.radioButton2.Checked = true;
			}
			else
			{
				this.radioButton1.Checked = true;
			}
		}

		//검색 버튼 활성화
		private void searchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if(searchTextBox.TextLength > 0)
			{
				button1.Enabled = true;
			}
			else
			{
				button1.Enabled = false;
			}
		}

		//검색
		private void button1_Click(object sender, System.EventArgs e)
		{
			string searchText;//검색할 문자
			int searchLength;//검색할 문자의 수
			int searchStart;//검색 시작 위치
			int searchLocation;//검색된 문자의 위치
			string  textLower;//대/소문자 구분

			if(checkBox1.Checked)//대/소문자 구분을 한다면...
			{
				searchText = this.searchTextBox.Text;
				textLower = this.f1.mainTextBox.Text;
			}
			else//대/소문자 구분을 안한다면...
			{
				searchText = this.searchTextBox.Text.ToLower();
				textLower = this.f1.mainTextBox.Text.ToLower();
			}

			searchLength = searchText.Length;

			if(this.f1.mainTextBox.SelectedText.Length > 0)//선택되어진 글자가 있다면...
			{
				searchStart = this.f1.mainTextBox.SelectionStart+searchLength;//다음검색을 위해서 검색문자의 길이를 더해줌
			}
			else//스타트 위치가 검색어 글자 수 보다 작을 경우
			{
				searchStart = this.f1.mainTextBox.SelectionStart;//케럿 위치부터 검색
			}

			if(radioButton2.Checked)//정방향 검색
			{
				searchLocation = textLower.IndexOf(searchText, searchStart);
			}
			else//역방향 검색
			{
				string lastSearch = textLower.Remove(this.f1.mainTextBox.SelectionStart, this.f1.mainTextBox.TextLength-this.f1.mainTextBox.SelectionStart);
				searchLocation = lastSearch.LastIndexOf(searchText);
			}
				
			if(searchLocation >= 0)
			{
				this.f1.mainTextBox.Select(searchLocation, searchLength);
				this.f1.mainTextBox.ScrollToCaret();
			}
			else
			{
				MessageBox.Show("\""+searchText+"\"을(를) 찾을 수 없습니다.","메모장",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}

			//체크한 후 한번이라도 검색을 하면 아래 정보를 메인폼에 넘겨줌
			this.f1.search = searchText;
			this.f1.downChecked = radioButton2.Checked;
			this.f1.lowerChecked = checkBox1.Checked;
		}

		//닫기
		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
