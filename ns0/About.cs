using ns1;
using ns2;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	internal class About : Form
	{
		private IContainer icontainer_0 = null;

		private Button CloseBtn;

		private Panel panel1;

		private Panel panel2;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Label label1;

		private Panel panel3;

		private Label label7;

		private Button goReg;

		public About()
		{
			this.InitializeComponent();
			this.goReg.Visible = !Class8.form1_0.IsActivated;
			Label label = this.label3;
			Class8.form1_0.Text = "License:";
			this.goReg.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.label1.Text = Application.ProductName.ToString();
			this.label2.Text = string.Concat("Ver. ", Application.ProductVersion.ToString());
			//return label;
		}

		private void InitializeComponent()
		{
			this.CloseBtn = new Button();
			this.panel1 = new Panel();
			this.goReg = new Button();
			this.label7 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label1 = new Label();
			this.panel2 = new Panel();
			this.label2 = new Label();
			this.panel3 = new Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.CloseBtn.BackColor = Color.White;
			this.CloseBtn.FlatStyle = FlatStyle.Flat;
			this.CloseBtn.Location = new Point(322, 14);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(95, 28);
			this.CloseBtn.TabIndex = 1;
			this.CloseBtn.Text = "&Close";
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.panel1.BackColor = Color.White;
			this.panel1.Controls.Add(this.goReg);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = DockStyle.Right;
			this.panel1.Location = new Point(133, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(430, 211);
			this.panel1.TabIndex = 2;
			this.goReg.BackColor = Color.White;
			this.goReg.Cursor = Cursors.Hand;
			this.goReg.FlatAppearance.BorderColor = Color.White;
			this.goReg.FlatAppearance.BorderSize = 0;
			this.goReg.FlatAppearance.MouseDownBackColor = Color.White;
			this.goReg.FlatAppearance.MouseOverBackColor = Color.White;
			this.goReg.FlatStyle = FlatStyle.Flat;
			this.goReg.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Underline);
			this.goReg.ForeColor = SystemColors.HotTrack;
			this.goReg.Location = new Point(280, 81);
			this.goReg.Name = "goReg";
			this.goReg.Size = new System.Drawing.Size(143, 27);
			this.goReg.TabIndex = 8;
			this.goReg.Text = "Enter License Key";
			this.goReg.TextAlign = ContentAlignment.MiddleRight;
			this.goReg.UseVisualStyleBackColor = false;
			this.goReg.Visible = false;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ControlText;
			this.label7.Location = new Point(25, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(229, 15);
			this.label7.TabIndex = 7;
			this.label7.Text = "© Copyright 2015 Zyth3 Allright Reserved";
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.HotTrack;
			this.label5.Location = new Point(25, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Visit home page";
			this.label5.Click += new EventHandler(this.label5_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ControlText;
			this.label4.Location = new Point(25, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(232, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Professional Mu Server Cash Shop Editor";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.DarkRed;
			this.label3.Location = new Point(25, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "License: zTeam";
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ControlText;
			this.label1.Location = new Point(24, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Zythe CashShop Editor";
			this.panel2.BackColor = SystemColors.ControlDark;
			this.panel2.Controls.Add(this.CloseBtn);
			this.panel2.Dock = DockStyle.Bottom;
			this.panel2.Location = new Point(0, 157);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(430, 54);
			this.panel2.TabIndex = 0;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ControlDark;
			this.label2.Location = new Point(6, 187);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Version. 1.0.0.1";
			this.panel3.BackColor = Color.FromArgb(46, 46, 46);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(563, 211);
			this.panel3.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = SystemColors.ActiveCaptionText;
			base.ClientSize = new System.Drawing.Size(563, 211);
			base.ControlBox = false;
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel3);
			this.ForeColor = SystemColors.ControlDarkDark;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "About";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "About";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		private void label5_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("http://www.crysiscore.net");
			}
			catch (Exception exception)
			{
				Process.Start("IExplore.exe", "http://www.crysiscore.net");
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