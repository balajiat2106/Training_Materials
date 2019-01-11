using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    abstract class PropertyBase
    {
        public abstract string X
        {
            get;
        }
    }
    class PropertyDerived : PropertyBase
    {
        public override string X
        {
            get
            {
                return "Derived Class";
            }
        }
    }
    class PropertyTest
    {
        static void Main1()
        {
            PropertyBase pb = new PropertyDerived();
            Console.WriteLine("pd.x=" + pb.X);
        }
    }
}
