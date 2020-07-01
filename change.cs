using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace notepad
{
	/// <summary>
	/// change�� ���� ��� �����Դϴ�.
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

		private string searchText;//�˻��� ����
		private int searchLength;//�˻��� ������ ��
		private int search2Length;//�ٲ� ������ ��
		private int searchStart;//�˻� ���� ��ġ
		private int searchLocation;//�˻��� ������ ��ġ
		private string  textLower;//��/�ҹ��� ����
		Form1 f1;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public change(Form1 frm)
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
			this.label1.Text = "ã�� ����(&N):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "�ٲ� ����(&P):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 89);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "��/�ҹ��� ����(&C)";
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
			this.button1.Text = "���� ã��(&F)";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(304, 37);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "�ٲٱ�(&R)";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(304, 65);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "��� �ٲٱ�(&A)";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(304, 93);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 23);
			this.button4.TabIndex = 8;
			this.button4.Text = "���";
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
			this.Text = "�ٲٱ�";
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

		//���� ã�� ��ư
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)//��/�ҹ��� ������ �Ѵٸ�...
			{
				searchText = this.textBox1.Text;
				textLower = this.f1.mainTextBox.Text;
			}
			else//��/�ҹ��� ������ ���Ѵٸ�...
			{
				searchText = this.textBox1.Text.ToLower();
				textLower = this.f1.mainTextBox.Text.ToLower();
			}

			searchLength = searchText.Length;
			search2Length = this.textBox2.TextLength;

			int ssLength = this.f1.mainTextBox.SelectionStart;
			if(this.f1.mainTextBox.SelectedText.Length > 0)//���õǾ��� ���ڰ� �ִٸ�...
			{
				if(searchLength > search2Length)
				{
					searchStart = ssLength+search2Length;//�ٲܹ��ڰ� �˻����ں��� ��ٸ� �ٲ� ������ ���̸� ������
				}
				else
				{
					searchStart = ssLength+searchLength;//�����˻��� ���ؼ� �˻������� ���̸� ������
				}
			}
			else//��ŸƮ ��ġ�� �˻��� ���� �� ���� ���� ���
			{
				searchStart = ssLength;//�ɷ� ��ġ���� �˻�
			}

			searchLocation = textLower.IndexOf(searchText, searchStart);//���ڿ� �˻�

			if(searchLocation >= 0)//�˻��� ���ڰ� �ִٸ�...
			{
				this.f1.mainTextBox.Select(searchLocation, searchLength);
				this.f1.mainTextBox.ScrollToCaret();
			}
			else
			{
				MessageBox.Show("\""+searchText+"\"��(��) ã�� �� �����ϴ�.","�޸���",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}

			//üũ�� �� �ѹ��̶� �˻��� �ϸ� �Ʒ� ������ �������� �Ѱ���
			this.f1.search = searchText;
			this.f1.lowerChecked = checkBox1.Checked;
		}

		//�ٲٱ� ��ư
		private void button2_Click(object sender, System.EventArgs e)
		{
			button1_Click(sender, e);

			if(searchLocation >= 0)//�˻��� ���ڰ� �ִٸ�...
			{
				//�������� �ؽ�Ʈ�ڽ��� ���õ� ���ڸ� Replace�� ����Ͽ� �ٲ���
				this.f1.mainTextBox.SelectedText = this.f1.mainTextBox.SelectedText.Replace(this.textBox1.Text, this.textBox2.Text);
				this.f1.mainTextBox.Select(this.f1.mainTextBox.SelectionStart-this.textBox2.TextLength, this.textBox2.TextLength);
			}
		}

		//��� �ٲٱ� ��ư
		private void button3_Click(object sender, System.EventArgs e)
		{
			this.f1.mainTextBox.Text = 	this.f1.mainTextBox.Text.Replace(this.textBox1.Text, this.textBox2.Text);
		}

		//�ݱ� ��ư
		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}