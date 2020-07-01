using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Text;

namespace notepad
{
	/// <summary>
	/// search�� ���� ��� �����Դϴ�.
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

		Form1 f1;//������ ���� ����

		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public search(Form1 frm)//���ڷ� �������� �޾ƿ�
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();
			f1 = frm;//������ �ʱ�ȭ
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
			this.label1.Text = "ã�� ����(&N):";
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
			this.button1.Text = "���� ã��(&F)";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(336, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "���";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 55);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "��/�ҹ��� ����(&C)";
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
			this.groupBox1.Text = "����";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(86, 14);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(90, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "�Ʒ���(&D)";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(9, 14);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(79, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "����(&U)";
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
			this.Text = "ã��";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.search_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//�˻��� �õ��� ���� �ִٸ�...
		private void search_Load(object sender, System.EventArgs e)
		{
			this.searchTextBox.Text = this.f1.search;//�˻�� �Է�����
			this.checkBox1.Checked = this.f1.lowerChecked;//��/�ҹ��� ����
			
			if(this.f1.downChecked)//�Ʒ��� �˻����� ���� �˻������� ����
			{
				this.radioButton2.Checked = true;
			}
			else
			{
				this.radioButton1.Checked = true;
			}
		}

		//�˻� ��ư Ȱ��ȭ
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

		//�˻�
		private void button1_Click(object sender, System.EventArgs e)
		{
			string searchText;//�˻��� ����
			int searchLength;//�˻��� ������ ��
			int searchStart;//�˻� ���� ��ġ
			int searchLocation;//�˻��� ������ ��ġ
			string  textLower;//��/�ҹ��� ����

			if(checkBox1.Checked)//��/�ҹ��� ������ �Ѵٸ�...
			{
				searchText = this.searchTextBox.Text;
				textLower = this.f1.mainTextBox.Text;
			}
			else//��/�ҹ��� ������ ���Ѵٸ�...
			{
				searchText = this.searchTextBox.Text.ToLower();
				textLower = this.f1.mainTextBox.Text.ToLower();
			}

			searchLength = searchText.Length;

			if(this.f1.mainTextBox.SelectedText.Length > 0)//���õǾ��� ���ڰ� �ִٸ�...
			{
				searchStart = this.f1.mainTextBox.SelectionStart+searchLength;//�����˻��� ���ؼ� �˻������� ���̸� ������
			}
			else//��ŸƮ ��ġ�� �˻��� ���� �� ���� ���� ���
			{
				searchStart = this.f1.mainTextBox.SelectionStart;//�ɷ� ��ġ���� �˻�
			}

			if(radioButton2.Checked)//������ �˻�
			{
				searchLocation = textLower.IndexOf(searchText, searchStart);
			}
			else//������ �˻�
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
				MessageBox.Show("\""+searchText+"\"��(��) ã�� �� �����ϴ�.","�޸���",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}

			//üũ�� �� �ѹ��̶� �˻��� �ϸ� �Ʒ� ������ �������� �Ѱ���
			this.f1.search = searchText;
			this.f1.downChecked = radioButton2.Checked;
			this.f1.lowerChecked = checkBox1.Checked;
		}

		//�ݱ�
		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
