using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Overriding
    {

        public class Parent
        {
            public virtual int TestProperty
            {
                // Notice the accessor accessibility level.
                protected set { }

                // No access modifier is used here.
                get { return 0; }
            }
        }
        public class Kid : Parent
        {
            public override int TestProperty
            {
                // Use the same accessibility level as in the overridden accessor.
                protected set { }

                // Cannot use access modifier here.
                get { return 0; }
            }
        }
    }
}
