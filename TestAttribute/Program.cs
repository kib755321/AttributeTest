using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest
{
    class Program
    {
        private static ITest _Test;

        static void Main(string[] args)
        {
            Console.WriteLine("TestA ---- Attribute Value = A");

            _Test = new TestA();

            var t_AttributeValue = GetSomeValue(_Test);

            Console.WriteLine($"SomeAttribute.Value = {t_AttributeValue}");

            Console.WriteLine("TestB ---- Attribute Value = B");

            _Test = new TestB();

            t_AttributeValue = GetSomeValue(_Test);

            Console.WriteLine($"SomeAttribute.Value = {t_AttributeValue}");

            Console.Read();
        }

        static string GetSomeValue(ITest test)
        {
            var t_Type = test.GetType();

            var t_PropertyInfo = t_Type.GetProperty((nameof(ITest.Name)));

            SomeAttribute[] t_SomeAttribute = t_PropertyInfo.GetCustomAttributes(typeof(SomeAttribute), true) as SomeAttribute[];

            return t_SomeAttribute[0].Value;
        }
    }
}
