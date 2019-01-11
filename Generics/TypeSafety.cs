using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TypeSafety
    {
        public static void test()
        {
            ArrayList obj = new ArrayList();
            obj.Add(50);
            obj.Add("Dog");
            obj.Add(new TestClass());

            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            test();
        }
    }
    public class TestClass
    {
        public TestClass()
        {
        }
    }
}
