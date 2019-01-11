using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Implementation
    {
        public interface ISomeInterface
        {
            int TestProperty
            {
                // No access modifier allowed here
                // because this is an interface.
                get;
            }
        }

        public class TestClass : ISomeInterface
        {
            public int TestProperty
            {
                // Cannot use access modifier here because
                // this is an interface implementation.
                get { return 10; }

                // Interface property does not have set accessor,
                // so access modifier is allowed.
                protected set { }
            }
        }
    }
}
