using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace notepad
{
	/// <summary>
	/// move�� ���� ��� �����Դϴ�.
	/// </summary>
	public class move : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;

		Form1 f1;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public move(Form1 frm)
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();
			f1 = frm;
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
				if(components != null)
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
			this.label1.Text = "�� ��ȣ(&N)";
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
			this.button1.Text = "Ȯ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(112, 56);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "���";
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
			this.Text = "�� �̵�";
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
					MessageBox.Show("���ڸ� �Է� �����մϴ�.", "����");
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
