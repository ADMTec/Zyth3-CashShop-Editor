using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns2
{
	internal class Class7
	{
		public Class7()
		{
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int GetPrivateProfileString(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0, int int_0, string string_3);

		public static bool smethod_0(string string_0, string string_1, string string_2, string string_3)
		{
			bool flag;
			try
			{
				Class7.WritePrivateProfileString(string_0, string_1, string.Concat(" ", string_2), string_3);
				flag = true;
			}
			catch (Exception exception)
			{
				flag = false;
			}
			return flag;
		}

		public static string smethod_1(string string_0, string string_1, string string_2)
		{
			string str;
			try
			{
				StringBuilder stringBuilder = new StringBuilder(255);
				Class7.GetPrivateProfileString(string_0, string_1, "", stringBuilder, 255, string_2);
				str = stringBuilder.ToString().Trim();
			}
			catch (Exception exception)
			{
				throw;
			}
			return str;
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int WritePrivateProfileString(string string_0, string string_1, string string_2, string string_3);
	}
}