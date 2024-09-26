using ns1;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ns2
{
	internal static class Class8
	{
		public static Form1 form1_0;

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Class8.form1_0 = new Form1();
			Application.ThreadException += new ThreadExceptionEventHandler(Class8.smethod_0);
			Application.Run(Class8.form1_0);
		}

		private static void smethod_0(object sender, ThreadExceptionEventArgs e)
		{
			if (MessageBox.Show("An unexpected error has occurred.\nPlease contact the Author of this Program or Click \"Yes\" to Continue. \n\n Zyth3.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				Application.Exit();
			}
		}
	}
}