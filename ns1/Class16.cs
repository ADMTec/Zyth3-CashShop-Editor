
namespace ns1
{
    using System;
    using System.Reflection;
    using System.Security.Cryptography;

    internal sealed class Class16 : IDisposable
    {
        private readonly object object_0;
        private readonly Type type_0 = Assembly.Load("mscorlib").GetType("System.Security.Cryptography.DESCryptoServiceProvider");

        public Class16()
        {
            this.object_0 = Activator.CreateInstance(this.type_0);
        }

        public ICryptoTransform method_0(byte[] byte_0, byte[] byte_1, bool bool_0)
        {
            this.type_0.GetProperty("Key").GetSetMethod().Invoke(this.object_0, new object[] { byte_0 });
            this.type_0.GetProperty("IV").GetSetMethod().Invoke(this.object_0, new object[] { byte_1 });
            return (ICryptoTransform)this.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]).Invoke(this.object_0, new object[0]);
        }

        public void method_1()
        {
            this.type_0.GetMethod("Clear").Invoke(this.object_0, new object[0]);
        }

        void IDisposable.Dispose()
        {
            this.method_1();
        }
    }
}

