using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_abstractClasses
{
    class Manager : Employee
    {
        //decided to override the login method since Login method has virtual keyword making it optional to override.
        public override void Login()
        {
           Console.WriteLine("Manager Login");
        }

        //mandatory override of the Hire method which the abstract keyword means in Employee base class.
        public override void Hire()
        {
            Console.WriteLine("Hire Someone");
        }
        //private string department;
    }
}
