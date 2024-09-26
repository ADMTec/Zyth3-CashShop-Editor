namespace ns3
{
    using ns1;
    using ns2;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Security.Cryptography;

    internal class Class17
    {
        private static bool smethod_0(Assembly assembly_0, Assembly assembly_1)
        {
            byte[] publicKey = assembly_0.GetName().GetPublicKey();
            byte[] buffer2 = assembly_1.GetName().GetPublicKey();
            if ((buffer2 == null) != (publicKey == null))
            {
                return false;
            }
            if (buffer2 != null)
            {
                for (int i = 0; i < buffer2.Length; i++)
                {
                    if (buffer2[i] != publicKey[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static byte[] smethod_1(byte[] byte_0)
        {
            Assembly callingAssembly = Assembly.GetCallingAssembly();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            if ((callingAssembly != executingAssembly) && !smethod_0(executingAssembly, callingAssembly))
            {
                return null;
            }
            Stream0 stream = new Stream0(byte_0);
            byte[] buffer = new byte[0];
            int num = stream.method_1();
            if (num == 0x4034b50)
            {
                short num2 = (short)stream.method_0();
                int num3 = stream.method_0();
                int num4 = stream.method_0();
                if ((((num != 0x4034b50) || (num2 != 20)) || (num3 != 0)) || (num4 != 8))
                {
                    throw new FormatException("Wrong Header Signature");
                }
                stream.method_1();
                stream.method_1();
                stream.method_1();
                int num5 = stream.method_1();
                int count = stream.method_0();
                int num7 = stream.method_0();
                if (count > 0)
                {
                    byte[] buffer2 = new byte[count];
                    stream.Read(buffer2, 0, count);
                }
                if (num7 > 0)
                {
                    byte[] buffer3 = new byte[num7];
                    stream.Read(buffer3, 0, num7);
                }
                byte[] buffer4 = new byte[stream.Length - stream.Position];
                stream.Read(buffer4, 0, buffer4.Length);
                Class18 class2 = new Class18(buffer4);
                buffer = new byte[num5];
                class2.method_2(buffer, 0, buffer.Length);
                buffer4 = null;
            }
            else
            {
                int num8 = num >> 0x18;
                num -= num8 << 0x18;
                if (num == 0x7d7a7b)
                {
                    switch (num8)
                    {
                        case 1:
                            {
                                int num12;
                                int num9 = stream.method_1();
                                buffer = new byte[num9];
                                for (int i = 0; i < num9; i += num12)
                                {
                                    int num11 = stream.method_1();
                                    num12 = stream.method_1();
                                    byte[] buffer5 = new byte[num11];
                                    stream.Read(buffer5, 0, buffer5.Length);
                                    new Class18(buffer5).method_2(buffer, i, num12);
                                }
                                break;
                            }
                        case 2:
                            {
                                byte[] buffer6 = new byte[] { 140, 0x95, 0x70, 0x4d, 0xe9, 1, 0x97, 0xbc };
                                byte[] buffer7 = new byte[] { 11, 10, 0x94, 0x45, 0xfc, 0xbc, 0x76, 0x70 };
                                using (Class16 class4 = new Class16())
                                {
                                    using (ICryptoTransform transform = class4.method_0(buffer6, buffer7, true))
                                    {
                                        buffer = smethod_1(transform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
                                    }
                                }
                                break;
                            }
                    }
                    if (num8 != 3)
                    {
                        goto Label_02A7;
                    }
                    byte[] buffer9 = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
                    byte[] buffer10 = new byte[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
                    using (Class15 class5 = new Class15())
                    {
                        using (ICryptoTransform transform2 = class5.method_0(buffer9, buffer10, true))
                        {
                            buffer = smethod_1(transform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
                        }
                        goto Label_02A7;
                    }
                }
                throw new FormatException("Unknown Header");
            }
            Label_02A7:
            stream.Close();
            stream = null;
            return buffer;
        }

        internal sealed class Class18
        {
            private bool bool_0;
            private Class17.Class19 class19_0 = new Class17.Class19();
            private Class17.Class20 class20_0 = new Class17.Class20();
            private Class17.Class21 class21_0;
            private Class17.Class21 class21_1;
            private Class17.Class22 class22_0;
            private static readonly int[] int_0 = new int[] {
                3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 0x11, 0x13, 0x17, 0x1b, 0x1f,
                0x23, 0x2b, 0x33, 0x3b, 0x43, 0x53, 0x63, 0x73, 0x83, 0xa3, 0xc3, 0xe3, 0x102
            };
            private static readonly int[] int_1 = new int[] {
                0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2,
                3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0
            };
            private static readonly int[] int_2 = new int[] {
                1, 2, 3, 4, 5, 7, 9, 13, 0x11, 0x19, 0x21, 0x31, 0x41, 0x61, 0x81, 0xc1,
                0x101, 0x181, 0x201, 0x301, 0x401, 0x601, 0x801, 0xc01, 0x1001, 0x1801, 0x2001, 0x3001, 0x4001, 0x6001
            };
            private static readonly int[] int_3 = new int[] {
                0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6,
                7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13
            };
            private int int_4 = 2;
            private int int_5;
            private int int_6;
            private int int_7;
            private int int_8;

            public Class18(byte[] byte_0)
            {
                this.class19_0.method_7(byte_0, 0, byte_0.Length);
            }

            private bool method_0()
            {
                int num = this.class20_0.method_4();
                while (num >= 0x102)
                {
                    int num2;
                    switch (this.int_4)
                    {
                        case 7:
                            goto Label_0052;

                        case 8:
                            goto Label_009E;

                        case 9:
                            goto Label_00EE;

                        case 10:
                            goto Label_0121;

                        default:
                            {
                                continue;
                            }
                    }
                    Label_0037:
                    this.class20_0.method_0(num2);
                    if (--num < 0x102)
                    {
                        return true;
                    }
                    Label_0052:
                    if (((num2 = this.class21_0.method_1(this.class19_0)) & -256) == 0)
                    {
                        goto Label_0037;
                    }
                    if (num2 < 0x101)
                    {
                        if (num2 < 0)
                        {
                            return false;
                        }
                        this.class21_1 = null;
                        this.class21_0 = null;
                        this.int_4 = 2;
                        return true;
                    }
                    this.int_6 = int_0[num2 - 0x101];
                    this.int_5 = int_1[num2 - 0x101];
                    Label_009E:
                    if (this.int_5 > 0)
                    {
                        this.int_4 = 8;
                        int num3 = this.class19_0.method_0(this.int_5);
                        if (num3 < 0)
                        {
                            return false;
                        }
                        this.class19_0.method_1(this.int_5);
                        this.int_6 += num3;
                    }
                    this.int_4 = 9;
                    Label_00EE:
                    num2 = this.class21_1.method_1(this.class19_0);
                    if (num2 < 0)
                    {
                        return false;
                    }
                    this.int_7 = int_2[num2];
                    this.int_5 = int_3[num2];
                    Label_0121:
                    if (this.int_5 > 0)
                    {
                        this.int_4 = 10;
                        int num4 = this.class19_0.method_0(this.int_5);
                        if (num4 < 0)
                        {
                            return false;
                        }
                        this.class19_0.method_1(this.int_5);
                        this.int_7 += num4;
                    }
                    this.class20_0.method_2(this.int_6, this.int_7);
                    num -= this.int_6;
                    this.int_4 = 7;
                }
                return true;
            }

            private bool method_1()
            {
                int num3;
                switch (this.int_4)
                {
                    case 2:
                        if (!this.bool_0)
                        {
                            int num = this.class19_0.method_0(3);
                            if (num < 0)
                            {
                                return false;
                            }
                            this.class19_0.method_1(3);
                            if ((num & 1) != 0)
                            {
                                this.bool_0 = true;
                            }
                            switch ((num >> 1))
                            {
                                case 0:
                                    this.class19_0.method_4();
                                    this.int_4 = 3;
                                    goto Label_00DA;

                                case 1:
                                    this.class21_0 = Class17.Class21.class21_0;
                                    this.class21_1 = Class17.Class21.class21_1;
                                    this.int_4 = 7;
                                    goto Label_00DA;

                                case 2:
                                    this.class22_0 = new Class17.Class22();
                                    this.int_4 = 6;
                                    goto Label_00DA;
                            }
                            break;
                        }
                        this.int_4 = 12;
                        return false;

                    case 3:
                        this.int_8 = this.class19_0.method_0(0x10);
                        if (this.int_8 >= 0)
                        {
                            this.class19_0.method_1(0x10);
                            this.int_4 = 4;
                            goto Label_010B;
                        }
                        return false;

                    case 4:
                        goto Label_010B;

                    case 5:
                        goto Label_0133;

                    case 6:
                        if (this.class22_0.method_0(this.class19_0))
                        {
                            this.class21_0 = this.class22_0.method_1();
                            this.class21_1 = this.class22_0.method_2();
                            this.int_4 = 7;
                            goto Label_01B7;
                        }
                        return false;

                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        goto Label_01B7;

                    case 12:
                        return false;

                    default:
                        return false;
                }
                Label_00DA:
                return true;
                Label_010B:
                if (this.class19_0.method_0(0x10) < 0)
                {
                    return false;
                }
                this.class19_0.method_1(0x10);
                this.int_4 = 5;
                Label_0133:
                num3 = this.class20_0.method_3(this.class19_0, this.int_8);
                this.int_8 -= num3;
                if (this.int_8 == 0)
                {
                    this.int_4 = 2;
                    return true;
                }
                return !this.class19_0.method_5();
                Label_01B7:
                return this.method_0();
            }

            public int method_2(byte[] byte_0, int int_9, int int_10)
            {
                int num = 0;
                goto Label_0048;
                Label_0004:
                if (!this.method_1() && ((this.class20_0.method_5() <= 0) || (this.int_4 == 11)))
                {
                    return num;
                }
                Label_0048:
                if (this.int_4 == 11)
                {
                    goto Label_0004;
                }
                int num2 = this.class20_0.method_6(byte_0, int_9, int_10);
                int_9 += num2;
                num += num2;
                int_10 -= num2;
                if (int_10 != 0)
                {
                    goto Label_0004;
                }
                return num;
            }
        }

        internal sealed class Class19
        {
            private byte[] byte_0;
            private int int_0 = 0;
            private int int_1 = 0;
            private int int_2 = 0;
            private uint uint_0 = 0;

            public int method_0(int int_3)
            {
                if (this.int_2 < int_3)
                {
                    if (this.int_0 == this.int_1)
                    {
                        return -1;
                    }
                    this.uint_0 |= (uint)(((this.byte_0[this.int_0++] & 0xff) | ((this.byte_0[this.int_0++] & 0xff) << 8)) << this.int_2);
                    this.int_2 += 0x10;
                }
                return (((int)this.uint_0) & ((((int)1) << int_3) - 1));
            }

            public void method_1(int int_3)
            {
                this.uint_0 = this.uint_0 >> int_3;
                this.int_2 -= int_3;
            }

            public int method_2()
            {
                return this.int_2;
            }

            public int method_3()
            {
                return ((this.int_1 - this.int_0) + (this.int_2 >> 3));
            }

            public void method_4()
            {
                this.uint_0 = this.uint_0 >> (this.int_2 & 7);
                this.int_2 &= -8;
            }

            public bool method_5()
            {
                return (this.int_0 == this.int_1);
            }

            public int method_6(byte[] byte_1, int int_3, int int_4)
            {
                int num = 0;
                while (this.int_2 > 0)
                {
                    if (int_4 <= 0)
                    {
                        break;
                    }
                    byte_1[int_3++] = (byte)this.uint_0;
                    this.uint_0 = this.uint_0 >> 8;
                    this.int_2 -= 8;
                    int_4--;
                    num++;
                }
                if (int_4 == 0)
                {
                    return num;
                }
                int num2 = this.int_1 - this.int_0;
                if (int_4 > num2)
                {
                    int_4 = num2;
                }
                Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
                this.int_0 += int_4;
                if (((this.int_0 - this.int_1) & 1) != 0)
                {
                    this.uint_0 = (uint)(this.byte_0[this.int_0++] & 0xff);
                    this.int_2 = 8;
                }
                return (num + int_4);
            }

            public void method_7(byte[] byte_1, int int_3, int int_4)
            {
                if (this.int_0 < this.int_1)
                {
                    throw new InvalidOperationException();
                }
                int num = int_3 + int_4;
                if (((0 > int_3) || (int_3 > num)) || (num > byte_1.Length))
                {
                    throw new ArgumentOutOfRangeException();
                }
                if ((int_4 & 1) != 0)
                {
                    this.uint_0 |= (uint)((byte_1[int_3++] & 0xff) << this.int_2);
                    this.int_2 += 8;
                }
                this.byte_0 = byte_1;
                this.int_0 = int_3;
                this.int_1 = num;
            }
        }

        internal sealed class Class20
        {
            private byte[] byte_0 = new byte[0x8000];
            private int int_0 = 0;
            private int int_1 = 0;

            public void method_0(int int_2)
            {
                if (this.int_1++ == 0x8000)
                {
                    throw new InvalidOperationException();
                }
                this.byte_0[this.int_0++] = (byte)int_2;
                this.int_0 &= 0x7fff;
            }

            private void method_1(int int_2, int int_3, int int_4)
            {
                while (int_3-- > 0)
                {
                    this.byte_0[this.int_0++] = this.byte_0[int_2++];
                    this.int_0 &= 0x7fff;
                    int_2 &= 0x7fff;
                }
            }

            public void method_2(int int_2, int int_3)
            {
                this.int_1 += int_2;
                if (this.int_1 > 0x8000)
                {
                    throw new InvalidOperationException();
                }
                int num = (this.int_0 - int_3) & 0x7fff;
                int num2 = 0x8000 - int_2;
                if ((num > num2) || (this.int_0 >= num2))
                {
                    this.method_1(num, int_2, int_3);
                }
                else if (int_2 > int_3)
                {
                    while (int_2-- > 0)
                    {
                        this.byte_0[this.int_0++] = this.byte_0[num++];
                    }
                }
                else
                {
                    Array.Copy(this.byte_0, num, this.byte_0, this.int_0, int_2);
                    this.int_0 += int_2;
                }
            }

            public int method_3(Class17.Class19 class19_0, int int_2)
            {
                int num;
                int_2 = Math.Min(Math.Min(int_2, 0x8000 - this.int_1), class19_0.method_3());
                int num2 = 0x8000 - this.int_0;
                if (int_2 > num2)
                {
                    num = class19_0.method_6(this.byte_0, this.int_0, num2);
                    if (num == num2)
                    {
                        num += class19_0.method_6(this.byte_0, 0, int_2 - num2);
                    }
                }
                else
                {
                    num = class19_0.method_6(this.byte_0, this.int_0, int_2);
                }
                this.int_0 = (this.int_0 + num) & 0x7fff;
                this.int_1 += num;
                return num;
            }

            public int method_4()
            {
                return (0x8000 - this.int_1);
            }

            public int method_5()
            {
                return this.int_1;
            }

            public int method_6(byte[] byte_1, int int_2, int int_3)
            {
                int num = this.int_0;
                if (int_3 > this.int_1)
                {
                    int_3 = this.int_1;
                }
                else
                {
                    num = ((this.int_0 - this.int_1) + int_3) & 0x7fff;
                }
                int num2 = int_3;
                int length = int_3 - num;
                if (length > 0)
                {
                    Array.Copy(this.byte_0, 0x8000 - length, byte_1, int_2, length);
                    int_2 += length;
                    int_3 = num;
                }
                Array.Copy(this.byte_0, num - int_3, byte_1, int_2, int_3);
                this.int_1 -= num2;
                if (this.int_1 < 0)
                {
                    throw new InvalidOperationException();
                }
                return num2;
            }
        }

        internal sealed class Class21
        {
            public static readonly Class17.Class21 class21_0;
            public static readonly Class17.Class21 class21_1;
            private short[] short_0;

            static Class21()
            {
                byte[] buffer = new byte[0x120];
                int num = 0;
                while (num < 0x90)
                {
                    buffer[num++] = 8;
                }
                while (num < 0x100)
                {
                    buffer[num++] = 9;
                }
                while (num < 280)
                {
                    buffer[num++] = 7;
                }
                while (num < 0x120)
                {
                    buffer[num++] = 8;
                }
                class21_0 = new Class17.Class21(buffer);
                buffer = new byte[0x20];
                num = 0;
                while (num < 0x20)
                {
                    buffer[num++] = 5;
                }
                class21_1 = new Class17.Class21(buffer);
            }

            public Class21(byte[] byte_0)
            {
                this.method_0(byte_0);
            }

            private void method_0(byte[] byte_0)
            {
                int[] numArray = new int[0x10];
                int[] numArray2 = new int[0x10];
                for (int i = 0; i < byte_0.Length; i++)
                {
                    int index = byte_0[i];
                    if (index > 0)
                    {
                        numArray[index]++;
                    }
                }
                int num3 = 0;
                int num4 = 0x200;
                for (int j = 1; j <= 15; j++)
                {
                    numArray2[j] = num3;
                    num3 += numArray[j] << (0x10 - j);
                    if (j >= 10)
                    {
                        int num6 = numArray2[j] & 0x1ff80;
                        int num7 = num3 & 0x1ff80;
                        num4 += (num7 - num6) >> (0x10 - j);
                    }
                }
                this.short_0 = new short[num4];
                int num8 = 0x200;
                for (int k = 15; k >= 10; k--)
                {
                    int num10 = num3 & 0x1ff80;
                    num3 -= numArray[k] << (0x10 - k);
                    int num11 = num3 & 0x1ff80;
                    for (int n = num11; n < num10; n += 0x80)
                    {
                        this.short_0[Class17.Class23.smethod_0(n)] = (short)((-num8 << 4) | k);
                        num8 += ((int)1) << (k - 9);
                    }
                }
                for (int m = 0; m < byte_0.Length; m++)
                {
                    int num14 = byte_0[m];
                    if (num14 != 0)
                    {
                        num3 = numArray2[num14];
                        int num15 = Class17.Class23.smethod_0(num3);
                        if (num14 <= 9)
                        {
                            do
                            {
                                this.short_0[num15] = (short)((m << 4) | num14);
                                num15 += ((int)1) << num14;
                            }
                            while (num15 < 0x200);
                        }
                        else
                        {
                            int num16 = this.short_0[num15 & 0x1ff];
                            int num17 = ((int)1) << (num16 & 15);
                            num16 = -(num16 >> 4);
                            do
                            {
                                this.short_0[num16 | (num15 >> 9)] = (short)((m << 4) | num14);
                                num15 += ((int)1) << num14;
                            }
                            while (num15 < num17);
                        }
                        numArray2[num14] = num3 + (((int)1) << (0x10 - num14));
                    }
                }
            }

            public int method_1(Class17.Class19 class19_0)
            {
                int num2;
                int index = class19_0.method_0(9);
                if (index >= 0)
                {
                    num2 = this.short_0[index];
                    if (num2 >= 0)
                    {
                        class19_0.method_1(num2 & 15);
                        return (num2 >> 4);
                    }
                    int num3 = -(num2 >> 4);
                    int num4 = num2 & 15;
                    index = class19_0.method_0(num4);
                    if (index >= 0)
                    {
                        num2 = this.short_0[num3 | (index >> 9)];
                        class19_0.method_1(num2 & 15);
                        return (num2 >> 4);
                    }
                    int num5 = class19_0.method_2();
                    index = class19_0.method_0(num5);
                    num2 = this.short_0[num3 | (index >> 9)];
                    if ((num2 & 15) <= num5)
                    {
                        class19_0.method_1(num2 & 15);
                        return (num2 >> 4);
                    }
                    return -1;
                }
                int num6 = class19_0.method_2();
                index = class19_0.method_0(num6);
                num2 = this.short_0[index];
                if ((num2 >= 0) && ((num2 & 15) <= num6))
                {
                    class19_0.method_1(num2 & 15);
                    return (num2 >> 4);
                }
                return -1;
            }
        }

        internal sealed class Class22
        {
            private byte[] byte_0;
            private byte[] byte_1;
            private byte byte_2;
            private Class17.Class21 class21_0;
            private static readonly int[] int_0 = new int[] { 3, 3, 11 };
            private static readonly int[] int_1 = new int[] { 2, 3, 7 };
            private int int_2;
            private int int_3;
            private int int_4;
            private int int_5;
            private int int_6;
            private int int_7;
            private int int_8;
            private static readonly int[] int_9 = new int[] {
                0x10, 0x11, 0x12, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2,
                14, 1, 15
            };

            public bool method_0(Class17.Class19 class19_0)
            {
                int num2;
                int num3;
                Label_0000:
                switch (this.int_2)
                {
                    case 0:
                        this.int_3 = class19_0.method_0(5);
                        if (this.int_3 < 0)
                        {
                            return false;
                        }
                        this.int_3 += 0x101;
                        class19_0.method_1(5);
                        this.int_2 = 1;
                        goto Label_01DD;

                    case 1:
                        goto Label_01DD;

                    case 2:
                        goto Label_018F;

                    case 3:
                        goto Label_0156;

                    case 4:
                        goto Label_00E1;

                    case 5:
                        break;

                    default:
                        goto Label_0000;
                }
                Label_002C:
                num3 = int_1[this.int_7];
                int num4 = class19_0.method_0(num3);
                if (num4 < 0)
                {
                    return false;
                }
                class19_0.method_1(num3);
                num4 += int_0[this.int_7];
                while (num4-- > 0)
                {
                    this.byte_1[this.int_8++] = this.byte_2;
                }
                if (this.int_8 == this.int_6)
                {
                    return true;
                }
                this.int_2 = 4;
                goto Label_0000;
                Label_00E1:
                while (((num2 = this.class21_0.method_1(class19_0)) & -16) == 0)
                {
                    this.byte_1[this.int_8++] = this.byte_2 = (byte)num2;
                    if (this.int_8 == this.int_6)
                    {
                        return true;
                    }
                }
                if (num2 < 0)
                {
                    return false;
                }
                if (num2 >= 0x11)
                {
                    this.byte_2 = 0;
                }
                this.int_7 = num2 - 0x10;
                this.int_2 = 5;
                goto Label_002C;
                Label_0156:
                while (this.int_8 < this.int_5)
                {
                    int num = class19_0.method_0(3);
                    if (num < 0)
                    {
                        return false;
                    }
                    class19_0.method_1(3);
                    this.byte_0[int_9[this.int_8]] = (byte)num;
                    this.int_8++;
                }
                this.class21_0 = new Class17.Class21(this.byte_0);
                this.byte_0 = null;
                this.int_8 = 0;
                this.int_2 = 4;
                goto Label_00E1;
                Label_018F:
                this.int_5 = class19_0.method_0(4);
                if (this.int_5 < 0)
                {
                    return false;
                }
                this.int_5 += 4;
                class19_0.method_1(4);
                this.byte_0 = new byte[0x13];
                this.int_8 = 0;
                this.int_2 = 3;
                goto Label_0156;
                Label_01DD:
                this.int_4 = class19_0.method_0(5);
                if (this.int_4 < 0)
                {
                    return false;
                }
                this.int_4++;
                class19_0.method_1(5);
                this.int_6 = this.int_3 + this.int_4;
                this.byte_1 = new byte[this.int_6];
                this.int_2 = 2;
                goto Label_018F;
            }

            public Class17.Class21 method_1()
            {
                byte[] destinationArray = new byte[this.int_3];
                Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_3);
                return new Class17.Class21(destinationArray);
            }

            public Class17.Class21 method_2()
            {
                byte[] destinationArray = new byte[this.int_4];
                Array.Copy(this.byte_1, this.int_3, destinationArray, 0, this.int_4);
                return new Class17.Class21(destinationArray);
            }
        }

        internal sealed class Class23
        {
            private static readonly byte[] byte_0 = new byte[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            private static readonly byte[] byte_1 = new byte[0x11e];
            private static readonly byte[] byte_2;
            private static readonly int[] int_0 = new int[] {
                0x10, 0x11, 0x12, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2,
                14, 1, 15
            };
            private static readonly short[] short_0 = new short[0x11e];
            private static readonly short[] short_1;

            static Class23()
            {
                int index = 0;
                while (index < 0x90)
                {
                    short_0[index] = smethod_0((0x30 + index) << 8);
                    byte_1[index++] = 8;
                }
                while (index < 0x100)
                {
                    short_0[index] = smethod_0((0x100 + index) << 7);
                    byte_1[index++] = 9;
                }
                while (index < 280)
                {
                    short_0[index] = smethod_0((-256 + index) << 9);
                    byte_1[index++] = 7;
                }
                while (index < 0x11e)
                {
                    short_0[index] = smethod_0((-88 + index) << 8);
                    byte_1[index++] = 8;
                }
                short_1 = new short[30];
                byte_2 = new byte[30];
                for (index = 0; index < 30; index++)
                {
                    short_1[index] = smethod_0(index << 11);
                    byte_2[index] = 5;
                }
            }

            public static short smethod_0(int int_1)
            {
                return (short)((((byte_0[int_1 & 15] << 12) | (byte_0[(int_1 >> 4) & 15] << 8)) | (byte_0[(int_1 >> 8) & 15] << 4)) | byte_0[int_1 >> 12]);
            }
        }

        internal sealed class Stream0 : MemoryStream
        {
            public Stream0(byte[] byte_0) : base(byte_0, false)
            {
            }

            public int method_0()
            {
                return (this.ReadByte() | (this.ReadByte() << 8));
            }

            public int method_1()
            {
                return (this.method_0() | (this.method_0() << 0x10));
            }
        }
    }
}

