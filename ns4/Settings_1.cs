using ns0;
using ns2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns4
{
	internal class Settings_1 : Form
	{
		public Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

		private Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

		private IContainer icontainer_0 = null;

		private Label label7;

		private OpenFileDialog openFileDialog_0;

		private Label label1;

		private Panel panel2;

		private Button CloseBtn;

		private Button OkBtn;

		private Panel panel1;

		private TabControl tabControl1;

		private TabPage tabPage1;

		private TabPage tabPage2;

		private ComboBox ServerFileIDX;

		private TextBox OutPutFolder;

		private Label label3;

		private Label label2;

		private ComboBox MaxItemOpt;

		private Label label9;

		private TextBox MaxDurability;

		private Label label8;

		private ComboBox MaxItemLvl;

		private Label label5;

		private Label label14;

		private Label label13;

		private Label label12;

		private CheckBox AncientItem;

		private Label label11;

		private TextBox ItemTxt;

		private ComboBox MaxItemSocket;

		private Label label6;

		private TextBox ItemSocketTxt;

		private Label label10;

		private Label label4;

		public Settings_1()
		{
			this.InitializeComponent();
			this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.method_0(false);
		}

		private void InitializeComponent()
		{
			this.label7 = new Label();
			this.openFileDialog_0 = new OpenFileDialog();
			this.label1 = new Label();
			this.panel2 = new Panel();
			this.label4 = new Label();
			this.CloseBtn = new Button();
			this.OkBtn = new Button();
			this.panel1 = new Panel();
			this.tabControl1 = new TabControl();
			this.tabPage1 = new TabPage();
			this.label14 = new Label();
			this.ServerFileIDX = new ComboBox();
			this.OutPutFolder = new TextBox();
			this.label3 = new Label();
			this.label2 = new Label();
			this.tabPage2 = new TabPage();
			this.label13 = new Label();
			this.label12 = new Label();
			this.AncientItem = new CheckBox();
			this.label11 = new Label();
			this.ItemTxt = new TextBox();
			this.MaxItemSocket = new ComboBox();
			this.label6 = new Label();
			this.ItemSocketTxt = new TextBox();
			this.label10 = new Label();
			this.MaxItemOpt = new ComboBox();
			this.label9 = new Label();
			this.MaxDurability = new TextBox();
			this.label8 = new Label();
			this.MaxItemLvl = new ComboBox();
			this.label5 = new Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ButtonFace;
			this.label7.Location = new Point(25, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(430, 14);
			this.label7.TabIndex = 18;
			this.label7.Text = "If you found this Application anywhare Please contact the Author  @ skype: i_am_zythe";
			this.openFileDialog_0.DefaultExt = "txt";
			this.openFileDialog_0.Filter = "Text files (*.txt)|*.txt";
			this.openFileDialog_0.FileOk += new CancelEventHandler(this.openFileDialog_0_FileOk);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ButtonFace;
			this.label1.Location = new Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 22);
			this.label1.TabIndex = 16;
			this.label1.Text = "Application Settings";
			this.panel2.BackColor = SystemColors.ControlDarkDark;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.CloseBtn);
			this.panel2.Controls.Add(this.OkBtn);
			this.panel2.Dock = DockStyle.Bottom;
			this.panel2.Location = new Point(0, 160);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(570, 54);
			this.panel2.TabIndex = 0;
			this.label4.AutoSize = true;
			this.label4.Cursor = Cursors.Hand;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.DeepSkyBlue;
			this.label4.Location = new Point(25, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 16);
			this.label4.TabIndex = 23;
			this.label4.Text = "Load Default";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			this.label4.Click += new EventHandler(this.label4_Click);
			this.CloseBtn.BackColor = Color.White;
			this.CloseBtn.FlatStyle = FlatStyle.Flat;
			this.CloseBtn.Location = new Point(355, 14);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(95, 28);
			this.CloseBtn.TabIndex = 1;
			this.CloseBtn.Text = "&Close";
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.OkBtn.BackColor = Color.White;
			this.OkBtn.FlatStyle = FlatStyle.Flat;
			this.OkBtn.Location = new Point(456, 14);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(95, 28);
			this.OkBtn.TabIndex = 0;
			this.OkBtn.Text = "&Save";
			this.OkBtn.UseVisualStyleBackColor = false;
			this.OkBtn.Click += new EventHandler(this.OkBtn_Click);
			this.panel1.BackColor = Color.White;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 54);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(570, 214);
			this.panel1.TabIndex = 17;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tabControl1.Location = new Point(-1, -2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new Point(10, 6);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(575, 164);
			this.tabControl1.TabIndex = 1;
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.ServerFileIDX);
			this.tabPage1.Controls.Add(this.OutPutFolder);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new Point(4, 30);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(567, 130);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label14.ForeColor = SystemColors.HotTrack;
			this.label14.Location = new Point(474, 60);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(49, 15);
			this.label14.TabIndex = 22;
			this.label14.Text = "Browse";
			this.label14.TextAlign = ContentAlignment.MiddleRight;
			this.label14.Click += new EventHandler(this.label14_Click);
			this.ServerFileIDX.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.ServerFileIDX.Items;
			object[] objArray = new object[] { "ZTeam S8 Files" };
			items.AddRange(objArray);
			this.ServerFileIDX.Location = new Point(147, 19);
			this.ServerFileIDX.Name = "ServerFileIDX";
			this.ServerFileIDX.Size = new System.Drawing.Size(166, 23);
			this.ServerFileIDX.TabIndex = 6;
			this.OutPutFolder.Location = new Point(147, 57);
			this.OutPutFolder.Name = "OutPutFolder";
			this.OutPutFolder.Size = new System.Drawing.Size(321, 21);
			this.OutPutFolder.TabIndex = 4;
			this.label3.Location = new Point(9, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Output Folder";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			this.label2.Location = new Point(9, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Server Files";
			this.label2.TextAlign = ContentAlignment.MiddleRight;
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.AncientItem);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.ItemTxt);
			this.tabPage2.Controls.Add(this.MaxItemSocket);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.ItemSocketTxt);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.MaxItemOpt);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.MaxDurability);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.MaxItemLvl);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new Point(4, 30);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(567, 130);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Item Control";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label13.ForeColor = SystemColors.HotTrack;
			this.label13.Location = new Point(480, 85);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(49, 15);
			this.label13.TabIndex = 22;
			this.label13.Text = "Browse";
			this.label13.TextAlign = ContentAlignment.MiddleRight;
			this.label13.Click += new EventHandler(this.label13_Click);
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label12.ForeColor = SystemColors.HotTrack;
			this.label12.Location = new Point(480, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(49, 15);
			this.label12.TabIndex = 21;
			this.label12.Text = "Browse";
			this.label12.TextAlign = ContentAlignment.MiddleRight;
			this.label12.Click += new EventHandler(this.label12_Click);
			this.AncientItem.AutoSize = true;
			this.AncientItem.Location = new Point(382, 26);
			this.AncientItem.Name = "AncientItem";
			this.AncientItem.Size = new System.Drawing.Size(146, 19);
			this.AncientItem.TabIndex = 20;
			this.AncientItem.Text = "Enable Ancient Option";
			this.AncientItem.UseVisualStyleBackColor = true;
			this.label11.Location = new Point(188, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 15);
			this.label11.TabIndex = 19;
			this.label11.Text = "Item.txt";
			this.label11.TextAlign = ContentAlignment.MiddleRight;
			this.ItemTxt.Location = new Point(291, 53);
			this.ItemTxt.Name = "ItemTxt";
			this.ItemTxt.Size = new System.Drawing.Size(183, 21);
			this.ItemTxt.TabIndex = 18;
			this.MaxItemSocket.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections = this.MaxItemSocket.Items;
			objArray = new object[] { "0", "1", "2", "3", "4", "5" };
			objectCollections.AddRange(objArray);
			this.MaxItemSocket.Location = new Point(291, 24);
			this.MaxItemSocket.Name = "MaxItemSocket";
			this.MaxItemSocket.Size = new System.Drawing.Size(79, 23);
			this.MaxItemSocket.TabIndex = 17;
			this.label6.Location = new Point(188, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "ItemSocket.txt";
			this.label6.TextAlign = ContentAlignment.MiddleRight;
			this.ItemSocketTxt.Location = new Point(291, 82);
			this.ItemSocketTxt.Name = "ItemSocketTxt";
			this.ItemSocketTxt.Size = new System.Drawing.Size(183, 21);
			this.ItemSocketTxt.TabIndex = 15;
			this.label10.Location = new Point(188, 27);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 15);
			this.label10.TabIndex = 14;
			this.label10.Text = "Max Socket";
			this.label10.TextAlign = ContentAlignment.MiddleRight;
			this.MaxItemOpt.FormattingEnabled = true;
			ComboBox.ObjectCollection items1 = this.MaxItemOpt.Items;
			objArray = new object[] { "0", "1", "2", "3", "4", "5", "6", "7" };
			items1.AddRange(objArray);
			this.MaxItemOpt.Location = new Point(108, 53);
			this.MaxItemOpt.Name = "MaxItemOpt";
			this.MaxItemOpt.Size = new System.Drawing.Size(79, 23);
			this.MaxItemOpt.TabIndex = 11;
			this.label9.Location = new Point(5, 85);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 15);
			this.label9.TabIndex = 10;
			this.label9.Text = "Max Durability";
			this.label9.TextAlign = ContentAlignment.MiddleRight;
			this.MaxDurability.Location = new Point(108, 82);
			this.MaxDurability.Name = "MaxDurability";
			this.MaxDurability.Size = new System.Drawing.Size(79, 21);
			this.MaxDurability.TabIndex = 9;
			this.label8.Location = new Point(5, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 15);
			this.label8.TabIndex = 8;
			this.label8.Text = "Max Option";
			this.label8.TextAlign = ContentAlignment.MiddleRight;
			this.MaxItemLvl.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections1 = this.MaxItemLvl.Items;
			objArray = new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
			objectCollections1.AddRange(objArray);
			this.MaxItemLvl.Location = new Point(108, 24);
			this.MaxItemLvl.Name = "MaxItemLvl";
			this.MaxItemLvl.Size = new System.Drawing.Size(79, 23);
			this.MaxItemLvl.TabIndex = 7;
			this.label5.Location = new Point(5, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Item Max Level";
			this.label5.TextAlign = ContentAlignment.MiddleRight;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = SystemColors.ControlDarkDark;
			base.ClientSize = new System.Drawing.Size(570, 268);
			base.ControlBox = false;
			base.Controls.Add(this.label7);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "Settings";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label12_Click(object sender, EventArgs e)
		{
			this.openFileDialog_0.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
			this.openFileDialog_0.FileName = "Item.txt";
			this.openFileDialog_0.Tag = "item";
			this.openFileDialog_0.ShowDialog();
		}

		private void label13_Click(object sender, EventArgs e)
		{
			this.openFileDialog_0.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
			this.openFileDialog_0.FileName = "ItemSocket.txt";
			this.openFileDialog_0.Tag = "itemsocket";
			this.openFileDialog_0.ShowDialog();
		}

		private void label14_Click(object sender, EventArgs e)
		{
			Class0 class0 = new Class0();
			class0.method_2(base.Owner);
			string str = class0.method_0();
			if (str != "")
			{
				this.OutPutFolder.Text = str;
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.method_0(true);
		}

		private void method_0(bool bool_0)
		{
			this.dictionary_0 = Class12.smethod_1(bool_0);
			this.ServerFileIDX.SelectedIndex = Class3.smethod_0(this.dictionary_0["ServerFileIDX"]);
			this.OutPutFolder.Text = this.dictionary_0["OutPutFolder"];
			this.ItemTxt.Text = this.dictionary_0["ItemTxt"];
			this.MaxItemLvl.SelectedIndex = this.MaxItemLvl.Items.IndexOf(this.dictionary_0["MaxItemLvl"]);
			this.MaxItemOpt.SelectedIndex = this.MaxItemLvl.Items.IndexOf(this.dictionary_0["MaxItemOpt"]);
			this.MaxItemSocket.SelectedIndex = this.MaxItemLvl.Items.IndexOf(this.dictionary_0["MaxItemSocket"]);
			this.ItemSocketTxt.Text = this.dictionary_0["ItemSocketTxt"];
			this.MaxDurability.Text = this.dictionary_0["MaxDurability"];
			this.AncientItem.Checked = Convert.ToBoolean(Class3.smethod_0(this.dictionary_0["AncientItem"]));
		}

		private bool method_1()
		{
			bool flag;
			bool[] selectedIndex = new bool[] { this.ServerFileIDX.SelectedIndex > -1, this.OutPutFolder.Text != "", this.ItemTxt.Text != "", this.MaxItemLvl.SelectedIndex > -1, this.MaxItemOpt.SelectedIndex > -1, this.MaxItemSocket.SelectedIndex > -1, this.ItemSocketTxt.Text != "", this.MaxDurability.Text != "" };
			bool[] flagArray = selectedIndex;
			string[] strArrays = new string[] { "Select ServerFiles.", "Ouput folder should not be empty.", "Select location for item.txt.", "Select Max item level.", "Select Max item option.", "Select max item socket.", "Select itemSocket.txt location", "Max item durability is empty" };
			string[] strArrays1 = strArrays;
			int num = 0;
			while (true)
			{
				if (num >= (int)flagArray.Length)
				{
					flag = true;
					break;
				}
				else if (!flagArray[num])
				{
					Class3.smethod_1(strArrays1[num], "");
					flag = false;
					break;
				}
				else
				{
					num++;
				}
			}
			return flag;
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			if (this.method_1())
			{
				string[] str = new string[] { "ServerFileIDX", "OutPutFolder", "ItemTxt", "MaxItemLvl", "MaxItemOpt", "MaxItemSocket", "ItemSocketTxt", "MaxDurability", "AncientItem" };
				string[] strArrays = str;
				str = new string[9];
				int selectedIndex = this.ServerFileIDX.SelectedIndex;
				str[0] = selectedIndex.ToString();
				str[1] = this.OutPutFolder.Text;
				str[2] = this.ItemTxt.Text;
				selectedIndex = this.MaxItemLvl.SelectedIndex;
				str[3] = selectedIndex.ToString();
				selectedIndex = this.MaxItemOpt.SelectedIndex;
				str[4] = selectedIndex.ToString();
				selectedIndex = this.MaxItemSocket.SelectedIndex;
				str[5] = selectedIndex.ToString();
				str[6] = this.ItemSocketTxt.Text;
				str[7] = this.MaxDurability.Text;
				str[8] = (this.AncientItem.Checked ? "1" : "0");
				Class12.smethod_2(strArrays, str);
				base.DialogResult = System.Windows.Forms.DialogResult.OK;
				base.Close();
			}
		}

		private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
		{
			if (this.openFileDialog_0.FileName != "")
			{
				if (this.openFileDialog_0.Tag.ToString() == "item")
				{
					this.ItemTxt.Text = this.openFileDialog_0.FileName;
				}
				if (this.openFileDialog_0.Tag.ToString() == "itemsocket")
				{
					this.ItemSocketTxt.Text = this.openFileDialog_0.FileName;
				}
				this.openFileDialog_0.Tag = "";
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