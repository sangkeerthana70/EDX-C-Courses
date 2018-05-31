using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_abstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //connot create an instance of an abstract class
            //Employee newEmp = new Employee();
            //newEmp.login();

            Manager myManager = new Manager();
            myManager.Login();
            myManager.Hire();
        }
    }
}
