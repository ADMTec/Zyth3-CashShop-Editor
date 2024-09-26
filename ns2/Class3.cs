using System;
using System.IO;
using System.Windows.Forms;

namespace ns2
{
	internal class Class3
	{
		public Class3()
		{
		}

		public static int smethod_0(object object_0)
		{
			int num;
			try
			{
				num = Convert.ToInt32(object_0);
			}
			catch (Exception exception)
			{
				num = 0;
			}
			return num;
		}

		public static void smethod_1(string string_0, string string_1 = "")
		{
			DialogResult dialogResult;
			string string1 = string_1;
			if (string1 != null)
			{
				if (string1 == "error")
				{
					MessageBox.Show(string_0, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				else if (string1 == "warning")
				{
					MessageBox.Show(string_0, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				else
				{
					if (string1 != "success")
					{
						dialogResult = MessageBox.Show(string_0, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					MessageBox.Show(string_0, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
			}
			dialogResult = MessageBox.Show(string_0, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		public static string smethod_2(string string_0, bool bool_0 = false, bool bool_1 = false)
		{
			string string0;
			string str = (string_0.Substring(1, 1) == ":" ? string.Empty : AppDomain.CurrentDomain.BaseDirectory);
			string_0 = (string_0.Substring(0, 1) == "\\" ? string.Concat(str, string_0.Substring(1)) : string.Concat(str, string_0));
			if (bool_0)
			{
				string0 = (string_0.Substring(string_0.Length - 1, 1) == "\\" ? string_0 : string.Concat(string_0, "\\"));
			}
			else
			{
				string0 = string_0;
			}
			string_0 = string0;
			if ((!bool_0 || !bool_1 ? false : !Directory.Exists(string_0)))
			{
				Directory.CreateDirectory(string_0);
			}
			if ((bool_0 || !bool_1 ? false : !File.Exists(string_0)))
			{
				Class3.smethod_1(string.Concat("\"", string_0, "\" File not exests"), "warning");
			}
			return string_0;
		}
	}
}