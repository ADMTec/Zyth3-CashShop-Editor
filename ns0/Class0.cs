using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	internal class Class0
	{
		public Class0()
		{
		}

        [CompilerGenerated]
        private string string_0;

        [DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr GetActiveWindow();

        [CompilerGenerated]
        public string method_0()
        {
            return this.string_0;
        }

        [CompilerGenerated]
        public void method_1(string string_1)
        {
            this.string_0 = string_1;
        }
        public DialogResult method_2(IWin32Window iwin32Window_0)
		{
			IntPtr intPtr;
			Class0.Interface1 interface1;
			DialogResult dialogResult;
			string str;
			IntPtr intPtr1 = (iwin32Window_0 != null ? iwin32Window_0.Handle : Class0.GetActiveWindow());
			Class0.Interface0 class1 = (Class0.Interface0)(new Class0.Class1());
			try
			{
				if (!string.IsNullOrEmpty(this.method_0()))
				{
					uint num = 0;
					if (Class0.SHILCreateFromPath(this.method_0(), out intPtr, ref num) == 0 && Class0.SHCreateShellItem(IntPtr.Zero, IntPtr.Zero, intPtr, out interface1) == 0)
					{
						class1.imethod_9(interface1);
					}
				}
				class1.imethod_6(Class0.Enum1.flag_6 | Class0.Enum1.flag_17);
				uint num1 = class1.imethod_0(intPtr1);
				if (num1 == -2147023673)
				{
					dialogResult = DialogResult.Cancel;
				}
				else if (num1 == 0)
				{
					class1.imethod_17(out interface1);
					interface1.imethod_2(Class0.Enum0.const_2, out str);
					this.method_1(str);
					dialogResult = DialogResult.OK;
				}
				else
				{
					dialogResult = DialogResult.Abort;
				}
			}
			finally
			{
				Marshal.ReleaseComObject(class1);
			}
			return dialogResult;
		}

		[DllImport("shell32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int SHCreateShellItem(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, out Class0.Interface1 interface1_0);

		[DllImport("shell32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int SHILCreateFromPath(string string_1, out IntPtr intptr_0, ref uint uint_0);

		[Guid("DC1C5A9C-E88A-4dde-A5A1-60F82A20AEF7")]
		private class Class1
		{
			public extern Class1();
		}

		private enum Enum0 : uint
		{
			const_3 = 0,
			const_7 = 2147581953,
			const_1 = 2147647488,
			const_5 = 2147684353,
			const_0 = 2147794944,
			const_2 = 2147844096,
			const_8 = 2147909632,
			const_6 = 2147991553,
			const_4 = 2148007937
		}

		[Flags]
		private enum Enum1
		{
			flag_15 = 2,
			flag_19 = 4,
			flag_10 = 8,
			flag_17 = 32,
			flag_6 = 64,
			flag_0 = 128,
			flag_14 = 256,
			flag_1 = 512,
			flag_16 = 2048,
			flag_5 = 4096,
			flag_2 = 8192,
			flag_18 = 16384,
			flag_12 = 32768,
			flag_13 = 65536,
			flag_8 = 131072,
			flag_9 = 262144,
			flag_11 = 1048576,
			flag_4 = 33554432,
			flag_7 = 268435456,
			flag_3 = 536870912
		}

		[Guid("42f85136-db7e-439c-85f1-e4075d135fc8")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		private interface Interface0
		{
			uint imethod_0([In] IntPtr intptr_0);

			void imethod_1();

			void imethod_10(out Class0.Interface1 interface1_0);

			void imethod_11(out Class0.Interface1 interface1_0);

			void imethod_12([In] string string_0);

			void imethod_13(out string string_0);

			void imethod_14([In] string string_0);

			void imethod_15([In] string string_0);

			void imethod_16([In] string string_0);

			void imethod_17(out Class0.Interface1 interface1_0);

			void imethod_18(Class0.Interface1 interface1_0, int int_0);

			void imethod_19([In] string string_0);

			void imethod_2([In] uint uint_0);

			void imethod_20(int int_0);

			void imethod_21();

			void imethod_22();

			void imethod_23(IntPtr intptr_0);

			void imethod_24(out IntPtr intptr_0);

			void imethod_25(out IntPtr intptr_0);

			void imethod_3(out uint uint_0);

			void imethod_4();

			void imethod_5();

			void imethod_6([In] Class0.Enum1 enum1_0);

			void imethod_7(out Class0.Enum1 enum1_0);

			void imethod_8(Class0.Interface1 interface1_0);

			void imethod_9(Class0.Interface1 interface1_0);
		}

		[Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		private interface Interface1
		{
			void imethod_0();

			void imethod_1();

			void imethod_2([In] Class0.Enum0 enum0_0, out string string_0);

			void imethod_3();

			void imethod_4();
		}
	}
}