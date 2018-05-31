using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_abstractClasses
{
    abstract class Employee//this example shows how we can optinally override a method or do it as mandatory within the class itself 
    {
        //method
        public virtual void Login()
        {
            Console.WriteLine("Employee Login");
        }
        //method
        //abstract keyword in  the method is to force sub classes to implement a method
        public abstract void Hire();//abstract class cannot have a body in it.

        public string empNumber;
        private string firstName;
        private string lastName;
        private string address;

    }
}
