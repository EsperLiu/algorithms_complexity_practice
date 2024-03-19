//CAB301 - Workshop 3
//Maolin Tang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerCollection aCollection = new CustomerCollection();

            aCollection.Insert("Morris", "Scott", 11111111);
            aCollection.Insert("Turnbull", "Malcolm", 22222222);
            aCollection.Insert("Rudd", "Kevin", 33333333);
            aCollection.Insert("Gillard", "Julia", 44444444);
            aCollection.Insert("Howard", "John", 55555555);

            aCollection.Display();
            Console.WriteLine();

            int mobile = aCollection.Find("Rudd", "Kevin");
            Console.WriteLine("The mobile number of Kevin Rudd is " + mobile.ToString());
            Console.WriteLine();

            aCollection.Delete("Rudd", "Kevin");
            aCollection.Display();
            Console.WriteLine();

            Customer aCustomer = new Customer("Rudd", "Kevin", 33333333);
            aCollection.Insert(aCustomer);
            aCollection.Display();
            Console.WriteLine();
    
        }
    }
}
