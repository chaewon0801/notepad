using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace notepad
{
	/// <summary>
	/// move에 대한 요약 설명입니다.
	/// </summary>
	public class move : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;

		Form1 f1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public move(Form1 frm)
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "줄 번호(&N)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(89, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "1";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(24, 56);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "확인";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(112, 56);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "취소";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// move
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(210, 95);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "move";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "줄 이동";
			this.ResumeLayout(false);

		}
		#endregion

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			string isNum = textBox1.Text;
			for(int i = 0; i < isNum.Length; i++)
			{
				if(!char.IsDigit(isNum, i))
				{
					MessageBox.Show("숫자만 입력 가능합니다.", "에러");
					textBox1.Text = "";
					break;
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.f1.lineNum = int.Parse(textBox1.Text);
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
