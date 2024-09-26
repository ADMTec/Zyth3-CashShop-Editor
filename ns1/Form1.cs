using ns0;
using ns2;
using ns3;
using ns4;
using ns5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.Reflection;
using System.Security.Cryptography;

namespace ns1
{
	internal class Form1 : Form
	{
		private int[] int_0 = new int[2];

		public static DataSet dataSet_0;

		public bool IsActivated = true;

		public static Dictionary<string, string> dictionary_0;

		public static Dictionary<string, int> dictionary_1;

		public List<string> list_0 = Class13.smethod_0(Class3.smethod_2(Class12.smethod_0("ItemTxt"), false, true));

		public int[] int_1 = new int[3];

		private TextBox newTedit = new TextBox();

		private TextBox newMedit = new TextBox();

		public string string_0 = AppDomain.CurrentDomain.BaseDirectory;

		private Control control_0 = null;

		private int int_2 = 0;

		private int int_3 = 0;

		private string string_1 = string.Empty;

		private string string_2 = string.Empty;

		private int int_4 = 0;

		private IContainer icontainer_0 = null;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem fileToolStripMenuItem;

		private ToolStripMenuItem editToolStripMenuItem;

		private ToolStripMenuItem optionToolStripMenuItem;

		private ToolStripMenuItem helpToolStripMenuItem;

		private Panel panel1;

		private ListBox itemListBox;

		private ComboBox itemGroup;

		private TabControl itemTabs;

		private TabPage tabPage1;

		private TabPage tabPage2;

		private TabPage tabPage3;

		private TabPage tabPage4;

		private TabPage tabPage5;

		private ToolStripMenuItem newProjectToolStripMenuItem;

		private TabPage tabPage6;

		private ComboBox packCurrency;

		private ComboBox packType;

		private TextBox packCount;

		private TextBox packDisc;

		private TextBox packName;

		private Panel panel2;

		private CheckBox enableMultiPack;

		private GroupBox groupBox2;

		private CheckBox item1ExcOpt3;

		private CheckBox item1ExcOpt2;

		private CheckBox item1ExcOpt1;

		private CheckBox item1ExcOpt6;

		private CheckBox item1ExcOpt5;

		private ComboBox item1ExcOptType;

		private CheckBox item1ExcOpt4;

		private CheckBox item1Skill;

		private CheckBox item1Luck;

		private ComboBox item1Ancient;

		private ComboBox item1Sckt;

		private ComboBox item1Opt;

		private ComboBox item1Lvl;

		private GroupBox groupBox1;

		private TextBox item1Price;

		private TextBox item1Count;

		private TextBox item1Name;

		private CheckBox item1Enable;

		private GroupBox groupBox3;

		private CheckBox item2ExcOpt3;

		private CheckBox item2ExcOpt2;

		private CheckBox item2ExcOpt1;

		private CheckBox item2ExcOpt6;

		private CheckBox item2ExcOpt5;

		private ComboBox item2ExcOptType;

		private CheckBox item2ExcOpt4;

		private CheckBox item2Skill;

		private CheckBox item2Luck;

		private ComboBox item2Ancient;

		private ComboBox item2Sckt;

		private ComboBox item2Opt;

		private ComboBox item2Lvl;

		private GroupBox groupBox4;

		private TextBox item2Price;

		private TextBox item2Count;

		private TextBox item2Name;

		private CheckBox item2Enable;

		private GroupBox groupBox5;

		private CheckBox item3ExcOpt3;

		private CheckBox item3ExcOpt2;

		private CheckBox item3ExcOpt1;

		private CheckBox item3ExcOpt6;

		private CheckBox item3ExcOpt5;

		private ComboBox item3ExcOptType;

		private CheckBox item3ExcOpt4;

		private CheckBox item3Skill;

		private CheckBox item3Luck;

		private ComboBox item3Ancient;

		private ComboBox item3Sckt;

		private ComboBox item3Opt;

		private ComboBox item3Lvl;

		private GroupBox groupBox6;

		private TextBox item3Price;

		private TextBox item3Count;

		private TextBox item3Name;

		private CheckBox item3Enable;

		private GroupBox groupBox7;

		private CheckBox item4ExcOpt3;

		private CheckBox item4ExcOpt2;

		private CheckBox item4ExcOpt1;

		private CheckBox item4ExcOpt6;

		private CheckBox item4ExcOpt5;

		private ComboBox item4ExcOptType;

		private CheckBox item4ExcOpt4;

		private CheckBox item4Skill;

		private CheckBox item4Luck;

		private ComboBox item4Ancient;

		private ComboBox item4Sckt;

		private ComboBox item4Opt;

		private ComboBox item4Lvl;

		private GroupBox groupBox8;

		private TextBox item4Price;

		private TextBox item4Count;

		private TextBox item4Name;

		private GroupBox groupBox9;

		private CheckBox item5ExcOpt3;

		private CheckBox item5ExcOpt2;

		private CheckBox item5ExcOpt1;

		private CheckBox item5ExcOpt6;

		private CheckBox item5ExcOpt5;

		private ComboBox item5ExcOptType;

		private CheckBox item5ExcOpt4;

		private CheckBox item5Skill;

		private CheckBox item5Luck;

		private ComboBox item5Ancient;

		private ComboBox item5Sckt;

		private ComboBox item5Opt;

		private ComboBox item5Lvl;

		private GroupBox groupBox10;

		private TextBox item5Price;

		private TextBox item5Count;

		private TextBox item5Name;

		private CheckBox item5Enable;

		private GroupBox groupBox11;

		private CheckBox item6ExcOpt3;

		private CheckBox item6ExcOpt2;

		private CheckBox item6ExcOpt1;

		private CheckBox item6ExcOpt6;

		private CheckBox item6ExcOpt5;

		private ComboBox item6ExcOptType;

		private CheckBox item6ExcOpt4;

		private CheckBox item6Skill;

		private CheckBox item6Luck;

		private ComboBox item6Ancient;

		private ComboBox item6Sckt;

		private ComboBox item6Opt;

		private ComboBox item6Lvl;

		private GroupBox groupBox12;

		private TextBox item6Price;

		private TextBox item6Count;

		private TextBox item6Name;

		private CheckBox item6Enable;

		private PictureBox itemImg;

		private Panel panel3;

		private TextBox item1Dur;

		private TextBox item2Dur;

		private TextBox item3Dur;

		private TextBox item4Dur;

		private TextBox item5Dur;

		private TextBox item6Dur;

		private Button addPack;

		private Button updatePack;

		private Panel subCutPanel;

		private StatusStrip statusStrip1;

		private Panel mainCutPanel;

		private FlowLayoutPanel flowLayoutPanel1;

		private Button prevBtn;

		private Button nextBtn;

		private Label totalPages;

		private Label currentPage;

		private ToolStripStatusLabel statusicon;

		private CheckBox item4Enable;

		private ToolStripStatusLabel statusinfo;

		private System.Windows.Forms.ContextMenuStrip contexMenu;

		private ToolStripMenuItem addNewToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator2;

		private ToolStripMenuItem moveUpToolStripMenuItem;

		private ToolStripMenuItem moveDownToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripMenuItem renameToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator3;

		private ToolStripMenuItem deleteToolStripMenuItem;

		private ToolStripMenuItem resetDefaultToolStripMenuItem;

		private ToolStripMenuItem mainCategoryToolStripMenuItem;

		private ToolStripMenuItem addNewToolStripMenuItem1;

		private ToolStripMenuItem editCategoriesToolStripMenuItem;

		private ToolStripMenuItem packageTabToolStripMenuItem;

		private ToolStripMenuItem addNewToolStripMenuItem2;

		private ToolStripMenuItem editToolStripMenuItem1;

		private ToolStripMenuItem clearAllDataToolStripMenuItem;

		private ToolStripMenuItem generalSettingToolStripMenuItem;

		private ToolStripMenuItem helpToolStripMenuItem1;

		private ToolStripMenuItem aboutToolStripMenuItem;

		private ToolStripMenuItem openToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator4;

		private ToolStripMenuItem saveToolStripMenuItem;

		private ToolStripMenuItem saveAsToolStripMenuItem;

		private ToolStripMenuItem exportToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator5;

		private ToolStripMenuItem exitToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator6;

		private ToolStripSeparator toolStripSeparator7;

		private ToolStripMenuItem wCoinsShopToolStripMenuItem;

		private ToolStripMenuItem wCoinsPShopToolStripMenuItem;

		private ToolStripMenuItem goblinPointsShopToolStripMenuItem;

		private ToolStripMenuItem addNewTabToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator8;

		private ToolStripMenuItem wCoinCShopToolStripMenuItem;

		private ToolStripMenuItem wCoinsPShopToolStripMenuItem1;

		private ToolStripSeparator toolStripSeparator9;

		private ToolStripMenuItem goblinPShopToolStripMenuItem;

		private ToolStripMenuItem previewDataTablesToolStripMenuItem;

		private System.Windows.Forms.ContextMenuStrip packageMenu;

		private ToolStripMenuItem modifyPackagPackageMenu;

		private ToolStripSeparator toolStripSeparator11;

		private ToolStripMenuItem moveUpPackageMenu;

		private ToolStripMenuItem moveDownPackageMenu;

		private ToolStripSeparator toolStripSeparator10;

		private ToolStripMenuItem deletPackageMenu;

		private SaveFileDialog saveFileDialog_0;

		private OpenFileDialog openFileDialog_0;

		private ListBox itemIndexList;

		protected BackgroundWorker backgroundWorker_0;

		private ComboBox packUnit;

		private RadioButton packageEnable;

		private RadioButton bundleEnable;

		private Panel pcPanel;

		private Panel bdPanel;

		private TabControl tabControl1;

		private TabPage tabPage7;

		private Label label1;

		private Button deleteprod;

		private Button addprod;

		private DataGridView PrDGV;

		private DataGridView bundleDGV;

		private DataGridViewTextBoxColumn PName;

		private DataGridViewTextBoxColumn PID;

		private TabPage tabPage8;

		private TextBox newPrDur;

		private GroupBox groupBox13;

		private CheckBox newPrOpt6;

		private CheckBox newPrOpt5;

		private CheckBox newPrOpt4;

		private CheckBox newPrOpt3;

		private CheckBox newPrOpt2;

		private CheckBox newPrOpt1;

		private ComboBox newP7rExcOptType;

		private CheckBox newPrSkill;

		private CheckBox newPrLuck;

		private ComboBox newPrAncient;

		private ComboBox newPrSckt;

		private ComboBox newPrOpt;

		private ComboBox newPrLvl;

		private GroupBox groupBox14;

		private TextBox newPrPrice;

		private TextBox newPrCount;

		private TextBox newPrPname;

		private Panel addtoproductPanel;

		private Button addNewProdBtn;

		private TextBox bundlePrice;

		private DataGridViewTextBoxColumn inProductID;

		private DataGridViewTextBoxColumn inProductName;

		private DataGridViewTextBoxColumn colProductID;

		private DataGridViewTextBoxColumn colProductName;

		private PictureBox pictureBox1;

		private TextBox textBox1;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem modifyProductToolStripMenuItem;

		private ToolStripMenuItem deleteProductToolStripMenuItem;

		private ToolStripMenuItem addToBundleToolStripMenuItem;

		private ToolStripProgressBar workProgress;

		private ToolStripStatusLabel pleaseWait;

		private BackgroundWorker backgroundWorker_1;

		static Form1()
		{
			Form1.dataSet_0 = Class6.smethod_0("zDataSet", true);
			Form1.dictionary_0 = new Dictionary<string, string>();
			Form1.dictionary_1 = new Dictionary<string, int>();
		}

		public Form1()
		{
			this.InitializeComponent();
			this.itemGroup.Items.AddRange(Class13.string_0);
			this.itemGroup.SelectedIndex = 0;
			this.bundleEnable_CheckedChanged(null, null);
			int windowLong = Form1.Class2.GetWindowLong(base.Handle, Form1.Class2.int_0);
			windowLong = windowLong | Form1.Class2.int_1;
			Form1.Class2.SetWindowLong(base.Handle, Form1.Class2.int_0, windowLong);
			this.method_0();
			this.method_6();
			this.method_2(10, true);
			this.backgroundWorker_0.RunWorkerAsync();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About about = new About();
			if (about.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				RegForm regForm = new RegForm();
				if (regForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					this.backgroundWorker_0.RunWorkerAsync();
				}
				regForm.Dispose();
			}
			about.Dispose();
		}

		private void addNewProdBtn_Click(object sender, EventArgs e)
		{
			if (this.int_4 == 0)
			{
				this.method_27(false, 0);
			}
			else if (!this.method_19(this.int_4))
			{
				Class3.smethod_1("You must select first a package you want to update.", "warning");
			}
			else
			{
				this.method_27(true, this.int_4);
			}
		}

		private void addNewTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_24("New", "Tab Name", this.int_0[0], false, 10);
			this.method_2(this.int_0[1], false);
		}

		private void addPack_Click(object sender, EventArgs e)
		{
			if (this.method_35() == "bundle")
			{
				this.method_28(this.int_1[0], false, 0);
				this.method_11(this.int_1[0], Convert.ToInt32(this.int_1[2]));
			}
			if (this.method_35() == "product")
			{
				Class3.smethod_1("Please use the \"Add to Product\" button below to add product.", "warning");
			}
			if (this.method_35() == "pack")
			{
				this.method_26(this.int_1[0], false, 0);
				this.method_11(this.int_1[0], Convert.ToInt32(this.int_1[2]));
			}
			this.int_2 = 0;
		}

