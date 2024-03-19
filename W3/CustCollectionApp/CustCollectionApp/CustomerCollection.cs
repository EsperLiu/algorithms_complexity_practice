//CAB301 - Workshop 3
//Maolin Tang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{
    class CustomerCollection
    {
        private Customer[] customers;
        private int noCustomers;

        public CustomerCollection()
        {
            customers = new Customer[10];
            noCustomers = 0;
        }

        public int Find(string lastname, string firstname)
        {
            Customer aCustomer = new Customer(lastname, firstname, 0);
            for (int i = 0; i < noCustomers; i++)
                if (customers[i].CompareTo(aCustomer) == 0)
                    return customers[i].Mobile;
            return 0;
        }

        public void Insert(string lastname, string firstname, int mobile)
        {
            Customer aCustomer = new Customer(lastname, firstname, mobile);
            customers[noCustomers] = aCustomer;
            noCustomers++;
        }

        public void Insert(Customer aCustomer)
        {
            customers[noCustomers] = aCustomer;
            noCustomers++;
        }

        public void Delete(string lastname, string firstname)
        {
            Customer aCustomer = new Customer(lastname, firstname, 0);
            int i = 0;
            while ((i < noCustomers) && (customers[i].CompareTo(aCustomer) != 0))
                i++;
            if (i == noCustomers)
                Console.WriteLine("The customer does not exist!");
            else
            {
                for (int j = i + 1; j < noCustomers; j++)
                    customers[j - 1] = customers[j];
                noCustomers--;
            }
        }

        public void Display()
        {
            for (int i = 0; i < noCustomers; i++)
                Console.Write(customers[i]);
        }

    }
}
