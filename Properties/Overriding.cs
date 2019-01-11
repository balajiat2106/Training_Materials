using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class BaseClass
    {
        private string[] b = new string[5];
        public virtual string this[int index]
        {
            get
            {
                return b[index];
            }
            set
            {
                b[index] = value;
            }
        }
    }
    class DerivedClass : BaseClass
    {
        private string[] d = new string[10];
        public override string this[int index]
        {
            get
            {
                return d[index];
            }
            set
            {
                d[index] = value;
            }
        }
    }
    class IndexerTest
    {
        static void Main1()
        {
            BaseClass dc = new DerivedClass();
            dc[0] = "12";
            dc[1] = "23";
            dc[2] = "34";
            dc[3] = "45";
            dc[4] = "56";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dc[i]);
            }
        }
    }
}
