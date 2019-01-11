using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        class ParentClass
        {
            private string[] range = new string[5];
            public string this[int index]
            {
                get
                {
                    return range[index];
                }
                set
                {
                    range[index] = value;
                }
            }
        }
        class ChildClass
        {
            static void Main()
            {
                ParentClass pc = new ParentClass();
                pc[0] = "Mandala";
                pc[1] = "Vivek";
                pc[2] = "Ananda";
                pc[3] = "Swamy";
                pc[4] = "MVS";
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(pc[i]);
                }
            }
        }
    }
}
