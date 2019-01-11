using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class AutoImplemented
    {
        // This class is mutable. Its data can be modified from
        // outside the class.
        class Customer
        {
            // Auto-Impl Properties for trivial get and set
            private double testtotal = 10;
            private double TotalPurchases {
                get { return testtotal; }
                set { testtotal = value; } }
            private string Name { get; set; }
            private int CustomerID { get; set; }

            // Constructor
            public Customer(double purchases, string name, int ID)
            {
                TotalPurchases = purchases;
                Name = name;
                CustomerID = ID;
            }
            // Methods
            public string GetContactInfo() { return "ContactInfo"; }
            public string GetTransactionHistory() { return "History"; }

            // .. Additional methods, events, etc.
        }

        class ProgramTest
        {
            static void Main1()
            {
                // Intialize a new object.
                Customer cust1 = new Customer(4987.63, "Northwind", 90108);

                //Modify a property
                //cust1.TotalPurchases += 499.99;
            }


            //public string FirstName { get; set; } = "Jane";  
        }
    }
}
