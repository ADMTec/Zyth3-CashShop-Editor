using ns3;
using ns6;
using System;
using System.Collections.Generic;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ns4
{
    internal class Class5
    {
        private static Class10 class10_0;

        static Class5()
        {
            Class5.class10_0 = new Class10();
        }

        public Class5()
        {
        }

        public static bool smethod_0()
        {
            string str = Class5.smethod_3();
            string str1 = Regex.Replace(str, "[ -]", "");
            string[] strArrays = Regex.Replace(str, "[ ]", "").Split(new char[] { '-' });
            string str2 = Class5.class10_0.method_0("ActivationCode", null);
            Class11.smethod_0(str1, strArrays[1], str2);
            return true;
        }

        public static Dictionary<string, string> smethod_1()
        {
            Dictionary<string, string> strs = new Dictionary<string, string>();
            strs["License"] = Class5.class10_0.method_0("License", "Invalid License");
            strs["ActivationCode"] = Class5.class10_0.method_0("ActivationCode", null);
            strs["UserKey"] = Class5.smethod_3();
            return strs;
        }

        public static Dictionary<string, int> smethod_2()
        {
            Dictionary<string, int> strs = new Dictionary<string, int>();
            strs["DefaultInt"] = Class5.class10_0.method_1("DefaultInt", 0);
            return strs;
        }

        public static string smethod_3()
        {
            string empty;
            int i;
            string upper = Class5.smethod_4("Processor", "ProcessorId").ToUpper();
            if (upper.Length >= 12)
            {
                int numericValue = 0;
                string str = string.Empty;
                string str1 = upper;
                string str2 = "J21G16K5RX21";
                string str3 = "JGKRX";
                string[] strArrays = new string[] { "A", "B", "C", "D", "E", "F", "G" };
                string[] strArrays1 = strArrays;
                strArrays = new string[] { "1", "6", "2", "1", "5", "2", "1" };
                string[] strArrays2 = strArrays;
                for (i = 0; i < (int)strArrays1.Length; i++)
                {
                    str1 = str1.Replace(strArrays1[i], strArrays2[i]);
                }
                char[] charArray = str1.ToCharArray();
                for (int j = 0; j < (int)charArray.Length; j++)
                {
                    char chr = charArray[j];
                    numericValue = numericValue + (int)char.GetNumericValue(chr);
                }
                char[] chrArray = upper.ToCharArray();
                char[] charArray1 = upper.ToCharArray();
                Array.Reverse(charArray1);
                for (i = 0; i < (int)chrArray.Length / 2; i++)
                {
                    str = string.Concat(str, chrArray[i].ToString(), charArray1[i].ToString());
                }
                string str4 = string.Concat(upper.Substring(2, 1), numericValue.ToString("D2"));
                str = (str.Length < 16 ? string.Concat(str, str2).Substring(0, 16) : str.Substring(0, 16));
                strArrays = new string[] { str.Substring(0, 5), str.Substring(5, 5), str.Substring(10, 5) };
                string[] strArrays3 = strArrays;
                string empty1 = string.Empty;
                for (i = 0; i < str3.Length; i++)
                {
                    empty1 = string.Concat(empty1, str3.ToCharArray()[i].ToString(), strArrays3[2].ToCharArray()[i].ToString());
                }
                strArrays = new string[] { strArrays3[0], " - ", str4, " - ", strArrays3[1], " - ", empty1.Substring(0, 5), " - ", empty1.Substring(5) };
                empty = string.Concat(strArrays);
            }
            else
            {
                empty = string.Empty;
            }
            return empty;
        }

        private static string smethod_4(string string_0, string string_1)
        {
            string str;
            foreach (ManagementObject managementObject in (new ManagementObjectSearcher(string.Concat("Select * from Win32_", string_0))).Get())
            {
                try
                {
                    str = managementObject[string_1].ToString();
                    return str;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            str = "";
            return str;
        }
    }
}