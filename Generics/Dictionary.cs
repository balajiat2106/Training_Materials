using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Dictionary
    {
        public class Program
        {
            static void Main1()
            {
                //define Dictionary collection
                Dictionary<int, string> dObj = new Dictionary<int, string>(5);

                //add elements to Dictionary

                dObj.Add(1, "Tom");
                dObj.Add(2, "John");
                dObj.Add(3, "Maria");
                dObj.Add(4, "Max");
                dObj.Add(5, "Ram");

                //print data
                for (int i = 1; i <= dObj.Count; i++)
                {
                    string test = dObj[5];
                    Console.WriteLine(dObj[i]);
                }
                Console.ReadKey();
            }
        }
    }
}
