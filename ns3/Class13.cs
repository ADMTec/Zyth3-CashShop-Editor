using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ns3
{
	internal class Class13
	{
		public static string[] string_0;

		static Class13()
		{
			string[] strArrays = new string[] { "Swords", "Axes", "Maces /Scepters", "Spears", "Bow /CrossBow", "Staffs", "Shields", "Hemls", "Armors", "Pants", "Gloves", "Boots", "Wings /Orbs /Spheres", "Pets /Rings /Etc", "Jewels /Misc", "Scrolls" };
			Class13.string_0 = strArrays;
		}

		public Class13()
		{
		}

		public static List<string> smethod_0(string string_1)
		{
			string[] strArrays = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
			string[] strArrays1 = strArrays;
			List<string> strs = new List<string>();
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			StreamReader streamReader = new StreamReader(string_1);
			try
			{
				int num = -1;
				while (true)
				{
					string str = streamReader.ReadLine();
					string str1 = str;
					if (str == null)
					{
						break;
					}
					if (strArrays1.Contains<string>(str1))
					{
						num = Convert.ToInt32(str1);
					}
					char[] chrArray = new char[] { ' ', '\t' };
					string[] strArrays2 = str1.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
					chrArray = new char[] { '\"' };
					string[] strArrays3 = str1.Split(chrArray);
					if ((str1.Length <= 2 || (int)strArrays3.Length <= 2 ? false : num >= 0))
					{
						object[] objArray = new object[] { num, "|", Convert.ToInt32(strArrays2[0]), "|", strArrays3[1] };
						strs.Add(string.Concat(objArray));
					}
				}
			}
			finally
			{
				if (streamReader != null)
				{
					((IDisposable)streamReader).Dispose();
				}
			}
			return strs;
		}
	}
}