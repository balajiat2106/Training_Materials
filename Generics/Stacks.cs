using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Stacks
    {
        class Program
        {
            static void Main1()
            {
                int[] iArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //Define a stack
                Stack sObj = new Stack(iArray);

                Console.WriteLine("Total items=" + sObj.Count);

                //displaying collections
                for (int i = 0; i < sObj.Count; ++i)
                {
                    Console.WriteLine(sObj.Pop());
                }

                //sObj.Peek
                Console.ReadKey();
            }
        }
    }
}
