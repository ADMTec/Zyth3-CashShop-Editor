using System;
using System.Collections.Generic;

namespace ns2
{
	internal class Class12
	{
		private static string string_0;

		static Class12()
		{
			Class12.string_0 = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Config.ini");
		}

		public Class12()
		{
		}

		public static string smethod_0(string string_1)
		{
			string item;
			try
			{
				item = Class12.smethod_1(false)[string_1];
			}
			catch (Exception exception)
			{
				item = Class12.smethod_1(true)[string_1];
			}
			return item;
		}

		public static Dictionary<string, string> smethod_1(bool bool_0 = false)
		{
			Dictionary<string, string> strs = new Dictionary<string, string>();
			if (!bool_0)
			{
				strs["ServerFileIDX"] = Class7.smethod_1("Main", "ServerFileIDX", Class12.string_0);
				strs["OutPutFolder"] = Class7.smethod_1("Main", "OutPutFolder", Class12.string_0);
				strs["ItemTxt"] = Class7.smethod_1("ItemSetting", "ItemTxt", Class12.string_0);
				strs["MaxItemLvl"] = Class7.smethod_1("ItemSetting", "MaxItemLvl", Class12.string_0);
				strs["MaxItemOpt"] = Class7.smethod_1("ItemSetting", "MaxItemOpt", Class12.string_0);
				strs["MaxItemSocket"] = Class7.smethod_1("ItemSetting", "MaxItemSocket", Class12.string_0);
				strs["ItemSocketTxt"] = Class7.smethod_1("ItemSetting", "ItemSocketTxt", Class12.string_0);
				strs["MaxDurability"] = Class7.smethod_1("ItemSetting", "MaxDurability", Class12.string_0);
				strs["AncientItem"] = Class7.smethod_1("ItemSetting", "AncientItem", Class12.string_0);
			}
			else
			{
				string[] strArrays = new string[] { "ServerFileIDX", "OutPutFolder", "ItemTxt", "MaxItemLvl", "MaxItemOpt", "MaxItemSocket", "ItemSocketTxt", "MaxDurability", "AncientItem" };
				string[] strArrays1 = strArrays;
				strArrays = new string[] { "0", "Output", "Data\\Item.Txt", "15", "7", "5", "Data\\ItemSocket.Text", "500", "1" };
				string[] strArrays2 = strArrays;
				for (int i = 0; i < (int)strArrays1.Length; i++)
				{
					strs[strArrays1[i]] = strArrays2[i];
				}
			}
			return strs;
		}

		public static bool smethod_2(string[] string_1, string[] string_2)
		{
			bool flag;
			try
			{
				for (int i = 0; i < (int)string_1.Length; i++)
				{
					string str = (i < 2 ? "Main" : "ItemSetting");
					Class7.smethod_0(str, string_1[i], string_2[i], Class12.string_0);
				}
				flag = true;
			}
			catch (Exception exception)
			{
				flag = false;
			}
			return flag;
		}
	}
}