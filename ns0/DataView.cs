using ns1;
using ns2;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
    internal class DataView : Form
    {
        private int int_0 = 0;
        private IContainer icontainer_0 = null;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private Panel panel2;
        private Panel panel3;

        public DataView()
        {
            this.InitializeComponent();
            this.comboBox1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class8.form1_0.method_43();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_0(this.comboBox1.SelectedIndex, true);
        }

        private void InitializeComponent()
        {
            this.panel1 = new Panel();
            this.panel3 = new Panel();
            this.button1 = new Button();
            this.label1 = new Label();
            this.comboBox1 = new ComboBox();
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.editToolStripMenuItem = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.dataGridView1 = new DataGridView();
            this.statusStrip1 = new StatusStrip();
            this.panel2 = new Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.panel1.BackColor = Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1084, 84);
            this.panel1.TabIndex = 0;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = DockStyle.Right;
            this.panel3.Location = new Point(932, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(152, 60);
            this.panel3.TabIndex = 4;
            this.button1.Location = new Point(17, 22);
            this.button1.Name = "button1";
            this.button1.Size = new Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export to File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = SystemColors.ControlDarkDark;
            this.label1.Location = new Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new Size(96, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select DataTable";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Client", "  --IBSCategory", "  --IBSPackage", "  --IBSProduct", "Server", "  --CashShopPackage", "  --CashShopProduct" });
            this.comboBox1.Location = new Point(0x6c, 0x2e);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(178, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem, this.editToolStripMenuItem, this.helpToolStripMenuItem });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(1084, 455);
            this.dataGridView1.TabIndex = 1;
            this.statusStrip1.Location = new Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(1084, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.panel2.BackColor = SystemColors.ButtonShadow;
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1084, 455);
            this.panel2.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1084, 561);
            base.Controls.Add(this.dataGridView1);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.statusStrip1);
            base.Controls.Add(this.panel1);
            base.MainMenuStrip = this.menuStrip1;
            base.Name = "DataView";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "DataView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0(int int_1, bool bool_0 = false)
        {
            if (int_1 != this.int_0)
            {
                this.dataGridView1.Columns.Clear();
                BindingSource bindingSources = new BindingSource();
                switch (int_1)
                {
                    case 0:
                        {
                            this.comboBox1.SelectedIndex = 1;
                            bindingSources.DataSource = Form1.dataSet_0.Tables["IBSCategory"];
                            break;
                        }
                    case 1:
                        {
                            bindingSources.DataSource = Form1.dataSet_0.Tables["IBSCategory"];
                            break;
                        }
                    case 2:
                        {
                            bindingSources.DataSource = Form1.dataSet_0.Tables["IBSPackage"];
                            break;
                        }
                    case 3:
                        {
                            bindingSources.DataSource = Form1.dataSet_0.Tables["IBSProduct"];
                            break;
                        }
                    case 4:
                        {
                            this.comboBox1.SelectedIndex = 5;
                            bindingSources.DataSource = Form1.dataSet_0.Tables["CashShopPackage"];
                            break;
                        }
                    case 5:
                        {
                            bindingSources.DataSource = Form1.dataSet_0.Tables["CashShopPackage"];
                            break;
                        }
                    case 6:
                        {
                            bindingSources.DataSource = Form1.dataSet_0.Tables["CashShopProduct"];
                            break;
                        }
                }
                this.dataGridView1.DataSource = bindingSources;
                this.int_0 = int_1;
            }
        }

        //protected override void System.Windows.Forms.Form.Dispose(bool disposing)
        //{
        //    if ((!disposing ? false : this.icontainer_0 != null))
        //    {
        //        this.icontainer_0.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}