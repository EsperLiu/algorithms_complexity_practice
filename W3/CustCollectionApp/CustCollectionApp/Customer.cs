//CAB301 - Workshop 3
//Maolin Tang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{
    class Customer
    {
        private string lastname;
        private string firstname;
        private int mobile;

        public string FirstName
        {
            get { return firstname; }
        }

        public string LastName
        {
            get { return lastname; }
        }

        public int Mobile
        {
            get { return mobile; }
        }

        public Customer(string lastName, string firstName, int mobileNumber)
        {
            this.lastname = lastName;
            this.firstname = firstName;
            this.mobile = mobileNumber;
        }

        public int CompareTo(Customer another)
        {
            if (this.lastname.CompareTo(another.LastName) < 0)
                return -1;
            else
                    if (this.lastname.CompareTo(another.LastName) == 0)
                return this.firstname.CompareTo(another.FirstName);
            else
                return 1;
        }


        public override string ToString()
        {
            return (firstname + " " + lastname + " " + mobile.ToString() + "\n");
        }
    }
}
