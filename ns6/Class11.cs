// Decompiled with JetBrains decompiler
// Type: ns6.Class11
// Assembly: Zyth3 CashShop Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51BCBBBC-B3EB-48EE-B08E-15ED8141915B
// Assembly location: D:\NDev\xTeam\Files\CashShopEditor_zTeam\CashShopEditor_zTeam\CashShopEditor_zTeam\CashShop Editor-cleaned.exe

using System;
using System.Security.Cryptography;

namespace ns6
{
    internal class Class11
    {
        public static bool smethod_0(string string_0, string string_1, string string_2)
        {
            try
            {
                char[] chArray = new char[1]
        {
          ':'
        };
                string[] strArray = string_2.Split(chArray);
                byte[] byte_0_1 = Convert.FromBase64String(strArray[0]);
                byte[] byte_0_2 = Convert.FromBase64String(strArray[1]);
                byte[] byte_0_3 = Convert.FromBase64String(strArray[2]);
                byte[] byte_1_1 = Class11.smethod_3(string_0, byte_0_1, 1000, byte_0_2.Length);
                byte[] byte_1_2 = Class11.smethod_3(string_1, byte_0_1, 1000, byte_0_3.Length);
                return Class11.smethod_2(byte_0_2, byte_1_1) && Class11.smethod_2(byte_0_3, byte_1_2);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool smethod_1(string string_0, string string_1)
        {
            try
            {
                char[] chArray = new char[1]
        {
          ':'
        };
                string[] strArray = string_1.Split(chArray);
                byte[] byte_0_1 = Convert.FromBase64String(strArray[0]);
                byte[] byte_0_2 = Convert.FromBase64String(strArray[3]);
                byte[] byte_1 = Class11.smethod_3(string_0, byte_0_1, 1000, byte_0_2.Length);
                return Class11.smethod_2(byte_0_2, byte_1);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static bool smethod_2(byte[] byte_0, byte[] byte_1)
        {
            uint num = (uint)(byte_0.Length ^ byte_1.Length);
            for (int index = 0; (index >= byte_0.Length ? 0 : (index < byte_1.Length ? 1 : 0)) != 0; ++index)
                num |= (uint)byte_0[index] ^ (uint)byte_1[index];
            return (int)num == 0;
        }

        private static byte[] smethod_3(string string_0, byte[] byte_0, int int_0, int int_1)
        {
            return new Rfc2898DeriveBytes(string_0, byte_0)
            {
                IterationCount = int_0
            }.GetBytes(int_1);
        }
    }
}
