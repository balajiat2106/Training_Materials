using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Indexers
{
    abstract class AbstractIndexer
    {
        private string[] a = new string[5];
        public abstract string this[int index]
        {
            get;
            set;
        }
    }
    class DerivedClass : AbstractIndexer
    {
        private string[] b = new string[5];
        public override string this[int index]
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
    class IndexerTest
    {
        static void Main3()
        {
            DerivedClass dc = new DerivedClass();
            dc[0] = "132";
            dc[1] = "34";
            dc[2] = "43";
            dc[3] = "46";
            dc[4] = "87";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dc[i]);
            }
        }
    }
}
