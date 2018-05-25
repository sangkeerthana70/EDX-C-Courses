using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_InheritanceDemo
{
    class Employee
    {
        //private member variables
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        //properties of Employee class
        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
    
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
