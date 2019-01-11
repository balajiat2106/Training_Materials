using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class SalesEmployee : Employee
    {
        protected int salesNumber;
        public SalesEmployee()
        { }
        public SalesEmployee(string fName, string lName, int age, int sNumber) : base(fName, lName, age)
        {
            this.salesNumber = sNumber;
        }
    }
}
