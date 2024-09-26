using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ns3
{
	internal class Class10
	{
		private bool bool_0 = false;

		private string string_0 = "Software\\Microsoft\\SysNetService\\";

		private RegistryKey registryKey_0 = Registry.CurrentUser;

		public Class10()
		{
		}

		public string method_0(string string_1, string string_2 = null)
		{
			string string2;
			RegistryKey registryKey = this.registryKey_0.OpenSubKey(this.string_0);
			if (registryKey != null)
			{
				try
				{
					string value = (string)registryKey.GetValue(string_1.ToUpper());
					if (value == null)
					{
						value = string_2;
					}
					string2 = value;
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					this.method_3(exception, string.Concat("Reading registry ", string_1.ToUpper()));
					string2 = string_2;
				}
			}
			else
			{
				string2 = string_2;
			}
			return string2;
		}

		public int method_1(string string_1, int int_0 = 0)
		{
			int int0;
			RegistryKey registryKey = this.registryKey_0.OpenSubKey(this.string_0);
			if (registryKey != null)
			{
				try
				{
					int value = (int)registryKey.GetValue(string_1.ToUpper());
					if (value == 0)
					{
						value = int_0;
					}
					int0 = value;
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					this.method_3(exception, string.Concat("Reading registry ", string_1.ToUpper()));
					int0 = int_0;
				}
			}
			else
			{
				int0 = int_0;
			}
			return int0;
		}

		public bool method_2(string string_1, object object_0)
		{
			bool flag;
			try
			{
				this.registryKey_0.CreateSubKey(this.string_0).SetValue(string_1, object_0);
				flag = true;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.method_3(exception, string.Concat("Writing registry ", string_1.ToUpper()));
				flag = false;
			}
			return flag;
		}

		private void method_3(Exception exception_0, string string_1)
		{
			if (this.bool_0)
			{
				MessageBox.Show(exception_0.Message, string_1, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
}