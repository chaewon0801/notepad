using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace notepad
{
	/// <summary>
	/// change에 대한 요약 설명입니다.
	/// </summary>
	public class change : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;

		private string searchText;//검색할 문자
		private int searchLength;//검색할 문자의 수
		private int search2Length;//바꿀 문자의 수
		private int searchStart;//검색 시작 위치
		private int searchLocation;//검색된 문자의 위치
		private string  textLower;//대/소문자 구분
		Form1 f1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public change(Form1 frm)
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();
			f1 = frm;
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
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "찾을 내용(&N):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "바꿀 내용(&P):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 89);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "대/소문자 구분(&C)";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 21);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 37);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(192, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(304, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "다음 찾기(&F)";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(304, 37);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "바꾸기(&R)";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(304, 65);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "모두 바꾸기(&A)";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(304, 93);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 23);
			this.button4.TabIndex = 8;
			this.button4.Text = "취소";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// change
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 125);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "change";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "바꾸기";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.change_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void change_Load(object sender, System.EventArgs e)
		{
			this.textBox1.Text = this.f1.search;
			this.checkBox1.Checked = this.f1.lowerChecked;
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(this.textBox1.TextLength > 0)
			{
				this.button1.Enabled = true;
				this.button2.Enabled = true;
				this.button3.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
				this.button2.Enabled = false;
				this.button3.Enabled = false;			
			}
		}

		//다음 찾기 버튼
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)//대/소문자 구분을 한다면...
			{
				searchText = this.textBox1.Text;
				textLower = this.f1.mainTextBox.Text;
			}
			else//대/소문자 구분을 안한다면...
			{
				searchText = this.textBox1.Text.ToLower();
				textLower = this.f1.mainTextBox.Text.ToLower();
			}

			searchLength = searchText.Length;
			search2Length = this.textBox2.TextLength;

			int ssLength = this.f1.mainTextBox.SelectionStart;
			if(this.f1.mainTextBox.SelectedText.Length > 0)//선택되어진 글자가 있다면...
			{
				if(searchLength > search2Length)
				{
					searchStart = ssLength+search2Length;//바꿀문자가 검색문자보다 길다면 바꿀 문자의 길이를 더해줌
				}
				else
				{
					searchStart = ssLength+searchLength;//다음검색을 위해서 검색문자의 길이를 더해줌
				}
			}
			else//스타트 위치가 검색어 글자 수 보다 작을 경우
			{
				searchStart = ssLength;//케럿 위치부터 검색
			}

			searchLocation = textLower.IndexOf(searchText, searchStart);//문자열 검색

			if(searchLocation >= 0)//검색된 문자가 있다면...
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
			this.f1.lowerChecked = checkBox1.Checked;
		}

		//바꾸기 버튼
		private void button2_Click(object sender, System.EventArgs e)
		{
			button1_Click(sender, e);

			if(searchLocation >= 0)//검색된 문자가 있다면...
			{
				//메인폼의 텍스트박스에 선택된 문자를 Replace를 사용하여 바꿔줌
				this.f1.mainTextBox.SelectedText = this.f1.mainTextBox.SelectedText.Replace(this.textBox1.Text, this.textBox2.Text);
				this.f1.mainTextBox.Select(this.f1.mainTextBox.SelectionStart-this.textBox2.TextLength, this.textBox2.TextLength);
			}
		}

		//모두 바꾸기 버튼
		private void button3_Click(object sender, System.EventArgs e)
		{
			this.f1.mainTextBox.Text = 	this.f1.mainTextBox.Text.Replace(this.textBox1.Text, this.textBox2.Text);
		}

		//닫기 버튼
		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}