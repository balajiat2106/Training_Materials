using Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covarience_Delegates
{
    public delegate Employee EmployeeDelegate();
    //a new  delegate pointing to methods returning SalesEmployee types.
    public delegate SalesEmployee SalesEmployeeDelegate();
    class Program
    {
        public static Employee GetEmployee()
        {
            return new Employee();
        }
        public static SalesEmployee GetSalesEmployee()
        {
            return new SalesEmployee();
        }
        static void Main2()
        {
            EmployeeDelegate empDel = new EmployeeDelegate(GetEmployee);
            Employee emp = empDel();
            SalesEmployeeDelegate salesEmpDel = new SalesEmployeeDelegate(GetSalesEmployee);
            SalesEmployee emp2 = salesEmpDel();
        }

        static void Main3()
        {
            EmployeeDelegate emp = new EmployeeDelegate(GetEmployee);
            Employee emp1 = emp();
            EmployeeDelegate empB = new EmployeeDelegate(GetSalesEmployee);
            //to obtain a derived type you must perform an explicit cast.
            SalesEmployee emp2 = (SalesEmployee)empB();
        }
    }
}