		private void addToBundleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.bundleDGV.Rows.Count < 6)
			{
				try
				{
					object[] value = new object[] { this.PrDGV.SelectedRows[0].Cells[0].Value, this.PrDGV.SelectedRows[0].Cells[1].Value };
					object[] objArray = value;
					foreach (DataGridViewRow row in (IEnumerable)this.bundleDGV.Rows)
					{
						if (!row.Cells[0].Value.ToString().Equals(objArray[0].ToString()))
						{
							continue;
						}
						Class3.smethod_1("The product is already exist in the bundle.", "warning");
						return;
					}
					this.bundleDGV.Rows.Add(objArray);
					this.packDisc.Text = string.Concat("Bundle Includes:", this.method_47(this.bundleDGV, 1));
				}
				catch (Exception exception)
				{
					Class3.smethod_1("No product selected to add.", "warning");
				}
			}
			else
			{
				Class3.smethod_1("Maximum of 6 products per bundle.", "warning");
			}
		}

        //private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    Class4 class4 = new Class4();
        //    class4.method_1(Class5.smethod_0());
        //    class4.method_5(Class5.smethod_2());
        //    class4.method_3(Class5.smethod_1());
        //    e.Result = class4;
        //}

        //private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    Class4 result = e.Result as Class4;
        //    this.IsActivated = result.method_0();
        //    Form1.dictionary_1 = result.method_4();
        //    Form1.dictionary_0 = result.method_2();
        //    if (result.method_0())
        //    {
        //        this.string_1 = string.Empty;
        //    }
        //}

        private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
		{
			if (!this.IsActivated)
			{
				this.string_1 = string.Concat(this.string_1, "License Error \r");
			}
			bool flag = Class5.smethod_0();
			if ((!(this.string_1 == string.Empty) || !flag ? true : !this.IsActivated))
			{
				e.Result = false;
			}
			else
			{
				e.Result = true;
			}
		}

		private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			bool result = (bool)e.Result;
			this.workProgress.Visible = false;
			this.pleaseWait.Visible = false;
			if (this.string_1 != string.Empty)
			{
				this.method_16("Please activate this program.", "warning");
			}
			if (result)
			{
				switch (this.int_3)
				{
					case 1:
					{
						(new ns0.DataView()).Show();
						break;
					}
					case 2:
					{
						this.method_43();
						break;
					}
				}
			}
		}

		private void bundleDGV_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button.Equals(System.Windows.Forms.MouseButtons.Right))
			{
				this.bundleDGV.Rows[e.RowIndex].Selected = true;
			}
		}

		private void bundleEnable_CheckedChanged(object sender, EventArgs e)
		{
			Point point = new Point(35, 311);
			Point point1 = new Point(1096, 60);
			Point point2 = new Point(1096, 311);
			if ((!this.bundleEnable.Checked ? false : !this.packageEnable.Checked))
			{
				this.bdPanel.Location = point;
				this.pcPanel.Location = point1;
				this.method_45();
			}
			if ((this.bundleEnable.Checked ? false : this.packageEnable.Checked))
			{
				this.pcPanel.Location = point;
				this.bdPanel.Location = point1;
				this.method_46();
			}
		}

		private void clearAllDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Clear all Data? . \nClick 'Yes' to continue", Application.ProductName, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				Form1.dataSet_0 = new DataSet();
				Form1.dataSet_0 = Class6.smethod_0("zData", false);
				this.int_0[0] = 0;
				this.method_2(this.int_0[0], true);
			}
		}

		private void contexMenu_Opening(object sender, CancelEventArgs e)
		{
			string str = this.contexMenu.SourceControl.Parent.Name.ToString();
			string str1 = this.contexMenu.SourceControl.Name.ToString();
			if (str == "mainCutPanel")
			{
				this.addNewTabToolStripMenuItem.Visible = false;
				this.addNewToolStripMenuItem.Visible = true;
				this.moveDownToolStripMenuItem.Enabled = true;
				this.moveUpToolStripMenuItem.Enabled = true;
				this.renameToolStripMenuItem.Enabled = true;
				this.deleteToolStripMenuItem.Enabled = true;
				this.moveDownToolStripMenuItem.Text = "Move Right";
				this.moveUpToolStripMenuItem.Text = "Move Left";
				this.moveUpToolStripMenuItem.Image = Class9.smethod_15();
				this.moveDownToolStripMenuItem.Image = Class9.smethod_16();
			}
			if (str == "subCutPanel")
			{
				this.addNewTabToolStripMenuItem.Visible = true;
				this.addNewToolStripMenuItem.Visible = false;
				this.moveDownToolStripMenuItem.Enabled = true;
				this.moveUpToolStripMenuItem.Enabled = true;
				this.renameToolStripMenuItem.Enabled = true;
				this.deleteToolStripMenuItem.Enabled = true;
				this.moveDownToolStripMenuItem.Text = "Move Down";
				this.moveUpToolStripMenuItem.Text = "Move Up";
				this.moveUpToolStripMenuItem.Image = Class9.smethod_17();
				this.moveDownToolStripMenuItem.Image = Class9.smethod_14();
			}
			if (str1 == "mainCutPanel")
			{
				this.addNewTabToolStripMenuItem.Visible = false;
				this.addNewToolStripMenuItem.Visible = true;
				this.moveDownToolStripMenuItem.Enabled = false;
				this.moveUpToolStripMenuItem.Enabled = false;
				this.renameToolStripMenuItem.Enabled = false;
				this.deleteToolStripMenuItem.Enabled = false;
			}
			if (str1 == "subCutPanel")
			{
				this.addNewTabToolStripMenuItem.Visible = true;
				this.addNewTabToolStripMenuItem.Enabled = true;
				this.addNewToolStripMenuItem.Visible = false;
				this.moveDownToolStripMenuItem.Enabled = false;
				this.moveUpToolStripMenuItem.Enabled = false;
				this.renameToolStripMenuItem.Enabled = false;
				this.deleteToolStripMenuItem.Enabled = false;
				if (this.int_0[0] == 0)
				{
					this.addNewTabToolStripMenuItem.Enabled = false;
				}
			}
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			Control sourceControl = this.contextMenuStrip1.SourceControl;
			string empty = string.Empty;
			try
			{
				empty = ((DataGridView)sourceControl).SelectedRows[0].Cells[0].Value.ToString();
			}
			catch (Exception exception)
			{
				empty = string.Empty;
			}
			if (empty == string.Empty)
			{
				this.contextMenuStrip1.Enabled = false;
			}
			else
			{
				this.contextMenuStrip1.Enabled = true;
				string str = sourceControl.Name.ToString();
				if (str != null)
				{
					if (str == "bundleDGV")
					{
						this.addToBundleToolStripMenuItem.Visible = false;
						this.modifyProductToolStripMenuItem.Visible = false;
						this.deleteProductToolStripMenuItem.Text = "Remove Product";
						this.deleteProductToolStripMenuItem.Enabled = true;
					}
					else if (str == "PrDGV")
					{
						this.addToBundleToolStripMenuItem.Visible = true;
						this.modifyProductToolStripMenuItem.Visible = true;
						this.addToBundleToolStripMenuItem.Enabled = true;
						this.deleteProductToolStripMenuItem.Enabled = this.method_7(empty, -99) >= 10000;
						this.modifyProductToolStripMenuItem.Enabled = this.method_7(empty, -99) >= 10000;
						this.deleteProductToolStripMenuItem.Text = "Delete Product";
					}
				}
			}
		}

		private void deleteprod_Click(object sender, EventArgs e)
		{
			try
			{
				this.bundleDGV.Rows.Remove(this.bundleDGV.SelectedRows[0]);
				this.packDisc.Text = string.Concat("Bundle Includes:", this.method_47(this.bundleDGV, 1));
			}
			catch (Exception exception)
			{
				Class3.smethod_1("No product selected to remove.", "warning");
			}
		}

		private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = this.contextMenuStrip1.SourceControl.Name.ToString();
			if (str != null)
			{
				if (str == "bundleDGV")
				{
					this.deleteprod_Click(null, null);
				}
				else if (str == "PrDGV" && MessageBox.Show("Are you sure you want to delete this product?\nSome bundle package maybe using this product \nClick 'Yes' to continue", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.Yes)
				{
					if (!this.method_19(this.method_7(this.PrDGV.SelectedRows[0].Cells[0].Value.ToString(), -99)))
					{
						this.method_16("Product deleted failed!", "error");
					}
					else
					{
						this.method_16("Product deleted successfully!", "success");
						this.method_44();
					}
				}
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Control sourceControl = this.contexMenu.SourceControl;
			string str = this.contexMenu.SourceControl.Parent.Name.ToString();
			if (str == "mainCutPanel")
			{
				this.method_24("Del", sourceControl.Text, this.method_7(sourceControl.Tag, -99), true, 10);
				this.method_2(this.int_0[0], true);
			}
			if (str == "subCutPanel")
			{
				this.method_24("Del", sourceControl.Text, this.method_7(sourceControl.Tag, -99), false, 10);
				this.method_2(this.int_0[0], true);
			}
		}

		private void deletPackageMenu_Click(object sender, EventArgs e)
		{
			Control sourceControl = this.packageMenu.SourceControl;
			this.method_18(this.method_7(sourceControl.Tag, -99));
			this.method_11(this.int_1[0], Convert.ToInt32(this.int_1[2]));
			this.int_2 = 0;
		}

		private void editToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string str = string.Concat("TypeID = ", this.int_0[0]);
			DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSCategory"].Select(str);
			if ((dataRowArray != null ? false : (int)dataRowArray.Length <= 0))
			{
				Class3.smethod_1("Can't find any tab recored!", "");
			}
			else
			{
				DataRow[] dataRowArray1 = dataRowArray;
				for (int i = 0; i < (int)dataRowArray1.Length; i++)
				{
					DataRow dataRow = dataRowArray1[i];
					if (this.method_7(dataRow["Code"], -99) == 0)
					{
						Form1.dataSet_0.Tables["IBSCategory"].Rows.Remove(dataRow);
					}
				}
			}
			this.method_2(this.int_0[0], true);
		}

		private void enableMultiPack_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox[] checkBoxArray = new CheckBox[] { this.item1Enable, this.item2Enable, this.item3Enable, this.item4Enable, this.item5Enable, this.item6Enable };
			CheckBox[] checkBoxArray1 = checkBoxArray;
			if (!this.enableMultiPack.Checked)
			{
				this.itemTabs.SelectedIndex = 0;
				this.panel3.Visible = true;
				CheckBox[] checkBoxArray2 = checkBoxArray1;
				for (int i = 0; i < (int)checkBoxArray2.Length; i++)
				{
					CheckBox checkBox = checkBoxArray2[i];
					checkBox.Enabled = false;
					checkBox.Checked = false;
				}
				this.item1Enable.Checked = true;
			}
			else
			{
				this.panel3.Visible = false;
				this.item2Enable.Enabled = true;
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_40(null, null);
			this.workProgress.Visible = true;
			this.pleaseWait.Visible = true;
			this.int_3 = 2;
			this.backgroundWorker_1.RunWorkerAsync();
		}

		private void generalSettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings_1 settings1 = new Settings_1();
			if (settings1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				this.method_6();
				this.list_0 = Class13.smethod_0(Class3.smethod_2(Class12.smethod_0("ItemTxt"), false, true));
			}
			settings1.Dispose();
		}

		private void goblinPointsShopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_24("New", "Goblin (P) Shop", 0, true, 20);
			this.method_2(this.int_0[0], true);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle font = new DataGridViewCellStyle();
			DataGridViewCellStyle white = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new MenuStrip();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.newProjectToolStripMenuItem = new ToolStripMenuItem();
			this.openToolStripMenuItem = new ToolStripMenuItem();
			this.previewDataTablesToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new ToolStripMenuItem();
			this.exportToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.exitToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenuItem = new ToolStripMenuItem();
			this.resetDefaultToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.mainCategoryToolStripMenuItem = new ToolStripMenuItem();
			this.addNewToolStripMenuItem1 = new ToolStripMenuItem();
			this.wCoinCShopToolStripMenuItem = new ToolStripMenuItem();
			this.wCoinsPShopToolStripMenuItem1 = new ToolStripMenuItem();
			this.toolStripSeparator9 = new ToolStripSeparator();
			this.goblinPShopToolStripMenuItem = new ToolStripMenuItem();
			this.editCategoriesToolStripMenuItem = new ToolStripMenuItem();
			this.packageTabToolStripMenuItem = new ToolStripMenuItem();
			this.addNewToolStripMenuItem2 = new ToolStripMenuItem();
			this.editToolStripMenuItem1 = new ToolStripMenuItem();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.clearAllDataToolStripMenuItem = new ToolStripMenuItem();
			this.optionToolStripMenuItem = new ToolStripMenuItem();
			this.generalSettingToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this.contexMenu = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.addNewTabToolStripMenuItem = new ToolStripMenuItem();
			this.addNewToolStripMenuItem = new ToolStripMenuItem();
			this.wCoinsShopToolStripMenuItem = new ToolStripMenuItem();
			this.wCoinsPShopToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator8 = new ToolStripSeparator();
			this.goblinPointsShopToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.moveUpToolStripMenuItem = new ToolStripMenuItem();
			this.moveDownToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.renameToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.deleteToolStripMenuItem = new ToolStripMenuItem();
			this.packageMenu = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.modifyPackagPackageMenu = new ToolStripMenuItem();
			this.toolStripSeparator11 = new ToolStripSeparator();
			this.moveUpPackageMenu = new ToolStripMenuItem();
			this.moveDownPackageMenu = new ToolStripMenuItem();
			this.toolStripSeparator10 = new ToolStripSeparator();
			this.deletPackageMenu = new ToolStripMenuItem();
			this.saveFileDialog_0 = new SaveFileDialog();
			this.openFileDialog_0 = new OpenFileDialog();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.PName = new DataGridViewTextBoxColumn();
			this.PID = new DataGridViewTextBoxColumn();
			this.panel1 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.textBox1 = new TextBox();
			this.bdPanel = new Panel();
			this.addtoproductPanel = new Panel();
			this.addNewProdBtn = new Button();
			this.tabControl1 = new TabControl();
			this.tabPage7 = new TabPage();
			this.bundlePrice = new TextBox();
			this.addprod = new Button();
			this.label1 = new Label();
			this.deleteprod = new Button();
			this.PrDGV = new DataGridView();
			this.colProductID = new DataGridViewTextBoxColumn();
			this.colProductName = new DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.addToBundleToolStripMenuItem = new ToolStripMenuItem();
			this.modifyProductToolStripMenuItem = new ToolStripMenuItem();
			this.deleteProductToolStripMenuItem = new ToolStripMenuItem();
			this.bundleDGV = new DataGridView();
			this.inProductID = new DataGridViewTextBoxColumn();
			this.inProductName = new DataGridViewTextBoxColumn();
			this.tabPage8 = new TabPage();
			this.newPrDur = new TextBox();
			this.groupBox13 = new GroupBox();
			this.newPrOpt6 = new CheckBox();
			this.newPrOpt5 = new CheckBox();
			this.newPrOpt4 = new CheckBox();
			this.newPrOpt3 = new CheckBox();
			this.newPrOpt2 = new CheckBox();
			this.newPrOpt1 = new CheckBox();
			this.newP7rExcOptType = new ComboBox();
			this.newPrSkill = new CheckBox();
			this.newPrLuck = new CheckBox();
			this.newPrAncient = new ComboBox();
			this.newPrSckt = new ComboBox();
			this.newPrOpt = new ComboBox();
			this.newPrLvl = new ComboBox();
			this.groupBox14 = new GroupBox();
			this.newPrPrice = new TextBox();
			this.newPrCount = new TextBox();
			this.newPrPname = new TextBox();
			this.pcPanel = new Panel();
			this.panel2 = new Panel();
			this.enableMultiPack = new CheckBox();
			this.panel3 = new Panel();
			this.itemTabs = new TabControl();
			this.tabPage1 = new TabPage();
			this.item1Dur = new TextBox();
			this.groupBox2 = new GroupBox();
			this.item1ExcOpt3 = new CheckBox();
			this.item1ExcOpt2 = new CheckBox();
			this.item1ExcOpt1 = new CheckBox();
			this.item1ExcOpt6 = new CheckBox();
			this.item1ExcOpt5 = new CheckBox();
			this.item1ExcOptType = new ComboBox();
			this.item1ExcOpt4 = new CheckBox();
			this.item1Skill = new CheckBox();
			this.item1Luck = new CheckBox();
			this.item1Ancient = new ComboBox();
			this.item1Sckt = new ComboBox();
			this.item1Opt = new ComboBox();
			this.item1Lvl = new ComboBox();
			this.groupBox1 = new GroupBox();
			this.item1Price = new TextBox();
			this.item1Count = new TextBox();
			this.item1Name = new TextBox();
			this.item1Enable = new CheckBox();
			this.tabPage2 = new TabPage();
			this.item2Dur = new TextBox();
			this.groupBox3 = new GroupBox();
			this.item2ExcOpt3 = new CheckBox();
			this.item2ExcOpt2 = new CheckBox();
			this.item2ExcOpt1 = new CheckBox();
			this.item2ExcOpt6 = new CheckBox();
			this.item2ExcOpt5 = new CheckBox();
			this.item2ExcOptType = new ComboBox();
			this.item2ExcOpt4 = new CheckBox();
			this.item2Skill = new CheckBox();
			this.item2Luck = new CheckBox();
			this.item2Ancient = new ComboBox();
			this.item2Sckt = new ComboBox();
			this.item2Opt = new ComboBox();
			this.item2Lvl = new ComboBox();
			this.groupBox4 = new GroupBox();
			this.item2Price = new TextBox();
			this.item2Count = new TextBox();
			this.item2Name = new TextBox();
			this.item2Enable = new CheckBox();
			this.tabPage3 = new TabPage();
			this.item3Dur = new TextBox();
			this.groupBox5 = new GroupBox();
			this.item3ExcOpt3 = new CheckBox();
			this.item3ExcOpt2 = new CheckBox();
			this.item3ExcOpt1 = new CheckBox();
			this.item3ExcOpt6 = new CheckBox();
			this.item3ExcOpt5 = new CheckBox();
			this.item3ExcOptType = new ComboBox();
			this.item3ExcOpt4 = new CheckBox();
			this.item3Skill = new CheckBox();
			this.item3Luck = new CheckBox();
			this.item3Ancient = new ComboBox();
			this.item3Sckt = new ComboBox();
			this.item3Opt = new ComboBox();
			this.item3Lvl = new ComboBox();
			this.groupBox6 = new GroupBox();
			this.item3Price = new TextBox();
			this.item3Count = new TextBox();
			this.item3Name = new TextBox();
			this.item3Enable = new CheckBox();
			this.tabPage4 = new TabPage();
			this.item4Dur = new TextBox();
			this.groupBox7 = new GroupBox();
			this.item4ExcOpt3 = new CheckBox();
			this.item4ExcOpt2 = new CheckBox();
			this.item4ExcOpt1 = new CheckBox();
			this.item4ExcOpt6 = new CheckBox();
			this.item4ExcOpt5 = new CheckBox();
			this.item4ExcOptType = new ComboBox();
			this.item4ExcOpt4 = new CheckBox();
			this.item4Skill = new CheckBox();
			this.item4Luck = new CheckBox();
			this.item4Ancient = new ComboBox();
			this.item4Sckt = new ComboBox();
			this.item4Opt = new ComboBox();
			this.item4Lvl = new ComboBox();
			this.groupBox8 = new GroupBox();
			this.item4Enable = new CheckBox();
			this.item4Price = new TextBox();
			this.item4Count = new TextBox();
			this.item4Name = new TextBox();
			this.tabPage5 = new TabPage();
			this.item5Dur = new TextBox();
			this.groupBox9 = new GroupBox();
			this.item5ExcOpt3 = new CheckBox();
			this.item5ExcOpt2 = new CheckBox();
			this.item5ExcOpt1 = new CheckBox();
			this.item5ExcOpt6 = new CheckBox();
			this.item5ExcOpt5 = new CheckBox();
			this.item5ExcOptType = new ComboBox();
			this.item5ExcOpt4 = new CheckBox();
			this.item5Skill = new CheckBox();
			this.item5Luck = new CheckBox();
			this.item5Ancient = new ComboBox();
			this.item5Sckt = new ComboBox();
			this.item5Opt = new ComboBox();
			this.item5Lvl = new ComboBox();
			this.groupBox10 = new GroupBox();
			this.item5Price = new TextBox();
			this.item5Count = new TextBox();
			this.item5Name = new TextBox();
			this.item5Enable = new CheckBox();
			this.tabPage6 = new TabPage();
			this.item6Dur = new TextBox();
			this.groupBox11 = new GroupBox();
			this.item6ExcOpt3 = new CheckBox();
			this.item6ExcOpt2 = new CheckBox();
			this.item6ExcOpt1 = new CheckBox();
			this.item6ExcOpt6 = new CheckBox();
			this.item6ExcOpt5 = new CheckBox();
			this.item6ExcOptType = new ComboBox();
			this.item6ExcOpt4 = new CheckBox();
			this.item6Skill = new CheckBox();
			this.item6Luck = new CheckBox();
			this.item6Ancient = new ComboBox();
			this.item6Sckt = new ComboBox();
			this.item6Opt = new ComboBox();
			this.item6Lvl = new ComboBox();
			this.groupBox12 = new GroupBox();
			this.item6Price = new TextBox();
			this.item6Count = new TextBox();
			this.item6Name = new TextBox();
			this.item6Enable = new CheckBox();
			this.packageEnable = new RadioButton();
			this.bundleEnable = new RadioButton();
			this.packUnit = new ComboBox();
			this.itemIndexList = new ListBox();
			this.totalPages = new Label();
			this.currentPage = new Label();
			this.nextBtn = new Button();
			this.flowLayoutPanel1 = new FlowLayoutPanel();
			this.prevBtn = new Button();
			this.mainCutPanel = new Panel();
			this.statusStrip1 = new StatusStrip();
			this.statusicon = new ToolStripStatusLabel();
			this.statusinfo = new ToolStripStatusLabel();
			this.subCutPanel = new Panel();
			this.updatePack = new Button();
			this.addPack = new Button();
			this.itemImg = new PictureBox();
			this.packCurrency = new ComboBox();
			this.packType = new ComboBox();
			this.packCount = new TextBox();
			this.packDisc = new TextBox();
			this.packName = new TextBox();
			this.itemListBox = new ListBox();
			this.itemGroup = new ComboBox();
			this.workProgress = new ToolStripProgressBar();
			this.pleaseWait = new ToolStripStatusLabel();
			this.backgroundWorker_1 = new BackgroundWorker();
			this.menuStrip1.SuspendLayout();
			this.contexMenu.SuspendLayout();
			this.packageMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.bdPanel.SuspendLayout();
			this.addtoproductPanel.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage7.SuspendLayout();
			((ISupportInitialize)this.PrDGV).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((ISupportInitialize)this.bundleDGV).BeginInit();
			this.tabPage8.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.pcPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.itemTabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((ISupportInitialize)this.itemImg).BeginInit();
			base.SuspendLayout();
			this.menuStrip1.BackColor = Color.White;
			ToolStripItemCollection items = this.menuStrip1.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.fileToolStripMenuItem, this.editToolStripMenuItem, this.optionToolStripMenuItem, this.helpToolStripMenuItem };
			items.AddRange(toolStripItemArray);
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			this.fileToolStripMenuItem.BackColor = Color.White;
			ToolStripItemCollection dropDownItems = this.fileToolStripMenuItem.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.newProjectToolStripMenuItem, this.openToolStripMenuItem, this.previewDataTablesToolStripMenuItem, this.toolStripSeparator4, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.exportToolStripMenuItem, this.toolStripSeparator5, this.exitToolStripMenuItem };
			dropDownItems.AddRange(toolStripItemArray);
			this.fileToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.newProjectToolStripMenuItem.Image = Class9.smethod_18();
			this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
			this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.newProjectToolStripMenuItem.Text = "New Project";
			this.newProjectToolStripMenuItem.Click += new EventHandler(this.newProjectToolStripMenuItem_Click);
			this.openToolStripMenuItem.Image = Class9.smethod_21();
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
			this.previewDataTablesToolStripMenuItem.Image = Class9.smethod_8();
			this.previewDataTablesToolStripMenuItem.Name = "previewDataTablesToolStripMenuItem";
			this.previewDataTablesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.previewDataTablesToolStripMenuItem.Text = "Preview DataTables";
			this.previewDataTablesToolStripMenuItem.Click += new EventHandler(this.previewDataTablesToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(173, 6);
			this.saveToolStripMenuItem.Image = Class9.smethod_25();
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new EventHandler(this.saveToolStripMenuItem_Click);
			this.saveAsToolStripMenuItem.Image = Class9.smethod_26();
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
			this.exportToolStripMenuItem.Image = Class9.smethod_8();
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new EventHandler(this.exportToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
			this.exitToolStripMenuItem.Image = Class9.smethod_7();
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
			ToolStripItemCollection toolStripItemCollections = this.editToolStripMenuItem.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.resetDefaultToolStripMenuItem, this.toolStripSeparator6, this.mainCategoryToolStripMenuItem, this.packageTabToolStripMenuItem, this.toolStripSeparator7, this.clearAllDataToolStripMenuItem };
			toolStripItemCollections.AddRange(toolStripItemArray);
			this.editToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			this.resetDefaultToolStripMenuItem.Image = Class9.smethod_24();
			this.resetDefaultToolStripMenuItem.Name = "resetDefaultToolStripMenuItem";
			this.resetDefaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.resetDefaultToolStripMenuItem.Text = "Reset Default";
			this.resetDefaultToolStripMenuItem.Click += new EventHandler(this.resetDefaultToolStripMenuItem_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
			ToolStripItemCollection dropDownItems1 = this.mainCategoryToolStripMenuItem.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.addNewToolStripMenuItem1, this.editCategoriesToolStripMenuItem };
			dropDownItems1.AddRange(toolStripItemArray);
			this.mainCategoryToolStripMenuItem.Image = Class9.smethod_13();
			this.mainCategoryToolStripMenuItem.Name = "mainCategoryToolStripMenuItem";
			this.mainCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.mainCategoryToolStripMenuItem.Text = "Main Category";
			ToolStripItemCollection toolStripItemCollections1 = this.addNewToolStripMenuItem1.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.wCoinCShopToolStripMenuItem, this.wCoinsPShopToolStripMenuItem1, this.toolStripSeparator9, this.goblinPShopToolStripMenuItem };
			toolStripItemCollections1.AddRange(toolStripItemArray);
			this.addNewToolStripMenuItem1.Image = Class9.smethod_1();
			this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
			this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
			this.addNewToolStripMenuItem1.Text = "Add New";
			this.wCoinCShopToolStripMenuItem.Image = Class9.smethod_3();
			this.wCoinCShopToolStripMenuItem.Name = "wCoinCShopToolStripMenuItem";
			this.wCoinCShopToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.wCoinCShopToolStripMenuItem.Text = "W Coin (C) Shop";
			this.wCoinCShopToolStripMenuItem.Click += new EventHandler(this.wCoinsPShopToolStripMenuItem_Click);
			this.wCoinsPShopToolStripMenuItem1.Image = Class9.smethod_4();
			this.wCoinsPShopToolStripMenuItem1.Name = "wCoinsPShopToolStripMenuItem1";
			this.wCoinsPShopToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
			this.wCoinsPShopToolStripMenuItem1.Text = "W Coins (P) Shop";
			this.wCoinsPShopToolStripMenuItem1.Click += new EventHandler(this.wCoinsPShopToolStripMenuItem_Click);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(163, 6);
			this.goblinPShopToolStripMenuItem.Image = Class9.smethod_9();
			this.goblinPShopToolStripMenuItem.Name = "goblinPShopToolStripMenuItem";
			this.goblinPShopToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.goblinPShopToolStripMenuItem.Text = "Goblin (P) Shop";
			this.goblinPShopToolStripMenuItem.Click += new EventHandler(this.goblinPointsShopToolStripMenuItem_Click);
			this.editCategoriesToolStripMenuItem.Image = Class9.smethod_2();
			this.editCategoriesToolStripMenuItem.Name = "editCategoriesToolStripMenuItem";
			this.editCategoriesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.editCategoriesToolStripMenuItem.Text = "Clear";
			this.editCategoriesToolStripMenuItem.Click += new EventHandler(this.clearAllDataToolStripMenuItem_Click);
			ToolStripItemCollection dropDownItems2 = this.packageTabToolStripMenuItem.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.addNewToolStripMenuItem2, this.editToolStripMenuItem1 };
			dropDownItems2.AddRange(toolStripItemArray);
			this.packageTabToolStripMenuItem.Image = Class9.smethod_28();
			this.packageTabToolStripMenuItem.Name = "packageTabToolStripMenuItem";
			this.packageTabToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.packageTabToolStripMenuItem.Text = "Package Tab";
			this.addNewToolStripMenuItem2.Image = Class9.smethod_1();
			this.addNewToolStripMenuItem2.Name = "addNewToolStripMenuItem2";
			this.addNewToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
			this.addNewToolStripMenuItem2.Text = "Add New";
			this.addNewToolStripMenuItem2.Click += new EventHandler(this.addNewTabToolStripMenuItem_Click);
			this.editToolStripMenuItem1.Image = Class9.smethod_2();
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
			this.editToolStripMenuItem1.Text = "Clear";
			this.editToolStripMenuItem1.Click += new EventHandler(this.editToolStripMenuItem1_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
			this.clearAllDataToolStripMenuItem.Image = Class9.smethod_2();
			this.clearAllDataToolStripMenuItem.Name = "clearAllDataToolStripMenuItem";
			this.clearAllDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clearAllDataToolStripMenuItem.Text = "Clear Database";
			this.clearAllDataToolStripMenuItem.Click += new EventHandler(this.clearAllDataToolStripMenuItem_Click);
			ToolStripItemCollection toolStripItemCollections2 = this.optionToolStripMenuItem.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.generalSettingToolStripMenuItem };
			toolStripItemCollections2.AddRange(toolStripItemArray);
			this.optionToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
			this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
			this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionToolStripMenuItem.Text = "Option";
			this.generalSettingToolStripMenuItem.Image = Class9.smethod_22();
			this.generalSettingToolStripMenuItem.Name = "generalSettingToolStripMenuItem";
			this.generalSettingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.generalSettingToolStripMenuItem.Text = "General Setting";
			this.generalSettingToolStripMenuItem.Click += new EventHandler(this.generalSettingToolStripMenuItem_Click);
			ToolStripItemCollection dropDownItems3 = this.helpToolStripMenuItem.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.helpToolStripMenuItem1, this.aboutToolStripMenuItem };
			dropDownItems3.AddRange(toolStripItemArray);
			this.helpToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem1.Enabled = false;
			this.helpToolStripMenuItem1.Image = Class9.smethod_10();
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.helpToolStripMenuItem1.Text = "Help";
			this.aboutToolStripMenuItem.Image = Class9.smethod_30();
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
			ToolStripItemCollection items1 = this.contexMenu.Items;
			toolStripItemArray = new ToolStripItem[] { this.addNewTabToolStripMenuItem, this.addNewToolStripMenuItem, this.toolStripSeparator2, this.moveUpToolStripMenuItem, this.moveDownToolStripMenuItem, this.toolStripSeparator1, this.renameToolStripMenuItem, this.toolStripSeparator3, this.deleteToolStripMenuItem };
			items1.AddRange(toolStripItemArray);
			this.contexMenu.Name = "contexMenu";
			this.contexMenu.Size = new System.Drawing.Size(139, 154);
			this.contexMenu.Opening += new CancelEventHandler(this.contexMenu_Opening);
			this.addNewTabToolStripMenuItem.Image = Class9.smethod_1();
			this.addNewTabToolStripMenuItem.Name = "addNewTabToolStripMenuItem";
			this.addNewTabToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.addNewTabToolStripMenuItem.Text = "Add New";
			this.addNewTabToolStripMenuItem.Click += new EventHandler(this.addNewTabToolStripMenuItem_Click);
			ToolStripItemCollection toolStripItemCollections3 = this.addNewToolStripMenuItem.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.wCoinsShopToolStripMenuItem, this.wCoinsPShopToolStripMenuItem, this.toolStripSeparator8, this.goblinPointsShopToolStripMenuItem };
			toolStripItemCollections3.AddRange(toolStripItemArray);
			this.addNewToolStripMenuItem.Image = Class9.smethod_1();
			this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
			this.addNewToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.addNewToolStripMenuItem.Text = "Add New";
			this.wCoinsShopToolStripMenuItem.Image = Class9.smethod_3();
			this.wCoinsShopToolStripMenuItem.Name = "wCoinsShopToolStripMenuItem";
			this.wCoinsShopToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.wCoinsShopToolStripMenuItem.Text = "W Coin (C) Shop";
			this.wCoinsShopToolStripMenuItem.Click += new EventHandler(this.wCoinsPShopToolStripMenuItem_Click);
			this.wCoinsPShopToolStripMenuItem.Image = Class9.smethod_4();
			this.wCoinsPShopToolStripMenuItem.Name = "wCoinsPShopToolStripMenuItem";
			this.wCoinsPShopToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.wCoinsPShopToolStripMenuItem.Text = "W Coin (P) Shop";
			this.wCoinsPShopToolStripMenuItem.Click += new EventHandler(this.wCoinsPShopToolStripMenuItem_Click);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(159, 6);
			this.goblinPointsShopToolStripMenuItem.Image = Class9.smethod_9();
			this.goblinPointsShopToolStripMenuItem.Name = "goblinPointsShopToolStripMenuItem";
			this.goblinPointsShopToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.goblinPointsShopToolStripMenuItem.Text = "Goblin (P) Shop";
			this.goblinPointsShopToolStripMenuItem.Click += new EventHandler(this.goblinPointsShopToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
			this.moveUpToolStripMenuItem.Image = Class9.smethod_15();
			this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
			this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.moveUpToolStripMenuItem.Text = "Move Up";
			this.moveUpToolStripMenuItem.Click += new EventHandler(this.moveUpToolStripMenuItem_Click);
			this.moveDownToolStripMenuItem.Image = Class9.smethod_14();
			this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
			this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.moveDownToolStripMenuItem.Text = "Move Down";
			this.moveDownToolStripMenuItem.Click += new EventHandler(this.moveDownToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
			this.renameToolStripMenuItem.Image = Class9.smethod_18();
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new EventHandler(this.renameToolStripMenuItem_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
			this.deleteToolStripMenuItem.Image = Class9.smethod_5();
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
			ToolStripItemCollection items2 = this.packageMenu.Items;
			toolStripItemArray = new ToolStripItem[] { this.modifyPackagPackageMenu, this.toolStripSeparator11, this.moveUpPackageMenu, this.moveDownPackageMenu, this.toolStripSeparator10, this.deletPackageMenu };
			items2.AddRange(toolStripItemArray);
			this.packageMenu.Name = "packageMenu";
			this.packageMenu.Size = new System.Drawing.Size(160, 104);
			this.modifyPackagPackageMenu.Image = Class9.smethod_18();
			this.modifyPackagPackageMenu.Name = "modifyPackagPackageMenu";
			this.modifyPackagPackageMenu.Size = new System.Drawing.Size(159, 22);
			this.modifyPackagPackageMenu.Text = "Modify Package";
			this.modifyPackagPackageMenu.Click += new EventHandler(this.modifyPackagPackageMenu_Click);
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(156, 6);
			this.moveUpPackageMenu.Image = Class9.smethod_17();
			this.moveUpPackageMenu.Name = "moveUpPackageMenu";
			this.moveUpPackageMenu.Size = new System.Drawing.Size(159, 22);
			this.moveUpPackageMenu.Text = "Move Up";
			this.moveUpPackageMenu.Click += new EventHandler(this.moveUpPackageMenu_Click);
			this.moveDownPackageMenu.Image = Class9.smethod_14();
			this.moveDownPackageMenu.Name = "moveDownPackageMenu";
			this.moveDownPackageMenu.Size = new System.Drawing.Size(159, 22);
			this.moveDownPackageMenu.Text = "Move Down";
			this.moveDownPackageMenu.Click += new EventHandler(this.moveDownPackageMenu_Click);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(156, 6);
			this.deletPackageMenu.Image = Class9.smethod_5();
			this.deletPackageMenu.Name = "deletPackageMenu";
			this.deletPackageMenu.Size = new System.Drawing.Size(159, 22);
			this.deletPackageMenu.Text = "Delete Package";
			this.deletPackageMenu.Click += new EventHandler(this.deletPackageMenu_Click);
			this.saveFileDialog_0.AddExtension = false;
			this.saveFileDialog_0.DefaultExt = "dat";
			this.saveFileDialog_0.FileName = "CashShopData";
			this.saveFileDialog_0.Filter = "Text files (*.dat)|*.dat";
			this.saveFileDialog_0.Title = "Save Zythe CashShop Editor Data";
			this.saveFileDialog_0.FileOk += new CancelEventHandler(this.saveFileDialog_0_FileOk);
			this.openFileDialog_0.DefaultExt = "dat";
			this.openFileDialog_0.FileName = "openFileDialog1";
			this.openFileDialog_0.Filter = "Text files (*.dat)|*.dat";
			this.openFileDialog_0.Title = "Open Zythe CashShop Editor Data";
			this.openFileDialog_0.FileOk += new CancelEventHandler(this.openFileDialog_0_FileOk);
			//this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			//this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
			this.PName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.PName.HeaderText = "Product Name";
			this.PName.Name = "PName";
			this.PName.ReadOnly = true;
			this.PID.HeaderText = "PID";
			this.PID.Name = "PID";
			this.PID.ReadOnly = true;
			this.PID.Visible = false;
			this.panel1.BackColor = Color.White;
			this.panel1.BackgroundImage = Class9.smethod_31();
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.bdPanel);
			this.panel1.Controls.Add(this.pcPanel);
			this.panel1.Controls.Add(this.packageEnable);
			this.panel1.Controls.Add(this.bundleEnable);
			this.panel1.Controls.Add(this.packUnit);
			this.panel1.Controls.Add(this.itemIndexList);
			this.panel1.Controls.Add(this.totalPages);
			this.panel1.Controls.Add(this.currentPage);
			this.panel1.Controls.Add(this.nextBtn);
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Controls.Add(this.prevBtn);
			this.panel1.Controls.Add(this.mainCutPanel);
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.subCutPanel);
			this.panel1.Controls.Add(this.updatePack);
			this.panel1.Controls.Add(this.addPack);
			this.panel1.Controls.Add(this.itemImg);
			this.panel1.Controls.Add(this.packCurrency);
			this.panel1.Controls.Add(this.packType);
			this.panel1.Controls.Add(this.packCount);
			this.panel1.Controls.Add(this.packDisc);
			this.panel1.Controls.Add(this.packName);
			this.panel1.Controls.Add(this.itemListBox);
			this.panel1.Controls.Add(this.itemGroup);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1062, 529);
			this.panel1.TabIndex = 0;
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.Image = Class9.smethod_27();
			this.pictureBox1.Location = new Point(199, 93);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.TabIndex = 109;
			this.pictureBox1.TabStop = false;
			this.textBox1.Location = new Point(43, 90);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(174, 20);
			this.textBox1.TabIndex = 108;
			this.textBox1.Text = "Search Item";
			this.textBox1.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
			this.bdPanel.Controls.Add(this.addtoproductPanel);
			this.bdPanel.Controls.Add(this.tabControl1);
			this.bdPanel.Location = new Point(1096, 311);
			this.bdPanel.Name = "bdPanel";
			this.bdPanel.Size = new System.Drawing.Size(500, 168);
			this.bdPanel.TabIndex = 107;
			this.addtoproductPanel.Controls.Add(this.addNewProdBtn);
			this.addtoproductPanel.Location = new Point(233, -3);
			this.addtoproductPanel.Name = "addtoproductPanel";
			this.addtoproductPanel.Size = new System.Drawing.Size(261, 35);
			this.addtoproductPanel.TabIndex = 65;
			this.addtoproductPanel.Visible = false;
			this.addNewProdBtn.BackColor = SystemColors.Control;
			this.addNewProdBtn.Cursor = Cursors.Hand;
			this.addNewProdBtn.FlatAppearance.BorderColor = SystemColors.ControlDark;
			this.addNewProdBtn.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
			this.addNewProdBtn.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
			this.addNewProdBtn.FlatStyle = FlatStyle.Flat;
			this.addNewProdBtn.Font = new System.Drawing.Font("Arial Narrow", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.addNewProdBtn.ForeColor = Color.Black;
			this.addNewProdBtn.Image = Class9.smethod_1();
			this.addNewProdBtn.ImageAlign = ContentAlignment.MiddleLeft;
			this.addNewProdBtn.Location = new Point(140, 6);
			this.addNewProdBtn.Margin = new System.Windows.Forms.Padding(0);
			this.addNewProdBtn.Name = "addNewProdBtn";
			this.addNewProdBtn.Size = new System.Drawing.Size(116, 30);
			this.addNewProdBtn.TabIndex = 57;
			this.addNewProdBtn.Text = "\u00a0\u00a0\u00a0Add to Products";
			this.addNewProdBtn.UseVisualStyleBackColor = false;
			this.addNewProdBtn.Click += new EventHandler(this.addNewProdBtn_Click);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tabControl1.Location = new Point(5, 6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new Point(10, 6);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(492, 158);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabPage7.Controls.Add(this.bundlePrice);
			this.tabPage7.Controls.Add(this.addprod);
			this.tabPage7.Controls.Add(this.label1);
			this.tabPage7.Controls.Add(this.deleteprod);
			this.tabPage7.Controls.Add(this.PrDGV);
			this.tabPage7.Controls.Add(this.bundleDGV);
			this.tabPage7.Location = new Point(4, 28);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(484, 126);
			this.tabPage7.TabIndex = 0;
			this.tabPage7.Text = "Product Bundle";
			this.tabPage7.UseVisualStyleBackColor = true;
			this.bundlePrice.Location = new Point(10, 12);
			this.bundlePrice.Name = "bundlePrice";
			this.bundlePrice.Size = new System.Drawing.Size(80, 20);
			this.bundlePrice.TabIndex = 63;
			this.bundlePrice.Tag = "Enter Bundle Price";
			this.bundlePrice.Text = "Price";
			this.bundlePrice.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.addprod.BackColor = Color.White;
			this.addprod.Cursor = Cursors.Hand;
			this.addprod.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
			this.addprod.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
			this.addprod.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
			this.addprod.FlatStyle = FlatStyle.Flat;
			this.addprod.Font = new System.Drawing.Font("Arial Narrow", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.addprod.ForeColor = Color.Black;
			this.addprod.Image = Class9.smethod_1();
			this.addprod.Location = new Point(100, 11);
			this.addprod.Margin = new System.Windows.Forms.Padding(0);
			this.addprod.Name = "addprod";
			this.addprod.Size = new System.Drawing.Size(70, 22);
			this.addprod.TabIndex = 56;
			this.addprod.UseVisualStyleBackColor = false;
			this.addprod.Click += new EventHandler(this.addToBundleToolStripMenuItem_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.DarkSlateGray;
			this.label1.Location = new Point(6, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 62;
			this.deleteprod.BackColor = Color.White;
			this.deleteprod.Cursor = Cursors.Hand;
			this.deleteprod.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
			this.deleteprod.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
			this.deleteprod.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
			this.deleteprod.FlatStyle = FlatStyle.Flat;
			this.deleteprod.Font = new System.Drawing.Font("Arial Narrow", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.deleteprod.ForeColor = Color.Black;
			this.deleteprod.Image = Class9.smethod_5();
			this.deleteprod.Location = new Point(171, 11);
			this.deleteprod.Margin = new System.Windows.Forms.Padding(0);
			this.deleteprod.Name = "deleteprod";
			this.deleteprod.Size = new System.Drawing.Size(57, 22);
			this.deleteprod.TabIndex = 57;
			this.deleteprod.UseVisualStyleBackColor = false;
			this.deleteprod.Click += new EventHandler(this.deleteprod_Click);
			this.PrDGV.AllowUserToAddRows = false;
			this.PrDGV.AllowUserToDeleteRows = false;
			this.PrDGV.AllowUserToResizeColumns = false;
			this.PrDGV.AllowUserToResizeRows = false;
			this.PrDGV.BackgroundColor = Color.White;
			this.PrDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.PrDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.ControlLight;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = Color.OliveDrab;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.PrDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.PrDGV.ColumnHeadersHeight = 30;
			this.PrDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			DataGridViewColumnCollection columns = this.PrDGV.Columns;
			DataGridViewColumn[] dataGridViewColumnArray = new DataGridViewColumn[] { this.colProductID, this.colProductName };
			columns.AddRange(dataGridViewColumnArray);
			this.PrDGV.ContextMenuStrip = this.contextMenuStrip1;
			this.PrDGV.Dock = DockStyle.Right;
			this.PrDGV.GridColor = SystemColors.ControlDarkDark;
			this.PrDGV.Location = new Point(245, 3);
			this.PrDGV.MultiSelect = false;
			this.PrDGV.Name = "PrDGV";
			this.PrDGV.ReadOnly = true;
			this.PrDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			this.PrDGV.RowHeadersVisible = false;
			this.PrDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			font.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			font.ForeColor = Color.Black;
			this.PrDGV.RowsDefaultCellStyle = font;
			this.PrDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.PrDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
			this.PrDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
			this.PrDGV.RowTemplate.ReadOnly = true;
			this.PrDGV.RowTemplate.Resizable = DataGridViewTriState.False;
			this.PrDGV.ScrollBars = ScrollBars.Vertical;
			this.PrDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.PrDGV.Size = new System.Drawing.Size(236, 120);
			this.PrDGV.TabIndex = 61;
			this.PrDGV.CellMouseDown += new DataGridViewCellMouseEventHandler(this.PrDGV_CellMouseDown);
			this.colProductID.HeaderText = "colProductID";
			this.colProductID.Name = "colProductID";
			this.colProductID.ReadOnly = true;
			this.colProductID.Visible = false;
			this.colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			white.BackColor = Color.White;
			white.ForeColor = Color.DarkOliveGreen;
			this.colProductName.DefaultCellStyle = white;
			this.colProductName.HeaderText = "Product Database";
			this.colProductName.Name = "colProductName";
			this.colProductName.ReadOnly = true;
			this.colProductName.Resizable = DataGridViewTriState.False;
			ToolStripItemCollection items3 = this.contextMenuStrip1.Items;
			toolStripItemArray = new ToolStripItem[] { this.addToBundleToolStripMenuItem, this.modifyProductToolStripMenuItem, this.deleteProductToolStripMenuItem };
			items3.AddRange(toolStripItemArray);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
			this.contextMenuStrip1.Opening += new CancelEventHandler(this.contextMenuStrip1_Opening);
			this.addToBundleToolStripMenuItem.Image = Class9.smethod_1();
			this.addToBundleToolStripMenuItem.Name = "addToBundleToolStripMenuItem";
			this.addToBundleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.addToBundleToolStripMenuItem.Text = "Add to Bundle";
			this.addToBundleToolStripMenuItem.Click += new EventHandler(this.addToBundleToolStripMenuItem_Click);
			this.modifyProductToolStripMenuItem.Image = Class9.smethod_18();
			this.modifyProductToolStripMenuItem.Name = "modifyProductToolStripMenuItem";
			this.modifyProductToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.modifyProductToolStripMenuItem.Text = "Modify Product";
			this.modifyProductToolStripMenuItem.Click += new EventHandler(this.modifyProductToolStripMenuItem_Click);
			this.deleteProductToolStripMenuItem.Image = Class9.smethod_5();
			this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
			this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.deleteProductToolStripMenuItem.Text = "Delete Product";
			this.deleteProductToolStripMenuItem.Click += new EventHandler(this.deleteProductToolStripMenuItem_Click);
			this.bundleDGV.AllowUserToAddRows = false;
			this.bundleDGV.AllowUserToDeleteRows = false;
			this.bundleDGV.AllowUserToResizeColumns = false;
			this.bundleDGV.AllowUserToResizeRows = false;
			this.bundleDGV.BackgroundColor = Color.White;
			this.bundleDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.bundleDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bundleDGV.ColumnHeadersVisible = false;
			DataGridViewColumnCollection dataGridViewColumnCollections = this.bundleDGV.Columns;
			dataGridViewColumnArray = new DataGridViewColumn[] { this.inProductID, this.inProductName };
			dataGridViewColumnCollections.AddRange(dataGridViewColumnArray);
			this.bundleDGV.ContextMenuStrip = this.contextMenuStrip1;
			this.bundleDGV.Location = new Point(1, 38);
			this.bundleDGV.MultiSelect = false;
			this.bundleDGV.Name = "bundleDGV";
			this.bundleDGV.ReadOnly = true;
			this.bundleDGV.RowHeadersVisible = false;
			this.bundleDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.bundleDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bundleDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
			this.bundleDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
			this.bundleDGV.ScrollBars = ScrollBars.Vertical;
			this.bundleDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.bundleDGV.Size = new System.Drawing.Size(227, 85);
			this.bundleDGV.TabIndex = 59;
			this.bundleDGV.CellMouseDown += new DataGridViewCellMouseEventHandler(this.bundleDGV_CellMouseDown);
			this.inProductID.HeaderText = "inProductID";
			this.inProductID.Name = "inProductID";
			this.inProductID.ReadOnly = true;
			this.inProductID.Visible = false;
			this.inProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.inProductName.HeaderText = "inProductName";
			this.inProductName.Name = "inProductName";
			this.inProductName.ReadOnly = true;
			this.inProductName.Resizable = DataGridViewTriState.False;
			this.tabPage8.Controls.Add(this.newPrDur);
			this.tabPage8.Controls.Add(this.groupBox13);
			this.tabPage8.Controls.Add(this.newPrSkill);
			this.tabPage8.Controls.Add(this.newPrLuck);
			this.tabPage8.Controls.Add(this.newPrAncient);
			this.tabPage8.Controls.Add(this.newPrSckt);
			this.tabPage8.Controls.Add(this.newPrOpt);
			this.tabPage8.Controls.Add(this.newPrLvl);
			this.tabPage8.Controls.Add(this.groupBox14);
			this.tabPage8.ForeColor = SystemColors.ActiveCaptionText;
			this.tabPage8.Location = new Point(4, 28);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Size = new System.Drawing.Size(484, 126);
			this.tabPage8.TabIndex = 1;
			this.tabPage8.Text = "Add New Product";
			this.tabPage8.UseVisualStyleBackColor = true;
			this.newPrDur.Location = new Point(216, 43);
			this.newPrDur.Name = "newPrDur";
			this.newPrDur.Size = new System.Drawing.Size(48, 20);
			this.newPrDur.TabIndex = 45;
			this.newPrDur.Tag = "Item durability";
			this.newPrDur.Text = "Dur";
			this.newPrDur.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.groupBox13.BackColor = Color.Transparent;
			this.groupBox13.Controls.Add(this.newPrOpt6);
			this.groupBox13.Controls.Add(this.newPrOpt5);
			this.groupBox13.Controls.Add(this.newPrOpt4);
			this.groupBox13.Controls.Add(this.newPrOpt3);
			this.groupBox13.Controls.Add(this.newPrOpt2);
			this.groupBox13.Controls.Add(this.newPrOpt1);
			this.groupBox13.Controls.Add(this.newP7rExcOptType);
			this.groupBox13.Location = new Point(270, 10);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(208, 106);
			this.groupBox13.TabIndex = 50;
			this.groupBox13.TabStop = false;
			this.newPrOpt6.AutoSize = true;
			this.newPrOpt6.BackColor = Color.Transparent;
			this.newPrOpt6.ForeColor = SystemColors.InfoText;
			this.newPrOpt6.Location = new Point(107, 74);
			this.newPrOpt6.Name = "newPrOpt6";
			this.newPrOpt6.Size = new System.Drawing.Size(94, 17);
			this.newPrOpt6.TabIndex = 23;
			this.newPrOpt6.Tag = "";
			this.newPrOpt6.Text = "Zen Drop +3%";
			this.newPrOpt6.UseVisualStyleBackColor = false;
			this.newPrOpt5.AutoSize = true;
			this.newPrOpt5.BackColor = Color.Transparent;
			this.newPrOpt5.ForeColor = SystemColors.InfoText;
			this.newPrOpt5.Location = new Point(107, 50);
			this.newPrOpt5.Name = "newPrOpt5";
			this.newPrOpt5.Size = new System.Drawing.Size(94, 17);
			this.newPrOpt5.TabIndex = 22;
			this.newPrOpt5.Tag = "";
			this.newPrOpt5.Text = "Zen Drop +3%";
			this.newPrOpt5.UseVisualStyleBackColor = false;
			this.newPrOpt4.AutoSize = true;
			this.newPrOpt4.BackColor = Color.Transparent;
			this.newPrOpt4.ForeColor = SystemColors.InfoText;
			this.newPrOpt4.Location = new Point(107, 27);
			this.newPrOpt4.Name = "newPrOpt4";
			this.newPrOpt4.Size = new System.Drawing.Size(94, 17);
			this.newPrOpt4.TabIndex = 21;
			this.newPrOpt4.Tag = "";
			this.newPrOpt4.Text = "Zen Drop +3%";
			this.newPrOpt4.UseVisualStyleBackColor = false;
			this.newPrOpt3.AutoSize = true;
			this.newPrOpt3.BackColor = Color.Transparent;
			this.newPrOpt3.ForeColor = SystemColors.InfoText;
			this.newPrOpt3.Location = new Point(10, 74);
			this.newPrOpt3.Name = "newPrOpt3";
			this.newPrOpt3.Size = new System.Drawing.Size(94, 17);
			this.newPrOpt3.TabIndex = 20;
			this.newPrOpt3.Tag = "";
			this.newPrOpt3.Text = "Zen Drp +30%";
			this.newPrOpt3.UseVisualStyleBackColor = false;
			this.newPrOpt2.AutoSize = true;
			this.newPrOpt2.BackColor = Color.Transparent;
			this.newPrOpt2.ForeColor = SystemColors.InfoText;
			this.newPrOpt2.Location = new Point(10, 50);
			this.newPrOpt2.Name = "newPrOpt2";
			this.newPrOpt2.Size = new System.Drawing.Size(94, 17);
			this.newPrOpt2.TabIndex = 19;
			this.newPrOpt2.Tag = "";
			this.newPrOpt2.Text = "Zen Drp +30%";
			this.newPrOpt2.UseVisualStyleBackColor = false;
			this.newPrOpt1.AutoSize = true;
			this.newPrOpt1.BackColor = Color.Transparent;
			this.newPrOpt1.ForeColor = SystemColors.InfoText;
			this.newPrOpt1.Location = new Point(10, 27);
			this.newPrOpt1.Name = "newPrOpt1";
			this.newPrOpt1.Size = new System.Drawing.Size(94, 17);
			this.newPrOpt1.TabIndex = 18;
			this.newPrOpt1.Tag = "";
			this.newPrOpt1.Text = "Zen Drp +30%";
			this.newPrOpt1.UseVisualStyleBackColor = false;
			this.newP7rExcOptType.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections = this.newP7rExcOptType.Items;
			object[] objArray = new object[] { "Exc Opt. Weapon", "Exc Opt. Armor", "Exc Opt. Wings" };
			objectCollections.AddRange(objArray);
			this.newP7rExcOptType.Location = new Point(11, 0);
			this.newP7rExcOptType.Name = "newP7rExcOptType";
			this.newP7rExcOptType.Size = new System.Drawing.Size(102, 21);
			this.newP7rExcOptType.TabIndex = 99;
			this.newP7rExcOptType.Tag = "Excellent Option Type";
			this.newP7rExcOptType.Text = "Excellent Option";
			this.newP7rExcOptType.SelectedIndexChanged += new EventHandler(this.item6ExcOptType_SelectedIndexChanged);
			this.newPrSkill.AutoSize = true;
			this.newPrSkill.BackColor = Color.Transparent;
			this.newPrSkill.ForeColor = SystemColors.InfoText;
			this.newPrSkill.Location = new Point(214, 73);
			this.newPrSkill.Name = "newPrSkill";
			this.newPrSkill.Size = new System.Drawing.Size(45, 17);
			this.newPrSkill.TabIndex = 47;
			this.newPrSkill.Tag = "Item skill";
			this.newPrSkill.Text = "Skill";
			this.newPrSkill.UseVisualStyleBackColor = false;
			this.newPrLuck.AutoSize = true;
			this.newPrLuck.BackColor = Color.Transparent;
			this.newPrLuck.ForeColor = SystemColors.InfoText;
			this.newPrLuck.Location = new Point(162, 73);
			this.newPrLuck.Name = "newPrLuck";
			this.newPrLuck.Size = new System.Drawing.Size(50, 17);
			this.newPrLuck.TabIndex = 46;
			this.newPrLuck.Tag = "ltem Luck";
			this.newPrLuck.Text = "Luck";
			this.newPrLuck.UseVisualStyleBackColor = false;
			this.newPrAncient.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections1 = this.newPrAncient.Items;
			objArray = new object[] { "No Ancient", "Ancient Lvl 1", "Ancient Lvl 2" };
			objectCollections1.AddRange(objArray);
			this.newPrAncient.Location = new Point(162, 95);
			this.newPrAncient.Name = "newPrAncient";
			this.newPrAncient.Size = new System.Drawing.Size(102, 21);
			this.newPrAncient.TabIndex = 48;
			this.newPrAncient.Tag = "Ancient option";
			this.newPrAncient.Text = "Ancient";
			this.newPrSckt.FormattingEnabled = true;
			this.newPrSckt.Location = new Point(162, 43);
			this.newPrSckt.Name = "newPrSckt";
			this.newPrSckt.Size = new System.Drawing.Size(48, 21);
			this.newPrSckt.TabIndex = 44;
			this.newPrSckt.Tag = "Number of socket";
			this.newPrSckt.Text = "Sckt";
			this.newPrOpt.FormattingEnabled = true;
			this.newPrOpt.Location = new Point(216, 16);
			this.newPrOpt.Name = "newPrOpt";
			this.newPrOpt.Size = new System.Drawing.Size(48, 21);
			this.newPrOpt.TabIndex = 43;
			this.newPrOpt.Tag = "Item option";
			this.newPrOpt.Text = "Opt";
			this.newPrLvl.FormattingEnabled = true;
			this.newPrLvl.Location = new Point(162, 16);
			this.newPrLvl.Name = "newPrLvl";
			this.newPrLvl.Size = new System.Drawing.Size(48, 21);
			this.newPrLvl.TabIndex = 42;
			this.newPrLvl.Tag = "Item Level";
			this.newPrLvl.Text = "Lvl";
			this.groupBox14.BackColor = Color.Transparent;
			this.groupBox14.Controls.Add(this.newPrPrice);
			this.groupBox14.Controls.Add(this.newPrCount);
			this.groupBox14.Controls.Add(this.newPrPname);
			this.groupBox14.Location = new Point(6, 10);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(149, 106);
			this.groupBox14.TabIndex = 49;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Product Info";
			this.newPrPrice.Location = new Point(73, 70);
			this.newPrPrice.Name = "newPrPrice";
			this.newPrPrice.Size = new System.Drawing.Size(69, 20);
			this.newPrPrice.TabIndex = 10;
			this.newPrPrice.Tag = "Product Price";
			this.newPrPrice.Text = "Price";
			this.newPrPrice.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.newPrCount.Location = new Point(8, 70);
			this.newPrCount.Name = "newPrCount";
			this.newPrCount.Size = new System.Drawing.Size(59, 20);
			this.newPrCount.TabIndex = 9;
			this.newPrCount.Tag = "Item Count or Quantity";
			this.newPrCount.Text = "Count";
			this.newPrCount.TextChanged += new EventHandler(this.newPrCount_TextChanged);
			this.newPrCount.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.newPrPname.Location = new Point(8, 36);
			this.newPrPname.Name = "newPrPname";
			this.newPrPname.Size = new System.Drawing.Size(134, 20);
			this.newPrPname.TabIndex = 8;
			this.newPrPname.Tag = "Product Name";
			this.newPrPname.Text = "Name";
			this.newPrPname.TextChanged += new EventHandler(this.newPrPname_TextChanged);
			this.newPrPname.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.pcPanel.Controls.Add(this.panel2);
			this.pcPanel.Controls.Add(this.panel3);
			this.pcPanel.Controls.Add(this.itemTabs);
			this.pcPanel.Location = new Point(1096, 60);
			this.pcPanel.Name = "pcPanel";
			this.pcPanel.Size = new System.Drawing.Size(500, 168);
			this.pcPanel.TabIndex = 106;
			this.panel2.BackColor = Color.Transparent;
			this.panel2.Controls.Add(this.enableMultiPack);
			this.panel2.Location = new Point(377, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(116, 26);
			this.panel2.TabIndex = 46;
			this.enableMultiPack.AutoSize = true;
			this.enableMultiPack.BackColor = Color.Transparent;
			this.enableMultiPack.ForeColor = SystemColors.InfoText;
			this.enableMultiPack.Location = new Point(18, 4);
			this.enableMultiPack.Name = "enableMultiPack";
			this.enableMultiPack.Size = new System.Drawing.Size(94, 17);
			this.enableMultiPack.TabIndex = 22;
			this.enableMultiPack.Text = "Multi Package";
			this.enableMultiPack.UseVisualStyleBackColor = false;
			this.enableMultiPack.CheckedChanged += new EventHandler(this.enableMultiPack_CheckedChanged);
			this.panel3.BackColor = Color.White;
			this.panel3.Location = new Point(98, 6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(280, 26);
			this.panel3.TabIndex = 48;
			this.itemTabs.Controls.Add(this.tabPage1);
			this.itemTabs.Controls.Add(this.tabPage2);
			this.itemTabs.Controls.Add(this.tabPage3);
			this.itemTabs.Controls.Add(this.tabPage4);
			this.itemTabs.Controls.Add(this.tabPage5);
			this.itemTabs.Controls.Add(this.tabPage6);
			this.itemTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.itemTabs.ItemSize = new System.Drawing.Size(89, 24);
			this.itemTabs.Location = new Point(5, 6);
			this.itemTabs.Multiline = true;
			this.itemTabs.Name = "itemTabs";
			this.itemTabs.Padding = new Point(10, 6);
			this.itemTabs.SelectedIndex = 0;
			this.itemTabs.Size = new System.Drawing.Size(492, 158);
			this.itemTabs.SizeMode = TabSizeMode.FillToRight;
			this.itemTabs.TabIndex = 20;
			this.itemTabs.Tag = "";
			this.tabPage1.Controls.Add(this.item1Dur);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.item1Skill);
			this.tabPage1.Controls.Add(this.item1Luck);
			this.tabPage1.Controls.Add(this.item1Ancient);
			this.tabPage1.Controls.Add(this.item1Sckt);
			this.tabPage1.Controls.Add(this.item1Opt);
			this.tabPage1.Controls.Add(this.item1Lvl);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(484, 126);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main Package";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.item1Dur.Location = new Point(216, 43);
			this.item1Dur.Name = "item1Dur";
			this.item1Dur.Size = new System.Drawing.Size(48, 20);
			this.item1Dur.TabIndex = 14;
			this.item1Dur.Tag = "Item durability";
			this.item1Dur.Text = "Dur";
			this.item1Dur.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.groupBox2.BackColor = Color.Transparent;
			this.groupBox2.Controls.Add(this.item1ExcOpt3);
			this.groupBox2.Controls.Add(this.item1ExcOpt2);
			this.groupBox2.Controls.Add(this.item1ExcOpt1);
			this.groupBox2.Controls.Add(this.item1ExcOpt6);
			this.groupBox2.Controls.Add(this.item1ExcOpt5);
			this.groupBox2.Controls.Add(this.item1ExcOptType);
			this.groupBox2.Controls.Add(this.item1ExcOpt4);
			this.groupBox2.Location = new Point(270, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(208, 106);
			this.groupBox2.TabIndex = 41;
			this.groupBox2.TabStop = false;
			this.item1ExcOpt3.AutoSize = true;
			this.item1ExcOpt3.BackColor = Color.Transparent;
			this.item1ExcOpt3.ForeColor = SystemColors.InfoText;
			this.item1ExcOpt3.Location = new Point(10, 74);
			this.item1ExcOpt3.Name = "item1ExcOpt3";
			this.item1ExcOpt3.Size = new System.Drawing.Size(94, 17);
			this.item1ExcOpt3.TabIndex = 20;
			this.item1ExcOpt3.Tag = "";
			this.item1ExcOpt3.Text = "Zen Drp +30%";
			this.item1ExcOpt3.UseVisualStyleBackColor = false;
			this.item1ExcOpt2.AutoSize = true;
			this.item1ExcOpt2.BackColor = Color.Transparent;
			this.item1ExcOpt2.ForeColor = SystemColors.InfoText;
			this.item1ExcOpt2.Location = new Point(10, 50);
			this.item1ExcOpt2.Name = "item1ExcOpt2";
			this.item1ExcOpt2.Size = new System.Drawing.Size(94, 17);
			this.item1ExcOpt2.TabIndex = 19;
			this.item1ExcOpt2.Tag = "";
			this.item1ExcOpt2.Text = "Zen Drp +30%";
			this.item1ExcOpt2.UseVisualStyleBackColor = false;
			this.item1ExcOpt1.AutoSize = true;
			this.item1ExcOpt1.BackColor = Color.Transparent;
			this.item1ExcOpt1.ForeColor = SystemColors.InfoText;
			this.item1ExcOpt1.Location = new Point(10, 27);
			this.item1ExcOpt1.Name = "item1ExcOpt1";
			this.item1ExcOpt1.Size = new System.Drawing.Size(94, 17);
			this.item1ExcOpt1.TabIndex = 18;
			this.item1ExcOpt1.Tag = "";
			this.item1ExcOpt1.Text = "Zen Drp +30%";
			this.item1ExcOpt1.UseVisualStyleBackColor = false;
			this.item1ExcOpt6.AutoSize = true;
			this.item1ExcOpt6.BackColor = Color.Transparent;
			this.item1ExcOpt6.ForeColor = SystemColors.InfoText;
			this.item1ExcOpt6.Location = new Point(107, 74);
			this.item1ExcOpt6.Name = "item1ExcOpt6";
			this.item1ExcOpt6.Size = new System.Drawing.Size(94, 17);
			this.item1ExcOpt6.TabIndex = 23;
			this.item1ExcOpt6.Tag = "";
			this.item1ExcOpt6.Text = "Zen Drop +3%";
			this.item1ExcOpt6.UseVisualStyleBackColor = false;
			this.item1ExcOpt5.AutoSize = true;
			this.item1ExcOpt5.BackColor = Color.Transparent;
			this.item1ExcOpt5.ForeColor = SystemColors.InfoText;
			this.item1ExcOpt5.Location = new Point(107, 50);
			this.item1ExcOpt5.Name = "item1ExcOpt5";
			this.item1ExcOpt5.Size = new System.Drawing.Size(94, 17);
			this.item1ExcOpt5.TabIndex = 22;
			this.item1ExcOpt5.Tag = "";
			this.item1ExcOpt5.Text = "Zen Drop +3%";
			this.item1ExcOpt5.UseVisualStyleBackColor = false;
			this.item1ExcOptType.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections2 = this.item1ExcOptType.Items;
			objArray = new object[] { "Exc Opt. Weapon", "Exc Opt. Armor", "Exc Opt. Wings" };
			objectCollections2.AddRange(objArray);
			this.item1ExcOptType.Location = new Point(11, 0);
			this.item1ExcOptType.Name = "item1ExcOptType";
			this.item1ExcOptType.Size = new System.Drawing.Size(102, 21);
			this.item1ExcOptType.TabIndex = 99;
			this.item1ExcOptType.Tag = "Excellent Option Type";
			this.item1ExcOptType.Text = "Excellent Option";
			this.item1ExcOptType.SelectedIndexChanged += new EventHandler(this.item6ExcOptType_SelectedIndexChanged);
			this.item1ExcOpt4.AutoSize = true;
			this.item1ExcOpt4.BackColor = Color.Transparent;
			this.item1ExcOpt4.ForeColor = SystemColors.InfoText;
			this.item1ExcOpt4.Location = new Point(107, 27);
			this.item1ExcOpt4.Name = "item1ExcOpt4";
			this.item1ExcOpt4.Size = new System.Drawing.Size(94, 17);
			this.item1ExcOpt4.TabIndex = 21;
			this.item1ExcOpt4.Tag = "";
			this.item1ExcOpt4.Text = "Zen Drop +3%";
			this.item1ExcOpt4.UseVisualStyleBackColor = false;
			this.item1Skill.AutoSize = true;
			this.item1Skill.BackColor = Color.Transparent;
			this.item1Skill.ForeColor = SystemColors.InfoText;
			this.item1Skill.Location = new Point(214, 73);
			this.item1Skill.Name = "item1Skill";
			this.item1Skill.Size = new System.Drawing.Size(45, 17);
			this.item1Skill.TabIndex = 16;
			this.item1Skill.Tag = "Item skill";
			this.item1Skill.Text = "Skill";
			this.item1Skill.UseVisualStyleBackColor = false;
			this.item1Luck.AutoSize = true;
			this.item1Luck.BackColor = Color.Transparent;
			this.item1Luck.ForeColor = SystemColors.InfoText;
			this.item1Luck.Location = new Point(162, 73);
			this.item1Luck.Name = "item1Luck";
			this.item1Luck.Size = new System.Drawing.Size(50, 17);
			this.item1Luck.TabIndex = 15;
			this.item1Luck.Tag = "ltem Luck";
			this.item1Luck.Text = "Luck";
			this.item1Luck.UseVisualStyleBackColor = false;
			this.item1Ancient.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections3 = this.item1Ancient.Items;
			objArray = new object[] { "No Ancient", "Ancient Lvl 1", "Ancient Lvl 2" };
			objectCollections3.AddRange(objArray);
			this.item1Ancient.Location = new Point(162, 95);
			this.item1Ancient.Name = "item1Ancient";
			this.item1Ancient.Size = new System.Drawing.Size(102, 21);
			this.item1Ancient.TabIndex = 17;
			this.item1Ancient.Tag = "Ancient option";
			this.item1Ancient.Text = "Ancient";
			this.item1Sckt.FormattingEnabled = true;
			this.item1Sckt.Location = new Point(162, 43);
			this.item1Sckt.Name = "item1Sckt";
			this.item1Sckt.Size = new System.Drawing.Size(48, 21);
			this.item1Sckt.TabIndex = 13;
			this.item1Sckt.Tag = "Number of socket";
			this.item1Sckt.Text = "Sckt";
			this.item1Opt.FormattingEnabled = true;
			this.item1Opt.Location = new Point(216, 16);
			this.item1Opt.Name = "item1Opt";
			this.item1Opt.Size = new System.Drawing.Size(48, 21);
			this.item1Opt.TabIndex = 12;
			this.item1Opt.Tag = "Item option";
			this.item1Opt.Text = "Opt";
			this.item1Lvl.FormattingEnabled = true;
			this.item1Lvl.Location = new Point(162, 16);
			this.item1Lvl.Name = "item1Lvl";
			this.item1Lvl.Size = new System.Drawing.Size(48, 21);
			this.item1Lvl.TabIndex = 11;
			this.item1Lvl.Tag = "Item Level";
			this.item1Lvl.Text = "Lvl";
			this.groupBox1.BackColor = Color.Transparent;
			this.groupBox1.Controls.Add(this.item1Price);
			this.groupBox1.Controls.Add(this.item1Count);
			this.groupBox1.Controls.Add(this.item1Name);
			this.groupBox1.Controls.Add(this.item1Enable);
			this.groupBox1.Location = new Point(6, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(149, 106);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			this.item1Price.Location = new Point(73, 70);
			this.item1Price.Name = "item1Price";
			this.item1Price.Size = new System.Drawing.Size(69, 20);
			this.item1Price.TabIndex = 10;
			this.item1Price.Tag = "Item Price";
			this.item1Price.Text = "Price";
			this.item1Price.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item1Count.Location = new Point(8, 70);
			this.item1Count.Name = "item1Count";
			this.item1Count.Size = new System.Drawing.Size(59, 20);
			this.item1Count.TabIndex = 9;
			this.item1Count.Tag = "Item Count or Quantity";
			this.item1Count.Text = "Count";
			this.item1Count.TextChanged += new EventHandler(this.item1Count_TextChanged);
			this.item1Count.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item1Name.Location = new Point(8, 36);
			this.item1Name.Name = "item1Name";
			this.item1Name.Size = new System.Drawing.Size(134, 20);
			this.item1Name.TabIndex = 8;
			this.item1Name.Tag = "Item Name";
			this.item1Name.Text = "Name";
			this.item1Name.TextChanged += new EventHandler(this.item1Name_TextChanged);
			this.item1Name.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.item1Enable.AutoSize = true;
			this.item1Enable.BackColor = Color.White;
			this.item1Enable.Checked = true;
			this.item1Enable.CheckState = CheckState.Checked;
			this.item1Enable.Enabled = false;
			this.item1Enable.FlatStyle = FlatStyle.Popup;
			this.item1Enable.ForeColor = SystemColors.InfoText;
			this.item1Enable.Location = new Point(8, -1);
			this.item1Enable.Name = "item1Enable";
			this.item1Enable.Size = new System.Drawing.Size(57, 17);
			this.item1Enable.TabIndex = 38;
			this.item1Enable.Tag = "1";
			this.item1Enable.Text = "Enable";
			this.item1Enable.UseVisualStyleBackColor = false;
			this.tabPage2.Controls.Add(this.item2Dur);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.item2Skill);
			this.tabPage2.Controls.Add(this.item2Luck);
			this.tabPage2.Controls.Add(this.item2Ancient);
			this.tabPage2.Controls.Add(this.item2Sckt);
			this.tabPage2.Controls.Add(this.item2Opt);
			this.tabPage2.Controls.Add(this.item2Lvl);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.ForeColor = SystemColors.ControlText;
			this.tabPage2.Location = new Point(4, 28);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(484, 126);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Pack 2";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.item2Dur.Enabled = false;
			this.item2Dur.Location = new Point(216, 43);
			this.item2Dur.Name = "item2Dur";
			this.item2Dur.Size = new System.Drawing.Size(48, 20);
			this.item2Dur.TabIndex = 48;
			this.item2Dur.Text = "Dur";
			this.item2Dur.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.groupBox3.BackColor = Color.Transparent;
			this.groupBox3.Controls.Add(this.item2ExcOpt3);
			this.groupBox3.Controls.Add(this.item2ExcOpt2);
			this.groupBox3.Controls.Add(this.item2ExcOpt1);
			this.groupBox3.Controls.Add(this.item2ExcOpt6);
			this.groupBox3.Controls.Add(this.item2ExcOpt5);
			this.groupBox3.Controls.Add(this.item2ExcOptType);
			this.groupBox3.Controls.Add(this.item2ExcOpt4);
			this.groupBox3.Location = new Point(270, 10);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(208, 106);
			this.groupBox3.TabIndex = 41;
			this.groupBox3.TabStop = false;
			this.item2ExcOpt3.AutoSize = true;
			this.item2ExcOpt3.BackColor = Color.Transparent;
			this.item2ExcOpt3.Enabled = false;
			this.item2ExcOpt3.ForeColor = SystemColors.InfoText;
			this.item2ExcOpt3.Location = new Point(10, 74);
			this.item2ExcOpt3.Name = "item2ExcOpt3";
			this.item2ExcOpt3.Size = new System.Drawing.Size(94, 17);
			this.item2ExcOpt3.TabIndex = 47;
			this.item2ExcOpt3.Tag = "";
			this.item2ExcOpt3.Text = "Zen Drp +30%";
			this.item2ExcOpt3.UseVisualStyleBackColor = false;
			this.item2ExcOpt2.AutoSize = true;
			this.item2ExcOpt2.BackColor = Color.Transparent;
			this.item2ExcOpt2.Enabled = false;
			this.item2ExcOpt2.ForeColor = SystemColors.InfoText;
			this.item2ExcOpt2.Location = new Point(10, 50);
			this.item2ExcOpt2.Name = "item2ExcOpt2";
			this.item2ExcOpt2.Size = new System.Drawing.Size(94, 17);
			this.item2ExcOpt2.TabIndex = 46;
			this.item2ExcOpt2.Tag = "";
			this.item2ExcOpt2.Text = "Zen Drp +30%";
			this.item2ExcOpt2.UseVisualStyleBackColor = false;
			this.item2ExcOpt1.AutoSize = true;
			this.item2ExcOpt1.BackColor = Color.Transparent;
			this.item2ExcOpt1.Enabled = false;
			this.item2ExcOpt1.ForeColor = SystemColors.InfoText;
			this.item2ExcOpt1.Location = new Point(10, 27);
			this.item2ExcOpt1.Name = "item2ExcOpt1";
			this.item2ExcOpt1.Size = new System.Drawing.Size(94, 17);
			this.item2ExcOpt1.TabIndex = 45;
			this.item2ExcOpt1.Tag = "";
			this.item2ExcOpt1.Text = "Zen Drp +30%";
			this.item2ExcOpt1.UseVisualStyleBackColor = false;
			this.item2ExcOpt6.AutoSize = true;
			this.item2ExcOpt6.BackColor = Color.Transparent;
			this.item2ExcOpt6.Enabled = false;
			this.item2ExcOpt6.ForeColor = SystemColors.InfoText;
			this.item2ExcOpt6.Location = new Point(107, 74);
			this.item2ExcOpt6.Name = "item2ExcOpt6";
			this.item2ExcOpt6.Size = new System.Drawing.Size(94, 17);
			this.item2ExcOpt6.TabIndex = 44;
			this.item2ExcOpt6.Tag = "";
			this.item2ExcOpt6.Text = "Zen Drop +3%";
			this.item2ExcOpt6.UseVisualStyleBackColor = false;
			this.item2ExcOpt5.AutoSize = true;
			this.item2ExcOpt5.BackColor = Color.Transparent;
			this.item2ExcOpt5.Enabled = false;
			this.item2ExcOpt5.ForeColor = SystemColors.InfoText;
			this.item2ExcOpt5.Location = new Point(107, 50);
			this.item2ExcOpt5.Name = "item2ExcOpt5";
			this.item2ExcOpt5.Size = new System.Drawing.Size(94, 17);
			this.item2ExcOpt5.TabIndex = 43;
			this.item2ExcOpt5.Tag = "";
			this.item2ExcOpt5.Text = "Zen Drop +3%";
			this.item2ExcOpt5.UseVisualStyleBackColor = false;
			this.item2ExcOptType.Enabled = false;
			this.item2ExcOptType.FormattingEnabled = true;
			ComboBox.ObjectCollection items4 = this.item2ExcOptType.Items;
			objArray = new object[] { "Exc Opt. Weapon", "Exc Opt. Armor", "Exc Opt. Wings" };
			items4.AddRange(objArray);
			this.item2ExcOptType.Location = new Point(11, 0);
			this.item2ExcOptType.Name = "item2ExcOptType";
			this.item2ExcOptType.Size = new System.Drawing.Size(102, 21);
			this.item2ExcOptType.TabIndex = 40;
			this.item2ExcOptType.Tag = "";
			this.item2ExcOptType.Text = "Excellent Option";
			this.item2ExcOptType.SelectedIndexChanged += new EventHandler(this.item6ExcOptType_SelectedIndexChanged);
			this.item2ExcOpt4.AutoSize = true;
			this.item2ExcOpt4.BackColor = Color.Transparent;
			this.item2ExcOpt4.Enabled = false;
			this.item2ExcOpt4.ForeColor = SystemColors.InfoText;
			this.item2ExcOpt4.Location = new Point(107, 27);
			this.item2ExcOpt4.Name = "item2ExcOpt4";
			this.item2ExcOpt4.Size = new System.Drawing.Size(94, 17);
			this.item2ExcOpt4.TabIndex = 39;
			this.item2ExcOpt4.Tag = "";
			this.item2ExcOpt4.Text = "Zen Drop +3%";
			this.item2ExcOpt4.UseVisualStyleBackColor = false;
			this.item2Skill.AutoSize = true;
			this.item2Skill.BackColor = Color.Transparent;
			this.item2Skill.Enabled = false;
			this.item2Skill.ForeColor = SystemColors.InfoText;
			this.item2Skill.Location = new Point(214, 73);
			this.item2Skill.Name = "item2Skill";
			this.item2Skill.Size = new System.Drawing.Size(45, 17);
			this.item2Skill.TabIndex = 47;
			this.item2Skill.Text = "Skill";
			this.item2Skill.UseVisualStyleBackColor = false;
			this.item2Luck.AutoSize = true;
			this.item2Luck.BackColor = Color.Transparent;
			this.item2Luck.Enabled = false;
			this.item2Luck.ForeColor = SystemColors.InfoText;
			this.item2Luck.Location = new Point(162, 73);
			this.item2Luck.Name = "item2Luck";
			this.item2Luck.Size = new System.Drawing.Size(50, 17);
			this.item2Luck.TabIndex = 46;
			this.item2Luck.Text = "Luck";
			this.item2Luck.UseVisualStyleBackColor = false;
			this.item2Ancient.Enabled = false;
			this.item2Ancient.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections4 = this.item2Ancient.Items;
			objArray = new object[] { "No Ancient", "Ancient Lvl 1", "Ancient Lvl 2" };
			objectCollections4.AddRange(objArray);
			this.item2Ancient.Location = new Point(162, 95);
			this.item2Ancient.Name = "item2Ancient";
			this.item2Ancient.Size = new System.Drawing.Size(102, 21);
			this.item2Ancient.TabIndex = 45;
			this.item2Ancient.Text = "Ancient";
			this.item2Sckt.Enabled = false;
			this.item2Sckt.FormattingEnabled = true;
			this.item2Sckt.Location = new Point(162, 43);
			this.item2Sckt.Name = "item2Sckt";
			this.item2Sckt.Size = new System.Drawing.Size(48, 21);
			this.item2Sckt.TabIndex = 44;
			this.item2Sckt.Text = "Sckt";
			this.item2Opt.Enabled = false;
			this.item2Opt.FormattingEnabled = true;
			this.item2Opt.Location = new Point(216, 16);
			this.item2Opt.Name = "item2Opt";
			this.item2Opt.Size = new System.Drawing.Size(48, 21);
			this.item2Opt.TabIndex = 43;
			this.item2Opt.Text = "Opt";
			this.item2Lvl.Enabled = false;
			this.item2Lvl.FormattingEnabled = true;
			this.item2Lvl.Location = new Point(162, 16);
			this.item2Lvl.Name = "item2Lvl";
			this.item2Lvl.Size = new System.Drawing.Size(48, 21);
			this.item2Lvl.TabIndex = 42;
			this.item2Lvl.Text = "Lvl";
			this.groupBox4.BackColor = Color.Transparent;
			this.groupBox4.Controls.Add(this.item2Price);
			this.groupBox4.Controls.Add(this.item2Count);
			this.groupBox4.Controls.Add(this.item2Name);
			this.groupBox4.Controls.Add(this.item2Enable);
			this.groupBox4.Location = new Point(6, 10);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(149, 106);
			this.groupBox4.TabIndex = 40;
			this.groupBox4.TabStop = false;
			this.item2Price.Enabled = false;
			this.item2Price.Location = new Point(73, 70);
			this.item2Price.Name = "item2Price";
			this.item2Price.Size = new System.Drawing.Size(69, 20);
			this.item2Price.TabIndex = 41;
			this.item2Price.Text = "Price";
			this.item2Price.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item2Count.Enabled = false;
			this.item2Count.Location = new Point(8, 70);
			this.item2Count.Name = "item2Count";
			this.item2Count.Size = new System.Drawing.Size(59, 20);
			this.item2Count.TabIndex = 40;
			this.item2Count.Text = "Count";
			this.item2Count.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item2Name.Enabled = false;
			this.item2Name.Location = new Point(8, 36);
			this.item2Name.Name = "item2Name";
			this.item2Name.Size = new System.Drawing.Size(134, 20);
			this.item2Name.TabIndex = 39;
			this.item2Name.Text = "Name";
			this.item2Name.TextChanged += new EventHandler(this.packDisc_TextChanged);
			this.item2Name.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.item2Enable.AutoSize = true;
			this.item2Enable.BackColor = Color.White;
			this.item2Enable.Enabled = false;
			this.item2Enable.FlatStyle = FlatStyle.Popup;
			this.item2Enable.ForeColor = SystemColors.InfoText;
			this.item2Enable.Location = new Point(8, -1);
			this.item2Enable.Name = "item2Enable";
			this.item2Enable.Size = new System.Drawing.Size(57, 17);
			this.item2Enable.TabIndex = 38;
			this.item2Enable.Tag = "2";
			this.item2Enable.Text = "Enable";
			this.item2Enable.UseVisualStyleBackColor = false;
			this.item2Enable.CheckedChanged += new EventHandler(this.item6Enable_CheckedChanged);
			this.tabPage3.Controls.Add(this.item3Dur);
			this.tabPage3.Controls.Add(this.groupBox5);
			this.tabPage3.Controls.Add(this.item3Skill);
			this.tabPage3.Controls.Add(this.item3Luck);
			this.tabPage3.Controls.Add(this.item3Ancient);
			this.tabPage3.Controls.Add(this.item3Sckt);
			this.tabPage3.Controls.Add(this.item3Opt);
			this.tabPage3.Controls.Add(this.item3Lvl);
			this.tabPage3.Controls.Add(this.groupBox6);
			this.tabPage3.Location = new Point(4, 28);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(484, 126);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Pack 3";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.item3Dur.Enabled = false;
			this.item3Dur.Location = new Point(216, 43);
			this.item3Dur.Name = "item3Dur";
			this.item3Dur.Size = new System.Drawing.Size(48, 20);
			this.item3Dur.TabIndex = 48;
			this.item3Dur.Text = "Dur";
			this.item3Dur.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.groupBox5.BackColor = Color.Transparent;
			this.groupBox5.Controls.Add(this.item3ExcOpt3);
			this.groupBox5.Controls.Add(this.item3ExcOpt2);
			this.groupBox5.Controls.Add(this.item3ExcOpt1);
			this.groupBox5.Controls.Add(this.item3ExcOpt6);
			this.groupBox5.Controls.Add(this.item3ExcOpt5);
			this.groupBox5.Controls.Add(this.item3ExcOptType);
			this.groupBox5.Controls.Add(this.item3ExcOpt4);
			this.groupBox5.Location = new Point(270, 10);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(208, 106);
			this.groupBox5.TabIndex = 41;
			this.groupBox5.TabStop = false;
			this.item3ExcOpt3.AutoSize = true;
			this.item3ExcOpt3.BackColor = Color.Transparent;
			this.item3ExcOpt3.Enabled = false;
			this.item3ExcOpt3.ForeColor = SystemColors.InfoText;
			this.item3ExcOpt3.Location = new Point(10, 74);
			this.item3ExcOpt3.Name = "item3ExcOpt3";
			this.item3ExcOpt3.Size = new System.Drawing.Size(94, 17);
			this.item3ExcOpt3.TabIndex = 47;
			this.item3ExcOpt3.Tag = "";
			this.item3ExcOpt3.Text = "Zen Drp +30%";
			this.item3ExcOpt3.UseVisualStyleBackColor = false;
			this.item3ExcOpt2.AutoSize = true;
			this.item3ExcOpt2.BackColor = Color.Transparent;
			this.item3ExcOpt2.Enabled = false;
			this.item3ExcOpt2.ForeColor = SystemColors.InfoText;
			this.item3ExcOpt2.Location = new Point(10, 50);
			this.item3ExcOpt2.Name = "item3ExcOpt2";
			this.item3ExcOpt2.Size = new System.Drawing.Size(94, 17);
			this.item3ExcOpt2.TabIndex = 46;
			this.item3ExcOpt2.Tag = "";
			this.item3ExcOpt2.Text = "Zen Drp +30%";
			this.item3ExcOpt2.UseVisualStyleBackColor = false;
			this.item3ExcOpt1.AutoSize = true;
			this.item3ExcOpt1.BackColor = Color.Transparent;
			this.item3ExcOpt1.Enabled = false;
			this.item3ExcOpt1.ForeColor = SystemColors.InfoText;
			this.item3ExcOpt1.Location = new Point(10, 27);
			this.item3ExcOpt1.Name = "item3ExcOpt1";
			this.item3ExcOpt1.Size = new System.Drawing.Size(94, 17);
			this.item3ExcOpt1.TabIndex = 45;
			this.item3ExcOpt1.Tag = "";
			this.item3ExcOpt1.Text = "Zen Drp +30%";
			this.item3ExcOpt1.UseVisualStyleBackColor = false;
			this.item3ExcOpt6.AutoSize = true;
			this.item3ExcOpt6.BackColor = Color.Transparent;
			this.item3ExcOpt6.Enabled = false;
			this.item3ExcOpt6.ForeColor = SystemColors.InfoText;
			this.item3ExcOpt6.Location = new Point(107, 74);
			this.item3ExcOpt6.Name = "item3ExcOpt6";
			this.item3ExcOpt6.Size = new System.Drawing.Size(94, 17);
			this.item3ExcOpt6.TabIndex = 44;
			this.item3ExcOpt6.Tag = "";
			this.item3ExcOpt6.Text = "Zen Drop +3%";
			this.item3ExcOpt6.UseVisualStyleBackColor = false;
			this.item3ExcOpt5.AutoSize = true;
			this.item3ExcOpt5.BackColor = Color.Transparent;
			this.item3ExcOpt5.Enabled = false;
			this.item3ExcOpt5.ForeColor = SystemColors.InfoText;
			this.item3ExcOpt5.Location = new Point(107, 50);
			this.item3ExcOpt5.Name = "item3ExcOpt5";
			this.item3ExcOpt5.Size = new System.Drawing.Size(94, 17);
			this.item3ExcOpt5.TabIndex = 43;
			this.item3ExcOpt5.Tag = "";
			this.item3ExcOpt5.Text = "Zen Drop +3%";
			this.item3ExcOpt5.UseVisualStyleBackColor = false;
			this.item3ExcOptType.Enabled = false;
			this.item3ExcOptType.FormattingEnabled = true;
			ComboBox.ObjectCollection items5 = this.item3ExcOptType.Items;
			objArray = new object[] { "Exc Opt. Weapon", "Exc Opt. Armor", "Exc Opt. Wings" };
			items5.AddRange(objArray);
			this.item3ExcOptType.Location = new Point(11, 0);
			this.item3ExcOptType.Name = "item3ExcOptType";
			this.item3ExcOptType.Size = new System.Drawing.Size(102, 21);
			this.item3ExcOptType.TabIndex = 40;
			this.item3ExcOptType.Text = "Excellent Option";
			this.item3ExcOptType.SelectedIndexChanged += new EventHandler(this.item6ExcOptType_SelectedIndexChanged);
			this.item3ExcOpt4.AutoSize = true;
			this.item3ExcOpt4.BackColor = Color.Transparent;
			this.item3ExcOpt4.Enabled = false;
			this.item3ExcOpt4.ForeColor = SystemColors.InfoText;
			this.item3ExcOpt4.Location = new Point(107, 27);
			this.item3ExcOpt4.Name = "item3ExcOpt4";
			this.item3ExcOpt4.Size = new System.Drawing.Size(94, 17);
			this.item3ExcOpt4.TabIndex = 39;
			this.item3ExcOpt4.Tag = "";
			this.item3ExcOpt4.Text = "Zen Drop +3%";
			this.item3ExcOpt4.UseVisualStyleBackColor = false;
			this.item3Skill.AutoSize = true;
			this.item3Skill.BackColor = Color.Transparent;
			this.item3Skill.Enabled = false;
			this.item3Skill.ForeColor = SystemColors.InfoText;
			this.item3Skill.Location = new Point(214, 73);
			this.item3Skill.Name = "item3Skill";
			this.item3Skill.Size = new System.Drawing.Size(45, 17);
			this.item3Skill.TabIndex = 47;
			this.item3Skill.Text = "Skill";
			this.item3Skill.UseVisualStyleBackColor = false;
			this.item3Luck.AutoSize = true;
			this.item3Luck.BackColor = Color.Transparent;
			this.item3Luck.Enabled = false;
			this.item3Luck.ForeColor = SystemColors.InfoText;
			this.item3Luck.Location = new Point(162, 73);
			this.item3Luck.Name = "item3Luck";
			this.item3Luck.Size = new System.Drawing.Size(50, 17);
			this.item3Luck.TabIndex = 46;
			this.item3Luck.Text = "Luck";
			this.item3Luck.UseVisualStyleBackColor = false;
			this.item3Ancient.Enabled = false;
			this.item3Ancient.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections5 = this.item3Ancient.Items;
			objArray = new object[] { "No Ancient", "Ancient Lvl 1", "Ancient Lvl 2" };
			objectCollections5.AddRange(objArray);
			this.item3Ancient.Location = new Point(162, 95);
			this.item3Ancient.Name = "item3Ancient";
			this.item3Ancient.Size = new System.Drawing.Size(102, 21);
			this.item3Ancient.TabIndex = 45;
			this.item3Ancient.Text = "Ancient";
			this.item3Sckt.Enabled = false;
			this.item3Sckt.FormattingEnabled = true;
			this.item3Sckt.Location = new Point(162, 43);
			this.item3Sckt.Name = "item3Sckt";
			this.item3Sckt.Size = new System.Drawing.Size(48, 21);
			this.item3Sckt.TabIndex = 44;
			this.item3Sckt.Text = "Sckt";
			this.item3Opt.Enabled = false;
			this.item3Opt.FormattingEnabled = true;
			this.item3Opt.Location = new Point(216, 16);
			this.item3Opt.Name = "item3Opt";
			this.item3Opt.Size = new System.Drawing.Size(48, 21);
			this.item3Opt.TabIndex = 43;
			this.item3Opt.Text = "Opt";
			this.item3Lvl.Enabled = false;
			this.item3Lvl.FormattingEnabled = true;
			this.item3Lvl.Location = new Point(162, 16);
			this.item3Lvl.Name = "item3Lvl";
			this.item3Lvl.Size = new System.Drawing.Size(48, 21);
			this.item3Lvl.TabIndex = 42;
			this.item3Lvl.Text = "Lvl";
			this.groupBox6.BackColor = Color.Transparent;
			this.groupBox6.Controls.Add(this.item3Price);
			this.groupBox6.Controls.Add(this.item3Count);
			this.groupBox6.Controls.Add(this.item3Name);
			this.groupBox6.Controls.Add(this.item3Enable);
			this.groupBox6.Location = new Point(6, 10);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(149, 106);
			this.groupBox6.TabIndex = 40;
			this.groupBox6.TabStop = false;
			this.item3Price.Enabled = false;
			this.item3Price.Location = new Point(73, 70);
			this.item3Price.Name = "item3Price";
			this.item3Price.Size = new System.Drawing.Size(69, 20);
			this.item3Price.TabIndex = 41;
			this.item3Price.Text = "Price";
			this.item3Price.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item3Count.Enabled = false;
			this.item3Count.Location = new Point(8, 70);
			this.item3Count.Name = "item3Count";
			this.item3Count.Size = new System.Drawing.Size(59, 20);
			this.item3Count.TabIndex = 40;
			this.item3Count.Text = "Count";
			this.item3Count.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item3Name.Enabled = false;
			this.item3Name.Location = new Point(8, 36);
			this.item3Name.Name = "item3Name";
			this.item3Name.Size = new System.Drawing.Size(134, 20);
			this.item3Name.TabIndex = 39;
			this.item3Name.Text = "Name";
			this.item3Name.TextChanged += new EventHandler(this.packDisc_TextChanged);
			this.item3Name.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.item3Enable.AutoSize = true;
			this.item3Enable.BackColor = Color.White;
			this.item3Enable.Enabled = false;
			this.item3Enable.FlatStyle = FlatStyle.Popup;
			this.item3Enable.ForeColor = SystemColors.InfoText;
			this.item3Enable.Location = new Point(8, -1);
			this.item3Enable.Name = "item3Enable";
			this.item3Enable.Size = new System.Drawing.Size(57, 17);
			this.item3Enable.TabIndex = 38;
			this.item3Enable.Tag = "3";
			this.item3Enable.Text = "Enable";
			this.item3Enable.UseVisualStyleBackColor = false;
			this.item3Enable.CheckedChanged += new EventHandler(this.item6Enable_CheckedChanged);
			this.tabPage4.Controls.Add(this.item4Dur);
			this.tabPage4.Controls.Add(this.groupBox7);
			this.tabPage4.Controls.Add(this.item4Skill);
			this.tabPage4.Controls.Add(this.item4Luck);
			this.tabPage4.Controls.Add(this.item4Ancient);
			this.tabPage4.Controls.Add(this.item4Sckt);
			this.tabPage4.Controls.Add(this.item4Opt);
			this.tabPage4.Controls.Add(this.item4Lvl);
			this.tabPage4.Controls.Add(this.groupBox8);
			this.tabPage4.Location = new Point(4, 28);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(484, 126);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Pack 4";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.item4Dur.Enabled = false;
			this.item4Dur.Location = new Point(216, 43);
			this.item4Dur.Name = "item4Dur";
			this.item4Dur.Size = new System.Drawing.Size(48, 20);
			this.item4Dur.TabIndex = 48;
			this.item4Dur.Text = "Dur";
			this.item4Dur.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.groupBox7.BackColor = Color.Transparent;
			this.groupBox7.Controls.Add(this.item4ExcOpt3);
			this.groupBox7.Controls.Add(this.item4ExcOpt2);
			this.groupBox7.Controls.Add(this.item4ExcOpt1);
			this.groupBox7.Controls.Add(this.item4ExcOpt6);
			this.groupBox7.Controls.Add(this.item4ExcOpt5);
			this.groupBox7.Controls.Add(this.item4ExcOptType);
			this.groupBox7.Controls.Add(this.item4ExcOpt4);
			this.groupBox7.Location = new Point(270, 10);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(208, 106);
			this.groupBox7.TabIndex = 41;
			this.groupBox7.TabStop = false;
			this.item4ExcOpt3.AutoSize = true;
			this.item4ExcOpt3.BackColor = Color.Transparent;
			this.item4ExcOpt3.Enabled = false;
			this.item4ExcOpt3.ForeColor = SystemColors.InfoText;
			this.item4ExcOpt3.Location = new Point(10, 74);
			this.item4ExcOpt3.Name = "item4ExcOpt3";
			this.item4ExcOpt3.Size = new System.Drawing.Size(94, 17);
			this.item4ExcOpt3.TabIndex = 47;
			this.item4ExcOpt3.Tag = "";
			this.item4ExcOpt3.Text = "Zen Drp +30%";
			this.item4ExcOpt3.UseVisualStyleBackColor = false;
			this.item4ExcOpt2.AutoSize = true;
			this.item4ExcOpt2.BackColor = Color.Transparent;
			this.item4ExcOpt2.Enabled = false;
			this.item4ExcOpt2.ForeColor = SystemColors.InfoText;
			this.item4ExcOpt2.Location = new Point(10, 50);
			this.item4ExcOpt2.Name = "item4ExcOpt2";
			this.item4ExcOpt2.Size = new System.Drawing.Size(94, 17);
			this.item4ExcOpt2.TabIndex = 46;
			this.item4ExcOpt2.Tag = "";
			this.item4ExcOpt2.Text = "Zen Drp +30%";
			this.item4ExcOpt2.UseVisualStyleBackColor = false;
			this.item4ExcOpt1.AutoSize = true;
			this.item4ExcOpt1.BackColor = Color.Transparent;
			this.item4ExcOpt1.Enabled = false;
			this.item4ExcOpt1.ForeColor = SystemColors.InfoText;
			this.item4ExcOpt1.Location = new Point(10, 27);
			this.item4ExcOpt1.Name = "item4ExcOpt1";
			this.item4ExcOpt1.Size = new System.Drawing.Size(94, 17);
			this.item4ExcOpt1.TabIndex = 45;
			this.item4ExcOpt1.Tag = "";
			this.item4ExcOpt1.Text = "Zen Drp +30%";
			this.item4ExcOpt1.UseVisualStyleBackColor = false;
			this.item4ExcOpt6.AutoSize = true;
			this.item4ExcOpt6.BackColor = Color.Transparent;
			this.item4ExcOpt6.Enabled = false;
			this.item4ExcOpt6.ForeColor = SystemColors.InfoText;
			this.item4ExcOpt6.Location = new Point(107, 74);
			this.item4ExcOpt6.Name = "item4ExcOpt6";
			this.item4ExcOpt6.Size = new System.Drawing.Size(94, 17);
			this.item4ExcOpt6.TabIndex = 44;
			this.item4ExcOpt6.Tag = "";
			this.item4ExcOpt6.Text = "Zen Drop +3%";
			this.item4ExcOpt6.UseVisualStyleBackColor = false;
			this.item4ExcOpt5.AutoSize = true;
			this.item4ExcOpt5.BackColor = Color.Transparent;
			this.item4ExcOpt5.Enabled = false;
			this.item4ExcOpt5.ForeColor = SystemColors.InfoText;
			this.item4ExcOpt5.Location = new Point(107, 50);
			this.item4ExcOpt5.Name = "item4ExcOpt5";
			this.item4ExcOpt5.Size = new System.Drawing.Size(94, 17);
			this.item4ExcOpt5.TabIndex = 43;
			this.item4ExcOpt5.Tag = "";
			this.item4ExcOpt5.Text = "Zen Drop +3%";
			this.item4ExcOpt5.UseVisualStyleBackColor = false;
			this.item4ExcOptType.Enabled = false;
			this.item4ExcOptType.FormattingEnabled = true;
			ComboBox.ObjectCollection items6 = this.item4ExcOptType.Items;
			objArray = new object[] { "Exc Opt. Weapon", "Exc Opt. Armor", "Exc Opt. Wings" };
			items6.AddRange(objArray);
			this.item4ExcOptType.Location = new Point(11, 0);
			this.item4ExcOptType.Name = "item4ExcOptType";
			this.item4ExcOptType.Size = new System.Drawing.Size(102, 21);
			this.item4ExcOptType.TabIndex = 40;
			this.item4ExcOptType.Text = "Excellent Option";
			this.item4ExcOptType.SelectedIndexChanged += new EventHandler(this.item6ExcOptType_SelectedIndexChanged);
			this.item4ExcOpt4.AutoSize = true;
			this.item4ExcOpt4.BackColor = Color.Transparent;
			this.item4ExcOpt4.Enabled = false;
			this.item4ExcOpt4.ForeColor = SystemColors.InfoText;
			this.item4ExcOpt4.Location = new Point(107, 27);
			this.item4ExcOpt4.Name = "item4ExcOpt4";
			this.item4ExcOpt4.Size = new System.Drawing.Size(94, 17);
			this.item4ExcOpt4.TabIndex = 39;
			this.item4ExcOpt4.Tag = "";
			this.item4ExcOpt4.Text = "Zen Drop +3%";
			this.item4ExcOpt4.UseVisualStyleBackColor = false;
			this.item4Skill.AutoSize = true;
			this.item4Skill.BackColor = Color.Transparent;
			this.item4Skill.Enabled = false;
			this.item4Skill.ForeColor = SystemColors.InfoText;
			this.item4Skill.Location = new Point(214, 73);
			this.item4Skill.Name = "item4Skill";
			this.item4Skill.Size = new System.Drawing.Size(45, 17);
			this.item4Skill.TabIndex = 47;
			this.item4Skill.Text = "Skill";
			this.item4Skill.UseVisualStyleBackColor = false;
			this.item4Luck.AutoSize = true;
			this.item4Luck.BackColor = Color.Transparent;
			this.item4Luck.Enabled = false;
			this.item4Luck.ForeColor = SystemColors.InfoText;
			this.item4Luck.Location = new Point(162, 73);
			this.item4Luck.Name = "item4Luck";
			this.item4Luck.Size = new System.Drawing.Size(50, 17);
			this.item4Luck.TabIndex = 46;
			this.item4Luck.Text = "Luck";
			this.item4Luck.UseVisualStyleBackColor = false;
			this.item4Ancient.Enabled = false;
			this.item4Ancient.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections6 = this.item4Ancient.Items;
			objArray = new object[] { "No Ancient", "Ancient Lvl 1", "Ancient Lvl 2" };
			objectCollections6.AddRange(objArray);
			this.item4Ancient.Location = new Point(162, 95);
			this.item4Ancient.Name = "item4Ancient";
			this.item4Ancient.Size = new System.Drawing.Size(102, 21);
			this.item4Ancient.TabIndex = 45;
			this.item4Ancient.Text = "Ancient";
			this.item4Sckt.Enabled = false;
			this.item4Sckt.FormattingEnabled = true;
			this.item4Sckt.Location = new Point(162, 43);
			this.item4Sckt.Name = "item4Sckt";
			this.item4Sckt.Size = new System.Drawing.Size(48, 21);
			this.item4Sckt.TabIndex = 44;
			this.item4Sckt.Text = "Sckt";
			this.item4Opt.Enabled = false;
			this.item4Opt.FormattingEnabled = true;
			this.item4Opt.Location = new Point(216, 16);
			this.item4Opt.Name = "item4Opt";
			this.item4Opt.Size = new System.Drawing.Size(48, 21);
			this.item4Opt.TabIndex = 43;
			this.item4Opt.Text = "Opt";
			this.item4Lvl.Enabled = false;
			this.item4Lvl.FormattingEnabled = true;
			this.item4Lvl.Location = new Point(162, 16);
			this.item4Lvl.Name = "item4Lvl";
			this.item4Lvl.Size = new System.Drawing.Size(48, 21);
			this.item4Lvl.TabIndex = 42;
			this.item4Lvl.Text = "Lvl";
			this.groupBox8.BackColor = Color.Transparent;
			this.groupBox8.Controls.Add(this.item4Enable);
			this.groupBox8.Controls.Add(this.item4Price);
			this.groupBox8.Controls.Add(this.item4Count);
			this.groupBox8.Controls.Add(this.item4Name);
			this.groupBox8.Location = new Point(6, 10);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(149, 106);
			this.groupBox8.TabIndex = 40;
			this.groupBox8.TabStop = false;
			this.item4Enable.AutoSize = true;
			this.item4Enable.BackColor = Color.White;
			this.item4Enable.Enabled = false;
			this.item4Enable.FlatStyle = FlatStyle.Popup;
			this.item4Enable.ForeColor = SystemColors.InfoText;
			this.item4Enable.Location = new Point(8, -1);
			this.item4Enable.Name = "item4Enable";
			this.item4Enable.Size = new System.Drawing.Size(57, 17);
			this.item4Enable.TabIndex = 42;
			this.item4Enable.Tag = "4";
			this.item4Enable.Text = "Enable";
			this.item4Enable.UseVisualStyleBackColor = false;
			this.item4Enable.CheckedChanged += new EventHandler(this.item6Enable_CheckedChanged);
			this.item4Price.Enabled = false;
			this.item4Price.Location = new Point(73, 70);
			this.item4Price.Name = "item4Price";
			this.item4Price.Size = new System.Drawing.Size(69, 20);
			this.item4Price.TabIndex = 41;
			this.item4Price.Text = "Price";
			this.item4Price.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item4Count.Enabled = false;
			this.item4Count.Location = new Point(8, 70);
			this.item4Count.Name = "item4Count";
			this.item4Count.Size = new System.Drawing.Size(59, 20);
			this.item4Count.TabIndex = 40;
			this.item4Count.Text = "Count";
			this.item4Count.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item4Name.Enabled = false;
			this.item4Name.Location = new Point(8, 36);
			this.item4Name.Name = "item4Name";
			this.item4Name.Size = new System.Drawing.Size(134, 20);
			this.item4Name.TabIndex = 39;
			this.item4Name.Text = "Name";
			this.item4Name.TextChanged += new EventHandler(this.packDisc_TextChanged);
			this.item4Name.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.tabPage5.Controls.Add(this.item5Dur);
			this.tabPage5.Controls.Add(this.groupBox9);
			this.tabPage5.Controls.Add(this.item5Skill);
			this.tabPage5.Controls.Add(this.item5Luck);
			this.tabPage5.Controls.Add(this.item5Ancient);
			this.tabPage5.Controls.Add(this.item5Sckt);
			this.tabPage5.Controls.Add(this.item5Opt);
			this.tabPage5.Controls.Add(this.item5Lvl);
			this.tabPage5.Controls.Add(this.groupBox10);
			this.tabPage5.Location = new Point(4, 28);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(484, 126);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Pack 5";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.item5Dur.Enabled = false;
			this.item5Dur.Location = new Point(216, 43);
			this.item5Dur.Name = "item5Dur";
			this.item5Dur.Size = new System.Drawing.Size(48, 20);
			this.item5Dur.TabIndex = 48;
			this.item5Dur.Text = "Dur";
			this.item5Dur.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.groupBox9.BackColor = Color.Transparent;
			this.groupBox9.Controls.Add(this.item5ExcOpt3);
			this.groupBox9.Controls.Add(this.item5ExcOpt2);
			this.groupBox9.Controls.Add(this.item5ExcOpt1);
			this.groupBox9.Controls.Add(this.item5ExcOpt6);
			this.groupBox9.Controls.Add(this.item5ExcOpt5);
			this.groupBox9.Controls.Add(this.item5ExcOptType);
			this.groupBox9.Controls.Add(this.item5ExcOpt4);
			this.groupBox9.Location = new Point(270, 10);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(208, 106);
			this.groupBox9.TabIndex = 41;
			this.groupBox9.TabStop = false;
			this.item5ExcOpt3.AutoSize = true;
			this.item5ExcOpt3.BackColor = Color.Transparent;
			this.item5ExcOpt3.Enabled = false;
			this.item5ExcOpt3.ForeColor = SystemColors.InfoText;
			this.item5ExcOpt3.Location = new Point(10, 74);
			this.item5ExcOpt3.Name = "item5ExcOpt3";
			this.item5ExcOpt3.Size = new System.Drawing.Size(94, 17);
			this.item5ExcOpt3.TabIndex = 47;
			this.item5ExcOpt3.Tag = "";
			this.item5ExcOpt3.Text = "Zen Drp +30%";
			this.item5ExcOpt3.UseVisualStyleBackColor = false;
			this.item5ExcOpt2.AutoSize = true;
			this.item5ExcOpt2.BackColor = Color.Transparent;
			this.item5ExcOpt2.Enabled = false;
			this.item5ExcOpt2.ForeColor = SystemColors.InfoText;
			this.item5ExcOpt2.Location = new Point(10, 50);
			this.item5ExcOpt2.Name = "item5ExcOpt2";
			this.item5ExcOpt2.Size = new System.Drawing.Size(94, 17);
			this.item5ExcOpt2.TabIndex = 46;
			this.item5ExcOpt2.Tag = "";
			this.item5ExcOpt2.Text = "Zen Drp +30%";
			this.item5ExcOpt2.UseVisualStyleBackColor = false;
			this.item5ExcOpt1.AutoSize = true;
			this.item5ExcOpt1.BackColor = Color.Transparent;
			this.item5ExcOpt1.Enabled = false;
			this.item5ExcOpt1.ForeColor = SystemColors.InfoText;
			this.item5ExcOpt1.Location = new Point(10, 27);
			this.item5ExcOpt1.Name = "item5ExcOpt1";
			this.item5ExcOpt1.Size = new System.Drawing.Size(94, 17);
			this.item5ExcOpt1.TabIndex = 45;
			this.item5ExcOpt1.Tag = "";
			this.item5ExcOpt1.Text = "Zen Drp +30%";
			this.item5ExcOpt1.UseVisualStyleBackColor = false;
			this.item5ExcOpt6.AutoSize = true;
			this.item5ExcOpt6.BackColor = Color.Transparent;
			this.item5ExcOpt6.Enabled = false;
			this.item5ExcOpt6.ForeColor = SystemColors.InfoText;
			this.item5ExcOpt6.Location = new Point(107, 74);
			this.item5ExcOpt6.Name = "item5ExcOpt6";
			this.item5ExcOpt6.Size = new System.Drawing.Size(94, 17);
			this.item5ExcOpt6.TabIndex = 44;
			this.item5ExcOpt6.Tag = "";
			this.item5ExcOpt6.Text = "Zen Drop +3%";
			this.item5ExcOpt6.UseVisualStyleBackColor = false;
			this.item5ExcOpt5.AutoSize = true;
			this.item5ExcOpt5.BackColor = Color.Transparent;
			this.item5ExcOpt5.Enabled = false;
			this.item5ExcOpt5.ForeColor = SystemColors.InfoText;
			this.item5ExcOpt5.Location = new Point(107, 50);
			this.item5ExcOpt5.Name = "item5ExcOpt5";
			this.item5ExcOpt5.Size = new System.Drawing.Size(94, 17);
			this.item5ExcOpt5.TabIndex = 43;
			this.item5ExcOpt5.Tag = "";
			this.item5ExcOpt5.Text = "Zen Drop +3%";
			this.item5ExcOpt5.UseVisualStyleBackColor = false;
			this.item5ExcOptType.Enabled = false;
			this.item5ExcOptType.FormattingEnabled = true;
			ComboBox.ObjectCollection items7 = this.item5ExcOptType.Items;
			objArray = new object[] { "Exc Opt. Weapon", "Exc Opt. Armor", "Exc Opt. Wings" };
			items7.AddRange(objArray);
			this.item5ExcOptType.Location = new Point(11, 0);
			this.item5ExcOptType.Name = "item5ExcOptType";
			this.item5ExcOptType.Size = new System.Drawing.Size(102, 21);
			this.item5ExcOptType.TabIndex = 40;
			this.item5ExcOptType.Text = "Excellent Option";
			this.item5ExcOptType.SelectedIndexChanged += new EventHandler(this.item6ExcOptType_SelectedIndexChanged);
			this.item5ExcOpt4.AutoSize = true;
			this.item5ExcOpt4.BackColor = Color.Transparent;
			this.item5ExcOpt4.Enabled = false;
			this.item5ExcOpt4.ForeColor = SystemColors.InfoText;
			this.item5ExcOpt4.Location = new Point(107, 27);
			this.item5ExcOpt4.Name = "item5ExcOpt4";
			this.item5ExcOpt4.Size = new System.Drawing.Size(94, 17);
			this.item5ExcOpt4.TabIndex = 39;
			this.item5ExcOpt4.Tag = "";
			this.item5ExcOpt4.Text = "Zen Drop +3%";
			this.item5ExcOpt4.UseVisualStyleBackColor = false;
			this.item5Skill.AutoSize = true;
			this.item5Skill.BackColor = Color.Transparent;
			this.item5Skill.Enabled = false;
			this.item5Skill.ForeColor = SystemColors.InfoText;
			this.item5Skill.Location = new Point(214, 73);
			this.item5Skill.Name = "item5Skill";
			this.item5Skill.Size = new System.Drawing.Size(45, 17);
			this.item5Skill.TabIndex = 47;
			this.item5Skill.Text = "Skill";
			this.item5Skill.UseVisualStyleBackColor = false;
			this.item5Luck.AutoSize = true;
			this.item5Luck.BackColor = Color.Transparent;
			this.item5Luck.Enabled = false;
			this.item5Luck.ForeColor = SystemColors.InfoText;
			this.item5Luck.Location = new Point(162, 73);
			this.item5Luck.Name = "item5Luck";
			this.item5Luck.Size = new System.Drawing.Size(50, 17);
			this.item5Luck.TabIndex = 46;
			this.item5Luck.Text = "Luck";
			this.item5Luck.UseVisualStyleBackColor = false;
			this.item5Ancient.Enabled = false;
			this.item5Ancient.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections7 = this.item5Ancient.Items;
			objArray = new object[] { "No Ancient", "Ancient Lvl 1", "Ancient Lvl 2" };
			objectCollections7.AddRange(objArray);
			this.item5Ancient.Location = new Point(162, 95);
			this.item5Ancient.Name = "item5Ancient";
			this.item5Ancient.Size = new System.Drawing.Size(102, 21);
			this.item5Ancient.TabIndex = 45;
			this.item5Ancient.Text = "Ancient";
			this.item5Sckt.Enabled = false;
			this.item5Sckt.FormattingEnabled = true;
			this.item5Sckt.Location = new Point(162, 43);
			this.item5Sckt.Name = "item5Sckt";
			this.item5Sckt.Size = new System.Drawing.Size(48, 21);
			this.item5Sckt.TabIndex = 44;
			this.item5Sckt.Text = "Sckt";
			this.item5Opt.Enabled = false;
			this.item5Opt.FormattingEnabled = true;
			this.item5Opt.Location = new Point(216, 16);
			this.item5Opt.Name = "item5Opt";
			this.item5Opt.Size = new System.Drawing.Size(48, 21);
			this.item5Opt.TabIndex = 43;
			this.item5Opt.Text = "Opt";
			this.item5Lvl.Enabled = false;
			this.item5Lvl.FormattingEnabled = true;
			this.item5Lvl.Location = new Point(162, 16);
			this.item5Lvl.Name = "item5Lvl";
			this.item5Lvl.Size = new System.Drawing.Size(48, 21);
			this.item5Lvl.TabIndex = 42;
			this.item5Lvl.Text = "Lvl";
			this.groupBox10.BackColor = Color.Transparent;
			this.groupBox10.Controls.Add(this.item5Price);
			this.groupBox10.Controls.Add(this.item5Count);
			this.groupBox10.Controls.Add(this.item5Name);
			this.groupBox10.Controls.Add(this.item5Enable);
			this.groupBox10.Location = new Point(6, 10);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(149, 106);
			this.groupBox10.TabIndex = 40;
			this.groupBox10.TabStop = false;
			this.item5Price.Enabled = false;
			this.item5Price.Location = new Point(73, 70);
			this.item5Price.Name = "item5Price";
			this.item5Price.Size = new System.Drawing.Size(69, 20);
			this.item5Price.TabIndex = 41;
			this.item5Price.Text = "Price";
			this.item5Price.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item5Count.Enabled = false;
			this.item5Count.Location = new Point(8, 70);
			this.item5Count.Name = "item5Count";
			this.item5Count.Size = new System.Drawing.Size(59, 20);
			this.item5Count.TabIndex = 40;
			this.item5Count.Text = "Count";
			this.item5Count.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item5Name.Enabled = false;
			this.item5Name.Location = new Point(8, 36);
			this.item5Name.Name = "item5Name";
			this.item5Name.Size = new System.Drawing.Size(134, 20);
			this.item5Name.TabIndex = 39;
			this.item5Name.Text = "Name";
			this.item5Name.TextChanged += new EventHandler(this.packDisc_TextChanged);
			this.item5Name.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.item5Enable.AutoSize = true;
			this.item5Enable.BackColor = Color.White;
			this.item5Enable.Enabled = false;
			this.item5Enable.FlatStyle = FlatStyle.Popup;
			this.item5Enable.ForeColor = SystemColors.InfoText;
			this.item5Enable.Location = new Point(8, -1);
			this.item5Enable.Name = "item5Enable";
			this.item5Enable.Size = new System.Drawing.Size(57, 17);
			this.item5Enable.TabIndex = 38;
			this.item5Enable.Tag = "5";
			this.item5Enable.Text = "Enable";
			this.item5Enable.UseVisualStyleBackColor = false;
			this.item5Enable.CheckedChanged += new EventHandler(this.item6Enable_CheckedChanged);
			this.tabPage6.Controls.Add(this.item6Dur);
			this.tabPage6.Controls.Add(this.groupBox11);
			this.tabPage6.Controls.Add(this.item6Skill);
			this.tabPage6.Controls.Add(this.item6Luck);
			this.tabPage6.Controls.Add(this.item6Ancient);
			this.tabPage6.Controls.Add(this.item6Sckt);
			this.tabPage6.Controls.Add(this.item6Opt);
			this.tabPage6.Controls.Add(this.item6Lvl);
			this.tabPage6.Controls.Add(this.groupBox12);
			this.tabPage6.Location = new Point(4, 28);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(484, 126);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Pack 6";
			this.tabPage6.UseVisualStyleBackColor = true;
			this.item6Dur.Enabled = false;
			this.item6Dur.Location = new Point(216, 43);
			this.item6Dur.Name = "item6Dur";
			this.item6Dur.Size = new System.Drawing.Size(48, 20);
			this.item6Dur.TabIndex = 48;
			this.item6Dur.Text = "Dur";
			this.item6Dur.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.groupBox11.BackColor = Color.Transparent;
			this.groupBox11.Controls.Add(this.item6ExcOpt3);
			this.groupBox11.Controls.Add(this.item6ExcOpt2);
			this.groupBox11.Controls.Add(this.item6ExcOpt1);
			this.groupBox11.Controls.Add(this.item6ExcOpt6);
			this.groupBox11.Controls.Add(this.item6ExcOpt5);
			this.groupBox11.Controls.Add(this.item6ExcOptType);
			this.groupBox11.Controls.Add(this.item6ExcOpt4);
			this.groupBox11.Location = new Point(270, 10);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(208, 106);
			this.groupBox11.TabIndex = 41;
			this.groupBox11.TabStop = false;
			this.item6ExcOpt3.AutoSize = true;
			this.item6ExcOpt3.BackColor = Color.Transparent;
			this.item6ExcOpt3.Enabled = false;
			this.item6ExcOpt3.ForeColor = SystemColors.InfoText;
			this.item6ExcOpt3.Location = new Point(10, 74);
			this.item6ExcOpt3.Name = "item6ExcOpt3";
			this.item6ExcOpt3.Size = new System.Drawing.Size(94, 17);
			this.item6ExcOpt3.TabIndex = 47;
			this.item6ExcOpt3.Tag = "";
			this.item6ExcOpt3.Text = "Zen Drp +30%";
			this.item6ExcOpt3.UseVisualStyleBackColor = false;
			this.item6ExcOpt2.AutoSize = true;
			this.item6ExcOpt2.BackColor = Color.Transparent;
			this.item6ExcOpt2.Enabled = false;
			this.item6ExcOpt2.ForeColor = SystemColors.InfoText;
			this.item6ExcOpt2.Location = new Point(10, 50);
			this.item6ExcOpt2.Name = "item6ExcOpt2";
			this.item6ExcOpt2.Size = new System.Drawing.Size(94, 17);
			this.item6ExcOpt2.TabIndex = 46;
			this.item6ExcOpt2.Tag = "";
			this.item6ExcOpt2.Text = "Zen Drp +30%";
			this.item6ExcOpt2.UseVisualStyleBackColor = false;
			this.item6ExcOpt1.AutoSize = true;
			this.item6ExcOpt1.BackColor = Color.Transparent;
			this.item6ExcOpt1.Enabled = false;
			this.item6ExcOpt1.ForeColor = SystemColors.InfoText;
			this.item6ExcOpt1.Location = new Point(10, 27);
			this.item6ExcOpt1.Name = "item6ExcOpt1";
			this.item6ExcOpt1.Size = new System.Drawing.Size(94, 17);
			this.item6ExcOpt1.TabIndex = 45;
			this.item6ExcOpt1.Tag = "";
			this.item6ExcOpt1.Text = "Zen Drp +30%";
			this.item6ExcOpt1.UseVisualStyleBackColor = false;
			this.item6ExcOpt6.AutoSize = true;
			this.item6ExcOpt6.BackColor = Color.Transparent;
			this.item6ExcOpt6.Enabled = false;
			this.item6ExcOpt6.ForeColor = SystemColors.InfoText;
			this.item6ExcOpt6.Location = new Point(107, 74);
			this.item6ExcOpt6.Name = "item6ExcOpt6";
			this.item6ExcOpt6.Size = new System.Drawing.Size(94, 17);
			this.item6ExcOpt6.TabIndex = 44;
			this.item6ExcOpt6.Tag = "";
			this.item6ExcOpt6.Text = "Zen Drop +3%";
			this.item6ExcOpt6.UseVisualStyleBackColor = false;
			this.item6ExcOpt5.AutoSize = true;
			this.item6ExcOpt5.BackColor = Color.Transparent;
			this.item6ExcOpt5.Enabled = false;
			this.item6ExcOpt5.ForeColor = SystemColors.InfoText;
			this.item6ExcOpt5.Location = new Point(107, 50);
			this.item6ExcOpt5.Name = "item6ExcOpt5";
			this.item6ExcOpt5.Size = new System.Drawing.Size(94, 17);
			this.item6ExcOpt5.TabIndex = 43;
			this.item6ExcOpt5.Tag = "";
			this.item6ExcOpt5.Text = "Zen Drop +3%";
			this.item6ExcOpt5.UseVisualStyleBackColor = false;
			this.item6ExcOptType.Enabled = false;
			this.item6ExcOptType.FormattingEnabled = true;
			ComboBox.ObjectCollection items8 = this.item6ExcOptType.Items;
			objArray = new object[] { "Exc Opt. Weapon", "Exc Opt. Armor", "Exc Opt. Wings" };
			items8.AddRange(objArray);
			this.item6ExcOptType.Location = new Point(11, 0);
			this.item6ExcOptType.Name = "item6ExcOptType";
			this.item6ExcOptType.Size = new System.Drawing.Size(102, 21);
			this.item6ExcOptType.TabIndex = 40;
			this.item6ExcOptType.Text = "Excellent Option";
			this.item6ExcOptType.SelectedIndexChanged += new EventHandler(this.item6ExcOptType_SelectedIndexChanged);
			this.item6ExcOpt4.AutoSize = true;
			this.item6ExcOpt4.BackColor = Color.Transparent;
			this.item6ExcOpt4.Enabled = false;
			this.item6ExcOpt4.ForeColor = SystemColors.InfoText;
			this.item6ExcOpt4.Location = new Point(107, 27);
			this.item6ExcOpt4.Name = "item6ExcOpt4";
			this.item6ExcOpt4.Size = new System.Drawing.Size(94, 17);
			this.item6ExcOpt4.TabIndex = 39;
			this.item6ExcOpt4.Tag = "";
			this.item6ExcOpt4.Text = "Zen Drop +3%";
			this.item6ExcOpt4.UseVisualStyleBackColor = false;
			this.item6Skill.AutoSize = true;
			this.item6Skill.BackColor = Color.Transparent;
			this.item6Skill.Enabled = false;
			this.item6Skill.ForeColor = SystemColors.InfoText;
			this.item6Skill.Location = new Point(214, 73);
			this.item6Skill.Name = "item6Skill";
			this.item6Skill.Size = new System.Drawing.Size(45, 17);
			this.item6Skill.TabIndex = 47;
			this.item6Skill.Text = "Skill";
			this.item6Skill.UseVisualStyleBackColor = false;
			this.item6Luck.AutoSize = true;
			this.item6Luck.BackColor = Color.Transparent;
			this.item6Luck.Enabled = false;
			this.item6Luck.ForeColor = SystemColors.InfoText;
			this.item6Luck.Location = new Point(162, 73);
			this.item6Luck.Name = "item6Luck";
			this.item6Luck.Size = new System.Drawing.Size(50, 17);
			this.item6Luck.TabIndex = 46;
			this.item6Luck.Text = "Luck";
			this.item6Luck.UseVisualStyleBackColor = false;
			this.item6Ancient.Enabled = false;
			this.item6Ancient.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections8 = this.item6Ancient.Items;
			objArray = new object[] { "No Ancient", "Ancient Lvl 1", "Ancient Lvl 2" };
			objectCollections8.AddRange(objArray);
			this.item6Ancient.Location = new Point(162, 95);
			this.item6Ancient.Name = "item6Ancient";
			this.item6Ancient.Size = new System.Drawing.Size(102, 21);
			this.item6Ancient.TabIndex = 45;
			this.item6Ancient.Text = "Ancient";
			this.item6Sckt.Enabled = false;
			this.item6Sckt.FormattingEnabled = true;
			this.item6Sckt.Location = new Point(162, 43);
			this.item6Sckt.Name = "item6Sckt";
			this.item6Sckt.Size = new System.Drawing.Size(48, 21);
			this.item6Sckt.TabIndex = 44;
			this.item6Sckt.Text = "Sckt";
			this.item6Opt.Enabled = false;
			this.item6Opt.FormattingEnabled = true;
			this.item6Opt.Location = new Point(216, 16);
			this.item6Opt.Name = "item6Opt";
			this.item6Opt.Size = new System.Drawing.Size(48, 21);
			this.item6Opt.TabIndex = 43;
			this.item6Opt.Text = "Opt";
			this.item6Lvl.Enabled = false;
			this.item6Lvl.FormattingEnabled = true;
			this.item6Lvl.Location = new Point(162, 16);
			this.item6Lvl.Name = "item6Lvl";
			this.item6Lvl.Size = new System.Drawing.Size(48, 21);
			this.item6Lvl.TabIndex = 42;
			this.item6Lvl.Text = "Lvl";
			this.groupBox12.BackColor = Color.Transparent;
			this.groupBox12.Controls.Add(this.item6Price);
			this.groupBox12.Controls.Add(this.item6Count);
			this.groupBox12.Controls.Add(this.item6Name);
			this.groupBox12.Controls.Add(this.item6Enable);
			this.groupBox12.Location = new Point(6, 10);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(149, 106);
			this.groupBox12.TabIndex = 40;
			this.groupBox12.TabStop = false;
			this.item6Price.Enabled = false;
			this.item6Price.Location = new Point(73, 70);
			this.item6Price.Name = "item6Price";
			this.item6Price.Size = new System.Drawing.Size(69, 20);
			this.item6Price.TabIndex = 41;
			this.item6Price.Text = "Price";
			this.item6Price.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item6Count.Enabled = false;
			this.item6Count.Location = new Point(8, 70);
			this.item6Count.Name = "item6Count";
			this.item6Count.Size = new System.Drawing.Size(59, 20);
			this.item6Count.TabIndex = 40;
			this.item6Count.Text = "Count";
			this.item6Count.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.item6Name.Enabled = false;
			this.item6Name.Location = new Point(8, 36);
			this.item6Name.Name = "item6Name";
			this.item6Name.Size = new System.Drawing.Size(134, 20);
			this.item6Name.TabIndex = 39;
			this.item6Name.Text = "Name";
			this.item6Name.TextChanged += new EventHandler(this.packDisc_TextChanged);
			this.item6Name.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.item6Enable.AutoSize = true;
			this.item6Enable.BackColor = Color.White;
			this.item6Enable.Enabled = false;
			this.item6Enable.FlatStyle = FlatStyle.Popup;
			this.item6Enable.ForeColor = SystemColors.InfoText;
			this.item6Enable.Location = new Point(8, -1);
			this.item6Enable.Name = "item6Enable";
			this.item6Enable.Size = new System.Drawing.Size(57, 17);
			this.item6Enable.TabIndex = 38;
			this.item6Enable.Tag = "6";
			this.item6Enable.Text = "Enable";
			this.item6Enable.UseVisualStyleBackColor = false;
			this.item6Enable.CheckedChanged += new EventHandler(this.item6Enable_CheckedChanged);
			this.packageEnable.AutoSize = true;
			this.packageEnable.BackColor = Color.Transparent;
			this.packageEnable.Checked = true;
			this.packageEnable.Font = new System.Drawing.Font("Arial Unicode MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.packageEnable.ForeColor = Color.LightYellow;
			this.packageEnable.Location = new Point(459, 281);
			this.packageEnable.Name = "packageEnable";
			this.packageEnable.Size = new System.Drawing.Size(74, 20);
			this.packageEnable.TabIndex = 105;
			this.packageEnable.TabStop = true;
			this.packageEnable.Text = "Package";
			this.packageEnable.UseVisualStyleBackColor = false;
			this.packageEnable.CheckedChanged += new EventHandler(this.bundleEnable_CheckedChanged);
			this.bundleEnable.AutoSize = true;
			this.bundleEnable.BackColor = Color.Transparent;
			this.bundleEnable.Font = new System.Drawing.Font("Arial Unicode MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bundleEnable.ForeColor = Color.LightYellow;
			this.bundleEnable.Location = new Point(387, 281);
			this.bundleEnable.Name = "bundleEnable";
			this.bundleEnable.Size = new System.Drawing.Size(65, 20);
			this.bundleEnable.TabIndex = 104;
			this.bundleEnable.Text = "Bundle";
			this.bundleEnable.UseVisualStyleBackColor = false;
			this.bundleEnable.CheckedChanged += new EventHandler(this.bundleEnable_CheckedChanged);
			this.packUnit.FormattingEnabled = true;
			this.packUnit.Location = new Point(476, 233);
			this.packUnit.Name = "packUnit";
			this.packUnit.Size = new System.Drawing.Size(50, 21);
			this.packUnit.TabIndex = 103;
			this.packUnit.Tag = "Select Unit";
			this.packUnit.Text = "Unit";
			this.packUnit.SelectedIndexChanged += new EventHandler(this.packUnit_SelectedIndexChanged);
			this.itemIndexList.FormattingEnabled = true;
			this.itemIndexList.Location = new Point(181, 127);
			this.itemIndexList.Name = "itemIndexList";
			this.itemIndexList.Size = new System.Drawing.Size(54, 108);
			this.itemIndexList.TabIndex = 102;
			this.itemIndexList.Visible = false;
			this.itemIndexList.SelectedIndexChanged += new EventHandler(this.itemIndexList_SelectedIndexChanged);
			this.totalPages.BackColor = Color.Transparent;
			this.totalPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.totalPages.ForeColor = Color.FromArgb(24, 24, 24);
			this.totalPages.Location = new Point(865, 449);
			this.totalPages.Name = "totalPages";
			this.totalPages.Size = new System.Drawing.Size(15, 17);
			this.totalPages.TabIndex = 67;
			this.totalPages.Text = "6";
			this.totalPages.TextAlign = ContentAlignment.MiddleCenter;
			this.currentPage.BackColor = Color.Transparent;
			this.currentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.currentPage.ForeColor = Color.FromArgb(24, 24, 24);
			this.currentPage.Location = new Point(844, 449);
			this.currentPage.Name = "currentPage";
			this.currentPage.Size = new System.Drawing.Size(15, 17);
			this.currentPage.TabIndex = 66;
			this.currentPage.Text = "1";
			this.currentPage.TextAlign = ContentAlignment.MiddleCenter;
			this.nextBtn.BackColor = Color.Transparent;
			this.nextBtn.BackgroundImage = Class9.smethod_19();
			this.nextBtn.BackgroundImageLayout = ImageLayout.Center;
			this.nextBtn.Cursor = Cursors.Hand;
			this.nextBtn.FlatAppearance.BorderSize = 0;
			this.nextBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
			this.nextBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
			this.nextBtn.FlatStyle = FlatStyle.Flat;
			this.nextBtn.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.nextBtn.ForeColor = SystemColors.ControlDarkDark;
			this.nextBtn.Location = new Point(879, 449);
			this.nextBtn.Margin = new System.Windows.Forms.Padding(0);
			this.nextBtn.Name = "nextBtn";
			this.nextBtn.Size = new System.Drawing.Size(27, 17);
			this.nextBtn.TabIndex = 65;
			this.nextBtn.UseVisualStyleBackColor = false;
			this.nextBtn.Click += new EventHandler(this.prevBtn_Click);
			this.flowLayoutPanel1.BackColor = Color.Transparent;
			this.flowLayoutPanel1.Location = new Point(695, 53);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 390);
			this.flowLayoutPanel1.TabIndex = 63;
			this.prevBtn.BackColor = Color.Transparent;
			this.prevBtn.BackgroundImage = Class9.smethod_23();
			this.prevBtn.BackgroundImageLayout = ImageLayout.Center;
			this.prevBtn.Cursor = Cursors.Hand;
			this.prevBtn.FlatAppearance.BorderSize = 0;
			this.prevBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
			this.prevBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
			this.prevBtn.FlatStyle = FlatStyle.Flat;
			this.prevBtn.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.prevBtn.ForeColor = SystemColors.ControlDarkDark;
			this.prevBtn.Location = new Point(815, 449);
			this.prevBtn.Margin = new System.Windows.Forms.Padding(0);
			this.prevBtn.Name = "prevBtn";
			this.prevBtn.Size = new System.Drawing.Size(27, 17);
			this.prevBtn.TabIndex = 64;
			this.prevBtn.UseVisualStyleBackColor = false;
			this.prevBtn.Click += new EventHandler(this.prevBtn_Click);
			this.mainCutPanel.BackColor = Color.Transparent;
			this.mainCutPanel.ContextMenuStrip = this.contexMenu;
			this.mainCutPanel.Location = new Point(701, 20);
			this.mainCutPanel.Name = "mainCutPanel";
			this.mainCutPanel.Size = new System.Drawing.Size(355, 28);
			this.mainCutPanel.TabIndex = 62;
			this.statusStrip1.AutoSize = false;
			ToolStripItemCollection toolStripItemCollections4 = this.statusStrip1.Items;
			toolStripItemArray = new ToolStripItem[] { this.statusicon, this.statusinfo, this.workProgress, this.pleaseWait };
			toolStripItemCollections4.AddRange(toolStripItemArray);
			this.statusStrip1.Location = new Point(0, 507);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1062, 22);
			this.statusStrip1.Stretch = false;
			this.statusStrip1.TabIndex = 61;
			this.statusStrip1.Text = "statusStrip1";
			this.statusicon.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.statusicon.Image = Class9.smethod_12();
			this.statusicon.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.statusicon.Name = "statusicon";
			this.statusicon.Size = new System.Drawing.Size(16, 17);
			this.statusicon.Text = "status";
			this.statusinfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.statusinfo.ForeColor = SystemColors.ActiveCaptionText;
			this.statusinfo.Name = "statusinfo";
			this.statusinfo.Size = new System.Drawing.Size(93, 17);
			this.statusinfo.Text = "Welcome Zythe!";
			this.statusinfo.TextAlign = ContentAlignment.MiddleLeft;
			this.subCutPanel.BackColor = Color.Transparent;
			this.subCutPanel.ContextMenuStrip = this.contexMenu;
			this.subCutPanel.Location = new Point(595, 58);
			this.subCutPanel.Name = "subCutPanel";
			this.subCutPanel.Size = new System.Drawing.Size(96, 411);
			this.subCutPanel.TabIndex = 59;
			this.updatePack.BackColor = Color.FromArgb(64, 64, 64);
			this.updatePack.Cursor = Cursors.Hand;
			this.updatePack.FlatAppearance.BorderSize = 0;
			this.updatePack.FlatAppearance.MouseDownBackColor = Color.White;
			this.updatePack.FlatAppearance.MouseOverBackColor = Color.White;
			this.updatePack.FlatStyle = FlatStyle.Flat;
			this.updatePack.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.updatePack.ForeColor = SystemColors.ControlDarkDark;
			this.updatePack.Image = (Image)componentResourceManager.GetObject("updatePack.Image");
			this.updatePack.Location = new Point(547, 127);
			this.updatePack.Margin = new System.Windows.Forms.Padding(0);
			this.updatePack.Name = "updatePack";
			this.updatePack.Size = new System.Drawing.Size(38, 60);
			this.updatePack.TabIndex = 55;
			this.updatePack.UseVisualStyleBackColor = false;
			this.updatePack.Click += new EventHandler(this.updatePack_Click);
			this.updatePack.KeyDown += new KeyEventHandler(this.updatePack_KeyDown);
			this.addPack.BackColor = Color.FromArgb(64, 64, 64);
			this.addPack.Cursor = Cursors.Hand;
			this.addPack.FlatAppearance.BorderSize = 0;
			this.addPack.FlatAppearance.MouseDownBackColor = Color.White;
			this.addPack.FlatAppearance.MouseOverBackColor = Color.White;
			this.addPack.FlatStyle = FlatStyle.Flat;
			this.addPack.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.addPack.ForeColor = SystemColors.ControlDarkDark;
			this.addPack.Image = (Image)componentResourceManager.GetObject("addPack.Image");
			this.addPack.Location = new Point(547, 58);
			this.addPack.Margin = new System.Windows.Forms.Padding(0);
			this.addPack.Name = "addPack";
			this.addPack.Size = new System.Drawing.Size(38, 60);
			this.addPack.TabIndex = 54;
			this.addPack.UseVisualStyleBackColor = false;
			this.addPack.Click += new EventHandler(this.addPack_Click);
			this.itemImg.BackColor = Color.FromArgb(46, 46, 46);
			this.itemImg.BackgroundImageLayout = ImageLayout.Center;
			this.itemImg.BorderStyle = BorderStyle.FixedSingle;
			this.itemImg.ErrorImage = Class9.smethod_20();
			this.itemImg.Location = new Point(255, 58);
			this.itemImg.Name = "itemImg";
			this.itemImg.Size = new System.Drawing.Size(71, 126);
			this.itemImg.TabIndex = 47;
			this.itemImg.TabStop = false;
			this.packCurrency.FormattingEnabled = true;
			ComboBox.ObjectCollection items9 = this.packCurrency.Items;
			objArray = new object[] { "W Coin (C)", "W Coin (P)", "Goblin Points" };
			items9.AddRange(objArray);
			this.packCurrency.Location = new Point(335, 233);
			this.packCurrency.Name = "packCurrency";
			this.packCurrency.Size = new System.Drawing.Size(77, 21);
			this.packCurrency.TabIndex = 5;
			this.packCurrency.Tag = "Select Currency";
			this.packCurrency.Text = "Currency";
			this.packType.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections9 = this.packType.Items;
			objArray = new object[] { "Normal (Qty)", "Expire Pet /Item (Duration)", "Expire Seal /Scroll (Duration)", "Rate (%)" };
			objectCollections9.AddRange(objArray);
			this.packType.Location = new Point(255, 233);
			this.packType.Name = "packType";
			this.packType.Size = new System.Drawing.Size(74, 21);
			this.packType.TabIndex = 4;
			this.packType.Tag = "Select Pack Type";
			this.packType.Text = "Pack Type";
			this.packType.SelectedIndexChanged += new EventHandler(this.packType_SelectedIndexChanged);
			this.packCount.Location = new Point(418, 233);
			this.packCount.Name = "packCount";
			this.packCount.Size = new System.Drawing.Size(52, 20);
			this.packCount.TabIndex = 6;
			this.packCount.Tag = "Enter Count or Quantity";
			this.packCount.Text = "Count";
			this.packCount.TextChanged += new EventHandler(this.packCount_TextChanged);
			this.packCount.KeyPress += new KeyPressEventHandler(this.packCount_KeyPress);
			this.packDisc.Location = new Point(333, 94);
			this.packDisc.Multiline = true;
			this.packDisc.Name = "packDisc";
			this.packDisc.ScrollBars = ScrollBars.Vertical;
			this.packDisc.Size = new System.Drawing.Size(194, 90);
			this.packDisc.TabIndex = 3;
			this.packDisc.Tag = "Description of the Package, use Enter Key as  line separator";
			this.packDisc.Text = "Description";
			this.packDisc.TextChanged += new EventHandler(this.packDisc_TextChanged);
			this.packDisc.KeyDown += new KeyEventHandler(this.packDisc_KeyDown);
			this.packDisc.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.packName.Location = new Point(333, 61);
			this.packName.Name = "packName";
			this.packName.Size = new System.Drawing.Size(194, 20);
			this.packName.TabIndex = 2;
			this.packName.Tag = "Enter Package Name";
			this.packName.Text = "Name";
			this.packName.TextChanged += new EventHandler(this.packName_TextChanged);
			this.packName.KeyPress += new KeyPressEventHandler(this.packName_KeyPress);
			this.itemListBox.BorderStyle = BorderStyle.FixedSingle;
			this.itemListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.itemListBox.ForeColor = SystemColors.WindowText;
			this.itemListBox.FormattingEnabled = true;
			this.itemListBox.ItemHeight = 15;
			ListBox.ObjectCollection items10 = this.itemListBox.Items;
			objArray = new object[] { "Lol", "Lel" };
			items10.AddRange(objArray);
			this.itemListBox.Location = new Point(43, 117);
			this.itemListBox.Name = "itemListBox";
			this.itemListBox.ScrollAlwaysVisible = true;
			this.itemListBox.Size = new System.Drawing.Size(174, 137);
			this.itemListBox.TabIndex = 101;
			this.itemListBox.SelectedIndexChanged += new EventHandler(this.itemListBox_SelectedIndexChanged);
			this.itemGroup.BackColor = SystemColors.MenuBar;
			this.itemGroup.FlatStyle = FlatStyle.System;
			this.itemGroup.FormattingEnabled = true;
			this.itemGroup.Location = new Point(43, 62);
			this.itemGroup.Name = "itemGroup";
			this.itemGroup.Size = new System.Drawing.Size(174, 21);
			this.itemGroup.TabIndex = 100;
			this.itemGroup.Text = "Item Group";
			this.itemGroup.SelectedIndexChanged += new EventHandler(this.itemGroup_SelectedIndexChanged);
			this.workProgress.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
			this.workProgress.Name = "workProgress";
			this.workProgress.Size = new System.Drawing.Size(120, 16);
			this.workProgress.Style = ProgressBarStyle.Marquee;
			this.workProgress.Value = 1;
			this.workProgress.Visible = false;
			this.pleaseWait.ForeColor = SystemColors.ActiveCaptionText;
			this.pleaseWait.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.pleaseWait.Name = "pleaseWait";
			this.pleaseWait.Size = new System.Drawing.Size(71, 17);
			this.pleaseWait.Text = "Please wait..";
			this.pleaseWait.Visible = false;
			this.backgroundWorker_1.DoWork += new DoWorkEventHandler(this.backgroundWorker_1_DoWork);
			this.backgroundWorker_1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_1_RunWorkerCompleted);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new System.Drawing.Size(1062, 554);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.menuStrip1);
			this.ForeColor = SystemColors.ButtonFace;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Zythe CashShop Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.contexMenu.ResumeLayout(false);
			this.packageMenu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.bdPanel.ResumeLayout(false);
			this.addtoproductPanel.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			((ISupportInitialize)this.PrDGV).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((ISupportInitialize)this.bundleDGV).EndInit();
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.groupBox13.ResumeLayout(false);
			this.groupBox13.PerformLayout();
			this.groupBox14.ResumeLayout(false);
			this.groupBox14.PerformLayout();
			this.pcPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.itemTabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((ISupportInitialize)this.itemImg).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void item1Count_TextChanged(object sender, EventArgs e)
		{
			this.packCount.Text = this.item1Count.Text;
		}

		private void item1Name_TextChanged(object sender, EventArgs e)
		{
			string text = ((Control)sender).Text;
			if (text.Contains(";"))
			{
				((Control)sender).Text = text.Replace(";", " ");
			}
			if (text.Contains("^"))
			{
				((Control)sender).Text = text.Replace("^", " ");
			}
		}

		private void item6Enable_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = (CheckBox)sender;
			int num = Convert.ToInt32(checkBox.Tag);
			CheckBox[] checkBoxArray = new CheckBox[] { this.item1Enable, this.item2Enable, this.item3Enable, this.item4Enable, this.item5Enable, this.item6Enable };
			CheckBox[] checkBoxArray1 = checkBoxArray;
			if (!checkBox.Checked)
			{
				for (int i = 0; i < 6; i++)
				{
					if (i > num - 1)
					{
						checkBoxArray1[i].Checked = false;
						checkBoxArray1[i].Enabled = false;
					}
				}
				this.method_36(false, num - 1);
			}
			else
			{
				if (num != 6)
				{
					checkBoxArray1[num].Enabled = true;
				}
				this.method_36(true, num - 1);
			}
		}

		private void item6ExcOptType_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			int num = Convert.ToInt32(comboBox.Name.Substring(4, 1)) - 1;
			int selectedIndex = comboBox.SelectedIndex;
			Dictionary<string, Control[]> strs = this.method_37();
			switch (selectedIndex)
			{
				case 0:
				{
					strs["ExcOpt1"][num].Tag = "Increase mana after monster + mana/8";
					strs["ExcOpt2"][num].Tag = "Increase life after monster + life/8";
					strs["ExcOpt3"][num].Tag = "Increase Speed + 7";
					strs["ExcOpt4"][num].Tag = "Increase Damage + 2%";
					strs["ExcOpt5"][num].Tag = "Increase Damage + level/20";
					strs["ExcOpt6"][num].Tag = "Excellent Damage Rate + 10%";
					strs["ExcOpt1"][num].Text = "++ M H M +M";
					strs["ExcOpt2"][num].Text = "++ L H M +L";
					strs["ExcOpt3"][num].Text = "++ A(W)speed";
					strs["ExcOpt4"][num].Text = "++ Damage";
					strs["ExcOpt5"][num].Text = "++ Dmg lvl";
					strs["ExcOpt6"][num].Text = "++ Exc Dmg %";
					break;
				}
				case 1:
				{
					strs["ExcOpt1"][num].Tag = "Increase Zen After Hunt 40%";
					strs["ExcOpt2"][num].Tag = "Defense Succes Rate 10%";
					strs["ExcOpt3"][num].Tag = "Reflect Damage 5%";
					strs["ExcOpt4"][num].Tag = "Damage Decrease 4%";
					strs["ExcOpt5"][num].Tag = "Increase MP 4%";
					strs["ExcOpt6"][num].Tag = "Increase HP 4%";
					strs["ExcOpt1"][num].Text = "++ Zen";
					strs["ExcOpt2"][num].Text = "Defense SR";
					strs["ExcOpt3"][num].Text = "Reflect Dmg";
					strs["ExcOpt4"][num].Text = "Decrese Dmg";
					strs["ExcOpt5"][num].Text = "++ Max Mana";
					strs["ExcOpt6"][num].Text = "++ Max HP";
					break;
				}
				case 2:
				{
					strs["ExcOpt1"][num].Tag = "Ignore Enemies Defensive Power 5% / HP +125";
					strs["ExcOpt2"][num].Tag = "Return Enemies Attact 5% / Mana +125";
					strs["ExcOpt3"][num].Tag = "Complete HP Recovery 5% / Ignore Defense +3%";
					strs["ExcOpt4"][num].Tag = "Complete MP Recovery 5% / AG +50";
					strs["ExcOpt5"][num].Tag = "Auto HP Recovery / Attack (Wiz) Speed +5";
					strs["ExcOpt6"][num].Tag = "No Opt.";
					strs["ExcOpt1"][num].Text = "Ignore DP 5%";
					strs["ExcOpt2"][num].Text = "Return Att 5%";
					strs["ExcOpt3"][num].Text = "*HP Rcvry 5%";
					strs["ExcOpt4"][num].Text = "*MP Rcvry 5%";
					strs["ExcOpt5"][num].Text = "Auto HP Rcvry";
					(strs["ExcOpt6"][num] as CheckBox).Checked = false;
					strs["ExcOpt6"][num].Text = "No Opt.";
					break;
				}
			}
		}

		private void itemGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int selectedIndex = this.itemListBox.SelectedIndex;
				this.itemListBox.Items.Clear();
				this.itemIndexList.Items.Clear();
				int num = this.itemGroup.SelectedIndex;
				foreach (string list0 in this.list_0)
				{
					string[] strArrays = list0.Split(new char[] { '|' });
					if (strArrays[0] != num.ToString())
					{
						continue;
					}
					this.itemListBox.Items.Add(strArrays[2]);
					this.itemIndexList.Items.Add(strArrays[1]);
				}
				try
				{
					this.itemListBox.SelectedIndex = selectedIndex;
				}
				catch (Exception exception)
				{
					this.itemListBox.SelectedIndex = -1;
				}
				this.method_14(num);
				this.method_15(num);
			}
			catch (Exception exception1)
			{
				Class3.smethod_1(exception1.Message, "warning");
			}
		}

		private void itemIndexList_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.itemListBox.SelectedIndex = this.itemIndexList.SelectedIndex;
		}

		private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] text;
			this.packName.Text = this.itemListBox.GetItemText(this.itemListBox.SelectedItem);
			this.itemIndexList.SelectedIndex = this.itemListBox.SelectedIndex;
			Control[] item = this.method_37()["Count"];
			int num = 0;
			Control[] controlArray = this.method_37()["PName"];
			for (int i = 0; i < (int)controlArray.Length; i++)
			{
				Control control = controlArray[i];
				text = new string[] { this.packName.Text, " (", item[num].Text, " ", this.packUnit.Text.Replace("(s)", "s"), ")" };
				control.Text = string.Concat(text);
				num++;
			}
			this.itemImg.SizeMode = PictureBoxSizeMode.CenterImage;
			try
			{
				text = new string[] { AppDomain.CurrentDomain.BaseDirectory, "\\Data\\item.img\\", null, null, null, null };
				int selectedIndex = this.itemGroup.SelectedIndex;
				text[2] = selectedIndex.ToString("D2");
				text[3] = "\\";
				text[4] = this.method_8(this.itemIndexList.SelectedItem);
				text[5] = ".gif";
				Image image = Image.FromFile(string.Concat(text));
				if (image.Width > this.itemImg.Width)
				{
					this.itemImg.SizeMode = PictureBoxSizeMode.Zoom;
				}
				this.itemImg.Image = image;
			}
			catch (Exception exception)
			{
				this.itemImg.Image = Class9.smethod_20();
			}
		}

		private void method_0()
		{
			Control[] value;
			int i;
			this.newMedit.KeyPress += new KeyPressEventHandler(this.newTedit_KeyPress);
			this.newTedit.KeyPress += new KeyPressEventHandler(this.newTedit_KeyPress);
			this.newMedit.LostFocus += new EventHandler(this.newTedit_LostFocus);
			this.newTedit.LostFocus += new EventHandler(this.newTedit_LostFocus);
			string[] strArrays = new string[] { "Enable" };
			foreach (KeyValuePair<string, Control[]> keyValuePair in this.method_37())
			{
				if (Array.IndexOf<string>(strArrays, keyValuePair.Key) < 0)
				{
					value = keyValuePair.Value;
					for (i = 0; i < (int)value.Length; i++)
					{
						Control tag = value[i];
						if ((tag.Tag == null || Convert.ToString(tag.Tag) == "" ? true : tag.Tag.ToString().Length == 0))
						{
							tag.Tag = keyValuePair.Value[0].Tag;
						}
						tag.GotFocus += new EventHandler(this.method_39);
						tag.LostFocus += new EventHandler(this.method_40);
					}
				}
				if (keyValuePair.Key != "Count")
				{
					continue;
				}
				value = keyValuePair.Value;
				for (i = 0; i < (int)value.Length; i++)
				{
					value[i].TextChanged += new EventHandler(this.method_1);
				}
			}
		}

		private void method_1(object sender, EventArgs e)
		{
			int num = this.method_7(((Control)sender).Name.Substring(4, 1), -99) - 1;
			num = (num == -1 ? 6 : num);
			Control[] item = this.method_37()["PName"];
			Control[] controlArray = this.method_37()["Count"];
			Control control = item[num];
			string[] text = new string[] { this.packName.Text, " (", controlArray[num].Text, " ", this.packUnit.Text.Replace("(s)", "s"), ")" };
			control.Text = string.Concat(text);
		}

		private void method_10(int int_5)
		{
			this.int_0[1] = int_5;
			foreach (Control control in this.subCutPanel.Controls)
			{
				if (!(control is Button))
				{
					continue;
				}
				if (Convert.ToInt32(control.Tag) != int_5)
				{
					control.BackColor = Color.White;
				}
				else
				{
					control.BackColor = Color.FromArgb(24, 24, 24);
				}
			}
			this.method_11(int_5, 1);
		}

		private void method_11(int int_5, int int_6 = 1)
		{
			int int6;
			string str = string.Concat("CategoryID =", int_5);
			string str1 = "PackageSort ASC";
			DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSPackage"].Select(str, str1);
			this.flowLayoutPanel1.Controls.Clear();
			int num = Convert.ToInt32((int)dataRowArray.Length) / 9 + 1;
			int num1 = 0;
			DataRow[] dataRowArray1 = dataRowArray;
			for (int i = 0; i < (int)dataRowArray1.Length; i++)
			{
				DataRow dataRow = dataRowArray1[i];
				int num2 = Convert.ToInt32(dataRow["PackageID"]);
				DataRow dataRow1 = Form1.dataSet_0.Tables["CashShopPackage"].Rows.Find(num2);
				string[] baseDirectory = new string[2];
				int6 = this.method_7(dataRow1["ItemGroup"], -99);
				baseDirectory[0] = int6.ToString("D2");
				baseDirectory[1] = this.method_8(dataRow1["ItemIndex"]);
				string[] strArrays = baseDirectory;
				if ((num1 < int_6 * 9 - 9 || num1 > int_6 * 9 ? false : dataRow1 != null))
				{
					Panel panel = new Panel();
					Label label = new Label();
					Label silver = new Label();
					PictureBox pictureBox = new PictureBox();
					string str2 = dataRow[3].ToString();
					string str3 = string.Concat(dataRow[5].ToString(), " ", dataRow[14].ToString());
					this.method_7(dataRow["ItemID"], -99);
					label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					label.ForeColor = Color.Silver;
					label.Location = new Point(2, 2);
					label.Size = new System.Drawing.Size(96, 28);
					label.Text = str2;
					label.BackColor = Color.Transparent;
					label.TextAlign = ContentAlignment.MiddleCenter;
					silver.ForeColor = Color.Silver;
					silver.Location = new Point(2, 88);
					silver.Size = new System.Drawing.Size(96, 28);
					silver.Text = str3;
					silver.BackColor = Color.Transparent;
					silver.TextAlign = ContentAlignment.MiddleCenter;
					pictureBox.Location = new Point(12, 28);
					pictureBox.Size = new System.Drawing.Size(77, 63);
					pictureBox.Tag = dataRow[2];
					pictureBox.ContextMenuStrip = this.packageMenu;
					pictureBox.MouseDown += new MouseEventHandler(this.method_13);
					pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
					try
					{
						baseDirectory = new string[] { AppDomain.CurrentDomain.BaseDirectory, "\\Data\\item.img\\", strArrays[0], "\\", strArrays[1], ".gif" };
						Image image = Image.FromFile(string.Concat(baseDirectory));
						if ((image.Width > pictureBox.Width ? true : image.Height > pictureBox.Height))
						{
							pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
						}
						pictureBox.Image = image;
					}
					catch (Exception exception)
					{
						pictureBox.Image = Class9.smethod_20();
					}
					panel.BackColor = Color.FromArgb(24, 24, 24);
					panel.ForeColor = SystemColors.ActiveCaptionText;
					panel.BackgroundImageLayout = ImageLayout.Center;
					panel.Margin = new System.Windows.Forms.Padding(5);
					panel.Name = string.Concat("itemPN", num1.ToString());
					panel.Tag = dataRow[2];
					panel.Size = new System.Drawing.Size(100, 120);
					this.flowLayoutPanel1.Controls.Add(panel);
					panel.Controls.Add(label);
					panel.Controls.Add(silver);
					panel.Controls.Add(pictureBox);
				}
				if (num1 > int_6 * 9)
				{
					break;
				}
				num1++;
			}
			this.totalPages.Text = num.ToString();
			this.currentPage.Text = int_6.ToString();
			if (int_6 != 1)
			{
				this.prevBtn.Enabled = true;
			}
			else
			{
				this.prevBtn.Enabled = false;
			}
			if (int_6 != num)
			{
				this.nextBtn.Enabled = true;
			}
			else
			{
				this.nextBtn.Enabled = false;
			}
			int6 = int_6 - 1;
			this.prevBtn.Tag = string.Concat(int_5.ToString(), "|", int6.ToString());
			int6 = int_6 + 1;
			this.nextBtn.Tag = string.Concat(int_5.ToString(), "|", int6.ToString());
			this.int_1[0] = int_5;
			this.int_1[1] = int_6;
			this.int_1[2] = num;
		}

		private void method_12(Control control_1)
		{
			try
			{
				control_1.Parent.BackgroundImage = Class9.smethod_11();
				if (this.control_0 != null)
				{
					this.control_0.Parent.BackgroundImage = null;
				}
				this.control_0 = control_1;
			}
			catch (Exception exception)
			{
				this.int_2 = 0;
			}
		}

		private void method_13(object sender, MouseEventArgs e)
		{
			int num;
			if ((e == null ? false : e.Button == System.Windows.Forms.MouseButtons.Middle))
			{
				num = this.method_7(((Control)sender).Tag, -99);
				this.method_12((Control)sender);
				this.int_2 = num;
				this.method_20(this.int_2);
			}
			if (e == null)
			{
				num = this.method_7(((Control)sender).Tag, -99);
				this.method_12((Control)sender);
				this.int_2 = num;
				this.method_20(this.int_2);
			}
		}

		private void method_14(int int_5)
		{
			Control[] controlArray;
			int i;
			Control[] item = this.method_37()["ExcOptType"];
			if (int_5 <= 5)
			{
				controlArray = item;
				for (i = 0; i < (int)controlArray.Length; i++)
				{
					((ComboBox)controlArray[i]).SelectedIndex = 0;
				}
			}
			else if ((int_5 <= 5 ? true : int_5 > 11))
			{
				controlArray = item;
				for (i = 0; i < (int)controlArray.Length; i++)
				{
					((ComboBox)controlArray[i]).SelectedIndex = 2;
				}
			}
			else
			{
				controlArray = item;
				for (i = 0; i < (int)controlArray.Length; i++)
				{
					((ComboBox)controlArray[i]).SelectedIndex = 1;
				}
			}
		}

		private void method_15(int int_5)
		{
			if (int_5 <= 5)
			{
				this.item1ExcOptType.SelectedIndex = 0;
				this.item2ExcOptType.SelectedIndex = 0;
				this.item3ExcOptType.SelectedIndex = 0;
				this.item4ExcOptType.SelectedIndex = 0;
				this.item5ExcOptType.SelectedIndex = 0;
				this.item6ExcOptType.SelectedIndex = 0;
				this.newP7rExcOptType.SelectedIndex = 0;
			}
			if ((int_5 <= 5 ? false : int_5 <= 11))
			{
				this.item1ExcOptType.SelectedIndex = 1;
				this.item2ExcOptType.SelectedIndex = 1;
				this.item3ExcOptType.SelectedIndex = 1;
				this.item4ExcOptType.SelectedIndex = 1;
				this.item5ExcOptType.SelectedIndex = 1;
				this.item6ExcOptType.SelectedIndex = 1;
				this.newP7rExcOptType.SelectedIndex = 1;
			}
			if (int_5 > 11)
			{
				this.item1ExcOptType.SelectedIndex = 2;
				this.item2ExcOptType.SelectedIndex = 2;
				this.item3ExcOptType.SelectedIndex = 2;
				this.item4ExcOptType.SelectedIndex = 2;
				this.item5ExcOptType.SelectedIndex = 2;
				this.item6ExcOptType.SelectedIndex = 2;
				this.newP7rExcOptType.SelectedIndex = 2;
			}
		}

		private void method_16(string string_3, string string_4 = "")
		{
			string string4 = string_4;
			if (string4 != null)
			{
				if (string4 == "success")
				{
					this.statusicon.Image = Class9.smethod_29();
					this.statusicon.Visible = true;
					this.statusinfo.Visible = true;
					this.statusinfo.Text = string_3;
					return;
				}
				else if (string4 == "error")
				{
					this.statusicon.Image = Class9.smethod_6();
					this.statusicon.Visible = true;
					this.statusinfo.Visible = true;
					this.statusinfo.Text = string_3;
					return;
				}
				else
				{
					if (string4 != "warning")
					{
						this.statusicon.Image = Class9.smethod_12();
						this.statusicon.Visible = true;
						this.statusinfo.Visible = true;
						this.statusinfo.Text = string_3;
						return;
					}
					this.statusicon.Image = Class9.smethod_30();
					this.statusicon.Visible = true;
					this.statusinfo.Visible = true;
					this.statusinfo.Text = string_3;
					return;
				}
			}
			this.statusicon.Image = Class9.smethod_12();
			this.statusicon.Visible = true;
			this.statusinfo.Visible = true;
			this.statusinfo.Text = string_3;
		}

		private bool method_17(int int_5)
		{
			bool flag;
			bool flag1 = false;
			DataRow dataRow = Form1.dataSet_0.Tables["IBSPackage"].Rows.Find(int_5);
			if (dataRow != null)
			{
				if ((this.method_7(dataRow["CategoryID"], -99) != this.int_1[0] || dataRow == null ? false : int_5 != 0))
				{
					DataRow dataRow1 = Form1.dataSet_0.Tables["CashShopPackage"].Rows.Find(dataRow["PackageID"]);
					Form1.dataSet_0.Tables["CashShopPackage"].Rows.Remove(dataRow1);
					Form1.dataSet_0.Tables["IBSPackage"].Rows.Remove(dataRow);
					flag1 = true;
				}
				flag = flag1;
			}
			else
			{
				flag = flag1;
			}
			return flag;
		}

		private bool method_18(int int_5)
		{
			bool flag;
			int i;
			bool flag1 = false;
			DataRow dataRow = Form1.dataSet_0.Tables["IBSPackage"].Rows.Find(int_5);
			if (dataRow != null)
			{
				if ((this.method_7(dataRow["CategoryID"], -99) != this.int_1[0] || dataRow == null ? false : int_5 != 0))
				{
					DataRow dataRow1 = Form1.dataSet_0.Tables["CashShopPackage"].Rows.Find(dataRow["PackageID"]);
					string str = string.Concat("ProductID = ", dataRow["ProductID"].ToString().Replace("|", ""));
					DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSProduct"].Select(str);
					DataRow[] dataRowArray1 = Form1.dataSet_0.Tables["CashShopProduct"].Select(str);
					DataRow[] dataRowArray2 = dataRowArray1;
					for (i = 0; i < (int)dataRowArray2.Length; i++)
					{
						DataRow dataRow2 = dataRowArray2[i];
						Form1.dataSet_0.Tables["CashShopProduct"].Rows.Remove(dataRow2);
					}
					dataRowArray2 = dataRowArray;
					for (i = 0; i < (int)dataRowArray2.Length; i++)
					{
						DataRow dataRow3 = dataRowArray2[i];
						Form1.dataSet_0.Tables["IBSProduct"].Rows.Remove(dataRow3);
					}
					Form1.dataSet_0.Tables["CashShopPackage"].Rows.Remove(dataRow1);
					Form1.dataSet_0.Tables["IBSPackage"].Rows.Remove(dataRow);
					flag1 = true;
				}
				flag = flag1;
			}
			else
			{
				flag = flag1;
			}
			return flag;
		}

		private bool method_19(int int_5)
		{
			int i;
			bool flag = false;
			string str = string.Concat("ProductID = ", int_5);
			DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSProduct"].Select(str);
			DataRow[] dataRowArray1 = Form1.dataSet_0.Tables["CashShopProduct"].Select(str);
			if ((dataRowArray == null ? false : dataRowArray1 != null))
			{
				DataRow[] dataRowArray2 = dataRowArray1;
				for (i = 0; i < (int)dataRowArray2.Length; i++)
				{
					DataRow dataRow = dataRowArray2[i];
					Form1.dataSet_0.Tables["CashShopProduct"].Rows.Remove(dataRow);
				}
				dataRowArray2 = dataRowArray;
				for (i = 0; i < (int)dataRowArray2.Length; i++)
				{
					DataRow dataRow1 = dataRowArray2[i];
					Form1.dataSet_0.Tables["IBSProduct"].Rows.Remove(dataRow1);
				}
				flag = true;
			}
			return flag;
		}

		private void method_2(int int_5, bool bool_0)
		{
			int i;
			this.subCutPanel.Controls.Clear();
			this.mainCutPanel.Controls.Clear();
			int num = 0;
			int num1 = 0;
			DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSCategory"].Select("Code = 1", "CategorySort ASC");
			int num2 = 0;
			Form1.dataSet_0.Tables["IBSCategory"].Rows.Find(int_5);
			int num3 = (bool_0 ? int_5 : this.int_0[0]);
			string str = string.Concat("TypeID = ", num3, " AND Code = 0");
			DataRow[] dataRowArray1 = Form1.dataSet_0.Tables["IBSCategory"].Select(str, "CategorySort ASC");
			if (dataRowArray != null)
			{
				DataRow[] dataRowArray2 = dataRowArray;
				for (i = 0; i < (int)dataRowArray2.Length; i++)
				{
					DataRow dataRow = dataRowArray2[i];
					Button button = new Button()
					{
						Cursor = Cursors.Hand
					};
					button.FlatAppearance.BorderSize = 0;
					button.FlatAppearance.MouseDownBackColor = Color.White;
					button.FlatAppearance.MouseOverBackColor = Color.White;
					button.BackColor = Color.FromArgb(24, 24, 24);
					button.FlatStyle = FlatStyle.Flat;
					button.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
					button.ForeColor = SystemColors.ControlDarkDark;
					button.Location = new Point(num, 0);
					button.Margin = new System.Windows.Forms.Padding(0);
					button.Name = string.Concat("MainTab", dataRow["CategoryID"].ToString());
					button.Tag = dataRow["CategoryID"].ToString();
					button.Size = new System.Drawing.Size(89, 28);
					button.Text = dataRow["CategoryName"].ToString();
					button.UseVisualStyleBackColor = false;
					button.ContextMenuStrip = this.contexMenu;
					button.MouseDown += new MouseEventHandler(this.method_5);
					this.mainCutPanel.Controls.Add(button);
					num = num + 87;
					int num4 = (bool_0 ? int_5 : this.int_0[0]);
					if (this.method_7(dataRow["TypeID"], -99) == num4)
					{
						button.BackColor = Color.White;
						this.int_0[0] = num4;
					}
				}
				if ((int)dataRowArray1.Length != 0)
				{
					dataRowArray2 = dataRowArray1;
					for (i = 0; i < (int)dataRowArray2.Length; i++)
					{
						DataRow dataRow1 = dataRowArray2[i];
						Button font = new Button()
						{
							Cursor = Cursors.Hand
						};
						font.FlatAppearance.BorderSize = 0;
						font.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 24, 24);
						font.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
						font.FlatStyle = FlatStyle.Flat;
						font.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
						font.ForeColor = SystemColors.ControlDarkDark;
						font.Location = new Point(0, num1);
						font.Margin = new System.Windows.Forms.Padding(0);
						font.Name = string.Concat("SubTab", dataRow1["CategoryID"].ToString());
						font.Tag = dataRow1["CategoryID"].ToString();
						font.Size = new System.Drawing.Size(96, 28);
						font.Text = dataRow1["CategoryName"].ToString();
						font.UseVisualStyleBackColor = false;
						font.BackColor = Color.White;
						font.MouseDown += new MouseEventHandler(this.method_4);
						font.ContextMenuStrip = this.contexMenu;
						this.subCutPanel.Controls.Add(font);
						num1 = num1 + 28;
					}
					num2 = this.method_7(dataRowArray1[0]["CategoryID"], -99);
				}
				this.method_3(false);
				this.method_3(true);
				this.int_0[0] = (bool_0 ? int_5 : num3);
				this.int_0[1] = (bool_0 ? num2 : int_5);
				this.method_10(this.int_0[1]);
			}
		}

		private void method_20(int int_5)
		{
			DataRow dataRow = Form1.dataSet_0.Tables["IBSPackage"].Rows.Find(int_5);
			if (dataRow != null)
			{
				if (dataRow["ProductNumber"].ToString() != "")
				{
					this.packageEnable.Checked = true;
					this.method_45();
					Form1.dataSet_0.Tables["CashShopPackage"].Rows.Find(dataRow["PackageID"]);
					string str = string.Concat("ProductID = ", dataRow["ProductID"].ToString().Replace("|", ""));
					DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSProduct"].Select(str);
					DataRow[] dataRowArray1 = Form1.dataSet_0.Tables["CashShopProduct"].Select(str);
					int num = this.method_7(dataRow["NumberOfItems"], -99);
					try
					{
						this.itemGroup.SelectedIndex = this.method_7(dataRowArray1[0]["ItemGroup"], -99);
					}
					catch (Exception exception)
					{
						Class3.smethod_1((dataRowArray1 == null ? "This Package is missing in the ServerSide Database" : "The item from the database is not exists in the Item.txt"), "");
						return;
					}
					int num1 = this.itemIndexList.Items.IndexOf(this.method_8(dataRowArray1[0]["ItemIndex"]));
					this.itemListBox.SelectedIndex = num1;
					this.packName.Text = this.method_8(dataRow["Name"]);
					string str1 = this.method_8(dataRow["Description"]);
					str1 = str1.Replace("#", "\r\n");
					this.packDisc.Text = str1;
					this.packCurrency.SelectedIndex = this.packCurrency.Items.IndexOf(this.method_8(dataRow["Currency1"]));
					string[] strArrays = new string[] { "7", "10", "10", "74" };
					int num2 = Array.LastIndexOf<string>(strArrays, this.method_8(dataRowArray[0]["PType1"]));
					if (num2 == 2 && this.method_7(dataRowArray[0]["PType2"], -99) == 138)
					{
						num2 = 1;
					}
					this.packType.SelectedIndex = num2;
					this.enableMultiPack.Checked = false;
					this.enableMultiPack.Checked = num > 1;
					this.method_21(dataRowArray, dataRowArray1);
				}
				else
				{
					this.bundleEnable.Checked = true;
					this.method_45();
					this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabPage7"];
					this.packName.Text = this.method_8(dataRow["Name"]);
					string str2 = this.method_8(dataRow["Description"]);
					str2 = str2.Replace("#", "\r\n");
					this.packDisc.Text = str2;
					this.packCurrency.SelectedIndex = this.packCurrency.Items.IndexOf(this.method_8(dataRow["Currency1"]));
					this.bundlePrice.Text = this.method_8(dataRow["Price"]);
					string str3 = this.method_8(dataRow["ProductID"]).ToString();
					char[] chrArray = new char[] { '|' };
					string[] strArrays1 = str3.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
					this.bundleDGV.Rows.Clear();
					string[] strArrays2 = strArrays1;
					for (int i = 0; i < (int)strArrays2.Length; i++)
					{
						string str4 = strArrays2[i];
						string str5 = string.Concat("ProductID = ", this.method_8(str4));
						DataRow[] dataRowArray2 = Form1.dataSet_0.Tables["IBSProduct"].Select(str5);
						try
						{
							DataGridViewRowCollection rows = this.bundleDGV.Rows;
							object[] item = new object[] { dataRowArray2[0]["ProductID"], dataRowArray2[0]["Name"] };
							rows.Add(item);
						}
						catch (Exception exception1)
						{
							Class3.smethod_1(string.Concat("This product ID ", str4, " does not exist in the database."), "");
						}
					}
				}
			}
		}

		private void method_21(DataRow[] dataRow_0, DataRow[] dataRow_1)
		{
			Dictionary<string, Control[]> str = this.method_37();
			CheckBox[] checkBoxArray = new CheckBox[] { this.item1Enable, this.item2Enable, this.item3Enable, this.item4Enable, this.item5Enable, this.item6Enable };
			CheckBox[] checkBoxArray1 = checkBoxArray;
			bool flag = (this.method_7(dataRow_0[0]["PType1"], -99) != 10 ? false : this.method_7(dataRow_0[0]["PType2"], -99) == 138);
			bool flag1 = this.method_7(dataRow_0[0]["PType2"], -99) == 140;
			bool flag2 = flag1;
			if ((flag1 ? true : flag))
			{
				this.packUnit.SelectedIndex = this.packUnit.Items.IndexOf(dataRow_0[0]["UnitType"]);
			}
			string[] strArrays = new string[] { "Minute(s)", "Hour(s)", "Day(s)" };
			int num = Array.IndexOf<string>(strArrays, this.method_8(dataRow_0[0]["UnitType"]));
			int num1 = 1;
			for (int i = 0; i < (int)dataRow_1.Length; i++)
			{
				checkBoxArray1[i].Enabled = true;
				checkBoxArray1[i].Checked = true;
				str["Price"][i].Text = dataRow_1[i]["Price"].ToString();
				if (flag)
				{
					str["Count"][i].Text = dataRow_0[i + num1 - 1]["Count"].ToString();
					str["PName"][i].Text = dataRow_0[i + num1 - 1]["Name"].ToString();
				}
				else if (!flag2)
				{
					str["Count"][i].Text = dataRow_0[i]["Count"].ToString();
					str["PName"][i].Text = dataRow_0[i]["Name"].ToString();
				}
				else
				{
					Control item = str["Count"][i];
					int num2 = this.method_22(this.method_7(dataRow_0[i + num1 - 1]["Count"], -99), num);
					item.Text = num2.ToString();
					str["PName"][i].Text = dataRow_0[i + num1 - 1]["Name"].ToString();
				}
				((ComboBox)str["AncOp"][i]).SelectedIndex = this.method_7(dataRow_1[i]["AncOp"], -99);
				str["Dur"][i].Text = dataRow_1[i]["Durability"].ToString();
				((ComboBox)str["Lvl"][i]).SelectedIndex = ((ComboBox)str["Lvl"][i]).Items.IndexOf(dataRow_1[i]["Level"].ToString());
				((ComboBox)str["Opt"][i]).SelectedIndex = ((ComboBox)str["Opt"][i]).Items.IndexOf(dataRow_1[i]["Option"].ToString());
				((CheckBox)str["Skill"][i]).Checked = Convert.ToBoolean(this.method_7(dataRow_1[i]["Skill"], -99));
				((CheckBox)str["Luck"][i]).Checked = Convert.ToBoolean(this.method_7(dataRow_1[i]["Luck"], -99));
				int[] numArray = this.method_23(this.method_7(dataRow_1[i]["ExOpt"], -99));
				((CheckBox)str["ExcOpt1"][i]).Checked = Convert.ToBoolean(numArray[0]);
				((CheckBox)str["ExcOpt2"][i]).Checked = Convert.ToBoolean(numArray[1]);
				((CheckBox)str["ExcOpt3"][i]).Checked = Convert.ToBoolean(numArray[2]);
				((CheckBox)str["ExcOpt4"][i]).Checked = Convert.ToBoolean(numArray[3]);
				((CheckBox)str["ExcOpt5"][i]).Checked = Convert.ToBoolean(numArray[4]);
				((CheckBox)str["ExcOpt6"][i]).Checked = Convert.ToBoolean(numArray[5]);
				num1++;
			}
		}

		private int method_22(int int_5, int int_6)
		{
			int[] int5 = new int[] { int_5 / 60, int_5 / 60 / 60, int_5 / 60 / 60 / 24 };
			return int5[int_6];
		}

		private int[] method_23(int int_5)
		{
			int[] numArray = new int[6];
			int num = 32;
			for (int i = 0; i < 6; i++)
			{
				if (int_5 - num < 0)
				{
					num = num / 2;
					numArray[i] = 0;
				}
				else
				{
					int_5 = int_5 - num;
					num = num / 2;
					numArray[i] = 1;
				}
			}
			Array.Reverse(numArray);
			return numArray;
		}

		private void method_24(string string_3, string string_4, int int_5, bool bool_0 = false, int int_6 = 10)
		{
			int num;
			int num1;
			int num2;
			string string4;
			int int5;
			int num3;
			int num4;
			object[] objArray;
			object[] objArray1;
			string string3 = string_3;
			if (string3 != null)
			{
				if (string3 == "New")
				{
					if (!bool_0)
					{
						string str = string.Concat("TypeID = ", int_5);
						DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSCategory"].Select(str);
						IEnumerable<int> nums = 
							from dataRow_0 in dataRowArray.AsEnumerable<DataRow>()
							select (int)dataRow_0["CategoryID"];
						IEnumerable<int> nums1 = 
							from dataRow_0 in dataRowArray.AsEnumerable<DataRow>()
							select (int)dataRow_0["CategorySort"];
						num = 0;
						num1 = 0;
						int int51 = int_5;
						switch (int51)
						{
							case 10:
							{
								num = 31;
								num1 = 40;
								break;
							}
							case 11:
							{
								num = 41;
								num1 = 50;
								break;
							}
							case 12:
							{
								num = 51;
								num1 = 60;
								break;
							}
							default:
							{
								switch (int51)
								{
									case 20:
									{
										num = 61;
										num1 = 70;
										break;
									}
									case 21:
									{
										num = 71;
										num1 = 80;
										break;
									}
									default:
									{
										num = 81;
										num1 = 99;
										break;
									}
								}
								break;
							}
						}
						num2 = this.method_25(num, num1, nums.ToArray<int>());
						string4 = string_4;
						int5 = int_5;
						num3 = this.method_25(1, 10, nums1.ToArray<int>());
						num4 = 0;
						if ((this.method_7(num2, -99) == 0 ? true : this.method_7(num3, -99) == 0))
						{
							Class3.smethod_1((Convert.ToBoolean(num3) ? "Could not validate ID" : "Maximum of 10 tabs can only be created."), "");
						}
						else
						{
							objArray = new object[] { num2, string4, 200, 201, int5, num3, num4 };
							objArray1 = objArray;
							Form1.dataSet_0.Tables["IBSCategory"].Rows.Add(objArray1);
						}
					}
					else
					{
						DataRow[] dataRowArray1 = Form1.dataSet_0.Tables["IBSCategory"].Select("Code = 1");
						IEnumerable<int> nums2 = 
							from dataRow_0 in dataRowArray1.AsEnumerable<DataRow>()
							select (int)dataRow_0["TypeID"];
						IEnumerable<int> nums3 = 
							from dataRow_0 in dataRowArray1.AsEnumerable<DataRow>()
							select (int)dataRow_0["CategorySort"];
						num = (int_6 == 10 ? 10 : 20);
						num1 = (int_6 == 10 ? 12 : 22);
						num2 = this.method_25(num, num1, nums2.ToArray<int>());
						string4 = string_4;
						int5 = num2;
						num3 = this.method_25(1, 4, nums3.ToArray<int>());
						num4 = 1;
						if ((num2 == 0 || num3 == 0 ? true : (int)dataRowArray1.Length >= 4))
						{
							Class3.smethod_1(((int)dataRowArray1.Length < 4 ? "Could not validate ID" : "Maximum of 4 Shop can only be created."), "");
						}
						else
						{
							objArray = new object[] { num2, string4, 200, 201, int5, num3, num4 };
							objArray1 = objArray;
							Form1.dataSet_0.Tables["IBSCategory"].Rows.Add(objArray1);
						}
					}
				}
				else if (string3 == "Edit")
				{
					string str1 = string.Concat("CategoryID = ", int_5);
					DataRow[] string41 = Form1.dataSet_0.Tables["IBSCategory"].Select(str1);
					if ((string41 == null ? true : (int)string41.Length <= 0))
					{
						Class3.smethod_1("Can't find the recored!", "");
					}
					else
					{
						string41[0]["CategoryName"] = string_4;
					}
				}
				else if (string3 == "Del")
				{
					string str2 = string.Concat("CategoryID = ", int_5);
					string str3 = string.Concat("TypeID = ", int_5);
					DataRow[] dataRowArray2 = Form1.dataSet_0.Tables["IBSCategory"].Select(str2);
					DataRow[] dataRowArray3 = Form1.dataSet_0.Tables["IBSCategory"].Select(str3);
					if ((dataRowArray2 == null ? true : (int)dataRowArray2.Length <= 0))
					{
						Class3.smethod_1("Can't find the recored!", "");
					}
					else if (!bool_0)
					{
						Form1.dataSet_0.Tables["IBSCategory"].Rows.Remove(dataRowArray2[0]);
					}
					else
					{
						for (int i = (int)dataRowArray3.Length - 1; i >= 0; i--)
						{
							Form1.dataSet_0.Tables["IBSCategory"].Rows.Remove(dataRowArray3[i]);
						}
					}
				}
			}
		}

		private int method_25(int int_5, int int_6, int[] int_7)
		{
			bool flag;
			int int5 = 0;
			do
			{
				int5 = int_5;
				int_5++;
				flag = (!int_7.Contains<int>(int5) ? false : int_5 <= int_6);
			}
			while (flag);
			if (int_7.Contains<int>(int5))
			{
				int5 = 0;
			}
			return int5;
		}

		private void method_26(int int_5, bool bool_0 = false, int int_6 = 0)
		{
			int i;
			object[] objArray;
			if (!this.method_34())
			{
				this.method_16("Invalid data!", "error");
			}
			else
			{
				int num = (this.item1Enable.Checked ? 1 : 0) + (this.item2Enable.Checked ? 1 : 0) + (this.item3Enable.Checked ? 1 : 0) + (this.item4Enable.Checked ? 1 : 0) + (this.item5Enable.Checked ? 1 : 0) + (this.item6Enable.Checked ? 1 : 0);
				string text = this.packName.Text;
				string str = this.item1Price.Text;
				EnumerableRowCollection<int> nums = Form1.dataSet_0.Tables["IBSPackage"].AsEnumerable().Select<DataRow, int>((DataRow dataRow_0) => (int)dataRow_0["PackageID"]);
				int num1 = (bool_0 ? int_6 : this.method_25(100, 999, nums.ToArray<int>()));
				int num2 = 1000 + (num1 - 100) * 10;
				string str1 = this.method_29(num, num2);
				int selectedIndex = this.itemGroup.SelectedIndex;
				int num3 = this.method_7(this.itemIndexList.SelectedItem, -99);
				string str2 = this.packDisc.Text.Replace("\n", "#");
				str2 = str2.Replace("\r", " ");
				string str3 = str2.Replace("\t", " ");
				int num4 = 512 * selectedIndex + num3;
				string str4 = string.Concat("// ", text);
				int selectedIndex1 = this.packType.SelectedIndex;
				int selectedIndex2 = this.packCurrency.SelectedIndex;
				string str5 = string.Concat("CategoryID = ", int_5);
				DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSPackage"].Select(str5);
				IEnumerable<int> nums1 = 
					from dataRow_0 in dataRowArray.AsEnumerable<DataRow>()
					select (int)dataRow_0["PackageSort"];
				int num5 = this.method_25(1, 99, nums1.ToArray<int>());
				object selectedItem = this.packCurrency.SelectedItem;
				object obj = selectedItem;
				int[] numArray = new int[] { 2, 3, 5 };
				int[] numArray1 = new int[] { 0, 0, 1 };
				int[] numArray2 = numArray1;
				numArray1 = new int[] { 508, 509, 0 };
				int[] numArray3 = numArray1;
				numArray1 = new int[] { 0, 1, 2 };
				int[] numArray4 = numArray1;
				numArray1 = new int[] { 1, 0, 0, 1 };
				int[] numArray5 = numArray1;
				object[] int5 = new object[] { int_5, num5, num1, text, 170, str, str3, "", 182, 185, 0, 0, 177, 1, selectedItem, obj, 181, 200, 0, string.Concat(num2, "|"), num4, numArray[selectedIndex2], num, str1, numArray2[selectedIndex2], numArray3[selectedIndex2], 669 };
				object[] objArray1 = int5;
				int5 = new object[] { int_5, num1, selectedIndex, num3, numArray4[selectedIndex2], str, numArray5[selectedIndex1], 0, 1, num2, str4 };
				object[] objArray2 = int5;
				object[][] objArray3 = this.method_30("IBSProduct", num2, num4, selectedIndex1, num, selectedIndex, num3);
				object[][] objArray4 = this.method_30("CashShopProduct", num2, num4, selectedIndex1, num, selectedIndex, num3);
				Form1.dataSet_0.Tables["IBSPackage"].Rows.Add(objArray1);
				object[][] objArray5 = objArray3;
				for (i = 0; i < (int)objArray5.Length; i++)
				{
					objArray = objArray5[i];
					Form1.dataSet_0.Tables["IBSProduct"].Rows.Add(objArray);
				}
				Form1.dataSet_0.Tables["CashShopPackage"].Rows.Add(objArray2);
				objArray5 = objArray4;
				for (i = 0; i < (int)objArray5.Length; i++)
				{
					objArray = objArray5[i];
					Form1.dataSet_0.Tables["CashShopProduct"].Rows.Add(objArray);
				}
				this.method_16((bool_0 ? "Package Updated successfully." : "New Package added successfully."), "success");
			}
		}

		private void method_27(bool bool_0 = false, int int_5 = 0)
		{
			object[] objArray;
			object[] objArray1;
			object[] objArray2;
			if (!this.method_34())
			{
				this.method_16("Invalid data!", "error");
			}
			else
			{
				IEnumerable<int> nums = Form1.dataSet_0.Tables["IBSProduct"].AsEnumerable().Where<DataRow>((DataRow dataRow_0) => (int)dataRow_0["ProductID"] >= 10000).Select<DataRow, int>((DataRow dataRow_0) => (int)dataRow_0["ProductID"]).Distinct<int>();
				int num = (bool_0 ? int_5 : this.method_25(10000, 11000, nums.ToArray<int>()));
				int selectedIndex = this.itemGroup.SelectedIndex;
				int num1 = this.method_7(this.itemIndexList.SelectedItem, -99);
				int num2 = 512 * selectedIndex + num1;
				int selectedIndex1 = this.packType.SelectedIndex;
				string text = this.newPrPname.Text;
				string[] strArrays = new string[] { "Quantity", "Duration", "Duration", "Rate" };
				string str = this.newPrPrice.Text;
				int num3 = 0;
				if (selectedIndex1 == 1)
				{
					num3 = this.method_7(this.newPrCount.Text, -99);
				}
				else if (selectedIndex1 != 2)
				{
					num3 = this.method_7(this.newPrCount.Text, -99);
				}
				else
				{
					int[] numArray = new int[] { 60, 3600, 86400 };
					num3 = this.method_7(this.newPrCount.Text, -99) * numArray[this.packUnit.SelectedIndex];
				}
				string str1 = this.packUnit.SelectedItem.ToString();
				int num4 = num;
				int[] numArray1 = new int[] { 7, 10, 10, 74 };
				int[] numArray2 = new int[] { 138, 138, 140, 138 };
				int[] numArray3 = new int[] { 680, 680, 386, 304 };
				if (selectedIndex1 == 1)
				{
					objArray = new object[] { num, text, strArrays[selectedIndex1], num3, str1, str, num4, 142, 145, 1, 144, 673, 518, num2, numArray1[selectedIndex1], numArray2[selectedIndex1], numArray3[selectedIndex1] };
					objArray1 = objArray;
					Form1.dataSet_0.Tables["IBSProduct"].Rows.Add(objArray1);
					objArray = new object[] { num, text, strArrays[0], 1, " ", str, num4, 142, 145, 1, 144, 673, 518, num2, 9, 140, 174 };
					objArray2 = objArray;
					Form1.dataSet_0.Tables["IBSProduct"].Rows.Add(objArray2);
				}
				if (selectedIndex1 != 2)
				{
					objArray = new object[] { num, text, strArrays[selectedIndex1], num3, str1, str, num4, 142, 145, 1, 144, 673, 518, num2, numArray1[selectedIndex1], numArray2[selectedIndex1], numArray3[selectedIndex1] };
					objArray1 = objArray;
					Form1.dataSet_0.Tables["IBSProduct"].Rows.Add(objArray1);
				}
				else
				{
					objArray = new object[] { num, text, strArrays[selectedIndex1], num3, str1, str, num4, 142, 145, 1, 144, 673, 518, num2, numArray1[selectedIndex1], numArray2[selectedIndex1], numArray3[selectedIndex1] };
					objArray1 = objArray;
					Form1.dataSet_0.Tables["IBSProduct"].Rows.Add(objArray1);
					objArray = new object[] { num, text, "???-??????", 365, "Day(s)", str, num4, 142, 145, 1, 144, 673, 518, num2, 37, 140, 151 };
					objArray2 = objArray;
					Form1.dataSet_0.Tables["IBSProduct"].Rows.Add(objArray2);
				}
				string str2 = string.Concat("// ", text);
				int num5 = this.method_7(this.newPrDur.Text, -99);
				int[] numArray4 = new int[] { 1, 60, 1440 };
				int[] numArray5 = new int[] { 0, Convert.ToInt32(this.newPrCount.Text) * numArray4[this.packUnit.SelectedIndex], Convert.ToInt32(this.newPrCount.Text) * numArray4[this.packUnit.SelectedIndex], 0 };
				int[] numArray6 = numArray5;
				int num6 = this.method_7(this.newPrLvl.SelectedIndex, 0);
				int num7 = (this.newPrSkill.Checked ? 1 : 0);
				int num8 = (this.newPrLuck.Checked ? 1 : 0);
				int num9 = this.method_7(this.newPrOpt.SelectedIndex, 0);
				int num10 = (this.newPrOpt1.Checked ? 1 : 0) + (this.newPrOpt2.Checked ? 2 : 0) + (this.newPrOpt3.Checked ? 4 : 0) + (this.newPrOpt4.Checked ? 8 : 0) + (this.newPrOpt5.Checked ? 16 : 0) + (this.newPrOpt6.Checked ? 32 : 0);
				int num11 = (this.newPrAncient.SelectedIndex < 0 ? 0 : this.newPrAncient.SelectedIndex);
				objArray = new object[] { num, num4, selectedIndex, num1, str, num5, numArray6[selectedIndex1], 80, num6, num7, num8, num9, num10, num11, str2 };
				object[] objArray3 = objArray;
				Form1.dataSet_0.Tables["CashShopProduct"].Rows.Add(objArray3);
				string str3 = (bool_0 ? "Product Updated successfully." : "New Product added successfully.");
				Class3.smethod_1(str3, "");
				this.method_16(str3, "success");
			}
		}

		private void method_28(int int_5, bool bool_0 = false, int int_6 = 0)
		{
			if (!this.method_34())
			{
				this.method_16("Invalid data!", "error");
			}
			else
			{
				int count = this.bundleDGV.Rows.Count;
				string text = this.packName.Text;
				string str = this.bundlePrice.Text;
				EnumerableRowCollection<int> nums = Form1.dataSet_0.Tables["IBSPackage"].AsEnumerable().Select<DataRow, int>((DataRow dataRow_0) => (int)dataRow_0["PackageID"]);
				int num = (bool_0 ? int_6 : this.method_25(100, 999, nums.ToArray<int>()));
				string empty = string.Empty;
				for (int i = 0; i < count; i++)
				{
					empty = string.Concat(empty, this.bundleDGV.Rows[i].Cells[0].Value, "|");
				}
				string str1 = "";
				int selectedIndex = this.itemGroup.SelectedIndex;
				int num1 = this.method_7(this.itemIndexList.SelectedItem, -99);
				string str2 = this.packDisc.Text.Replace("\n", "#");
				str2 = str2.Replace("\r", " ");
				string str3 = str2.Replace("\t", " ");
				int num2 = 512 * selectedIndex + num1;
				string str4 = string.Concat("// ", text);
				int selectedIndex1 = this.packType.SelectedIndex;
				int selectedIndex2 = this.packCurrency.SelectedIndex;
				string str5 = string.Concat("CategoryID = ", int_5);
				DataRow[] dataRowArray = Form1.dataSet_0.Tables["IBSPackage"].Select(str5);
				IEnumerable<int> nums1 = 
					from dataRow_0 in dataRowArray.AsEnumerable<DataRow>()
					select (int)dataRow_0["PackageSort"];
				int num3 = this.method_25(1, 99, nums1.ToArray<int>());
				object selectedItem = this.packCurrency.SelectedItem;
				object obj = selectedItem;
				int[] numArray = new int[] { 2, 3, 5 };
				int[] numArray1 = new int[] { 0, 0, 1 };
				int[] numArray2 = numArray1;
				numArray1 = new int[] { 508, 509, 0 };
				int[] numArray3 = numArray1;
				numArray1 = new int[] { 0, 1, 2 };
				int[] numArray4 = numArray1;
				numArray1 = new int[] { 1, 0, 0, 1 };
				int[] numArray5 = numArray1;
				object[] int5 = new object[] { int_5, num3, num, text, 170, str, str3, "", 182, 185, 0, 0, 177, 1, selectedItem, obj, 181, 200, 0, empty, num2, numArray[selectedIndex2], 1, str1, numArray2[selectedIndex2], numArray3[selectedIndex2], 669 };
				object[] objArray = int5;
				int5 = new object[] { int_5, num, selectedIndex, num1, numArray4[selectedIndex2], str, numArray5[selectedIndex1], 0, count, empty, str4 };
				object[] objArray1 = int5;
				Form1.dataSet_0.Tables["IBSPackage"].Rows.Add(objArray);
				Form1.dataSet_0.Tables["CashShopPackage"].Rows.Add(objArray1);
				this.method_16("New Bundle Package added successfully.", "success");
			}
		}

		private string method_29(int int_5, int int_6)
		{
			string str = string.Concat(int_6.ToString(), "|");
			for (int i = 1; i < int_5; i++)
			{
				int int6 = int_6 + i;
				str = string.Concat(str, int6.ToString(), "|");
			}
			return str;
		}

		private void method_3(bool bool_0 = false)
		{
			if (!bool_0)
			{
				this.newTedit.BackColor = Color.FromArgb(24, 24, 24);
				this.newTedit.BorderStyle = BorderStyle.None;
				this.newTedit.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
				this.newTedit.ForeColor = Color.OrangeRed;
				this.newTedit.Location = new Point(3, 392);
				this.newTedit.Name = "newTedit";
				this.newTedit.Size = new System.Drawing.Size(90, 14);
				this.newTedit.Text = "";
				this.newTedit.Visible = false;
				this.newTedit.TextAlign = HorizontalAlignment.Center;
				this.subCutPanel.Controls.Add(this.newTedit);
			}
			else
			{
				this.newMedit.BackColor = Color.FromArgb(24, 24, 24);
				this.newMedit.BorderStyle = BorderStyle.None;
				this.newMedit.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
				this.newMedit.ForeColor = Color.OrangeRed;
				this.newMedit.Location = new Point(238, 7);
				this.newMedit.Name = "newMedit";
				this.newMedit.Size = new System.Drawing.Size(84, 14);
				this.newMedit.TabIndex = 1;
				this.newMedit.Text = "";
				this.newMedit.Visible = false;
				this.newMedit.TextAlign = HorizontalAlignment.Center;
				this.mainCutPanel.Controls.Add(this.newMedit);
			}
		}

		private object[][] method_30(string string_3, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10)
		{
			int i;
			TextBox[] textBoxArray;
			TextBox[] textBoxArray1;
			TextBox[] textBoxArray2;
			TextBox[] textBoxArray3;
			string text;
			int int5;
			object[] objArray;
			object[][] objArray1 = new object[((int_7 == 1 || int_7 == 2) && string_3 == "IBSProduct" ? int_8 + int_8 : int_8)][];
			string string3 = string_3;
			if (string3 != null)
			{
				if (string3 == "IBSProduct")
				{
					int num = 1;
					for (i = 0; i < int_8; i++)
					{
						textBoxArray = new TextBox[] { this.item1Name, this.item2Name, this.item3Name, this.item4Name, this.item5Name, this.item6Name };
						textBoxArray1 = textBoxArray;
						textBoxArray = new TextBox[] { this.item1Price, this.item2Price, this.item3Price, this.item4Price, this.item5Price, this.item6Price };
						textBoxArray2 = textBoxArray;
						textBoxArray = new TextBox[] { this.item1Count, this.item2Count, this.item3Count, this.item4Count, this.item5Count, this.item6Count };
						textBoxArray3 = textBoxArray;
						string str = textBoxArray1[i].Text;
						string[] strArrays = new string[] { "Quantity", "Duration", "Duration", "Rate" };
						text = textBoxArray2[i].Text;
						int num1 = 0;
						if (int_7 == 1)
						{
							num1 = this.method_7(textBoxArray3[i].Text, -99);
						}
						else if (int_7 != 2)
						{
							num1 = this.method_7(textBoxArray3[i].Text, -99);
						}
						else
						{
							int[] numArray = new int[] { 60, 3600, 86400 };
							num1 = this.method_7(textBoxArray3[i].Text, -99) * numArray[this.packUnit.SelectedIndex];
						}
						string str1 = this.packUnit.SelectedItem.ToString();
						int5 = int_5 + i;
						int[] numArray1 = new int[] { 7, 10, 10, 74 };
						int[] numArray2 = new int[] { 138, 138, 140, 138 };
						int[] numArray3 = new int[] { 680, 680, 386, 304 };
						if (int_7 == 1)
						{
							objArray = new object[] { int_5, str, strArrays[int_7], num1, str1, text, int5, 142, 145, 1, 144, 673, 518, int_6, numArray1[int_7], numArray2[int_7], numArray3[int_7] };
							objArray1[i + num - 1] = objArray;
							objArray = new object[] { int_5, str, strArrays[0], 1, " ", text, int5, 142, 146, 9, 144, 673, 518, int_6, 37, 140, 151 };
							objArray1[i + num] = objArray;
						}
						else if (int_7 != 2)
						{
							objArray = new object[] { int_5, str, strArrays[int_7], num1, str1, text, int5, 142, 145, 1, 144, 673, 518, int_6, numArray1[int_7], numArray2[int_7], numArray3[int_7] };
							objArray1[i] = objArray;
						}
						else
						{
							objArray = new object[] { int_5, str, strArrays[int_7], num1, str1, text, int5, 142, 145, 1, 144, 673, 518, int_6, numArray1[int_7], numArray2[int_7], numArray3[int_7] };
							objArray1[i + num - 1] = objArray;
							objArray = new object[] { int_5, str, "???-??????", 365, "Day(s)", text, int5, 142, 146, 9, 144, 673, 518, int_6, 37, 140, 151 };
							objArray1[i + num] = objArray;
						}
						num++;
					}
				}
				else if (string3 == "CashShopProduct")
				{
					for (i = 0; i < int_8; i++)
					{
						textBoxArray = new TextBox[] { this.item1Price, this.item2Price, this.item3Price, this.item4Price, this.item5Price, this.item6Price };
						textBoxArray2 = textBoxArray;
						textBoxArray = new TextBox[] { this.item1Name, this.item2Name, this.item3Name, this.item4Name, this.item5Name, this.item6Name };
						textBoxArray1 = textBoxArray;
						textBoxArray = new TextBox[] { this.item1Dur, this.item2Dur, this.item3Dur, this.item4Dur, this.item5Dur, this.item6Dur };
						TextBox[] textBoxArray4 = textBoxArray;
						textBoxArray = new TextBox[] { this.item1Count, this.item2Count, this.item3Count, this.item4Count, this.item5Count, this.item6Count };
						textBoxArray3 = textBoxArray;
						ComboBox[] comboBoxArray = new ComboBox[] { this.item1Lvl, this.item2Lvl, this.item3Lvl, this.item4Lvl, this.item5Lvl, this.item6Lvl };
						ComboBox[] comboBoxArray1 = comboBoxArray;
						comboBoxArray = new ComboBox[] { this.item1Opt, this.item2Opt, this.item3Opt, this.item4Opt, this.item5Opt, this.item6Opt };
						ComboBox[] comboBoxArray2 = comboBoxArray;
						CheckBox[] checkBoxArray = new CheckBox[] { this.item1Skill, this.item2Skill, this.item3Skill, this.item4Skill, this.item5Skill, this.item6Skill };
						CheckBox[] checkBoxArray1 = checkBoxArray;
						checkBoxArray = new CheckBox[] { this.item1Luck, this.item2Luck, this.item3Luck, this.item4Luck, this.item5Luck, this.item6Luck };
						CheckBox[] checkBoxArray2 = checkBoxArray;
						comboBoxArray = new ComboBox[] { this.item1Ancient, this.item2Ancient, this.item3Ancient, this.item4Ancient, this.item5Ancient, this.item6Ancient };
						ComboBox[] comboBoxArray3 = comboBoxArray;
						checkBoxArray = new CheckBox[] { this.item1ExcOpt1, this.item2ExcOpt1, this.item3ExcOpt1, this.item4ExcOpt1, this.item5ExcOpt1, this.item6ExcOpt1 };
						CheckBox[] checkBoxArray3 = checkBoxArray;
						checkBoxArray = new CheckBox[] { this.item1ExcOpt2, this.item2ExcOpt2, this.item3ExcOpt2, this.item4ExcOpt2, this.item5ExcOpt2, this.item6ExcOpt2 };
						CheckBox[] checkBoxArray4 = checkBoxArray;
						checkBoxArray = new CheckBox[] { this.item1ExcOpt3, this.item2ExcOpt3, this.item3ExcOpt3, this.item4ExcOpt3, this.item5ExcOpt3, this.item6ExcOpt3 };
						CheckBox[] checkBoxArray5 = checkBoxArray;
						checkBoxArray = new CheckBox[] { this.item1ExcOpt4, this.item2ExcOpt4, this.item3ExcOpt4, this.item4ExcOpt4, this.item5ExcOpt4, this.item6ExcOpt4 };
						CheckBox[] checkBoxArray6 = checkBoxArray;
						checkBoxArray = new CheckBox[] { this.item1ExcOpt5, this.item2ExcOpt5, this.item3ExcOpt5, this.item4ExcOpt5, this.item5ExcOpt5, this.item6ExcOpt5 };
						CheckBox[] checkBoxArray7 = checkBoxArray;
						checkBoxArray = new CheckBox[] { this.item1ExcOpt6, this.item2ExcOpt6, this.item3ExcOpt6, this.item4ExcOpt6, this.item5ExcOpt6, this.item6ExcOpt6 };
						CheckBox[] checkBoxArray8 = checkBoxArray;
						string str2 = string.Concat("// ", textBoxArray1[i].Text);
						int5 = int_5 + i;
						text = textBoxArray2[i].Text;
						int num2 = this.method_7(textBoxArray4[i].Text, -99);
						int[] numArray4 = new int[] { 1, 60, 1440 };
						int[] num3 = new int[] { 0, Convert.ToInt32(textBoxArray3[i].Text) * numArray4[this.packUnit.SelectedIndex], Convert.ToInt32(textBoxArray3[i].Text) * numArray4[this.packUnit.SelectedIndex], 0 };
						int[] numArray5 = num3;
						int num4 = this.method_7(comboBoxArray1[i].SelectedIndex, 0);
						int num5 = (checkBoxArray1[i].Checked ? 1 : 0);
						int num6 = (checkBoxArray2[i].Checked ? 1 : 0);
						int num7 = this.method_7(comboBoxArray2[1].SelectedIndex, 0);
						int num8 = (checkBoxArray3[i].Checked ? 1 : 0) + (checkBoxArray4[i].Checked ? 2 : 0) + (checkBoxArray5[i].Checked ? 4 : 0) + (checkBoxArray6[i].Checked ? 8 : 0) + (checkBoxArray7[i].Checked ? 16 : 0) + (checkBoxArray8[i].Checked ? 32 : 0);
						int num9 = this.method_7(comboBoxArray3[i].SelectedIndex, 0);
						objArray = new object[] { int_5, int5, int_9, int_10, text, num2, numArray5[int_7], 80, num4, num5, num6, num7, num8, num9, str2 };
						objArray1[i] = objArray;
					}
				}
			}
			return objArray1;
		}

		private string method_31()
		{
			int num;
			bool[] selectedIndex = new bool[] { this.itemListBox.SelectedIndex > -1, false, false, false, false, false };
			selectedIndex[1] = (this.packName.Text == "Name" ? false : this.packName.Text != "");
			selectedIndex[2] = Convert.ToInt32(this.packType.SelectedIndex) >= 0;
			selectedIndex[3] = Convert.ToInt32(this.packCurrency.SelectedIndex) >= 0;
			selectedIndex[4] = int.TryParse(this.packCount.Text, out num);
			bool flag = this.method_35() == "bundle";
			selectedIndex[5] = (flag ? true : Convert.ToInt32(this.packUnit.SelectedIndex) >= 0);
			string[] strArrays = new string[] { "No item selected.", "Invalid Item Name.", "Invalid Item Pack Type.", "Invalid Item Currency", "Invalid Item Count", "Select Count Unit" };
			string[] strArrays1 = strArrays;
			int num1 = 0;
			string empty = string.Empty;
			bool[] flagArray = selectedIndex;
			for (int i = 0; i < (int)flagArray.Length; i++)
			{
				if (!flagArray[i])
				{
					string str = empty;
					empty = string.Concat(str, "* ", strArrays1[num1], "\n");
				}
				num1++;
			}
			if (this.method_35() == "pack")
			{
				empty = string.Concat(empty, this.method_38());
			}
			if (this.method_35() == "bundle")
			{
				empty = string.Concat(empty, this.method_32());
			}
			if (this.method_35() == "product")
			{
				empty = string.Concat(empty, this.method_33());
			}
			return empty;
		}

		private string method_32()
		{
			return string.Concat((this.bundleDGV.Rows.Count > 0 ? string.Empty : "* You don't add any product to the bundle."), (Class3.smethod_0(this.bundlePrice.Text) > 0 ? string.Empty : "* Please check your bundle price."));
		}

		private string method_33()
		{
			string empty = string.Empty;
			this.packDisc.Text = " ";
			int num = 0;
			return string.Concat(string.Concat(string.Concat(string.Concat(empty, (!(this.newPrPname.Text != "Name") || !(this.newPrPname.Text != "") ? "* Invalid Item Name \n" : string.Empty)), (!int.TryParse(this.newPrPrice.Text, out num) || num <= 0 ? "* Check your Price value \n" : string.Empty)), (!int.TryParse(this.newPrCount.Text, out num) || num < 0 ? "* Invalid Count value \n" : string.Empty)), (this.method_7(this.newPrDur.Text, 0) <= this.method_7(Class12.smethod_1(false)["MaxDurability"], -99) ? string.Empty : "* Invalid Durability value \n"));
		}

		private bool method_34()
		{
			bool flag = false;
			string str = this.method_31();
			if ((str != "" ? false : !(str != string.Empty)))
			{
				flag = true;
			}
			else
			{
				flag = false;
				Class3.smethod_1(str, "error");
			}
			return flag;
		}

		private string method_35()
		{
			int num = (this.tabControl1.SelectedTab == this.tabControl1.TabPages["tabPage8"] ? 1 : 0) + (this.bundleEnable.Checked ? 1 : 0);
			return (new string[] { "pack", "bundle", "product" })[num];
		}

		private void method_36(bool bool_0, int int_5)
		{
			foreach (KeyValuePair<string, Control[]> bool0 in this.method_37())
			{
				if (bool0.Key == "Main")
				{
					continue;
				}
				bool0.Value[int_5].Enabled = bool_0;
			}
		}

		private Dictionary<string, Control[]> method_37()
		{
			Dictionary<string, Control[]> strs = new Dictionary<string, Control[]>();
			Control[] controlArray = new Control[] { this.packName, this.packDisc, this.packType, this.packCount, this.packCurrency, this.packUnit };
			strs.Add("Main", controlArray);
			controlArray = new Control[] { this.item1Price, this.item2Price, this.item3Price, this.item4Price, this.item5Price, this.item6Price, this.newPrPrice, this.bundlePrice };
			strs.Add("Price", controlArray);
			controlArray = new Control[] { this.item1Name, this.item2Name, this.item3Name, this.item4Name, this.item5Name, this.item6Name, this.newPrPname };
			strs.Add("PName", controlArray);
			controlArray = new Control[] { this.item1Count, this.item2Count, this.item3Count, this.item4Count, this.item5Count, this.item6Count, this.newPrCount };
			strs.Add("Count", controlArray);
			controlArray = new Control[] { this.item1Dur, this.item2Dur, this.item3Dur, this.item4Dur, this.item5Dur, this.item6Dur, this.newPrDur };
			strs.Add("Dur", controlArray);
			controlArray = new Control[] { this.item1Lvl, this.item2Lvl, this.item3Lvl, this.item4Lvl, this.item5Lvl, this.item6Lvl, this.newPrLvl };
			strs.Add("Lvl", controlArray);
			controlArray = new Control[] { this.item1Opt, this.item2Opt, this.item3Opt, this.item4Opt, this.item5Opt, this.item6Opt, this.newPrOpt };
			strs.Add("Opt", controlArray);
			controlArray = new Control[] { this.item1Skill, this.item2Skill, this.item3Skill, this.item4Skill, this.item5Skill, this.item6Skill, this.newPrSkill };
			strs.Add("Skill", controlArray);
			controlArray = new Control[] { this.item1Luck, this.item2Luck, this.item3Luck, this.item4Luck, this.item5Luck, this.item6Luck, this.newPrLuck };
			strs.Add("Luck", controlArray);
			controlArray = new Control[] { this.item1Sckt, this.item2Sckt, this.item3Sckt, this.item4Sckt, this.item5Sckt, this.item6Sckt, this.newPrSckt };
			strs.Add("Sckt", controlArray);
			controlArray = new Control[] { this.item1Ancient, this.item2Ancient, this.item3Ancient, this.item4Ancient, this.item5Ancient, this.item6Ancient };
			strs.Add("AncOp", controlArray);
			controlArray = new Control[] { this.item1ExcOpt1, this.item2ExcOpt1, this.item3ExcOpt1, this.item4ExcOpt1, this.item5ExcOpt1, this.item6ExcOpt1, this.newPrOpt1 };
			strs.Add("ExcOpt1", controlArray);
			controlArray = new Control[] { this.item1ExcOpt2, this.item2ExcOpt2, this.item3ExcOpt2, this.item4ExcOpt2, this.item5ExcOpt2, this.item6ExcOpt2, this.newPrOpt2 };
			strs.Add("ExcOpt2", controlArray);
			controlArray = new Control[] { this.item1ExcOpt3, this.item2ExcOpt3, this.item3ExcOpt3, this.item4ExcOpt3, this.item5ExcOpt3, this.item6ExcOpt3, this.newPrOpt3 };
			strs.Add("ExcOpt3", controlArray);
			controlArray = new Control[] { this.item1ExcOpt4, this.item2ExcOpt4, this.item3ExcOpt4, this.item4ExcOpt4, this.item5ExcOpt4, this.item6ExcOpt4, this.newPrOpt4 };
			strs.Add("ExcOpt4", controlArray);
			controlArray = new Control[] { this.item1ExcOpt5, this.item2ExcOpt5, this.item3ExcOpt5, this.item4ExcOpt5, this.item5ExcOpt5, this.item6ExcOpt5, this.newPrOpt5 };
			strs.Add("ExcOpt5", controlArray);
			controlArray = new Control[] { this.item1ExcOpt6, this.item2ExcOpt6, this.item3ExcOpt6, this.item4ExcOpt6, this.item5ExcOpt6, this.item6ExcOpt6, this.newPrOpt6 };
			strs.Add("ExcOpt6", controlArray);
			controlArray = new Control[] { this.item1ExcOptType, this.item2ExcOptType, this.item3ExcOptType, this.item4ExcOptType, this.item5ExcOptType, this.item6ExcOptType, this.newP7rExcOptType };
			strs.Add("ExcOptType", controlArray);
			Dictionary<string, Control[]> strs1 = strs;
			if (Class12.smethod_0("AncientItem") == "1")
			{
				controlArray = new Control[] { this.item1Ancient, this.item2Ancient, this.item3Ancient, this.item4Ancient, this.item5Ancient, this.item6Ancient };
				strs1["AncOp"] = controlArray;
			}
			return strs1;
		}

		private string method_38()
		{
			int num;
			string str;
			string str1;
			string str2;
			string str3;
			string empty = string.Empty;
			Dictionary<string, Control[]> strs = this.method_37();
			CheckBox[] checkBoxArray = new CheckBox[] { this.item1Enable, this.item2Enable, this.item3Enable, this.item4Enable, this.item5Enable, this.item6Enable };
			CheckBox[] checkBoxArray1 = checkBoxArray;
			int num1 = 0;
			for (int i = 0; i < (int)checkBoxArray1.Length; i++)
			{
				if (checkBoxArray1[i].Checked)
				{
					string str4 = empty;
					if (!(strs["PName"][i].Text != "Name") || !(strs["PName"][i].Text != ""))
					{
						num = i + 1;
						str = string.Concat("[Pack", num.ToString(), "]Invalid Item Name \n");
					}
					else
					{
						str = "";
					}
					empty = string.Concat(str4, str);
					string str5 = empty;
					if (!int.TryParse(strs["Price"][i].Text, out num1) || num1 <= 0)
					{
						num = i + 1;
						str1 = string.Concat("[Pack", num.ToString(), "]Check your Price value \n");
					}
					else
					{
						str1 = "";
					}
					empty = string.Concat(str5, str1);
					string str6 = empty;
					if (!int.TryParse(strs["Count"][i].Text, out num1) || num1 < 0)
					{
						num = i + 1;
						str2 = string.Concat("[Pack", num.ToString(), "]Invalid Count value \n");
					}
					else
					{
						str2 = "";
					}
					empty = string.Concat(str6, str2);
					string str7 = empty;
					if (this.method_7(strs["Dur"][i].Text, 0) <= this.method_7(Class12.smethod_1(false)["MaxDurability"], -99))
					{
						str3 = "";
					}
					else
					{
						num = i + 1;
						str3 = string.Concat("[Pack", num.ToString(), "]Invalid Durability value \n");
					}
					empty = string.Concat(str7, str3);
				}
			}
			return empty;
		}

		private void method_39(object sender, EventArgs e)
		{
			string str = ((Control)sender).Tag.ToString();
			this.statusicon.Image = Class9.smethod_12();
			this.statusinfo.Text = str;
			this.statusicon.Visible = true;
			this.statusinfo.Visible = true;
		}

		private void method_4(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Middle)
			{
				Control control = (Control)sender;
				TextBox point = this.newTedit;
				Point location = control.Location;
				int x = location.X + 2;
				location = control.Location;
				point.Location = new Point(x, location.Y + 6);
				this.newTedit.Text = control.Text;
				this.newTedit.Visible = true;
				this.newTedit.BackColor = control.BackColor;
				this.newTedit.BringToFront();
				this.newTedit.Focus();
				this.newTedit.Tag = control.Tag;
			}
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				string str = ((Button)sender).Tag.ToString();
				this.method_10(Convert.ToInt32(str));
			}
		}

		private void method_40(object sender, EventArgs e)
		{
			this.statusinfo.Visible = false;
			this.statusicon.Visible = false;
		}

		private bool method_41(string string_3, string string_4, int int_5)
		{
			int[] numArray;
			int i;
			int num;
			int num1;
			int num2;
			DataRow[] int5 = Form1.dataSet_0.Tables["IBSCategory"].Select(string_4);
			IEnumerable<int> nums = 
				from dataRow_0 in int5.AsEnumerable<DataRow>()
				select (int)dataRow_0["CategorySort"];
			bool flag = false;
			if ((int)nums.ToArray<int>().Length > 1)
			{
				int[] array = nums.ToArray<int>();
				string string3 = string_3;
				if (string3 != null)
				{
					if (string3 == "up")
					{
						int[] array1 = nums.ToArray<int>();
						Array.Sort<int>(array1);
						int num3 = 0;
						numArray = array1;
						for (i = 0; i < (int)numArray.Length; i++)
						{
							num = numArray[i];
							if (num < int_5)
							{
								num3 = num;
							}
						}
						if (num3 > 0)
						{
							num1 = Array.IndexOf<int>(array, num3);
							num2 = Array.IndexOf<int>(array, int_5);
							int5[num1]["CategorySort"] = int_5;
							int5[num2]["CategorySort"] = num3;
							flag = true;
						}
					}
					else if (string3 == "down")
					{
						int[] numArray1 = nums.ToArray<int>();
						Array.Reverse(numArray1);
						int num4 = 0;
						numArray = numArray1;
						for (i = 0; i < (int)numArray.Length; i++)
						{
							num = numArray[i];
							if (num > int_5)
							{
								num4 = num;
							}
						}
						if (num4 > 0)
						{
							num1 = Array.IndexOf<int>(array, num4);
							num2 = Array.IndexOf<int>(array, int_5);
							int5[num1]["CategorySort"] = int_5;
							int5[num2]["CategorySort"] = num4;
							flag = true;
						}
					}
				}
			}
			return flag;
		}

		private bool method_42(string string_3, string string_4, int int_5)
		{
			int[] numArray;
			int i;
			int num;
			int num1;
			int num2;
			DataRow[] int5 = Form1.dataSet_0.Tables["IBSPackage"].Select(string_4);
			IEnumerable<int> nums = 
				from dataRow_0 in int5.AsEnumerable<DataRow>()
				select (int)dataRow_0["PackageSort"];
			bool flag = false;
			if ((int)nums.ToArray<int>().Length > 1)
			{
				int[] array = nums.ToArray<int>();
				string string3 = string_3;
				if (string3 != null)
				{
					if (string3 == "up")
					{
						int[] array1 = nums.ToArray<int>();
						Array.Sort<int>(array1);
						int num3 = 0;
						numArray = array1;
						for (i = 0; i < (int)numArray.Length; i++)
						{
							num = numArray[i];
							if (num < int_5)
							{
								num3 = num;
							}
						}
						if (num3 > 0)
						{
							num1 = Array.IndexOf<int>(array, num3);
							num2 = Array.IndexOf<int>(array, int_5);
							int5[num1]["PackageSort"] = int_5;
							int5[num2]["PackageSort"] = num3;
							flag = true;
						}
					}
					else if (string3 == "down")
					{
						int[] numArray1 = nums.ToArray<int>();
						Array.Reverse(numArray1);
						int num4 = 0;
						numArray = numArray1;
						for (i = 0; i < (int)numArray.Length; i++)
						{
							num = numArray[i];
							if (num > int_5)
							{
								num4 = num;
							}
						}
						if (num4 > 0)
						{
							num1 = Array.IndexOf<int>(array, num4);
							num2 = Array.IndexOf<int>(array, int_5);
							int5[num1]["PackageSort"] = int_5;
							int5[num2]["PackageSort"] = num4;
							flag = true;
						}
					}
				}
			}
			return flag;
		}

		public void method_43()
		{
			if (this.IsActivated)
			{
				string str = Class3.smethod_2(string.Concat(Class12.smethod_0("OutPutFolder"), "\\Server"), true, true);
				string str1 = Class3.smethod_2(string.Concat(Class12.smethod_0("OutPutFolder"), "\\Client"), true, true);
				bool flag = Class6.smethod_1(Form1.dataSet_0.Tables["IBSCategory"], "@", false, string.Concat(str1, "IBSCategory.txt"), false, "CategoryID");
				bool flag1 = Class6.smethod_1(Form1.dataSet_0.Tables["IBSProduct"], "@", false, string.Concat(str1, "IBSProduct.txt"), false, "ProductID, ProductNumber");
				bool flag2 = Class6.smethod_1(Form1.dataSet_0.Tables["IBSPackage"], "@", false, string.Concat(str1, "IBSPackage.txt"), false, "CategoryID, PackageSort");
				bool flag3 = Class6.smethod_1(Form1.dataSet_0.Tables["CashShopProduct"], "\t", true, string.Concat(str, "CashShopProduct.txt"), false, "ProductID, ProductNumber");
				bool flag4 = Class6.smethod_1(Form1.dataSet_0.Tables["CashShopPackage"], "\t", true, string.Concat(str, "CashShopPackage.txt"), true, "CategoryID, PackageID");
				int num = (flag ? 20 : 0) + (flag1 ? 20 : 0) + (flag2 ? 20 : 0) + (flag3 ? 20 : 0) + (flag4 ? 20 : 0);
				this.method_16("Exporting Data. Please Wait..", "");
				if (num != 100)
				{
					this.method_16("Export Failed!", "error");
				}
				else
				{
					this.method_16("Data has been successfully exported.", "success");
					if (MessageBox.Show("Data successfully exported. \nYour exported file is located at 'Output' folder. Click \"Yes\" to open the folder.", Application.ProductName, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
					{
						Process.Start(Class3.smethod_2(Class12.smethod_0("OutPutFolder"), true, false));
					}
				}
			}
		}

		private void method_44()
		{
			this.PrDGV.Rows.Clear();
			foreach (DataRow dataRow in Form1.dataSet_0.Tables["IBSProduct"].Rows)
			{
				//if ((!(row["ProductID"].ToString() == row["ProductNumber"].ToString()) || !(row["PType3"].ToString() != "174") ? 0 : (int)(row["PType3"].ToString() != "151")) == 0)
                if ((!(dataRow["ProductID"].ToString() == dataRow["ProductNumber"].ToString()) || !(dataRow["PType3"].ToString() != "174") ? 0 : (dataRow["PType3"].ToString() != "151" ? 1 : 0)) != 0)
                    {
					continue;
				}
				DataGridViewRowCollection rows = this.PrDGV.Rows;
				object[] item = new object[] { dataRow["ProductID"], dataRow["Name"] };
				rows.Add(item);
			}
		}

		private void method_45()
		{
			this.addNewProdBtn.Text = "\u00a0\u00a0\u00a0Add to Products";
			this.int_4 = 0;
			this.method_44();
			bool flag = this.method_35() == "bundle";
			this.packType.Enabled = (flag ? false : true);
			this.packCount.Enabled = (flag ? false : true);
			if (flag)
			{
				this.packType.SelectedIndex = 1;
				this.packCount.Text = (flag ? "0" : this.packCount.Text);
				this.packUnit.SelectedIndex = -1;
				this.itemGroup.SelectedIndex = 14;
				this.itemIndexList.SelectedIndex = this.itemIndexList.Items.IndexOf("134");
				this.packUnit.Enabled = false;
			}
		}

		private void method_46()
		{
			this.packType.Enabled = true;
			this.packCount.Enabled = true;
		}

		private string method_47(DataGridView dataGridView_0, int int_5)
		{
			string empty = string.Empty;
			foreach (DataGridViewRow row in (IEnumerable)dataGridView_0.Rows)
			{
				empty = string.Concat(empty, "\r\n* ", row.Cells[int_5].Value.ToString());
			}
			return empty;
		}

		private void method_48(int int_5)
		{
			string str = string.Concat("ProductID =", int_5);
			DataRow[] dataRowArray = Form1.dataSet_0.Tables["CashShopProduct"].Select(str);
			DataRow[] dataRowArray1 = Form1.dataSet_0.Tables["IBSProduct"].Select(str);
			if (((int)dataRowArray1.Length == 0 ? false : (int)dataRowArray.Length != 0))
			{
				this.bundleEnable.Checked = true;
				this.method_45();
				this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabPage8"];
				bool flag = (this.method_7(dataRowArray1[0]["PType1"], -99) != 10 ? false : this.method_7(dataRowArray1[0]["PType2"], -99) == 138);
				bool flag1 = this.method_7(dataRowArray1[0]["PType2"], -99) == 140;
				this.addNewProdBtn.Text = "\u00a0\u00a0\u00a0Update Product";
				this.packDisc.Text = " ";
				if (this.int_0[0] >= 19)
				{
					this.packCurrency.SelectedIndex = 2;
				}
				else
				{
					this.packCurrency.SelectedIndex = (this.int_0[0] == 10 ? 0 : 1);
				}
				this.itemGroup.SelectedIndex = this.method_7(dataRowArray[0]["ItemGroup"], -99);
				this.itemListBox.SelectedIndex = this.itemIndexList.Items.IndexOf(this.method_8(dataRowArray[0]["ItemIndex"]));
				this.newPrPrice.Text = this.method_8(dataRowArray[0]["Price"]);
				string[] strArrays = new string[] { "7", "10", "10", "74" };
				int num = Array.LastIndexOf<string>(strArrays, this.method_8(dataRowArray1[0]["PType1"]));
				if (num == 2 && this.method_7(dataRowArray1[0]["PType2"], -99) == 138)
				{
					num = 1;
				}
				this.packType.SelectedIndex = num;
				if (flag)
				{
					this.newPrCount.Text = dataRowArray1[0]["Count"].ToString();
					this.newPrPname.Text = dataRowArray1[0]["Name"].ToString();
				}
				else if (!flag1)
				{
					this.newPrCount.Text = dataRowArray1[0]["Count"].ToString();
					this.newPrPname.Text = dataRowArray1[0]["Name"].ToString();
				}
				else
				{
					TextBox textBox = this.newPrCount;
					int num1 = this.method_22(this.method_7(dataRowArray1[0]["Count"], -99), num);
					textBox.Text = num1.ToString();
					this.newPrPname.Text = dataRowArray1[0]["Name"].ToString();
				}
				this.newPrAncient.SelectedIndex = this.method_7(dataRowArray[0]["AncOp"], -99);
				this.newPrDur.Text = dataRowArray[0]["Durability"].ToString();
				this.newPrLvl.SelectedIndex = this.newPrLvl.Items.IndexOf(dataRowArray[0]["Level"].ToString());
				this.newPrOpt.SelectedIndex = this.newPrOpt.Items.IndexOf(dataRowArray[0]["Option"].ToString());
				this.newPrSkill.Checked = Convert.ToBoolean(this.method_7(dataRowArray[0]["Skill"], -99));
				this.newPrLuck.Checked = Convert.ToBoolean(this.method_7(dataRowArray[0]["Luck"], -99));
				int[] numArray = this.method_23(this.method_7(dataRowArray[0]["ExOpt"], -99));
				this.newPrOpt1.Checked = Convert.ToBoolean(numArray[0]);
				this.newPrOpt2.Checked = Convert.ToBoolean(numArray[1]);
				this.newPrOpt3.Checked = Convert.ToBoolean(numArray[2]);
				this.newPrOpt4.Checked = Convert.ToBoolean(numArray[3]);
				this.newPrOpt5.Checked = Convert.ToBoolean(numArray[4]);
				this.newPrOpt6.Checked = Convert.ToBoolean(numArray[5]);
				this.int_4 = int_5;
			}
		}

		private void method_5(object sender, MouseEventArgs e)
		{
			Control control = (Control)sender;
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				int num = Convert.ToInt32(control.Tag);
				this.method_9(num);
				this.int_0[0] = num;
				if (num >= 19)
				{
					this.packCurrency.SelectedIndex = 2;
				}
				else
				{
					this.packCurrency.SelectedIndex = (num == 10 ? 0 : 1);
				}
			}
			if (e.Button == System.Windows.Forms.MouseButtons.Middle)
			{
				TextBox point = this.newMedit;
				Point location = control.Location;
				int x = location.X + 2;
				location = control.Location;
				point.Location = new Point(x, location.Y + 6);
				this.newMedit.Text = control.Text;
				this.newMedit.Visible = true;
				this.newMedit.BackColor = control.BackColor;
				this.newMedit.BringToFront();
				this.newMedit.Tag = control.Tag;
				this.newMedit.Focus();
			}
		}

		private void method_6()
		{
			int i;
			this.enableMultiPack.Checked = false;
			this.item1Ancient.Enabled = Class12.smethod_0("AncientItem") == "1";
			this.newPrAncient.Enabled = this.item1Ancient.Enabled;
			string[] strArrays = Form1.smethod_0("MaxItemLvl");
			string[] strArrays1 = Form1.smethod_0("MaxItemOpt");
			string[] strArrays2 = Form1.smethod_0("MaxItemSocket");
			Control[] item = this.method_37()["Lvl"];
			Control[] controlArray = this.method_37()["Opt"];
			Control[] item1 = this.method_37()["Sckt"];
			Control[] controlArray1 = item;
			for (i = 0; i < (int)controlArray1.Length; i++)
			{
				Control control = controlArray1[i];
				((ComboBox)control).Items.Clear();
				((ComboBox)control).Items.AddRange(strArrays);
			}
			controlArray1 = controlArray;
			for (i = 0; i < (int)controlArray1.Length; i++)
			{
				Control control1 = controlArray1[i];
				((ComboBox)control1).Items.Clear();
				((ComboBox)control1).Items.AddRange(strArrays1);
			}
			controlArray1 = item1;
			for (i = 0; i < (int)controlArray1.Length; i++)
			{
				Control control2 = controlArray1[i];
				((ComboBox)control2).Items.Clear();
				((ComboBox)control2).Items.AddRange(strArrays2);
			}
		}

		private int method_7(object object_0, int int_5 = -99)
		{
			int num;
			int num1;
			try
			{
				int num2 = Convert.ToInt32(object_0);
				if (num2 >= 0)
				{
					num1 = num2;
				}
				else
				{
					num1 = (int_5 != -99 ? int_5 : num2);
				}
				num = num1;
			}
			catch (Exception exception)
			{
				num = (int_5 != -99 ? int_5 : 0);
			}
			return num;
		}

		private string method_8(object object_0)
		{
			string str;
			try
			{
				str = object_0.ToString();
			}
			catch (Exception exception)
			{
				str = string.Empty;
			}
			return str;
		}

		private void method_9(int int_5)
		{
			this.method_2(int_5, true);
		}

		private void modifyPackagPackageMenu_Click(object sender, EventArgs e)
		{
			this.method_13(this.packageMenu.SourceControl, null);
		}

		private void modifyProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Control sourceControl = this.contextMenuStrip1.SourceControl;
			int num = this.method_7(((DataGridView)sourceControl).SelectedRows[0].Cells[0].Value, -99);
			this.method_48(num);
		}

		private void moveDownPackageMenu_Click(object sender, EventArgs e)
		{
			Control sourceControl = this.packageMenu.SourceControl;
			DataRow dataRow = Form1.dataSet_0.Tables["IBSPackage"].Rows.Find(this.method_7(sourceControl.Tag, -99));
			if (dataRow == null)
			{
				Class3.smethod_1("Could not find the package!", "warning");
			}
			else if (!this.method_42("down", string.Concat("CategoryID = ", this.method_7(dataRow["CategoryID"], -99)), this.method_7(dataRow["PackageSort"], -99)))
			{
				Class3.smethod_1("Unable to move!", "warning");
			}
			else
			{
				this.method_2(this.int_0[1], false);
			}
			this.int_2 = 0;
		}

		private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Control sourceControl = this.contexMenu.SourceControl;
			string str = this.contexMenu.SourceControl.Parent.Name.ToString();
			DataRow dataRow = Form1.dataSet_0.Tables["IBSCategory"].Rows.Find(this.method_7(sourceControl.Tag, -99));
			if (dataRow == null)
			{
				Class3.smethod_1("Somethng wrong while moving!", "warning");
			}
			else
			{
				string str1 = str;
				if (str1 != null)
				{
					if (str1 != "mainCutPanel")
					{
						if (str1 == "subCutPanel")
						{
							if (!this.method_41("down", string.Concat("Code = 0 AND TypeID = ", this.method_7(dataRow["TypeID"], -99)), this.method_7(dataRow["CategorySort"], -99)))
							{
								Class3.smethod_1("Unable to move!", "warning");
							}
							else
							{
								this.method_2(this.int_0[1], false);
							}
						}
					}
					else if (!this.method_41("down", "Code = 1", this.method_7(dataRow["CategorySort"], -99)))
					{
						Class3.smethod_1("Unable to move!", "warning");
					}
					else
					{
						this.method_2(this.int_0[0], true);
					}
				}
			}
		}

		private void moveUpPackageMenu_Click(object sender, EventArgs e)
		{
			Control sourceControl = this.packageMenu.SourceControl;
			DataRow dataRow = Form1.dataSet_0.Tables["IBSPackage"].Rows.Find(this.method_7(sourceControl.Tag, -99));
			if (dataRow == null)
			{
				Class3.smethod_1("Could not find the package!", "warning");
			}
			else if (!this.method_42("up", string.Concat("CategoryID = ", this.method_7(dataRow["CategoryID"], -99)), this.method_7(dataRow["PackageSort"], -99)))
			{
				Class3.smethod_1("Unable to move!", "warning");
			}
			else
			{
				this.method_2(this.int_0[1], false);
			}
			this.int_2 = 0;
		}

		private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Control sourceControl = this.contexMenu.SourceControl;
			string str = this.contexMenu.SourceControl.Parent.Name.ToString();
			DataRow dataRow = Form1.dataSet_0.Tables["IBSCategory"].Rows.Find(this.method_7(sourceControl.Tag, -99));
			if ((dataRow == null ? true : this.method_7(dataRow["CategorySort"], -99) <= 1))
			{
				Class3.smethod_1("Unable to move!", "warning");
			}
			else
			{
				string str1 = str;
				if (str1 != null)
				{
					if (str1 != "mainCutPanel")
					{
						if (str1 == "subCutPanel")
						{
							if (!this.method_41("up", string.Concat("Code = 0 AND TypeID = ", this.method_7(dataRow["TypeID"], -99)), this.method_7(dataRow["CategorySort"], -99)))
							{
								Class3.smethod_1("Somethng wrong while moving!", "warning");
							}
							else
							{
								this.method_2(this.int_0[1], false);
							}
						}
					}
					else if (!this.method_41("up", "Code = 1", this.method_7(dataRow["CategorySort"], -99)))
					{
						Class3.smethod_1("Unable to move!", "warning");
					}
					else
					{
						this.method_2(this.int_0[0], true);
					}
				}
			}
		}

		private void newPrCount_TextChanged(object sender, EventArgs e)
		{
			this.packCount.Text = this.newPrCount.Text;
		}

		private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Don't forget to save your data ;). \nDo your want to continue? Click \"Yes\" to stat new project.", Application.ProductName, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				Form1.dataSet_0 = new DataSet();
				Form1.dataSet_0 = Class6.smethod_0("zData", true);
				this.method_2(this.int_0[0], true);
				this.string_2 = string.Empty;
			}
		}

		private void newPrPname_TextChanged(object sender, EventArgs e)
		{
		}

		private void newTedit_KeyPress(object sender, KeyPressEventArgs e)
		{
			string str = ((Control)sender).Name.ToString();
			if (str != null)
			{
				if (str == "newTedit")
				{
					this.int_0[1] = this.method_7(((Control)sender).Tag, -99);
					if ((e.KeyChar == '\r' ? true : e.KeyChar == '\r'))
					{
						if ((((Control)sender).Text == "" ? true : ((Control)sender).Text.Length <= 3))
						{
							Class3.smethod_1("Tab Name must be minumum of 4 character long.", "");
						}
						else
						{
							this.method_24("Edit", ((Control)sender).Text, this.method_7(((Control)sender).Tag, -99), false, 10);
							this.method_2(this.int_0[1], false);
						}
					}
				}
				else if (str == "newMedit")
				{
					this.int_0[0] = this.method_7(((Control)sender).Tag, -99);
					if ((e.KeyChar == '\r' ? true : e.KeyChar == '\r'))
					{
						if ((((Control)sender).Text == "" ? true : ((Control)sender).Text.Length <= 3))
						{
							Class3.smethod_1("Tab Name must be minumum of 4 character long.", "");
						}
						else
						{
							this.method_24("Edit", ((Control)sender).Text, this.method_7(((Control)sender).Tag, -99), false, 10);
							this.method_2(this.int_0[0], true);
						}
					}
				}
			}
		}

		private void newTedit_LostFocus(object sender, EventArgs e)
		{
			this.newTedit_KeyPress(sender, new KeyPressEventArgs('\r'));
			((TextBox)sender).Visible = false;
		}

		private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
		{
			if ((this.openFileDialog_0.FileName == "" ? false : File.Exists(this.openFileDialog_0.FileName)))
			{
				string fileName = this.openFileDialog_0.FileName;
				string[] strArrays = File.ReadAllLines(fileName);
				if ((int)strArrays.Length != 5)
				{
					Class3.smethod_1("Invalid file.", "warning");
				}
				else
				{
					string str = strArrays[0];
					char[] chrArray = new char[] { ';' };
					string[] strArrays1 = str.Split(chrArray);
					string str1 = strArrays[1];
					chrArray = new char[] { ';' };
					string[] strArrays2 = str1.Split(chrArray);
					string str2 = strArrays[2];
					chrArray = new char[] { ';' };
					string[] strArrays3 = str2.Split(chrArray);
					string str3 = strArrays[3];
					chrArray = new char[] { ';' };
					string[] strArrays4 = str3.Split(chrArray);
					string str4 = strArrays[4];
					chrArray = new char[] { ';' };
					string[] strArrays5 = str4.Split(chrArray);
					Form1.dataSet_0 = new DataSet();
					Form1.dataSet_0 = Class6.smethod_0("zData", false);
					DataSet dataSet0 = Form1.dataSet_0;
					bool flag = Class6.smethod_2(dataSet0.Tables["IBSCategory"], strArrays1, "IBSCT");
					bool flag1 = Class6.smethod_2(dataSet0.Tables["IBSPackage"], strArrays2, "IBSPK");
					bool flag2 = Class6.smethod_2(dataSet0.Tables["IBSProduct"], strArrays3, "IBSPD");
					bool flag3 = Class6.smethod_2(dataSet0.Tables["CashShopPackage"], strArrays4, "CSHPK");
					bool flag4 = Class6.smethod_2(dataSet0.Tables["CashShopProduct"], strArrays5, "CSHPD");
					if ((!flag || !flag1 || !flag2 || !flag3 ? true : !flag4))
					{
						this.string_2 = string.Empty;
						Class3.smethod_1("Error while loading saved data", "warning");
					}
					else
					{
						this.string_2 = fileName;
						this.method_2(this.int_0[0], true);
					}
					this.method_44();
				}
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Data\\");
			this.openFileDialog_0.InitialDirectory = str;
			this.openFileDialog_0.FileName = "CashShopData.dat";
			this.openFileDialog_0.ShowDialog();
		}

		private void packCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((char.IsControl(e.KeyChar) ? false : !char.IsDigit(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void packCount_TextChanged(object sender, EventArgs e)
		{
			this.item1Count.Text = this.packCount.Text;
			this.newPrCount.Text = this.packCount.Text;
		}

		private void packDisc_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == (Keys.LButton | Keys.A | Keys.Control))
			{
				this.packDisc.SelectAll();
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void packDisc_TextChanged(object sender, EventArgs e)
		{
			string text = ((Control)sender).Text;
			if (text.Contains(";"))
			{
				((Control)sender).Text = text.Replace(";", " ");
			}
			if (text.Contains("^"))
			{
				((Control)sender).Text = text.Replace("^", " ");
			}
		}

		private void packName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar == '\u005E' ? false : e.KeyChar != ';'))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void packName_TextChanged(object sender, EventArgs e)
		{
			string text = ((Control)sender).Text;
			if (text.Contains(";"))
			{
				((Control)sender).Text = text.Replace(";", " ");
			}
			if (text.Contains("^"))
			{
				((Control)sender).Text = text.Replace("^", " ");
			}
		}

		private void packType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.packUnit.Items.Clear();
			this.packUnit.Enabled = false;
			string[] strArrays = new string[] { "Minute(s)", "Hour(s)", "Day(s)" };
			switch (this.packType.SelectedIndex)
			{
				case 0:
				{
					this.packUnit.Items.Add("EA");
					this.packUnit.SelectedIndex = 0;
					break;
				}
				case 1:
				{
					this.packUnit.Items.AddRange(strArrays);
					this.packUnit.SelectedIndex = 1;
					this.packUnit.Enabled = true;
					break;
				}
				case 2:
				{
					this.packUnit.Items.AddRange(strArrays);
					this.packUnit.SelectedIndex = 1;
					this.packUnit.Enabled = true;
					break;
				}
				case 3:
				{
					this.packUnit.Items.Add("%");
					this.packUnit.SelectedIndex = 0;
					break;
				}
			}
		}

		private void packUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			Control[] item = this.method_37()["Count"];
			int num = 0;
			Control[] controlArray = this.method_37()["PName"];
			for (int i = 0; i < (int)controlArray.Length; i++)
			{
				Control control = controlArray[i];
				string[] text = new string[] { this.packName.Text, " (", item[num].Text, " ", this.packUnit.Text.Replace("(s)", "s"), ")" };
				control.Text = string.Concat(text);
				num++;
			}
		}

		private void PrDGV_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button.Equals(System.Windows.Forms.MouseButtons.Right))
			{
				this.PrDGV.Rows[e.RowIndex].Selected = true;
			}
		}

		private void prevBtn_Click(object sender, EventArgs e)
		{
			string str = ((Button)sender).Tag.ToString();
			string[] strArrays = str.Split(new char[] { '|' });
			this.method_11(Convert.ToInt32(strArrays[0]), Convert.ToInt32(strArrays[1]));
		}

		private void previewDataTablesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_40(null, null);
			this.workProgress.Visible = true;
			this.pleaseWait.Visible = true;
			this.int_3 = 1;
			this.backgroundWorker_1.RunWorkerAsync();
		}

		private void renameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Point location;
			Control sourceControl = this.contexMenu.SourceControl;
			string str = this.contexMenu.SourceControl.Parent.Name.ToString();
			if (str == "mainCutPanel")
			{
				TextBox point = this.newMedit;
				location = sourceControl.Location;
				int x = location.X + 2;
				location = sourceControl.Location;
				point.Location = new Point(x, location.Y + 6);
				this.newMedit.Text = sourceControl.Text;
				this.newMedit.Visible = true;
				this.newMedit.BackColor = sourceControl.BackColor;
				this.newMedit.BringToFront();
				this.newMedit.Focus();
				this.newMedit.Tag = sourceControl.Tag;
			}
			if (str == "subCutPanel")
			{
				TextBox textBox = this.newTedit;
				location = sourceControl.Location;
				int num = location.X + 2;
				location = sourceControl.Location;
				textBox.Location = new Point(num, location.Y + 6);
				this.newTedit.Text = sourceControl.Text;
				this.newTedit.Visible = true;
				this.newTedit.BackColor = sourceControl.BackColor;
				this.newTedit.BringToFront();
				this.newTedit.Focus();
				this.newTedit.Tag = sourceControl.Tag;
			}
		}

		private void resetDefaultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to reset to default? . \nClick 'Yes' to continue", Application.ProductName, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				Form1.dataSet_0 = new DataSet();
				Form1.dataSet_0 = Class6.smethod_0("zData", true);
				this.method_2(this.int_0[0], true);
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.IsActivated)
			{
				string str = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Data\\");
				this.saveFileDialog_0.InitialDirectory = str;
				this.saveFileDialog_0.FileName = "CashShopData.dat";
				this.saveFileDialog_0.ShowDialog();
			}
		}

		private void saveFileDialog_0_FileOk(object sender, CancelEventArgs e)
		{
			if (this.saveFileDialog_0.FileName != "")
			{
				if (!this.IsActivated)
				{
					this.string_1 = string.Concat(this.string_1, "Export Error \r");
				}
				if (this.string_1 != string.Empty)
				{
					this.method_16("Please activate this program.", "warning");
				}
				bool flag = Class5.smethod_0();
				if ((!(this.string_1 == string.Empty) || !flag ? false : this.IsActivated))
				{
					Class6.smethod_3(Form1.dataSet_0, this.saveFileDialog_0.FileName, false);
					this.string_2 = this.saveFileDialog_0.FileName;
					this.method_16("CashShop Data Saved!", "success");
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.IsActivated)
			{
				if ((this.string_2 == null ? true : this.string_2.Length <= 1))
				{
					string str = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Data\\");
					this.saveFileDialog_0.InitialDirectory = str;
					this.saveFileDialog_0.FileName = "CashShopData.dat";
					this.saveFileDialog_0.ShowDialog();
				}
				else
				{
					Class6.smethod_3(Form1.dataSet_0, this.string_2, false);
					this.method_16("CashShop Data Saved!", "success");
				}
			}
		}

		private static string[] smethod_0(string string_3)
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string str = Class12.smethod_0(string_3);
			string[] strArrays = new string[Convert.ToInt32(str) + 1];
			for (int i = 0; i <= Convert.ToInt32(str); i++)
			{
				strArrays[i] = i.ToString();
			}
			return strArrays;
		}

		//protected override void System.Windows.Forms.Form.Dispose(bool disposing)
		//{
		//	if ((!disposing ? false : this.icontainer_0 != null))
		//	{
		//		this.icontainer_0.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.addtoproductPanel.Visible = this.tabControl1.SelectedTab == this.tabControl1.TabPages["tabPage8"];
			if (this.tabControl1.SelectedTab == this.tabControl1.TabPages["tabPage8"])
			{
				this.packType.SelectedIndex = 0;
			}
			this.method_45();
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.textBox1.Text != string.Empty)
			{
				int num = this.itemListBox.FindString(this.textBox1.Text);
				if (num != -1)
				{
					this.itemListBox.SetSelected(num, true);
				}
			}
		}

		private void updatePack_Click(object sender, EventArgs e)
		{
			if (this.method_35() == "product")
			{
				Class3.smethod_1("Please use the \"Add to Product\" button below to add product.", "warning");
			}
			if (this.method_35() == "bundle")
			{
				if (!this.method_17(this.int_2))
				{
					Class3.smethod_1("You must select first a package you want to update.", "warning");
				}
				else
				{
					this.method_28(this.int_1[0], true, this.int_2);
					this.method_11(this.int_1[0], Convert.ToInt32(this.int_1[1]));
					this.int_2 = 0;
				}
			}
			if (this.method_35() == "pack")
			{
				if (!this.method_18(this.int_2))
				{
					Class3.smethod_1("You must select first a package you want to update.", "warning");
				}
				else
				{
					this.method_26(this.int_1[0], true, this.int_2);
					this.method_11(this.int_1[0], Convert.ToInt32(this.int_1[1]));
					this.int_2 = 0;
				}
			}
		}

		private void updatePack_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void wCoinsPShopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_24("New", "W Coin Shop", 0, true, 10);
			this.method_2(this.int_0[0], true);
		}

		internal static class Class2
		{
			internal readonly static int int_0;

			internal readonly static int int_1;

			static Class2()
			{
				Form1.Class2.int_0 = -20;
				Form1.Class2.int_1 = 33554432;
			}

			[DllImport("user32", CharSet=CharSet.None, ExactSpelling=false)]
			internal static extern int GetWindowLong(IntPtr intptr_0, int int_2);

			[DllImport("user32", CharSet=CharSet.None, ExactSpelling=false)]
			internal static extern int SetWindowLong(IntPtr intptr_0, int int_2, int int_3);
		}
	}
}