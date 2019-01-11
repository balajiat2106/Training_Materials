using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Queues
    {
        class Program
        {
            static void Main1()
            {
                //Defines a Queue.
                Queue qObj = new Queue();

                //adding string values into collection
                qObj.Enqueue("Tom");
                qObj.Enqueue("Harry");
                qObj.Enqueue("Maria");
                qObj.Enqueue("john");

                //displaying collections
                while (qObj.Count != 0)
                {
                    Console.WriteLine(qObj.Dequeue());
                }

                Console.ReadKey();
            }
        }
    }
}
