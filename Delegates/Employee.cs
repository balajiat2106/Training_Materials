using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int Age;
        public Employee()
        { }
        public Employee(string fName, string lName, int age)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.Age = age;
        }

    }
}
