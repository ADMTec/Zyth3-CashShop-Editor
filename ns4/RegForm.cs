using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ns4
{
	internal class RegForm : Form
	{
		private Class10 class10_0 = new Class10();

		private IContainer icontainer_0 = null;

		private Button CloseBtn;

		private Button OkBtn;

		private Panel panel1;

		private Label label4;

		private Label label1;

		private Panel panel2;

		private Label label3;

		private TextBox activationtxt;

		private Label label5;

		private TextBox codetxt;

		private Label label2;

		private TextBox nametxt;

		private Label label6;

		private OpenFileDialog openFileDialog_0;

		private Label label8;

		private PictureBox pictureBox1;

		private SaveFileDialog saveFileDialog_0;

		private Label label7;

		public RegForm()
		{
			this.InitializeComponent();
			this.codetxt.Text = Form1.dictionary_0["UserKey"];
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void InitializeComponent()
		{
			this.CloseBtn = new Button();
			this.OkBtn = new Button();
			this.panel1 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.label8 = new Label();
			this.label3 = new Label();
			this.activationtxt = new TextBox();
			this.label5 = new Label();
			this.codetxt = new TextBox();
			this.label4 = new Label();
			this.label2 = new Label();
			this.nametxt = new TextBox();
			this.panel2 = new Panel();
			this.label6 = new Label();
			this.label1 = new Label();
			this.openFileDialog_0 = new OpenFileDialog();
			this.saveFileDialog_0 = new SaveFileDialog();
			this.label7 = new Label();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.CloseBtn.BackColor = Color.White;
			this.CloseBtn.FlatStyle = FlatStyle.Flat;
			this.CloseBtn.Location = new Point(355, 14);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(95, 28);
			this.CloseBtn.TabIndex = 1;
			this.CloseBtn.Text = "&Close";
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.CloseBtn.Click += new EventHandler(this.CloseBtn_Click);
			this.OkBtn.BackColor = Color.White;
			this.OkBtn.FlatStyle = FlatStyle.Flat;
			this.OkBtn.Location = new Point(456, 14);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(95, 28);
			this.OkBtn.TabIndex = 0;
			this.OkBtn.Text = "&Activate";
			this.OkBtn.UseVisualStyleBackColor = false;
			this.OkBtn.Click += new EventHandler(this.OkBtn_Click);
			this.panel1.BackColor = Color.White;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.activationtxt);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.codetxt);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.nametxt);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 54);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(570, 214);
			this.panel1.TabIndex = 4;
			this.pictureBox1.Image = Class9.smethod_25();
			this.pictureBox1.Location = new Point(424, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			this.label8.AutoSize = true;
			this.label8.Cursor = Cursors.Hand;
			this.label8.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.DarkGreen;
			this.label8.Location = new Point(441, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 15);
			this.label8.TabIndex = 6;
			this.label8.Text = "Save Client Code";
			this.label8.Click += new EventHandler(this.label8_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.DimGray;
			this.label3.Location = new Point(25, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Enter Activation Code";
			this.activationtxt.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.activationtxt.Location = new Point(28, 79);
			this.activationtxt.Multiline = true;
			this.activationtxt.Name = "activationtxt";
			this.activationtxt.ScrollBars = ScrollBars.Vertical;
			this.activationtxt.Size = new System.Drawing.Size(513, 49);
			this.activationtxt.TabIndex = 12;
			this.activationtxt.TextAlign = HorizontalAlignment.Center;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.DimGray;
			this.label5.Location = new Point(276, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "Client Code";
			this.codetxt.Location = new Point(279, 35);
			this.codetxt.Name = "codetxt";
			this.codetxt.Size = new System.Drawing.Size(262, 20);
			this.codetxt.TabIndex = 10;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ControlDarkDark;
			this.label4.Location = new Point(376, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Contact Zythe @ skype: i_am_zythe";
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.DimGray;
			this.label2.Location = new Point(25, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "License To";
			this.nametxt.Location = new Point(28, 35);
			this.nametxt.Name = "nametxt";
			this.nametxt.Size = new System.Drawing.Size(231, 20);
			this.nametxt.TabIndex = 8;
			this.panel2.BackColor = SystemColors.ControlDarkDark;
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.CloseBtn);
			this.panel2.Controls.Add(this.OkBtn);
			this.panel2.Dock = DockStyle.Bottom;
			this.panel2.Location = new Point(0, 160);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(570, 54);
			this.panel2.TabIndex = 0;
			this.label6.AutoSize = true;
			this.label6.Cursor = Cursors.Hand;
			this.label6.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.GreenYellow;
			this.label6.Location = new Point(12, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Load activation file";
			this.label6.Click += new EventHandler(this.label6_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ButtonFace;
			this.label1.Location = new Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Activation Proccess";
			this.openFileDialog_0.DefaultExt = "zythe";
			this.openFileDialog_0.FileName = "License.zythe";
			this.openFileDialog_0.Filter = "zythe files (*.zythe)|*.zythe";
			this.openFileDialog_0.FileOk += new CancelEventHandler(this.openFileDialog_0_FileOk);
			this.saveFileDialog_0.DefaultExt = "zythe";
			this.saveFileDialog_0.FileName = "ClientCode.zythe";
			this.saveFileDialog_0.Filter = "zythe files (*.zythe)|*.zythe";
			this.saveFileDialog_0.FileOk += new CancelEventHandler(this.saveFileDialog_0_FileOk);
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ButtonFace;
			this.label7.Location = new Point(25, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(326, 14);
			this.label7.TabIndex = 15;
			this.label7.Text = "If you found this Application anywhare Please contact the Author  ";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = SystemColors.ControlDarkDark;
			base.ClientSize = new System.Drawing.Size(570, 268);
			base.ControlBox = false;
			base.Controls.Add(this.label7);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "RegForm";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Activation Form";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			this.openFileDialog_0.ShowDialog();
		}

		private void label8_Click(object sender, EventArgs e)
		{
			if (this.nametxt.Text.Length <= 1)
			{
				MessageBox.Show("License to is empty!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				this.saveFileDialog_0.ShowDialog();
			}
		}

		private bool method_0()
		{
			bool flag = false;
			string str = Regex.Replace(this.codetxt.Text, "[ -]", "");
			string str1 = Regex.Replace(this.codetxt.Text, "[ ]", "");
			char[] chrArray = new char[] { '-' };
			if (!Class11.smethod_0(str, str1.Split(chrArray)[1], this.activationtxt.Text))
			{
				MessageBox.Show("Invalid Activation key", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (!Class11.smethod_1(this.nametxt.Text.ToUpper(), this.activationtxt.Text))
			{
				MessageBox.Show("Invalid license name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				this.class10_0.method_2("ActivationCode", this.activationtxt.Text);
				this.class10_0.method_2("License", this.nametxt.Text);
				flag = true;
			}
			return flag;
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			if (this.method_0())
			{
				Class3.smethod_1("Congratulation!\nActivation proccess completed successfully.", "success");
				base.DialogResult = System.Windows.Forms.DialogResult.OK;
				base.Close();
			}
		}

		private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
		{
			if (this.openFileDialog_0.FileName == "")
			{
				MessageBox.Show("Invalid Activation file", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				string[] strArrays = File.ReadAllLines(this.openFileDialog_0.FileName);
				if ((strArrays[0].Length <= 0 ? true : strArrays[1].Length <= 20))
				{
					MessageBox.Show("Invalid Activation file", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					this.nametxt.Text = strArrays[0];
					this.activationtxt.Text = strArrays[1];
				}
			}
		}

		private void saveFileDialog_0_FileOk(object sender, CancelEventArgs e)
		{
			if (this.saveFileDialog_0.FileName != "")
			{
				string[] text = new string[] { this.nametxt.Text, this.codetxt.Text };
				File.WriteAllLines(this.saveFileDialog_0.FileName, text);
				MessageBox.Show("ClientCode file saved!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		//protected override void System.Windows.Forms.Form.Dispose(bool disposing)
		//{
		//	if ((!disposing ? false : this.icontainer_0 != null))
		//	{
		//		this.icontainer_0.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}
	}
}