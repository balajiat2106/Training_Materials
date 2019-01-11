using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumNew;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;             // boxing  
            int j = (int)o;          // unboxing  
            Console.WriteLine("value of o object : " + o);
            Console.WriteLine("Value of j : " + j);
            Console.ReadLine();
            
        }
    }
}
