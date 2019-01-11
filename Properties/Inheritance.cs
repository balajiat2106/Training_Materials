using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class IndexerClass
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
    class IndexerDemo1 : IndexerClass
    {

    }
    class Indexer
    {
        static void Main2()
        {
            IndexerDemo1 id = new IndexerDemo1();
            id[0] = "Mandala";
            id[1] = "Vivek";
            id[2] = "Ananda";
            id[3] = "Swamy";
            id[4] = "MVS";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(id[i]);
            }
        }
    }
}
